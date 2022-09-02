using ConsoleApp10.Models;
using ConsoleApp10.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10.Repositories
{
    public class BookService : GenericService<Book>, IBookService
    {
        //private readonly Library _library;

        //public BookService(Library library)
        //{
        //    _library = library;
        //}
        public BookService(List<Book> books):base(books)
        {

        }
    }
}
