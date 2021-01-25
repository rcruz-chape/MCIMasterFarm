using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.Telas;
using MCIMasterFarm.Negocio.Global;

namespace MCIMasterFarm.Negocio.BackOffice.Negocio
{
    public class SIS_PARAMETRO_NEG
    {
        public SisParametro ObtemParametro(ref Banco pBanco)
        {
            var vSisParametroDal = new SIS_PARAMETRO_DAL();
            return vSisParametroDal.getParametro(ref pBanco); 
        }
        public Boolean bAtualizaParametro(ref Banco pBanco, SisParametro pParametro)
        {
            var vSisParametroDal = new SIS_PARAMETRO_DAL();
            return vSisParametroDal.bUpdateParametro(ref pBanco, pParametro);
        }
    }
}
