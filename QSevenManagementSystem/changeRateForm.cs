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
    public partial class changeRateForm : Form
    {
        private int type;
        private pricesForm parentForm;
        public changeRateForm(pricesForm parent, int type)
        {
            parentForm = parent;
            this.type = type;
            InitializeComponent();
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (type == 1) //Electric Bill
            {
                //idk how to update the bills so hehe
            }
            else if (type == 2) //Water Bill
            {
                //idk how to update the bills so hehe
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
