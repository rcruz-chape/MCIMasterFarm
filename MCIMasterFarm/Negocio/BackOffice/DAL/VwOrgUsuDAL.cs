using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.Global;
using MCIMasterFarm.Negocio.BackOffice.Model;

namespace MCIMasterFarm.Negocio.BackOffice.DAL
{
    public class VwOrgUsuDAL
    {
        public List<VwOrgUsu> ObtemListOrg(ref Banco pBanco,string pIdUsu)
        {
            string vsSql = @"select ORG.NM_ORG_RESUMIDO
                              	  , ORG.ID_ORG
                               from VW_ORG_USUARIO ORG
                              where ORG.ID_USU = @ID_USU";
            var Parametros = new Dictionary<string, dynamic>
            {
                {"ID_USU",pIdUsu }
            };
            return RecuperaListaOrg(ref pBanco, vsSql,Parametros);
        }

        private List<VwOrgUsu> RecuperaListaOrg(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametros)
        {
            var vConnect = new Connect();
            var vList_VwOrgUsu = new List<VwOrgUsu>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResult = vConnect.ObtemLista(psSql,ref vConnectado,pParametros);
            if (GetResult.HasRows)
            {
                while (GetResult.Read())
                {
                    var registro = new VwOrgUsu();
                    registro.NM_ORG_RESUMIDO = GetResult.GetString(0);
                    registro.ID_ORG = GetResult.GetInt32(1);
                    vList_VwOrgUsu.Add(registro);
                }
            }
            var close = vConnect.FechaConnection(ref vConnectado);
            return vList_VwOrgUsu;
        }
    }
}
