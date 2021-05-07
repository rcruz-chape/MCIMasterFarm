using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.Global;

namespace MCIMasterFarm.Negocio.BackOffice.Negocio
{
    public class SisUsuarioLogadoHistNEG
    {
        SisUsuarioLogHistDAL vSisLogHistDal = new SisUsuarioLogHistDAL();
        public Boolean RegistraHistoricoLogonUsuario(SisUsuarioLog pSisUsuarioLog, ref Banco pBanco)
        {
            return vSisLogHistDal.InsereHistorico(pSisUsuarioLog, ref pBanco);
        }
    }
}
