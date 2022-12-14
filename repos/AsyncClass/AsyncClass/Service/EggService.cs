using AsyncClass.Models;
using System;
using System.Threading.Tasks;

namespace AsyncClass.Service
{
    internal class EggService
    {
        public static Egg FryEgg(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking eggs...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");
            return new Egg();
        }
        public static async Task<Egg> FryEggAsync(int howMany)
        {
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking eggs...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Put eggs on plate");
            return new Egg();
        }
    }
}
