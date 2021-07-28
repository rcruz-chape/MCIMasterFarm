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
    public class CorGeneroMercadoriaDAL
    {
        private Connect vConnect = new Connect();
        public CorGeneroMercadoria RecuperaGeneroMercadoria(ref Banco pBanco, int pCodGeneMerc)
        {
            string vsSql = @"SELECT COD_GENE_MERC
                                  , DS_COD_GENE_MERC
                                  , DS_GENE_MERC
                                  , DATA_INI_VIG
                                  , DATA_FIM_VIG
                               FROM COR_GENERO_MERCADORIA
                              WHERE CURRENT_DATE BETWEEN DATA_INI_VIG AND COALESCE(DATA_FIM_VIG,CURRENT_DATE)
                                AND COD_GENE_MERC = @COD_GENE_MERC";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"COD_GENE_MERC",pCodGeneMerc }
            };
            return ObtemCorGeneroMercadoria(ref pBanco, vsSql, Parametro);

        }
        public List<CorGeneroMercadoria> RecuperaListaGeneroMercadoria(ref Banco pBanco)
        {
            string vsSql = @"SELECT COD_GENE_MERC
                                  , DS_COD_GENE_MERC
                                  , DS_GENE_MERC
                                  , DATA_INI_VIG
                                  , DATA_FIM_VIG
                               FROM COR_GENERO_MERCADORIA
                              WHERE CURRENT_DATE BETWEEN DATA_INI_VIG AND COALESCE(DATA_FIM_VIG,CURRENT_DATE)";
            return ObtemListaGeneroMercadoria(ref pBanco, vsSql);
        }
        private CorGeneroMercadoria ObtemCorGeneroMercadoria(ref Banco pBanco, string psSql, Dictionary<string, dynamic> Parametro)
        {
            var Registro = new CorGeneroMercadoria();

            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResults = vConnect.ObtemFirst(psSql, Parametro, ref vConnectado);

            if (GetResults.HasRows)
            {
                GetResults.Read(); 
                Registro.COD_GENE_MERC = GetResults.GetInt32(0);
                Registro.DS_COD_GENE_MERC = GetResults.GetString(1);
                Registro.DS_GENE_MERC = GetResults.GetString(2);
                Registro.DATA_INI_VIG = GetResults.GetDateTime(3);
                if (GetResults.IsDBNull(4))
                {
                    Registro.DATA_FIM_VIG = GetResults.GetDateTime(4);
                }
            }
            var bClose = vConnect.FechaConnection(ref vConnectado);
            return Registro;
        }
        private List<CorGeneroMercadoria> ObtemListaGeneroMercadoria(ref Banco pBanco, string psSQl)
        {
            var vListCorGeneroMercadoria = new List<CorGeneroMercadoria>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResults = vConnect.ObtemLista(psSQl, ref vConnectado);
            
            if (GetResults.HasRows)
            {
                while(GetResults.Read())
                {
                    var Registro = new CorGeneroMercadoria();
                    Registro.COD_GENE_MERC = GetResults.GetInt32(0);
                    Registro.DS_COD_GENE_MERC = GetResults.GetString(1);
                    Registro.DS_GENE_MERC = GetResults.GetString(2);
                    Registro.DATA_INI_VIG = GetResults.GetDateTime(3);
                    if (GetResults.IsDBNull(4))
                    {
                        Registro.DATA_FIM_VIG = GetResults.GetDateTime(4);
                    }
                    vListCorGeneroMercadoria.Add(Registro);
                }
            }
            var bClose = vConnect.FechaConnection(ref vConnectado);
            return vListCorGeneroMercadoria; 
        }

    }
}
