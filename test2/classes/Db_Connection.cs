using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2.classes
{
    class Db_Connection
    {
        testEntities dbEntities = new testEntities();

        //string connStr = "server=uz-ts;user=marasulov;database=test;password=Qwerty123$;";
        MySqlConnection connection = new MySqlConnection("server=uz-ts;user=marasulov;database=test;password=Qwerty123$;");

        public MySqlConnection getConnection
        {
            get
            {
                return connection;
            }
        }

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
