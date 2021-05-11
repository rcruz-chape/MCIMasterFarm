using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.Global;
using MCIMasterFarm.Negocio.BackOffice.Model;
namespace MCIMasterFarm.Negocio.BackOffice.DAL
{
    public class SisUsuarioLogDAL
    {
        public Boolean DeleteUsuarioLogado(string pIDUsu, ref Banco pBanco)
        {
            string vsSql = @"DELETE
                               FROM SIS_USUARIO_LOG
                              WHERE ID_USU = @ID_USU";
            var Parametros = new Dictionary<string, dynamic>
            {
                {"ID_USU",pIDUsu }
            };
            var vConnect = new Connect();
            return vConnect.delete(ref pBanco, vsSql, Parametros);

        }
        
        public Boolean InsereUsuarioLogado(SisUsuarioLog pSisUsuario, ref Banco pBanco)
        {
            string vsSql = @"INSERT INTO SIS_USUARIO_LOG
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
            return vConnect.insert(ref pBanco, vsSql, Parametros);
        }
        
        public SisUsuarioLog ObtemUsuarioLogado(string pIDUSU, ref Banco pBanco)
        {
            String vsSql = @"SELECT ID_USU, DT_LOGIN, DS_HOSTNAME, DS_OS, DS_MAC_ADDRESS, DS_IP_ADDRESS
                                       FROM SIS_USUARIO_LOG
                                    WHERE ID_USU = @ID_USU";
            var Parametros = new Dictionary<string, dynamic>
            {
                {"ID_USU",pIDUSU }
            };
            return GetSisUsuarioLog(ref pBanco, vsSql, Parametros);
        }
        private SisUsuarioLog GetSisUsuarioLog(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametros)
        {
            var vConnect = new Connect();
            var RegSisUsuarioLog = new SisUsuarioLog();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResult = vConnect.ObtemFirst(pBanco, psSql, pParametros,ref vConnect.vConnect);

            if (GetResult.HasRows)
            {
                while(GetResult.Read())
                {
                    RegSisUsuarioLog.ID_USU = GetResult.GetString(0);
                    RegSisUsuarioLog.DT_LOGIN = GetResult.GetDateTime(1);
                    RegSisUsuarioLog.DS_HOSTNAME = GetResult.GetString(2);
                    RegSisUsuarioLog.DS_OS = GetResult.GetString(3);
                    RegSisUsuarioLog.DS_MAC_ADDRESS = GetResult.GetString(4);
                    RegSisUsuarioLog.DS_IP_ADDRESS = GetResult.GetString(5);

                }
            }

            var Close = vConnect.FechaConnection(ref vConnectado);
            return RegSisUsuarioLog;
        }
    }
}
