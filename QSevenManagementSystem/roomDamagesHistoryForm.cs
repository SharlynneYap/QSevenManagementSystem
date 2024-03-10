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
    public partial class roomDamagesHistoryForm : Form
    {
        public roomDamagesHistoryForm()
        {

            InitializeComponent();

        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            mainForm mainForm = (mainForm)this.ParentForm;
            mainForm.rDHForm_reportButtonClick(this, EventArgs.Empty);
        }

        public DataGridView getTable()
        {
            return rDHData;
        }

        private void loadDataToLabels(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                roomDamageLabel.Text = rowData[0];
                roomLabel.Text = rowData[1];
                damageLabel.Text = rowData[2];
                descLabel.Text = rowData[3];
                totalLabel.Text = rowData[4];
                dateLabel.Text = rowData[5];
            }
            else
            {
                // Clear labels if there is no selected row
                roomDamageLabel.Text = "None";
                roomLabel.Text = "None";
                damageLabel.Text = "None";
                descLabel.Text = "None";
                totalLabel.Text = "None";
                dateLabel.Text = "None";
            }
        }

        private void rDHData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> rowData = new List<string>();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = rDHData.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    rowData.Add(cell.Value?.ToString() ?? "");
                }
            }
            loadDataToLabels(rowData);
        }

        private void loadSearchCBox()//adds items to the search combo box
        {
            searchCBox.Items.Add("Room Damage ID");
            searchCBox.Items.Add("Room ID");
            searchCBox.Items.Add("Damage Type");
            searchCBox.Items.Add("Total Damage");
            searchCBox.Items.Add("Date");

        }

        private void searchTBox_TextChanged(object sender, EventArgs e)
        {
            string table = "vw_current_rooms";
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
                ConnectToSQL.LoadDataGridView(rDHData, query);
            }
        }
    }
}
