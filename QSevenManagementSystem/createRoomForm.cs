using Microsoft.VisualBasic;
using System;
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
    public partial class createRoomForm : Form
    {
        List<string> roomValues;
        List<string> roomColumns;

        List<string> priceValues;
        List<string> priceColumns;

        List<string> rAValues;
        List<string> rAColumns;

        public createRoomForm()
        {
            InitializeComponent();
            roomValues = new List<string>();
            roomColumns = new List<string> { "room_id", "room_floor", "room_max_renters" };

            priceValues = new List<string>();
            priceColumns = new List<string> { "room_id", "rp_price", "rp_date" };

            rAValues = new List<string>();
            rAColumns = new List<string> { "room_id", "rat_id", "ra_date" };
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            mainForm mainForm = (mainForm)this.ParentForm;
            mainForm.createRoomForm_submitButtonClick(this, EventArgs.Empty);

            loadRoomValues();
            loadPriceValues();
            loadRAValues();

            insertRoomRecords();
            insertPriceRecords();
            insertRARecords();

        }

        private void loadRoomValues()
        {
            string roomId = roomIdTBox.Text;
            string floor = floorTBox.Text;
            string maxRenters = maxTBox.Text;

            roomValues.Clear();

            roomValues.Add(roomId);
            roomValues.Add(floor);
            roomValues.Add(maxRenters);

            MessageBox.Show(string.Join(", ", roomValues)); // Testing
        }

        private void loadPriceValues()
        {
            string roomID = roomIdTBox.Text;
            string price = priceTBox.Text;
            string date = raDate.Value.ToShortDateString();
            date = raDate.Value.ToString("yyyy-MM-dd");

            priceValues.Clear();

            priceValues.Add(roomID);
            priceValues.Add(price);
            priceValues.Add(date);

            MessageBox.Show(string.Join(", ", priceValues)); // Testing
        }

        private void loadRAValues()
        {
            string roomID = roomIdTBox.Text;
            string ratID = "1";
            string date = raDate.Value.ToShortDateString();
            date = raDate.Value.ToString("yyyy-MM-dd");

            rAValues.Clear();

            rAValues.Add(roomID);
            rAValues.Add(ratID);
            rAValues.Add(date);
        }

        private void insertRoomRecords()
        {
            string table = "tbl_room";
            string values = "'" + roomValues[0] + "', " + roomValues[1] + ", " + roomValues[2];
            string columns = string.Join(", ", roomColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void insertPriceRecords()
        {
            string table = "tbl_room_price_record";
            string values = "'" + priceValues[0] + "', " + priceValues[1] + ",'" + priceValues[2] + "'";
            string columns = string.Join(", ", priceColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void insertRARecords()
        {
            string table = "tbl_room_availability_record";
            string values = "'" + rAValues[0] + "', " + rAValues[1] + ", '" + rAValues[2] + "'";
            string columns = string.Join(", ", rAColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        public List<string> getRoomColumns()
        {
            return roomColumns;
        }

        public List<string> getRoomValues()
        {
            return roomValues;
        }

        public List<string> getPriceColumns()
        {
            return priceColumns;
        }

        public List<string> getPriceValues()
        {
            return priceValues;
        }

        public List<string> getRAColumns()
        {
            return rAColumns;
        }

        public List<string> getRAValues()
        {
            return rAValues;
        }

        private void createRoomForm_Load(object sender, EventArgs e)
        {

        }
    }
}
