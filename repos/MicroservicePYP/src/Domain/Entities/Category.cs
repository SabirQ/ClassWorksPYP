using MicroservicePYP.Domain.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroservicePYP.Domain.Entities
{
    public class Category:BaseAuditable
    {
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
