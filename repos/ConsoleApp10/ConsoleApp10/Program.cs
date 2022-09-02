using ConsoleApp10.Models;
using ConsoleApp10.Repositories;
using System;
using System.Collections.Generic;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Harry", "Lima", 340);
            Book book1 = new Book("Lord of rings", "Kenan", 650);
            Book book2 = new Book("Skyrim", "Ali", 140);
            Book book3 = new Book("Ali ve Nino", "Avaz", 70);


           
            BookService service = new BookService(new List<Book>());
            service.list.Add(book);
            service.list.Add(book1);
            service.list.Add(book2);
            service.list.Add(book3);
          
            Console.WriteLine("pagecount ");
            foreach (var item in service.list.FindAll(x=>x.PageCount>=300&&x.PageCount<=700))
            {
                Console.WriteLine(item.PageCount);
            }
            Console.WriteLine("search ");
            //var searchedBooks = service.list.FindAll(x => x.Name.Contains("Ali") ||x.AuthorName.Contains("Ali"));
            foreach (var item in service.list.FindAll(x => x.Name.Contains("Ali") || x.AuthorName.Contains("Ali")))
            {
                Console.WriteLine(item.PageCount);
            }
            Console.WriteLine("all book:");
            foreach (var item in service.list.FindAll(x=>x.Name.Contains("ri")))
            {
                Console.WriteLine(item.Name);
            }
            service.RemoveBy(x => x.Code=="HA101");
            Console.WriteLine("removed by code;");
            foreach (var item in service.list)
            {
                Console.WriteLine(item.Code);
            }
            service.RemoveAll(x => x.Name.Contains("HA101"));
            Console.WriteLine("removed by Name;");
            foreach (var item in service.list)
            {
                Console.WriteLine(item.Name);
            }

            //Console.WriteLine("search reqem :");
            //foreach (var item in library.SearchBooks("140"))
            //{
            //    Console.WriteLine(item.PageCount);
            //}
            //Console.WriteLine("search string :");
            //foreach (var item in library.SearchBooks("Ali"))
            //{
            //    Console.WriteLine(item.Name);
            //}
        }
    }
}
