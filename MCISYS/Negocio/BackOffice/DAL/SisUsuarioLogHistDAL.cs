using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.Global;
using MCIMasterFarm.Negocio.BackOffice.Model;

namespace MCIMasterFarm.Negocio.BackOffice.DAL
{
    public class SisUsuarioLogHistDAL
    {
        public Boolean InsereHistorico (SisUsuarioLog pSisUsuario, ref Banco pBanco)
        {
            string vsSql = @"INSERT INTO SIS_USUARIO_HIST
                                (ID_USU
                               , DT_LOGIN
                               , DS_HOSTNAME
                               , DS_OS
                               , DS_MAC_ADDRESS
                               , DS_IP_ADDRESS)
                                VALUES
                                (@ID_USU
                               , @DT_LOGIN
                               , @DS_HOSTNAME
                               , @DS_OS
                               , @DS_MAC_ADDRESS
                               , @DS_IP_ADDRESS)
                               ";
            var Parametros = new Dictionary<string, dynamic>
            {
                {"ID_USU",pSisUsuario.ID_USU },
                {"DT_LOGIN",pSisUsuario.DT_LOGIN },
                {"DS_HOSTNAME",pSisUsuario.DS_HOSTNAME },
                {"DS_OS",pSisUsuario.DS_OS },
                {"DS_MAC_ADDRESS",pSisUsuario.DS_MAC_ADDRESS },
                {"DS_IP_ADDRESS",pSisUsuario.DS_IP_ADDRESS }
            };
            var vConnect = new Connect();
            return vConnect.insert(ref pBanco,vsSql, Parametros);
        }
    }
}
