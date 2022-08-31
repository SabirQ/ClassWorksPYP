using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    class NotAvailableException:Exception
    {
        public NotAvailableException(string message) : base(message) { }
       
    }
}
