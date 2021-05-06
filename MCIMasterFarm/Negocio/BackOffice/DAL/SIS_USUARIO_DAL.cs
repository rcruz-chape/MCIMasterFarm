using System;
using System.Collections.Generic;
using Npgsql;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.BackOffice.Model;
using MCIMasterFarm.Negocio.Global;

namespace MCIMasterFarm.Negocio.BackOffice.DAL
{
    public class SIS_USUARIO_DAL
    {
        public Boolean atualizaUsuario(SisUsuario psisUsuario, ref Banco pBanco)
        {
            string vsSql = @"UPDATE SIS_USUARIO 
                                SET NM_USU = @NM_USU
                                  , DS_EMAIL = @DS_EMAIL
                                  , DT_LAST_LOGIN = @DT_LAST_LOGIN    
                                 , QTD_LOGIN_SEM_SUCESSO = @QTD_LOGIN_SEM_SUCESSO
                                 , ID_PESSOA_FISICA = @ID_PESSOA_FISICA
                                 , DT_ALTERACAO = @DT_ALTERACAO
                                 , ID_USU_ALT = @ID_USU_ALT
                             WHERE ID_USU = @CD_USUARIO";

            var parametros = new Dictionary<string, dynamic>()
            {
                { "CD_USUARIO", psisUsuario.id_usu },
                { "NM_USU", psisUsuario.nm_usu },
                { "DS_EMAIL", psisUsuario.ds_email },
                { "DT_LAST_LOGIN",psisUsuario.dt_last_login },
                { "QTD_LOGIN_SEM_SUCESSO", psisUsuario.qtd_login_sem_sucesso},
                { "ID_PESSOA_FISICA", psisUsuario.id_pessoa_fisica},
                { "DT_ALTERACAO", psisUsuario.dt_alteracao},
                { "ID_USU_ALT", psisUsuario.id_usu_alt}
            };

            var Connect = new Connect();
            return Connect.update(ref pBanco, vsSql, parametros);
        }
        public Boolean bloqueiaUsuario(SisUsuario psisUsuario, ref Banco pBanco)
        {
            string vsSql = @"UPDATE SIS_USUARIO
                                SET IND_BLOQUEADO = 'S'
                                  , ind_motivo_bloqueio = @IndMotivoBloqueio
                              WHERE ID_USU = @CD_USUARIO";
            var parametros = new Dictionary<string, dynamic>()
            {
                { "CD_USUARIO", psisUsuario.id_usu },
                { "IndMotivoBloqueio", psisUsuario.ind_motivo_bloqueio }
            };
            var Connect = new Connect();
            return Connect.update(ref pBanco, vsSql, parametros);
        }
        public Boolean insereUsuario(SisUsuario sisUSu, ref Banco pBanco)
        {
            string vSql = @"INSERT INTO SIS_USUARIO
                                 ( ID_USU
                                 , NM_USU
                                 , DS_EMAIL
                                 , DT_LAST_LOGIN    
                                 , DS_PWD
                                 , IND_BLOQUEADO
                                 , IND_MOTIVO_BLOQUEIO
                                 , QTD_LOGIN_SEM_SUCESSO
                                 , ID_PESSOA_FISICA
                                 , DT_INCLUSAO
                                 , DT_ALTERACAO
                                 , ID_USU_ALT
                                 , ID_USU_INCL
                                 )
                           VALUES
                                ( @ID_USU
                                 , @NM_USU
                                 , @DS_EMAIL
                                 , @DT_LAST_LOGIN    
                                 , @DS_PWD
                                 , @IND_BLOQUEADO
                                 , @IND_MOTIVO_BLOQUEIO
                                 , @QTD_LOGIN_SEM_SUCESSO
                                 , @ID_PESSOA_FISICA
                                 , @DT_INCLUSAO
                                 , @DT_ALTERACAO
                                 , @ID_USU_ALT
                                 , @ID_USU_INCL
                                 )";
            var parametros = new Dictionary<string, dynamic>()
            {
                { "ID_USU", sisUSu.id_usu },
                { "NM_USU", sisUSu.nm_usu },
                { "DS_EMAIL", sisUSu.ds_email },
                { "DT_LAST_LOGIN", sisUSu.dt_last_login },
                { "DS_PWD", sisUSu.ds_pwd },
                { "IND_BLOQUEADO", sisUSu.ind_bloqueado },
                { "IND_MOTIVO_BLOQUEIO", sisUSu.ind_motivo_bloqueio },
                { "QTD_LOGIN_SEM_SUCESSO", sisUSu.qtd_login_sem_sucesso },
                { "ID_PESSOA_FISICA", sisUSu.id_pessoa_fisica },
                { "DT_INCLUSAO", sisUSu.dt_inclusao },
                { "DT_ALTERACAO", sisUSu.dt_alteracao },
                { "ID_USU_ALT", sisUSu.id_usu_alt },
                { "ID_USU_INCL", sisUSu.id_usu_incl }
            };
            var Connect = new Connect();
            return Connect.insert(ref pBanco, vSql, parametros);
        }


