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
    public partial class roomsForm : Form
    {
        public roomsForm()
        {
            InitializeComponent();
            loadSearchCBox();
            searchTBox.TextChanged += searchTBox_TextChanged;
            roomsData.CellClick += roomsData_CellContentClick;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            mainForm mainForm = (mainForm)this.ParentForm;
            mainForm.roomsForm_createButtonClick(this, EventArgs.Empty);
        }

        public DataGridView getTable()
        {
            return roomsData;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            removeRoomForm rRForm = new removeRoomForm(this);
            rRForm.ShowDialog();
        }

        public string getRoomID()
        {
            return roomLabel.Text;
        }

        private void loadDataToLabels(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                roomLabel.Text = rowData[0];
                priceLabel.Text = rowData[1];
                maxLabel.Text = rowData[2];
                floorLabel.Text = rowData[3];
                availabilityLabel.Text = rowData[4];
            }
            else
            {
                // Clear labels if there is no selected row
                roomLabel.Text = "None";
                priceLabel.Text = "None";
                maxLabel.Text = "None";
                floorLabel.Text = "None";
                availabilityLabel.Text = "None";
            }
        }

        private void roomsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> rowData = new List<string>();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = roomsData.Rows[e.RowIndex];
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
            searchCBox.Items.Add("Price");
            searchCBox.Items.Add("Max # of Renters");
            searchCBox.Items.Add("Floor");
            searchCBox.Items.Add("Availability");

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
                ConnectToSQL.LoadDataGridView(roomsData, query);
            }
        }
    }
}
