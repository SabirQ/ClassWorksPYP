using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Task.ClassTask
{
     public class Car:Vehicle
    {
        private int _fuelCapacity;
        private int _fuelFor1Km;
        private int _currentFuel;

        public string Brand { get; set; }
        public string Model { get; set; }
        public int FuelCapacity {
            get => _fuelCapacity;
            set 
            {
                if (value>=0)
                {
                   _fuelCapacity = value;
                }
                else
                {
                    Console.WriteLine("can not be below zero");
                }
            } 
        }
        public int FuelFor1Km
        {
            get => _fuelFor1Km;
            set
            {
                if (value >= 0)
                {
                    _fuelFor1Km = value;
                }
                else
                {
                    Console.WriteLine("can not be below zero");
                }
            }
        }
        public int CurrentFuel
        {
            get => _currentFuel;
            set
            {
                if (value >= 0)
                {
                    _currentFuel = value;
                }
                else
                {
                    Console.WriteLine("can not be below zero");
                }
            }
        }
        public Car(int year, string brand, string model,int capacity,int for1km):this(brand,year)
        {
            
            Model = model;
            FuelCapacity = capacity;
            FuelFor1Km = for1km;

        }
        public Car(string brand,int year):base(year)
        {
            Brand = brand;
        }
    }
}
