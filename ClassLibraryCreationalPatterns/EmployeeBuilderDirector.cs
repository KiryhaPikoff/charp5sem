using EmployeeBusinessLogic.BindingModel;
using System;

namespace CreationalPatterns
{
    public class EmployeeBuilderDirector
    {
        public EmployeeBindingModel build(IEmployeeBuilder builder) {
            builder.setName();
            builder.setSurname();
            builder.setPatronymic();
            builder.setPosition();
            return builder.build();
        }
    }
}
