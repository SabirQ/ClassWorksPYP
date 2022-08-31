using ConsoleApp7;
using ConsoleApp7.Attributes;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

User user = new User("sabir", "sabir@gmail.com", "W123456a");
CheckProps(user);
Console.WriteLine(user.Email);
Console.WriteLine(user.Password);

bool CheckMail(string mail)
{
    Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
    if (!regex.IsMatch(mail))
    {
       return false;
    }
    else
    {
        return true;
    }
};
var prop=user.GetType().GetProperties().FirstOrDefault(x => x.IsDefined(typeof(ValidPassword)));
Console.WriteLine(prop.Name);
bool CheckPassword(string password)
{
    if (string.IsNullOrEmpty(password) || password.Length < 8)
    {
        return false;
    }
    bool check = false;
    bool check1 = false;
    bool check2 = false;
    if (Char.IsUpper(password[0]))
    {
        check2 = true;
    }
    for (int i = 0; i < password.Length; i++)
    {
        if (Char.IsDigit(password[i]))
        {
            check = true;
        }
        if (Char.IsLower(password[i]))
        {
            check1 = true;
        }

    }
    if (check == true && check1 == true && check2 == true)
    {
        return true;
    }
    else
    {
        return false;
    }
}

void CheckProps<T>(T entity) 
{
    var prop = user.GetType().GetProperties().FirstOrDefault(x => x.IsDefined(typeof(ValidEmail)));
    var prop1 = user.GetType().GetProperties().FirstOrDefault(x => x.IsDefined(typeof(ValidPassword)));
    if (prop != null)
    {
        if (CheckMail(prop.GetValue(entity).ToString()))
        {
            Console.WriteLine("Email Okay");
        }
        else
        {
            Console.WriteLine("Email is not correct");
        }
    }
    if (prop1 != null)
    {
        if (CheckPassword(prop1.GetValue(entity).ToString()))
        {
            Console.WriteLine("Pass okay");
        }
        else
        {
            Console.WriteLine("Pass wrong ");
        }
    }
}