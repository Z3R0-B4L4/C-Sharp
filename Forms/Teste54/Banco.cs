using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Teste54
{
    internal class Banco
    {

        private static MySqlConnection con;//connection

        private static MySqlConnection Connect() 
        {
            con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=/*/*;database=teste54;");
            con.Open();
            return con;
        }

        public static DataTable getAllUsers() 
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Connect().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_users";
                    da = new MySqlDataAdapter(cmd.CommandText, Connect());
                    da.Fill(dt);
                    Connect().Close();
                    return dt;
                }
                
            }
            catch (Exception ex)
            {
                Connect().Close();
                throw ex;
            }
            
        }

        public static DataTable read(string sql) 
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = Connect().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new MySqlDataAdapter(cmd.CommandText, Connect());
                    da.Fill(dt);
                    Connect().Close();
                    return dt;
                }

            }
            catch (Exception ex)
            {
                Connect().Close();
                throw ex;
            }
        }
        
    }
}

/*
 public static DataTable getAllUsers() 
        {
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM users", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
 */
