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
                vSisUsuario.ind_motivo_bloqueio = (int)reader.GetValue(reader.GetOrdinal("ind_motivo_bloqueio"));
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
