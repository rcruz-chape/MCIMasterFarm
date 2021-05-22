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
    public class SisFuncaoImplementarDAL
    {
        public List<SisFuncaoImplementar> GetObterRegistros(ref Banco pBanco)
        {
            string vsSql = @"SELECT ID_SIS
                            ,ID_MOD
                            ,ID_FUNCAO
	                        ,NM_FUNCAO
	                        ,DS_FUNCAO
	                        ,IND_INCL_REG
	                        ,IND_INCL_ALT
	                        ,IND_EXCL_REG
	                        ,IND_CONS_REG
	                        ,IND_EXECUTE
                        FROM VW_SIS_FUNCAO_IMPLEMENTAR";
            return ObterRegistros(ref pBanco, vsSql);
        }
        private List<SisFuncaoImplementar> ObterRegistros(ref Banco pBanco, string psSql)
        {
            Connect vConnect = new Connect();
            List<SisFuncaoImplementar> vlSisFucaoImplementar = new List<SisFuncaoImplementar>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResultado = vConnect.ObtemLista(psSql, ref vConnectado);
            if (GetResultado.HasRows)
            {
                while(GetResultado.Read())
                {
                    var LinhaImplementar = new SisFuncaoImplementar();
                    LinhaImplementar.ID_SIS = GetResultado.GetInt32(0);
                    LinhaImplementar.ID_MOD = GetResultado.GetInt32(1);
                    LinhaImplementar.ID_FUNCAO = GetResultado.GetInt32(2);
                    LinhaImplementar.NM_FUNCAO = GetResultado.GetString(3);
                    LinhaImplementar.DS_FUNCAO = GetResultado.GetString(4);
                    LinhaImplementar.IND_INCL_REG = GetResultado.GetString(5);
                    LinhaImplementar.IND_INCL_ALT = GetResultado.GetString(6);
                    LinhaImplementar.IND_EXCL_REG = GetResultado.GetString(7);
                    LinhaImplementar.IND_CONS_REG = GetResultado.GetString(8);
                    LinhaImplementar.IND_EXECUTE = GetResultado.GetString(9);
                    vlSisFucaoImplementar.Add(LinhaImplementar);
                }
            }
            var bClose = vConnect.FechaConnection(ref vConnectado);
            return vlSisFucaoImplementar;
        }
    }
}
