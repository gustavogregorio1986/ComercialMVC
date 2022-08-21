namespace ComercialMVC.Models
{
    public class ProdutoView
    {
        public int IdProduto { get; set; }

        public string NomeProd { get; set; }

        public string Descricao { get; set; }

        public LojaView LojaView { get; set; }
    }
}
