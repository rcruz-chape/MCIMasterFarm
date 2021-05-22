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
    }
}
