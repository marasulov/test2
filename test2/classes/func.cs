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
        //Db_Connection connection = new Db_Connection();
        testEntities dbEntities = new testEntities();
        /// <summary>
        /// get data
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public DataTable getData(MySqlCommand command)
        {
            db.

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
