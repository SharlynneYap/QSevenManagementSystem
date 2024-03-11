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
    public partial class pricesForm : Form
    {
        private List<string> BillRateValues;
        private List<string> BillRateColumns;
        private List<string> BillRateValues2;
        private List<string> priceValues;
        private List<string> priceColumns;

        public pricesForm()
        {
            InitializeComponent();
        
            BillRateValues = new List<string>();
            BillRateColumns = new List<string> { "BT_ID", "BR_price", "BR_date" };
            BillRateValues2 = new List<string>();
            priceValues = new List<string>();
            priceColumns = new List<string> { "room_id", "rp_price", "rp_date" };
        }
        private void loadBillRateValues()
        {
            string btId = "1";
            string price = elecTBox.Text;
            string date = elecDate.Value.ToString("yyyy-MM-dd");

            BillRateValues.Clear();

            BillRateValues.Add(btId);
            BillRateValues.Add(price);
            BillRateValues.Add(date);

            MessageBox.Show(string.Join(", ", BillRateValues)); // Testing
        }

        private void insertBillRateRecord()
        {
            string table = "tbl_bill_rate_record";
            string values = BillRateValues[0] + ", " + BillRateValues[1] + ", '" + BillRateValues[2] + "'";
            string columns = string.Join(", ", BillRateColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void loadBillRateValues2()
        {
            string btId = "2";
            string price = waterTBox.Text;
            string date = waterDate.Value.ToString("yyyy-MM-dd");

            BillRateValues2.Clear();

            BillRateValues2.Add(btId);
            BillRateValues2.Add(price);
            BillRateValues2.Add(date);


            MessageBox.Show(string.Join(", ", BillRateValues2)); // Testing
        }

        private void insertBillRateRecord2()
        {
            string table = "tbl_bill_rate_record";
            string values = BillRateValues2[0] + ", " + BillRateValues2[1] + ", '" + BillRateValues2[2] + "'";
            string columns = string.Join(", ", BillRateColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void loadPriceValues()
        {
            string roomID = roomIdTBox.Text;
            string price = priceTBox.Text;
            string date = priceDate.Value.ToShortDateString();
            date = priceDate.Value.ToString("yyyy-MM-dd");

            priceValues.Clear();

            priceValues.Add(roomID);
            priceValues.Add(price);
            priceValues.Add(date);

            MessageBox.Show(string.Join(", ", priceValues)); // Testing
        }
        private void insertPriceRecords()
        {
            string table = "tbl_room_price_record";
            string values = "'" + priceValues[0] + "', " + priceValues[1] + ",'" + priceValues[2] + "'";
            string columns = string.Join(", ", priceColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void pricesForm_Load(object sender, EventArgs e)
        {

        }

        private void applyElecButton_Click(object sender, EventArgs e)
        {

            loadBillRateValues();
            insertBillRateRecord();
        }

        private void applyWaterButton_Click(object sender, EventArgs e)
        {
            loadBillRateValues2();
            insertBillRateRecord2();
        }

        private void applyRoomButton_Click(object sender, EventArgs e)
        {       
            loadPriceValues();
            insertPriceRecords();
            ConnectToSQL.LoadDataGridView(this.getTable(), "SELECT * FROM vw_room_price_history");
        }

        public DataGridView getTable()
        {
            return priceData;
        }
    }
}
