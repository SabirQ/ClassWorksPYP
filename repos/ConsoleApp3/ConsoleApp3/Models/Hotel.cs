using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
     public class Hotel
    {
        private Room[] _rooms;
        public string Name { get; set; }
        public Room[] Rooms { get => _rooms; set => _rooms = value;}
        public Hotel(string name)
        {
            Name = name;
            Rooms = new Room[0];
        }
        public void AddRoom(Room room)
        {
            Array.Resize(ref _rooms,Rooms.Length + 1);
            Rooms[Rooms.Length - 1] = room;
        }
        public void MakeReservation(int? id)
        {
            if (id==null||id==0)
            {
                throw new NotAvailableException("Is not available");
            }
            Room room = Array.Find(Rooms,x=>x.Id==id);
            if (room==null)
            {
                throw new NotAvailableException("Is not available");
            }
            if (!room.IsAvailable)
            {
                throw new NotAvailableException("Is not available");
            }
            room.IsAvailable = false;
            Console.WriteLine("Success");
        }
    }
}
