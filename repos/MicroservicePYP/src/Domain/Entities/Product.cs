using MicroservicePYP.Domain.Entities.BaseEntities;


namespace MicroservicePYP.Domain.Entities
{
    public class Product:BaseAuditable
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
