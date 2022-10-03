using MediatorPractise.DAL;
using MediatorPractise.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System.Globalization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace MediatorPractise.Mediatrs.AppUsers.Commands.Login
{
    public class LoginCommand:IRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class LoginCommandHandler : IRequestHandler<LoginCommand>
    {
        private readonly UserManager<AppUser> _userManager;

        public LoginCommandHandler(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<Unit> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            AppUser user=await _userManager.FindByNameAsync(request.Username);
            bool result=await _userManager.CheckPasswordAsync(user, request.Password);
            if (result) 
            { 

            } 
            else
            {
                throw new Exception("incorrect username and password");
            }
            return Unit.Value;
        }
    }
}

   

