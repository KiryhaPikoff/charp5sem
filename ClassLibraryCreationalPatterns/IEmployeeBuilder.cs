using EmployeeBusinessLogic.BindingModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns
{
    public interface IEmployeeBuilder
    { 
        void setName();

        void setSurname();

        void setPatronymic();

        void setPosition();

        EmployeeBindingModel build();
    }
}
