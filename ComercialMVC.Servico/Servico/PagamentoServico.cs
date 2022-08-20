using ComercialMVC.Data.Repositorio;
using ComercialMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialMVC.Servico.Servico
{
    public class PagamentoServico
    {
        private readonly PagamentoRepositorio pagamentoRepositorio;

        public PagamentoServico()
        {
            pagamentoRepositorio = new PagamentoRepositorio();
        }

        public void InserirPagamento(Pagamento pagamento)
        {
            pagamentoRepositorio.Adicionar(pagamento);
        }

        public List<Pagamento> ListarPagamewntos()
        {
           return pagamentoRepositorio.ObterTodos();
        }

        public void Atualizar(Pagamento pagamento)
        {
            pagamentoRepositorio.Atualizar(pagamento);
        }

        public Pagamento Buscar(int idPagamento)
        {
            return pagamentoRepositorio.Buscar(idPagamento, idPagamento);
        }
    }
}
