using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp10.Models
{
    public class Book
    {
        public static int Count = 100;
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public short PageCount { get; set; }
        public string Code { get;}
        public Book(string name, string authorName, short pageCount)
        {
            Count++;
            Name = name;
            AuthorName = authorName;
            PageCount = pageCount;
            if (name.Length<2)
            {
                Code = Char.ToUpper(name[0]).ToString() + Count.ToString();
            }
            else
            {
                Code =Char.ToUpper(name[0]).ToString()+ Char.ToUpper(name[1]).ToString()+ Count.ToString();
            }
        }
    }
}
