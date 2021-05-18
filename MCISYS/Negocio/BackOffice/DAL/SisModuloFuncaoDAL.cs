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
