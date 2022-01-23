using EmployeeManagement.Application.DTOs;
using EmployeeManagement.Application.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Features
{
    public interface IBusinessService
    {
        Task<Object> GetEmployeeById(int id);
        Task<Object> GetAllEmployee();
        Task<BaseCommandResponse> AddEmployee(EmployeeDto employeeDto);
        Task<BaseCommandResponse> UpdateEmployee(EmployeeDto employeeDto);
        Task<BaseCommandResponse> DeleteEmployee(EmployeeDto employeeDto);
        
    }
}
