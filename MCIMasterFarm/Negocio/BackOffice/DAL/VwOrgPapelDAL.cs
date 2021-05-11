﻿using System;
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
