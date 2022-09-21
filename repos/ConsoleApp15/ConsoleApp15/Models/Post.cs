using ConsoleApp15.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp15.Models
{
    public class Post : IEntity
    {
        public int Id { get ; set ; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
