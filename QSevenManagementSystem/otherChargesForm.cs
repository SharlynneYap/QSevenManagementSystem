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
    public partial class otherChargesForm : Form
    {
        List<string> otherChargesValues;
        List<string> otherChargesColumns;
        public otherChargesForm()
        {
            InitializeComponent();
            otherChargesValues = new List<string>();
            otherChargesColumns = new List<string>() { "dpn_id", "oc_description", "oc_total" };
        }



        private void loadOtherChargesValues()
        {
            string dpnId = ConnectToSQL.readTableString("SELECT MAX(dpn_id) FROM tbl_dpn;"); ;
            string description = descriptionTBox.Text;
            string total = totalTBox.Text;

            otherChargesValues.Clear();

            otherChargesValues.Add(dpnId);
            otherChargesValues.Add(description);
            otherChargesValues.Add(total);

            MessageBox.Show(string.Join(", ", otherChargesValues)); // Testing
        }

        private void insertOtherChargesRecord()
        {
            string table = "tbl_other_charges";
            string columns = string.Join(", ", otherChargesColumns);
            string values = otherChargesValues[0] + ",'" + otherChargesValues[1] + "'," + otherChargesValues[2];

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing

            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {

            loadOtherChargesValues();
            insertOtherChargesRecord();

            this.Close();


        }
    }
}
