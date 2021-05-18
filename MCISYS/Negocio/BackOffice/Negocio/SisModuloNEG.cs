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
        public List<SisModulo> ObtemModulos(ref Banco pBanco)
        {
            return vSisModuloDAL.ObtemTodosModulosAssociada(ref pBanco);
        }
        public List<SisModulo> ObtemModulosHabilitados(ref Banco pBanco, int pIdOrg, int pIdSis)
        {
            return vSisModuloDAL.ObtemTodosModulosHabilitados(ref pBanco, pIdOrg, pIdSis);
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
            var vListSisModulo = plSisModulo;
            if (vListSisModulo.Count == 0 || vListSisModulo == null)
            {
                var ModuloImplantacao = new SisModulo();
                ModuloImplantacao.ID_SIS = 1;
                ModuloImplantacao.ID_MOD = vSisModuloDAL.GetIdMod(1, ref pBanco);
                ModuloImplantacao.DS_MOD = "Módulo de Controle de Acesso";
                ModuloImplantacao.DS_SIGLA_MOD = "MCA";
                ModuloImplantacao.DT_ALTERACAO = DateTime.Now;
                ModuloImplantacao.DT_INCLUSAO = DateTime.Now;
                ModuloImplantacao.ID_USU_INCL = "admin";
                ModuloImplantacao.ID_USU_ALT = "admin";
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
