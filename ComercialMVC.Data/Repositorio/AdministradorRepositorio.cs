using ComercialMVC.Data.Repositorio.Interface;
using ComercialMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialMVC.Data.Repositorio
{
    public class AdministradorRepositorio : GenericRepositorio<Administrador>, IAdministradorRepositorio
    {
        public IEnumerable<Administrador> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}
