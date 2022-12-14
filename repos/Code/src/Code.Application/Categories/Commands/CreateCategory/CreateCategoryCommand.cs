using Code.Application.Common.Interfaces;
using Code.Domain.Entities;
using MediatR;

namespace Code.Application.Categories.Commands.CreateCategory
{
    public class CreateCategoryCommand:IRequest<int>
    {
        public string CategoryName { get; set; } = null!;
        public string? Description { get; set; }
    }
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateCategoryCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var entity = new Category
            {
                CategoryName = request.CategoryName,
                Description = request.Description
            };
            _context.Categories.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);
            return entity.Id;
        }
    }
}
