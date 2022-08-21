namespace ComercialMVC.Models
{
    public class EnderecoView
    {
        public int IdEndereco { get; set; }

        public string Logradouro { get; set; }

        public string Complemento { get; set; }

        public string Cidade { get; set; }

        public string Uf { get; set; }

        public UsuarioView UsuarioView { get; set; }
    }
}
