using AsyncClass.Models;
using AsyncClass.Service;
using System;
using System.Threading.Tasks;

namespace AsyncClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Process is sync:");
           Coffe coffe= CoffeService.PourCoffe();
            Console.WriteLine("Coffe is ready");

            Egg egg = EggService.FryEgg(2);
            Console.WriteLine("eggs are ready");

            Bacon bacon = FryBaconService.FryBacon(3);
            Console.WriteLine("Bacon are ready");

            Toast toast = ToastService.ToastBread(2);
            Console.WriteLine("Toast is ready");

            Juice juice = JuiceService.ProurOJ();
            Console.WriteLine("OJ is ready");

            Console.WriteLine("Breakfast is ready");
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine(new String('_',50)+"\n");
            Console.ResetColor();


            Console.WriteLine("Process is async:");
            Task<Coffe> coffe1 = CoffeService.PourCoffeAsync();
            Console.WriteLine("Coffe is ready");

            Task<Egg> egg1 = EggService.FryEggAsync(2);
            Console.WriteLine("eggs are ready");

            Task<Bacon> bacon1 = FryBaconService.FryBaconAsync(3);
            Console.WriteLine("Bacon are ready");

            Task<Toast> toast1 = ToastService.ToastBreadAsync(2);
            Console.WriteLine("Toast is ready");

            Task<Juice> juice1 = JuiceService.ProurOJAsync();
            Console.WriteLine("OJ is ready");

            Console.WriteLine("Breakfast is ready");
        }
    }
}
