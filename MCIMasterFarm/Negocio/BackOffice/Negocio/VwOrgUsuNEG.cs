using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.Global;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.BackOffice.Model;
namespace MCIMasterFarm.Negocio.BackOffice.Negocio
{
    public class VwOrgUsuNEG
    {
        public VwOrgUsuDAL vVwOrgUsuDAL = new VwOrgUsuDAL();
        public Boolean fbReturnVwOrgUsuDal(ref Banco pBanco, string pIdUsu)
        {
            var ExisteRegistro = vVwOrgUsuDAL.ObtemListOrg(ref pBanco, pIdUsu);
            Boolean bExiste = (ExisteRegistro.Count >= 0);
            return bExiste;
        }
        public List<VwOrgUsu> GetListaOrg(ref Banco pBanco, string pIdUsu)
        {
            return vVwOrgUsuDAL.ObtemListOrg(ref pBanco, pIdUsu);
        }
    }
}
