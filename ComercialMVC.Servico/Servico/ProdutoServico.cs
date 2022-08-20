using ComercialMVC.Data.Repositorio;
using ComercialMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialMVC.Servico.Servico
{
    public class ProdutoServico
    {
        private readonly ProdutoReositorio produtoReositorio;

        public ProdutoServico()
        {
            produtoReositorio = new ProdutoReositorio();
        }

        public void InserirProduto(Produto produto)
        {
            produtoReositorio.Adicionar(produto);
        }

        public List<Produto> ListarProdutos()
        {
            return produtoReositorio.ObterTodos();
        }

        public void Atualizar(Produto produto)
        {
            produtoReositorio.Atualizar(produto);
        }

        public Produto Buscar(int idProduto)
        {
            return produtoReositorio.Buscar(idProduto, idProduto);
        }

        public void Deletar(int idProduto)
        {
            produtoReositorio.Deletar(idProduto);
        }
    }
}
