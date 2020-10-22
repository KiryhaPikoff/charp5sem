using EmployeeBusinessLogic.BindingModel;
using EmployeeBusinessLogic.repository.models;
using EmployeeBusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBusinessLogic.service
{
    public interface IEmployeeService
    {

        void CreateOrUpdate(EmployeeBindingModel model);

        List<EmployeeViewModel> Read(EmployeeBindingModel filter);

        void Delete(EmployeeBindingModel model);
    }
}
