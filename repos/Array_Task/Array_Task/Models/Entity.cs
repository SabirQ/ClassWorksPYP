using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Task.Models
{
    public abstract class Entity
    {
        public int Id { get; set; }
    }

    public class Person:Entity
    {
        public string FirsName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
    public class Category : Entity
    {
        public string CategoryName { get; set; } = null!;
        
    }
}
