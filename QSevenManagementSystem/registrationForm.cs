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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QSevenManagementSystem
{
    public partial class registrationForm : Form
    {
        List<string> renterValues;
        List<string> renterColumns;

        public registrationForm()
        {
            InitializeComponent();
            renterValues = new List<string>();
            renterColumns = new List<string> { "renter_fname", "renter_mname", "renter_lname", "renter_contact", "renter_dob", "renter_address", "renter_sex" };
            sexCBox.Items.Add("F");
            sexCBox.Items.Add("M");
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                mainForm mainForm = (mainForm)this.ParentForm;
                mainForm.rForm_nextButtonClick(this, EventArgs.Empty);
                loadRenterValues();
            }
        }

        private void loadRenterValues()
        {
            string fName = fNameTBox.Text;
            string mName = string.IsNullOrEmpty(fNameTBox.Text) ? "NULL" : mNameTBox.Text;
            string lName = lNameTBox.Text;
            string dob = dobDate.Value.ToString("yyyy-MM-dd");
            string sex = (sexCBox.SelectedItem ?? "").ToString();
            string contact = contactTBox.Text;
            string address = addressTBox.Text;

            renterValues.Clear();

            renterValues.Add(fName);
            renterValues.Add(mName);
            renterValues.Add(lName);
            renterValues.Add(contact);
            renterValues.Add(dob);
            renterValues.Add(address);
            renterValues.Add(sex);

            MessageBox.Show(string.Join(", ", renterValues)); //testing
        }


        public List<string> getRenterColumns()
        {
            return renterColumns;

        }

        public List<string> getRenterValues()
        {
            return renterValues;

        }

        public bool checkFields()
        {
            bool isChecked = false;
            bool isFieldEmpty = false;

            String[] fields = new String[] { fNameTBox.Text, mNameTBox.Text, lNameTBox.Text, contactTBox.Text, addressTBox.Text };

            foreach (String txt in fields)
            {
                if (string.IsNullOrEmpty(txt))
                {
                    isFieldEmpty = true;
                    break;
                }
            }

            if (isFieldEmpty)
            {
                MessageBox.Show("There are some fields empty!");
            }
            else if (fNameTBox.Text.Any(char.IsDigit))
            { //Checks for numbers inside the field
                MessageBox.Show("First name cannot contain numbers!");
            }
            else if (fNameTBox.Text.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("First name cannot contain special characters!");
            }
            else if (mNameTBox.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Middle name cannot contain numbers!");
            }
            else if (mNameTBox.Text.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("Middle name cannot contain special characters!");
            }
            else if (lNameTBox.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Last name cannot contain numbers!");
            }
            else if (lNameTBox.Text.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("Last name cannot contain special characters!");
            }
            else if (contactTBox.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Contact number cannot contain letters!");
            }
            else if (contactTBox.Text.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("Contact number cannot contain special characters!");
            }
            else
            {
                isChecked = true;
            }
            return isChecked;
        }

        public void clearForm()
        {
            fNameTBox.Text = null;
            mNameTBox.Text = null;
            lNameTBox.Text = null;
            dobDate.Value = DateTime.Now;
            sexCBox.SelectedIndex = 1;
            contactTBox.Text = null;
            addressTBox.Text = null;
        }

    }
}
