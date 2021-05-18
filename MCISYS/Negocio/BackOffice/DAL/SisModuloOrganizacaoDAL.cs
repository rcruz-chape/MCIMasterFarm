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
	public class SisModuloOrganizacaoDAL
	{
		private Boolean fbAssociaOrg(ref Banco pBanco, SisModuloOrganizacao pSisModulo)
		{
			string vsSql = @"INSERT INTO SIS_MODULO_ORGANIZACAO (
																  ID_ORG
																, ID_SIS
																, ID_MOD
																)
															VALUES (
																  @ID_ORG
																, @ID_SIS
																, @ID_MOD
																)";
			var Parametros = new Dictionary<string, dynamic>()
			{
				{"ID_SIS",pSisModulo.ID_SIS },
				{"ID_MOD",pSisModulo.ID_MOD },
				{"ID_ORG", pSisModulo.ID_ORG }
			};
			var vConnect = new Connect();
			return vConnect.insert(ref pBanco, vsSql, Parametros);
		}
		public Boolean fbAssociaListOrg(ref Banco pBanco, List<SisModuloOrganizacao> pSisModulo)
		{
			Boolean vbUpdate = true;
			foreach (var linha in pSisModulo)
			{
				vbUpdate = fbAssociaOrg(ref pBanco, linha);
			}
			return vbUpdate;
		}
	}
}
