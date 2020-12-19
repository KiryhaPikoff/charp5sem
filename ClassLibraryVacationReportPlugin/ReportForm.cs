using EmployeeBusinessLogic.BindingModel;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibraryVacationReportPlugin
{
    public partial class ReportForm : Form
    {
        public ReportForm(EmployeeBindingModel employee)
        {
            InitializeComponent();
            reportViewer1.RefreshReport();
            ReportParameter repPar = new ReportParameter("EmployeeParameter", employee.Surname + " " + employee.Name + " " + employee.Patronymic + " c " + employee.VacationStart);
            reportViewer1.LocalReport.SetParameters(repPar);
            reportViewer1.RefreshReport();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {


        }
    }
}
