using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pojo
{
    public class Conexao
    {
        private static string strCon = "server=127.0.0.1;user=root;password=18071988;database=ads";

        public MySqlConnection ConectarBD()
        {
            MySqlConnection c = new MySqlConnection(strCon);
            c.Open();
            return c;
        }
    }
}
