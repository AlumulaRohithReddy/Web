using System;
using ProductApi.Models;
namespace ProductApi.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetProducts();

Products GetProductByID(int ProductId);

void InsertProduct(Products Product);

void DeleteProduct(int ProductId);

void UpdateProduct(Products Product);

void Save();

    }
}
