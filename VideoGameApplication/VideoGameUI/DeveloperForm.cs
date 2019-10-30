using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoGameDAL;
using VideoGameDAL.Models;

namespace VideoGameUI
{
    public partial class DeveloperForm : Form
    {
        public DeveloperForm()
        {
            InitializeComponent();
        }

        private void DeveloperForm_Load(object sender, EventArgs e)
        {
            UpdateDeveloperListView();
            DeveloperListBox.DisplayMember = "DeveloperName";
        }

        private void UpdateDeveloperListView()
        {
            List<Developer> devList = DeveloperManager.GetDeveloperList();
            DeveloperListBox.DataSource = devList;
        }

        private void DeveloperListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeveloperListBox.SelectedIndex > -1)
            {
                Developer dev = (Developer)DeveloperListBox.SelectedItem;

                DeveloperIDTB.Text = dev.DeveloperID.ToString();
                DeveloperNameTB.Text = dev.DeveloperName;

            }
        }

        private void SaveBN_Click(object sender, EventArgs e)
        {
            if (DeveloperIDTB.Text == string.Empty)
            {
                Developer newDev = new Developer();
                newDev.DeveloperName = DeveloperNameTB.Text;
                DeveloperManager.InsertDeveloper(newDev);

                MessageBox.Show("Developer Inserted.");
                UpdateDeveloperListView();
            }
            else
            {
                Developer dev = (Developer)DeveloperListBox.SelectedItem;
                dev.DeveloperName = DeveloperNameTB.Text;
                int listIndex = DeveloperListBox.SelectedIndex;

                DeveloperManager.UpdateDeveloper(dev);

                if (DeveloperManager.UpdateDeveloper(dev) == 1)
                {
                    MessageBox.Show("Developer Updated.");
                    List<Developer> devList = DeveloperManager.GetDeveloperList();
                    UpdateDeveloperListView();
                    DeveloperListBox.SelectedIndex = listIndex;
                }
                else
                {
                    MessageBox.Show("Warning! Developer Not Updated.");
                }
            }
        }

        private void DeleteBN_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DeveloperIDTB.Text);
            int rowsaffected = DeveloperManager.DeleteDeveloper(id);

            if (rowsaffected == 1)
            {
                MessageBox.Show("Developer Deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateDeveloperListView();
            }
            else
            {
                MessageBox.Show("Unable to delete Developer.\nThis Developer is in use as a foreign key.",
                                "Error Deleting",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void InsertBN_Click(object sender, EventArgs e)
        {
            DeveloperIDTB.Text = string.Empty;
            DeveloperNameTB.Text = string.Empty;
            DeveloperListBox.SelectedIndex = -1;
            DeveloperNameTB.Focus();
        }
    }
}
