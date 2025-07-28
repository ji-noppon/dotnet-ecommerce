using Microsoft.AspNetCore.Identity;
using ecommerce.Application.DTOs.Request;
using ecommerce.Application.Interfaces;
using ecommerce.Domain.Interfaces;
using ecommerce.Domain.Entities;


namespace ecommerce.Application.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _repository;
        private readonly PasswordHasher<Users> _passwordHasher = new PasswordHasher<Users>();
        public UserService(IUserRepository userRepository) 
        {
            _repository = userRepository;
        }
        public async Task<Users> UserCreate(UserRequest userDTO)
        {
            var user = new Users
            {
                Email = userDTO.Email,
                UserName = userDTO.Username,
                FirstName = userDTO.Firstname,
            };
            user.Password = _passwordHasher.HashPassword(user, userDTO.Password);
            return await _repository.UserCreate(user);
        }
    }
}
