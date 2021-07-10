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
    public class SisModuloFuncaoNEG
    {
        private SisModuloFuncaoDAL vSisFuncaoDAL = new SisModuloFuncaoDAL();
        public Boolean fbnAssociaOrg(ref Banco pBanco, List<SisModuloFuncao> plistModuloFuncao)
        {
            return vSisFuncaoDAL.fbAssociaListaFuncaoModulo(ref pBanco, plistModuloFuncao);
        }
        public List<SisModuloFuncao> ListaModuloFuncao(ref Banco pBanco, int piTpMod)
        {
            return vSisFuncaoDAL.ObtemFuncaoAssociar(ref pBanco, piTpMod);
        }
    }
}
