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
    public class CorNcmMercadoriaNEG
    {
        CorNcmMercadoriaDAL vCorNcmMercadoriaDAL = new CorNcmMercadoriaDAL();
        public List<CorNcmMercadoria> GetListCorNcmMercadoria(ref Banco pBanco, int pCorGeneMerc)
        {
            return vCorNcmMercadoriaDAL.RecuperaListaNCM(ref pBanco, pCorGeneMerc);
        }
        public CorNcmMercadoria GetCorNcmMercadoria(ref Banco pBanco, string psCodNcm)
        {
            return vCorNcmMercadoriaDAL.RecuperNCM(ref pBanco, psCodNcm);
        }
        public List<CorNcmMercadoria> GetListTodosCorNcmMercadoria(ref Banco pBanco)
        {
            return vCorNcmMercadoriaDAL.RecuperaListaNCM(ref pBanco);
        }
    }
}
