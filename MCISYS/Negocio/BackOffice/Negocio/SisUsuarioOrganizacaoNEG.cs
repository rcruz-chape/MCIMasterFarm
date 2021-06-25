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
    public class SisUsuarioOrganizacaoNEG
    {
        private SisUsuarioOrganizacaoDAL vUORGDAL = new SisUsuarioOrganizacaoDAL();
        public Boolean DeleteOrgUsu(ref Banco pBanco, int pIdOrg, string pIdUsu)
        {
            return vUORGDAL.ExclueOrgUsu(ref pBanco, pIdOrg, pIdUsu);
        }
        public List<SisUsuarioOrganizacao> ObtemOrgsAssociadosUSuario(ref Banco pBanco, string pIdUsu)
        {
            return vUORGDAL.ObtemUsuariosAssociadosOrg(ref pBanco, 0, pIdUsu);
        }
        public List<SisUsuarioOrganizacao> ObtemUsuariosAssociadosOrg(ref Banco pBanco, int pIdOrg)
        {
            return vUORGDAL.ObtemUsuariosAssociadosOrg(ref pBanco, pIdOrg);
        }

        public Boolean bDesassociaUsuarioOrg(ref Banco pBanco, List<SisUsuarioOrganizacao> pSisUsuarioOrganizacaoInicial, List<SisUsuarioOrganizacao> pSisUsuOrganizacaoFinal)
        {
            Boolean vbAssocia = true;
            foreach(var linhaUORG_Inicial in pSisUsuarioOrganizacaoInicial)
            {
                if (!pSisUsuOrganizacaoFinal.Exists(UORGFinal => UORGFinal.ID_ORG == linhaUORG_Inicial.ID_ORG && UORGFinal.ID_USU == linhaUORG_Inicial.ID_USU))
                {
                    vbAssocia = vUORGDAL.ExclueOrgUsu(ref pBanco, linhaUORG_Inicial.ID_ORG, linhaUORG_Inicial.ID_USU);
                }
            }

            return vbAssocia;
        }

        public Boolean bAssociaUsuarioOrg(ref Banco pBanco, List<SisUsuarioOrganizacao> pSisUsuarioOrganizacaoInicial, List<SisUsuarioOrganizacao> pSisUsuOrganizacaoIncluir)
        {
            Boolean vbAssocia = false;
            foreach(var linhaUROGAssocia in pSisUsuOrganizacaoIncluir)
            {
                if (!pSisUsuarioOrganizacaoInicial.Exists(linha => linha.ID_ORG == linhaUROGAssocia.ID_ORG && linha.ID_USU == linhaUROGAssocia.ID_USU))
                {
                    vbAssocia = vUORGDAL.InclueOrgUsu(ref pBanco, linhaUROGAssocia);
                }
            }
            return vbAssocia;
        }
    }
}
