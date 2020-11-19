using EmployeeBusinessLogic.BindingModel;
using EmployeeBusinessLogic.repository.models;
using EmployeeBusinessLogic.service;
using EmployeeBusinessLogic.ViewModel;
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
using WindowsFormsControlLibrary.Models;

namespace EmployeeView
{
    public partial class MainForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly IEmployeeService employeeService;

        public MainForm(IEmployeeService employeeService)
        {
            InitializeComponent();
            this.employeeService = employeeService;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }



        private void backupSaveButton_Click(object sender, EventArgs e)
        {
            var employees = employeeService.Read(null);
            xmlBackupComponent.saveData<EmployeeViewModel>("D:/1/2", employees.ToArray());
        }

        private void createEmployeeButton_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<CreateEmployeeForm>();
            form.ShowDialog();
            LoadData();
        }

        private void LoadData()
        {
            var employees = employeeService.Read(null);
            var treeInfo = new DataTreeNodeConfig();
            var nodeNames = new Queue<string>();
            nodeNames.Enqueue("name");
            nodeNames.Enqueue("surname");
            nodeNames.Enqueue("surname");
            nodeNames.Enqueue("surname");
            nodeNames.Enqueue("surname");
            nodeNames.Enqueue("surname");
            nodeNames.Enqueue("surname");
            nodeNames.Enqueue("surname");
            treeInfo.NodeNames = nodeNames;

            controlDataTreeTable.LoadTreeInfo(treeInfo);
            controlDataTreeTable.AddTable(employees);
        }

        private void positionWordButton_Click(object sender, EventArgs e)
        {

        }

        private void createJuniorBtn_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<CreateEmployeeForm>();
            form.Employee = employeeCreateComponent.createEmployee(Position.JUNIOR);
            form.ShowDialog();
            LoadData();
        }

        private void createMiddleBtn_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<CreateEmployeeForm>();
            form.Employee = employeeCreateComponent.createEmployee(Position.MIDDLE);
            form.ShowDialog();
            LoadData();
        }

        private void createSeniorBtn_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<CreateEmployeeForm>();
            form.Employee = employeeCreateComponent.createEmployee(Position.SENIOR);
            form.ShowDialog();
            LoadData();
        }
    }
}
