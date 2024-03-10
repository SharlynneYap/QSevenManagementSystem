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
    public partial class reportDamageForm : Form
    {
        List<string> rDValues;
        List<string> rDColumns;

        public reportDamageForm()
        {
            InitializeComponent();
            rDValues = new List<string>();
            rDColumns = new List<string>() { "room_id", "rdt_id", "rd_description", "rd_total_damages", "rd_date" };
            string[,] damageType = ConnectToSQL.readTableArray("Select * from tbl_room_damage_type");
            damageCBox.Items.Add(damageType[0, 1]);
            damageCBox.Items.Add(damageType[1, 1]);
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            mainForm mainForm = (mainForm)this.ParentForm;
            mainForm.rDForm_confirmButtonClick(this, EventArgs.Empty);

            loadRDValues();
            insertRDRecords();
        }

        private void loadRDValues()
        {
            string roomId = roomIdTBox.Text;
            string damageType = (damageCBox.Text == "Maintenance") ? "1" : "2";
            string desc = descTBox.Text;
            string total = totalTBox.Text;
            string date = rdDate.Value.ToShortDateString();
            date = rdDate.Value.ToString("yyyy-MM-dd");


            rDValues.Clear();

            rDValues.Add(roomId);
            rDValues.Add(damageType);
            rDValues.Add(desc);
            rDValues.Add(total);
            rDValues.Add(date);

            MessageBox.Show(string.Join(", ", rDValues)); // Testing
        }

        private void insertRDRecords()
        {
            string table = "tbl_room_damage_record";
            string values = "'" + rDValues[0] + "', '" + rDValues[1] + "', '" + rDValues[2] + "', " + rDValues[3] + ", '" + rDValues[4] + "'";
            string columns = string.Join(", ", rDColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        public DataGridView getTable()
        {
            return roomsData;
        }
    }
}
