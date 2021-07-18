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
    public class CorGrupoMercadoriaNEG
    {
        private CorGrupoMercadoriaDAL vCorGrupoMercadoriaDAL = new CorGrupoMercadoriaDAL();
        public string ATIVO = "S";
        public string DESATIVO = "N";

        public Dictionary<string, string> vIndAtivoGrupoMercadoria = new Dictionary<string, string>()
        {
            { "S", "Ativado"},
            { "N", "Desativado" }
        };
        public Boolean AtivaGrupoMercadoria(ref Banco pBanco, int pIdOrg, int pIdGrpMerc)
        {
            return vCorGrupoMercadoriaDAL.fbUpdateAtivaInativaGrupoMercadoria(ref pBanco, pIdOrg, pIdGrpMerc, ATIVO);
        }
        public Boolean DesAtivaGrupoMercadoria(ref Banco pBanco, int pIdOrg, int pIdGrpMerc)
        {
            return vCorGrupoMercadoriaDAL.fbUpdateAtivaInativaGrupoMercadoria(ref pBanco, pIdOrg, pIdGrpMerc, DESATIVO);
        }
        public Boolean DeleteGrupoMercadoria(ref Banco pBanco, int pIdOrg, int pIdGrpMerc)
        {
            return vCorGrupoMercadoriaDAL.fbExclueGrupoMercadoria(ref pBanco, pIdOrg, pIdGrpMerc);
        }
        public Boolean AtualizaGrupoMercadoria(ref Banco pBanco, CorGrupoMercadoria pCorGrupoMercadoria)
        {
            return vCorGrupoMercadoriaDAL.fbUpdateGrupoMercadoria(ref pBanco, pCorGrupoMercadoria);
        }
        public Boolean InsereGrupoMercadoria(ref Banco pBanco, CorGrupoMercadoria pCorGrupoMercadoria)
        {
            var vCorGrupoMercadoria = pCorGrupoMercadoria;
            vCorGrupoMercadoria.ID_GRP_MERC = vCorGrupoMercadoriaDAL.GetIdGrupoMercadoria(vCorGrupoMercadoria.ID_ORG, ref pBanco);
            return vCorGrupoMercadoriaDAL.fbInsereGrupoMercadoria(ref pBanco, pCorGrupoMercadoria);
        }
        public List<CorGrupoMercadoria> ObtemListaGrupoMercadoria(ref Banco pBanco, int pIdOrg)
        {
            return vCorGrupoMercadoriaDAL.ObtemListaGrupoMercadoria(ref pBanco, pIdOrg);
        }
        public CorGrupoMercadoria ObtemRegistroGrupoMercadoria(ref Banco pBanco, int pIdOrg, int pIdGrpMerc)
        {
            return vCorGrupoMercadoriaDAL.ObtemRegistroCorGrupoMercadoria(ref pBanco, pIdOrg, pIdGrpMerc);
        }

        /*
         * Validacao de Uso de GRupos
         * 
         */
    }
}
