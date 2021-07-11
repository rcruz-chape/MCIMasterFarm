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
    public class SisPapelFuncaoNEG
    {
        private SisPapelFuncaoDAL vSisPapelFuncaoDAL = new SisPapelFuncaoDAL();
        public Boolean fbFuncaoLicenciada(ref Banco pBanco, int pIdOrg, int pidMod)
        {
            Boolean vbLicencia = true;

            var vModuloNEG = new SisModuloNEG();
            var vSisModulo = vModuloNEG.ObtemModuloSelecionado(ref pBanco, pidMod);

            var vListFuncaoLicenciar = vSisPapelFuncaoDAL.GetFuncaoLicenciar(ref pBanco, "0", pidMod);
            if (vListFuncaoLicenciar.Count > 0)
            {
                vbLicencia = fbAssociaListaFuncaoPapel(ref pBanco, vListFuncaoLicenciar);
            }
            return vbLicencia;
        }
        public Boolean fbAssociaListaFuncaoPapel(ref Banco pBanco, List<SisPapelFuncao> pSisPapelFuncao)
        {
            return vSisPapelFuncaoDAL.AssociaFuncoesPapeis(ref pBanco, pSisPapelFuncao);
        }
        
        public Boolean fbAssociaFuncaoPapelCriado(ref Banco pBanco, string pIdPapel, int pTpPapel)
        {
            List<SisPapelFuncao> vListSisPapel = new List<SisPapelFuncao>();
            Boolean bInsert = true;
            SisModuloFuncaoNEG vSisFuncaoNeg = new SisModuloFuncaoNEG();
            var ListFuncao = vSisFuncaoNeg.ListaModuloFuncao(ref pBanco, pTpPapel);
            foreach(var Funcao in ListFuncao)
            {
                SisPapelFuncao vPapelFuncao = new SisPapelFuncao();
                vPapelFuncao.ID_PAPEL = pIdPapel;
                vPapelFuncao.ID_SIS = Funcao.ID_SIS;
                vPapelFuncao.ID_MOD = Funcao.ID_MOD;
                vPapelFuncao.ID_FUNCAO = Funcao.ID_FUNCAO;
                vPapelFuncao.ind_cons_reg = "S";
                vPapelFuncao.ind_excl_reg = "S";
                vPapelFuncao.ind_execute = "S";
                vPapelFuncao.ind_incl_alt = "S";
                vPapelFuncao.ind_incl_reg = "S";
                vListSisPapel.Add(vPapelFuncao);
            }
            bInsert = fbAssociaListaFuncaoPapel(ref pBanco, vListSisPapel);

            return bInsert;
        }
    }
}
