using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult create()
        {
            return View();
        }
    }
}
