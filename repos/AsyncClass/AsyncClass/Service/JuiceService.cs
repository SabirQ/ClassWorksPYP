using AsyncClass.Models;
using System;
using System.Threading.Tasks;

namespace AsyncClass.Service
{
    internal class JuiceService
    {
        public static Juice ProurOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }
        public static async Task<Juice> ProurOJAsync()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }
    }
}