        public Boolean DesbloqueiaUSuario(SisUsuario sisUSu, ref Banco pBanco)
        {
            string vSQl = @"UPDATE MCISYS.SIS_USUARIO
                               SET IND_BLOQUEADO='N', IND_MOTIVO_BLOQUEIO=NULL
                             WHERE ID_USU=@CD_USUARIO";

            ;
            var parametros = new Dictionary<string, dynamic>()
            {
                { "CD_USUARIO", sisUSu.id_usu }

            };
            var vConnect = new Connect();
            return vConnect.update(ref pBanco, vSQl, parametros);
        }
        public Boolean AtualizaSenha(SisUsuario sisUSu, ref Banco pBanco)
        {
            string vSQl = @"update SIS_USUARIO 
                               set ds_pwd = @ds_Senha
                             where id_usu = @cd_usuario";
            var parametros = new Dictionary<string, dynamic>()
            {
                { "cd_usuario", sisUSu.id_usu },
                { "ds_Senha", sisUSu.ds_pwd }

            };
            var vConnect = new Connect();
            return vConnect.update(ref pBanco, vSQl, parametros);
        }
        public SisUsuario ObtemUsuarioReiniciaSenha(string pIDUSU, string pDsEmail, ref Banco pBanco)
        {
            string vsSql= @"select usu.id_usu
                                 , usu.nm_usu 
                                 , usu.ds_email 
                                 , usu.dt_last_login
                                 , usu.ds_pwd 
                                 , usu.ind_bloqueado 
                                 , usu.ind_motivo_bloqueio 
                                 , usu.qtd_login_sem_sucesso 
                                 , usu.id_pessoa_fisica 
                                 , usu.dt_inclusao 
                                 , usu.dt_alteracao 
                                 , usu.id_usu_incl 
                                 , usu.id_usu_alt 
                              from sis_usuario usu
                             where usu.id_usu = @ID_USU
                                or usu.ds_email = @DS_EMAIL";
            var parametros = new Dictionary<string, dynamic>()
            {
                { "ID_USU", pIDUSU },
                { "DS_EMAIL", pDsEmail }
            };
            return RecuperaDBUsuario(ref pBanco, vsSql, parametros);
        }
        public SisUsuario obtemUsuario(string pIDUSU, ref Banco pBanco)
        {
            string vSql = @"select usu.id_usu
                                 , usu.nm_usu 
                                 , usu.ds_email 
                                 , usu.dt_last_login
                                 , usu.ds_pwd 
                                 , usu.ind_bloqueado 
                                 , usu.ind_motivo_bloqueio 
                                 , usu.qtd_login_sem_sucesso 
                                 , usu.id_pessoa_fisica 
                                 , usu.dt_inclusao 
                                 , usu.dt_alteracao 
                                 , usu.id_usu_incl 
                                 , usu.id_usu_alt 
                              from sis_usuario usu
                             where usu.id_usu = @cd_usuario";
            var parametros = new Dictionary<string, dynamic>()
            {
                { "cd_usuario", pIDUSU }
            };
            return RecuperaDBUsuario(ref pBanco, vSql, parametros);
            
        }
        private SisUsuario RecuperaDBUsuario(ref Banco pBanco, string pSql, Dictionary<string, dynamic> pParametros)
        {
            var vConnect = new Connect();
            

            string vSql = vConnect.montaSql(pSql, pParametros);
            var vConnectado = vConnect.GetConnection(ref pBanco);
            vConnectado.Open();
            
            NpgsqlCommand command = new NpgsqlCommand(vSql, vConnectado);
            NpgsqlDataReader reader = command.ExecuteReader();

            var vSisUsuario = new SisUsuario();

            if (reader.HasRows)
            {
                reader.Read();
                vSisUsuario.id_usu = (string)reader.GetValue(reader.GetOrdinal("id_usu"));
                vSisUsuario.nm_usu = (string)reader.GetValue(reader.GetOrdinal("nm_usu"));
                vSisUsuario.ds_email = (string)reader.GetValue(reader.GetOrdinal("ds_email"));
                if  (!reader.IsDBNull(reader.GetOrdinal("dt_last_login")))
                {
                    vSisUsuario.dt_last_login = (DateTime)reader.GetValue(reader.GetOrdinal("dt_last_login"));
                }
                vSisUsuario.ds_pwd = (string)reader.GetValue(reader.GetOrdinal("ds_pwd"));
                vSisUsuario.ind_bloqueado = (string)reader.GetValue(reader.GetOrdinal("ind_bloqueado"));
                if (!reader.IsDBNull(reader.GetOrdinal("ind_motivo_bloqueio")))
                {
                    vSisUsuario.ind_motivo_bloqueio = (int)reader.GetValue(reader.GetOrdinal("ind_motivo_bloqueio"));
                }
                if (!reader.IsDBNull(reader.GetOrdinal("qtd_login_sem_sucesso")))
                {
                    vSisUsuario.qtd_login_sem_sucesso = (int)reader.GetValue(reader.GetOrdinal("qtd_login_sem_sucesso"));
                }
                if (!reader.IsDBNull(reader.GetOrdinal("id_pessoa_fisica")))
                {
                    vSisUsuario.id_pessoa_fisica = (int)reader.GetValue(reader.GetOrdinal("id_pessoa_fisica"));
                }

                vSisUsuario.dt_inclusao = (DateTime)reader.GetValue(reader.GetOrdinal("dt_inclusao"));
                if (!reader.IsDBNull(reader.GetOrdinal("dt_alteracao")))
                {
                    vSisUsuario.dt_alteracao = (DateTime)reader.GetValue(reader.GetOrdinal("dt_alteracao"));
                }
                if (!reader.IsDBNull(reader.GetOrdinal("id_usu_incl")))
                {
                    vSisUsuario.id_usu_incl = (string)reader.GetValue(reader.GetOrdinal("id_usu_incl"));
                }
                
                if (!reader.IsDBNull(reader.GetOrdinal("id_usu_alt")))
                {
                    vSisUsuario.id_usu_alt = (string)reader.GetValue(reader.GetOrdinal("id_usu_alt"));
                }
                reader.Close();

            }
            var bFechar = vConnect.FechaConnection(ref vConnectado);
            return vSisUsuario;


        }
    } 
}
