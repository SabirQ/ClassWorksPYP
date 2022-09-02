using ConsoleApp10.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleApp10.Services
{
    public interface IGenericService<T> where T : class
    {
        //public List<T> SearchBooks(string search);
        //public List<T> FindByPagecount(int min, int max);
        public void RemoveAll(Func<T, bool> predicate);
        public List<T> FindAll(Func<T, bool> predicate);
        public void RemoveBy(Func<T, bool> predicate);
    }
}
