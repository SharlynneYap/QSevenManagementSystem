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

            mainForm mainForm = (mainForm)this.ParentForm;
            mainForm.rForm_nextButtonClick(this, EventArgs.Empty);
            loadRenterValues();
        }

        private void loadRenterValues()
        {
            string fName = mNameTBox.Text;
            string mName = string.IsNullOrEmpty(fNameTBox.Text) ? "NULL" : fNameTBox.Text;
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

    }
}
