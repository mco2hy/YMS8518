namespace Relationships.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string OpenAddress { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
