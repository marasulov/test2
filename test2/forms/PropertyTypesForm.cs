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
    public partial class PropertyTypesForm : Form
    {
        public PropertyTypesForm()
        {
            InitializeComponent();
        }

        classes.PROPERTY_TYPE pType = new classes.PROPERTY_TYPE();
        private void PropertyTypesForm_Load(object sender, EventArgs e)
        {
            LoadListboxData();

            displayTypesCount();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string description = textBoxDescription.Text;

            if (!name.Trim().Equals(""))
            {
                if (pType.insertType(name, description))
                {
                    MessageBox.Show("Type added", "Add type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListboxData();

                    textBoxId.Text = "";
                    textBoxName.Text = "";
                    textBoxDescription.Text = "";

                    displayTypesCount();

                }
                else
                {
                    MessageBox.Show("Type not added", "Add type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Enter type name", "Add type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //display data in textboxes on listbox click;
        private void listBoxTypes_Click(object sender, EventArgs e)
        {

            DataRow dataRow = pType.getAllTypes().Rows[listBoxTypes.SelectedIndex];
            textBoxId.Text = dataRow.ItemArray[0].ToString();
            textBoxName.Text = dataRow.ItemArray[1].ToString();
            textBoxDescription.Text = dataRow.ItemArray[2].ToString();

        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);
                string name = textBoxName.Text;
                string description = textBoxDescription.Text;

                if (!name.Trim().Equals(""))
                {
                    if (pType.insertType(name, description))
                    {
                        MessageBox.Show("Type added", "Add type", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadListboxData();

                        displayTypesCount();
                    }
                    else
                    {
                        MessageBox.Show("Type not added", "Add type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Enter type name", "Add type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("No type selected", "Edit type", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // create a fucntion to populate the listbox
        public void LoadListboxData()
        {
            listBoxTypes.DataSource = pType.getAllTypes();
            listBoxTypes.DisplayMember = "name";
            listBoxTypes.ValueMember = "id";

            displayTypesCount();

            // remove selection from listbox
            listBoxTypes.SelectedItem = null;
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxId.Text);

                if (MessageBox.Show("Continue The Delete?", "Remove Type", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (pType.deleteType(id))
                    {
                        MessageBox.Show("Type deleted", "Remove type", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //refresh listbox
                        LoadListboxData();

                        // clear textboxes
                        textBoxId.Text = "";
                        textBoxName.Text = "";
                        textBoxDescription.Text = "";

                        displayTypesCount();
                    }
                    else
                    {
                        MessageBox.Show("Type not deleted", "Remove type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Nothing selected", "Remove type", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void displayTypesCount()
        {
            labelTypesCount.Text = listBoxTypes.Items.Count.ToString();
        }
    }
}
