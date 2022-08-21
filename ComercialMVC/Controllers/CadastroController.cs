using Microsoft.AspNetCore.Mvc;

namespace ComercialMVC.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
