﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.Global;
using MCISYS.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.BackOffice.DAL;
namespace MCISYS.Negocio.BackOffice.DAL
{
    public class SisSistemaDAL
    {
        public String ObtemVersaoSistema(ref Banco pBanco)
        {
            string vNrVersao = "1.0.0.0";
            string vsSql = @"SELECT NR_VERSAO
                               FROM SIS_SISTEMA";
            Connect vConnect = new Connect();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResultado = vConnect.ObtemDistinct(vsSql, null, ref vConnectado);
            if (GetResultado.HasRows)
            {
                GetResultado.Read();
                vNrVersao = GetResultado.GetString(0);

            }
            return vNrVersao;


        }
        public SisSistema ObtemSistema(ref Banco pBanco)
        {
            string vsSql = @"SELECT ID_SIS
					                 , NM_SIS
					                 , DS_SIS
					                 , SG_SIS
                                     , NR_VERSAO
					                 , DT_INCLUSAO
					                 , DT_ALTERACAO
					                 , ID_USU_ALT
					                 , ID_USU_INCL
				                  FROM SIS_SISTEMA";
            
            return SelectSistemaHabilitado(ref pBanco, vsSql);
        }
        public SisSistema ObtemSistemaHabilitado(ref Banco pBanco, int pIdORg)
        {
            string vsSql = @"select  
                               SIS.id_sis
                             , SIS_HAB.sistema as nm_sis 
                             , SIS.ds_sis
                             , SIS.sg_sis 
                             , SIS.NR_VERSAO
                             , SIS.dt_inclusao 
                             , SIS.dt_alteracao 
                             , SIS.id_usu_alt 
                             , SIS.id_usu_incl 
                          from sis_sistema SIS
                          inner join vw_modulo_sistema_habilitado SIS_HAB on (SIS_HAB.id_sis = SIS.id_sis)
                         where SIS_HAB.id_org  = @ID_ORG";
            vsSql = vsSql.ToUpper();
            var Parametros = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", pIdORg }
            };
            return SelectSistemaHabilitado(ref pBanco, vsSql, Parametros);
        }
        
        private SisSistema SelectSistemaHabilitado(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametros = null)
        {
            Connect vConnect = new Connect();
            SisSistema vSisSistema = new SisSistema();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResultado = vConnect.ObtemDistinct(psSql,pParametros,ref vConnectado);
            if (GetResultado.HasRows)
            {
                GetResultado.Read();
                vSisSistema.ID_SIS = GetResultado.GetInt32(0);
                vSisSistema.NM_SIS = GetResultado.GetString(1);
                vSisSistema.DS_SIS = GetResultado.GetString(2);
                vSisSistema.SG_SIS = GetResultado.GetString(3);
                vSisSistema.NR_VERSAO = GetResultado.GetString(4);
                vSisSistema.DT_INCLUSAO = GetResultado.GetDateTime(5);
                vSisSistema.DT_ALTERACAO = GetResultado.GetDateTime(6);
                vSisSistema.ID_USU_ALT = GetResultado.GetString(7);
                vSisSistema.ID_USU_INCL = GetResultado.GetString(8);
            }
            var bClose = vConnect.FechaConnection(ref vConnectado);
            return vSisSistema;
        }
        public Boolean bUpdateSistemaVersao(ref Banco pBanco, SisSistema pSisSistema, string pNrVersao, string  pIdUsuAlt)
        {
            string vsSql = @"UPDATE SIS_SISTEMA
                                SET ID_USU_ALT = @ID_USU_ALT
                                  , DT_ALTERACAO = @DT_ALTERACAO
                                  , NR_VERSAO = @NR_VERSAO
                              WHERE ID_SIS = @ID_SIS";
            var Parametros = new Dictionary<string, dynamic>()
            {
                {"ID_USU_ALT", pIdUsuAlt},
                {"DT_ALTERACAO", DateTime.Now },
                {"ID_SIS",pSisSistema.ID_SIS },
                {"NR_VERSAO",pNrVersao }
            };
            Connect vConnect = new Connect();
            return vConnect.update(ref pBanco, vsSql, Parametros);
        }
        public Boolean bUpdateSistema(ref Banco pBanco)
        {
            string vsSql = @"UPDATE SIS_SISTEMA
                                SET ID_USU_ALT = @ID_USU_ALT
                                  , DT_ALTERACAO = @DT_ALTERACAO
                              WHERE ID_SIS = @ID_SIS";
            var Parametros = new Dictionary<string, dynamic>()
            {
                {"ID_USU_ALT", "admin" },
                {"DT_ALTERACAO", DateTime.Now },
                {"ID_SIS",1 }
            };
            Connect vConnect = new Connect();
            return vConnect.update(ref pBanco,vsSql,Parametros);
        }
        public Boolean bInsereSistema(ref Banco pBanco,SisSistema psisSistema)
        {
            string vsSql = @"INSERT INTO sis_sistema
                            (id_sis, nm_sis, ds_sis, sg_sis, nr_versao,dt_inclusao, dt_alteracao, id_usu_alt, id_usu_incl)
                            VALUES(
                            @ID_SIS,
                            @NM_SIS,
                            @DS_SIS,
                            @SG_SIS,
                            @NR_VERSAO,
                            @DT_INCLUSAO,
                            @DT_ALTERACAO,
                            @ID_USU_ALT,
                            @ID_USU_INCL
                            )";
            var Parametros = new Dictionary<string, dynamic>()
            {
                {"ID_SIS", psisSistema.ID_SIS },
                {"NM_SIS", psisSistema.NM_SIS },
                {"DS_SIS", psisSistema.DS_SIS },
                {"SG_SIS", psisSistema.SG_SIS },
                {"NR_VERSAO", psisSistema.NR_VERSAO },
                {"DT_INCLUSAO", psisSistema.DT_INCLUSAO },
                {"DT_ALTERACAO", psisSistema.DT_ALTERACAO },
                {"ID_USU_ALT", psisSistema.ID_USU_ALT },
                {"ID_USU_INCL", psisSistema.ID_USU_INCL }
            };
            Connect vConnect = new Connect();
            return vConnect.insert(ref pBanco, vsSql, Parametros);
        }
    }
}
