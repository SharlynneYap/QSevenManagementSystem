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
    public partial class rentersHistoryForm : Form
    {
        public rentersHistoryForm()
        {
            InitializeComponent();
            ConnectToSQL.initialize();
            ConnectToSQL.LoadDataGridView(rentersData, "SELECT * FROM vw_renter_history;");
        }
    }
}
