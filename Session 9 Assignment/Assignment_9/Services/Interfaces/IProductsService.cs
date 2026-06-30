using Assignment_9.Models;

namespace Assignment_9.Services.Interfaces
{
      public interface IProductsService
      {
            IEnumerable<Product> GetProducts();
            Product? GetProductById(string id);
            string createProduct(Product product);
            string updateProduct(string id, Product updatedProduct);
            string deleteProduct(string id);
      }
}