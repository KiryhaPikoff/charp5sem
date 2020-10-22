using EmployeeBusinessLogic.BindingModel;
using EmployeeBusinessLogic.repository;
using EmployeeBusinessLogic.repository.models;
using EmployeeBusinessLogic.service;
using EmployeeBusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmployeeBusinessLogic.Service
{
    public class EmployeeService : IEmployeeService
    {
        public void CreateOrUpdate(EmployeeBindingModel model)
        {
            Employee employee;
            using (var context = new EmployeesDatabase())
            {
               
                if (model.Id.HasValue)
                {
                    employee = context.Employees.FirstOrDefault(rec => rec.Id == model.Id);
                    if (employee == null)
                    {
                        throw new Exception("Элемент не найден");
                    }
                }
                else
                {
                    employee = new Employee
                    {
                        Name = model.Name,
                        Surname = model.Surname,
                        Patronymic = model.Patronymic,
                        VacationStart = model.VacationStart,
                        Position = model.Position
                    };
                    context.Employees.Add(employee);
                    context.SaveChanges();
                    return;
                }
                employee.Name = model.Name;
                employee.Surname = model.Surname;
                employee.Patronymic = model.Patronymic;
                employee.VacationStart = model.VacationStart;
                employee.Position = model.Position;

                context.SaveChanges();
            }
        }

        public void Delete(EmployeeBindingModel model)
        {
            using (var context = new EmployeesDatabase())
            {
                var employee = context.Employees.FirstOrDefault(rec => rec.Id == model.Id);
                if (employee != null)
                {
                    context.Employees.Remove(employee);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Элемент не найден");
                }
            }
        }

        public List<EmployeeViewModel> Read(EmployeeBindingModel filter)
        {
            using (var context = new EmployeesDatabase())
            {
                return context.Employees
                .Where(rec => filter == null || rec.Id == filter.Id)
                .ToList()
               .Select(rec => new EmployeeViewModel
               {
                   Id = rec.Id,
                   Name = rec.Name,
                   Surname = rec.Surname,
                   Patronymic= rec.Patronymic,
                   Position = rec.Position,
                   VacationStart = rec.VacationStart
               })
               .ToList();
            }
        }
    }
}
