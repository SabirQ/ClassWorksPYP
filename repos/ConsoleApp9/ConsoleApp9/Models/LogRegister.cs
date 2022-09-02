using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9.Models
{
    public static class LogRegister
    {
        public static void CreateUsername(string name, string surname, ref User user, List<User> users)
        {
            string username = $"{name.Trim().ToLower()}.{surname.Trim().ToLower()}";
            int count = 0;

            //if (users)
            //{
            for (int i = 0; i < users.Count;)
            {
                if (username == users[i].Username)
                {
                    Console.WriteLine("Name is same");
                    count++;
                    username = $"{name.Trim().ToLower()}.{surname.Trim().ToLower()}{count}";
                    i = 0;
                }
                else
                {
                    i++;
                }
            }

            user.Username = username;
        }
        public static void CreateEmail(string name, string surname, ref User user, List<User> users)
        {
            string email = $"{name.Trim().ToLower()}.{surname.Trim().ToLower()}@gmail.com";
            int count = 0;
            for (int i = 0; i < users.Count;)
            {
                if (email == users[i].Email)
                {
                    Console.WriteLine("Name is same");
                    count++;
                    email = $"{name.Trim().ToLower()}.{surname.Trim().ToLower()}{count}@gmail.com";
                    i = 0;
                }
                else
                {
                    i++;
                }
            }
            user.Email = email;
        } 
    }
}
