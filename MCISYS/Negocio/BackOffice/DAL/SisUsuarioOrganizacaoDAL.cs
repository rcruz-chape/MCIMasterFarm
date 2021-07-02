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
    public class SisUsuarioOrganizacaoDAL
    {
        private Connect vConnect = new Connect();
        public Boolean ExclueOrgUsu(ref Banco pBanco, int pIdOrg, string pIdUsu)
        {
            string vsSql = @"DELETE FROM SIS_USUARIO_ORGANIZACAO
                              WHERE ID_ORG = @ID_ORG
                                AND ID_USU = @ID_USU";
            var vParametros = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", pIdOrg },
                {"ID_USU", pIdUsu }
            };
            return vConnect.delete(ref pBanco, vsSql, vParametros);
        }

        public Boolean InclueOrgUsu(ref Banco pBanco, SisUsuarioOrganizacao pRegUsuOrg)
        {
            string vsSql = @"INSERT INTO SIS_USUARIO_ORGANIZACAO
                                    ( ID_ORG
                                    , ID_USU
                                    , ID_USU_INCL
                                    , DT_INCLUSAO)
                             VALUES ( @ID_ORG
                                    , @ID_USU
                                    , @ID_USU_INCL
                                    , @DT_INCLUSAO)";
            var vParametros = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", pRegUsuOrg.ID_ORG },
                {"ID_USU_INCL", pRegUsuOrg.ID_USU_INCL },
                {"ID_USU", pRegUsuOrg.ID_USU },
                {"DT_INCLUSAO", pRegUsuOrg.DT_INCLUSAO }
            };
            return vConnect.insert(ref pBanco, vsSql, vParametros);
        }

        public List<SisUsuarioOrganizacao> ObtemUsuariosAssociadosOrg(ref Banco pBanco, int pIdOrg = 0, string pIdUsu = null)
        {
            string vsSql = @"SELECT UORG.ID_ORG
	                              , UORG.ID_USU
	                              , UORG.ID_USU_INCL
	                              , UORG.DT_INCLUSAO
                               FROM SIS_USUARIO_ORGANIZACAO UORG ";
            var Parametros = new Dictionary<string, dynamic>();
            if (pIdOrg != 0)
            {
                vsSql += "WHERE UORG.ID_ORG = @ID_ORG";
                Parametros.Add("ID_ORG", pIdOrg);
            }
            else if (pIdUsu != null)
            {
                vsSql += "WHERE UORG.ID_USU = @ID_USU";
                Parametros.Add("ID_USU", pIdUsu);
            };
            return GetRegistros(ref pBanco, vsSql, Parametros);
        }

        private List<SisUsuarioOrganizacao> GetRegistros(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametro)
        {
            Boolean bClose;
            var vListUsuOrg = new List<SisUsuarioOrganizacao>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetRows = vConnect.ObtemLista(psSql, ref vConnectado, pParametro);
            if (GetRows.HasRows)
            {
                while(GetRows.Read())
                {
                    var UsuOrg = new SisUsuarioOrganizacao();
                    UsuOrg.ID_ORG = GetRows.GetInt32(0);
                    UsuOrg.ID_USU = GetRows.GetString(1);
                    if (!GetRows.IsDBNull(2))
                    {
                        UsuOrg.ID_USU_INCL = GetRows.GetString(2);
                    }
                    UsuOrg.DT_INCLUSAO = GetRows.GetDateTime(3);
                    vListUsuOrg.Add(UsuOrg);
                }
            }

            bClose = vConnect.FechaConnection(ref vConnectado);
            return vListUsuOrg;
        }
    }
}
