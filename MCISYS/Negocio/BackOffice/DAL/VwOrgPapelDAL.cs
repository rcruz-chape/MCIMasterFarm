using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.Global;

namespace MCIMasterFarm.Negocio.BackOffice.DAL
{
    public class VwOrgPapelDAL
    {
        public const string CADMIN = "admin";
        public List<VwOrgPapel> ObtemListOrgPapel(ref Banco pBanco, int pIdOrg, string pIdUsu,int pTpPapel)
        {
            string vsSql;
            var Parametros = new Dictionary<string, dynamic>();
            if (pIdUsu == CADMIN)
            {
                vsSql = @"select DS_PAPEL
                               , ID_PAPEL
                            from SIS_PAPEL";
                if (pTpPapel == 0 || pTpPapel == 1)
                {
                    vsSql += Environment.NewLine + @"where TP_PAPEL = @TP_PAPEL ";
                    Parametros.Add("TP_PAPEL", pTpPapel);
                }
                else
                {
                    vsSql += Environment.NewLine + @"where TP_PAPEL IN (0,1) ";
                }

            }
            else
            {
                vsSql = @"select PAP.DS_PAPEL
                              	  , PAP.ID_PAPEL
                               from VW_PAP_USUARIO PAP";
                if (pTpPapel == 0 || pTpPapel == 1)
                {
                    vsSql += Environment.NewLine + @"where TP_PAPEL = @TP_PAPEL ";
                    Parametros.Add("TP_PAPEL", pTpPapel);
                }
                else
                {
                    vsSql += Environment.NewLine + @"where TP_PAPEL IN (0,1) ";
                }
                vsSql += Environment.NewLine + @"and PAP.ID_USU = @ID_USU
                                AND PAP.ID_ORG = @ID_ORG";
                Parametros.Add("ID_USU", pIdUsu);
                Parametros.Add("ID_ORG", pIdOrg);               
            }
            return RecuperaListaPapel(ref pBanco, vsSql, Parametros);

        }
        public VwOrgPapel ObtemPapelSelecionado(ref Banco pBanco,  int pIdOrg, string pIdUsu, string pIDPapel)
        {
            string vsSql = @"select PAP.DS_PAPEL
                              	  , PAP.ID_PAPEL
                               from VW_PAP_USUARIO PAP
                              where PAP.ID_USU = @ID_USU
                                AND PAP.ID_ORG = @ID_ORG
                                AND PAP.ID_PAPEL = @ID_PAPEL";
            var Parametros = new Dictionary<string, dynamic>
            {
                {"ID_USU",pIdUsu },
                {"ID_ORG", pIdOrg },
                {"ID_PAPEL", pIDPapel }
            };
            return RecuperaPapel(ref pBanco,vsSql,Parametros);
        }
        private VwOrgPapel RecuperaPapel(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametros)
        {
            var vConnect = new Connect();
            var vList_VwOrgPapel = new List<VwOrgPapel>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResult = vConnect.ObtemFirst(psSql, pParametros, ref vConnectado);
            var vVwOrgPapel = new VwOrgPapel();
            if (GetResult.HasRows)
            {
                while (GetResult.Read())
                {
                    vVwOrgPapel.DS_PAPEL = GetResult.GetString(0);
                    vVwOrgPapel.ID_PAPEL = GetResult.GetString(1);
                }
            }
            var close = vConnect.FechaConnection(ref vConnectado);
            return vVwOrgPapel;
        }

        public List<VwOrgPapel> ObtemPapelHabilitado(ref Banco pBanco, int pIdOrg, string pIdUsu)
        {
            string vsSql = @"select PAP.DS_PAPEL
                              	  , PAP.ID_PAPEL
                               from VW_PAP_USUARIO PAP
                              where PAP.ID_USU = @ID_USU
                                AND PAP.ID_ORG = @ID_ORG";
            var Parametros = new Dictionary<string, dynamic>
            {
                {"ID_USU",pIdUsu },
                {"ID_ORG", pIdOrg }
            };
            return RecuperaListaPapel(ref pBanco, vsSql, Parametros);

        }
        private List<VwOrgPapel> RecuperaListaPapel(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametros)
        {
            var vConnect = new Connect();
            var vList_VwOrgPapel = new List<VwOrgPapel>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResult = vConnect.ObtemLista(psSql, ref vConnectado,pParametros);
            if (GetResult.HasRows)
            {
                while (GetResult.Read())
                {
                    var registro = new VwOrgPapel();
                    registro.DS_PAPEL = GetResult.GetString(0);
                    registro.ID_PAPEL = GetResult.GetString(1);
                    vList_VwOrgPapel.Add(registro);
                }
            }
            var close = vConnect.FechaConnection(ref vConnectado);
            return vList_VwOrgPapel;
        }
    }

}
