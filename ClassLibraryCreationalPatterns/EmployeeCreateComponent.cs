using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeBusinessLogic.BindingModel;
using EmployeeBusinessLogic.repository.models;
using CreationalPatterns;

namespace ClassLibraryCreationalPatterns
{
    public partial class EmployeeCreateComponent: Component
    {

        private readonly EmployeeBuilderDirector employeeBuilderDirector = new EmployeeBuilderDirector();

        public EmployeeBindingModel createEmployee(Position position)
        {
            switch (position) {
                case Position.JUNIOR: {
                    return employeeBuilderDirector.build(new JuniorBuilder());    
                }
                case Position.MIDDLE:
                {
                    return employeeBuilderDirector.build(new MiddleBuilder());
                }
                case Position.SENIOR:
                {
                    return employeeBuilderDirector.build(new SeniorBuilder());
                }

                default: return new EmployeeBindingModel();
            }
        }
    }
}
