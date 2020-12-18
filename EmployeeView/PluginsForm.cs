using EmployeeBusinessLogic.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeBusinessLogic;
using EmployeeBusinessLogic.BindingModel;

namespace EmployeeView
{
    public partial class PluginsForm : Form
    {

        public IEmployeeService employeeService { get; }
        public PluginManager manager { get; }


        public PluginsForm()
        {
            InitializeComponent();
        }

        public PluginsForm(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;
            InitializeComponent();
            manager = new PluginManager();
            if (manager.Headers.Count() != 0)
            {
                comboBoxPlugins.Items.AddRange(manager.Headers.ToArray());
                comboBoxPlugins.Text = comboBoxPlugins.Items[0].ToString();
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void UpdateData()
        {
            var employees = employeeService.Read(null);

            dataGridView.DataSource = employees;
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void buttonDoIt_Click(object sender, EventArgs e)
        {
            Func<EmployeeBindingModel, EmployeeBindingModel> action;
            manager.plgs.TryGetValue(comboBoxPlugins.Text, out action);
            if (dataGridView.SelectedRows.Count != 0) {
                var r = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                var empl = employeeService.Read(new EmployeeBindingModel { Id = r })[0];
                var employee = action.Invoke(new EmployeeBindingModel
                {
                    Id = empl.Id,
                    Name = empl.Name,
                    Surname = empl.Surname,
                    Patronymic = empl.Patronymic,
                    Position = empl.Position,
                    VacationStart = empl.VacationStart
                });
                employeeService.CreateOrUpdate(employee);
            }
            UpdateData();
        }

        /* private void buttonReport_Click(object sender, EventArgs e)
         {
             Action<IEnumerable<Unit>> temp;
             manager.report.TryGetValue(comboBoxPlugins.Text, out temp);
             List<Unit> units = new List<Unit>();
             units.Add(employeeService.Read(null)[controlDataTableRow1.SelectedRowIndex]);
             units.Add(employeeService.Read(null)[controlDataTableRow2.SelectedRowIndex]);
             temp.Invoke(units);
         }*/
    }
}
