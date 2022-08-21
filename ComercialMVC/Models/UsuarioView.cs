namespace ComercialMVC.Models
{
    public class UsuarioView
    {
        public int IdUsuario { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public string Sexo { get; set; }

        public LoginView LoginView { get; set; }
    }
}
