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
    public class DictionarySequenceDAL
    {

        private Connect vConnect = new Connect();
        public List<sequence> ObtemSequences(ref Banco pBanco)
        {
            string vsSql = @"select b.sequence_name as sequence_name
                                  , 'create sequence '||b.sequence_name ||' start with '||b.start_value as comand_sequence
                               from information_schema.sequences b
                              where b.sequence_schema = @sequence_schema";
            var vParametros = new Dictionary<string, dynamic>()
            {
                { "sequence_schema","mcisys"}
            };
            return GetSequences(ref pBanco, vsSql, vParametros);
        }
        private List<sequence> GetSequences(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametro)
        {
            var ListTSequences = new List<sequence>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResults = vConnect.ObtemLista(psSql, ref vConnectado, pParametro);
            if (GetResults.HasRows)
            {
                while (GetResults.Read())
                {
                    sequence vRecordSequence = new sequence();
                    vRecordSequence.sequence_name = GetResults.GetString(0);
                    vRecordSequence.comand_sequence = GetResults.GetString(1);
                    ListTSequences.Add(vRecordSequence);
                }
            }

            var bClose = vConnect.FechaConnection(ref vConnectado);
            return ListTSequences;
        }
    }
}
