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
    public class CorGrupoMercadoriaDAL
    {
        Connect vConnect = new Connect();

        public int GetIdGrupoMercadoria(int pIdOrg, ref Banco pBanco)
        {
            var vSeqGrupoMercadoria = new SQ.SQGrupoMercadoria();
            var vSEquences = new Sequences();
            long vIdGrpMerc = vSEquences.sqNextComposta(vSeqGrupoMercadoria.NomeColuna
                                                  , vSeqGrupoMercadoria.NomeTabela
                                                  , vSeqGrupoMercadoria.NomeColunaWhere
                                                  , pIdOrg.ToString()
                                                  , ref pBanco);
            return Convert.ToInt16(vIdGrpMerc);
        }
        public Boolean fbExclueGrupoMercadoria(ref Banco pBanco, int pIdOrg, int pIdGrpMerc)
        {
            string vsSql = @"DELETE
                               FROM COR_GRUPO_MERCADORIA
                              WHERE ID_ORG = @ID_ORG
                                AND ID_GRP_MERC = @ID_GRP_MERC";
            var vParametro = new Dictionary<string, dynamic>()
            {
                { "ID_ORG", pIdOrg },
                { "ID_GRP_MERC", pIdGrpMerc }
            };
            return vConnect.delete(ref pBanco, vsSql, vParametro);
        }
        public Boolean fbUpdateAtivaInativaGrupoMercadoria(ref Banco pBanco, int pIdOrg, int pIdGrpMerc, string SituacaoGrp)
        {
            string vsSql = @"UPDATE COR_GRUPO_MERCADORIA
                                SET IND_GRUPO_ATIVO = @IND_GRUPO_ATIVO
                              WHERE ID_ORG = @ID_ORG
                                AND ID_GRP_MERC = @ID_GRP_MERC";
            var vParametro = new Dictionary<string, dynamic>()
            {
                { "ID_ORG", pIdOrg },
                { "ID_GRP_MERC", pIdGrpMerc },
                { "IND_GRUPO_ATIVO", SituacaoGrp }
            };
            return vConnect.update(ref pBanco, vsSql, vParametro);

        }
        public Boolean fbUpdateGrupoMercadoria(ref Banco pBanco, CorGrupoMercadoria pREgistro)
        {
            string vsSql = @"UPDATE COR_GRUPO_MERCADORIA
                                SET NM_GRP_MERC = @NM_GRP_MERC
                                  , ID_USU_ALT = @ID_USU_ALT
                                  , DT_ALTERACAO = DT_ALTERACAO
                              WHERE ID_ORG = @ID_ORG
                                AND ID_GRP_MERC = @ID_GRP_MERC";
            var vParametro = new Dictionary<string, dynamic>()
            {
                { "ID_ORG", pREgistro.ID_ORG },
                { "ID_GRP_MERC", pREgistro.ID_GRP_MERC },
                { "NM_GRP_MERC", pREgistro.NM_GRP_MERC },
                { "IND_GRUPO_ATIVO", pREgistro.IND_GRUPO_ATIVO },
                { "ID_USU_ALT", pREgistro.ID_USU_ALT },
                { "DT_ALTERACAO", pREgistro.DT_ALTERACAO }
            };
            return vConnect.update(ref pBanco, vsSql, vParametro);

        }
        public Boolean fbInsereGrupoMercadoria(ref Banco pBanco, CorGrupoMercadoria pREgistro)
        {
            string vsSql = @"INSERT INTO COR_GRUPO_MERCADORIA
                                     ( ID_ORG
                                     , ID_GRP_MERC
                                     , NM_GRP_MERC
                                     , IND_GRUPO_ATIVO
                                     , ID_USU_INCL
                                     , DT_INCLUSAO
                                     )
                               VALUES( @ID_ORG
                                     , @ID_GRP_MERC
                                     , @NM_GRP_MERC
                                     , @IND_GRUPO_ATIVO
                                     , @ID_USU_INCL
                                     , @DT_INCLUSAO
                                     )";
            var vParametro = new Dictionary<string, dynamic>()
            {
                { "ID_ORG", pREgistro.ID_ORG },
                { "ID_GRP_MERC", pREgistro.ID_GRP_MERC },
                { "NM_GRP_MERC", pREgistro.NM_GRP_MERC },
                { "IND_GRUPO_ATIVO", pREgistro.IND_GRUPO_ATIVO },
                { "ID_USU_INCL", pREgistro.ID_USU_INCL },
                { "DT_INCLUSAO", pREgistro.DT_INCLUSAO }
            };
            return vConnect.insert(ref pBanco, vsSql, vParametro);
        }
        public CorGrupoMercadoria ObtemRegistroCorGrupoMercadoria(ref Banco pBanco, int pIdOrg, int pIdGrpMerc)
        {
            var vsSql = @"SELECT ID_ORG
                               , ID_GRP_MERC
                               , NM_GRP_MERC
                               , IND_GRUPO_ATIVO
                               , ID_USU_INCL
                               , DT_INCLUSAO
                               , ID_USU_ALT
                               , DT_ALTERACAO
                            FROM COR_GRUPO_MERCADORIA
                           WHERE ID_ORG = @ID_ORG
                             AND ID_GRP_MERC = @ID_GRP_MERC";
            var vParametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", pIdOrg },
                {"ID_GRP_MERC", pIdGrpMerc }
            };
            return RecuperaRegistroGrupoMercadoria(ref pBanco,vsSql,vParametro);
        }
        public List<CorGrupoMercadoria> ObtemListaGrupoMercadoria(ref Banco pBanco, int pIdOrg)
        {
            var vsSql = @"SELECT ID_ORG
                               , ID_GRP_MERC
                               , NM_GRP_MERC
                               , IND_GRUPO_ATIVO
                               , ID_USU_INCL
                               , DT_INCLUSAO
                               , ID_USU_ALT
                               , DT_ALTERACAO
                            FROM COR_GRUPO_MERCADORIA
                           WHERE ID_ORG = @ID_ORG";
            var vParametro = new Dictionary<string, dynamic>()
            {
                {"ID_ORG", pIdOrg }
            };
            return RecuperaListaGrupoMercadoria(ref pBanco, vsSql, vParametro);
        }
        private CorGrupoMercadoria RecuperaRegistroGrupoMercadoria(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametro)
        {

            var RegCorGrupoMercadoria = new CorGrupoMercadoria();
            Boolean vbConsulta;
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResult = vConnect.ObtemFirst(psSql, pParametro, ref vConnectado);
            if (GetResult.HasRows)
            {
                GetResult.Read();
                RegCorGrupoMercadoria.ID_ORG = GetResult.GetInt32(0);
                RegCorGrupoMercadoria.ID_GRP_MERC = GetResult.GetInt32(1);
                RegCorGrupoMercadoria.NM_GRP_MERC = GetResult.GetString(2);
                RegCorGrupoMercadoria.IND_GRUPO_ATIVO = GetResult.GetString(3);
                RegCorGrupoMercadoria.ID_USU_INCL = GetResult.GetString(4);
                RegCorGrupoMercadoria.DT_INCLUSAO = GetResult.GetDateTime(5);
                if (!GetResult.IsDBNull(6))
                {
                    RegCorGrupoMercadoria.ID_USU_ALT = GetResult.GetString(6);
                }
                if (!GetResult.IsDBNull(7))
                {
                    RegCorGrupoMercadoria.DT_ALTERACAO = GetResult.GetDateTime(7);
                }

            }
            vbConsulta = vConnect.FechaConnection(ref vConnectado);

            return RegCorGrupoMercadoria;
        }
        private List<CorGrupoMercadoria> RecuperaListaGrupoMercadoria(ref Banco pBanco, string psSql, Dictionary<string,dynamic> pParametro)
        {
            Boolean vbConsulta;
            List<CorGrupoMercadoria> vListCorGrupoMercadoria = new List<CorGrupoMercadoria>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResults = vConnect.ObtemLista(psSql,ref vConnectado,pParametro);

            if (GetResults.HasRows)
            {
                while(GetResults.Read())
                {
                    var RegCorGrupoMercadoria = new CorGrupoMercadoria();
                    RegCorGrupoMercadoria.ID_ORG = GetResults.GetInt32(0);
                    RegCorGrupoMercadoria.ID_GRP_MERC = GetResults.GetInt32(1);
                    RegCorGrupoMercadoria.NM_GRP_MERC = GetResults.GetString(2);
                    RegCorGrupoMercadoria.IND_GRUPO_ATIVO = GetResults.GetString(3);
                    RegCorGrupoMercadoria.ID_USU_INCL = GetResults.GetString(4);
                    RegCorGrupoMercadoria.DT_INCLUSAO = GetResults.GetDateTime(5);
                    if (!GetResults.IsDBNull(6))
                    {
                        RegCorGrupoMercadoria.ID_USU_ALT = GetResults.GetString(6);
                    }
                    if (!GetResults.IsDBNull(7))
                    {
                        RegCorGrupoMercadoria.DT_ALTERACAO = GetResults.GetDateTime(7);
                    }
                    vListCorGrupoMercadoria.Add(RegCorGrupoMercadoria);
                }
            }

            vbConsulta = vConnect.FechaConnection(ref vConnectado);
            return vListCorGrupoMercadoria;

        }

    }
}
