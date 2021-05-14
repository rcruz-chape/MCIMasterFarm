using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.DadosAcesso;
using MCIMasterFarm.Negocio.Telas;
using MCIMasterFarm.Negocio.Global;

namespace MCISYS.Negocio.BackOffice.Negocio
{
    public class CriaEstruturaSisNEG
    {
        public Boolean CriaEstrutura(ref Banco pBanco)
        {
            var vSisSistemaNEG = new SisSistemaNEG();
            var vSisModuloNEG = new SisModuloNEG();
            Boolean vbCria;
            vbCria = vSisSistemaNEG.CriaSisSistema(ref pBanco);
            if (vbCria == false)
            {
                return vbCria;
            }
            vbCria = vSisModuloNEG.InclueModulo(ref pBanco);
            if (vbCria == false)
            {
                return vbCria;
            }
            return vbCria;
        }
    }
}
