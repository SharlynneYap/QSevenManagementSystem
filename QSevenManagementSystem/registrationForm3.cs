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
    public partial class registrationForm3 : Form
    {
        public registrationForm3()
        {
            InitializeComponent();
            ConnectToSQL.initialize();
            registrationLabel.Text = ConnectToSQL.readTableString("SELECT registration_id FROM tbl_registration WHERE renter_id = (SELECT MAX(renter_id) FROM tbl_registration);");
            renterLabel.Text = ConnectToSQL.readTableString("SELECT MAX(renter_id) FROM tbl_registration;");
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            mainForm mainForm = (mainForm)this.ParentForm;
            mainForm.Form2_prevButtonClick(this, EventArgs.Empty);
        }
    }
}
