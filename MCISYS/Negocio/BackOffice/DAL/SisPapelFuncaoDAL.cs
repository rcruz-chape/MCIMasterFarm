using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.Global;
using MCISYS.Negocio.BackOffice.Model;
using MCISYS.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.Sequence;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.DAL;


namespace MCISYS.Negocio.BackOffice.DAL
{
    public class SisPapelFuncaoDAL
    {
		public Boolean AssociaFuncoesPapeis(ref Banco pBanco, List<SisPapelFuncao> pListSisPapelFuncao)
        {
			Boolean bInsert = true;
			foreach(var LinhaSisFuncao in pListSisPapelFuncao)
            {
				bInsert = fbInsereFuncaoPapel(ref pBanco, LinhaSisFuncao);
				if (!bInsert)
                {
					break;
                }
            }

			return bInsert;
        }
		public Boolean fbInsereFuncaoPapel(ref Banco pBanco, SisPapelFuncao pSisPapelFuncao)
		{
			string vsSql = @"INSERT INTO SIS_PAPEL_FUNCAO (
								ID_PAPEL
								,ID_SIS
								,ID_MOD
								,ID_FUNCAO
								,IND_INCL_REG
								,IND_INCL_ALT
								,IND_EXCL_REG
								,IND_CONS_REG
								,IND_EXECUTE
								)
							VALUES (
									@ID_PAPEL
								,	@ID_SIS
								,	@ID_MOD
								,	@ID_FUNCAO
								,	@IND_INCL_REG
								,	@IND_INCL_ALT
								,	@IND_EXCL_REG
								,	@IND_CONS_REG
								,	@IND_EXECUTE
								)";
			var Parametros = new Dictionary<string, dynamic>()
			{
				{"ID_PAPEL", pSisPapelFuncao.ID_PAPEL },
				{"ID_SIS", pSisPapelFuncao.ID_SIS },
				{"ID_MOD", pSisPapelFuncao.ID_MOD },
				{"ID_FUNCAO", pSisPapelFuncao.ID_FUNCAO },
				{"IND_INCL_REG", pSisPapelFuncao.ind_incl_reg },
				{"IND_INCL_ALT", pSisPapelFuncao.ind_incl_alt },
				{"IND_EXCL_REG", pSisPapelFuncao.ind_excl_reg },
				{"IND_CONS_REG", pSisPapelFuncao.ind_cons_reg },
				{"IND_EXECUTE", pSisPapelFuncao.ind_execute }
			};
			var vConnect = new Connect();
			return vConnect.insert(ref pBanco, vsSql, Parametros);
		}
		public List<SisPapelFuncao> GetFuncaoLicenciar(ref Banco pBanco, string psIdPapel, int piIdMod)
        {
			string vsSql = @"SELECT MFUNC.ID_SIS
  								  , MFUNC.ID_MOD 
								  , MFUNC.ID_FUNCAO 
								  , 'S' AS IND_INCL_REG
								  , 'S' AS IND_INCL_ALT
								  , 'S' AS IND_EXCL_REG
								  , 'S' AS IND_CONS_REG
								  , 'S' AS IND_EXECUTE
							   FROM SIS_MODULO_FUNCAO MFUNC 
							  INNER JOIN SIS_MODULO MODU ON (MFUNC.ID_SIS = MODU.ID_SIS AND MFUNC.ID_MOD = MODU.ID_MOD)
							  INNER JOIN SIS_FUNCAO FUNC ON (FUNC.ID_FUNCAO = MFUNC.ID_FUNCAO)
							   LEFT JOIN SIS_PAPEL_FUNCAO PFUNC ON (MFUNC.ID_FUNCAO = PFUNC.ID_FUNCAO  
							    AND MFUNC.ID_MOD = PFUNC.ID_MOD 
							    AND MFUNC.ID_SIS = PFUNC.ID_SIS)
							  WHERE PFUNC.ID_FUNCAO IS NULL
							    AND MODU.ID_MOD  = @ID_MOD";
			var Parametros = new Dictionary<string, dynamic>()
			{
				{"ID_MOD",piIdMod }
			};


			return ObtemRegistroPapelFuncaoLicenciar(ref pBanco, vsSql, psIdPapel, Parametros);

        }
		private List<SisPapelFuncao> ObtemRegistroPapelFuncaoLicenciar(ref Banco pBanco, string psSql, string psIdPapel, Dictionary<string, dynamic> Parametro)
        {
			var listSisPapelFuncao = new List<SisPapelFuncao>();
			var vConnect = new Connect();
			var vConnectado = vConnect.GetConnection(ref pBanco);
			var GetResults = vConnect.ObtemLista(psSql, ref vConnectado, Parametro);
			if (GetResults.HasRows)
            {
				while (GetResults.Read())
	            {
					var vRegSisPapelFuncao = new SisPapelFuncao();
					vRegSisPapelFuncao.ID_PAPEL = psIdPapel;
					vRegSisPapelFuncao.ID_SIS = GetResults.GetInt32(0);
					vRegSisPapelFuncao.ID_MOD = GetResults.GetInt32(1);
					vRegSisPapelFuncao.ID_FUNCAO = GetResults.GetInt32(2);
					vRegSisPapelFuncao.ind_incl_reg = GetResults.GetString(3);
					vRegSisPapelFuncao.ind_incl_alt = GetResults.GetString(4);
					vRegSisPapelFuncao.ind_excl_reg = GetResults.GetString(5);
					vRegSisPapelFuncao.ind_cons_reg = GetResults.GetString(6);
					vRegSisPapelFuncao.ind_execute = GetResults.GetString(7);
					listSisPapelFuncao.Add(vRegSisPapelFuncao);
				}
            }
			return listSisPapelFuncao;

        }
	}
}
