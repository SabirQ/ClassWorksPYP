namespace MVC_example09_22.Models
{
    public class ProductImage
    {
        public string Name { get; set; }
        public string Alt { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
        public bool Primary { get; set; }
    }
}
