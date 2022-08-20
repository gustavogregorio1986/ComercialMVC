using ComercialMVC.Data.Repositorio.Interface;
using ComercialMVC.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercialMVC.Data.Repositorio
{
    public class PagamentoRepositorio : GenericRepositorio<Pagamento>, IPagamentoRepositorio
    {
        public IEnumerable<Pagamento> Buscar(object id)
        {
            throw new NotImplementedException();
        }
    }
}
