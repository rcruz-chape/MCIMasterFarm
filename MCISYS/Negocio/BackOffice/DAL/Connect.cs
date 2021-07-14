using System;
using Npgsql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MCIMasterFarm.Negocio.Global;

namespace MCIMasterFarm.Negocio.BackOffice.DAL
{
    public class Connect 
    {
        private string connString = "";
        public NpgsqlConnection vConnect = new NpgsqlConnection();
        public NpgsqlConnection GetConnection(ref Banco pBanco)
        {
            connString = String.Format(
                    "Server={0};User ID={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                    pBanco.Host,
                    pBanco.User,
                    pBanco.DbName,
                    pBanco.Porta,
                    pBanco.PAssword);
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            this.vConnect = conn;
            connString = "";
            return conn;
        }
        public Boolean FechaConnection(ref NpgsqlConnection pCon)
        {
            try
            {
                pCon.Close();
                return true;
            }
            catch (Exception)
            {
                
                return false;
            }
        }
        public NpgsqlDataReader ObtemUnico(string pSql, ref NpgsqlConnection pConnect )
        {
            string vSql = pSql;

            NpgsqlCommand command = new NpgsqlCommand(vSql,pConnect);
            
            NpgsqlDataReader dataReader = command.ExecuteReader();
            
            return dataReader;
        }
        public NpgsqlDataReader ObtemDistinct(string pSql, Dictionary<string, dynamic> pParametros, ref NpgsqlConnection pConnect)
        {
            string vSql = pSql.ToUpper().Replace("SELECT","SELECT DISTINCT");

            vSql = montaSql(vSql, pParametros);
            NpgsqlCommand command = new NpgsqlCommand(vSql, pConnect);
            NpgsqlDataReader dataReader = command.ExecuteReader();


            return dataReader;
        }

        public NpgsqlDataReader ObtemFirst( string pSql, Dictionary<string, dynamic> pParametros, ref NpgsqlConnection pConnect)
        {
            string vSql = pSql;

            vSql = montaSql(vSql, pParametros);
            NpgsqlCommand command = new NpgsqlCommand(vSql, pConnect);
            NpgsqlDataReader dataReader = command.ExecuteReader();


            return dataReader;
        }
        public NpgsqlDataReader ObtemLista(string pSql, ref NpgsqlConnection pConnect , Dictionary<string, dynamic> pParametros = null )
        {
            string vSql = pSql;

            if (pParametros != null)
            {

                vSql = montaSql(pSql, pParametros);
             
            }
            NpgsqlCommand command = new NpgsqlCommand(vSql, pConnect);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            

            
            return dataReader;
        }
        public string montaSql(string pSql, Dictionary<string, dynamic> pParametros = null)
        {
            string vSql = pSql;
            foreach (var item in pParametros)            
            {
                //  if (item.Value.getType() == typeof(string))
                if (item.Value == null)
                {
                        vSql = vSql.Replace("@" + item.Key, "null"); 
                }
                else
                {
                    var sitem = item.Value;
                    var sitemType = sitem.GetType();
                    if (sitemType == typeof(string))
                    {
                        vSql = vSql.Replace("@" + item.Key, "'" + item.Value + "'");
                    }
                    else if (sitemType == typeof(DateTime))
                    {
                        vSql = vSql.Replace("@" + item.Key, "'" + item.Value + "'");
                    }
                    else if (sitemType == typeof(int))
                    {
                        int variavel = item.Value;
                        vSql = vSql.Replace("@" + item.Key, variavel.ToString());
                    }
                    else if (sitemType == typeof(double))
                    {
                        int variavel = item.Value;
                        vSql = vSql.Replace("@" + item.Key, variavel.ToString());
                    }
                    else if (sitemType == typeof(long))
                    {
                        long variavel = item.Value;
                        vSql = vSql.Replace("@" + item.Key, variavel.ToString());
                    }
                    else if (sitemType == typeof(decimal))
                    {
                        decimal variavel = item.Value;
                        vSql = vSql.Replace("@" + item.Key, variavel.ToString());
                    }
                }
            }
            return vSql;
        }
        public Boolean insert(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametros)
        {
            NpgsqlConnection conn = null;
            NpgsqlCommand cmd = null;
            Boolean vbInsert = true;
            string vSql = montaSql(psSql, pParametros);

            try
            {
                conn = GetConnection(ref pBanco);
                cmd = new NpgsqlCommand(vSql, conn);
                cmd.Prepare();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                var vError = new Error();
                vbInsert = vError.DisplayErrorGrave("Connect.Insert", ex.Message, "Erro ao Inserir");
                vbInsert = false;
                
            }
            finally
            {
                if (cmd != null) cmd.Dispose();
                if (conn != null) vbInsert = FechaConnection(ref conn);
               
            }
            return vbInsert;
        }
        public Boolean delete(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametros)
        {
            NpgsqlConnection conn = null;
            NpgsqlCommand cmd = null;
            Boolean vbDelete = true;
            string vSql = montaSql(psSql, pParametros);

            try
            {
                conn = GetConnection(ref pBanco);
                cmd = new NpgsqlCommand(vSql, conn);
                cmd.Prepare();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            catch (NpgsqlException ex)
            {

                var vError = new Error();
                if (ex.ErrorCode == 23503 || ex.ErrorCode == 23000)
                {
                    vbDelete = vError.DisplayErrorGrave("Connect.Delete", "Não foi possível realizar a exclusão", "Erro ao Excluir"); ;
                }
                else
                {
                    vbDelete = vError.DisplayErrorGrave("Connect.Delete", ex.Message, "Erro ao Excluir");
                }
                vbDelete = false;

            }
            finally
            {
                if (cmd != null) cmd.Dispose();
                if (conn != null) vbDelete = FechaConnection(ref conn);

            }
            return vbDelete;
        }
        public Boolean update(ref Banco pBanco, string psSql, Dictionary<string, dynamic> pParametros)
        {
            NpgsqlConnection conn = null;
            NpgsqlCommand cmd = null;
            Boolean vbUpdate = true;
            string vSql = montaSql(psSql, pParametros);

            try
            {
                conn = GetConnection(ref pBanco);
                cmd = new NpgsqlCommand(vSql, conn);
                cmd.Prepare();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                var vError = new Error();
                vbUpdate = vError.DisplayErrorGrave("Connect.Update", ex.Message, "Erro ao Atualizar");
                vbUpdate = false;

            }
            finally
            {
                if (cmd != null) cmd.Dispose();
                if (conn != null) vbUpdate = FechaConnection(ref conn);

            }
            return vbUpdate;
        }
    }
}
