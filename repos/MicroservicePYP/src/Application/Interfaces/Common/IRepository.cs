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
    public interface IRepository <T,U> where T : BaseEntity where U : DbContext
    {
        Task<T> AddAsync(T entity);
        Task<T> GetByIdAsync(int id);
        Task<ICollection<T>> GetAllAsync(Expression<Func<T, bool>> expression);
        void Remove(T entity);
    }
}
