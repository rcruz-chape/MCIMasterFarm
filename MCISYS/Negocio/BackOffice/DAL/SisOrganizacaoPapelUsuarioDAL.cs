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
    public class SisOrganizacaoPapelUsuarioDAL
	{
		Connect vConnect = new Connect();

		public Boolean fbExisteAssociacao(ref Banco pBanco, string pIDUsu, int pIdOrg, string pIDPapel)
        {
			Boolean vbResult;
			Boolean vbClose;
			string vsSql = @"SELECT 1 FROM SIS_ORGANIZACAO_PAPEL 
							  WHERE ID_USU = @ID_USU
								AND ID_ORG = @ID_ORG
								AND ID_PAPEL = @ID_PAPEL";

			var Parametro = new Dictionary<string, dynamic>()
			{
				{ "ID_ORG",pIdOrg },
				{ "ID_PAPEL",pIDPapel },
				{ "ID_USU",pIDUsu }
			};
			var vConnectado = vConnect.GetConnection(ref pBanco);
			var GetResults = vConnect.ObtemLista(vsSql, ref vConnectado, Parametro);
			vbResult = GetResults.HasRows;
			vbClose = vConnect.FechaConnection(ref vConnectado);
			return vbResult;
			
		}

		public Boolean fbExcluiAssociacao(ref Banco pBanco, string pIDUsu = null, int pIdOrg = 0, string pIDPapel = null)
        {
			string vsSql = @"DELETE FROM SIS_ORGANIZACAO_PAPEL";
			var Parametro = new Dictionary<string, dynamic>();
			if (pIdOrg != 0)
            {
				Parametro.Add("ID_ORG", pIdOrg);
            }
			if (pIDPapel != null)
            {
				Parametro.Add("ID_PAPEL", pIDPapel);
			}
			if (pIDUsu != null)
			{
				Parametro.Add("ID_USU", pIDUsu);
			}
			if (Parametro.Count > 0)
            {
				vsSql += " WHERE ";
            }
			if (pIdOrg != 0)
			{
				vsSql += "ID_ORG = @ID_ORG";
				if (Parametro.Count > 1)
				{
					vsSql += " AND ";
				}
			}
			if (pIDPapel != null)
			{
				vsSql += "ID_PAPEL = @ID_PAPEL";
				if (Parametro.Count >= 2)
				{
					vsSql += " AND ";
				}
			}
			if (pIDUsu != null)
			{
				vsSql += "ID_USU = @ID_USU";
			}
			return vConnect.delete(ref pBanco, vsSql, Parametro);
		}
		public Boolean fbExclueAssocia(ref Banco pBanco, SisOrganizacaoPapelUsuario pOPUsu)
        {
			string vsSql = @"DELETE FROM SIS_ORGANIZACAO_PAPEL
						      WHERE ID_ORG = @ID_ORG
								AND ID_PAPEL = @ID_PAPEL
								AND ID_USU = @ID_USU";
			var Parametro = new Dictionary<string, dynamic>()
			{
				{ "ID_ORG",pOPUsu.ID_ORG },
				{ "ID_PAPEL",pOPUsu.ID_PAPEL },
				{ "ID_USU",pOPUsu.ID_USU }
			};
			return vConnect.delete(ref pBanco, vsSql, Parametro);
        }
        public Boolean fbInclueAssocia(ref Banco pBanco, SisOrganizacaoPapelUsuario pOPUsu)
        {
            string vsSql = @"INSERT INTO SIS_ORGANIZACAO_PAPEL_USUARIO (
										   ID_ORG
   										 , ID_PAPEL
									     , ID_USU
										 , ID_USU_INCL
									     , DT_INCLUSAO
											)
									VALUES (
											@ID_ORG
											,@ID_PAPEL
											,@ID_USU
											,@ID_USU_INCL
											,@DT_INCLUSAO
											)";
			var Parametro = new Dictionary<string, dynamic>()
			{
				{ "ID_USU_INCL",pOPUsu.ID_USU_INCL },
				{ "ID_ORG",pOPUsu.ID_ORG },
				{ "ID_PAPEL",pOPUsu.ID_PAPEL },
				{ "ID_USU",pOPUsu.ID_USU },
				{ "DT_INCLUSAO", pOPUsu.DT_INCLUSAO }
			};

			return vConnect.insert(ref pBanco, vsSql, Parametro);
        }
    }
}
