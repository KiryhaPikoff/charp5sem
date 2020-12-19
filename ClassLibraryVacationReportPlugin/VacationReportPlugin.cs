using EmployeeBusinessLogic.BindingModel;
using EmployeeBusinessLogic.Service;
using Microsoft.Office.Interop.Word;
using System;
using System.ComponentModel.Composition;
using System.IO;


namespace ClassLibraryVacationReportPlugin
{
    [Export(typeof(IEmployeePlugin))]
    public class VacationReportPlugin : IEmployeePlugin
    {
        public string Name => "VacationReport";

        public EmployeeBindingModel Handle(EmployeeBindingModel employee)
        {
            var repForm = new ReportForm(employee);
            repForm.Show();
            
            return employee;
        }
    }
}
