using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp9.Models
{   public delegate void ErrorDelegate(string message);
    public delegate void CompanyDelegate(string name,string surname,ref User user, List<User> users);
    public class Company
    {
        public string Name { get; set; }
        public List<User> Users { get; set; }
        public Company(string name)
        {
            Name = name;
            Users = new List<User>();
        }

        public void Register()
        {
            ErrorDelegate error = new ErrorDelegate(LogError.Error);
            CompanyDelegate company = new CompanyDelegate(LogRegister.CreateUsername);
            company += LogRegister.CreateEmail;
            Name:
            Console.WriteLine("Name:");
            string name = Console.ReadLine().Trim();
            if (String.IsNullOrEmpty(name)) { error("Name is Empty or Null");
                goto Name; }
            if (name.Length < 3) { error("Name have to contains more than 2 letters");
                goto Name;
            }
            for (int i = 0; i < name.Length; i++)
            {
                if (!Char.IsLetter(name[i]))
                {
                    error("Name have to contains only letters");
                    goto Name;
                }
            }
            name=Capitalize(name);
        Surname:
            Console.WriteLine("Surname:");
            string surname = Console.ReadLine().Trim();
            if (String.IsNullOrEmpty(surname)) { error("Surname is Empty or Null");
                goto Surname;
            }
            if (surname.Length < 3) { error("Surname have to contains more than 2 letters");
                goto Surname;
            }
            for (int i = 0; i < surname.Length; i++)
            {
                if (!Char.IsLetter(surname[i]))
                {
                    error("Surname have to contains only letters");
                    goto Surname;
                }
            }
            surname = Capitalize(surname);
        Password:
            Console.WriteLine("Password:");
            string password = Console.ReadLine();
            if (String.IsNullOrEmpty(password)) { error("Password is Empty or Null");
                goto Password; }

            if (password.Length < 8) { error("Password is less than 8 characters");
                goto Password;
            }
            if (!Char.IsUpper(password[0])) { error("Password does not start with upper letter ");
                goto Password;
            }
            bool valid = false;
            bool valid2 = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (Char.IsDigit(password[i]))
                {
                    valid = true;
                }
                if (Char.IsLower(password[i]))
                {
                    valid2 = true;
                }
            }
            if (valid == false || valid2 == false) { error("Password does not contain digit or lower case ");
                goto Password;
            }
            User user =new User(name,surname,password);
            company.Invoke(name,surname,ref user,Users);
            Users.Add(user);
            Console.WriteLine($"Succesfully registered Username:{user.Username} Email:{user.Email}");
        }
        public void Login()
        {
            ErrorDelegate error = new ErrorDelegate(LogError.Error);
            Login:
            Console.WriteLine("Username:");
            string username=Console.ReadLine().Trim();
            Console.WriteLine("Password:");
            string password = Console.ReadLine().Trim();
            User user = null;
            foreach (User item in Users)
            {
                if (item.Username==username)
                {
                    user = item;
                }
            }
            if (user==null)
            {
                error("Yanlish username ve ya password");
                goto Login;
            }
            else
            {
                if (user.Password == password)
                {
                    Console.WriteLine("girish edildi");
                }
                else
                {
                    error("Yanlish username ve ya password");
                    goto Login;
                }
            }
        }
        public static string Capitalize(string item)
        {
            StringBuilder str = new StringBuilder();
            str.Append(Char.ToUpper(item[0]));
            for (int i = 1; i < item.Length; i++)
            {
                str.Append(Char.ToLower(item[i]));
            }
            return str.ToString();
        }
    }

}
