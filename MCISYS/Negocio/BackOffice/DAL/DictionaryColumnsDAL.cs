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
    public class DictionaryColumnsDAL
    {
        private Connect vConnect = new Connect();
        public List<columns> ObtemTodasColunas(ref Banco pBanco)
        {
            string vsSql = @"select upper(c.table_name) as table_name 
                                     , upper(c.column_name) as column_name 
                                     , c.ordinal_position as indice_col
                                     , upper(case when c.udt_name = 'int4' then 
                                        'integer'
                                       else 
                                        c.udt_name
                                       end) as column_type
                                     , coalesce(c.numeric_precision, c.character_maximum_length) as colunm_lenght
                                     , c.numeric_scale as column_precision     
                                     , c.is_nullable as isNullA 
                                  from information_schema.columns c 
                                 inner join  information_schema.tables a on  (a.table_name = c.table_name and a.table_type = @table_type)
                                 where a.table_schema = @table_schema
                                 order by c.table_name, c.ordinal_position";
            var vParametro = new Dictionary<string, dynamic>()
            {
                {"table_type","BASE TABLE" },
                {"table_schema","mcisys" }
            };
            return GetColumnsDict(ref pBanco, vsSql, vParametro);

        }
        private List<columns> GetColumnsDict(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametro)
        {
            var ListTodasColunas = new List<columns>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResults = vConnect.ObtemLista(psSql, ref vConnectado, pParametro);
            if (GetResults.HasRows)
            {
                while (GetResults.Read())
                {
                    columns ColumnRecord = new columns();
                    ColumnRecord.table_name = GetResults.GetString(0);
                    ColumnRecord.column_name = GetResults.GetString(1);
                    ColumnRecord.indice_col = GetResults.GetInt32(2);
                    ColumnRecord.column_type = GetResults.GetString(3);
                    if (!GetResults.IsDBNull(4))
                    {
                        ColumnRecord.column_lenght = GetResults.GetInt32(4);
                    }
                    if (!GetResults.IsDBNull(5))
                    {
                        ColumnRecord.column_precision = GetResults.GetInt32(5);
                    }
                    ColumnRecord.isNull = GetResults.GetBoolean(6);
                    ListTodasColunas.Add(ColumnRecord);
                }
            }

            var bClose = vConnect.FechaConnection(ref vConnectado);
            return ListTodasColunas;
        }
    }
}
