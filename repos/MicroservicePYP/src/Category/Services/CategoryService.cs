using MicroservicePYP.Category.Dtos;
using MicroservicePYP.Category.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicePYP.Category.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }
        public Task CreateAsync(CategoryPostDto dto)
        {
            
        }

        public async void DeleteAsync(int id)
        {
           _repository.Remove(await _repository.GetByIdAsync(id));
        }

        public Task<ICollection<CategoryGetDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CategoryGetDto> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
