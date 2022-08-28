using ComercialMVC.Dominio.Dominio;
using ComercialMVC.Models;
using ComercialMVC.Servico.Servico;
using Microsoft.AspNetCore.Mvc;
using System;

namespace ComercialMVC.Controllers
{
    public class CadastroController : Controller
    {
        private readonly LoginServico loginServico;

        public CadastroController()
        {
            loginServico = new LoginServico();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult CadastrarLogin(LoginView loginView)
        {
            try
            {
                loginView = new LoginView();
                Login login = new Login();
                loginView.IdLogin = login.IdLogin;
                loginView.Email = login.Email;
                loginView.Senha = login.Senha;
                loginView.Perfil = login.Perfil;
                loginServico.InserirLogin(login);
                return View("Cadastrar");
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
