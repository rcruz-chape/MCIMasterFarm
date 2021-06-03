﻿using System;
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
    public class SisOrganizacaoPapelDAL
    {
        private const string CUSUADMIN = "admin";
        public Boolean DeletePapelAssociadoOrg(ref Banco pBanco, SisOrganizacaoPapel pOrganizacaoPapel)
        {
            Boolean vExecuteDelete = true;
            string vsSql = @"DELETE FROM SIS_ORGANIZACAO_PAPEL
                              WHERE ID_ORG = @ID_ORG
                                AND ID_PAPEL = @ID_PAPEL";
            var vParametros = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", pOrganizacaoPapel.ID_ORG },
                {"ID_PAPEL", pOrganizacaoPapel.ID_PAPEL }
            };
            var vConnect = new Connect();
            vExecuteDelete = vConnect.delete(ref pBanco, vsSql, vParametros);
            return vExecuteDelete;

        }
        public Boolean InserePapelAssociadoOrg(ref Banco pBanco, SisOrganizacaoPapel pOrganizacaoPapel)
        {
            Boolean vExecutaInsert = true;
            string vsSql = @"INSERT INTO SIS_ORGANIZACAO_PAPEL (
			                                                   ID_ORG
		                                                     , ID_PAPEL
		                                                     , ID_USU_INCL
		                                                     , DT_INCLUSAO
			                                                   )
	                                                    VALUES (
			                                                   @ID_ORG
		                                                     , @ID_PAPEL
		                                                     , @ID_USU_INCL
		                                                     , @DT_INCLUSAO
	                                                           )";
            var vParametros = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", pOrganizacaoPapel.ID_ORG },
                {"ID_PAPEL", pOrganizacaoPapel.ID_PAPEL },
                {"ID_USU_INCL", pOrganizacaoPapel.ID_USU_INCL },
                {"DT_INCLUSAO", pOrganizacaoPapel.DT_INCLUSAO },
            };
            var vConnect = new Connect();
            vExecutaInsert = vConnect.insert(ref pBanco, vsSql, vParametros);
            return vExecutaInsert;
        }
        public List<SisOrganizacaoPapel> RecuperaPapeisAssociadosOrg(ref Banco pBanco, int pIDOrg, string pIdUsu)
        {
            string vsSql = @"SELECT ID_ORG
	                                 , ID_PAPEL
	                                 , DS_PAPEL
	                                 , ID_USU_INCL
	                                 , DT_INCLUSAO
                                  FROM VW_SIS_ORGANIZACAO
                                 WHERE ID_ORG = @ID_ORG";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", pIDOrg }
            };
            if (pIdUsu != CUSUADMIN)
            {
                vsSql += @"        AND EXISTS (SELECT 1
                                  FROM SIS_ORGANIZACAO_PAPEL_USUARIO OPUSU
                                 WHERE OPUSU.ID_PAPEL = VSORG.ID_PAPEL
                                   AND OPUSU.ID_ORG = VSORG.ID_ORG
                                   AND OPUSU.ID_USU =@ID_USU)";
                Parametro.Add("ID_USU", pIdUsu);
            }


            return RecuperaRegistro(ref pBanco, vsSql, Parametro);
        }
        private List<SisOrganizacaoPapel> RecuperaRegistro(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametro)
        {
            Boolean bClose;
            var listSisOrganizacaoPapel = new List<SisOrganizacaoPapel>();
            Connect vConnect = new Connect();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResultado = vConnect.ObtemLista(psSql, ref vConnectado, pParametro);
            if (GetResultado.HasRows)
            {
                while (GetResultado.Read())
                {
                    var vSisOrganizacaoPapel = new SisOrganizacaoPapel();
                    vSisOrganizacaoPapel.ID_ORG = GetResultado.GetInt32(0);
                    vSisOrganizacaoPapel.ID_PAPEL = GetResultado.GetString(1);
                    vSisOrganizacaoPapel.DS_PAPEL = GetResultado.GetString(2);
                    if (!GetResultado.IsDBNull(3))
                    {
                        vSisOrganizacaoPapel.ID_USU_INCL = GetResultado.GetString(3);
                    }
                    if (!GetResultado.IsDBNull(4))
                    {
                        vSisOrganizacaoPapel.DT_INCLUSAO = GetResultado.GetDateTime(4);
                    }
                    listSisOrganizacaoPapel.Add(vSisOrganizacaoPapel);

                }
            }

            bClose = vConnect.FechaConnection(ref vConnectado);
            return listSisOrganizacaoPapel;
        }
    }
}
