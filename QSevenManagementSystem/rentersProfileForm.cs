﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QSevenManagementSystem
{
    public partial class rentersProfileForm : Form
    {
        public rentersProfileForm()
        {
            InitializeComponent();
            searchTBox.TextChanged += searchTBox_TextChanged;
            rentersData.CellClick += rentersData_CellContentClick;
            loadSearchCBox();
        }

        public DataGridView getTable()
        {
            return rentersData;
        }

        public string getRegistrationID()
        {
            return registrationLabel.Text;
        }

        private void moveOutButton_Click(object sender, EventArgs e)
        {
            moveOutForm moveOutForm = new moveOutForm(this);
            moveOutForm.ShowDialog();
        }

        private void loadDataToLabels(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                registrationLabel.Text = rowData[0];
                renterLabel.Text = rowData[1];
                fLabel.Text = rowData[2];
                mLabel.Text = rowData[3];
                lLabel.Text = rowData[4];
                contactLabel.Text = rowData[5];
                dobLabel.Text = rowData[6];
                addressLabel.Text = rowData[7];
                roomLabel.Text = rowData[8];
                depositLabel.Text = rowData[9];
                moveInLabel.Text = rowData[10];
                regisDateLabel.Text = rowData[11];

            }
            else
            {
                // Clear labels if there is no selected row
                registrationLabel.Text = "None";
                renterLabel.Text = "None";
                fLabel.Text = "None";
                mLabel.Text = "None";
                lLabel.Text = "None";
                contactLabel.Text = "None";
                dobLabel.Text = "None";
                addressLabel.Text = "None";
                roomLabel.Text = "None";
                depositLabel.Text = "None";
                moveInLabel.Text = "None";
                regisDateLabel.Text = "None";
            }
        }

        private void rentersData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> rowData = new List<string>();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = rentersData.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    rowData.Add(cell.Value?.ToString() ?? "");
                }
            }
            loadDataToLabels(rowData);
        }

        private void loadSearchCBox()//adds items to the search combo box
        {
            searchCBox.Items.Add("Registration ID");
            searchCBox.Items.Add("Renter ID");
            searchCBox.Items.Add("First Name");
            searchCBox.Items.Add("Middle Name");
            searchCBox.Items.Add("Last Name");
            searchCBox.Items.Add("Contact #");
            searchCBox.Items.Add("DOB");
            searchCBox.Items.Add("Address");
            searchCBox.Items.Add("Room ID");
            searchCBox.Items.Add("Deposit Paid");
            searchCBox.Items.Add("Move In Date");
            searchCBox.Items.Add("Registration Date");

        }

        private void searchTBox_TextChanged(object sender, EventArgs e)
        {
            string table = "vw_renters_profile";
            // Get the selected column from the ComboBox
            string selectedColumn = searchCBox.SelectedItem?.ToString();

            // Get the search value from the TextBox
            string searchValue = searchTBox.Text.Trim();

            // Check if a column and search value are provided
            if (!string.IsNullOrEmpty(selectedColumn) && !string.IsNullOrEmpty(searchValue))
            {
                // Define the SQL query
                string query = $"SELECT * FROM {table} WHERE `{selectedColumn}` LIKE '%{searchValue}%'";
                //MessageBox.Show(query); //For testing
                //Execute the query and update the DataGridView
                ConnectToSQL.LoadDataGridView(rentersData, query);
            }
        }
    }
}
