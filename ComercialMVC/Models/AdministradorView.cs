namespace ComercialMVC.Models
{
    public class AdministradorView
    {
        public int IdAdm { get; set; }

        public string NomeAdm { get; set; }

        public string EmailAdm { get; set; }

        public LoginView LoginView { get; set; }
    }
}
