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
    public partial class changeRateForm : Form
    {
        private int type;
        private pricesForm parentForm;
        private List<string> billRateValues;
        private List<string> billRateValues2;
        private List<string> billRateColumns;

        public changeRateForm(pricesForm parent, int type)
        {
            parentForm = parent;
            this.type = type;
            InitializeComponent();
            billRateValues = new List<string>();
            billRateValues2 = new List<string>();
            billRateColumns = new List<string> { "BT_ID", "BR_price", "BR_date" };
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Changes made!");
            loadBillRateValues();
            insertBillRateRecord();
            this.Close();

        }

        private void loadBillRateValues()
        {
            string btId = type.ToString();
            string price = txtRate.Text;
            string date = billDate.Value.ToString("yyyy-MM-dd");

            billRateValues.Clear();

            billRateValues.Add(btId);
            billRateValues.Add(price);
            billRateValues.Add(date);

            MessageBox.Show(string.Join(", ", billRateValues)); // Testing
        }

        private void insertBillRateRecord()
        {
            string table = "tbl_bill_rate_record";
            string values = billRateValues[0] + ", " + billRateValues[1] + ", '" + billRateValues[2] + "'";
            string columns = string.Join(", ", billRateColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
