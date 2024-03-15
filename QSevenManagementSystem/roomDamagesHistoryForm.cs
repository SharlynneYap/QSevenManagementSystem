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
            loadSearchCBox();
            searchTBox.TextChanged += searchTBox_TextChanged;
            rDHData.CellClick += rDHData_CellContentClick;

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
                roomDamageLabel1.Text = rowData[0];
                roomLabel2.Text = rowData[1];
                damageLabel3.Text = rowData[2];
                descLabel4.Text = rowData[3];
                totalLabel5.Text = rowData[4];
                dateLabel6.Text = rowData[5];
            }
            else
            {
                // Clear labels if there is no selected row
                roomDamageLabel1.Text = "None";
                roomLabel2.Text = "None";
                damageLabel3.Text = "None";
                descLabel4.Text = "None";
                totalLabel5.Text = "None";
                dateLabel6.Text = "None";
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
            string table = "vw_room_damage_record";
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
