﻿using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using ProductsAPI.Data;
using ProductsAPI.Models;
using ProductsAPI.NewFolder;

namespace ProductsAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _dbContext;

        public ProductRepository(ProductContext dbcontext)
        {  
            _dbContext = dbcontext;
        }
        public void DeleteProduct(int productId)
        {
            var product = _dbContext.Products.Find(productId);

            _dbContext.Products.Remove(product);

            Save();
        }

        public Product GetProductById(int ProductId)
        {
            return _dbContext.Products.Find(ProductId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }

        public void InsertProduct(Product product)
        {
            _dbContext.Add(product);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            _dbContext.Entry(product).State=EntityState.Modified;
            Save();
        }
    }
}
