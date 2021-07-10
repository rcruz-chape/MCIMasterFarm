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
    public class SisPapelNEG
    {
        private SisPapelDAL vPapDAL = new SisPapelDAL();
        public List<SisPapel> ObtemTodosPapeis(ref Banco pBanco)
        {
            return vPapDAL.ObtemListaPapel(ref pBanco);
        }
        public Boolean ExistePapelInformado(ref Banco pBanco, string pIdPapel)
        {
            Boolean vbExistePapel = false;
            var vSisPapel = ObtemPapelSelecionado(ref pBanco, pIdPapel);
            vbExistePapel = (vSisPapel.ID_PAPEL == pIdPapel);
            return vbExistePapel;


        }
        public SisPapel ObtemPapelSelecionado(ref Banco pBanco, string pIdPapel)
        {
            return vPapDAL.ObtemPapel(ref pBanco, pIdPapel);
        }
        public Boolean CriaPapel(ref Banco pBanco, SisPapel pPap)
        {
            Boolean vbInsert;
            vbInsert = vPapDAL.InsertPapel(ref pBanco, pPap);
            if (vbInsert)
            {
                SisPapelFuncaoNEG vSisPapelFuncaoNEG = new SisPapelFuncaoNEG();
                vbInsert = vSisPapelFuncaoNEG.fbAssociaFuncaoPapelCriado(ref pBanco, pPap.ID_PAPEL, pPap.TP_PAPEL);
            }
            return vbInsert;
        }
        public Boolean AlteraPapel(ref Banco pBanco, SisPapel pPap)
        {
            return vPapDAL.UpdatePapel(ref pBanco, pPap);
        }
        public Boolean ExcluiPapel(ref Banco pBanco, string pIdPapel)
        {
            return vPapDAL.DeletePapel(ref pBanco, pIdPapel);
        }
    }
}
