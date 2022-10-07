using MicroservicePYP.Application.Repositories.Common;
using MicroservicePYP.Domain.Entities.BaseEntities;
using MicroservicePYP.Infrastructure.DAL;
using Microsoft.EntityFrameworkCore;
namespace MicroservicePYP.Category.Interfaces
{
    public interface ICategoryRepository: IRepository<MicroservicePYP.Domain.Entities.Category,AppDbContext>
    {
    }
}
