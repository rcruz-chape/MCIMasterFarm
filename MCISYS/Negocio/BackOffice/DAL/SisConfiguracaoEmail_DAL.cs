using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.Global;
using Npgsql;

namespace MCIMasterFarm.Negocio.BackOffice.DAL
{
    public class SisConfiguracaoEmail_DAL
    {
        private SisConfiguracaoEmail fSisConfiguracaoEmail_DataReader(NpgsqlDataReader pDataReader )
        {
            SisConfiguracaoEmail vSisConfiguracaoEmail = new SisConfiguracaoEmail();
            if (pDataReader.HasRows)
            {
                pDataReader.Read();
                //    vParametro.ds_car_especial = (string)regParametro.GetValue(regParametro.GetOrdinal("DS_CAR_ESPECIAL"));
                vSisConfiguracaoEmail.DS_HOST = (string)pDataReader.GetValue(pDataReader.GetOrdinal("DS_HOST"));
                vSisConfiguracaoEmail.BO_ENABLE_SSL = (Boolean)pDataReader.GetValue(pDataReader.GetOrdinal("BO_ENABLE_SSL"));
                vSisConfiguracaoEmail.BO_USE_DEFAULT_CREDENTIALS = (Boolean)pDataReader.GetValue(pDataReader.GetOrdinal("BO_USE_DEFAULT_CREDENTIALS"));
                vSisConfiguracaoEmail.NR_PORT = (int)pDataReader.GetValue(pDataReader.GetOrdinal("NR_PORT"));
                vSisConfiguracaoEmail.DS_EMAIL = (string)pDataReader.GetValue(pDataReader.GetOrdinal("DS_EMAIL"));
                vSisConfiguracaoEmail.DS_SENHA = (string)pDataReader.GetValue(pDataReader.GetOrdinal("DS_SENHA"));
            }
            return vSisConfiguracaoEmail;
        }
        public SisConfiguracaoEmail ObtemCOnfiguracaoEmail(ref Banco pBanco)
        {
            string vsSql = @"SELECT DS_HOST
                                  , NR_PORT
                                  , BO_ENABLE_SSL
                                  , BO_USE_DEFAULT_CREDENTIALS
                                  , DS_EMAIL
                                  , DS_SENHA
                               FROM SIS_CONFIGURACAO_EMAIL"; 

            var vConnect = new Connect();
            var vConnectDriver = vConnect.GetConnection(ref pBanco);
            var vRegConnect = vConnect.ObtemUnico(vsSql, ref vConnect.vConnect);
            var RegConfiguracaoEmail = fSisConfiguracaoEmail_DataReader(vRegConnect);
            var vClose = vConnect.FechaConnection(ref vConnect.vConnect);
            return RegConfiguracaoEmail;
        }
    }
}
