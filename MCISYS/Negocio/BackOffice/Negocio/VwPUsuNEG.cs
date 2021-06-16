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
    public class VwPUsuNEG
    {
        private VwPUsuDAL VwPUsuDAL = new VwPUsuDAL();
        public List<VwPUsu> ObtemUsuariosAssociados(ref Banco pBanco, string pIdPapel)
        {
            return VwPUsuDAL.ObtemUsuariosAssociadoPapel(ref pBanco, pIdPapel);
        }
    }
}
