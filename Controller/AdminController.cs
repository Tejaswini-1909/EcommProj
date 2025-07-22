using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EcommProj.Models;
using Microsoft.AspNetCore.Http;

namespace EcommProj.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            //var product = _context.Products.Find(id);
            return View(); // You must create Edit.cshtml
        }

        //[HttpPost]
        //public IActionResult Delete(int id)
        //{
        //    var product = _context.Products.Find(id);
        //    if (product != null)
        //    {
        //        _context.Products.Remove(product);
        //        _context.SaveChanges();
        //    }
        //    return RedirectToAction("Dashboard");
        //}

        //private static List<Product> Products = new List<Product>
        //{
        //    new Product { Id = 1, Name = "Organic Serum", Category = "Skincare", Price = 5699, Stock = 18 },
        //    new Product { Id = 2, Name = "Herbal Face Mask", Category = "Skincare", Price = 1299, Stock = 0 }
        //};
        // This action will serve the UserInfo page
        public IActionResult UserInfo()
        {
           
            return View();  
        }
        public IActionResult PrivacySetting()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitPrivacy(bool agree)
        {
            if (agree)
            {
                ViewData["Agreed"] = true;
            }
            else
            {
                ViewData["Agreed"] = false;
            }

            return View("PrivacySetting"); 
        }

        public IActionResult Logout()
        {
            var user = HttpContext.Session.GetString("UserID");
            user = "Test123";
            if (user != null)
            {
                HttpContext.Session.Clear();  
                return View("Logout"); 
            }
            else
            {
                return RedirectToAction("LogIn","Home"); 
            }
           
        }


    }
}

