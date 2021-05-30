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
    public class CorOrganizacaoDAL
    {
        private Boolean bClose;
        private const string CUSERADMIN = "admin";
        public Boolean ExisteFilhos(ref Banco pBanco, int pIdOrgMae)
        {
            string vsSql = @"SELECT ID_ORG
                               FROM COR_ORGANIZACAO
                              WHERE ID_ORG_MAE = @ID_ORG_MAE";
            var Parametros = new Dictionary<string, dynamic>()
            {
                {"ID_ORG_MAE", pIdOrgMae }
            };
            return ObtemFilhos(ref pBanco, vsSql, Parametros);

        }
        private Boolean ObtemFilhos(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametro )
        {
            Connect vConnect = new Connect();

            Boolean bExisteFIlhos;
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResultado = vConnect.ObtemLista(psSql, ref vConnectado, pParametro);
            bExisteFIlhos = GetResultado.HasRows;
            bClose = vConnect.FechaConnection(ref vConnectado);
            return bExisteFIlhos;
        }

        public int GetIdOrg(ref Banco pBanco)
        {
            var vSeqOrg = new SQ.SQOrg();
            var vSEquences = new Sequences();
            int vIdOrg = 0;
            var vSeqValor = vSEquences.sqMax(vSeqOrg.NomeColuna, vSeqOrg.NomeTabela, ref pBanco);
            vIdOrg = Convert.ToInt32(vSeqValor) + 1;
            return vIdOrg;
        }
        public Boolean fbExclueOrg(ref Banco pBanco, CorOrganizacao pCorOrganizacao)
        {
            string vsSql = @"DELETE 
                               FROM COR_ORGANIZACAO
                             WHERE ID_ORG=@ID_ORG";

            var Parametros = new Dictionary<string, dynamic>()
            {
                { "ID_ORG",pCorOrganizacao.ID_ORG }
            };
            Connect vConnect = new Connect();
            return vConnect.delete(ref pBanco, vsSql, Parametros);
        }
        public Boolean fbAtualizaOrg(ref Banco pBanco, CorOrganizacao pCorOrganizacao)
        {
            string vsSql = @"UPDATE COR_ORGANIZACAO
                                SET NM_ORG = @NM_ORG
	                                ,NM_ORG_RESUMIDO = @NM_ORG_RESUMIDO
	                                ,ID_ORG_MAE = @ID_ORG_MAE 
	                                ,TP_ORG = @TP_ORG
                              WHERE ID_ORG = @ID_ORG";
            var Parametros = new Dictionary<string, dynamic>()
            {
                {"NM_ORG_RESUMIDO",pCorOrganizacao.NM_ORG_RESUMIDO },
                {"ID_ORG_MAE",pCorOrganizacao.ID_ORG_MAE },
                {"ID_ORG",pCorOrganizacao.ID_ORG },
                {"NM_ORG",pCorOrganizacao.NM_ORG },
                {"TP_ORG",pCorOrganizacao.TP_ORG }

            };
            Connect vConnect = new Connect();
            return vConnect.update(ref pBanco, vsSql, Parametros);
        }
        public Boolean fbInsereOrg(ref Banco pBanco, CorOrganizacao pCorOrganizacao)
        {
            string vsSql = @"INSERT INTO COR_ORGANIZACAO (ID_ORG
	                                                     ,NM_ORG
	                                                        ,NM_ORG_RESUMIDO
	                                                        ,ID_ORG_MAE
	                                                        ,TP_ORG
	                                                        )
                                                        VALUES (
	                                                        @ID_ORG
	                                                        ,@NM_ORG
	                                                        ,@NM_ORG_RESUMIDO
	                                                        ,@ID_ORG_MAE
	                                                        ,@TP_ORG
	                                                        )";
            var Parametros = new Dictionary<string, dynamic>()
            {
                {"NM_ORG_RESUMIDO",pCorOrganizacao.NM_ORG_RESUMIDO },
                {"ID_ORG_MAE",pCorOrganizacao.ID_ORG_MAE },
                {"ID_ORG",pCorOrganizacao.ID_ORG },
                {"NM_ORG",pCorOrganizacao.NM_ORG },
                {"TP_ORG",pCorOrganizacao.TP_ORG }

            };
            Connect vConnect = new Connect();
            return vConnect.insert(ref pBanco, vsSql, Parametros);

        }
        public List<CorOrganizacao> ObtemListaOrganizacao(ref Banco pBanco, string pIDUsu)
        {
            string vsSql = @"SELECT  ORG_CAD.ID_ORG
                         ,  ORG_CAD.NM_ORG 
                         ,  ORG_CAD.NM_ORG_RESUMIDO
                         ,  ORG_CAD.ID_ORG_MAE  
                         ,  ORG_CAD.TP_ORG 
                      FROM VW_ORG_CADASTRADAS ORG_CAD
                     INNER JOIN SIS_USUARIO_ORGANIZACAO UORG ON (UORG.ID_ORG = ORG_CAD.ID_ORG)";
            var Parametros = new Dictionary<string, dynamic>();
            if (pIDUsu != CUSERADMIN)
            {
                vsSql += @"WHERE UORG.ID_USU = @ID_USU";
                Parametros.Add("ID_USU",pIDUsu);
            }
            return RecuperaTodasOrgs(ref pBanco, vsSql, Parametros);
        }

        private List<CorOrganizacao> RecuperaTodasOrgs(ref Banco pBanco
                                                      ,string psSql
                                                      ,Dictionary<string, dynamic> pParametros = null)
        {
            Connect vConnect = new Connect();
            List<CorOrganizacao> vListCorOrganizacao = new List<CorOrganizacao>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResultado = vConnect.ObtemLista(psSql, ref vConnectado, pParametros);
            if (GetResultado.HasRows)
            {
                while (GetResultado.Read())
                {
                    var vCorOrganizacao = new CorOrganizacao();
                    vCorOrganizacao.ID_ORG = GetResultado.GetInt32(0);
                    vCorOrganizacao.NM_ORG = GetResultado.GetString(1);
                    vCorOrganizacao.NM_ORG_RESUMIDO = GetResultado.GetString(2);
                    if (!GetResultado.IsDBNull(3))
                    {
                        vCorOrganizacao.ID_ORG_MAE = GetResultado.GetInt32(3);
                    }
                    vCorOrganizacao.TP_ORG = GetResultado.GetInt32(4);
                    vListCorOrganizacao.Add(vCorOrganizacao);
                }
            }
            bClose = vConnect.FechaConnection(ref vConnectado);
            return vListCorOrganizacao;
        }
    }
}
