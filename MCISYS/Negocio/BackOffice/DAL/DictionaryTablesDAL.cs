using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.Global;
using MCISYS.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.Sequence;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCISYS.DictionarysVersion;

namespace MCISYS.Negocio.BackOffice.DAL
{
    public class DictionaryTablesDAL
    {
        private Connect vConnect = new Connect();
        public List<tables> ObtemListaTabelas(ref Banco pBanco)
        {
            string vsSql = @"SELECT ROW_NUMBER() OVER(ORDER BY TABLE_NAME) AS ID
                                  , TABLE_NAME
                               FROM INFORMATION_SCHEMA.TABLES
                              WHERE TABLE_SCHEMA = @TABLE_SCHEMA
                                AND TABLE_TYPE = @TABLE_TYPE";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"TABLE_SCHEMA","mcisys" },
                {"TABLE_TYPE","BASE TABLE" }
            };
            return RecuperaTodasTabelas(ref pBanco, vsSql, Parametro);
        }
        private List<tables> RecuperaTodasTabelas(ref Banco pBanco, string psSql, Dictionary<string, dynamic> Parametro)
        {
            var ListTodasTabelas = new List<tables>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResults = vConnect.ObtemLista(psSql, ref vConnectado, Parametro);

            if (GetResults.HasRows)
            {
                while(GetResults.Read())
                {
                    tables vRecordTable = new tables();
                    vRecordTable.idTable = GetResults.GetInt32(0);
                    vRecordTable.table_name = GetResults.GetString(1);
                    ListTodasTabelas.Add(vRecordTable);
                }
            }
            var bClose = vConnect.FechaConnection(ref vConnectado);
            return ListTodasTabelas;

        }
    }
}
