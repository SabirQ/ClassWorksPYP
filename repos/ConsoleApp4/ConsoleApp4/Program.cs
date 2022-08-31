using ConsoleApp4.Attributes;
using ConsoleApp4.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine("Category item:");
        //    Category category = new Category();
        //    category=TypeValidator.GetInfoOfType(category);

        //    Product product = new Product();
        //    product = TypeValidator.GetInfoOfType(product);

        //    var properties = category.GetType().GetProperties();

        //    for (int i = 0; i < properties.Length; i++)
        //    {
        //        Console.WriteLine(properties[i].GetValue(category));
        //    }

        //    properties = product.GetType().GetProperties();
        //    Console.WriteLine("Category item:");
        //    for (int i = 0; i < properties.Length; i++)
        //    {
        //        Console.WriteLine(properties[i].GetValue(product));
        //    }


        //    Category result = TypeValidator.GenerateIns(new Category());
        //    Product result1 = TypeValidator.GenerateIns(typeof(Product));
        //    Console.WriteLine(result1.ProductName);



            //ch dosya
            //t4

           

        }
        public IEnumerable<string> GetColumnNames<T,A>(T entity,A attr)where A:Attribute
        {
            List<string> columnNames = new List<string>();
            foreach (PropertyInfo info in entity.GetType().GetProperties())
            {
                bool result = Attribute.IsDefined(info, typeof(A));
                if (result)
                {
                    ColumnName attrs =(ColumnName) info.GetCustomAttribute(typeof(ColumnName), false);
                    columnNames.Add(attrs.DisplayName ?? info.Name);
                }

            }
            return columnNames;
        }

    }
}
