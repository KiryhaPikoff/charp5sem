using EmployeeBusinessLogic.BindingModel;
using EmployeeBusinessLogic.repository.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns
{
    public class SeniorBuilder : IEmployeeBuilder
    {
        private EmployeeBindingModel senior = new EmployeeBindingModel();

        public EmployeeBindingModel build()
        {
            return senior;
        }

        public void setName()
        {
            senior.Name = "Сеньёр";
        }

        public void setPatronymic()
        {
            // without patronymic
        }

        public void setPosition()
        {
            senior.Position = Position.SENIOR;
        }

        public void setSurname()
        {
            senior.Surname = "Помидор";
        }
    }
}
