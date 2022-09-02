using ConsoleApp9.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company("Irshad");
            Console:
            Console.WriteLine( $"1:Register\n2:Login\n3:Show all users\n4:Get one User from Company\n6:Delete User\n\n0:Exit");
            string answer=Console.ReadLine().Trim();
            if (answer=="1")
            {
                Yes:
                company.Register();
                Console.WriteLine("Add more user?(Yes)");
                string str = Console.ReadLine();
                if (str.Trim().ToLower() == "yes")
                {
                    goto Yes;
                }
                else
                {
                    goto Console;
                }
            }
            else if (answer == "2")
            {
                company.Login();
                goto Console;
            }
            else if (answer=="3")
            {
                if (company.Users.Count<1)
                {
                    Console.WriteLine("There is no user in the company");
                    goto Console;
                }
                else
                {
                    foreach (var item in company.Users)
                    {
                        Console.WriteLine($"Id:{item.Id} Username:{item.Username} Email:{item.Email} Name:{item.Name} Surname:{item.Surname}");
                    }
                    goto Console;
                }
              
            }
            else if (answer == "4")
            {
                ID:
                int id=0;
                Console.WriteLine("Enter user Id:");
                string str = Console.ReadLine();
                bool result=int.TryParse(str, out id);
                if (!result)
                {
                    Console.WriteLine("Id is not valid");
                    goto ID;
                }
                User user=company.Users.FirstOrDefault(x=>x.Id==id);
                if (user==null)
                {
                    Console.WriteLine("There is no user with given Id");
                    goto ID;
                }
                Console.Clear();
                Console.WriteLine($"Id:{user.Id}\nName:{user.Name}\nSurname:{user.Surname}\nEmail:{user.Email}");
                Console.WriteLine("\n\nPress Any Key to return to Main menu:");
                Console.ReadKey();
                goto Console;
            }
            else if (answer == "6")
            {
                Delete:
                int id=0;
                Console.WriteLine("Enter user's Id whom you want to remove :");
                string str = Console.ReadLine();
                bool result = int.TryParse(str, out id);
                if (!result)
                {
                    Console.WriteLine("Id is not valid");
                    goto Delete;
                }
                User user = company.Users.FirstOrDefault(x => x.Id == id);
                if (user == null)
                {
                    Console.WriteLine("There is no user with given Id");
                    goto Delete;
                }
                company.Users.Remove(user);
                Console.WriteLine("Succesfully Removed");
                goto Console;
            }
            else if (answer=="0")
            {
                return;
            }
            else
            {
                goto Console;
            }
        }
    }
}
