using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QSevenManagementSystem
{
    public partial class reportDamageForm : Form
    {
        List<string> rDValues;
        List<string> rDColumns;

        public reportDamageForm()
        {
            InitializeComponent();
            rDValues = new List<string>();
            rDColumns = new List<string>() { "room_id", "rdt_id", "rd_description", "rd_total_damages", "rd_date" };
            string[,] damageType = ConnectToSQL.readTableArray("Select * from tbl_room_damage_type");
            damageCBox.Items.Add(damageType[0, 1]);
            damageCBox.Items.Add(damageType[1, 1]);
            searchTBox.TextChanged += searchTBox_TextChanged;
            roomsData.CellClick += roomsData_CellContentClick;
            loadSearchCBox();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            mainForm mainForm = (mainForm)this.ParentForm;
            mainForm.rDForm_confirmButtonClick(this, EventArgs.Empty);

            loadRDValues();
            insertRDRecords();
        }

        private void loadRDValues()
        {
            string roomId = roomIdTBox.Text;
            string damageType = (damageCBox.Text == "Maintenance") ? "1" : "2";
            string desc = descTBox.Text;
            string total = totalTBox.Text;
            string date = rdDate.Value.ToShortDateString();
            date = rdDate.Value.ToString("yyyy-MM-dd");


            rDValues.Clear();

            rDValues.Add(roomId);
            rDValues.Add(damageType);
            rDValues.Add(desc);
            rDValues.Add(total);
            rDValues.Add(date);

            MessageBox.Show(string.Join(", ", rDValues)); // Testing
        }

        private void insertRDRecords()
        {
            string table = "tbl_room_damage_record";
            string values = "'" + rDValues[0] + "', '" + rDValues[1] + "', '" + rDValues[2] + "', " + rDValues[3] + ", '" + rDValues[4] + "'";
            string columns = string.Join(", ", rDColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        public DataGridView getTable()
        {
            return roomsData;
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

                roomIdTBox.Text = rowData[0];
            }
            else
            {
                // Clear labels if there is no selected row
                roomLabel.Text = "None";
                priceLabel.Text = "None";
                maxLabel.Text = "None";
                floorLabel.Text = "None";
                availabilityLabel.Text = "None";

                roomIdTBox.Text = "";
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
