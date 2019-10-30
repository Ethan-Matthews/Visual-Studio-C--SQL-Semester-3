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
    public partial class DeveloperCountryForm : Form
    {
        public DeveloperCountryForm()
        {
            InitializeComponent();
        }

        private void DeveloperCountryForm_Load(object sender, EventArgs e)
        {
            UpdateDeveloperCountryListView();
            DeveloperCountryListBox.DisplayMember = "CountryName";
        }

        private void UpdateDeveloperCountryListView()
        {
            List<DeveloperCountry> devCountryList = DeveloperCountryManager.GetDeveloperCountryList();
            DeveloperCountryListBox.DataSource = devCountryList;
        }

        private void DeveloperCountryListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeveloperCountryListBox.SelectedIndex > -1)
            {
                DeveloperCountry country = (DeveloperCountry)DeveloperCountryListBox.SelectedItem;

                CountryCodeTB.Text = country.CountryCode;
                CountryNameTB.Text = country.CountryName;

            }
        }

        private void SaveCountryBN_Click(object sender, EventArgs e) 
        {
            CountryCodeTB.ReadOnly = true;
            bool isInList = false;
            List<DeveloperCountry> devCountryList = DeveloperCountryManager.GetDeveloperCountryList();
            foreach (DeveloperCountry country in devCountryList)
            {
                if (CountryCodeTB.Text.Equals(country.CountryCode)) 
                {
                    isInList = true;
                }
            }
            if (!isInList)
            {
                DeveloperCountry newCountry = new DeveloperCountry();
                newCountry.CountryCode = CountryCodeTB.Text;
                newCountry.CountryName = CountryNameTB.Text;
                DeveloperCountryManager.InsertDeveloperCountry(newCountry);

                MessageBox.Show("Genre Inserted.");
                UpdateGenreListView();
            }
            else
            {
                DeveloperCountry country = (DeveloperCountry)DeveloperCountryListBox.SelectedItem;
                country.CountryName = CountryNameTB.Text;
                int listIndex = DeveloperCountryListBox.SelectedIndex;

                DeveloperCountryManager.UpdateDeveloperCountry(country);

                if (DeveloperCountryManager.UpdateDeveloperCountry(country) == 1)
                {
                    MessageBox.Show("Country Updated.");
                    List<Genre> genreList = GenreManager.GetGenreList();
                    UpdateGenreListView();
                    DeveloperCountryListBox.SelectedIndex = listIndex;
                }
                else
                {
                    MessageBox.Show("Warning! Country Not Updated.");
                }
            }
            CountryCodeTB.Enabled = false;
            CountryCodeTB.ReadOnly = true;
        }

        private void DeleteCountryBN_Click(object sender, EventArgs e)
        {
            string code = CountryCodeTB.Text;
            int rowsaffected = DeveloperCountryManager.DeleteDeveloperCountry(code);

            if (rowsaffected == 1)
            {
                MessageBox.Show("Country Deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateGenreListView();
            }
            else
            {
                MessageBox.Show("Unable to delete developer country.\nThis country is in use as a foreign key.",
                                "Error Deleting",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void InsertCountryBN_Click(object sender, EventArgs e)
        {
            CountryCodeTB.Enabled = true;
            CountryCodeTB.ReadOnly = false;
            CountryCodeTB.Text = string.Empty;
            CountryNameTB.Text = string.Empty;
            DeveloperCountryListBox.SelectedIndex = -1;
            CountryCodeTB.Focus();
        }

        private void UpdateGenreListView()
        {
            List<DeveloperCountry> devCountryList = DeveloperCountryManager.GetDeveloperCountryList();
            DeveloperCountryListBox.DataSource = devCountryList;
        }

        private void BackBN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
