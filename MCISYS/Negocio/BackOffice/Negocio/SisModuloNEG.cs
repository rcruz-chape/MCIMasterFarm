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
    public class SisModuloNEG
    {
        private SisModuloDAL vSisModuloDAL = new SisModuloDAL();
        private CorOrganizacaoNEG vOrgNEG = new CorOrganizacaoNEG();
        private const string TPADM = "A";
        private const string TPOPE = "O";
        public List<SisModulo> ObtemModulos(ref Banco pBanco)
        {
            return vSisModuloDAL.ObtemTodosModulosAssociados(ref pBanco);
        }
        public List<SisModulo> ObtemModulosHabilitados(ref Banco pBanco, int pIdOrg, int pIdSis, string pTpOrg)
        {
            var vReturn = new List<SisModulo>();
            Boolean vbMAe = false;
            int idOrg = pIdOrg;

            while(!vbMAe)
            {
                var vOrg = vOrgNEG.OrgSelecionada(ref pBanco, idOrg);
                if (vOrg.ID_ORG_MAE == 0)
                {
                    vbMAe = true;
                }
                else
                {
                    idOrg = vOrg.ID_ORG_MAE;
                }
            }
            vReturn = vSisModuloDAL.ObtemTodosModulosHabilitados(ref pBanco, idOrg, pIdSis);
            vReturn = vReturn.FindAll(linha => linha.TP_MOD_ORG == pTpOrg);

            return vReturn;
        }
        
        public  Boolean AlteraModulo(ref Banco pBanco, int pIdSis = 1, int pIdMod = 1)
        {
            return vSisModuloDAL.fbAlteraModulo(ref pBanco, pIdSis, pIdMod);
        }
        public Boolean InsereNovoModulo(ref Banco pBanco, SisModulo pSisModulo)
        {
            Boolean bInclue = false;
            var vSisModulo = pSisModulo;
            vSisModulo.ID_MOD = vSisModuloDAL.GetIdMod(vSisModulo.ID_SIS, ref pBanco);
            bInclue = vSisModuloDAL.fbInsereModulo(ref pBanco, vSisModulo);
            return bInclue;
        }
        public Boolean InclueModulo(ref Banco pBanco, List<SisModulo> plSisModulo = null)
        {
            Boolean bInclue = false;
            List<SisModulo> vListSisModulo = plSisModulo;
            if (vListSisModulo == null)
            {
                var ModuloImplantacao = new SisModulo();
                ModuloImplantacao.ID_SIS = 1;
                ModuloImplantacao.ID_MOD = vSisModuloDAL.GetIdMod(1, ref pBanco);
                ModuloImplantacao.NM_MOD = "MCISYS Acesso";
                ModuloImplantacao.DS_MOD = "Módulo de Controle de Acesso";
                ModuloImplantacao.DS_SIGLA_MOD = "MCA";
                ModuloImplantacao.DT_ALTERACAO = DateTime.Now;
                ModuloImplantacao.DT_INCLUSAO = DateTime.Now;
                ModuloImplantacao.ID_USU_INCL = "admin";
                ModuloImplantacao.ID_USU_ALT = "admin";
                ModuloImplantacao.NM_IMAGEM_ICONE = "GrupoNegocio_SML";
                bInclue = vSisModuloDAL.fbInsereModulo(ref pBanco, ModuloImplantacao);
            }
            else
            {
                var vListSisModuloNew = new List<SisModulo>();
                var vDefaulNEg = new DefaultNEG();
                foreach(var RegSisModulo in plSisModulo)
                {
                    int vIDMOD = Convert.ToInt32(vDefaulNEg.NVL(vListSisModuloNew.FindLast(linha => linha.ID_SIS == RegSisModulo.ID_SIS).ID_MOD,0));
                    vIDMOD += 1;
                    RegSisModulo.ID_MOD = vIDMOD;
                    vListSisModuloNew.Add(RegSisModulo);
                    
                }
                bInclue = vSisModuloDAL.fbInsereModuloLista(ref pBanco,vListSisModuloNew);
            }
            return bInclue;
        }
       
    }
}
