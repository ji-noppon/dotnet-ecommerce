using ecommerce.Application.DTOs.Dto;
using ecommerce.Application.DTOs.Request;
using ecommerce.Application.DTOs.Response;
using ecommerce.Application.Interfaces;
using ecommerce.Domain.Entities;
using ecommerce.Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography;

namespace ecommerce.Application.Services
{
    public class AuthenService: IAuthenService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;
        private readonly PasswordHasher<Users> _passwordHasher = new PasswordHasher<Users>();
        public AuthenService(IUserRepository userRepository, ITokenService tokenService) 
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }

        public async Task<LoginResponse?> Login(LoginRequest request)
        {
            try
            {
                var user = await _userRepository.GetUserByUsername(request.Username);
                if (user == null || !VerifyPassword(user, request.Password))
                {
                    return null;
                }

                var accessToken = _tokenService.GenerateToken(user.Id.ToString(), user.Username);
                var refreshToken = GenerateRefreshToken();

                var updateUserDto = new UserUpdateDto
                {
                    RefreshToken = refreshToken,
                };
                await _userRepository.UpdateUser(request.Username, updateUserDto);

                var response = new LoginResponse
                {
                    AccessToken = accessToken,
                    RefreshToken = refreshToken,
                };
                return response;
            }
            catch (Exception ex) 
            {
                return null;
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
        public string GenerateRefreshToken()
        {
            var randomBytes = new byte[64];
            using var rng = RandomNumberGenerator.Create();
            rng.GetBytes(randomBytes);
            return Convert.ToBase64String(randomBytes);
        }
    }
}
