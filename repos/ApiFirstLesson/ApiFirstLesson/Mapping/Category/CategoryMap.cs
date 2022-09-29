using ApiFirstLesson.Dtos.CategoryDtos;
using AutoMapper;

namespace ApiFirstLesson.Mapping.Category
{
    public class CategoryMap:Profile
    {
        public CategoryMap()
        {
            CreateMap<Models.Category,CategoryDto>().ReverseMap();
            CreateMap<Models.Category, CategoryCreateDto>().ReverseMap();
        }
    }
}
