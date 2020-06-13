using System;
using System.Collections;
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
    public partial class ReducingTeeForm : Form
    {
        static string conString = "Server=uz-ts;Database=test;Uid=marasulov;Pwd=Qwerty123$;";
        MySqlConnection con = new MySqlConnection(conString);
        DataTable dt = new DataTable();
        public ReducingTeeForm()
        {
            InitializeComponent();
        }

        private void ReducingTeeF_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = loadData().Tables[0];
            addCombo();
        }

        private DataSet loadData()
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand cmd;
            DataSet ds = new DataSet();

            //SELECT STMTS
            string playerssql = "SELECT * FROM pipes GROUP BY specname";
            string coachessql = "SELECT * FROM users";

            //PLAYER TABLE
            cmd = new MySqlCommand(playerssql, con);
            adapter.SelectCommand = cmd;
            adapter.Fill(ds, "Players");

            //COACHES TABLE
            adapter.SelectCommand.CommandText = coachessql;
            adapter.Fill(ds, "Coaches");

            dt = ds.Tables[1];

            return ds;

        }

        //COMBO COLUMN
        public void addCombo()
        {
            //ADD COLUMNS
            DataGridViewComboBoxColumn combo = new DataGridViewComboBoxColumn();
            combo.HeaderText = "Head Coach";
            combo.Name = "combo";

            ArrayList row = new ArrayList();

            //FILL ARRAYLIST FROM DATATABLE
            foreach (DataRow dr in dt.Rows)
            {
                row.Add(dr["username"].ToString());
            }
            //ADD TO COMBO
            combo.Items.AddRange(row.ToArray());

            //ADD THE COMBO TO DATAGRIDVIEW
            dataGridView1.Columns.Add(combo);

        }

    }
}
