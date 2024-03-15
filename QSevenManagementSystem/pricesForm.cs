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
    public partial class pricesForm : Form
    {
        private changeRateForm changeRateForm;
        //private List<string> BillRateValues;
        //private List<string> BillRateColumns;
        //private List<string> BillRateValues2;
        private List<string> priceValues;
        private List<string> priceColumns;
        List<string> rowData = new List<string>();
        //private String elecBill, waterBill;

        public pricesForm()
        {
            InitializeComponent();

            //BillRateValues = new List<string>();
            //BillRateColumns = new List<string> { "BT_ID", "BR_price", "BR_date" };
            //BillRateValues2 = new List<string>();
            priceValues = new List<string>();
            priceColumns = new List<string> { "room_id", "rp_price", "rp_date" };
            priceData.CellClick += priceData_CellContentClick;
            priceDate.MinDate = DateTime.Now.Date;
            /*elecTBox.Text = ConnectToSQL.readTableString("");
            elecBill = elecTBox.Text;
            waterTBox.Text = //insert query
            waterBill = waterTBox.Text; */
            searchCBox.Items.AddRange(new String[] { "Room ID", "Room Floor", "Max # of Renters", "Room Price", "Date of Price Change" });
            reloadBillRts();
        }

        public void reloadBillRts()
        {
            elecTBox.Text = ConnectToSQL.readTableString("SELECT br_price FROM tbl_bill_rate_record WHERE bt_id = 1 ORDER BY br_id DESC LIMIT 1");
            waterTBox.Text = ConnectToSQL.readTableString("SELECT br_price FROM tbl_bill_rate_record WHERE bt_id = 2 ORDER BY br_id DESC LIMIT 1");
        }
        /*
        private void loadBillRateValues()
        {
            string btId = "1";
            string price = elecTBox.Text;
            //string date = elecDate.Value.ToString("yyyy-MM-dd");

            BillRateValues.Clear();

            BillRateValues.Add(btId);
            BillRateValues.Add(price);
            //BillRateValues.Add(date);

            MessageBox.Show(string.Join(", ", BillRateValues)); // Testing
        }
       
        private void insertBillRateRecord()
        {
            string table = "tbl_bill_rate_record";
            string values = BillRateValues[0] + ", " + BillRateValues[1] + ", '" + BillRateValues[2] + "'";
            string columns = string.Join(", ", BillRateColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void loadBillRateValues2()
        {
            string btId = "2";
            string price = waterTBox.Text;
            //string date = waterDate.Value.ToString("yyyy-MM-dd");

            BillRateValues2.Clear();

            BillRateValues2.Add(btId);
            BillRateValues2.Add(price);
            //BillRateValues2.Add(date);


            MessageBox.Show(string.Join(", ", BillRateValues2)); // Testing
        }

        private void insertBillRateRecord2()
        {
            string table = "tbl_bill_rate_record";
            string values = BillRateValues2[0] + ", " + BillRateValues2[1] + ", '" + BillRateValues2[2] + "'";
            string columns = string.Join(", ", BillRateColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }
        */

        private void priceData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> rowData = new List<string>();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = priceData.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    rowData.Add(cell.Value?.ToString() ?? "");
                }
            }
            loadDataToLabels(rowData);
            this.rowData = rowData;
        }

        private void loadDataToLabels(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                roomIdTBox.Text = rowData[0];
                priceTBox.Text = rowData[3];
            }
            else
            {
                // Clear labels if there is no selected row
                roomIdTBox.Text = "None";
                priceTBox.Text = "None";
            }
        }

        private void loadPriceValues()
        {
            string roomID = roomIdTBox.Text;
            string price = priceTBox.Text;
            string date = priceDate.Value.ToShortDateString();
            date = priceDate.Value.ToString("yyyy-MM-dd");

            priceValues.Clear();

            priceValues.Add(roomID);
            priceValues.Add(price);
            priceValues.Add(date);

            MessageBox.Show(string.Join(", ", priceValues)); // Testing
        }
        private void insertPriceRecords()
        {
            string table = "tbl_room_price_record";
            string values = "'" + priceValues[0] + "', " + priceValues[1] + ",'" + priceValues[2] + "'";
            string columns = string.Join(", ", priceColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void searchTBox_TextChanged(object sender, EventArgs e)
        {
            string table = "vw_rooms_current_prices";
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
                ConnectToSQL.LoadDataGridView(priceData, query);
            }
        }

        private void pricesForm_Load(object sender, EventArgs e)
        {

        }

        private void applyRoomButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                applyRoomButton.Visible = false;
                editBtn.Visible = true;
                cancelBtn.Visible = false;
                priceTBox.ReadOnly = true;
                priceDate.Enabled = false;

                loadPriceValues();
                insertPriceRecords();
                ConnectToSQL.LoadDataGridView(this.getTable(), "SELECT * FROM vw_room_price_history");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            applyRoomButton.Visible = true;
            editBtn.Visible = false;
            cancelBtn.Visible = true;

            priceTBox.ReadOnly = false;
            priceDate.Enabled = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            applyRoomButton.Visible = false;
            editBtn.Visible = true;
            cancelBtn.Visible = false;
            priceTBox.ReadOnly = true;
            priceDate.Enabled = false;

            if (rowData.Count > 0)
            {
                roomIdTBox.Text = rowData[0];
                priceTBox.Text = rowData[3];
            }
        }

        public DataGridView getTable()
        {
            return priceData;
        }


        private void changeElecBillBtn_Click(object sender, EventArgs e)
        {
            changeRateForm = new changeRateForm(this, 1);
            changeRateForm.ShowDialog();
        }

        private void changeWaterBillBtn_Click(object sender, EventArgs e)
        {
            changeRateForm = new changeRateForm(this, 2);
            changeRateForm.ShowDialog();
        }

        private bool validate()
        {
            if (string.IsNullOrEmpty(priceTBox.Text))
            {
                MessageBox.Show("Input missing!");
            }
            else if (priceTBox.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Letters are not allowed!");
            }
            else if (priceTBox.Text.Any(c => !char.IsDigit(c) && c != '.'))
            {
                MessageBox.Show("Special characters are not allowed!");
            }
            else
            {
                try
                {
                    double rate = double.Parse(priceTBox.Text);

                    if (priceTBox.Text.Contains("."))
                    {
                        // Get the index of the decimal separator
                        int decimalIndex = priceTBox.Text.IndexOf(".");

                        // Check if there are more than two digits after the decimal separator
                        if (priceTBox.Text.Length - decimalIndex - 1 > 2)
                        {
                            MessageBox.Show("Please enter a rate with at most two decimal places.");
                        }
                        else if (rate < 0)
                        {
                            MessageBox.Show("Number should be positive!");
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else if (rate < 0)
                    {
                        MessageBox.Show("Number should be positive!");
                    }
                    else
                    {
                        return true;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid input. Please enter a valid number.");
                }
            }
            return false;
        }

    }
}
