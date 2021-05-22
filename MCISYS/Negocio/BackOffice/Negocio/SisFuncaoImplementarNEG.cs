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
    public class SisFuncaoImplementarNEG
    {
        private SisFuncaoImplementarDAL vSisFuncaoImplementarDAL = new SisFuncaoImplementarDAL();
        public List<SisFuncaoImplementar> ObtemFuncoes(ref Banco pBanco)
        {
            return vSisFuncaoImplementarDAL.GetObterRegistros(ref pBanco);
        }
    }
}
