using ecommerce.Application.DTOs.Request;
using ecommerce.Application.DTOs.Response;

namespace ecommerce.Application.Interfaces
{
    public interface IAuthenService
    {
        Task<LoginResponse> Login(LoginRequest request);
    }
}
