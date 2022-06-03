using Microsoft.AspNetCore.Mvc;

namespace EternaTemplate.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Blog()
        {
            return View();
        }
    }
}
