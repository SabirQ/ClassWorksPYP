using Code.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.Application.Categories.Commands.DeleteCategory
{
    public record DeleteCategoryCommand : IRequest
    {
        public int Id { get; set; }
    }
    public class DeleteCategoryCommandHandler : IRequestHandler<DeleteCategoryCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteCategoryCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var existed =await _context.Categories.FirstOrDefaultAsync(x => x.Id == request.Id);
            if (existed == null)
            {
                throw new Exception("");
            }
            _context.Categories.Remove(existed);
            await _context.SaveChangesAsync(cancellationToken);
            return Unit.Value;
        }
    }
}
