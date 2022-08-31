using AsyncClass.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AsyncClass.Service
{
    class FryBaconService
    {
        public static Bacon FryBacon(int slice)
        {
            Console.WriteLine($"putting {slice} slices of bacon in the pan");
            Console.WriteLine($"cooking first side of bacon");
            Task.Delay(3000).Wait();
            for (int i = 0; i < slice; i++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second of bacon...");
            Task.Delay(3000).Wait();
            return new Bacon();
        }
        public static async Task<Bacon> FryBaconAsync(int slice)
        {
            Console.WriteLine($"putting {slice} slices of bacon in the pan");
            Console.WriteLine($"cooking first side of bacon");
            Task.Delay(3000).Wait();
            for (int i = 0; i < slice; i++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }
            Console.WriteLine("cooking the second of bacon...");
            Task.Delay(3000).Wait();
            return new Bacon();
        }
    }
}
