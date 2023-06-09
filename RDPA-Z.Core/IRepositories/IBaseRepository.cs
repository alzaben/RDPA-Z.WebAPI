using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDPA_Z.Core.IRepositories
{
    public interface IBaseRepository<T> where T : class
    {       // sync
        T FindById(int id);
        T Post(T entity);
        

        IEnumerable<T> FindAll();

            // Async
        Task<T> FindByIdAsync(int id);
        Task<IEnumerable<T>> FindAllAsync();
    }
}
