using EmployeeBusinessLogic.BindingModel;
using EmployeeBusinessLogic.repository.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalPatterns
{
    public class MiddleBuilder : IEmployeeBuilder
    {
        private EmployeeBindingModel middle = new EmployeeBindingModel();

        public EmployeeBindingModel build()
        {
            return middle;
        }

        public void setName()
        {
            middle.Name = "Вася";
        }

        public void setPatronymic()
        {
            middle.Patronymic = "Мидлыч";
        }

        public void setPosition()
        {
            middle.Position = Position.MIDDLE;
        }

        public void setSurname()
        {
            middle.Surname = "Мидлов";
        }
    }
}
