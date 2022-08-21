namespace ComercialMVC.Models
{
    public class PagamentoView
    {
        public int IdPagamento { get; set; }

        public decimal Preco { get; set; }

        public int Qtde { get; set; }

        public ProdutoView ProdutoView { get; set; }
    }
}
