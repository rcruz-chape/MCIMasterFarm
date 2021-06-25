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
    public class VwPUsuDAL
    {
        public List<VwPUsu> ObtemPapelAssociadoUsuario(ref Banco pBanco, string pIdUsu)
        {
            string vsSql = @"SELECT ID_PAPEL
	                                ,ID_USU
	                                ,ID_USU_INCL
	                                ,DT_INCLUSAO
                                FROM VW_SIS_PAP_USU
                                WHERE ID_USU = @ID_USU";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_USU",pIdUsu }
            };
            return ObtemListaRegistro(ref pBanco, vsSql, Parametro);
        }
        public List<VwPUsu> ObtemUsuariosAssociadoPapel(ref Banco pBanco, string pIdPapel)
        {
            string vsSql = @"SELECT ID_PAPEL
	                                ,ID_USU
	                                ,ID_USU_INCL
	                                ,DT_INCLUSAO
                                FROM VW_SIS_PAP_USU
                                WHERE ID_PAPEL = @ID_PAPEL";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_PAPEL",pIdPapel }
            };
            return ObtemListaRegistro(ref pBanco, vsSql, Parametro);
        }


        private List<VwPUsu> ObtemListaRegistro(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametro)
        {
            List<VwPUsu> ListPusu = new List<VwPUsu>();
            Connect vConnect = new Connect();
            var Connected = vConnect.GetConnection(ref pBanco);
            var GetResults = vConnect.ObtemLista(psSql, ref Connected, pParametro);

            if (GetResults.HasRows)
            {
                while (GetResults.Read())
                {
                    var RegPusu = new VwPUsu();
                    RegPusu.ID_PAPEL = GetResults.GetString(0);
                    RegPusu.ID_USU = GetResults.GetString(1);
                    if (!GetResults.IsDBNull(2))
                    {
                        RegPusu.ID_USU_INCL = GetResults.GetString(2);
                    }
                    if (!GetResults.IsDBNull(3))
                    {
                        RegPusu.DT_INCLUSAO = GetResults.GetDateTime(3);
                    }
                    ListPusu.Add(RegPusu);
                }
            }
            return ListPusu;

        }
    }
}
