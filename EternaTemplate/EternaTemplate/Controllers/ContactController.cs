using Microsoft.AspNetCore.Mvc;

namespace EternaTemplate.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Contact()
        {
            return View();
        }
    }
}
