using AsyncClass.Models;
using System;
using System.Threading.Tasks;

namespace AsyncClass.Service
{
    internal class CoffeService
    {
        public static Coffe PourCoffe()
        {
            Console.WriteLine("Pouring coffe");
            return new Coffe();
        }
        public static async Task<Coffe> PourCoffeAsync()
        {
            Console.WriteLine("Pouring coffe");
            return new Coffe();
        }
    }
}
