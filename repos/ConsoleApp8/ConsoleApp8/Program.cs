//int a = 0;
//Test(out a);
//void Test(out int num)
//{
//    num = 5;
//}
//Console.WriteLine(a);

using System.Runtime.CompilerServices;

string str = "asd";

ToMail(ref str);
static void ToMail(ref string mail)
{
    mail= mail.Trim().Replace("a", "e").Replace("d", "t");
}
Console.WriteLine(str);
