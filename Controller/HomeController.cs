using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EcommProj.Models;

namespace EcommProj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ModelContext _context;
        public HomeController(ModelContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }

     public IActionResult ProductPage()
        {
            return View();
        }
         public IActionResult Wishlist()
        {
            // Get wishlist from local storage (or session in server-side storage)
            //var wishlist = GetWishlistFromStorage();
            return View(); // Pass wishlist to the Wishlist view
        }

        // Helper method to fetch wishlist from localStorage or database
        //private List<Product> GetWishlistFromStorage()
        //{
        //    // You can retrieve the wishlist from session, a database, or localStorage
        //    var wishlistJson = Request.Cookies["wishlist"]; // Using cookies here as an example
        //    if (string.IsNullOrEmpty(wishlistJson))
        //        return new List<Product>(); // No wishlist, return an empty list

        //    // Deserialize the wishlist data into a List<Product>
        //    var wishlist = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Product>>(wishlistJson);
        //    return wishlist ?? new List<Product>();
        //}
        public IActionResult Cart()
        {
            return View();
        }
        public IActionResult Transaction()
        {
            return View();  

        }
        public IActionResult ThankYou()
        {
            return View();
        }
    }
}
