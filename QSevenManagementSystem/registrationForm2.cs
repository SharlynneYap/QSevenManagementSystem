using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QSevenManagementSystem
{
    public partial class registrationForm2 : Form
    {
        registrationForm rForm = new registrationForm();
        private List<string> renterValues;
        private List<string> renterColumns;
        List<string> moveinValues = new List<string>();
        List<string> moveinColumns = new List<string> { "Renter_ID", "MoveIn_date" };
        List<string> depositValues = new List<string>();
        List<string> depositColumns = new List<string> { "Deposit_total" };
        List<string> registrationValues = new List<string>();
        List<string> registrationColumns = new List<string> { "Renter_ID", "Room_ID", "Deposit_ID", "Registration_date" };
        List<string> registrationColumns2 = new List<string> { "Registration_ID", "Renter_ID", "Room_ID", "Deposit_ID", "Registration_date" };
        List<string> rAValues = new List<string>();
        List<string> rAValues2 = new List<string>();
        List<string> rAColumns = new List<string> { "room_id", "rat_id", "ra_date" };
        public registrationForm2()
        {
            InitializeComponent();
        }

        public registrationForm2(List<string> renterValues, List<string> renterColumns)
        {
            InitializeComponent();
            loadSearchCBox();
            searchTBox.TextChanged += searchTBox_TextChanged;
            selectRoomData.CellClick += selectRoomData_CellContentClick;
            this.renterValues = renterValues ?? new List<string>();
            this.renterColumns = renterColumns ?? new List<string>();

        }
        private void nextButton_Click(object sender, EventArgs e)
        {

            mainForm mainForm = (mainForm)this.ParentForm;
            mainForm.rForm2_nextButtonClick(this, EventArgs.Empty);

            if (availLabel.Text == "Unoccupied")
            {
                insertRentersRecords();
                loadMoveinValues();
                insertMoveinRecords();
                loadDepositValues();
                insertDepositRecord();
                loadRegistrationValues();
                insertRegistrationRecords();
                loadRAValues();
                insertRARecords();
                loadRAValues2();
                insertRARecords2();
            }

            else
            {
                insertRentersRecords();
                loadMoveinValues();
                insertMoveinRecords();
                loadRegistrationValues2();
                insertRegistrationRecords2();
                loadRAValues();
                insertRARecords();
                loadRAValues2();
                insertRARecords2();
            }
        }
        private void insertRentersRecords()
        {
            string table = "tbl_renter";
            string values = "";
            string columns;
            for (int i = 0; i < renterValues.Count; i++)
            {
                values += "'" + renterValues[i] + "'";
                if (i != renterValues.Count - 1)
                {
                    values += ",";
                }
            }

            columns = string.Join(", ", renterColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);

        }

        private void insertMoveinRecords()
        {
            string table = "tbl_moveIn";
            string values = moveinValues[0] + ", '" + moveinValues[1] + "'";
            string columns = string.Join(", ", moveinColumns);


            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);

        }

        private void insertRegistrationRecords()
        {
            string table = "tbl_registration";
            string values = registrationValues[0] + ",'" + registrationValues[1] + "'," + registrationValues[2] + ",'" + registrationValues[3] + "'";
            string columns = string.Join(", ", registrationColumns);


            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);

        }

        private void insertRegistrationRecords2()
        {
            string table = "tbl_registration";
            string values = registrationValues[0] + "," + registrationValues[1] + ",'" + registrationValues[2] + "'," + registrationValues[3] + ",'" + registrationValues[4] + "'";
            string columns = string.Join(", ", registrationColumns2);


            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);

        }
        private void insertRARecords()
        {
            string table = "tbl_room_availability_record";
            string values = "'" + rAValues[0] + "', " + rAValues[1] + ", '" + rAValues[2] + "'";
            string columns = string.Join(", ", rAColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void insertRARecords2()
        {
            string table = "tbl_room_availability_record";
            string values = "'" + rAValues2[0] + "', " + rAValues2[1] + ", '" + rAValues2[2] + "'";
            string columns = string.Join(", ", rAColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void insertDepositRecord()
        {
            string table = "tbl_Deposit";
            string columns = depositColumns[0];
            string values = depositValues[0];

            MessageBox.Show(table + "!!!" + columns + " !!!" + values); // Testing message box

            ConnectToSQL.insertRecord(table, columns, values);
        }


        private void loadRegistrationValues()
        {
            string renterID = ConnectToSQL.readTableString("SELECT MAX(renter_id) FROM tbl_renter;");
            string roomID = roomTBox.Text;
            string depositID = ConnectToSQL.readTableString("SELECT MAX(deposit_ID) FROM tbl_deposit;");
            string rDate = registrationDate.Value.ToString("yyyy-MM-dd");

            registrationValues.Clear();

            registrationValues.Add(renterID);
            registrationValues.Add(roomID);
            registrationValues.Add(depositID);
            registrationValues.Add(rDate);
        }

        private void loadRegistrationValues2()
        {
            string registrationID = ConnectToSQL.readTableString($"SELECT Registration_ID\r\nFROM tbl_Registration\r\nWHERE Renter_ID = {renterLabel.Text};\r\n"); ;
            string renterID = ConnectToSQL.readTableString("SELECT MAX(renter_id) FROM tbl_renter;");
            string roomID = roomTBox.Text;
            string depositID = ConnectToSQL.readTableString($"SELECT d.Deposit_ID \r\nFROM tbl_Deposit d\r\nINNER JOIN tbl_Registration r ON d.Deposit_ID = r.Deposit_ID\r\nWHERE r.Renter_ID = {renterLabel.Text};");
            string rDate = registrationDate.Value.ToString("yyyy-MM-dd");

            registrationValues.Clear();

            registrationValues.Add(registrationID);
            registrationValues.Add(renterID);
            registrationValues.Add(roomID);
            registrationValues.Add(depositID);
            registrationValues.Add(rDate);
        }

        private void loadMoveinValues()
        {
            string renterID = ConnectToSQL.readTableString("SELECT MAX(renter_id) FROM tbl_renter;");
            string mDate = moveInDate.Value.ToString("yyyy-MM-dd");

            moveinValues.Clear();

            moveinValues.Add(renterID);
            moveinValues.Add(mDate);

        }

        private void loadRAValues()
        {
            string roomID = roomTBox.Text;
            string ratID = "2";
            string raDate = registrationDate.Value.ToShortDateString();
            raDate = registrationDate.Value.ToString("yyyy-MM-dd");

            rAValues.Clear();

            rAValues.Add(roomID);
            rAValues.Add(ratID);
            rAValues.Add(raDate);

        }

        private void loadRAValues2()
        {
            string roomID = roomTBox.Text;
            string ratID = "3";
            string mDate = moveInDate.Value.ToShortDateString();
            mDate = moveInDate.Value.ToString("yyyy-MM-dd");

            rAValues2.Clear();

            rAValues2.Add(roomID);
            rAValues2.Add(ratID);
            rAValues2.Add(mDate);

        }

        private void loadDepositValues()
        {
            string depositTotal = depositAmountTBox.Text;

            depositValues.Clear();

            depositValues.Clear();
            depositValues.Add(depositTotal);
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            mainForm mainForm = (mainForm)this.ParentForm;
            mainForm.rForm2_prevButtonClick(this, EventArgs.Empty);
        }

        public DataGridView getTable()
        {
            return selectRoomData;
        }


        private void loadDataToLabels(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                roomLabel.Text = rowData[0];
                priceLabel.Text = rowData[1];
                availLabel.Text = rowData[2];
                floorLabel.Text = rowData[3];
                maxLabel.Text = rowData[4];
                renterLabel.Text = rowData[5];
                fNameLabel.Text = rowData[6];
                mNameLabel.Text = rowData[7];
                lNameLabel.Text = rowData[8];

                roomTBox.Text = rowData[0];
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

                roomTBox.Text = "";
            }
        }

        private void selectRoomData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> rowData = new List<string>();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = selectRoomData.Rows[e.RowIndex];
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
            searchCBox.Items.Add("Room Price");
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
            string table = "vw_current_rooms_tenants";
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
                ConnectToSQL.LoadDataGridView(selectRoomData, query);
            }
        }
        /*
        private void UpdateTextBoxesAvailabilityStatus(string availabilityStatus)
        {
            // Assuming textBox1 and textBox2 are the textboxes you want to enable/disable
            if (availabilityStatus == "occupied" || availabilityStatus == "reserved")
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
            else // Unoccupied
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
        }
        */

    }
}
