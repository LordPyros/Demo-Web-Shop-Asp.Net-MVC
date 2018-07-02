using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShopApp.Models;
using WebShopApp.Services;

namespace WebShopApp.Controllers
{
    public class ProductsController : Controller
    {
        private IProductRepository _productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Chips()
        {
            return View();
        }

        public IActionResult Chocolates()
        {
            var allChocolates = _productRepository.GetAllChocolates();

            var productIndexModels = allChocolates.Select(result => new ProductDetailModel
            {
                Id = result.Id,
                Name = result.Name,
                Price = result.Price,
                ImageUrl = result.ImageUrl
            }).ToList();

            var model = new ProductIndexModel()
            {
                Products = productIndexModels
            };

            return View(model);
        }

        public IActionResult Lollies()
        {
            return View();
        }
    }
}