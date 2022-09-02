using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp10.Models
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public Library()
        {
            Books = new List<Book>();
        }

        //public List<Book> FindAllBooks(string name)
        //{
        //    return Books.FindAll(x=>x.Name.ToLower().Contains(name.ToLower())).ToList();
        //}
        //public void RemoveAllBooks(string name)
        //{

        //    Books.RemoveAll(x=>x.Name.ToLower().Contains(name.ToLower()));
        //}
        //public List<Book> SearchBooks(string search)
        //{
        //    List<Book> books = new List<Book>();
        //    books.AddRange(FindAllBooks(search));
        //    books.AddRange((List<Book>)Books.FindAll(x => x.AuthorName.ToLower().Contains(search.ToLower())));
        //    short num = 0;
        //    bool result=short.TryParse(search, out num);
        //    if (result)
        //    {
        //        books.AddRange((List<Book>)Books.FindAll(x => x.PageCount==num));
        //    }
        //    return books;
        //}
        //public List<Book> FindByPagecount(int min,int max)
        //{
        //    if (min<=0&&max<=0)
        //    {
        //        return null;
        //    }
        //    if (min>max)
        //    {
        //        int save=min;
        //        min= max;
        //        max= save; 
        //    }
        //    List<Book> books = new List<Book>(); 
        //    books.AddRange((List<Book>)Books.FindAll(x => x.PageCount>=min&&x.PageCount<=max));
        //    return books;
        //}
        //public void RemoveByCode(string name)
        //{
        //    Book book=Books.Find(x => x.Code==name);

        //    if (book==null)
        //    {
        //        return;
        //    }
        //    Books.Remove(book);
        //}
    }
}
