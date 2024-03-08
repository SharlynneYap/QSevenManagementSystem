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
    public partial class paymentsHistoryForm : Form
    {
        public paymentsHistoryForm()
        {
            InitializeComponent();
            ConnectToSQL.initialize();
            ConnectToSQL.LoadDataGridView(dpnData, "SELECT * FROM vw_dpn_total;");
            ConnectToSQL.LoadDataGridView(receiptData, "SELECT * FROM vw_receipt_is_fully_paid;");
        }
    }
}

