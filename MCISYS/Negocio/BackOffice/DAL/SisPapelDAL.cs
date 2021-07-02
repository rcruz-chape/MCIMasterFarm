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
    public class SisPapelDAL
    {
        public const string SQLPAPEL = @" SELECT PAP.ID_PAPEL
                                        , PAP.DS_PAPEL 
                                        , PAP.ID_USU_INCL 
                                        , PAP.DT_INCLUSAO 
                                        , PAP.ID_USU_ALT 
                                        , PAP.DT_ALTERACAO
                                        , PAP.TP_PAPEL
                                     FROM SIS_PAPEL PAP";
        private Connect vConnect = new Connect();
        public Boolean DeletePapel(ref Banco pBanco, string pIdPapel)
        {
            string vsSql = @"DELETE
                               FROM SIS_PAPEL
                              WHERE ID_PAPEL = @ID_PAPEL";
            var Parametro = new Dictionary<string, dynamic>();
            Parametro.Add("ID_PAPEL", pIdPapel);

            return vConnect.delete(ref pBanco, vsSql, Parametro);
        }

        public Boolean UpdatePapel(ref Banco pBanco, SisPapel pRegSisPapel)
        {
            string vsSql = @"UPDATE SIS_PAPEL
                                SET DS_PAPEL = @DS_PAPEL
                                  , ID_USU_ALT = @ID_USU_ALT
                                  , DT_ALTERACAO = @DT_ALTERACAO
                                  , TP_PAPEL = @TP_PAPEL
                              WHERE ID_PAPEL = @ID_PAPEL";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_PAPEL", pRegSisPapel.ID_PAPEL },
                {"DS_PAPEL", pRegSisPapel.DS_PAPEL },
                {"ID_USU_ALT", pRegSisPapel.ID_USU_ALT },
                {"DT_ALTERACAO", pRegSisPapel.DT_ALTERACAO},
                {"TP_PAPEL", pRegSisPapel.TP_PAPEL }
            };
            return vConnect.update(ref pBanco,vsSql,Parametro);
                                
        }


        public Boolean InsertPapel(ref Banco pBanco, SisPapel pRegSisPapel)
        {
            string vsSql = @"INSERT INTO SIS_PAPEL
                                  ( ID_PAPEL
                                  , DS_PAPEL
                                  , ID_USU_INCL
                                  , DT_INCLUSAO
                                  , TP_PAPEL
                                    )
                            VALUES( @ID_PAPEL
                                  , @DS_PAPEL
                                  , @ID_USU_INCL
                                  , @DT_INCLUSAO
                                  , @TP_PAPEL
                                    )";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_PAPEL", pRegSisPapel.ID_PAPEL },
                {"DS_PAPEL", pRegSisPapel.DS_PAPEL },
                {"ID_USU_INCL", pRegSisPapel.ID_USU_INCL },
                {"DT_INCLUSAO", pRegSisPapel.DT_INCLUSAO },
                {"TP_PAPEL", pRegSisPapel.TP_PAPEL }
            };
            return vConnect.insert(ref pBanco, vsSql, Parametro);

        }

        public List<SisPapel> ObtemListaPapel(ref Banco pBanco)
        {
            string vsSql = SQLPAPEL;
            return RecuperaRegistroLista(ref pBanco, vsSql, null);
        }

        public SisPapel ObtemPapel(ref Banco pBanco, string pidPapel = null)
        {
            string vIdPapel = pidPapel;
            if (pidPapel == null)
            {
                vIdPapel = "1";
            }
            string vsSql = SQLPAPEL + Environment.NewLine + @"WHERE PAP.ID_PAPEL  = @ID_PAPEL";
            var Parametro = new Dictionary<string, dynamic>()
            {
                {"ID_PAPEL", pidPapel }
            };
            return RecuperaRegistroUnico(ref pBanco, vsSql, Parametro);
        }

        private SisPapel RecuperaRegistroUnico(ref Banco pBanco,string vsSql, Dictionary<string,dynamic> pParametro)
        {
            SisPapel vRegPapel = new SisPapel();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResult = vConnect.ObtemFirst(vsSql, pParametro, ref vConnectado);
            if(GetResult.HasRows)
            {
                GetResult.Read();
                vRegPapel.ID_PAPEL = GetResult.GetString(0);
                vRegPapel.DS_PAPEL = GetResult.GetString(1);
                if (!GetResult.IsDBNull(2))
                {
                    vRegPapel.ID_USU_INCL = GetResult.GetString(2);
                }
                if (!GetResult.IsDBNull(3))
                {
                    vRegPapel.DT_INCLUSAO = GetResult.GetDateTime(3);
                }
                if (!GetResult.IsDBNull(4))
                {
                    vRegPapel.ID_USU_ALT = GetResult.GetString(4);
                }
                if (!GetResult.IsDBNull(5))
                {
                    vRegPapel.DT_ALTERACAO = GetResult.GetDateTime(5);
                }
            }
            var bVlose = vConnect.FechaConnection(ref vConnectado);

            return vRegPapel;

        }
        private List<SisPapel> RecuperaRegistroLista(ref Banco pBanco, string vsSql, Dictionary<string, dynamic> pParametro)
        {
            List<SisPapel> listSisPapel = new List<SisPapel>();
            var vConnectado = vConnect.GetConnection(ref pBanco);
            var GetResult = vConnect.ObtemLista(vsSql,ref vConnectado,pParametro);
            if (GetResult.HasRows)
            {
                while (GetResult.Read())
                {

                    SisPapel vRegPapel = new SisPapel();
                    vRegPapel.ID_PAPEL = GetResult.GetString(0);
                    vRegPapel.DS_PAPEL = GetResult.GetString(1);
                    if (!GetResult.IsDBNull(2))
                    {
                        vRegPapel.ID_USU_INCL = GetResult.GetString(2);
                    }
                    if (!GetResult.IsDBNull(3))
                    {
                        vRegPapel.DT_INCLUSAO = GetResult.GetDateTime(3);
                    }
                    if (!GetResult.IsDBNull(4))
                    {
                        vRegPapel.ID_USU_ALT = GetResult.GetString(4);
                    }
                    if (!GetResult.IsDBNull(5))
                    {
                        vRegPapel.DT_ALTERACAO = GetResult.GetDateTime(5);
                    }
                    listSisPapel.Add(vRegPapel);
                }
            }
            var bVlose = vConnect.FechaConnection(ref vConnectado);
            return listSisPapel;

        }
    }
}
