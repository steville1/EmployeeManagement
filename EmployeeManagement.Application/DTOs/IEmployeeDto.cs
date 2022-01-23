using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.DTOs
{
    public interface IEmployeeDto
    {
        public string EmployeeName { get; set; }
        public string EmployeeState { get; set; }
        public string EmployeeAge { get; set; }
        public string EmployeePosition { get; set; }
    }
}
