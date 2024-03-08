using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic;
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
    public partial class registrationForm2 : Form
    {
        registrationForm rForm = new registrationForm();
        private List<string> renterValues;
        private List<string> renterColumns;
        List<string> moveinValues = new List<string>();
        List<string> moveinColumns = new List<string> { "movein_total_deposit_paid", "movein_date" };
        List<string> registrationValues = new List<string>();
        List<string> registrationColumns = new List<string> { "renter_id", "room_id", "movein_id", "registration_date" };
        List<string> rAValues = new List<string>();
        List<string> rAValues2 = new List<string>();
        List<string> rAColumns = new List<string> { "room_id", "rat_id", "ra_date" };
        public registrationForm2()
        {
            InitializeComponent();
            ConnectToSQL.initialize();
            ConnectToSQL.LoadDataGridView(selectRoomData, "SELECT * FROM tbl_room");
        }

        public registrationForm2(List<string> renterValues, List<string> renterColumns)
        {
            InitializeComponent();
            ConnectToSQL.initialize();
            this.renterValues = renterValues ?? new List<string>();
            this.renterColumns = renterColumns ?? new List<string>();
            ConnectToSQL.LoadDataGridView(selectRoomData, "SELECT * FROM tbl_room");
        }
        private void nextButton_Click(object sender, EventArgs e)
        {

            mainForm mainForm = (mainForm)this.ParentForm;
            mainForm.Form2_nextButtonClick(this, EventArgs.Empty);

            insertRentersRecords();
            loadMoveinValues();
            insertMoveinRecords();
            loadRegistrationValues();
            insertRegistrationRecords();
            loadRAValues();
            insertRARecords();
            loadRAValues2();
            insertRARecords2();

        }
        private void insertRentersRecords()
        {
            string table = "tbl_renter";
            string values = "";
            string columns;
            for (int i = 0; i < renterValues.Count; i++)
            {
                values += "'" + renterValues[i] + "'";
                if (i != renterValues.Count - 1)
                {
                    values += ",";
                }
            }

            columns = string.Join(", ", renterColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);

        }

        private void insertMoveinRecords()
        {
            string table = "tbl_movein";
            string values = moveinValues[0] + ", '" + moveinValues[1] + "'";
            string columns = string.Join(", ", moveinColumns);


            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);

        }

        private void insertRegistrationRecords()
        {
            string table = "tbl_registration";
            string values = registrationValues[0] + ",'" + registrationValues[1] + "'," + registrationValues[2] + ",'" + registrationValues[3] + "'";
            string columns = string.Join(", ", registrationColumns);


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

        private void insertRARecords2()
        {
            string table = "tbl_room_availability_record";
            string values = "'" + rAValues2[0] + "', " + rAValues2[1] + ", '" + rAValues2[2] + "'";
            string columns = string.Join(", ", rAColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }


        private void loadRegistrationValues()
        {
            string renterID = ConnectToSQL.readTableString("SELECT MAX(renter_id) FROM tbl_renter;");
            string roomID = roomTBox.Text;
            string moveinID = ConnectToSQL.readTableString("SELECT MAX(movein_id) FROM tbl_movein;");
            string rDate = registrationDate.Value.ToShortDateString();
            rDate = registrationDate.Value.ToString("yyyy-MM-dd");
            registrationValues.Add(renterID);
            registrationValues.Add(roomID);
            registrationValues.Add(moveinID);
            registrationValues.Add(rDate);
        }

        private void loadMoveinValues()
        {
            string depositAmount = depositTBox.Text;
            string mDate = moveInDate.Value.ToShortDateString();
            mDate = moveInDate.Value.ToString("yyyy-MM-dd");

            moveinValues.Add(depositAmount);
            moveinValues.Add(mDate);

        }

        private void loadRAValues()
        {
            string roomID = roomTBox.Text;
            string ratID = "2";
            string raDate = registrationDate.Value.ToShortDateString();
            raDate = registrationDate.Value.ToString("yyyy-MM-dd");

            rAValues.Add(roomID);
            rAValues.Add(ratID);
            rAValues.Add(raDate);

        }

        private void loadRAValues2()
        {
            string roomID = roomTBox.Text;
            string ratID = "3";
            string mDate = moveInDate.Value.ToShortDateString();
            mDate = moveInDate.Value.ToString("yyyy-MM-dd");

            rAValues2.Add(roomID);
            rAValues2.Add(ratID);
            rAValues2.Add(mDate);

        }
        private void prevButton_Click(object sender, EventArgs e)
        {
            mainForm mainForm = (mainForm)this.ParentForm;
            mainForm.Form2_prevButtonClick(this, EventArgs.Empty);
        }
    }
}
