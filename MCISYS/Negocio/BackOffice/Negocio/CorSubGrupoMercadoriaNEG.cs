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
    public class CorSubGrupoMercadoriaNEG
    {
        private CorSubGrupoMercadoriaDAL vCorSubGrupoMercadoriaDAL = new CorSubGrupoMercadoriaDAL();
        public string SUB_GRUPO_MERCADORIA_ATIVO = "S";
        public string SUB_GRUPO_MERCADORIA_DESATIVO = "N";

        public Dictionary<string, string> vIndAtivoSubGrupoMercadoria = new Dictionary<string, string>()
        {
            { "S", "Ativado"},
            { "N", "Desativado" }
        };
        public CorSubGrupoMercadoria ObtemDadosSubGrupoMercadoria(ref Banco pBanco, int pIdOrg, int pIdGRpMErc, int pIdSubGrpMerc)
        {
            return vCorSubGrupoMercadoriaDAL.ObtemSubGrupoMercadoria(ref pBanco, pIdOrg, pIdGRpMErc, pIdSubGrpMerc);
        }
        public List<CorSubGrupoMercadoria> ObtemListaSubGrupoMercadoria(ref Banco pBanco, int pIdOrg, int pIdGRpMErc = 0)
        {
            return vCorSubGrupoMercadoriaDAL.ObtemListaSubGrupoMercadoria(ref pBanco, pIdOrg, pIdGRpMErc);
        }
        public Boolean bInsereNovaListaSubGrupoMercadoria(ref Banco pBanco, CorSubGrupoMercadoria pSubGrupoMercadoria)
        {
            var vSubGrupoMercadoria = pSubGrupoMercadoria;
            var Parametro = new Dictionary<string, dynamic>()
            {
                {nameof(vSubGrupoMercadoria.ID_ORG), vSubGrupoMercadoria.ID_ORG},
                {nameof(vSubGrupoMercadoria.ID_GRP_MERC), vSubGrupoMercadoria.ID_GRP_MERC}
            };
            vSubGrupoMercadoria.ID_SUBGRP_MERC = Convert.ToInt32(vCorSubGrupoMercadoriaDAL.lGetIDSubGrupoMercadoria(ref pBanco, Parametro));
            return vCorSubGrupoMercadoriaDAL.bInsereCorSubGrupoMercadoria(ref pBanco, pSubGrupoMercadoria);
        }
        public Boolean bUpdateSubGrupoMercadoria(ref Banco pBanco, CorSubGrupoMercadoria pCorSubGrupoMercadoria)
        {
            return vCorSubGrupoMercadoriaDAL.bUpdateCorSubGrupoMercadoria(ref pBanco, pCorSubGrupoMercadoria);
        }
        public Boolean bAtivaSubGrupoMercadoria(ref Banco pBanco, int pIDOrg, int pIDGrpMerc, int pIDSubGrpMErc = 0)
        {
            return vCorSubGrupoMercadoriaDAL.bUpdateAtivaSubGrupoMercadoria(ref pBanco, pIDOrg, pIDGrpMerc, pIDSubGrpMErc);
        }
        public Boolean bDesativaSubGrupoMercadoria(ref Banco pBanco, int pIDOrg, int pIDGrpMerc, int pIDSubGrpMErc = 0)
        {
            return vCorSubGrupoMercadoriaDAL.bUpdateDesAtivaSubGrupoMercadoria(ref pBanco, pIDOrg, pIDGrpMerc, pIDSubGrpMErc);
        }
        public Boolean bDeleteListaGrupoMercadoria(ref Banco pBanco, int pIDOrg, int pIDGrpMerc, int pIDSubGrpMErc)
        {
            return vCorSubGrupoMercadoriaDAL.bDeleteSubGrupoMercadoria(ref pBanco, pIDOrg, pIDGrpMerc, pIDSubGrpMErc);
        }
    }
}
