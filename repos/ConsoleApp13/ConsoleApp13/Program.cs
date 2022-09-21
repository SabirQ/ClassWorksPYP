//server=localhost,1433;database=Northwind;trusted_connection=true;" Microsoft.EntityFrameworkCore.SqlServer -o Models

using ConsoleApp13.Models;

northwindContext db= new northwindContext();
List<Customer> customers=db.Customers.ToList();

customers.ForEach(customer => Console.WriteLine(customer));


db.Categories.Add(new Category
{
    CategoryName = "Test Qadasi",
    Description = "Aciklama Alani"
});

List<Product> products = db.Products.Where(p => p.SupplierId == null).ToList();
Supplier supplier = db.Suppliers.FirstOrDefault();

foreach (var item in products)
{
    item.SupplierId = supplier.SupplierId;
}
//supplier.Products.ToList().AddRange(products);

bool result = db.SaveChanges() > 0;
Console.WriteLine(result);