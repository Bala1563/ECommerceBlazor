using ECommerceBlazor.Models;

namespace ECommerceBlazor.Services
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
        Task<Product> GetProductById(int productId);
    }
}