using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WebShopApp.Entities;
using WebShopApp.Models;
using WebShopApp.Services;

namespace WebShopApp.Controllers
{
    public class CheckoutController : Controller
    {

        private IProductRepository _productRepository;

        public CheckoutController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public IActionResult Index()
        {
            // get all products from repository
            var allProductsFromRepository = _productRepository.GetAll();

            var model = new ProductIndexModel();

            // read the cookie
            if (Request.Cookies["products"] != null)
            {
                // split the cookie value into string ids
                var cookieValueArray = Request.Cookies["products"].ToString().Split("_");

                // parse cookie strings into Guids (for better performance during the comparision below)
                List<Guid> cookieValues = new List<Guid>();
                foreach (string s in cookieValueArray)
                {
                    cookieValues.Add(Guid.Parse(s));
                }

                // Get a list of all products in cart 
                List<ProductDetailModel> productDetailModels = new List<ProductDetailModel>();
                foreach (Guid g in cookieValues)
                {
                    foreach (Product p in allProductsFromRepository)
                    {
                        if (g == p.Id)
                        {
                            ProductDetailModel pdm = new ProductDetailModel()
                            {
                                Id = p.Id,
                                Name = p.Name,
                                ImageUrl = p.ImageUrl,
                                Price = p.Price,
                                TypeOfProduct = p.TypeOfProduct
                            };

                            productDetailModels.Add(pdm);
                            break;
                        }
                    }
                }

                model.Products = productDetailModels;
                
                return View(model);
            }

            // if there is no cookie (nothing in cart) return an empty model
            return View(model);
        }

        // test method, not required
        public IActionResult RemoveFromCart(Guid id)
        {

            var model = new ProductIndexModel();

            return View(model);
        }
    }
}