using ComercialMVC.Data.Repositorio;
using ComercialMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialMVC.Servico.Servico
{
    public class EnderecoServico
    {
        private readonly EnderecoRepositorio enderecoRepositorio;

        public EnderecoServico()
        {
            enderecoRepositorio = new EnderecoRepositorio();
        }

        public void InserirEndereco(Endereco endereco)
        {
            enderecoRepositorio.Adicionar(endereco);
        }

        public List<Endereco> ListarEnderecos()
        {
            return enderecoRepositorio.ObterTodos();
        }

        public void Atualizar(Endereco endereco)
        {
            enderecoRepositorio.Atualizar(endereco);
        }

        public Endereco Buscar(int idRndereco)
        {
            return enderecoRepositorio.Buscar(idRndereco, idRndereco);
        }

        public void Deletar(int idEndereco)
        {
            enderecoRepositorio.Deletar(idEndereco);
        }
    }
}
