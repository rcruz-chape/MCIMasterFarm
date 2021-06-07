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

        public Boolean AssociaPapelOrg(ref Banco pBanco,
            List<SisOrganizacaoPapel> pListSisOrganizacaoInicial
            , List<SisOrganizacaoPapel> pListSisOrganizacaoFinal)
        {
            Boolean vbAssocia = true;
            var ListOrPapel = new List<SisOrganizacaoPapel>();
            foreach(var RegOrgPap in pListSisOrganizacaoFinal)
            {
                if (!pListSisOrganizacaoInicial.Exists(linhaRegOrgPap => linhaRegOrgPap.ID_ORG == RegOrgPap.ID_ORG
                                                                      && linhaRegOrgPap.ID_PAPEL == RegOrgPap.ID_PAPEL))
                {
                    vbAssocia = vSisOrgPap.InserePapelAssociadoOrg(ref pBanco, RegOrgPap);
                    if(!vbAssocia)
                    {
                        break;
                    }

                }
            }
            return vbAssocia;
        }
        public Boolean ExclueAssociaPapelOrg(ref Banco pBanco, int pIdOrg)
        {
            return vSisOrgPap.DeletePapelAssociado(ref pBanco, pIdOrg);
        }

        public Boolean RetiraAssociacaoPapelOrg(ref Banco pBanco, SisOrganizacaoPapel pSisOrgPapel)
        {
            return vSisOrgPap.DeletePapelAssociadoOrg(ref pBanco, pSisOrgPapel);
        }
        public Boolean RetiraAssociaPapOrg(ref Banco pBanco, List<SisOrganizacaoPapel> pListSisOrganizacaoInicial, List<SisOrganizacaoPapel> pListSisOrganizacaoFinal)
        {
            Boolean vbRetira = true;
            var ListOrgPapel = new List<SisOrganizacaoPapel>();
            foreach(var LinhaOrgPapelInicial in pListSisOrganizacaoInicial)
            {
                if(!pListSisOrganizacaoFinal.Exists(RegOrgPapel => 
                                                    RegOrgPapel.ID_ORG == LinhaOrgPapelInicial.ID_ORG && 
                                                    RegOrgPapel.ID_PAPEL == LinhaOrgPapelInicial.ID_PAPEL))
                {
                    vbRetira = RetiraAssociacaoPapelOrg(ref pBanco, LinhaOrgPapelInicial);
                    if (!vbRetira)
                    {
                        break;
                    }
                }
            }
            return vbRetira;
        }
    }
}
