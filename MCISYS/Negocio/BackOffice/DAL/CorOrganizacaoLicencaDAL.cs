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
    public class CorOrganizacaoLicencaDAL
    {
        public Boolean ExclueRegistroLicOrg(ref Banco pBanco, int pIdOrg)
        {
            string vsSql = @"DELETE
                               FROM COR_ORGANIZACAO_LICENCA 
                              WHERE ID_ORG = @ID_ORG";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG",pIdOrg }
            };
            var vConnect = new Connect();
            return vConnect.delete(ref pBanco, vsSql, Parametro);


        }
        public Boolean InclueRegistroLicOrg(ref Banco pBanco, CorOrganizacaoLicenca pOrgLic)
        {
            string vsSql = @"INSERT INTO COR_ORGANIZACAO_LICENCA (   ID_ORG
	                                                                ,NR_CNPJ_RAIZ
	                                                                ,DS_AMBIENTE
	                                                                ,DS_SIGLA
	                                                                ,DT_LICENCIAMENTO
	                                                                )
                                                                VALUES(
                                                                     @ID_ORG
                                                                    , @NR_CNPJ_RAIZ
                                                                    , @DS_AMBIENTE
                                                                    , @DS_SIGLA
                                                                    , @DT_LICENCIAMENTO
                                                                    )";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG",pOrgLic.ID_ORG },
                {"NR_CNPJ_RAIZ", pOrgLic.NR_CNPJ_RAIZ },
                {"DS_AMBIENTE", pOrgLic.DS_AMBIENTE },
                {"DS_SIGLA", pOrgLic.DS_SIGLA },
                {"DT_LICENCIAMENTO", pOrgLic.DT_LICENCIAMENTO }
            };
            var vConnect = new Connect();
            return vConnect.insert(ref pBanco, vsSql, Parametro);

        }
        
        public CorOrganizacaoLicenca ObtemLicencaOrg(ref Banco pBanco, int pIdOrg)
        {
            string vsSql = @"SELECT ID_ORG
                                  , NR_CNPJ_RAIZ
	                              , DS_AMBIENTE
	                              , CASE WHEN DS_AMBIENTE = 2 THEN
		                            'HOMOLOGACAO' 
	                                WHEN DS_AMBIENTE = 1 THEN
		                            'PRODUCAO' 
	                                WHEN DS_AMBIENTE = 3 THEN
		                            'ACEITE' 
                                 END DS_AMBIENTE_dESC
	                             , DS_SIGLA
	                             , DT_LICENCIAMENTO
                              FROM COR_ORGANIZACAO_LICENCA
                             WHERE ID_ORG = @ID_ORG";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG",pIdOrg }
            };
            return RecuperaRegistro(ref pBanco, vsSql, Parametro);
        }
        private CorOrganizacaoLicenca RecuperaRegistro(ref Banco pBanco, string psSql, Dictionary<string,dynamic> pParametro)
        {
            Boolean bClose = true;
            var RegOrgLic = new CorOrganizacaoLicenca();
            Connect vConnect = new Connect();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResults = vConnect.ObtemFirst(psSql, pParametro, ref vConnectado);
            if (GetResults.HasRows)
            {
                GetResults.Read();
                RegOrgLic.ID_ORG = GetResults.GetInt32(0);
                RegOrgLic.NR_CNPJ_RAIZ = GetResults.GetInt32(1);
                RegOrgLic.DS_AMBIENTE = GetResults.GetInt32(2);
                RegOrgLic.DS_AMBIENTE_DESC = GetResults.GetString(3);
                RegOrgLic.DS_SIGLA = GetResults.GetString(4);
                RegOrgLic.DT_LICENCIAMENTO = GetResults.GetDateTime(5);
            }


            bClose = vConnect.FechaConnection(ref vConnectado);
            return RegOrgLic;

        }
    }
}
