using EmployeeBusinessLogic.BindingModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBusinessLogic.Service
{
    public interface IEmployeePlugin
    {
        string Name { get; }
        EmployeeBindingModel Handle(EmployeeBindingModel employee);
    }
}
