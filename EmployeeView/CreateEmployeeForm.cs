using EmployeeBusinessLogic.BindingModel;
using EmployeeBusinessLogic.repository.models;
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
using Unity;

namespace EmployeeView
{
    public partial class CreateEmployeeForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IEmployeeService employeeService;

        public EmployeeBindingModel Employee { 
            get { return Employee; }
            set {
                nameTextBox.Text = value.Name;
                surnameTextBox.Text = value.Surname;
                patronymicTextBox.Text = value.Patronymic;
                controlSelectedComboBoxEnum.SelectedItem = value.Position;
            } 
        }

        public CreateEmployeeForm(IEmployeeService employeeService)
        {
            InitializeComponent();
            this.employeeService = employeeService;
            controlSelectedComboBoxEnum.LoadEnum(typeof(Position));
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                employeeService.CreateOrUpdate(new EmployeeBindingModel
                {
                    Name = nameTextBox.Text,
                    Surname = surnameTextBox.Text,
                    Patronymic = patronymicTextBox.Text,
                    Position = (Position)controlSelectedComboBoxEnum.SelectedItem,
                    VacationStart = DateTime.Now
                }) ;
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
