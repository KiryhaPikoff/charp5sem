using EmployeeBusinessLogic.repository.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeBusinessLogic.BindingModel
{
    public class EmployeeBindingModel
    {
        public int? Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public DateTime? VacationStart { get; set; }

        public Position Position { get; set; }
    }
}
