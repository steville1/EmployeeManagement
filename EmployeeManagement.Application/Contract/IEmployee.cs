using EmployeeManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Contract
{
    public interface IEmployee : IGenericRepository<Employee>
    {
    }
}
