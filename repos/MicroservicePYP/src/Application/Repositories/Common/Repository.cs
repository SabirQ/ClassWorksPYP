using MicroservicePYP.Domain.Entities.BaseEntities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicePYP.Application.Repositories.Common
{
    public class Repository<T, U> : IRepository<T, U> where T : BaseEntity where U : DbContext
    {
        public U _context { get; set; }

        public Repository(U context)
        {
            _context = context;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>> expression=null)
        {
            if (expression!=null)
            {
                return await _context.Set<T>().Where(expression).ToListAsync();
            }
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(x=>x.Id==id);
        }

        public async void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}
