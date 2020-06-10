using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            checkFields();
        }

        //check if the uername or password are empty
        public Boolean checkFields()
        {
            
            labelUsername.Visible = false;
            labelPassword.Visible = false;

            if (textBoxUsername.Text.Trim().Equals("") && (textBoxUsername.Text.Trim().Equals("")))
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
