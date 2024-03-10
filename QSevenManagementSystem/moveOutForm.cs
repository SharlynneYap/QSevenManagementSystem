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
        List<string> moveOutColumns = new List<string>() { "registration_id", "moveout_date" };
        public moveOutForm(rentersProfileForm rPForm)
        {
            InitializeComponent();
            this.rPForm = rPForm;
        }

        private void loadMoveOutValues()
        {
            string registrationID = rPForm.getRegistrationID();
            MessageBox.Show(registrationID);//for testing
            string date = moveOutDate.Value.ToString("yyyy-MM-dd");

            moveOutValues.Clear();
            moveOutValues.Add(registrationID);
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
            loadMoveOutValues();
            insertMoveOutRecord();
        }
    }
}
