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
    public partial class createRoomForm2 : Form
    {
        public createRoomForm2()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            mainForm mainForm = (mainForm)this.ParentForm;
            mainForm.createRoomForm2_okButtonClick(this, EventArgs.Empty);
        }
    }
}
