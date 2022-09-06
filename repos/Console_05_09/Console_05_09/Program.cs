using System;
using System.Linq;

namespace Console_05_09
{
    delegate void CusDel();
    internal class Program
    {
        static void Main(string[] args)
        {
            CusDel cusdel = new CusDel(AAA);


            Cre(cusdel);
        }
        public static void Cre(CusDel method)
        {
            method();
        }
        public static void AAA()
        {
            Console.WriteLine("Calishdi");
        }
    }
}
