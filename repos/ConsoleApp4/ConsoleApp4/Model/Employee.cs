using ConsoleApp4.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        [ColumnName]
        public string LastName { get; set; }

    }
}
