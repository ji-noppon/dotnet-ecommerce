namespace ecommerce.Application.DTOs.Response
{
    public class UserResponse
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public string? Password { get; set; }
        public required string FirstName { get; set; }
        public required string LasttName { get; set; }
        public string? Email { get; set; }
    }
}
