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
    public partial class pricesHistoryForm : Form
    {
        public pricesHistoryForm()
        {
            InitializeComponent();
            loadSearchCBox();
            loadSearchCBox2();
            searchTBox.TextChanged += searchTBox_TextChanged;
            pricesData.CellClick += pricesData_CellContentClick;
            searchTBox2.TextChanged += searchTBox2_TextChanged;
            rateData.CellClick += rateData_CellContentClick;

        }

        public DataGridView getTable(int num)
        {
            return num == 1 ? pricesData : rateData;
        }

        private void loadDataToLabels(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                roomPIDLabel.Text = rowData[0];
                roomPLabel.Text = rowData[1];
                dateLabel.Text = rowData[2];
                roomIDLabel.Text = rowData[3];
                flLabel.Text = rowData[4];
                maxLabel.Text = rowData[5];

            }
            else
            {
                // Clear labels if there is no selected row
                roomPIDLabel.Text = "None";
                roomPLabel.Text = "None";
                roomIDLabel.Text = "None";
                dateLabel.Text = "None";
                flLabel.Text = "None";
                maxLabel.Text = "None";
            }
        }

        private void pricesData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> rowData = new List<string>();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = pricesData.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    rowData.Add(cell.Value?.ToString() ?? "");
                }
            }
            loadDataToLabels(rowData);
        }

        private void loadSearchCBox()//adds items to the search combo box
        {
            searchCBox.Items.Add("Room Price ID");
            searchCBox.Items.Add("Room Price");
            searchCBox.Items.Add("Date");
            searchCBox.Items.Add("Room ID");
            searchCBox.Items.Add("Floor");
            searchCBox.Items.Add("Max # of Renters");

        }

        private void searchTBox_TextChanged(object sender, EventArgs e)
        {
            string table = "vw_room_price_history";
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
                ConnectToSQL.LoadDataGridView(pricesData, query);
            }
        }

        private void loadDataToLabels2(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                rateIDLabel.Text = rowData[0];
                typeLabel.Text = rowData[1];
                rateLabel.Text = rowData[2];
                dateLabel2.Text = rowData[3];


            }
            else
            {
                // Clear labels if there is no selected row
                rateIDLabel.Text = "None";
                typeLabel.Text = "None";
                rateLabel.Text = "None";
                dateLabel2.Text = "None";
            }
        }

        private void rateData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> rowData = new List<string>();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = rateData.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    rowData.Add(cell.Value?.ToString() ?? "");
                }
            }
            loadDataToLabels2(rowData);
        }

        private void loadSearchCBox2()//adds items to the search combo box
        {
            searchCBox2.Items.Add("Bill Rate ID");
            searchCBox2.Items.Add("Bill Type");
            searchCBox2.Items.Add("Bill Rate");
            searchCBox2.Items.Add("Date");

        }

        private void searchTBox2_TextChanged(object sender, EventArgs e)
        {
            string table = "vw_bill_rate_history";
            // Get the selected column from the ComboBox
            string selectedColumn = searchCBox2.SelectedItem?.ToString();

            // Get the search value from the TextBox
            string searchValue = searchTBox2.Text.Trim();

            // Check if a column and search value are provided
            if (!string.IsNullOrEmpty(selectedColumn) && !string.IsNullOrEmpty(searchValue))
            {
                // Define the SQL query
                string query = $"SELECT * FROM {table} WHERE `{selectedColumn}` LIKE '%{searchValue}%'";
                //MessageBox.Show(query); //For testing
                //Execute the query and update the DataGridView
                ConnectToSQL.LoadDataGridView(rateData, query);
            }
        }
    }
}
