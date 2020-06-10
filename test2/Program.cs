using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using test2.forms;
using MySql.Data.MySqlClient;

namespace test2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string connStr = "server=uz-ts;user=marasulov;database=test;password=Qwerty123$;";
            //// создаём объект для подключения к БД
            //MySqlConnection conn = new MySqlConnection(connStr);
            //conn.Open();
            //// запрос
            //string sql = "SELECT * FROM users";
            //// объект для выполнения SQL-запроса
            //MySqlCommand command = new MySqlCommand(sql, conn);
            //// выполняем запрос и получаем ответ
            //MySqlDataReader reader = command.ExecuteReader();
            //// читаем результат
            //while (reader.Read())
            //{
            //    // элементы массива [] - это значения столбцов из запроса SELECT
            //    Console.WriteLine(reader[0].ToString() + " " + reader[1].ToString());
            //}
            //reader.Close(); // закрываем reader
            //                // закрываем соединение с БД


            //conn.Close();

            forms.LoginForm loginForm = new forms.LoginForm();
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new forms.MainForm());
            }
            else 
            {
                Application.Exit();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
