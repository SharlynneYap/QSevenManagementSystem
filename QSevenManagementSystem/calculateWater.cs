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

        private void startMonthButton_Click(object sender, EventArgs e)
        {
            string roomIdQuery = "SELECT Room_ID FROM tbl_registration WHERE Registration_ID = (SELECT Registration_ID FROM tbl_dpn ORDER BY dpn_id DESC LIMIT 1)";
            string roomId = ConnectToSQL.readTableString(roomIdQuery);

            if (string.IsNullOrEmpty(roomId))
            {
                // Set default values to 0
                meterStartMonthTBox.Text = "0";
            }
            else
            {
                string meterEndMonthQuery = $"SELECT MAX(`Meter End Month`) FROM vw_bills_history WHERE `Room ID` = '{roomId}' and `Bill Type` = 'Water';";

                string meterEndMonth = ConnectToSQL.readTableString(meterEndMonthQuery);

                meterStartMonthTBox.Text = string.IsNullOrEmpty(meterEndMonth) ? "0" : meterEndMonth.Replace(',', '.');

            }
        }
    }
}

