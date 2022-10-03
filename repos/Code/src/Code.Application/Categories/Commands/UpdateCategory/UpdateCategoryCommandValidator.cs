using Code.Application.Common.Interfaces;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Application.Categories.Commands.UpdateCategory
{
    internal class UpdateCategoryCommandValidator:AbstractValidator<UpdateCategoryCommand>
    {
        private readonly IApplicationDbContext _context;

        public UpdateCategoryCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(c => c.CategoryName)
              .NotEmpty().WithMessage("Category name is required")
              .MaximumLength(200).WithMessage("Less than 200 characters")
              .MustAsync(BeUniqueName).WithMessage("Exists");
        }
        public async Task<bool> BeUniqueName(UpdateCategoryCommand model,string categoryName, CancellationToken cancellationToken)
        {
            return await _context.Categories
                .Where(x=>x.Id!=model.Id)
                .AllAsync(x => x.CategoryName != categoryName, cancellationToken);
        }
    }
}
