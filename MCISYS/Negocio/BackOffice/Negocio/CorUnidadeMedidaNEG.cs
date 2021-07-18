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
    public class CorUnidadeMedidaNEG
    {
        private CorUnidadeMedidaDAL vCorUnidadeMedidaDAL = new CorUnidadeMedidaDAL();

        public Boolean bExisteCorUnidade(ref Banco pBanco, int pIdOrg, string psCodUm)
        {
            var VerificaCorUnidade = vCorUnidadeMedidaDAL.ObtemUnidadeMedidaSelecionado(ref pBanco, psCodUm, pIdOrg);
            return VerificaCorUnidade == null;
        }

        public CorUnidadeMedida Obtem_UM(ref Banco pBanco, int pIdOrg, string psCodUm)
        {
            return vCorUnidadeMedidaDAL.ObtemUnidadeMedidaSelecionado(ref pBanco, psCodUm, pIdOrg);
        }
        public List<CorUnidadeMedida> Obtem_ListaUM(ref Banco pBanco, int pIdOrg)
        {
            return vCorUnidadeMedidaDAL.ObtemListaUnidadeMedida(ref pBanco, pIdOrg);
        }
        public Boolean Insere_UM(ref Banco pBanco, CorUnidadeMedida pCorUnidadeMedida)
        {
            return vCorUnidadeMedidaDAL.InsereCorUnidadeMedida(ref pBanco, pCorUnidadeMedida);
        }
        public Boolean Exclue_UM(ref Banco pBanco, int pIdOrg, string pCodUm)
        {
            return vCorUnidadeMedidaDAL.ExclueCorUnidadeMedida(ref pBanco, pIdOrg, pCodUm);
        }
        public Boolean Atualiza_UM(ref Banco pBanco, CorUnidadeMedida pCorUnidadeMedida)
        {
            return vCorUnidadeMedidaDAL.AtualizaCorUnidadeMedida(ref pBanco, pCorUnidadeMedida);
        }
    }
}
