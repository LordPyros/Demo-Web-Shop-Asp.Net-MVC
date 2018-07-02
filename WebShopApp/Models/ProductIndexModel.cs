using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebShopApp.Models
{
    public class ProductIndexModel
    {
        public IEnumerable<ProductDetailModel> Products { get; set; }
    }
}
