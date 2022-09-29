namespace ApiFirstLesson.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public List<Product> Products { get; set; }
    }
}
