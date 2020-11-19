using EmployeeBusinessLogic.BindingModel;
using EmployeeBusinessLogic.repository.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns
{
    public class JuniorBuilder : IEmployeeBuilder
    {
        private EmployeeBindingModel junior = new EmployeeBindingModel();

        public EmployeeBindingModel build()
        {
            return junior;
        }

        public void setName()
        {
            junior.Name = "Ждун";
        }

        public void setPatronymic()
        {
            junior.Patronymic = "Ждунович";
        }

        public void setPosition()
        {
            junior.Position = Position.JUNIOR;
        }

        public void setSurname()
        {
            junior.Surname = "Ждунов";
        }
    }
}
