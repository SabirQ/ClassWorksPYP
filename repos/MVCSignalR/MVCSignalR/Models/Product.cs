using System.ComponentModel.DataAnnotations.Schema;

namespace MVCSignalR.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public short UnitsInStock { get; set; }
        [Column(TypeName ="decimal(18,2)")]
        public decimal UnitPrice { get; set; }
    }
}
