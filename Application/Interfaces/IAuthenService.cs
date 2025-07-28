using ecommerce.Application.DTOs.Request;

namespace ecommerce.Application.Interfaces
{
    public interface IAuthenService
    {
        Task<bool> Login(LoginRequest request);
    }
}
