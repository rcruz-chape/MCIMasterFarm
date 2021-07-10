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
    public class SisModuloFuncaoDAL
    {
		Connect vConnecte = new Connect();
		public List<SisModuloFuncao> ObtemFuncaoAssociar (ref Banco pBanco, int piTpPapel)
		{ 
			string vsTpModOrg = "O";
			string vsSql = @"SELECT MFUNC.ID_SIS
									  , MFUNC.ID_MOD
									  , MFUNC.ID_FUNCAO
                                FROM  SIS_MODULO_FUNCAO MFUNC 
                                INNER JOIN SIS_MODULO MODU ON (
		                                MODU.ID_SIS = MFUNC.ID_SIS
		                                AND MODU.ID_MOD = MFUNC.ID_MOD
		                                )
                                WHERE MODU.TP_MOD_ORG = @TP_MOD_ORG";
			if (piTpPapel == 0)
			{
				vsTpModOrg = "A";
			}
			var Parametro = new Dictionary<string, dynamic>()
			{
				{"TP_MOD_ORG",vsTpModOrg }
			};
			return RecuperaREgistroMFUNC(ref pBanco, vsSql, Parametro);
			
		}
		private List<SisModuloFuncao> RecuperaREgistroMFUNC(ref Banco pBanco, string psSql, Dictionary<string,dynamic> Parametro)
        {
			List<SisModuloFuncao> vListMFunc = new List<SisModuloFuncao>();
			var Connectado = vConnecte.GetConnection(ref pBanco);
			var GetRows = vConnecte.ObtemLista(psSql,ref Connectado,Parametro);

			if (GetRows.HasRows)
            {
				while(GetRows.Read())
                {
					SisModuloFuncao vMFunc = new SisModuloFuncao();
					vMFunc.ID_SIS = GetRows.GetInt32(0);
					vMFunc.ID_MOD = GetRows.GetInt32(1);
					vMFunc.ID_FUNCAO = GetRows.GetInt32(2);
					vListMFunc.Add(vMFunc);
                }
            }
			return vListMFunc;

        }
		public Boolean fbAssociaListaFuncaoModulo(ref Banco pBanco, List<SisModuloFuncao> plistSisModuloFuncao)
        {
			Boolean vbAssocia = true;
			foreach(var vLinhaSisModuloFuncao in plistSisModuloFuncao)
            {
				vbAssocia = fbAssociaFuncaoModulo(ref pBanco, vLinhaSisModuloFuncao);
				if (vbAssocia == false)
                {
					break;
                }
            }
			return vbAssocia;
        }
        private Boolean fbAssociaFuncaoModulo(ref Banco pBanco, SisModuloFuncao pSisModulo)
        {
            string vsSql = @"INSERT INTO SIS_MODULO_FUNCAO (
															ID_SIS
															,ID_MOD
															,ID_FUNCAO
															)
														VALUES (
															@ID_SIS
															,@ID_MOD
															,@ID_FUNCAO
															)";
			var Parametros = new Dictionary<string, dynamic>()
			{
				{"ID_SIS",pSisModulo.ID_SIS },
				{"ID_MOD",pSisModulo.ID_MOD },
				{"ID_FUNCAO", pSisModulo.ID_FUNCAO }
			};
			var vConnect = new Connect();
			return vConnect.insert(ref pBanco, vsSql, Parametros);
		}
    }
}
