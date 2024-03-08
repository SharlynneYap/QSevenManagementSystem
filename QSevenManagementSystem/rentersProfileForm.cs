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
    public partial class rentersProfileForm : Form
    {
        public rentersProfileForm()
        {
            InitializeComponent();
            ConnectToSQL.initialize();
            ConnectToSQL.LoadDataGridView(rentersData, "SELECT * FROM tbl_renter;");
        }
    }
}
