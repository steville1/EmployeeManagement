using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Application.Contract
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Add(T entity);
        Task<bool> Exists(int id);
        Task Update(T entity);
        Task Delete(T entity);
    }
}

