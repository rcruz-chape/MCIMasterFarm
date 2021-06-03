using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.Global;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.DAL;

namespace MCIMasterFarm.Negocio.BackOffice.Negocio
{
    public class VwOrgPapelNEG
    {
        public VwOrgPapelDAL vVwOrgPapelDAL = new VwOrgPapelDAL();
        public Boolean fbVerificaPapelAssociado(ref Banco pBanco, string pIDUsu,int pIDOrg)
        {
            var bPapelAssociado = vVwOrgPapelDAL.ObtemPapelHabilitado(ref pBanco, pIDOrg, pIDUsu);
            Boolean vbReturn = (bPapelAssociado.Count >= 0);
            return vbReturn;
        }
        public List<VwOrgPapel> ObtemPapelAssociado(ref Banco pBanco, string pIDUsu, int pIDOrg)
        {
            return vVwOrgPapelDAL.ObtemPapelHabilitado(ref pBanco, pIDOrg, pIDUsu);
        }
        public VwOrgPapel ObtemPapelSelecionado(ref Banco pBanco, string pIDUsu, int pIDOrg,string pidPapel)
        {
            return vVwOrgPapelDAL.ObtemPapelSelecionado(ref pBanco, pIDOrg, pIDUsu, pidPapel);
        }
        public List<VwOrgPapel> ObtemListaPapeis(ref Banco pBanco, string pIDUsu, int pIDOrg)
        {
            return vVwOrgPapelDAL.ObtemListOrgPapel(ref pBanco, pIDOrg, pIDUsu);
        }
    }
}
