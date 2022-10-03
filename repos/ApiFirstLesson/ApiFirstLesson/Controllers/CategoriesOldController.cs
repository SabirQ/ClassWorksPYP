using ApiFirstLesson.Data;
using ApiFirstLesson.Dtos.CategoryDtos;
using ApiFirstLesson.Models;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiFirstLesson.Controllers;



[ApiController]
[Route("api/[controller]")]
public class CategoriesOldController : ControllerBase
{
    private readonly AppDbContext _context;
    private readonly IMapper _mapper;

    public CategoriesOldController(AppDbContext context,IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }
    //[HttpGet]
    //  public async Task<IEnumerable<CategoryDto>> Get()
    //{
    //    var categories = _mapper.Map<IEnumerable<CategoryDto>>(await _context.Categories.ToListAsync());

    //    return categories;
    //}
    //[HttpGet("top-5")]

    //public async Task<IEnumerable<CategoryDto>> GetTop5()
    //{
    //    var categories = _mapper.Map<IEnumerable<CategoryDto>>(await _context.Categories.Take(5).ToListAsync());
    //    return categories;
    //}

    //[HttpPost]
    //public async Task<CategoryDto> Post(CategoryCreateDto dto)
    //{

    //    return new CategoryDto
    //    {
    //        CategoryId=11,
    //        CategoryName = dto.CategoryName,
    //        Description = dto.Description
    //    };
    
}
