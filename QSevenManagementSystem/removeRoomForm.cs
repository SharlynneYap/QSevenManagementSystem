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
    public partial class removeRoomForm : Form
    {
        roomsForm roForm;
        List<string> rAValues = new List<string>();
        List<string> rAColumns = new List<string>() { "room_id", "rat_id", "ra_date" };
        public removeRoomForm(roomsForm roForm)
        {
            InitializeComponent();
            this.roForm = roForm;
            roomLabel.Text = roForm.getRoomID();
            MessageBox.Show("fbhsfejka");//testing
        }

        private void loadRAValues()
        {
            string roomID = roForm.getRoomID();
            MessageBox.Show(roomID);//for testing
            string ratID = "4";
            string date = removeRoomDate.Value.ToString("yyyy-MM-dd");

            rAValues.Clear();

            rAValues.Add(roomID);
            MessageBox.Show(roomID);
            rAValues.Add(ratID);
            rAValues.Add(date);

            MessageBox.Show(string.Join(", ", rAValues)); //testing
        }

        private void insertRARecord()
        {
            string table = "tbl_room_availability_record";
            string values = "'" + rAValues[0] + "'," + rAValues[1] + ",'" + rAValues[2] + "'";
            string columns = string.Join(", ", rAColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            loadRAValues();
            insertRARecord();
        }
    }
}
