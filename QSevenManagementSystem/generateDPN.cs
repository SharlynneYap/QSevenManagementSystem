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
    public partial class generateDPN : Form
    {
        List<string> dpnColumns;
        List<string> dpnValues;

        List<string> billColumns;
        List<string> billValues1;
        List<string> billValues2;

        List<string> billRateColumns;
        List<string> billRateValues;

        calculateElec cEForm = new calculateElec();
        calculateWater cWForm = new calculateWater();
        public generateDPN()
        {
            dpnColumns = new List<string>() { "registration_id", "dpn_date_month", "dpn_date_issued", "dpn_is_deposit_used" };
            dpnValues = new List<string>();
            billColumns = new List<string>() { "dpn_id", "bt_id", "bill_meter_end_month", "bill_meter_start_month" };

            InitializeComponent();
            loadSearchCBox();

            searchTBox.TextChanged += searchTBox_TextChanged;
            roomData.CellClick += roomsData_CellContentClick;


        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            loadDPNValues();
            insertDPNRecords();

            // Show calculateElec form
            cEForm.ShowDialog();

            // Retrieve bill values from calculateElec form
            billValues1 = cEForm.getBillValues();
            MessageBox.Show(string.Join(", ", billValues1)); // Testing
                                                             // Get the dpn_id and put it in billValues1 
            billValues1[0] = ConnectToSQL.readTableString("SELECT dpn_id FROM tbl_dpn ORDER BY dpn_id DESC LIMIT 1;");
            insertBillRecords1();

            // Show calculateWater form
            cWForm.ShowDialog();

            // Retrieve bill values from calculateWater form
            billValues2 = cWForm.getBillValues();
            MessageBox.Show(string.Join(", ", billValues2)); // Testing
                                                             // Get the dpn_id and put it in billValues2 
            billValues2[0] = ConnectToSQL.readTableString("SELECT dpn_id FROM tbl_dpn ORDER BY dpn_id DESC LIMIT 1;");
            insertBillRecords2();
        }

        private void loadDPNValues()
        {
            string registrationId = registrationTBox.Text;
            string dateMonth = monthCBox.Text;
            string dateIssued = issuedDate.Value.ToString("yyyy-MM-dd");
            string isDepositUsed = (depositCheckBox.Checked) ? "1" : "0";

            dpnValues.Clear();

            dpnValues.Add(registrationId);
            dpnValues.Add(dateMonth);
            dpnValues.Add(dateIssued);
            dpnValues.Add(isDepositUsed);

            MessageBox.Show(string.Join(", ", dpnValues)); // Testing
        }

        private void insertDPNRecords()
        {
            string table = "tbl_dpn";
            string values = dpnValues[0] + ", '" + dpnValues[1] + "', '" + dpnValues[2] + "', " + dpnValues[3];
            string columns = string.Join(", ", dpnColumns);
            MessageBox.Show("columns: " + columns + " values: " + values);//for testing

            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void insertBillRecords1()
        {
            string table = "tbl_bill";
            string values = string.Join(", ", billValues1);
            string columns = string.Join(", ", billColumns);
            MessageBox.Show("columns: " + columns + " values: " + values);//for testing

            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void insertBillRecords2()
        {
            string table = "tbl_bill";
            string values = string.Join(", ", billValues2);
            string columns = string.Join(", ", billColumns);
            MessageBox.Show("columns: " + columns + " values: " + values);//for testing

            ConnectToSQL.insertRecord(table, columns, values);
        }

        public DataGridView getTable()
        {
            return roomData;
        }

        private void loadDataToLabels(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                roomLabel.Text = rowData[0];
                priceLabel.Text = rowData[1];
                floorLabel.Text = rowData[2];
                maxLabel.Text = rowData[3];
                maxLabel.Text = rowData[4];

                roomTBox.Text = rowData[0];
                registrationTBox.Text = rowData[4];
                priceTBox.Text = rowData[1];
            }
            else
            {
                // Clear labels if there is no selected row
                roomLabel.Text = "None";
                priceLabel.Text = "None";
                floorLabel.Text = "None";
                maxLabel.Text = "None";
                maxLabel.Text = "None";

                roomTBox.Text = "";
                registrationTBox.Text = "";
                priceTBox.Text = "";
            }
        }

        private void roomsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> rowData = new List<string>();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = roomData.Rows[e.RowIndex];
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
            searchCBox.Items.Add("Floor");
            searchCBox.Items.Add("Max # of Renters");
            searchCBox.Items.Add("Registration ID");

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
                ConnectToSQL.LoadDataGridView(roomData, query);
            }
        }
    }
}
