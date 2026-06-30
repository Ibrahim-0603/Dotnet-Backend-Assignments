using Assignment_9.Models;
using Assignment_9.Services.Interfaces;

namespace Assignment_9.Services
{
      public class ProductsService : IProductsService
      {
            private readonly List<Product> _products = new()
            {
                  new Product { Id = "1", Name = "Product 1", Price = 10.99m },
                  new Product { Id = "2", Name = "Product 2", Price = 19.99m },
                  new Product { Id = "3", Name = "Product 3", Price = 5.99m }
            };
            public IEnumerable<Product> GetProducts()
            {
                  return _products;
            }
            public Product? GetProductById(string id)
            {
                  return _products.FirstOrDefault(p => p.Id == id);
            }
            public string createProduct(Product product)
            {
                  var nextId = (_products.Count + 1).ToString();
                  product.Id = nextId;
                  _products.Add(product);
                  return nextId;
            }
            public string updateProduct(string id, Product updatedProduct)
            {
                  var product = _products.FirstOrDefault(p => p.Id == id);
                  if (product == null)
                  {
                        return null;
                  }
                  product.Name = updatedProduct.Name;
                  product.Price = updatedProduct.Price;
                  return product.Id;
            }
            public string deleteProduct(string id)
            {
                  var product = _products.FirstOrDefault(p => p.Id == id);
                  if (product == null)
                  {
                        return null;
                  }
                  _products.Remove(product);
                  return product.Id;
            }
      }
}