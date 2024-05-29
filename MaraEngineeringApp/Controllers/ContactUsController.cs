using Microsoft.AspNetCore.Mvc;

namespace MaraEngineeringApp.Controllers
{
    public class ContactUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
