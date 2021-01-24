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
        public NpgsqlConnection GetConnection(ref Banco pBanco)
        {
            connString = String.Format(
                    "Server={0};User ID={1};Database={2};Port={3};Password={4};SSLMode=Prefer",
                    pBanco.Host,
                    pBanco.User,
                    pBanco.DbName,
                    pBanco.Porta,
                    pBanco.PAssword);
            var conn = new NpgsqlConnection(connString);
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
        
        public NpgsqlDataReader ObtemLista(Banco pBanco, string pSql, Dictionary<string, dynamic> pParametros )
        {
            string vSql = pSql;
            
            foreach (var item in pParametros)
            {
                vSql = vSql.Replace("@" + item.Key, item.Value);
            }
            var Connect = GetConnection(ref pBanco);
            NpgsqlCommand command = new NpgsqlCommand(vSql, Connect);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            

            var fCOnexão = FechaConnection(ref Connect);
            
            return dataReader;
        }
        public string montaSql(string pSql, Dictionary<string, dynamic> pParametros)
        {
            string vSql = pSql;
            foreach (var item in pParametros)            
            {
                //  if (item.Value.getType() == typeof(string))
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
                conn.Open();
                cmd = new NpgsqlCommand(vSql, conn);
                cmd.Prepare();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
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
                conn.Open();
                cmd = new NpgsqlCommand(vSql, conn);
                cmd.Prepare();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
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
                conn.Open();
                cmd = new NpgsqlCommand(vSql, conn);
                cmd.Prepare();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
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
