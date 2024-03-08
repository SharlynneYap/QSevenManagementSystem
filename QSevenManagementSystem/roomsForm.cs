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
    public partial class roomsForm : Form
    {
        public roomsForm()
        {
            InitializeComponent();
            ConnectToSQL.initialize();
            ConnectToSQL.LoadDataGridView(roomsData, "SELECT * FROM tbl_room");
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            mainForm mainForm = (mainForm)this.ParentForm;
            mainForm.roomsForm_createButtonClick(this, EventArgs.Empty);
        }
    }
}
