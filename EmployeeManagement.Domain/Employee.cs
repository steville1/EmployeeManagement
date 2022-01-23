using EmployeeManagement.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Domain
{
    public class Employee : BaseDomainEntity
    {
        public string EmployeeName { get; set; }
        public string EmployeeState { get; set; }
        public string EmployeeAge { get; set; }
        public string EmployeePosition { get; set; }
    }
}
