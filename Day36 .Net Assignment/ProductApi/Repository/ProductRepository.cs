using Microsoft.EntityFrameworkCore;
using ProductApi.Data;
using ProductApi.Models;

namespace ProductApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _dbContext;

        public ProductRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteProduct(int productId)
        {
            var product = _dbContext.Products.Find(productId);
            _dbContext.Products.Remove(product);
            Save();
        }

        public Products GetProductByID(int productId)
        {
            return _dbContext.Products.Find(productId);
        }

  

        public IEnumerable<Products> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public void InsertProduct(Products product)
        {
            _dbContext.Add(product);
            Save();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateProduct(Products product)
        {
            _dbContext.Entry(product).State = EntityState.Modified;
            Save();
        }

    }
}
