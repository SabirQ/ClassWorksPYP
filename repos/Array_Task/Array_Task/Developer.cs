using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Task
{
    public class Developer:Person
    {
        private double _experience;

        public double Experience
        {
            get { return _experience; }
            set {
                if (value>=0&&value<=132)
                {
                    _experience = value;
                }
                else
                {
                    Console.WriteLine("tecrube sehvdir");
                }
            }
                
        }
        public string Language { get; set; }
        public Developer(string name, string surname, int age, double experience, string language) : base(name, surname, age)
        {
            Experience = experience;
            Language = language;
        }
    }
}
