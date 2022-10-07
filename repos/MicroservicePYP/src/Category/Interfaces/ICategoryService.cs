using MicroservicePYP.Category.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicePYP.Category.Interfaces
{
    public interface ICategoryService
    {
        Task CreateAsync(CategoryPostDto dto);
        Task<ICollection<CategoryGetDto>> GetAllAsync();
        Task<CategoryGetDto> GetAsync(int id);
        void DeleteAsync(int id);
    }
}
