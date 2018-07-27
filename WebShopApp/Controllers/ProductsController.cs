using System.Linq;
using Microsoft.AspNetCore.Http;
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
            var allChips = _productRepository.GetAllChips();

            var productIndexModels = allChips.Select(result => new ProductDetailModel
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
            var allLollies = _productRepository.GetAllLollies();

            var productIndexModels = allLollies.Select(result => new ProductDetailModel
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


        // This method has been replaced by JavaScript
        [HttpPost]
        public IActionResult AddProductToCart(string cookievalue)
        {
            string cookieName = "Lollie Shop Cookie";
            // read cookie to see if there are existing cart items
            if (Request.Cookies["Lollie Shop Cookie"] != null)
            {
                // append new product Id to existing cookie
                Response.Cookies.Append(cookieName, Request.Cookies["Lollie Shop Cookie"] + "," + cookievalue);
                // need to split the string and count the number of items, then update the amount of items in cart text OR add 1 to amount of items in cart text
                // need to add the value of the new item to the existing value in the cart
                
                return RedirectToAction("Index", "Checkout");
            }
            else
            {
                // write a cookie            
                CookieOptions cookies = new CookieOptions();
                Response.Cookies.Append(cookieName, cookievalue);
                // Need to change amount of items in cart text to "1"
                // Need to change total price in cart text to whatever the selected products value


                return RedirectToAction("Index", "Checkout");
            }
        }
    }
}