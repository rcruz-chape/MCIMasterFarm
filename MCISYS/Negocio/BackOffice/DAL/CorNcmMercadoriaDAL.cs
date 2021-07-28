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
    public class CorNcmMercadoriaDAL
    {
        private Connect vConnect = new Connect();
        public CorNcmMercadoria RecuperNCM(ref Banco pBanco, string psCodNcm)
        {
            string vsSql = @"SELECT COD_NCM
                                  , COD_GENE_MERC
                                  , DS_NCM
                                  , DATA_INICIO_VIG
                                  , DATA_FINAL_VIG
                               FROM COR_NCM_MERCADORIA
                              WHERE COD_NCM = @COD_NCM";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"COD_NCM", psCodNcm}
            };
            return GetCorNcmMercadoria(vsSql, Parametro, ref pBanco);
        }
        public List<CorNcmMercadoria> RecuperaListaNCM(ref Banco pBanco,int COD_GENE_MERC = 0)
        {
            string vsSql = @"SELECT COD_NCM
                                  , COD_GENE_MERC
                                  , DS_NCM
                                  , DATA_INICIO_VIG
                                  , DATA_FINAL_VIG
                               FROM COR_NCM_MERCADORIA";
            var Parametro = new Dictionary<string, dynamic>();
            if (COD_GENE_MERC != 0)
            {
                vsSql += @" WHERE COD_GENE_MERC = @COD_GENE_MERC";
                Parametro.Add("COD_GENE_MERC", COD_GENE_MERC);
            }
            return GetListaCorNcmMercadoria(vsSql, Parametro, ref pBanco);
        }
        private CorNcmMercadoria GetCorNcmMercadoria(string psSql, Dictionary<string, dynamic> pParametro, ref Banco pBanco)
        {
            var vCorNcmMercadoria = new CorNcmMercadoria();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResults = vConnect.ObtemFirst(psSql, pParametro, ref vConnectado);
            if (GetResults.HasRows)
            {
                GetResults.Read();
               
                vCorNcmMercadoria.COD_NCM = GetResults.GetString(0);
                vCorNcmMercadoria.COD_GENE_MERC = GetResults.GetInt32(1);
                vCorNcmMercadoria.DS_NCM = GetResults.GetString(2);
                vCorNcmMercadoria.DATA_INICIO_VIG = GetResults.GetDateTime(3);
                if (!GetResults.IsDBNull(4))
                {
                    vCorNcmMercadoria.DATA_FINAL_VIG = GetResults.GetDateTime(4);
                }
                                 
            }
            return vCorNcmMercadoria;
        }
        private List<CorNcmMercadoria> GetListaCorNcmMercadoria(string psSql, Dictionary<string, dynamic> pParametro, ref Banco pBanco)
        {
            var vListaCorNcmMercadoria = new List<CorNcmMercadoria>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResults = vConnect.ObtemLista(psSql, ref vConnectado, pParametro);
            if (GetResults.HasRows)
            {
                foreach(GetResults.Read())
                {
                    var vCorNcmMercadoria = new CorNcmMercadoria();
                    vCorNcmMercadoria.COD_NCM = GetResults.GetString(0);
                    vCorNcmMercadoria.COD_GENE_MERC = GetResults.GetInt32(1);
                    vCorNcmMercadoria.DS_NCM = GetResults.GetString(2);
                    vCorNcmMercadoria.DATA_INICIO_VIG = GetResults.GetDateTime(3);
                    if (!GetResults.IsDBNull(4))
                    {
                        vCorNcmMercadoria.DATA_FINAL_VIG = GetResults.GetDateTime(4);
                    }
                    vListaCorNcmMercadoria.Add(vCorNcmMercadoria);

                }
            }
            return vListaCorNcmMercadoria;
        }

    }
}
