using ComercialMVC.Data.Repositorio;
using ComercialMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialMVC.Servico.Servico
{
    public class AdmninistradorServico
    {
        private readonly AdministradorRepositorio administradorRepositorio;

        public AdmninistradorServico()
        {
            administradorRepositorio = new AdministradorRepositorio();
        }

        public void InserirAdministrador(Administrador administrador)
        {
            administradorRepositorio.Adicionar(administrador);
        }

        public List<Administrador> ListarAdministrador()
        {
           return administradorRepositorio.ObterTodos();
        }

        public void Atualizar(Administrador administrador)
        {
            administradorRepositorio.Atualizar(administrador);
        }

        public Administrador Buscar(int idAdministrador)
        {
            return administradorRepositorio.Buscar(idAdministrador, idAdministrador);
        }

        public void Deletar(int idAdmnistrador)
        {
            administradorRepositorio.Deletar(idAdmnistrador);
        }
    }
}
