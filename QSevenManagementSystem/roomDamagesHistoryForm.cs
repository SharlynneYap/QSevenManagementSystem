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
    public partial class roomDamagesHistoryForm : Form
    {
        public roomDamagesHistoryForm()
        {
            ConnectToSQL.initialize();
            InitializeComponent();
            ConnectToSQL.LoadDataGridView(rDHData, "select * from vw_room_damage_record");
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            mainForm mainForm = (mainForm)this.ParentForm;
            mainForm.rDHForm_reportButtonClick(this, EventArgs.Empty);
        }
    }
}
