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
    public class SisModuloDAL
    {
        public string CTPMODADM = "A";
        public string CTPMMODOP = "O";
        public int GetIdMod(int pIdSis, ref Banco pBanco)
        {
            var vSeqModulo = new SQ.SQModulo();
            var vSEquences = new Sequences();
            long vIdMod = vSEquences.sqNextComposta(vSeqModulo.NomeColuna
                                                  , vSeqModulo.NomeTabela
                                                  , vSeqModulo.NomeColunaWhere
                                                  , pIdSis.ToString()
                                                  , ref pBanco);
            return Convert.ToInt16(vIdMod);
        }

        public Boolean fbAlteraModulo(ref Banco pBanco, int pIdSis = 1, int pIdMod = 1)
        {
            string vsSql = @"UPDATE SIS_MODULO
                                SET ID_USU_ALT = @ID_USU_ALT
                                  , DT_ALTERACAO = @DT_ALTERACAO
                              WHERE ID_SIS = @ID_SIS
                                AND ID_MOD = @ID_MOD";
            var Parametros = new Dictionary<string, dynamic>()
            {
                {"ID_MOD", pIdMod },
                {"ID_SIS", pIdSis },
                {"ID_USU_ALT", "admin" },
                {"DT_ALTERACAO",DateTime.Now }
            };
            Connect vConnect = new Connect();
            return vConnect.update(ref pBanco, vsSql, Parametros);

        }
        public Boolean fbInsereModuloLista(ref Banco pBanco, List<SisModulo> plisSisModulo)
        {
            Boolean vReturn = true;
            foreach (var linhaSisModulo in plisSisModulo)
            {
                vReturn = fbInsereModulo(ref pBanco, linhaSisModulo);
                if (vReturn == false)
                {
                    break;
                }
            }
            return vReturn;
        }
        public Boolean fbInsereModulo(ref Banco pBanco, SisModulo pSisModulo)
        {
            string vsSql = @"INSERT INTO SIS_MODULO (
	                                                    ID_MOD
	                                                    ,NM_MOD
	                                                    ,DS_MOD
	                                                    ,DT_INCLUSAO
	                                                    ,DT_ALTERACAO
	                                                    ,ID_SIS
	                                                    ,ID_USU_ALT
	                                                    ,ID_USU_INCL
	                                                    ,DS_SIGLA_MOD
                                                        ,NM_IMAGEM_ICONE
	                                                    )
                                                    VALUES (
	                                                    @ID_MOD
	                                                    ,@NM_MOD
	                                                    ,@DS_MOD
	                                                    ,@DT_INCLUSAO
	                                                    ,@DT_ALTERACAO
	                                                    ,@ID_SIS
	                                                    ,@ID_USU_ALT
	                                                    ,@ID_USU_INCL
	                                                    ,@DS_SIGLA_MOD
                                                        ,@NM_IMAGEM_ICONE
	                                                    )";
            vsSql = vsSql.ToUpper();
            var Parametros = new Dictionary<string, dynamic>()
            {
                {"ID_MOD", pSisModulo.ID_MOD },
                {"ID_SIS", pSisModulo.ID_SIS },
                {"NM_MOD", pSisModulo.NM_MOD },
                {"DS_MOD", pSisModulo.DS_MOD },
                {"DT_INCLUSAO", pSisModulo.DT_INCLUSAO },
                {"DT_ALTERACAO", pSisModulo.DT_ALTERACAO },
                {"DS_SIGLA_MOD", pSisModulo.DS_SIGLA_MOD },
                {"ID_USU_INCL", pSisModulo.ID_USU_INCL },
                {"ID_USU_ALT", pSisModulo.ID_USU_ALT },
                {"NM_IMAGEM_ICONE", pSisModulo.NM_IMAGEM_ICONE }
            };
            Connect vConnect = new Connect();
            return vConnect.insert(ref pBanco, vsSql, Parametros);
        }
        public List<SisModulo> ObtemTodosModulosAssociados(ref Banco pBanco)
        {
            string vsSql = @"SELECT ID_MOD
   	                              , NM_MOD
	                              , DS_MOD
	                              , DT_INCLUSAO
	                              , DT_ALTERACAO
	                              , ID_SIS
	                              , ID_USU_ALT
	                              , ID_USU_INCL
	                              , DS_SIGLA_MOD
                                  , NM_IMAGEM_ICONE
                                  , TP_MOD_ORG
                               FROM SIS_MODULO";

            return RecuperaTodosOsModulosHabilitados(ref pBanco, vsSql);
        }

        public List<SisModulo> ObtemTodosModulosHabilitados(ref Banco pBanco, int pidOrg, int pidSis)
        {
            string vsSql = @"select distinct 
                                    modu.id_mod 
                                  , modu.nm_mod 
                                  , modu.ds_mod 
                                  , modu.dt_inclusao 
                                  , modu.dt_alteracao 
                                  , modu.id_sis 
                                  , modu.id_usu_alt 
                                  , modu.id_usu_incl 
                                  , modu.ds_sigla_mod
                                  , modu.nm_imagem_icone
                                  , modu.tp_mod_org
                               from sis_modulo modu
                               inner join vw_modulo_sistema_habilitado SIS_HAB on (SIS_HAB.id_sis = MODU.id_sis and SIS_HAB.id_mod = modu.id_mod)
                              where SIS_HAB.id_org  = @ID_ORG
                                and SIS_HAB.id_sis  = @ID_SIS";
            vsSql = vsSql.ToUpper();
            var Parametros = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", pidOrg },
                {"ID_SIS", pidSis }
            };
            return RecuperaTodosOsModulosHabilitados(ref pBanco, vsSql, Parametros);
        }

        private List<SisModulo> RecuperaTodosOsModulosHabilitados(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametros = null)
        {
            Connect vConnect = new Connect();
            List<SisModulo> vlSisModulo = new List<SisModulo>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResultado = vConnect.ObtemLista(psSql, ref vConnectado, pParametros);
            if (GetResultado.HasRows)
            {
                while (GetResultado.Read())
                {
                    var RegSisModulo = new SisModulo();
                    RegSisModulo.ID_MOD = GetResultado.GetInt32(0);
                    RegSisModulo.NM_MOD = GetResultado.GetString(1);
                    RegSisModulo.ID_SIS = GetResultado.GetInt32(5);
                    RegSisModulo.DS_MOD = GetResultado.GetString(2);
                    RegSisModulo.DS_SIGLA_MOD = GetResultado.GetString(8);
                    if (!GetResultado.IsDBNull(4))
                    {
                        RegSisModulo.DT_ALTERACAO = GetResultado.GetDateTime(4);
                    }
                    RegSisModulo.DT_INCLUSAO = GetResultado.GetDateTime(3);
                    if (!GetResultado.IsDBNull(6))
                    {
                        RegSisModulo.ID_USU_ALT = GetResultado.GetString(6);
                    }
                    RegSisModulo.ID_USU_INCL = GetResultado.GetString(7);
                    RegSisModulo.NM_IMAGEM_ICONE = GetResultado.GetString(9);
                    RegSisModulo.TP_MOD_ORG = GetResultado.GetString(10);
                    vlSisModulo.Add(RegSisModulo);
                }
            }
            var bClose = vConnect.FechaConnection(ref vConnectado);
            return vlSisModulo;

        }
        public List<SisModulo> ObtemModulosAssociadosPorTipo(ref Banco pBanco, string pTpModOrg)
        {
            string vsSql = @"SELECT ID_MOD
   	                              , NM_MOD
	                              , DS_MOD
	                              , DT_INCLUSAO
	                              , DT_ALTERACAO
	                              , ID_SIS
	                              , ID_USU_ALT
	                              , ID_USU_INCL
	                              , DS_SIGLA_MOD
                                  , NM_IMAGEM_ICONE
                                  , TP_MOD_ORG
                               FROM SIS_MODULO
                              WHERE TP_MOD_ORG = @TP_ORG_MOD";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"TP_MOD_ORG",pTpModOrg }
            };
            return RecuperaTodosOsModulosHabilitados(ref pBanco, vsSql, Parametro);
        }
        public SisModulo ObtemModuloSelecionado(ref Banco pBanco, int pIdMod)
        {
            string vsSql = @"SELECT ID_MOD
   	                              , NM_MOD
	                              , DS_MOD
	                              , DT_INCLUSAO
	                              , DT_ALTERACAO
	                              , ID_SIS
	                              , ID_USU_ALT
	                              , ID_USU_INCL
	                              , DS_SIGLA_MOD
                                  , NM_IMAGEM_ICONE
                                  , TP_MOD_ORG
                               FROM SIS_MODULO
                              WHERE ID_MOD = @ID_MOD";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {
                    "ID_MOD", pIdMod
                }
            };
            return RecuperaModuloUnico(ref pBanco, vsSql, Parametro);

        }
        private SisModulo RecuperaModuloUnico(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametros)
        {
            Connect vConnect = new Connect();
            SisModulo vSisModulo = new SisModulo();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResultado = vConnect.ObtemFirst(psSql, pParametros, ref vConnectado);
            if (GetResultado.HasRows)
            {
                GetResultado.Read();
                vSisModulo.ID_MOD = GetResultado.GetInt32(0);
                vSisModulo.NM_MOD = GetResultado.GetString(1);
                vSisModulo.ID_SIS = GetResultado.GetInt32(5);
                vSisModulo.DS_MOD = GetResultado.GetString(2);
                vSisModulo.DS_SIGLA_MOD = GetResultado.GetString(8);
                if (!GetResultado.IsDBNull(4))
                {
                    vSisModulo.DT_ALTERACAO = GetResultado.GetDateTime(4);
                }
                vSisModulo.DT_INCLUSAO = GetResultado.GetDateTime(3);
                if (!GetResultado.IsDBNull(6))
                {
                    vSisModulo.ID_USU_ALT = GetResultado.GetString(6);
                }
                vSisModulo.ID_USU_INCL = GetResultado.GetString(7);
                vSisModulo.NM_IMAGEM_ICONE = GetResultado.GetString(9);
                vSisModulo.TP_MOD_ORG = GetResultado.GetString(10);
            }
            
            vConnect.FechaConnection(ref vConnectado);
            return vSisModulo;


        }
    }
}
