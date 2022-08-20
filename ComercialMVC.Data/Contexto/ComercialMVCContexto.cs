using ComercialMVC.Dominio.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialMVC.Data.Contexto
{
    public class ComercialMVCContexto : DbContext
    {
        public ComercialMVCContexto(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Login> Logins { get; set; }

        public DbSet<Administrador> Administradores { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Loja> lojas { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }
    }
}
