using EmployeeBusinessLogic.repository.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace EmployeeBusinessLogic.ViewModel
{
    class EmployeeViewModel
    {

        public int Id { get; set; }

        [DisplayName("Имя")]
        public string Name { get; set; }

        [DisplayName("Фамилия")]
        public string Surname { get; set; }

        [DisplayName("Отчество")]
        public string Patronymic { get; set; }

        [DisplayName("Отпуск с")]
        public DateTime? VacationStart { get; set; }

        [DisplayName("Должность")]
        public Position Position { get; set; }
    }
}
