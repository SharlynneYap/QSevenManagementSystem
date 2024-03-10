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
    public partial class calculateElec : Form
    {
        List<String> billValues;
        public calculateElec()
        {
            InitializeComponent();
            billValues = new List<String>();
            billRateLabel.Text = ConnectToSQL.readTableString(@"SELECT br_price FROM tbl_bill_rate_record 
                                                                WHERE bt_id = 1 
                                                                AND (br_date, br_id) = (SELECT MAX(br_date), MAX(br_id)   
                                                                FROM tbl_bill_rate_record   
                                                                WHERE bt_id = 1   
                                                                AND br_date <= CURRENT_DATE);");
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            loadBillValues();
            this.Close();
        }

        private void loadBillValues()
        {
            string dpnId = "placeholder";
            string btId = "1";
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
