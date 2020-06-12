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
    }
}
