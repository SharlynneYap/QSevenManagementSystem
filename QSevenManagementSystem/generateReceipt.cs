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
    public partial class generateReceipt : Form
    {
        List<string> receiptValues;
        List<string> receiptColumns;
        public generateReceipt()
        {
            InitializeComponent();
            receiptValues = new List<string>();
            receiptColumns = new List<string>() { "dpn_id", "receipt_amount_paid", "receipt_date_issued" };

            searchTBox.TextChanged += searchTBox_TextChanged;
            dpnData.CellClick += dpnData_CellContentClick;
            loadSearchCBox();
        }

        private void loadReceiptValues()
        {
            string dpnId = dpnIdTBox.Text;
            string amountPaid = amountTBox.Text;
            string dateIssued = issuedDate.Value.ToString("yyyy-MM-dd");

            // Clear the list to ensure it's empty before adding new values
            receiptValues.Clear();

            // Add values to the list
            receiptValues.Add(dpnId);
            receiptValues.Add(amountPaid);
            receiptValues.Add(dateIssued);

            // For testing, display the values in a message box
            MessageBox.Show(string.Join(", ", receiptValues));
        }

        private void insertReceiptRecords()
        {
            string table = "tbl_receipt";
            string values = receiptValues[0] + ", " + receiptValues[1] + ", '" + receiptValues[2] + "'";
            string columns = string.Join(", ", receiptColumns);

            // For testing, display the table, columns, and values being inserted
            MessageBox.Show(table + " - " + columns + " - " + values);

            // Insert the record into the database
            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            loadReceiptValues();
            insertReceiptRecords();
        }

        public DataGridView getTable()
        {
            return dpnData;
        }
        private void loadDataToLabels(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                lbl1.Text = rowData[0];
                lbl2.Text = rowData[1];
                lbl3.Text = rowData[2];
                lbl4.Text = rowData[3];
                lbl5.Text = rowData[4];
                lbl6.Text = rowData[5];
                lbl7.Text = rowData[6];
                lbl8.Text = rowData[7];

                dpnIdTBox.Text = rowData[0];

            }
            else
            {
                // Clear labels if there is no selected row
                lbl1.Text = "None";
                lbl2.Text = "None";
                lbl3.Text = "None";
                lbl4.Text = "None";
                lbl5.Text = "None";
                lbl6.Text = "None";
                lbl7.Text = "None";
                lbl8.Text = "None";

                dpnIdTBox.Text = "";
            }
        }

        private void dpnData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> rowData = new List<string>();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dpnData.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    rowData.Add(cell.Value?.ToString() ?? "");
                }
            }
            loadDataToLabels(rowData);
        }

        private void loadSearchCBox()//adds items to the search combo box
        {
            searchCBox.Items.Add("dpn_id");
            searchCBox.Items.Add("Registration ID");
            searchCBox.Items.Add("Room ID");
            searchCBox.Items.Add("Room Price");
            searchCBox.Items.Add("Is Deposit Used");
            searchCBox.Items.Add("Total");
            searchCBox.Items.Add("For the month of");
            searchCBox.Items.Add("DPN Date Issued");

        }

        private void searchTBox_TextChanged(object sender, EventArgs e)
        {
            string table = "vw_dpn_total";
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
                ConnectToSQL.LoadDataGridView(dpnData, query);
            }
        }
    }
}
