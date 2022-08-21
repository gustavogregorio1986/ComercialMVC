using Microsoft.AspNetCore.Mvc;

namespace ComercialMVC.Controllers
{
    public class LogarController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
