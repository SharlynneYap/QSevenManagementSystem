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
    public partial class paymentsHistoryForm : Form
    {
        public paymentsHistoryForm()
        {
            InitializeComponent();
            tblDPN.SetColumnSpan(lblTbl_dpn, 2);
            tblRcpt.SetColumnSpan(lblTbl_rcpt, 2);
            tblBills.SetColumnSpan(lblTbl_bills, 2);
            tblOC.SetColumnSpan(lblTbl_oc, 2);

            //listeners
            dpnData.CellClick += dpnData_CellContentClick;
            receiptData.CellClick += receiptData_CellContentClick;
            billData.CellClick += billData_CellContentClick;
            otherChargesData.CellClick += otherChargesData_CellContentClick;

            //load comboboxes
            loadSearchCBox1();
            loadSearchCBox2();
            loadSearchCBox3();
            loadSearchCBox4();

            searchTBox1.TextChanged += searchTBox1_TextChanged;
            searchTBox2.TextChanged += searchTBox2_TextChanged;
            searchTBox3.TextChanged += searchTBox3_TextChanged;
            searchTBox4.TextChanged += searchTBox4_TextChanged;
        }

        public DataGridView getTable(int num)
        {
            if (num == 1)
            {
                return dpnData;
            }
            else if (num == 2)
            {
                return receiptData;
            }
            else if (num == 3)
            {
                return billData;
            }
            else
            {
                return otherChargesData;
            }
        }

        private void loadDataToLabels1(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                dpn_IDLbl.Text = rowData[0];
                dpn_RegIDLbl.Text = rowData[1];
                dpn_roomIDLbl.Text = rowData[2];
                dpn_roomPrcLbl.Text = rowData[3];
                dpn_depUsedLbl.Text = rowData[4];
                dpn_totalLbl.Text = rowData[5];
                dpn_dtIssdLbl.Text = rowData[6];
                dpn_monthLbl.Text = rowData[7];


            }
            else
            {
                // Clear labels if there is no selected row
                dpn_IDLbl.Text = "None";
                dpn_RegIDLbl.Text = "None";
                dpn_roomIDLbl.Text = "None";
                dpn_roomPrcLbl.Text = "None";
                dpn_depUsedLbl.Text = "None";
                dpn_totalLbl.Text = "None";
                dpn_dtIssdLbl.Text = "None";
                dpn_monthLbl.Text = "None";
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
            loadDataToLabels1(rowData);
        }



        private void loadDataToLabels2(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                rcpt_IDlbl1.Text = rowData[0];
                rcpt_dpnIDLbl2.Text = rowData[1];
                rcpt_regLbl3.Text = rowData[2];
                rcpt_roomLbl4.Text = rowData[3];
                rcpt_amtLbl5.Text = rowData[4];
                rcpt_payLbl6.Text = rowData[5];
                rcpt_dateLbl7.Text = rowData[6];
            }
            else
            {
                // Clear labels if there is no selected row
                rcpt_IDlbl1.Text = "None";
                rcpt_dpnIDLbl2.Text = "None";
                rcpt_regLbl3.Text = "None";
                rcpt_roomLbl4.Text = "None";
                rcpt_amtLbl5.Text = "None";
                rcpt_payLbl6.Text = "None";
                rcpt_dateLbl7.Text = "None";
            }
        }

        private void receiptData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> rowData = new List<string>();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = receiptData.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    rowData.Add(cell.Value?.ToString() ?? "");
                }
            }
            loadDataToLabels2(rowData);
        }


        private void loadDataToLabels3(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                bill_IDLbl1.Text = rowData[0];
                bill_dpnLbl2.Text = rowData[1];
                bill_regIDLbl3.Text = rowData[2];
                bill_roomIDLbl4.Text = rowData[3];
                bill_typeLbl5.Text = rowData[4];
                bill_mtrStrMoLbl6.Text = rowData[5];
                bill_mtrEndMoLbl7.Text = rowData[6];
                bill_rateLbl8.Text = rowData[7];
                bill_totalLbl9.Text = rowData[8];
                bill_dateLbl10.Text = rowData[9];
                bill_monthLbl11.Text = rowData[10];
            }
            else
            {
                // Clear labels if there is no selected row
                bill_IDLbl1.Text = "None";
                bill_dpnLbl2.Text = "None";
                bill_regIDLbl3.Text = "None";
                bill_roomIDLbl4.Text = "None";
                bill_typeLbl5.Text = "None";
                bill_mtrStrMoLbl6.Text = "None";
                bill_mtrEndMoLbl7.Text = "None";
                bill_rateLbl8.Text = "None";
                bill_totalLbl9.Text = "None";
                bill_dateLbl10.Text = "None";
                bill_monthLbl11.Text = "None";
            }
        }

        private void billData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> rowData = new List<string>();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = billData.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    rowData.Add(cell.Value?.ToString() ?? "");
                }
            }
            loadDataToLabels3(rowData);
        }

        private void loadDataToLabels4(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                oc_lbl1.Text = rowData[0];
                oc_lbl2.Text = rowData[1];
                oc_lbl3.Text = rowData[2];
                oc_lbl4.Text = rowData[3];
                oc_lbl5.Text = rowData[4];
                oc_lbl6.Text = rowData[5];
                oc_lbl7.Text = rowData[6];
                oc_lbl8.Text = rowData[7];
            }
            else
            {
                // Clear labels if there is no selected row
                oc_lbl1.Text = rowData[0];
                oc_lbl2.Text = rowData[1];
                oc_lbl3.Text = rowData[2];
                oc_lbl4.Text = rowData[3];
                oc_lbl5.Text = rowData[4];
                oc_lbl6.Text = rowData[5];
                oc_lbl7.Text = rowData[6];
                oc_lbl8.Text = rowData[7];
            }
        }

        private void otherChargesData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> rowData = new List<string>();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = otherChargesData.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    rowData.Add(cell.Value?.ToString() ?? "");
                }
            }
            loadDataToLabels4(rowData);
        }


        // search functions
        private void loadSearchCBox1()//adds items to the search combo box
        {
            searchCBox1.Items.Add("dpn_id");
            searchCBox1.Items.Add("Registration ID");
            searchCBox1.Items.Add("Room ID");
            searchCBox1.Items.Add("Room Price");
            searchCBox1.Items.Add("Is Deposit Used");
            searchCBox1.Items.Add("Total");
            searchCBox1.Items.Add("For the month of");
            searchCBox1.Items.Add("DPN Date Issued");

        }

        private void searchTBox1_TextChanged(object sender, EventArgs e)
        {
            string table = "vw_dpn_total";
            // Get the selected column from the ComboBox
            string selectedColumn = searchCBox1.SelectedItem?.ToString();

            // Get the search value from the TextBox
            string searchValue = searchTBox1.Text.Trim();

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

        private void loadSearchCBox2()//adds items to the search combo box
        {
            searchCBox2.Items.Add("Receipt ID");
            searchCBox2.Items.Add("DPN ID");
            searchCBox2.Items.Add("Registration ID");
            searchCBox2.Items.Add("Room ID");
            searchCBox2.Items.Add("Amount Paid");
            searchCBox2.Items.Add("Payment Status");
            searchCBox2.Items.Add("Date Issued");

        }

        private void searchTBox2_TextChanged(object sender, EventArgs e)
        {
            string table = "vw_receipt_history";
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
                ConnectToSQL.LoadDataGridView(receiptData, query);
            }
        }

        private void loadSearchCBox3()//adds items to the search combo box
        {
            searchCBox3.Items.Add("Bill ID");
            searchCBox3.Items.Add("DPN ID");
            searchCBox3.Items.Add("Registration ID");
            searchCBox3.Items.Add("Room ID");
            searchCBox3.Items.Add("Bill Type");
            searchCBox3.Items.Add("Meter Start Month");
            searchCBox3.Items.Add("Meter End Month");
            searchCBox3.Items.Add("Bill Rate");
            searchCBox3.Items.Add("Bill Total");
            searchCBox3.Items.Add("Date Issued");
            searchCBox3.Items.Add("For the month of");
        }

        private void searchTBox3_TextChanged(object sender, EventArgs e)
        {
            string table = "vw_bills_history";
            // Get the selected column from the ComboBox
            string selectedColumn = searchCBox3.SelectedItem?.ToString();

            // Get the search value from the TextBox
            string searchValue = searchTBox3.Text.Trim();

            // Check if a column and search value are provided
            if (!string.IsNullOrEmpty(selectedColumn) && !string.IsNullOrEmpty(searchValue))
            {
                // Define the SQL query
                string query = $"SELECT * FROM {table} WHERE `{selectedColumn}` LIKE '%{searchValue}%'";
                //MessageBox.Show(query); //For testing
                //Execute the query and update the DataGridView
                ConnectToSQL.LoadDataGridView(billData, query);
            }
        }

        private void loadSearchCBox4()//adds items to the search combo box
        {
            searchCBox4.Items.Add("Other Charges ID");
            searchCBox4.Items.Add("DPN ID");
            searchCBox4.Items.Add("Registration ID");
            searchCBox4.Items.Add("Room ID");
            searchCBox4.Items.Add("Description");
            searchCBox4.Items.Add("Other Charges Total");
            searchCBox4.Items.Add("Date Issued");
            searchCBox4.Items.Add("For the month of");
        }

        private void searchTBox4_TextChanged(object sender, EventArgs e)
        {
            string table = "vw_other_charges_history";
            // Get the selected column from the ComboBox
            string selectedColumn = searchCBox4.SelectedItem?.ToString();

            // Get the search value from the TextBox
            string searchValue = searchTBox4.Text.Trim();

            // Check if a column and search value are provided
            if (!string.IsNullOrEmpty(selectedColumn) && !string.IsNullOrEmpty(searchValue))
            {
                // Define the SQL query
                string query = $"SELECT * FROM {table} WHERE `{selectedColumn}` LIKE '%{searchValue}%'";
                //MessageBox.Show(query); //For testing
                //Execute the query and update the DataGridView
                ConnectToSQL.LoadDataGridView(otherChargesData, query);
            }
        }









    }
}

