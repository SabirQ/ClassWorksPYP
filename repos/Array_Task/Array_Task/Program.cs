using Array_Task.ClassTask;
using Array_Task.Models;
using Array_Task.Polymorphism;
using System;
using System.Linq;

namespace Array_Task
{
    class Program
    {
        static void Main(string[] args)
        {


            //FirstClass firstClass = new FirstClass();
            //Console.WriteLine("Wrong:");
            //firstClass.Yas = 17;
            //firstClass.Yas = 22;
            //Console.WriteLine("Right:");
            //Console.WriteLine(firstClass.Yas);
            //Kedi kedi = new Kedi
            //{
            //    Tur = "Tekir",
            //    Renk = "siyah"
            //};
            //Kopek kopek = new Kopek { 
            //Renk="beyaz",
            //Tur="Golden"
            //};
            //Kus kus = new Kus();
            //kus.Renk = "Mavi";
            //kus.Tur = "shahin";
            //Console.WriteLine($"{typeof(Kedi).Name}->{kedi.Ses()}");
            //Console.WriteLine($"{typeof(Kopek).Name}->{kopek                   .Ses()}");
            //Console.WriteLine($"{typeof(Kus).Name}->{kus.Ses()}");




            //string[] names = { "Daniel", "David", "Ariel", "Daniel", "Ares" };
            //string[] names2 = { "John", "Jack" };
            //int[] numbers = { 1, 3, 5, 7, 9 };
            //int[] numbers2 = { 2, 4, 5, 7, 9 };
            #region 24.08

            //#region 1st Task
            ////1) bir dizi içerisinde bir eleman birden fazla olup olmadığını kontrol eden bir kod bloğu
            //Console.WriteLine("1st Task:");
            //string[] duplicates = names.Distinct().ToArray();
            //if (duplicates.Length != names.Length)
            //{
            //    Console.WriteLine("There are duplicates elements in array");
            //}
            //else
            //{
            //    Console.WriteLine("There are NOT duplicates elements");
            //}

            ////another way:
            //string[] duplicates2 = Array.FindAll(names, x => x == "Daniel");
            ////or:
            ////string[] duplicates = employees.Where(x => x == "Daniel").ToArray();
            //if (duplicates2.Length > 1)
            //{
            //    Console.WriteLine("There are more than one Daniel in array");
            //}
            //else
            //{
            //    Console.WriteLine("There is only one Daniel in array");
            //}
            //#endregion

            //#region 2nd Task
            ////2) dizi içerisinde bir elemanın var olup olmadığını kontrol ediniz, bu değer bool tipinde olacak
            //Console.WriteLine($"\n2nd Task:");
            //bool result = Array.Exists(names, x => x == "David");
            //Console.WriteLine($"Is there this element in array-->{result}");
            ////another way with int result:
            ////int index = Array.BinarySearch(names,"David");
            ////if (index < 0) Console.WriteLine("There is no David in array");
            //#endregion

            //#region 3rd Task
            ////3) içerisinde birden fazla eleman tanımladığınız dizi içerisindeki elemanları, for, foreach, while, do-while döngüsü kullanmadan ekrana yazdırınız
            //Console.WriteLine($"\n3rd Task:");
            //Array.ForEach(names, Console.WriteLine);
            ////another way:
            //string str = names.Aggregate((x, y) => x + "," + y);
            //Console.WriteLine(str);
            //#endregion

            //#region 4th Task
            ////4) metinsel bir dizi içerisindeki değerlerde, verdiğiniz değer ile başlayan tüm elemanları ekrana yazdırınız.
            //Console.WriteLine($"\n4th Task:");
            //Array.ForEach(Array.FindAll(names, x => x.StartsWith("Ar")), Console.WriteLine);
            //#endregion

            //#region 5th Task
            ////5) var olan 2 dizinin elemanlarını ekrana yazdırınız.
            //Console.WriteLine($"\n5th Task:");
            //string twoArrayStr = names.Aggregate((x, y) => x + "," + y) + "," + names2.Aggregate((x, y) => x + "," + y);
            //Console.WriteLine(twoArrayStr);

            //int[] combined = new int[numbers.Length + numbers2.Length];
            //Array.Copy(numbers, combined, numbers.Length);
            //Array.Copy(numbers2, 0, combined, numbers.Length, numbers2.Length);
            //Array.ForEach(combined, Console.WriteLine);
            //#endregion

            //#region 6th Task
            ////6) sayısal 2 dizi içerisinde yer alan farklı elemanları yeni bir diziye, aynı olanları yeni bir diziye ekleyiniz.
            //Console.WriteLine($"\n6th Task:");
            //int[] differences = numbers.Except(numbers2).ToArray().Concat(numbers2.Except(numbers)).ToArray();
            //int[] commons = numbers.Intersect(numbers2).ToArray();
            //Console.WriteLine("Different Elements:");
            //Array.ForEach(differences, Console.WriteLine);
            //Console.WriteLine("Same Elements:");
            //Array.ForEach(commons, Console.WriteLine);
            //#endregion

            //string[] sayilar = { "1", "2", "3" };
            //int[] numbers = Array.ConvertAll(sayilar, s => int.Parse(s));
            //Array.ForEach(numbers, Console.WriteLine);

            //int num = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            //while (num!=0)
            //{
            //    sum += num % 10;
            //    num = num / 10;
            //}
            //Console.WriteLine(sum);


            //string existUser = "admin";
            //string existPass = "123";
            //string username = string.Empty;
            //string password = string.Empty;
            //do
            //{
            //    Console.WriteLine("please enter username");
            //     username = Console.ReadLine().ToLower();
            //    Console.WriteLine("please enter password");
            //     password = Console.ReadLine();
            //} while (username!=existUser||existPass!=password);



            //for (int i = 0; i < 10; i++)
            //{
            //    if (i==0)
            //    {
            //        for (int j = 0; j < 10; j++)
            //        {
            //            Console.Write("x");
            //            Console.Write(" ");
            //        }
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        Console.Write("x");
            //        for (int j = 0; j < 17; j++)
            //        {
            //            Console.Write(" ");
            //        }
            //        Console.Write("x");
            //        Console.WriteLine();

            //    }

            //    if (i == 9)
            //    {
            //        for (int j = 0; j < 10; j++)
            //        {
            //            Console.Write("x");
            //            Console.Write(" ");
            //        }
            //    }
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("x ");
            //    for (int j = 0; j < 8; j++)
            //    {
            //        if (i==0||i==9)
            //        {
            //            Console.Write("x ");
            //        }
            //        else
            //        {
            //            Console.Write("  ");
            //        }
            //    }
            //    Console.Write("x");
            //    Console.WriteLine();
            //} 


            //foreach (int num in Enumerable.Range(1,100))
            //{
            //    Console.WriteLine(num);
            //}  
            //int[] arr = {40, 2, 66,3,-5 };

            //int count = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i]/10==0&&arr[i]>=0)
            //    {
            //        count++;
            //    }
            //}
            //Console.WriteLine(count);
            #endregion

            #region Task 1
            //Console.WriteLine("Task 1:");
            //for (int i = 0; i <= 100; i++)
            //{
            //    Console.WriteLine($"positive={i} and negative={i * (-1)}");
            //}
            #endregion

            #region Task 2
            //Console.WriteLine($"\nTask 2:");
            //Console.WriteLine("Please enter word you want to reverse:");
            //string str = Console.ReadLine();
            //1st Way
            //StringBuilder reverse = new StringBuilder();
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    reverse.Append(str[i]);
            //}
            //Console.WriteLine(reverse.ToString());

            //2nd Way
            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    Console.Write(str[i]);
            //}
            //Console.WriteLine();

            //3rd Way
            //char[] charArray = Console.ReadLine().Trim().ToCharArray();
            //Array.Reverse(charArray);
            //Console.WriteLine(charArray);

            #endregion

            #region Task 3
            //Console.WriteLine($"\nTask 3:");
            //for (int i = 10; i <= 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"# {i} eşittir 2 * {i / 2}");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine($"# {i} eşittir 3 * {i / 3}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"# {i} asal sayıdır");
            //    }
            //}
            #endregion

            #region Task 4
            //Console.WriteLine($"\nTask 4:");
            //int num;
            //string numStr;
            //string answer;
            //bool result;
            //int[] numbers = new int[0];
            //do
            //{
            //    Console.Write("Please enter number: ");
            //    numStr = Console.ReadLine();
            //    result = int.TryParse(numStr, out num);

            //} while (!result);
            //Array.Resize(ref numbers, numbers.Length + 1);
            //numbers[numbers.Length - 1] = num;
            //do
            //{
            //    Console.Write("Would you like to add more numbers?(y/any)");
            //    answer = Console.ReadLine().Trim().ToLower();
            //    if (answer == "y")
            //    {
            //        do
            //        {
            //            Console.Clear();
            //            Console.Write("Please enter number: ");
            //            numStr = Console.ReadLine();
            //            result = int.TryParse(numStr, out num);

            //        } while (!result);
            //        Array.Resize(ref numbers, numbers.Length + 1);
            //        numbers[numbers.Length - 1] = num;
            //    }
            //} while (answer == "y");

            //int[] odds = Array.FindAll(numbers, x => x % 2 != 0);
            //if (odds.Length > 1)
            //{
            //    Array.Sort(odds);
            //    Console.WriteLine($"Max from odds={odds[odds.Length - 1]} and Min from odds={odds[0]}");
            //    Console.WriteLine($"result: {odds[odds.Length - 1]}-{odds[0]}={odds[odds.Length - 1] - odds[0]}");
            //}
            //else if (odds.Length == 1)
            //{
            //    Console.WriteLine("There is only one odd number so result will be: 0  --> because Max and Min values are equal");
            //}
            //else
            //{
            //    Console.WriteLine("There is no odd number in array");
            //}

            //or another way:

            //int max = 0;
            //int min = 0;
            //int count = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 != 0)
            //    {
            //        count++;
            //        if (numbers[i] > max)
            //        {
            //            max = numbers[i];
            //        }
            //        if (count == 1)
            //        {
            //            min = numbers[i];
            //        }
            //        if (numbers[i] < min)
            //        {
            //            min = numbers[i];
            //        }
            //    }
            //}
            //if (max == 0 && min == 0)
            //{
            //    Console.WriteLine("There is no odd number in array");
            //}
            //else
            //{
            //    Console.WriteLine($"Max from odds={max} and Min from odds={min}");
            //    Console.WriteLine($"result: {max}-{min}={max - min}");
            //}
            #endregion


            //Digit Sum
            #region Keep 1
            //string str = Console.ReadLine();
            //int sum = 0;
            //for (int i = 0; i < str.Length; i++)
            //{
            //    sum += Convert.ToInt32(str[i].ToString());
            //}
            //Console.WriteLine(sum);
            #endregion

            //Ternary
            #region Keep 2
            //bool result = true;
            //Console.WriteLine($"Kayit ekleme ishlemi bashari{(result == true ? "li" : "siz")}");
            #endregion

            //Switch
            #region Keep 3
            //int num = 5;
            //switch (num)
            //{
            //    case int a when a > 100:
            //        break;
            //    case int a when a < 0:
            //        break;
            //    default:
            //        break;
            //}
            #endregion

            //Tuple
            #region Keep 4
            //(string username, string passord, bool result) userLogin = (string.Empty, string.Empty, true);
            //var tuple = Tuple.Create<string, string, bool>("", "", true);
            //Console.WriteLine(tuple.Item3);
            //Console.WriteLine(userLogin.result);
            #endregion

            //Console.Write("Name : ");
            //string name = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Surname : ");
            //string surname = Console.ReadLine();
            //Console.WriteLine();
            //Console.Write("Age : ");
            //int age =int.Parse( Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("Experience : ");
            //double experience = double.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.Write("Language : ");
            //string language = Console.ReadLine();
            //Console.WriteLine();
            //BackEnd backEnd = new BackEnd(name,surname,age,experience,language);
            //Console.WriteLine(backEnd.GetFullname());
            //Console.WriteLine(backEnd.Age);
        }
    }
}
