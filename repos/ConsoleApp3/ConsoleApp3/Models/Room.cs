using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    public class Room
    {
        private static int Count = 1;
        public int Id { get;}
        public string Name { get; set; }
        public decimal Price { get; set; }
        public byte PersonCapacity { get; set; }
        public bool IsAvailable { get; set; } = true;
        public Room(string name,decimal price,byte personCapacity)
        {
            Id = Count;
            Name = name;
            Price = price;
            PersonCapacity = personCapacity;
            Count++;
        }
        public string ShowInfo()
        {
            return $"Id: {Id},Name: {Name},Price: {Price}, Person Capacity: {PersonCapacity},Is Available: {IsAvailable}";
        }
        public override string ToString()
        {
            return ShowInfo();
        }
    }

}
