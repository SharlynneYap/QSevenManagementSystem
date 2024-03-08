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
    public partial class pricesHistoryForm : Form
    {
        public pricesHistoryForm()
        {
            InitializeComponent();
            ConnectToSQL.initialize();
            ConnectToSQL.LoadDataGridView(pricesData, "SELECT * FROM tbl_room_price_record;");
            ConnectToSQL.LoadDataGridView(rateData, "SELECT * FROM vw_bill_rate_history;");
        }
    }
}
