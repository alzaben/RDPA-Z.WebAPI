using Microsoft.EntityFrameworkCore;
using RDPA_Z.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDPA_Z.EF.Repositories
{
    public class BaseRepositiory<T> : IBaseRepository<T> where T : class
    {
        private ApplicationDbContext _context;

        public BaseRepositiory(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<T> FindAll()
        {
            return _context.Set<T>().ToList();
        }

        public async Task<IEnumerable<T>> FindAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public  T FindById(int id)
        {
            return  _context.Set<T>().Find(id)!;
        }

        public async Task<T> FindByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id)!;
        }
        public T Post(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
