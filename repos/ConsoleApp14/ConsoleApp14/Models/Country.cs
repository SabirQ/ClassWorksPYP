using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14.Models
{
    public class Country
    {
          public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string ISO { get; set; }
        public string Capital { get; set; }
        public string Currency { get; set; }
        public string Continent { get; set; }
        public Country()
        {
            this.Id=Guid.NewGuid();
        }
    }
}
