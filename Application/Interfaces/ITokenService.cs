﻿namespace ecommerce.Application.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(string userId, string username);
    }
}
