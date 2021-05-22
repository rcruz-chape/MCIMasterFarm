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
    public class SisPapelFuncaoNEG
    {
        private SisPapelFuncaoDAL vSisPapelFuncaoDAL = new SisPapelFuncaoDAL();
        public Boolean fbAssociaListaFuncaoPapel(ref Banco pBanco, List<SisPapelFuncao> pSisPapelFuncao)
        {
            return vSisPapelFuncaoDAL.AssociaFuncoesPapeis(ref pBanco, pSisPapelFuncao);
        }
        public Boolean fbAssociaListaFuncaoPapel(ref Banco pBanco, SisPapelFuncao pSisPapelFuncao)
        {
            return vSisPapelFuncaoDAL.fbInsereFuncaoPapel(ref pBanco, pSisPapelFuncao);
        }
    }
}
