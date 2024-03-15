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
    public partial class calculateWater : Form
    {
        otherChargesForm oCForm = new otherChargesForm();
        public calculateWater()
        {
            InitializeComponent();
            billValues = new List<String>();
            billRateLabel.Text = ConnectToSQL.readTableString(@"SELECT br_price FROM tbl_bill_rate_record 
                                                                WHERE bt_id = 2 
                                                                AND (br_date, br_id) = (SELECT MAX(br_date), MAX(br_id)   
                                                                FROM tbl_bill_rate_record   
                                                                WHERE bt_id = 2  
                                                                AND br_date <= CURRENT_DATE);");
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            this.Close();
            loadBillValues();

            DialogResult result = MessageBox.Show("Add other charges?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            while (result == DialogResult.Yes)
            {
                oCForm.ShowDialog();
                result = MessageBox.Show("Add other charges?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }
        }

        List<String> billValues;

        private void loadBillValues()
        {
            string dpnId = "placeholder";
            string btId = "2";
            string meterEndMonth = meterEndMonthTBox.Text;
            string meterStartMonth = meterStartMonthTBox.Text;

            billValues.Clear();

            billValues.Add(dpnId);
            billValues.Add(btId);
            billValues.Add(meterEndMonth);
            billValues.Add(meterStartMonth);

            MessageBox.Show(string.Join(", ", billValues)); // Testing
        }

        public List<String> getBillValues()
        {
            return billValues;
        }
    }
}

