using Microsoft.AspNetCore.Mvc;

namespace MaraEngineeringApp.Controllers
{
    public class OurProjectsController : Controller
    {
        public IActionResult OurProjects()
        {
            return View();
        }
    }
}