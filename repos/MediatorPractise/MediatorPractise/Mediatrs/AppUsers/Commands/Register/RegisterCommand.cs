using MediatorPractise.DAL;
using MediatR;

namespace MediatorPractise.Mediatrs.AppUsers.Commands.Register
{
    public class RegisterCommand:IRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    public class RegisterCommandHandler : IRequestHandler<RegisterCommand>
    {
        private readonly AppDbContext _context;

        public RegisterCommandHandler(AppDbContext context)
        {
            _context = context;
        }
        public Task<Unit> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
