using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace test2.forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            classes.func func = new classes.func();

            if (checkFields())
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM users WHERE username = @un AND password=@pass");
                command.Parameters.Add("@un",MySqlDbType.VarChar).Value = username;
                command.Parameters.Add("@pass",MySqlDbType.VarChar).Value = password;
                DataTable table = func.getData(command);

                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("yes");
                    
                }
                else
                {
                    labelErrorMessage.Visible = true;

                }
            }
        }

        //check if the uername or password are empty
        public Boolean checkFields()
        {
            
            labelUsername.Visible = false;
            labelPassword.Visible = false;

            if (textBoxUsername.Text.Trim().Equals("") && (textBoxPassword.Text.Trim().Equals("")))
            {
                labelUsername.Visible = true;
                labelPassword.Visible = true;
                return false;
            }
            else if (textBoxUsername.Text.Trim().Equals(""))
            {
                labelUsername.Visible = true;
                return false;
            }
            else if (textBoxPassword.Text.Trim().Equals(""))
            {
                labelPassword.Visible = true;
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
