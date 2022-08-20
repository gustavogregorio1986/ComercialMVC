using ComercialMVC.Data.Repositorio;
using ComercialMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialMVC.Servico.Servico
{
    public class LojaServico
    {
        private readonly LojaRepositorio lojaRepositorio;

        public LojaServico()
        {
            lojaRepositorio = new LojaRepositorio();
        }

        public void InserirLoja(Loja loja)
        {
            lojaRepositorio.Adicionar(loja);
        }

        public List<Loja> ListarLojas()
        {
            return lojaRepositorio.ObterTodos();
        }

        public void Atulaizar(Loja loja)
        {
            lojaRepositorio.Atualizar(loja);
        }

        public Loja Buscar(int idLoja)
        {
            return lojaRepositorio.Buscar(idLoja, idLoja);
        }

        public void Deletar(int idLoja)
        {
            lojaRepositorio.Deletar(idLoja);
        }
    }
}
