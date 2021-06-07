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
    public class CorOrganizacaoNEG
    {
        private CorOrganizacaoDAL vCorOrganizacaoDAL = new CorOrganizacaoDAL();
        public string ADMINISTRATIVA = "A";
        public int OPERACIONAL = 1;
        public const int ORGADM = 1;

        public CorOrganizacao ObtemOrgSelecionada(int pIdOrg, List<CorOrganizacao> plistCorOrganizacao)
        {
            CorOrganizacao RegCorOrganizacao = plistCorOrganizacao.Find(Registro => Registro.ID_ORG == pIdOrg);
            return RegCorOrganizacao;
        }

        public List<CorOrganizacao> ObtemListaOrgMae(ref Banco pBanco, string pidUsu)
        {
            return vCorOrganizacaoDAL.ObtemListaOrganizacao(ref pBanco, pidUsu, true);
        }
        public int ObtemIdOrg(ref Banco pBanco)
        {
            return vCorOrganizacaoDAL.GetIdOrg(ref pBanco);
        }

        public List<CorOrganizacao> ObtemListaOrg(ref Banco pBanco, string pidUsu)
        {
            return vCorOrganizacaoDAL.ObtemListaOrganizacao(ref pBanco, pidUsu);
        }
        public Boolean InsereCorOrganizacao(ref Banco pBanco, CorOrganizacao pCorOrganizacao)
        {
            var vCorOrganizacao = pCorOrganizacao;
            return vCorOrganizacaoDAL.fbInsereOrg(ref pBanco, pCorOrganizacao);
        }
        public Boolean UpdateCorOrganizacao(ref Banco pBanco, CorOrganizacao pCorOrganizacao)
        {
            return vCorOrganizacaoDAL.fbAtualizaOrg(ref pBanco, pCorOrganizacao);
        }
        public String DeleteCorOrganizacao(ref Banco pBanco, CorOrganizacao pCorOrganizacao)
        {
            String VbMensagem = "";
            Boolean vbReturn;
            if (pCorOrganizacao.ID_ORG == ORGADM)
            {
                VbMensagem = "Impossível Excluir a Organização Administradora da Instância";
            }
            else
            {
                var vbExisteFilhos = vCorOrganizacaoDAL.ExisteFilhos(ref pBanco, pCorOrganizacao.ID_ORG);
                if (!vbExisteFilhos)
                {
                    vbReturn = vCorOrganizacaoDAL.fbExclueOrg(ref pBanco, pCorOrganizacao);
                    if (vbReturn)
                    {
                        VbMensagem = "OK";
                    }
                    else
                    {
                        VbMensagem = "Exclusão Não Realizada";
                    }
                }
                else
                {
                    VbMensagem = $"A Organização {pCorOrganizacao.ID_ORG.ToString("0000")} - ";
                    VbMensagem += $"{pCorOrganizacao.NM_ORG_RESUMIDO} possui filhos e não poderá ser excluída";
                }
            }
            return VbMensagem;
        }
    }
}
