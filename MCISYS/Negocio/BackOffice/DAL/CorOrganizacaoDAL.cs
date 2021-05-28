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
 
;
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
                    if (GetResultado.GetString(3) != null)
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
