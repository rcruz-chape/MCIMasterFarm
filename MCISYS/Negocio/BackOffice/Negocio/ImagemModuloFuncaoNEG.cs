
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
    public class ImagemModuloFuncaoNEG
    {
        private ImagemModuloFuncaoDAL vModFuncaoDAL = new ImagemModuloFuncaoDAL();
        public List<ImagensModuloFuncao> GetModuloIcone(ref Banco pBanco, string pIdPapel)
        {
            return vModFuncaoDAL.GetIcones(ref pBanco, pIdPapel,vModFuncaoDAL.MODULOS);
        }
        public List<ImagensModuloFuncao> GetIcone(ref Banco pBanco, string pIdPapel)
        {
            return vModFuncaoDAL.GetIcones(ref pBanco, pIdPapel, vModFuncaoDAL.TODOS);
        }
        public List<ImagensModuloFuncao> GetFuncaoIcone(ref Banco pBanco, string pIdPapel, int pIdSis, int pIdMod)
        {
            return vModFuncaoDAL.GetIcones(ref pBanco, pIdPapel, vModFuncaoDAL.FUNCAO, pIdSis, pIdMod);
        }
    }
}
