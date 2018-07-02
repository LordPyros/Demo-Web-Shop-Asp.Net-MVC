using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopApp.Entities;

namespace WebShopApp.Services
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();

        IEnumerable<Product> GetAllLollies();
        IEnumerable<Product> GetAllChocolates();
        IEnumerable<Product> GetAllChips();

        Product GetProductById(Guid id);

        void AddProduct(Product product);
        void RemoveProduct(Product product);

        void ChangeProductStockAmount(Guid id);

        bool Save();

    }
}
