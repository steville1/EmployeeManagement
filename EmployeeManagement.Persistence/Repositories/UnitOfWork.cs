using EmployeeManagement.Application.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private EmployeeDbContext _context;
        private IEmployee _employee;
        
        public UnitOfWork(EmployeeDbContext context)
        {
            _context = context;
        }

        public IEmployee Employee
        {
            get
            {

                if (this._employee == null)
                {
                    this._employee = new EmployeeRepository(_context);
                }
                return _employee;
            }
        }
        
       
        public EmployeeDbContext Context
        {
            get
            {

                if (this._context == null)
                {
                    this._context = new EmployeeDbContext();
                }
                return _context;
            }

        }

        private bool disposed = false;
    }
}
