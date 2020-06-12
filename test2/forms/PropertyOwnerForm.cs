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
    public partial class PropertyOwnerForm : Form
    {
        public PropertyOwnerForm()
        {
            InitializeComponent();
        }

        classes.Person person = new classes.Person();
        private void PropertyOwnerForm_Load(object sender, EventArgs e)
        {
            LoadDatagridviewOwners();
            dispalyOwnersCount();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int id = 0;
            string fname = textBoxFName.Text;
            string lname = textBoxLName.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string adress = textBoxAddress.Text;

            person = new classes.Person(id, fname, lname, phone, email, adress);
            int num;



            if (verifTextBoxes())
            {
                if (int.TryParse(phone, out num))
                {

                    if (person.insertPerson("property_owner", person))
                    {
                        MessageBox.Show("New Owner Added", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDatagridviewOwners();
                        dispalyOwnersCount();
                        CleanAllTextBoxesIn();
                    }
                    else
                    {
                        MessageBox.Show("Owner not Added", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else { MessageBox.Show("phone have to be number", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                MessageBox.Show("Owner not Added", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string fname = textBoxFName.Text;
            string lname = textBoxLName.Text;
            string phone = textBoxPhone.Text;
            string email = textBoxEmail.Text;
            string adress = textBoxAddress.Text;

            int num;

            try
            {
                int id = Convert.ToInt32(textBoxId.Text);
                if (verifTextBoxes())
                {
                    if (int.TryParse(phone, out num))
                    {

                        if (person.updatePerson("property_owner", new classes.Person(id, fname, lname, phone, email, adress)))
                        {
                            MessageBox.Show("Owner updated", "Edit Owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadDatagridviewOwners();
                            dispalyOwnersCount();
                            CleanAllTextBoxesIn();
                        }
                        else
                        {
                            MessageBox.Show("Owner not uodated", "Edit Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else { MessageBox.Show("phone have to be number", "Edit Owner", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else
                {
                    MessageBox.Show("Owner id error", "Edit Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch
            {
                MessageBox.Show("Owner not Added", "Add Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);
                if (person.deletePerson("property_owner", id))
                {
                    MessageBox.Show("Owner deleted", "Delete Owner", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDatagridviewOwners();
                    dispalyOwnersCount();
                    CleanAllTextBoxesIn();
                }

            }
            catch
            {
                MessageBox.Show("Owner not deleted", "delete Owner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool verifTextBoxes()
        {
            string fname = textBoxFName.Text.Trim();
            string lname = textBoxLName.Text.Trim();
            string phone = textBoxPhone.Text.Trim();


            if (fname.Equals("") || lname.Equals("") || phone.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void LoadDatagridviewOwners()
        {
            dataGridViewOwners.DataSource = person.getAllPersons("property_owner");
        }

        // display selected owner data from datagridview to textboxes
        private void dataGridViewOwners_Click(object sender, EventArgs e)
        {
            textBoxId.Text = dataGridViewOwners.CurrentRow.Cells[0].Value.ToString();
            textBoxFName.Text = dataGridViewOwners.CurrentRow.Cells[1].Value.ToString();
            textBoxLName.Text = dataGridViewOwners.CurrentRow.Cells[2].Value.ToString();
            textBoxPhone.Text = dataGridViewOwners.CurrentRow.Cells[3].Value.ToString();
            textBoxEmail.Text = dataGridViewOwners.CurrentRow.Cells[4].Value.ToString();
            textBoxAddress.Text = dataGridViewOwners.CurrentRow.Cells[5].Value.ToString();
        }

        public void dispalyOwnersCount()
        {
            labelCount.Text = person.getAllPersons("property_owner").Rows.Count.ToString();
        }

        private void CleanAllTextBoxesIn()
        {
            foreach (var c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
            }
        }
    }
}
