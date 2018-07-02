using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopApp.Models
{
    public class ProductDetailModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int NumberInStock { get; set; }
        public string TypeOfProduct { get; set; }
        public string ImageUrl { get; set; }
    }
}
