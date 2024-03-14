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

namespace QSevenManagementSystem
{
    public partial class moveOutForm : Form
    {
        rentersProfileForm rPForm;
        List<string> moveOutValues = new List<string>();
        List<string> moveOutColumns = new List<string>() { "renter_id", "moveout_date" };
        List<string> rAValues = new List<string>();
        List<string> rAColumns = new List<string> { "room_id", "rat_id", "ra_date" };

        public moveOutForm(rentersProfileForm rPForm)
        {
            InitializeComponent();
            renterLabel.Text = rPForm.getRenterID();
            this.rPForm = rPForm;
        }

        private void loadMoveOutValues()
        {
            string renterID = rPForm.getRenterID();
            MessageBox.Show(renterID);//for testing
            string date = moveOutDate.Value.ToString("yyyy-MM-dd");

            moveOutValues.Clear();

            moveOutValues.Add(renterID);
            moveOutValues.Add(date);

            MessageBox.Show(string.Join(", ", moveOutValues)); //testing
        }

        private void insertMoveOutRecord()
        {
            string table = "tbl_moveout";
            string values = moveOutValues[0] + ", '" + moveOutValues[1] + "'";
            string columns = string.Join(", ", moveOutColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string registrationID = ConnectToSQL.readTableString($"SELECT Registration_ID\r\nFROM tbl_Registration\r\nWHERE Renter_ID = {rPForm.getRenterID()};\r\n");
            string recordCountStr = ConnectToSQL.readTableString($"SELECT COUNT(*) AS RecordCount FROM vw_renters_profile WHERE `Registration ID` = {registrationID};");
            int recordCount = int.Parse(recordCountStr);

            MessageBox.Show("renters in the same room: " + recordCountStr);//for testing

            loadMoveOutValues();
            insertMoveOutRecord();

            if (recordCount == 1)
            {
                loadRAValues();
                insertRARecords();

            }

            ConnectToSQL.LoadDataGridView(rPForm.getTable(), "SELECT * FROM vw_renters_profile");
            this.Close();
        }

        private void loadRAValues()
        {
            string roomID = ConnectToSQL.readTableString($"SELECT\r\n    reg.Room_ID\r\nFROM\r\n    tbl_Registration reg\r\nINNER JOIN\r\n    tbl_MoveOut mo ON reg.Renter_ID = mo.Renter_ID\r\nWHERE\r\n    mo.Renter_ID = {rPForm.getRenterID()};\r\n");
            string ratID = "1";
            string raDate = moveOutDate.Value.ToString("yyyy-MM-dd");

            rAValues.Clear();

            rAValues.Add(roomID);
            rAValues.Add(ratID);
            rAValues.Add(raDate);

        }

        private void insertRARecords()
        {
            string table = "tbl_room_availability_record";
            string values = "'" + rAValues[0] + "', " + rAValues[1] + ", '" + rAValues[2] + "'";
            string columns = string.Join(", ", rAColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

    }
}
