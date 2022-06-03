using Microsoft.AspNetCore.Mvc;

namespace EternaTemplate.Controllers
{
    public class PortFolioController : Controller
    {
        public IActionResult Portfolio()
        {
            return View();
        }
    }
}
