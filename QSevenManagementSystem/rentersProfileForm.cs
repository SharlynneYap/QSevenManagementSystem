using Org.BouncyCastle.Asn1.X509;
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
    public partial class rentersProfileForm : Form
    {
        List<string> rowData = new List<string>();
        public rentersProfileForm()
        {
            InitializeComponent();
            searchTBox.TextChanged += searchTBox_TextChanged;
            rentersData.CellClick += rentersData_CellContentClick;
            loadSearchCBox();
        }

        public DataGridView getTable()
        {
            return rentersData;
        }

        public string getRenterID()
        {
            return lblRenterIDVal.Text;
        }

        private void moveOutButton_Click(object sender, EventArgs e)
        {
            moveOutForm moveOutForm = new moveOutForm(this);
            moveOutForm.ShowDialog();
        }

        private void loadDataToLabels(List<string> rowData)
        {

            if (rowData.Count > 0)
            {
                lblRegIDVal.Text = rowData[0];
                lblRenterIDVal.Text = rowData[1];
                txtFname.Text = rowData[2];
                txtMname.Text = rowData[3];
                txtLname.Text = rowData[4];
                txtContact.Text = rowData[5];
                txtDob.Text = rowData[6];
                txtAddress.Text = rowData[7];
                roomLabel.Text = rowData[8];
                depositLabel.Text = rowData[9];
                moveInLabel.Text = rowData[10];
                regisDateLabel.Text = rowData[11];

            }
            else
            {
                // Clear labels if there is no selected row
                lblRegIDVal.Text = "None";
                lblRenterIDVal.Text = "None";
                txtFname.Text = "None";
                txtMname.Text = "None";
                txtLname.Text = "None";
                txtContact.Text = "None";
                txtDob.Text = "None";
                txtAddress.Text = "None";
                roomLabel.Text = "None";
                depositLabel.Text = "None";
                moveInLabel.Text = "None";
                regisDateLabel.Text = "None";
            }
        }

        private void rentersData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<string> rowData = new List<string>();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = rentersData.Rows[e.RowIndex];
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    rowData.Add(cell.Value?.ToString() ?? "");
                }
            }
            loadDataToLabels(rowData);
            this.rowData = rowData;
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
            searchCBox.Items.Add("Address");
            searchCBox.Items.Add("Room ID");
            searchCBox.Items.Add("Deposit Paid");
            searchCBox.Items.Add("Move In Date");
            searchCBox.Items.Add("Registration Date");

        }

        private void searchTBox_TextChanged(object sender, EventArgs e)
        {
            string table = "vw_renters_profile";
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
                ConnectToSQL.LoadDataGridView(rentersData, query);
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                applyButton.Visible = false;
                moveOutButton.Enabled = true;
                editBtn.Visible = true;
                btnCancel.Visible = false;
                rentersData.Enabled = true;

                txtFname.ReadOnly = true;
                txtMname.ReadOnly = true;
                txtLname.ReadOnly = true;
                txtContact.ReadOnly = true;
                txtDob.ReadOnly = true;
                txtAddress.ReadOnly = true;

                //INSERT QUERY HERE (missing edit/update query)
                ConnectToSQL.LoadDataGridView(getTable(), "SELECT * FROM vw_renters_profile");
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            applyButton.Visible = true;
            moveOutButton.Enabled = false;
            editBtn.Visible = false;
            btnCancel.Visible = true;
            rentersData.Enabled = false;

            txtFname.ReadOnly = false;
            txtMname.ReadOnly = false;
            txtLname.ReadOnly = false;
            txtContact.ReadOnly = false;
            txtDob.ReadOnly = false;
            txtAddress.ReadOnly = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (rowData.Count > 0)
            {
                loadDataToLabels(this.rowData);
            }
            applyButton.Visible = false;
            moveOutButton.Enabled = true;
            editBtn.Visible = true;
            btnCancel.Visible = false;
            rentersData.Enabled = true;

            txtFname.ReadOnly = true;
            txtMname.ReadOnly = true;
            txtLname.ReadOnly = true;
            txtContact.ReadOnly = true;
            txtDob.ReadOnly = true;
            txtAddress.ReadOnly = true;
        }

        private bool validate()
        {
            bool isEmpty = false;
            List<String> fields = new List<String>();

            fields.Add(txtFname.Text);
            fields.Add(txtMname.Text);
            fields.Add(txtLname.Text);
            fields.Add(txtContact.Text);
            fields.Add(txtDob.Text);
            fields.Add(txtAddress.Text);

            foreach (String field in fields)
            {
                if (string.IsNullOrEmpty(field))
                {
                    isEmpty = true;
                    break;
                }
            }

            if (isEmpty)
            {
                MessageBox.Show("There are some fields empty!");
            }
            else if (fields[0].Any(char.IsDigit))
            {
                MessageBox.Show("First Name cannot contain digits!");
            }
            else if (fields[0].Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("First Name cannot contain special characters!");
            }
            else if (fields[1].Any(char.IsDigit))
            {
                MessageBox.Show("Middle Name cannot contain digits!");
            }
            else if (fields[1].Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("Middle Name cannot contain special characters!");
            }
            else if (fields[2].Any(char.IsDigit))
            {
                MessageBox.Show("Last Name cannot contain digits!");
            }
            else if (fields[2].Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("Last Name cannot contain special characters!");
            }
            else if (fields[3].Any(char.IsLetter))
            {
                MessageBox.Show("Contact cannot contain letters!");
            }
            else
            {
                return true;
            }
            return false;
        }
    }
}
