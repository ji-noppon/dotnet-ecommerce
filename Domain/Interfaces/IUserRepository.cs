using ecommerce.Application.DTOs;
using ecommerce.Domain.Entities;

namespace ecommerce.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<Users> UserCreate(Users userDTO);
        Task<Users?> GetUserByUsername(string username);
    }
}
