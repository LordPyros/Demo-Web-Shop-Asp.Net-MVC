using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WebShopApp
{
    // detect if cookies are disabled and warn user?


    // create a product detail page
    
    
    // add Error message (no items in cart) when in checkout with empty cart

    // add total value of items

    // add paypal option
    
    // make remove item from cart functional






    // Ideas for cart

    // when a page loads that displays the cart icon, check how many products are in the cookie and display that number




    // CHECKOUT PAGE

    // needs to check if theres anything in the cart
    // if nothing in cart display a message that the cart is empty
    // if cart not empty a table needs to be created with a row for each product

    // page needs to display a total price to be charged
    // page needs a paypal button
    // each item needs a remove button

    // delete cookie after all items checked out


    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
