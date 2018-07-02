using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebShopApp.Entities;

namespace WebShopApp.Services
{
    public class ProductRepository : IProductRepository
    {
        private ShopContext _context;

        public ProductRepository(ShopContext context)
        {
            _context = context;
        }

        public void AddProduct(Product product)
        {
            _context.Products.Add(product);
        }

        public void ChangeProductStockAmount(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products;
        }

        public IEnumerable<Product> GetAllChips()
        {
            return GetAll().Where(p => p.TypeOfProduct == "Chips");
        }

        public IEnumerable<Product> GetAllChocolates()
        {
            return GetAll().Where(p => p.TypeOfProduct == "Chocolates");
        }

        public IEnumerable<Product> GetAllLollies()
        {
            return GetAll().Where(p => p.TypeOfProduct == "Lollies");
        }

        public Product GetProductById(Guid id)
        {
            return GetAll().Where(p => p.Id == id).FirstOrDefault();
        }

        public void RemoveProduct(Product product)
        {
            _context.Products.Remove(product);
        }

        public bool Save()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
