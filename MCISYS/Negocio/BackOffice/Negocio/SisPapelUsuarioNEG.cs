﻿using System;
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
    public class SisPapelUsuarioNEG
    {
        private SisPapelUsuarioDAL vSisPapelUsuarioDAL = new SisPapelUsuarioDAL();
        public Boolean DesassociaPapelUsuario(ref Banco pBanco,
                                           List<SisPapelUsuario> pListInicialPUsu,
                                           List<SisPapelUsuario> PListFinalPUsu)
        {
            Boolean vbExclue = true;
            foreach(var Pusu in pListInicialPUsu)
            {
                if (!PListFinalPUsu.Exists(vLinhaPUsuFinal => vLinhaPUsuFinal.ID_PAPEL == Pusu.ID_PAPEL
                                                           && vLinhaPUsuFinal.ID_USU == Pusu.ID_USU))
                {
                    vbExclue = vSisPapelUsuarioDAL.bExclue(ref pBanco, Pusu);
                    if (!vbExclue)
                    {
                        break;
                    }
                }
            }

            return vbExclue;
        }

        public Boolean AssociaPapelUsuario(ref Banco pBanco, 
                                           List<SisPapelUsuario> pListInicialPUsu,
                                           List<SisPapelUsuario> PListFinalPUsu)
        {
            Boolean vbInclue = true;

            foreach(var Pusu in PListFinalPUsu)
            {
                if (!pListInicialPUsu.Exists(LinhaPusu => LinhaPusu.ID_PAPEL == Pusu.ID_PAPEL && LinhaPusu.ID_USU == Pusu.ID_USU))
                {
                    vbInclue = vSisPapelUsuarioDAL.bInsert(ref pBanco, Pusu);
                    if (!vbInclue)
                    {
                        break;
                    }
                }
            }
            return vbInclue;
        }
    }
}
