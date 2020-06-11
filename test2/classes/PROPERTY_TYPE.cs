using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace test2.classes
{
    class PROPERTY_TYPE
    {
        func func = new func();

        // insert a new type
        public Boolean insertType(string name, string description)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `test`.`property_type` (`name`, `description`) VALUES (@nm, @description);");
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = description;
            return func.ExecQuery(command);

        }

        // update selected type
        public Boolean updateType(int id, string name, string description)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `test`.`property_type` SET `name` = @nm, `description` = @description WHERE (`id` = @id);");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@description", MySqlDbType.VarChar).Value = description;
            return func.ExecQuery(command);

        }

        // delete selected type
        public Boolean deleteType(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `test`.`property_type` WHERE(`id` = @id);");
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            return func.ExecQuery(command);

        }


        public DataTable getAllTypes()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM test.property_type;");

            return func.getData(command);

        }
    }
}
