using ecommerce.Application.DTOs.Request;
using ecommerce.Domain.Entities;

namespace ecommerce.Application.Interfaces
{
    public interface IUserService
    {
        Task<Users> UserCreate(UserRequest userDTO);
    }
}
