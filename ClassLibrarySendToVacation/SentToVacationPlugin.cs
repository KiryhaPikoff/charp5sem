using EmployeeBusinessLogic.BindingModel;
using EmployeeBusinessLogic.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySendToVacation
{
    [Export(typeof(IEmployeePlugin))]
    public class SentToVacationPlugin : IEmployeePlugin
    {
        public string Name => "VacationSender";

        public EmployeeBindingModel Handle(EmployeeBindingModel employee)
        {
            var form = new SendVacationForm();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                employee.VacationStart = form.Date;
            }
            return employee;
        }
    }
}
