namespace ecommerce.Application.DTOs.Dto
{
    public class UserUpdateDto
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? RefreshToken { get; set; }
    }
}
