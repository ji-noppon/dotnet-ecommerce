using ecommerce.Application.DTOs.Request;
using ecommerce.Application.Interfaces;
using ecommerce.Domain.Entities;
using ecommerce.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace ecommerce.Application.Services
{
    public class AuthenService: IAuthenService
    {
        private readonly IUserRepository _userRepository;
        private readonly PasswordHasher<Users> _passwordHasher = new PasswordHasher<Users>();
        public AuthenService(IUserRepository userRepository) 
        {
            _userRepository = userRepository;
        }

        public async Task<bool> Login(LoginRequest request)
        {
            try
            {
                var user = await _userRepository.GetUserByUsername(request.Username);
                if (user == null)
                {
                    return false;
                }

                if (VerifyPassword(user, request.Password))
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex) 
            {
                return false;
            }
         
        }
        public bool VerifyPassword(Users user, string inputPassword)
        {
            if (string.IsNullOrEmpty(user.Password))
            {
                return false;
            }
            var result = _passwordHasher.VerifyHashedPassword(user, user.Password, inputPassword);
            return result == PasswordVerificationResult.Success;
        }
    }
}
