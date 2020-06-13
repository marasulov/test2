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
    public partial class PipeStockForm : Form
    {
        public PipeStockForm()
        {
            InitializeComponent();
        }

        classes.Person person = new classes.Person();

        private void PipeStockForm_Load(object sender, EventArgs e)
        {
            LoadDatagridviewOwners();

        }

        public void LoadDatagridviewOwners()
        {

           advancedDataGridView1.DataSource = person.getAllPersons("property_owner");
        }
    }
}
