using ComercialMVC.Data.Repositorio;
using ComercialMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialMVC.Servico.Servico
{
    public class UsuarioServico
    {
        private readonly UsuarioRepositorio usuarioRepositorio;

        public UsuarioServico()
        {
            usuarioRepositorio = new UsuarioRepositorio();
        }

        public void InserirUsuario(Usuario usuario)
        {
            usuarioRepositorio.Adicionar(usuario);
        }

        public List<Usuario> ListarUsuarios()
        {
            return usuarioRepositorio.ObterTodos();
        }

        public void Atualizar(Usuario usuario)
        {
            usuarioRepositorio.Atualizar(usuario);
        }

        public Usuario Buscar(int idUsuario)
        {
           return  usuarioRepositorio.Buscar(idUsuario, idUsuario);
        }
    }
}
