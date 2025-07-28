namespace ecommerce.Domain.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public string? Password { get; set; }
        public required string FirstName { get; set; }
        public string? Email { get; set; }
    }
}
