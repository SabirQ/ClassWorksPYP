using MVCSignalR.Models;

namespace MVCSignalR.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAll();
    }
}
