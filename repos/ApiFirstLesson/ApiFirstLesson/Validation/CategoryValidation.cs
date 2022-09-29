using ApiFirstLesson.Dtos.CategoryDtos;
using FluentValidation;

namespace ApiFirstLesson.Validation
{
    public class CategoryValidation:AbstractValidator<CategoryCreateDto>
    {
        public CategoryValidation()
        {
            RuleFor(x=>x.CategoryName).Cascade(CascadeMode.Stop)  //nested klassi yoxlama menasinda
                .NotNull()
                .WithMessage("")
                .NotEmpty()
                .WithMessage("");
            
        }
    }
}
