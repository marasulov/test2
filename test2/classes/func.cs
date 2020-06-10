using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace test2.classes
{
    class func
    {
        Db_Connection connection = new Db_Connection();
        public DataTable GetData(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connection.getConnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter();
        }

    }
}
