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
    public class CorOrganizacaoLicencaNEG
    {
        private CorOrganizacaoLicencaDAL vOrgLicDAL = new CorOrganizacaoLicencaDAL();
        public Boolean bTemLic(ref Banco pBanco, int pIdOrg)
        {
            return vOrgLicDAL.fbExisteLicenca(ref pBanco, pIdOrg);
        }
        public CorOrganizacaoLicenca ObtemLic (ref Banco pBanco, int pIdOrg)
        {
            return vOrgLicDAL.ObtemLicencaOrg(ref pBanco, pIdOrg);
        }
        public Boolean IncluiLicencaOrg(ref Banco pBanco, CorOrganizacaoLicenca pOrgLic)
        {
            Boolean vInclui = false;
            var vModDAL = new SisModuloDAL();
            var vMORGNEG = new SisModuloOrganizacaoNEG();
            var vOLICDAL = new CorOrganizacaoLicencaDAL();
            var vListMod = vMORGNEG.flistModulos(ref pBanco);
            var vListModOrg = new List<SisModuloOrganizacao>();
            var vListPFunc = new SisPapelFuncaoNEG();
            foreach(var Mod in vListMod)
            {
                var ModOrg = new SisModuloOrganizacao();
                ModOrg.ID_ORG = pOrgLic.ID_ORG;
                ModOrg.ID_MOD = Mod.ID_MOD;
                ModOrg.ID_SIS = Mod.ID_SIS;
                vInclui = vListPFunc.fbFuncaoLicenciada(ref pBanco, ModOrg.ID_ORG,Mod.ID_MOD);
                vListModOrg.Add(ModOrg);
            }
            if (vInclui)
            {
                vInclui = vMORGNEG.fbAssociaUpdate(ref pBanco, vListModOrg);
            }
            if (vInclui)
            {
                vInclui = vOLICDAL.InclueRegistroLicOrg(ref pBanco, pOrgLic);
            }
            return vInclui;
        }
        public Boolean ExclueLicencaOrg(ref Banco pBanco, int pIdOrg)
        {
            Boolean bExclue;
            var vMORGNEG = new SisModuloOrganizacaoNEG();
            var vOLICDAL = new CorOrganizacaoLicencaDAL();
            bExclue = vMORGNEG.fbRetiraModulos(ref pBanco, pIdOrg);
            bExclue = vOLICDAL.ExclueRegistroLicOrg(ref pBanco, pIdOrg);
            return bExclue;

        }

    }
}
