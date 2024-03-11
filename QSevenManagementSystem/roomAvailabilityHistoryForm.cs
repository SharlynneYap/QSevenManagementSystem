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
    public partial class roomAvailabilityHistoryForm : Form
    {
        public roomAvailabilityHistoryForm()
        {
            InitializeComponent();
            searchTBox.TextChanged += searchTBox_TextChanged;
            rAData.CellClick += rAData_CellContentClick;

        }

        public DataGridView getTable()
        {
            return rAData;
        }

        private void loadDataToLabels(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                rALabel.Text = rowData[0];
                roomLabel.Text = rowData[1];
                availabilityLabel.Text = rowData[2];
                priceLabel.Text = rowData[3];
                maxLabel.Text = rowData[4];
                floorLabel.Text = rowData[5];
                dateLabel.Text = rowData[6];

            }
            else
            {
                // Clear labels if there is no selected row
                rALabel.Text = "None";
                roomLabel.Text = "None";
                priceLabel.Text = "None";
                maxLabel.Text = "None";
                floorLabel.Text = "None";
                availabilityLabel.Text = "None";
                dateLabel.Text = "None";
            }
        }

        private void rAData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> rowData = new List<string>();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = rAData.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    rowData.Add(cell.Value?.ToString() ?? "");
                }
            }
            loadDataToLabels(rowData);
        }

        private void loadSearchCBox()//adds items to the search combo box
        {
            searchCBox.Items.Add("Room Availability ID");
            searchCBox.Items.Add("Room ID");
            searchCBox.Items.Add("Price");
            searchCBox.Items.Add("Max # of Renters");
            searchCBox.Items.Add("Floor");
            searchCBox.Items.Add("Availability");
            searchCBox.Items.Add("Date");

        }

        private void searchTBox_TextChanged(object sender, EventArgs e)
        {
            string table = "vw_room_availability_history";
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
                ConnectToSQL.LoadDataGridView(rAData, query);
            }
        }
    }
}
