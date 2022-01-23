using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.DTOs.Validator
{
    public class CreateEmployeeDtoValidator : AbstractValidator<EmployeeDto>
    {
        public CreateEmployeeDtoValidator()
        {
            Include(new IEmployeeDtoValidator());
        }
    }
}
