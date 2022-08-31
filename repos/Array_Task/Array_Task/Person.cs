using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Task
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        private int _age;

        public int Age
        {
            get { return _age; }
            set {
                if (value>=0&&value<=150)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Yash duz deyil");
                }
            }
        }
        public Person(string name,string surname,int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string GetFullname()
        {
            return Name + " " + Surname;
        }
    }
}
