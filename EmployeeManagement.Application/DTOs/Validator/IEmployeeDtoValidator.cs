using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.DTOs.Validator
{
    public class IEmployeeDtoValidator : AbstractValidator<IEmployeeDto>
    {
        public IEmployeeDtoValidator()
        {
            RuleFor(p => p.EmployeeName).NotEmpty().WithMessage("Employee Name Must Be Entered");
        }
    }
   
}
