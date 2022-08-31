using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Task.Models
{
    public class FirstClass
    {
       public string Ad;
       public string Soyad;
        public string Mail { get; set; } = null!;//bosh gecilemez
        public string Telefon;
        int _yas;
        public int Yas {
            get => _yas;
            
            set 
            {
                if (value>=18&&value<=55)
                {
                    _yas = value;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
        }
        public double Boy;
    }
}
 