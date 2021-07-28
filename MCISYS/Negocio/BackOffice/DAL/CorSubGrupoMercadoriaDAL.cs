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
    public class CorSubGrupoMercadoriaDAL
    {
        Connect vConnect = new Connect();
        public Boolean bDeleteSubGrupoMercadoria(ref Banco pBanco, int pIDOrg, int pIDGrpMerc, int pIDSubGrpMErc)
        {
            string vsSql = @"DELETE FROM  COR_SUB_GRUPO_MERCADORIA
                              WHERE ID_ORG = @ID_ORG
                                AND ID_GRP_MERC = @ID_GRP_MERC
                                AND ID_SUBGRP_MERC = @ID_SUBGRP_MERC";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", pIDOrg },
                {"ID_GRP_MERC", pIDGrpMerc },
                {"ID_SUBGRP_MERC", pIDSubGrpMErc }
            };
            return vConnect.delete(ref pBanco, vsSql, Parametro);

        }
        public Boolean bUpdateDesAtivaSubGrupoMercadoria(ref Banco pBanco, int pIDOrg, int pIDGrpMerc, int pIDSubGrpMErc = 0)
        {
            string vsSql = @"UPDATE COR_SUB_GRUPO_MERCADORIA
                                SET IND_SUBGRUPO_ATIVO = 'N' 
                              WHERE ID_ORG = @ID_ORG
                                AND ID_GRP_MERC = @ID_GRP_MERC";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG",  pIDOrg},
                {"ID_GRP_MERC", pIDGrpMerc }
            };
            if (pIDSubGrpMErc != 0)
            {
                vsSql += @" AND ID_SUBGRP_MERC = @ID_SUBGRP_MERC";
                Parametro.Add("ID_SUBGRP_MERC", pIDSubGrpMErc);
            }
            return vConnect.update(ref pBanco, vsSql, Parametro);

        }
        public Boolean bUpdateAtivaSubGrupoMercadoria(ref Banco pBanco, int pIDOrg, int pIDGrpMerc, int pIDSubGrpMErc=0)
        {
            string vsSql = @"UPDATE COR_SUB_GRUPO_MERCADORIA
                                SET IND_SUBGRUPO_ATIVO = 'S' 
                              WHERE ID_ORG = @ID_ORG
                                AND ID_GRP_MERC = @ID_GRP_MERC";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG",  pIDOrg},
                {"ID_GRP_MERC", pIDGrpMerc }
            };
            if (pIDSubGrpMErc != 0)
            {
                vsSql += @" AND ID_SUBGRP_MERC = @ID_SUBGRP_MERC";
                Parametro.Add("ID_SUBGRP_MERC", pIDSubGrpMErc);
            }
            return vConnect.update(ref pBanco, vsSql, Parametro);

        }
        public Boolean bUpdateCorSubGrupoMercadoria(ref Banco pBanco, CorSubGrupoMercadoria pCorSubGrupoMercadoria)
        {
            string vsSql = @"UPDATE COR_SUB_GRUPO_MERCADORIA
                                SET NM_SUBGRP_MERC = @NM_SUBGRP_MERC
                                  , ID_USU_ALT = @ID_USU_ALT
                                  , DT_ALTERACAO = @DT_ALTERACAO
                              WHERE ID_ORG = @ID_ORG
                                AND ID_GRP_MERC = @ID_GRP_MERC
                                AND ID_SUBGRP_MERC = @ID_SUBGRP_MERC";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", pCorSubGrupoMercadoria.ID_ORG },
                {"ID_GRP_MERC", pCorSubGrupoMercadoria.ID_GRP_MERC },
                {"ID_SUBGRP_MERC", pCorSubGrupoMercadoria.ID_SUBGRP_MERC },
                {"NM_SUBGRP_MERC", pCorSubGrupoMercadoria.NM_SUBGRP_MERC },
                {"IND_SUBGRUPO_ATIVO", pCorSubGrupoMercadoria.IND_SUBGRUPO_ATIVO },
                {"ID_USU_ALT", pCorSubGrupoMercadoria.ID_USU_ALT },
                {"DT_ALTERACAO", pCorSubGrupoMercadoria.DT_ALTERACAO },
            };
            return vConnect.update(ref pBanco, vsSql, Parametro);
        }
        
        public Boolean bInsereCorSubGrupoMercadoria(ref Banco pBanco, CorSubGrupoMercadoria pCorSubGrupoMercadoria)
        {
            string vsSql = @"INSERT INTO COR_SUB_GRUPO_MERCADORIA
                                         ( ID_ORG
                                         , ID_GRP_MERC
                                         , ID_SUBGRP_MERC
                                         , NM_SUBGRP_MERC
                                         , IND_SUBGRUPO_ATIVO
                                         , ID_USU_INCL
                                         , DT_INCLUSAO)
                                  VALUES ( @ID_ORG
                                         , @ID_GRP_MERC
                                         , @ID_SUBGRP_MERC
                                         , @NM_SUBGRP_MERC
                                         , @IND_SUBGRUPO_ATIVO
                                         , @ID_USU_INCL
                                         , @DT_INCLUSAO)";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", pCorSubGrupoMercadoria.ID_ORG },
                {"ID_GRP_MERC", pCorSubGrupoMercadoria.ID_GRP_MERC },
                {"ID_SUBGRP_MERC", pCorSubGrupoMercadoria.ID_SUBGRP_MERC },
                {"NM_SUBGRP_MERC", pCorSubGrupoMercadoria.NM_SUBGRP_MERC },
                {"IND_SUBGRUPO_ATIVO", pCorSubGrupoMercadoria.IND_SUBGRUPO_ATIVO },
                {"ID_USU_INCL", pCorSubGrupoMercadoria.ID_USU_INCL },
                {"DT_INCLUSAO", pCorSubGrupoMercadoria.DT_INCLUSAO },
            };

            return vConnect.insert(ref pBanco, vsSql, Parametro);
        }
        public CorSubGrupoMercadoria ObtemSubGrupoMercadoria(ref Banco pBanco, int pIdOrg, int pIdGRpMErc, int pIdSubGrpMerc)
        {
            string vsSql = @"SELECT ID_ORG
                                  , ID_GRP_MERC
                                  , ID_SUBGRP_MERC
                                  , NM_SUBGRP_MERC
                                  , IND_SUBGRUPO_ATIVO
                                  , ID_USU_INCL
                                  , DT_INCLUSAO
                                  , ID_USU_ALT
                                  , DT_ALTERACAO
                               FROM COR_SUB_GRUPO_MERCADORIA
                              WHERE ID_ORG = @ID_ORG ";
            if (pIdGRpMErc != 0)
            {
                vsSql += " AND ID_GRP_MERC = @ID_GRP_MERC";
            }
            if (pIdSubGrpMerc != 0)
            {
                vsSql += " AND ID_SUBGRP_MERC = @ID_SUBGRP_MERC";
            }
            var parametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", pIdOrg },
                {"ID_GRP_MERC", pIdGRpMErc },
                {"ID_SUB_GRP_MERC", pIdSubGrpMerc }
            };
            return GetRegistro(ref pBanco, vsSql, parametro);
        }

        public List<CorSubGrupoMercadoria> ObtemListaSubGrupoMercadoria(ref Banco pBanco, int pIdOrg, int pIdGRpMErc = 0)
        {
            string vsSql = @"SELECT ID_ORG
                                  , ID_GRP_MERC
                                  , ID_SUBGRP_MERC
                                  , NM_SUBGRP_MERC
                                  , IND_SUBGRUPO_ATIVO
                                  , ID_USU_INCL
                                  , DT_INCLUSAO
                                  , ID_USU_ALT
                                  , DT_ALTERACAO
                               FROM COR_SUB_GRUPO_MERCADORIA
                              WHERE ID_ORG = @ID_ORG";
            var parametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", pIdOrg }
            };
            if (pIdGRpMErc != 0)
            {
                vsSql += " AND ID_GRP_MERC = @ID_GRP_MERC";
                parametro.Add("ID_GRP_MERC",pIdGRpMErc);
            }
            return GetRegistros(ref pBanco, vsSql, parametro);
        }
        private CorSubGrupoMercadoria GetRegistro(ref Banco pBanco, string psSql, Dictionary<string, dynamic> Parametro)
        {
            CorSubGrupoMercadoria vSubGrupoMercadoria = new CorSubGrupoMercadoria();
            var vConnected = vConnect.GetConnection(ref pBanco);
            var GetResults = vConnect.ObtemFirst(psSql, Parametro,ref vConnected);
            if (GetResults.HasRows)
            {
                GetResults.Read();
                vSubGrupoMercadoria.ID_ORG = GetResults.GetInt32(0);
                vSubGrupoMercadoria.ID_GRP_MERC = GetResults.GetInt32(1);
                vSubGrupoMercadoria.ID_SUBGRP_MERC = GetResults.GetInt32(2);
                vSubGrupoMercadoria.NM_SUBGRP_MERC = GetResults.GetString(3);
                vSubGrupoMercadoria.IND_SUBGRUPO_ATIVO = GetResults.GetString(4);
                vSubGrupoMercadoria.ID_USU_INCL = GetResults.GetString(5);
                vSubGrupoMercadoria.DT_INCLUSAO = GetResults.GetDateTime(6);
                if (!GetResults.IsDBNull(7))
                {
                    vSubGrupoMercadoria.ID_USU_ALT = GetResults.GetString(7);
                }
                if (!GetResults.IsDBNull(8))
                {
                    vSubGrupoMercadoria.DT_ALTERACAO = GetResults.GetDateTime(8);
                }
            }
            var vbClose = vConnect.FechaConnection(ref vConnected);
            return vSubGrupoMercadoria;
        }
        private List<CorSubGrupoMercadoria> GetRegistros(ref Banco pBanco, string psSql, Dictionary<string,dynamic> Parametro)
        {
            List<CorSubGrupoMercadoria> vListSubGrupoMercadoria = new List<CorSubGrupoMercadoria> ();
            var vConnected = vConnect.GetConnection(ref pBanco);
            var GetResults = vConnect.ObtemLista(psSql, ref vConnected, Parametro);
            if (GetResults.HasRows)
            {
                while (GetResults.Read())
                {
                    var vRegLido = new CorSubGrupoMercadoria();
                    vRegLido.ID_ORG = GetResults.GetInt32(0);
                    vRegLido.ID_GRP_MERC = GetResults.GetInt32(1);
                    vRegLido.ID_SUBGRP_MERC = GetResults.GetInt32(2);
                    vRegLido.NM_SUBGRP_MERC = GetResults.GetString(3);
                    vRegLido.IND_SUBGRUPO_ATIVO = GetResults.GetString(4);
                    vRegLido.ID_USU_INCL = GetResults.GetString(5);
                    vRegLido.DT_INCLUSAO = GetResults.GetDateTime(6);
                    if (!GetResults.IsDBNull(7))
                    {
                        vRegLido.ID_USU_ALT = GetResults.GetString(7);
                    }
                    if (!GetResults.IsDBNull(8))
                    {
                        vRegLido.DT_ALTERACAO = GetResults.GetDateTime(8);
                    }
                    vListSubGrupoMercadoria.Add(vRegLido);

                }
            }

            var vbClose = vConnect.FechaConnection(ref vConnected);
            return vListSubGrupoMercadoria;
        }
        public long lGetIDSubGrupoMercadoria(ref Banco pBanco, Dictionary<string, dynamic> Parametro)
        {
            var vSeqSubGrupoMercadoria = new SQ.SQsubGrupoMercadoria();
            var vSEquences = new Sequences();
            long vIdGrpMerc = vSEquences.sqNextCompostaMultipla(vSeqSubGrupoMercadoria.NomeColuna
                                                  , vSeqSubGrupoMercadoria.NomeTabela
                                                  , Parametro
                                                  , ref pBanco);

            return Convert.ToInt16(vIdGrpMerc);
        }
    }
}
