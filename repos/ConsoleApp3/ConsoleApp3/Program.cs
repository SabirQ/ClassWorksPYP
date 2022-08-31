using ConsoleApp3.Models;
using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Room room = new Room("312B", 20.3m, 4);
            Room room2 = new Room("412a", 10.3m, 3);
            Hotel hotel = new Hotel("Bulvar");
            hotel.AddRoom(room);
            hotel.AddRoom(room2);
            try
            {
                hotel.MakeReservation(null);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
           
            }
           
            try
            {
                hotel.MakeReservation(5);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
            hotel.MakeReservation(2);
            Console.WriteLine(room);
            Console.WriteLine(room2);
        }

        
    }
}
