using EmployeeManagement.Application.Contract;
using EmployeeManagement.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Persistence.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployee
    {
        private readonly EmployeeDbContext _dbContext;

        public EmployeeRepository(EmployeeDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        
    }
}
