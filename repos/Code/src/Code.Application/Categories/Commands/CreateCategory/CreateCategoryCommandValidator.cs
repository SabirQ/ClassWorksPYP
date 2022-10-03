using Code.Application.Common.Interfaces;
using FluentValidation;
using FluentValidation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Application.Categories.Commands.CreateCategory
{
    public class DeleteCategoryCommandValidator:AbstractValidator<CreateCategoryCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteCategoryCommandValidator(IApplicationDbContext context)
        {
            _context = context;

            RuleFor(c => c.CategoryName)
                .NotEmpty().WithMessage("Category name is required")
                .MaximumLength(200).WithMessage("Less than 200 characters")
                .MustAsync(BeUniqueName).WithMessage("Exists");
        }
        public async Task<bool> BeUniqueName(string categoryName,CancellationToken cancellationToken)
        {
            return await _context.Categories.AllAsync(x => x.CategoryName != categoryName, cancellationToken);
        }
    }
}
