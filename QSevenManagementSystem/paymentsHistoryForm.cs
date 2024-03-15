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
        }

        public DataGridView getTable(int num)
        {
            if (num == 1)
            {
                return dpnData;
            }
            else if (num == 2)
            {
                return receiptData;
            }
            else if (num == 3)
            {
                return billData;
            }
            else
            {
                return otherChargesData;
            }
        }
    }
}

