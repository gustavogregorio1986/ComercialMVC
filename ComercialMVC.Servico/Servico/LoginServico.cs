using ComercialMVC.Data.Repositorio;
using ComercialMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialMVC.Servico.Servico
{
    public class LoginServico
    {
        private readonly LoginRepositorio loginRepositorio;

        public LoginServico()
        {
            loginRepositorio = new LoginRepositorio();
        }

        public void InserirLogin(Login login)
        {
            loginRepositorio.Adicionar(login);
        }

        public List<Login> ListarLogin()
        {
            return loginRepositorio.ObterTodos();
        }

        public void Atualizar(Login login)
        {
            loginRepositorio.Atualizar(login);
        }

        public Login Buscar(int idLogin)
        {
            return loginRepositorio.Buscar(idLogin, idLogin);
        }

        public void Deletar(int idLogin)
        {
            loginRepositorio.Deletar(idLogin);
        }
    }
}
