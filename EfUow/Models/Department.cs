namespace EfUow.Models
{
    public class Department : BaseEntity
    {
        public string? Name { get; set; }
        public List<Teacher>? Teachers { get; set; }
    }
}
