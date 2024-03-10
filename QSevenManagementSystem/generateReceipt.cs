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
    }
}
