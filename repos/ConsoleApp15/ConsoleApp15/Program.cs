using ConsoleApp15.Models;
using ConsoleApp15.Services;
using System;
using System.Net.Http;


namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HttpClientService<Post> http = new HttpClientService<Post>(new HttpClient());
            PostService postService = new PostService(new HttpClientService<Post>(new HttpClient()));

           
         

            Console:
            Console.Clear();
            Console.WriteLine("Program class\nMenu\n\n1. Get all posts\n2. Get post by Id\n\n0. Quit");
            string str=Console.ReadLine();
            if (str=="1")
            {
                Console.Clear();
                try
                {
                    var posts = postService.GetAllAsync().Result;
                    //var posts =http.GetAllAsync("posts").Result;

                    Console.WriteLine("List:");
                    foreach (var item in posts)
                    {
                        Console.WriteLine(item.Id);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    goto Console;
                }
                Console.WriteLine("\nPress any key to return menu:");
                Console.ReadKey();
                goto Console;
            }
            else if (str == "2")
            {
                Console.Clear();
                Id:
                Console.WriteLine("Please enter Id:");
                int num;
                string numStr=Console.ReadLine();
                bool result = int.TryParse(numStr, out num);
                if (!result)
                {
                    Console.Clear();
                    Console.WriteLine("Id is not valid try again");
                    goto Id;
                }
                else
                {
                    try
                    {
                        var post = postService.GetAsync(num).Result;
                        //var post = http.GetAsync("posts", 1).Result;
                        Console.WriteLine("Item:");
                        Console.WriteLine(post.UserId+" "+post.Title);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        goto Console;
                    }
                    Console.WriteLine("\nPress any key to return menu:");
                    Console.ReadKey();
                    goto Console;
                }
               
            }
            else if(str == "0")
            {
                return;
            }
            else
            {
                Console.Clear();
                goto Console;
            }
        }
    }
}
