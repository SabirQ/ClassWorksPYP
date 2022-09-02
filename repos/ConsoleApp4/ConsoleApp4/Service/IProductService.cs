using ConsoleApp4.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ConsoleApp4.Service
{
    public interface IProductService<Product> 
    {
        ICollection<Product> GetProducts();
        ICollection<Product> GetProducts(Func<Product, bool> predicate);
    }
    public class ProductService<product> : IProductService<Product> 
    {
        public ICollection<Product> GetProducts()
        {
            throw new NotImplementedException();
        }
        List<Product> products = new List<Product>();
        public ICollection<Product> GetProducts(Func<Product, bool> predicate)
        {
            
           var prop= products.Where(predicate);
            return null;
        }
    }
}
