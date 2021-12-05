using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.Global;
using MCISYS.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.DAL;

namespace MCISYS.Negocio.BackOffice.DAL
{
    public class DictionaryDAL
    {
        public string NrSisVersao(ref Banco pBanco)
        {
            var vSisSistema = new SisSistemaDAL();
            if (HasNrVersaoSisSistema(ref pBanco))
            {
                return vSisSistema.ObtemVersaoSistema(ref pBanco);
            }
            else
            {
                return "0.0.0.0";
            }

        }
        private Boolean HasNrVersaoSisSistema(ref Banco pBanco)
        {
            string vsSql = @"select * 
                               from information_schema.columns
                              where upper(table_name) = 'SIS_SISTEMA'
                                and upper(column_name) = 'NR_VERSAO'";
            Connect vConnect = new Connect();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResultado = vConnect.ObtemDistinct(vsSql, null, ref vConnectado);
            return GetResultado.HasRows;
        }

    }
}
