namespace EfUow.Models
{
    public class Press : BaseEntity
    {
        public string? Name { get; set; }
        public List<Book>? Books { get; set; }
    }
}
