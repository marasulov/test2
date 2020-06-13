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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            panel1.Height = this.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PipeStockForm pipeStockF = new PipeStockForm();

            //(sender as Button).Enabled = false;
            if (Application.OpenForms["PipeStockForm"] == null) 
            {
                pipeStockF.Show();
            }


        }

        private void buttonPropertyTypes_Click(object sender, EventArgs e)
        {
            PropertyTypesForm propertyTypesF = new PropertyTypesForm();
            propertyTypesF.Show();
        }

        private void buttonOwner_Click(object sender, EventArgs e)
        {
            PropertyOwnerForm propertyOwnerF = new PropertyOwnerForm();
            propertyOwnerF.Show();
        }

        private void ReopenChildForm(Form form)
        {
            if (form.Visible)
            {
                form.Hide();
                MessageBox.Show("sadsa");
            }
            //Update form information
            form.Show();
        }

        public void openForm(object Form)
        {

            Form form = new Form();

            //(sender as Button).Enabled = false;
            if (Application.OpenForms["form"] == null)
            {
                form.Show();
            }



            //var _myForm = (Form)Application.OpenForms["form"];
            //if (_myForm == null)
            //    _myForm = new Form();

            //// finally show the form
            //_myForm.Show();
        }

        private void buttonReducingTee_Click(object sender, EventArgs e)
        {
            ReducingTeeForm reducingTeeF = new  ReducingTeeForm();

            //(sender as Button).Enabled = false;
            if (Application.OpenForms["ReducingTeeForm"] == null)
            {
                reducingTeeF.Show();
            }
        }
    }
}
