using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.Negocio;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.Global;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCISYS.Negocio.BackOffice.Model;
using MCISYS.Negocio.BackOffice.DAL;

namespace MCISYS.Negocio.BackOffice.Negocio
{
    public class CorGeneroMercadoriaNEG
    {
        private CorGeneroMercadoriaDAL vCorGeneroMercadoriaDAL = new CorGeneroMercadoriaDAL();
        public List<CorGeneroMercadoria> GetListaGeneroMercadoria(ref Banco pBanco)
        {
            return vCorGeneroMercadoriaDAL.RecuperaListaGeneroMercadoria(ref pBanco);
        }
        public CorGeneroMercadoria GetGeneroMercadoria(ref Banco pBanco, int pCorGeneMercadoria)
        {
            return vCorGeneroMercadoriaDAL.RecuperaGeneroMercadoria(ref pBanco, pCorGeneMercadoria);
        }
    }
}
