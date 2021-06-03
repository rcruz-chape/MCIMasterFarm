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
    public class SisOrganizacaoPapelNEG
    {
        private SisOrganizacaoPapelDAL vSisOrgPap = new SisOrganizacaoPapelDAL();
        public List<SisOrganizacaoPapel> ObtemListaPapeisAssociados(ref Banco pBanco, int pIdOrg, string pIdUsu)
        {
            return vSisOrgPap.RecuperaPapeisAssociadosOrg(ref pBanco, pIdOrg, pIdUsu);
        }

        public Boolean AssociaPapelOrg(ref Banco pBanco, int pIdOrg, string pIdPapel, string pIdUsuIncl)
        {
            var vSisOrgPapel = new SisOrganizacaoPapel();
            vSisOrgPapel.ID_ORG = pIdOrg;
            vSisOrgPapel.ID_PAPEL = pIdPapel;
            vSisOrgPapel.ID_USU_INCL = pIdUsuIncl;
            vSisOrgPapel.DT_INCLUSAO = DateTime.Now;
            return vSisOrgPap.InserePapelAssociadoOrg(ref pBanco, vSisOrgPapel);
        }

        public Boolean RetiraAssociacaoPapelOrg(ref Banco pBanco, SisOrganizacaoPapel pSisOrgPapel)
        {
            return vSisOrgPap.DeletePapelAssociadoOrg(ref pBanco, pSisOrgPapel);
        }
    }
}
