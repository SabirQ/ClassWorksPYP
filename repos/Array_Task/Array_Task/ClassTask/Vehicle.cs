using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Task.ClassTask
{
    public class Vehicle
    {
        private int  _year;

        public string Color { get; set; }
        public int Year
        {

            get => _year;

            set
            {
                if (value>=1900&&value<=2022)
                {
                    _year = value;
                }
                else
                {
                    Console.WriteLine("Wrong");
                }
            } 
        }
        public Vehicle(int year)
        {
            Year = year;
        }
    }
}
