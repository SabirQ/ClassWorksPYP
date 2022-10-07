using MicroservicePYP.Application.Repositories.Common;
using MicroservicePYP.Category.Interfaces;
using MicroservicePYP.Domain.Entities;
using MicroservicePYP.Infrastructure.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicePYP.Category.Repositories
{
    public class CategoryRepository:Repository<MicroservicePYP.Domain.Entities.Category,AppDbContext>,ICategoryRepository
    {
        public CategoryRepository(AppDbContext context):base(context)
        {

        }
    }
}
