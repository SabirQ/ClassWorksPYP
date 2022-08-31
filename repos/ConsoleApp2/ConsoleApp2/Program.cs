using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Loop:
            Console.WriteLine("Please, enter product count:");
            string numStr = Console.ReadLine(); 
            int num;
            bool result = int.TryParse(numStr, out num);
            string[] products;
            if (result)
            {
                products = new string[num];
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("Please enter product name:");
                    string product = Console.ReadLine();
                    products[i] = product;
                }
                string yesNo;
                AddMore:
                do
                {
                    Console.WriteLine("Add more products?(y/n)");
                    yesNo = Console.ReadLine().ToLower();
                } while (yesNo!="n"&&yesNo!="y");
                if (yesNo=="y")
                {
                    do
                    {
                        Console.WriteLine("Please, enter product count:");
                        numStr = Console.ReadLine();
                        result = int.TryParse(numStr, out num);
                    } while (!result);
                    for (int i = 0; i < num; i++)
                    {
                        Console.WriteLine("Please enter product name:");
                        string product = Console.ReadLine();
                        Array.Resize(ref products, products.Length + 1);
                        products[products.Length - 1] = product;
                    }
                    goto AddMore;
                }
                for (int i = 0; i < products.Length; i++)
                {
                    Console.WriteLine(products[i]);
                }
            }
            else
            {
                Console.WriteLine("Value is not valid");
                goto Loop;
                
            }
           
           
            //int sum = 0;


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.ReadKey();
            //    sum += numbers[i];
            //    Console.WriteLine($"{numbers[i]}->{sum}");
            //}
            //Array.Resize(ref numbers, numbers.Length + 1);
            //numbers[numbers.Length - 1] = 4;
        }
    }
}
