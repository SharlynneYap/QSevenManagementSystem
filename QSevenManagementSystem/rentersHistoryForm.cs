using System;
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
    public partial class rentersHistoryForm : Form
    {
        public rentersHistoryForm()
        {
            InitializeComponent();
            searchTBox.TextChanged += searchTBox_TextChanged;
            rentersData.CellClick += rentersData_CellContentClick;
        }

        public DataGridView getTable()
        {
            return rentersData;
        }

        private void loadDataToLabels(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                roomLabel.Text = rowData[0];
                availLabel.Text = rowData[1];
                floorLabel.Text = rowData[2];
                maxLabel.Text = rowData[3];
                renterLabel.Text = rowData[4];
                fNameLabel.Text = rowData[5];
                mNameLabel.Text = rowData[6];
                lNameLabel.Text = rowData[7];
            }
            else
            {
                // Clear labels if there is no selected row
                roomLabel.Text = "None";
                availLabel.Text = "None";
                floorLabel.Text = "None";
                maxLabel.Text = "None";
                renterLabel.Text = "None";
                fNameLabel.Text = "None";
                mNameLabel.Text = "None";
                lNameLabel.Text = "None";
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
            searchCBox.Items.Add("Room ID");
            searchCBox.Items.Add("Availability");
            searchCBox.Items.Add("Floor");
            searchCBox.Items.Add("Max # of renters");
            searchCBox.Items.Add("Renter ID");
            searchCBox.Items.Add("Renter First Name");
            searchCBox.Items.Add("Renter Middle Name");
            searchCBox.Items.Add("Renter Last Name");
        }

        private void searchTBox_TextChanged(object sender, EventArgs e)
        {
            string table = "vw_renter_history";
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
