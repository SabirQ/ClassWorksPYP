using ConsoleApp10.Models;
using ConsoleApp10.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;

namespace ConsoleApp10.Repositories
{
    public abstract class GenericService<T> : IGenericService<T> where T : class
    {
        public List<T> list { get; set; }
        public GenericService(List<T> values)
        {
            list = values;
        }
        public List<T> FindAll(Func<T,bool> predicate)
        {
            if (predicate!=null) return list.Where(predicate).ToList();
            return list;
        }


        public void RemoveAll(Func<T, bool> predicate)
        {
            List<T> values = list.Where(predicate).ToList();
            list=list.Except(values).ToList();
        }
        public void RemoveBy(Func<T, bool> predicate)
        {
            T item = list.FirstOrDefault(predicate);

            if (item == null)
            {
                return;
            }
            list.Remove(item);
        }

        //public List<T> FindByPagecount(int min, int max)
        //{
        //    if (min <= 0 && max <= 0)
        //    {
        //        return null;
        //    }
        //    if (min > max)
        //    {
        //        int save = min;
        //        min = max;
        //        max = save;
        //    }
        //    List<Book> books = new List<Book>();
        //    books.AddRange((List<Book>)Books.FindAll(x => x.PageCount >= min && x.PageCount <= max));
        //    return books;
        //}

        //public List<T> SearchBooks(string search)
        //{
        //    List<Book> books = new List<Book>();
        //    books.AddRange(FindAllBooks(search));
        //    books.AddRange((List<Book>)Books.FindAll(x => x.AuthorName.ToLower().Contains(search.ToLower())));
        //    short num = 0;
        //    bool result = short.TryParse(search, out num);
        //    if (result)
        //    {
        //        books.AddRange((List<Book>)Books.FindAll(x => x.PageCount == num));
        //    }
        //    return books;
        //}
    }
}
