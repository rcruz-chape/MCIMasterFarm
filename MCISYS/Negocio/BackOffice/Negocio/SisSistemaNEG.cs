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
    public class SisSistemaNEG
    {
        private SisSistemaDAL vSisSistemaDAL = new SisSistemaDAL();
        public Boolean AtualizaSistema(ref Banco pBanco)
        {
            return vSisSistemaDAL.bUpdateSistema(ref pBanco);
        }
        public SisSistema OtemSis(ref Banco pBanco)
        {
            return vSisSistemaDAL.ObtemSistema(ref pBanco);
        }
        public SisSistema ObtemSisSistema(ref Banco pBanco, int pIdOrg)
        {
            return vSisSistemaDAL.ObtemSistemaHabilitado(ref pBanco,pIdOrg);
        }
        public Boolean CriaSisSistema(ref Banco pBanco, SisSistema pSisSistema = null)
        {
            SisSistema vSisSistema = new SisSistema();
            if (pSisSistema == null)
            {
                vSisSistema.ID_SIS = 1;
                vSisSistema.NM_SIS = "MCISYS Gestor";
                vSisSistema.SG_SIS = "MCISYS";
                vSisSistema.ID_USU_INCL = "admin";
                vSisSistema.ID_USU_ALT = "admin";
                vSisSistema.DS_SIS = "Sistema de Gestão Empresarial MCISYS";
                vSisSistema.DT_INCLUSAO = DateTime.Now;
                vSisSistema.DT_ALTERACAO = DateTime.Now;
            }
            else
            {
                vSisSistema = pSisSistema;
            }
            return vSisSistemaDAL.bInsereSistema(ref pBanco, vSisSistema);
        }

    }
}
