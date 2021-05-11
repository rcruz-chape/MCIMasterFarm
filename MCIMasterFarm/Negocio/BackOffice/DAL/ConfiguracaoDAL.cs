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
    public class ConfiguracaoDAL
    {
        Connect vConnect = new Connect();
        private List<Configuracao> GetConfig (string psSql, ref Banco pBanco)
        {
            NpgsqlConnection vConexao = vConnect.GetConnection(ref pBanco);
            var vFirst = vConnect.ObtemLista(psSql, ref vConexao);
            if (!vFirst.HasRows)
            {
                vFirst.Close();
                return new List<Configuracao>();
            }
            else
            {
                var vReturn = new List<Configuracao>();
                while (vFirst.Read())
                {
                    var vReg = new Configuracao();
                    vReg.DS_ACAO = vFirst.GetString(0);
                    vReg.NR_KEYCODE = vFirst.GetInt64(1);
                    vReg.NM_FUNCAO = vFirst.GetString(2);
                    vReturn.Add(vReg);
                }
                vFirst.Close();
                return vReturn;
            }
        }
        public List<Configuracao> ObtemConfig(ref Banco pBanco)
        {
            string vsSql = @"SELECT DS_ACAO 
                                  , NR_KEYCODE 
                                  , NM_FUNCAO
                               FROM SIS_CONFIGURACAO";
            var vGetConfig = GetConfig(vsSql, ref pBanco);
            var bClose = vConnect.FechaConnection(ref vConnect.vConnect);
            return vGetConfig;
        }
        public ConfigAcao RetornaConfigAcao()
        {
            ConfigAcao vconfigAcao = new ConfigAcao();
            vconfigAcao.DS_PESQ_ANTERIOR = "DS_PESQ_ANTERIOR";
            vconfigAcao.DS_PESQ_PROXIMO = "DS_PESQ_PROXIMO";
            vconfigAcao.DS_PESQ_REGISTRO = "DS_PESQ_REGISTRO";
            vconfigAcao.DS_TECLA_CAMPOPESQ = "DS_TECLA_CAMPOPESQ";
            vconfigAcao.DS_TECLA_EXCLUIR = "DS_TECLA_EXCLUIR";
            vconfigAcao.DS_TECLA_NOVO = "DS_TECLA_NOVO";
            vconfigAcao.DS_TECLA_SALVAR = "DS_TECLA_SALVAR";
            return vconfigAcao;
        }
    }
}
