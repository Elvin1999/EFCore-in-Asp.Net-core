using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class ProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>()
        {
            new Product(){  ProductId=1, Category="Phone", Name="Samsung A7", Price=1000 },
            new Product(){  ProductId=2, Category="Phone", Name="Samsung A8", Price=1500 },
            new Product(){  ProductId=3, Category="Phone", Name="Samsung A9", Price=2000 },
            new Product(){  ProductId=4, Category="Phone", Name="Samsung A80", Price=3000 },
        }.AsQueryable();

        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int productid)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
