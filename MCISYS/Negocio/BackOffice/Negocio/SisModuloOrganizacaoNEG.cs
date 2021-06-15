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
    public class SisModuloOrganizacaoNEG
    {
        private SisModuloOrganizacaoDAL vSisModuloOrganizacaoDAL = new SisModuloOrganizacaoDAL();
        private SisModuloDAL vSisModuloDal = new SisModuloDAL();
        public Boolean fbRetiraModulos(ref Banco pBanco, int pIdOrg)
        {
            return vSisModuloOrganizacaoDAL.fbExcluiModuloOrg(ref pBanco, pIdOrg);
        }
        public Boolean fbAssociaUpdate(ref Banco pBanco, List<SisModuloOrganizacao> pListModulo)
        {
            return vSisModuloOrganizacaoDAL.fbAssociaListOrg(ref pBanco, pListModulo);
        }
        public List<SisModulo> flistModulosHabilitados(ref Banco pBanco, int pidOrg, int pidSis)
        {
            return vSisModuloDal.ObtemTodosModulosHabilitados(ref pBanco, pidOrg, pidSis);
        }
        public List<SisModulo> flistModulos (ref Banco pBanco, string pTPModOrg = null)
        {
            if (pTPModOrg == null)
            {
                return vSisModuloDal.ObtemTodosModulosAssociados(ref pBanco);
            }
            else
            {
                return vSisModuloDal.ObtemModulosAssociadosPorTipo(ref pBanco, pTPModOrg);
            }
        }
    }
}
