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
    public class SisFuncaoDAL
    {
        public Sequences vSequence = new Sequences();
        public SQ.SQFuncao vSeq = new SQ.SQFuncao();

        public Boolean fbInsereGrupoFuncao(ref Banco pBanco, List<SisFuncao> plistSisFuncao)
        {
            Boolean vbInsereGrupo = false;
            foreach(var linhaSisFuncao in plistSisFuncao)
            {
                if (linhaSisFuncao.id_funcao == 0)
                {
                    linhaSisFuncao.id_funcao = Convert.ToInt32(vSequence.sqMax(vSeq.NomeColuna,vSeq.NomeTabela, ref pBanco));
                }
                vbInsereGrupo = fbInsereFuncao(ref pBanco, linhaSisFuncao);
                if (vbInsereGrupo == false)
                {
                    break;
                }
            }
            return vbInsereGrupo;
        }

        public Boolean fbInsereFuncao(ref Banco pBanco, SisFuncao pSisFuncao)
        {
            string vsSql = @"INSERT INTO SIS_FUNCAO (
	                                                ID_FUNCAO
	                                                ,NM_FUNCAO
	                                                ,DS_FUNCAO
	                                                ,IND_INCL_REG
	                                                ,IND_INCL_ALT
	                                                ,IND_EXCL_REG
	                                                ,IND_CONS_REG
	                                                ,IND_EXECUTE
	                                                ,DT_INCLUSAO
	                                                ,DT_ALTERACAO
	                                                ,ID_USU_ALT
	                                                ,ID_USU_INCL
	                                                )
                                                VALUES 
	                                                (
	                                                 @ID_FUNCAO
	                                                ,@NM_FUNCAO
	                                                ,@DS_FUNCAO
	                                                ,@IND_INCL_REG
	                                                ,@IND_INCL_ALT
	                                                ,@IND_EXCL_REG
	                                                ,@IND_CONS_REG
	                                                ,@IND_EXECUTE
	                                                ,@DT_INCLUSAO
	                                                ,@DT_ALTERACAO
	                                                ,@ID_USU_ALT
	                                                ,@ID_USU_INCL
	                                                )";
            var Parametros = new Dictionary<string, dynamic>()
            {
                {"ID_FUNCAO",pSisFuncao.id_funcao},
                {"NM_FUNCAO",pSisFuncao.nm_funcao},
                {"DS_FUNCAO",pSisFuncao.ds_funcao},
                {"IND_INCL_REG",pSisFuncao.ind_incl_reg},
                {"IND_INCL_ALT",pSisFuncao.ind_incl_alt},
                {"IND_EXCL_REG",pSisFuncao.ind_excl_reg},
                {"IND_CONS_REG",pSisFuncao.ind_cons_reg},
                {"IND_EXECUTE",pSisFuncao.ind_execute},
                {"DT_INCLUSAO",pSisFuncao.dt_inclusao},
                {"DT_ALTERACAO",pSisFuncao.dt_alteracao},
                {"ID_USU_ALT",pSisFuncao.id_usu_alt},
                {"ID_USU_INCL",pSisFuncao.id_usu_incl}
            };
            var vConnect = new Connect();
            return vConnect.insert(ref pBanco,vsSql,Parametros);
        }

        public List<SisFuncao> ObtemListaFuncaoHabilitados(ref Banco pBanco, int pidPapel, int pidMod, int pidSIS)
        {
            string vsSql = @"SELECT ID_FUNCAO
                                  , NM_FUNCAO
	                              , DS_FUNCAO
	                              , IND_INCL_REG
	                              , IND_INCL_ALT
	                              , IND_EXCL_REG
	                              , IND_CONS_REG
	                              , IND_EXECUTE
	                              , DT_INCLUSAO
	                              , DT_ALTERACAO
	                              , ID_USU_ALT
	                              , ID_USU_INCL
                               FROM VW_FUNCAO_HABILITADA_PAPEL
                              WHERE ID_PAPEL = @ID_PAPEL 
                                AND ID_SIS = @ID_SIS 
                                AND ID_MOD = @ID_MOD";
            var Parametros = new Dictionary<string, dynamic>()
            {
                {"ID_MOD", pidMod },
                {"ID_SIS", pidSIS },
                {"ID_PAPEL", pidPapel }
            };
            return GetListaFuncao(ref pBanco, vsSql, Parametros);
        }
        public List<SisFuncao> ObtemListaFuncao(ref Banco pBanco)
        {
            string vsSql = @"SELECT ID_FUNCAO
                                  , NM_FUNCAO
	                              , DS_FUNCAO
	                              , IND_INCL_REG
	                              , IND_INCL_ALT
	                              , IND_EXCL_REG
	                              , IND_CONS_REG
	                              , IND_EXECUTE
	                              , DT_INCLUSAO
	                              , DT_ALTERACAO
	                              , ID_USU_ALT
	                              , ID_USU_INCL
                               FROM SIS_FUNCAO";
            return GetListaFuncao(ref pBanco, vsSql);
        }
        private List<SisFuncao> GetListaFuncao(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametros = null)
        {
            Connect vConnect = new Connect();
            List<SisFuncao> vlSisFuncao = new List<SisFuncao>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResultado = vConnect.ObtemLista(psSql, ref vConnectado, pParametros);
            if (GetResultado.HasRows)
            {
                while (GetResultado.Read())
                {
                    var rSisFuncao = new SisFuncao();
                    rSisFuncao.id_funcao = GetResultado.GetInt32(0);
                    rSisFuncao.nm_funcao = GetResultado.GetString(1);
                    rSisFuncao.ds_funcao = GetResultado.GetString(2);
                    rSisFuncao.ind_incl_reg = GetResultado.GetString(3);
                    rSisFuncao.ind_incl_alt = GetResultado.GetString(4);
                    rSisFuncao.ind_excl_reg = GetResultado.GetString(5);
                    rSisFuncao.ind_cons_reg = GetResultado.GetString(6);
                    rSisFuncao.ind_execute = GetResultado.GetString(7);
                    rSisFuncao.dt_inclusao = GetResultado.GetDateTime(8);
                    rSisFuncao.dt_alteracao = GetResultado.GetDateTime(9);
                    rSisFuncao.id_usu_alt = GetResultado.GetString(10);
                    rSisFuncao.id_usu_incl = GetResultado.GetString(11);
                    vlSisFuncao.Add(rSisFuncao);
                }
            }
            var bDisconect = vConnect.FechaConnection(ref vConnectado);
            return vlSisFuncao;
        }
    }
}
