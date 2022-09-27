using Microsoft.AspNetCore.SignalR;
using Microsoft.Data.SqlClient;
using MVCSignalR.Models;
using System.Data;
using System.Xml.Linq;

namespace MVCSignalR.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IHubContext<SignalServer> _context;
        private readonly IConfiguration _configuration;

        public ProductRepository(IHubContext<SignalServer> context, IConfiguration configuration)
        {
           _context = context;
           _configuration = configuration;
        }
        public List<Product> GetAll()
        {
            var products =new List<Product>();
            using (SqlConnection connection=new SqlConnection(_configuration.GetConnectionString("default")))
            {
                if (connection.State == System.Data.ConnectionState.Closed) connection.Open();
                SqlDependency.Start(_configuration.GetConnectionString("default"));
                SqlCommand cmd = new SqlCommand("select * from Products", connection);
                SqlDependency dependency = new SqlDependency(cmd);
                dependency.OnChange += Dependency_OnChange;

                var reader=cmd.ExecuteReader();
                while (reader.Read())
                {
                    var product = new Product 
                    { 
                      Id=reader.GetInt32("id"),
                      ProductName=reader.GetString("ProductName"),
                      Description = reader.GetString("Description"),
                      UnitPrice =reader.GetDecimal("UnitPrice"),
                      UnitsInStock=reader.GetInt16("UnitsInStock")
                    };
                    products.Add(product);
                }
            }
            return products;
        }

        private void Dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            _context.Clients.All.SendAsync("refreshEmployees");
        }
    }
}
