using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace test2.classes
{
    class Person
    {
        //class for owner and clients

        func func = new func();

        private int id;
        private string fname;
        private string lname;
        private string phone;
        private string email;
        private string address;

        public Person() { }

        public Person(int Id, string FName, string LName, string Phone, string EMail, string Address)
        {
            this.id = Id;
            this.fname = FName;
            this.lname = LName;
            this.phone = Phone;
            this.email = EMail;
            this.address = Address;
        }

        // gett all owners
        public DataTable getAllPersons(string ownerOrclient)
        {
            string tablename = ownerOrclient;
            MySqlCommand command = new MySqlCommand("SELECT * FROM `"+ tablename +"`;");

            return func.getData(command);

        }

        // insert a new person
        public Boolean insertPerson(string ownerOrclient, Person person)
        {
            string tableName = ownerOrclient;

            MySqlCommand command = new MySqlCommand("INSERT INTO `" + tableName +"` (`first_name`, `last_name`, `phone`, `email`, `adress`) VALUES (@fn, @ln, @phn, @email, @addr);");
            
            
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = person.fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = person.lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = person.phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = person.email;
            command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = person.address;
            
            return func.ExecQuery(command);
        }



        // edit a person
        public Boolean updatePerson(string ownerOrclient, Person person)
        {
            string tableName = ownerOrclient;

            MySqlCommand command = new MySqlCommand("UPDATE `"+ tableName +"` SET `first_name` = @fn, `last_name` = @ln, `phone` = @phn, `email` = @email, `adress` = @addr WHERE (`id` = @id);");


            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = person.id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = person.fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = person.lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = person.phone;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = person.email;
            command.Parameters.Add("@addr", MySqlDbType.VarChar).Value = person.address;

            return func.ExecQuery(command);
        }

        public Boolean deletePerson(string ownerOrclient, int id)
        {
            string tableName = ownerOrclient;

            MySqlCommand command = new MySqlCommand("DELETE FROM `" + tableName + "` WHERE (`id` = @id);");
           

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            
            return func.ExecQuery(command);
        }

    }


}
