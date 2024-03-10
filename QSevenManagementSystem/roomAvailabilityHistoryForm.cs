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
    public partial class roomAvailabilityHistoryForm : Form
    {
        public roomAvailabilityHistoryForm()
        {
            InitializeComponent();

        }

        public DataGridView getTable()
        {
            return rAData;
        }
    }
}
