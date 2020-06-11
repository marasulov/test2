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
        
        /// <summary>
        /// get data
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public DataTable getData(MySqlCommand command)
        {
            command.Connection = connection.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);

            DataTable table = new DataTable();
            adapter.Fill(table);

            return table;
        }

        /// <summary>
        /// 
        /// </summary>
        public Boolean ExecQuery(MySqlCommand command)
        {
            command.Connection = connection.getConnection;
            connection.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else 
            {
                connection.closeConnection();
                return false;
            }
        }

    }
}
