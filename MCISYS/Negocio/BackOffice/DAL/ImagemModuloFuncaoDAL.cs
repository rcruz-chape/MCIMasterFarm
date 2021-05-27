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
    public class ImagemModuloFuncaoDAL
    {
        public string TODOS = "T";
        public string MODULOS = "M";
        public string FUNCAO = "F";

        public List<ImagensModuloFuncao> GetIcones (ref Banco pBanco, string pIDPapel, string pTipo, int pIdSis=0, int pIdMod=0)
        {
            string vsSql = @"SELECT (ROW_NUMBER () OVER (ORDER BY MODFUNC.ID_SIS,MODFUNC.ID_MOD,MODFUNC.ID_FUNCAO)-1) IDX
                                  , MODFUNC.ID_SIS
                                  , MODFUNC.ID_MOD
                                  , MODFUNC.ID_FUNCAO
                                  , MODFUNC.NM_IMAGEM_ICONE
                                  , NOME 
                               FROM VW_MODULO_FUNCAO MODFUNC
                              WHERE MODFUNC.ID_PAPEL = @ID_PAPEL";
            if (pTipo == MODULOS)
            {
                vsSql += "      AND MODFUNC.ID_FUNCAO = 0"; 
            }
            else if (pTipo == FUNCAO)
            {
                vsSql += @"      AND MODFUNC.ID_FUNCAO <> 0
                                 AND MODFUNC.ID_SIS = @ID_SIS
                                 AND MODFUNC.ID_MOD = @ID_MOD";
             }
            var Parametros = new Dictionary<string, dynamic>()
            {
                {"ID_PAPEL", pIDPapel }
            };
            if (pTipo == FUNCAO)
            {
                Parametros.Add("ID_SIS", pIdSis);
                Parametros.Add("ID_MOD", pIdMod);
            }
            return RecuperaRegistros(ref pBanco, vsSql, Parametros);
        }
        private List<ImagensModuloFuncao> RecuperaRegistros (ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametros)
        {
            Connect vConnect = new Connect();
            List<ImagensModuloFuncao> vListImModFuncao = new List<ImagensModuloFuncao>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResultado = vConnect.ObtemLista(psSql,ref vConnectado, pParametros);
            if (GetResultado.HasRows)
            {
                while (GetResultado.Read())
                {
                    var linhaRecuperada = new ImagensModuloFuncao();
                    linhaRecuperada.IDX = GetResultado.GetInt32(0);
                    linhaRecuperada.ID_SIS = GetResultado.GetInt32(1);
                    linhaRecuperada.ID_MOD = GetResultado.GetInt32(2);
                    linhaRecuperada.ID_FUNCAO = GetResultado.GetInt32(3);
                    linhaRecuperada.NM_IMAGEM_ICONE = GetResultado.GetString(4);
                    linhaRecuperada.NOME = GetResultado.GetString(5);
                    vListImModFuncao.Add(linhaRecuperada);
                }
            }

            var bClosed = vConnect.FechaConnection(ref vConnectado);
            return vListImModFuncao;
        
        }
    }
}
