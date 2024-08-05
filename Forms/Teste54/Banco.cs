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
        
    }
}
