using ecommerce.Application.DTOs;
using ecommerce.Application.DTOs.Dto;
using ecommerce.Domain.Entities;

namespace ecommerce.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<Users> UserCreate(Users userDTO);
        Task<Users?> GetUserByUsername(string username);
        Task<Users?> UpdateUser(string username, UserUpdateDto updateDto);
    }
}
