using EmployeeBusinessLogic.BindingModel;
using EmployeeBusinessLogic.repository.models;
using EmployeeBusinessLogic.Service;
using System.ComponentModel.Composition;
using System.IO;

namespace ClassLibraryPositionPlugin
{
    [Export(typeof(IEmployeePlugin))]
    public class PositionPlugin : IEmployeePlugin
    {
        public string Name => "PositionPlugin";

        public EmployeeBindingModel Handle(EmployeeBindingModel employee)
        {
            var form = new UpdatePositionForm();
            if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                employee.Position = form.Position;
            }
            return employee;
        }
    }
}
