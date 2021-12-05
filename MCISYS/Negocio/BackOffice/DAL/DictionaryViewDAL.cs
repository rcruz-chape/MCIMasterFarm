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
    public class DictionaryViewDAL
    {
        private Connect vConnect = new Connect();
        public List<views> RecuperaTodasView(ref Banco pBanco)
        {
            string vsSql = @"select table_name as view_name
                                  , view_definition as view_comand
                               from information_schema.views
                              where table_schema = 'mcisys'";
            return GetTodasViews(ref pBanco, vsSql);
        }
        private List<views> GetTodasViews(ref Banco pBanco, string psSql)
        {
            var ListTodasViews = new List<views>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResults = vConnect.ObtemLista(psSql, ref vConnectado, null);

            if (GetResults.HasRows)
            {
                while (GetResults.Read())
                {
                    views vRecordView = new views();
                    vRecordView.view_name = GetResults.GetString(0);
                    vRecordView.view_command = GetResults.GetString(1);
                    ListTodasViews.Add(vRecordView);

                }
            }
            var bClose = vConnect.FechaConnection(ref vConnectado);
            return ListTodasViews;
            ;

        }
    }
}
