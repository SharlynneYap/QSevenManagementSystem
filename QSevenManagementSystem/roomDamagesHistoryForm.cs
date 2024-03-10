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
            
            InitializeComponent();
            
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            mainForm mainForm = (mainForm)this.ParentForm;
            mainForm.rDHForm_reportButtonClick(this, EventArgs.Empty);
        }

        public DataGridView getTable()
        {
            return rDHData;
        }
    }
}
