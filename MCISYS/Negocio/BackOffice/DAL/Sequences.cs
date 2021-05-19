using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.DAL;
using MCIMasterFarm.Negocio.Global;

namespace MCISYS.Negocio.BackOffice.DAL
{
    public class Sequences
    {
        public long sqNextComposta(string pNomeColuna
                                 , string pNomeTabela
                                 , string pNomeColunaWhere
                                 , string pValorPesquisa
                                 , ref Banco pBanco)
        {
            string vsSql = "SELECT COALESCE(MAX(";
            long vReturn = 1;
            var Conect = new Connect();
            var vConnectado = Conect.GetConnection(ref pBanco);
            vsSql += pNomeColuna + "),0) + 1";
            vsSql += " FROM " + pNomeTabela;
            vsSql += " WHERE " + pNomeColunaWhere + " = " + pValorPesquisa;
            var vRecord = Conect.ObtemUnico(vsSql, ref vConnectado);
            if (vRecord != null)
            {
                vRecord.Read();
                vReturn = vRecord.GetInt32(0);
            }
            var bClose = Conect.FechaConnection(ref vConnectado);
            return vReturn;
        }
        public long sqNext(string psNomeSequence, ref Banco pBanco)
        {
            var Conect = new Connect();
            var vConnectado = Conect.GetConnection(ref pBanco);
            string vSsql = @"SELECT nextval('" + psNomeSequence + "')";
            var vreturn = Conect.ObtemUnico(vSsql,ref vConnectado);
            vreturn.Read();
            var vIdREturn = vreturn.GetInt64(0);
            var bClose = Conect.FechaConnection(ref vConnectado);
            return vIdREturn;
        }
        public long sqMax(string psNomeColuna, string psNomeTabela, ref Banco pBanco)
        {
            var Conect = new Connect();
            var vConectado = Conect.GetConnection(ref pBanco);
            long vlReturn = 0;
            string vSsql = @"SELECT coalesce(MAX(" + psNomeColuna + "),0) + 1 IND_NUMERO FROM " + psNomeTabela;
            var vreturn = Conect.ObtemUnico(vSsql,ref vConectado);
            if (vreturn == null)
            {
                vlReturn = 1;
            }
            else
            {
                vreturn.Read();
                vlReturn = vreturn.GetInt64(0);
            }
            var bClose = Conect.FechaConnection(ref vConectado);
            // (int)regParametro.GetValue(regParametro.GetOrdinal("IND_NUMERO"));
            return vlReturn;
        }

    }
}
