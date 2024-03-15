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
    public partial class rentersHistoryForm : Form
    {
        public rentersHistoryForm()
        {
            InitializeComponent();
            loadSearchCBox();
            loadSearchCBox2();
            searchTBox.TextChanged += searchTBox_TextChanged;
            searchTBox2.TextChanged += searchTBox_TextChanged2;
            moveinData.CellClick += moveinData_CellContentClick;
            moveoutData.CellClick += moveoutData_CellContentClick;
        }

        public DataGridView getTable(int num)
        {
            return num == 1 ? moveinData : moveoutData;
        }

        private void loadDataToLabels(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                registrationLabel.Text = rowData[0];
                renterLabel.Text = rowData[1];
                fLabel.Text = rowData[2];
                mLabel.Text = rowData[3];
                lLabel.Text = rowData[4];
                contactLabel.Text = rowData[5];
                dobLabel.Text = rowData[6];
                sexLabel.Text = rowData[7];
                addressLabel.Text = rowData[8];
                roomLabel.Text = rowData[9];
                depositLabel.Text = rowData[10];
                moveInLabel.Text = rowData[11];
                regisDateLabel.Text = rowData[12];
            }
            else
            {
                // Clear labels if there is no selected row
                registrationLabel.Text = "None";
                renterLabel.Text = "None";
                fLabel.Text = "None";
                mLabel.Text = "None";
                lLabel.Text = "None";
                contactLabel.Text = "None";
                dobLabel.Text = "None";
                sexLabel.Text = "None";
                addressLabel.Text = "None";
                roomLabel.Text = "None";
                depositLabel.Text = "None";
                moveInLabel.Text = "None";
                regisDateLabel.Text = "None";
            }
        }

        private void loadDataToLabels2(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                registrationLabel2.Text = rowData[0];
                renterLabel2.Text = rowData[1];
                fLabel2.Text = rowData[2];
                mLabel2.Text = rowData[3];
                lLabel2.Text = rowData[4];
                contactLabel2.Text = rowData[5];
                dobLabel2.Text = rowData[6];
                sexLabel2.Text = rowData[7];
                addressLabel2.Text = rowData[8];
                roomLabel2.Text = rowData[9];
                moveOutLabel.Text = rowData[11];
                regisLabel2.Text = rowData[12];
            }
            else
            {
                // Clear labels if there is no selected row
                registrationLabel2.Text = "None";
                renterLabel2.Text = "None";
                fLabel2.Text = "None";
                mLabel2.Text = "None";
                lLabel2.Text = "None";
                contactLabel2.Text = "None";
                dobLabel2.Text = "None";
                sexLabel2.Text = "None";
                addressLabel2.Text = "None";
                roomLabel2.Text = "None";
                moveOutLabel.Text = "None";
                regisLabel2.Text = "None";
            }
        }

        private void moveinData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> rowData = new List<string>();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = moveinData.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    rowData.Add(cell.Value?.ToString() ?? "");
                }
            }
            loadDataToLabels(rowData);
        }

        private void moveoutData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> rowData = new List<string>();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = moveinData.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    rowData.Add(cell.Value?.ToString() ?? "");
                }
            }
            loadDataToLabels2(rowData);
        }

        private void loadSearchCBox()//adds items to the search combo box
        {
            searchCBox.Items.Add("Registration ID");
            searchCBox.Items.Add("Renter ID");
            searchCBox.Items.Add("First Name");
            searchCBox.Items.Add("Middle Name");
            searchCBox.Items.Add("Last Name");
            searchCBox.Items.Add("Contact #");
            searchCBox.Items.Add("DOB");
            searchCBox.Items.Add("Sex");
            searchCBox.Items.Add("Address");
            searchCBox.Items.Add("Room ID");
            searchCBox.Items.Add("Deposit Paid");
            searchCBox.Items.Add("Move In Date");
            searchCBox.Items.Add("Move Out Date");
            searchCBox.Items.Add("Registration Date");


        }

        private void loadSearchCBox2()//adds items to the search combo box
        {
            searchCBox2.Items.Add("Registration ID");
            searchCBox2.Items.Add("Renter ID");
            searchCBox2.Items.Add("First Name");
            searchCBox2.Items.Add("Middle Name");
            searchCBox2.Items.Add("Last Name");
            searchCBox2.Items.Add("Contact");
            searchCBox2.Items.Add("Date of Birth");
            searchCBox2.Items.Add("Sex");
            searchCBox2.Items.Add("Address");
            searchCBox2.Items.Add("Room ID");
            searchCBox2.Items.Add("Move Out ID");
            searchCBox2.Items.Add("Move Out Date");
            searchCBox2.Items.Add("registration_date");


        }

        private void searchTBox_TextChanged(object sender, EventArgs e)
        {
            string table = "vw_movein_history";
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
                ConnectToSQL.LoadDataGridView(moveoutData, query);
            }
        }

        private void searchTBox_TextChanged2(object sender, EventArgs e)
        {
            string table = "vw_moveout_history";
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
                ConnectToSQL.LoadDataGridView(moveoutData, query);
            }
        }
    }
}
