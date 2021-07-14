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


namespace MCISYS.Negocio.BackOffice.DAL
{
    public class CorUnidadeMedidaDAL
    {
        private Connect vConnect = new Connect();


        public Boolean InsereCorUnidadeMedida(ref Banco pBanco, CorUnidadeMedida corUnidadeMedida)
        {
            string vsSql = @"INSERT INTO COR_UNIDADE_MEDIDA
                                SET ( ID_ORG
                                    , COD_UM
                                    , DESC_UM
                                    , ID_USU_INCL
                                    , DT_INCLUSAO
                                    )
                             VALUES ( @ID_ORG
                                    , @COD_UM
                                    , @DESC_UM
                                    , @ID_USU_INCL
                                    , @DT_INCLUSAO
                                    )";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", corUnidadeMedida.ID_ORG },
                {"COD_UM", corUnidadeMedida.COD_UM },
                {"DESC_UM", corUnidadeMedida.DESC_UM },
                {"ID_USU_INCL", corUnidadeMedida.ID_USU_INCL },
                {"DT_INCLUSAO", corUnidadeMedida.DT_INCLUSAO }
            };
            return vConnect.insert(ref pBanco, vsSql, Parametro);
        }

        public Boolean ExclueCorUnidadeMedida(ref Banco pBanco, int pIdOrg, string pCodUm)
        {
            string vsSql = @"DELETE FROM COR_UNIDADE_MEDIDA
                                   WHERE ID_ORG = @ID_ORG
                                     AND COD_UM = @COD_UM";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", pIdOrg },
                {"COD_UM", pCodUm }
            };
            return vConnect.delete(ref pBanco, vsSql, Parametro);
        }
        public Boolean AtualizaCorUnidadeMedida(ref Banco pBanco, CorUnidadeMedida corUnidadeMedida)
        {
            string vsSql = @"UPDATE COR_UNIDADE_MEDIDA
                                SET DESC_UM = @DESC_UM
                                  , ID_USU_AL = @ID_USU_ALT
                                  , DT_ALTERACAO = @DT_ALTERACAO
                              WHERE ID_ORG = @ID_ORG
                                AND COD_UM = @COD_UM";

            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", corUnidadeMedida.ID_ORG },
                {"COD_UM", corUnidadeMedida.COD_UM },
                {"DESC_UM", corUnidadeMedida.DESC_UM },
                {"ID_USU_ALT", corUnidadeMedida.ID_USU_ALT },
                {"DT_ALTERACAO", corUnidadeMedida.DT_ALTERACAO }
            };

            return vConnect.update(ref pBanco, vsSql, Parametro);

        }
        public List<CorUnidadeMedida> ObtemListaUnidadeMedida(ref Banco pBanco, int pIdOrg)
        {
            string vsSql = @"SELECT ID_ORG
	                              , COD_UM
	                              , DESC_UM
	                              , ID_USU_INCL
	                              , DT_INCLUSAO
	                              , ID_USU_ALT
	                              , DT_ALTERACAO
                               FROM COR_UNIDADE_MEDIDA
                              WHERE ID_ORG = @ID_ORG";

            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", pIdOrg }
            };
            return RecuperaListaCorUnidadeMedida(ref pBanco, vsSql, Parametro);
        }
        public CorUnidadeMedida ObtemUnidadeMedidaSelecionado(ref Banco pBanco, string pCodUm, int pIdOrg)
        {
            string vsSql = @"SELECT ID_ORG
	                              , COD_UM
	                              , DESC_UM
	                              , ID_USU_INCL
	                              , DT_INCLUSAO
	                              , ID_USU_ALT
	                              , DT_ALTERACAO
                               FROM COR_UNIDADE_MEDIDA
                              WHERE ID_ORG = @ID_ORG
                                AND COD_UM = @COD_UM";

            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", pIdOrg },
                {"COD_UM", pCodUm }
            };
            return RecuperaCorUnidadeMedida(ref pBanco, vsSql, Parametro);
        }
        private CorUnidadeMedida RecuperaCorUnidadeMedida(ref Banco pBanco, string psSql, Dictionary<string, dynamic> Parametro)
        {
            CorUnidadeMedida vCorUnidadeMedida = new CorUnidadeMedida();
            Boolean vbTrue;
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResults = vConnect.ObtemFirst(psSql, Parametro, ref vConnectado);
            if (GetResults.HasRows)
            {
                GetResults.Read();
                vCorUnidadeMedida.ID_ORG = GetResults.GetInt32(0);
                vCorUnidadeMedida.COD_UM = GetResults.GetString(1);
                vCorUnidadeMedida.DESC_UM = GetResults.GetString(2);
                vCorUnidadeMedida.ID_USU_INCL = GetResults.GetString(3);
                vCorUnidadeMedida.DT_INCLUSAO = GetResults.GetDateTime(4);
                vCorUnidadeMedida.ID_USU_ALT = GetResults.GetString(5);
                if (!GetResults.IsDBNull(6))
                {
                    vCorUnidadeMedida.DT_ALTERACAO = GetResults.GetDateTime(6);
                }                
            }
            vbTrue = vConnect.FechaConnection(ref vConnectado);
            return vCorUnidadeMedida;
        }
        private List<CorUnidadeMedida> RecuperaListaCorUnidadeMedida(ref Banco pBanco, string psSql, Dictionary<string,dynamic> Parametro)
        {
            Boolean vbTrue;
            var lCorUnidadeMedida = new List<CorUnidadeMedida>();
            var vConnectedado = vConnect.GetConnection(ref pBanco);
            var GetResults = vConnect.ObtemLista(psSql,ref  vConnectedado, Parametro);
            if (GetResults.HasRows)
            {
                while (GetResults.Read())
                {
                    var registro = new CorUnidadeMedida();
                    registro.ID_ORG = GetResults.GetInt32(0);
                    registro.COD_UM = GetResults.GetString(1);
                    registro.DESC_UM = GetResults.GetString(2);
                    registro.ID_USU_INCL = GetResults.GetString(3);
                    registro.DT_INCLUSAO = GetResults.GetDateTime(4);
                    registro.ID_USU_ALT = GetResults.GetString(5);
                    if (!GetResults.IsDBNull(6))
                    {
                        registro.DT_ALTERACAO = GetResults.GetDateTime(6);
                    }
                    lCorUnidadeMedida.Add(registro);                    
                }

            }
            vbTrue = vConnect.FechaConnection(ref vConnectedado);
            return lCorUnidadeMedida;
        }
    }
}
