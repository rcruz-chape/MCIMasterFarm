using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.Global;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.BackOffice.Model;

namespace MCIMasterFarm.Negocio.BackOffice.Negocio
{
    public class SysUsuarioLogNEG
    {
        SisUsuarioLogDAL vSisUsuLogado = new SisUsuarioLogDAL();
        public SisUsuarioLog ObtemSisUsuarioLog(ref Banco pBanco, string pIDUsuario)
        {
            return vSisUsuLogado.ObtemUsuarioLogado(pIDUsuario, ref pBanco);
        }
        public Boolean fVerificaSeUsuarioLogado(ref Banco pBanco, SisUsuarioLog psisUsuarioLog, string pIDUsuario)
        {
            Boolean vbUsuarioLogado;
            var vSisUsuarioLogado = vSisUsuLogado.ObtemUsuarioLogado(pIDUsuario,ref pBanco);

            vbUsuarioLogado = (vSisUsuarioLogado == null || vSisUsuarioLogado.ID_USU == null);
            if (!vbUsuarioLogado)
            {
                vbUsuarioLogado = (psisUsuarioLog.DS_MAC_ADDRESS == vSisUsuarioLogado.DS_MAC_ADDRESS);
                if (vbUsuarioLogado)
                {
                    var bExecute = RealizaLogoff(ref pBanco, pIDUsuario);
                }
            }

            if (vbUsuarioLogado)
            {
                var bExecute = vSisUsuLogado.InsereUsuarioLogado(psisUsuarioLog, ref pBanco);
            }
            
            return vbUsuarioLogado;
        }
        public Boolean RealizaLogoff(ref Banco pBanco, string pIDUsu)
        {
            return vSisUsuLogado.DeleteUsuarioLogado(pIDUsu, ref pBanco);
        }
    }
}
