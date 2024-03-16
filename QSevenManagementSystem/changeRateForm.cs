using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
        private List<string> billRateValues;
        private List<string> billRateValues2;
        private List<string> billRateColumns;

        public changeRateForm(pricesForm parent, int type)
        {
            parentForm = parent;
            this.type = type;
            InitializeComponent();
            billRateValues = new List<string>();
            billRateValues2 = new List<string>();
            billRateColumns = new List<string> { "BT_ID", "BR_price", "BR_date" };
            billDate.MinDate = DateTime.Now.Date;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            bool valid = false;
            if (string.IsNullOrEmpty(txtRate.Text))
            {
                MessageBox.Show("Input missing!");
            }
            else if (txtRate.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Letters are not allowed!");
            }
            else if (txtRate.Text.Any(c => !char.IsDigit(c) && c != '.' && c != '-'))
            {
                MessageBox.Show("Special characters are not allowed!");
            }
            else
            {
                try
                {
                    double rate = double.Parse(txtRate.Text);

                    if (txtRate.Text.Contains("."))
                    {
                        // Get the index of the decimal separator
                        int decimalIndex = txtRate.Text.IndexOf(".");

                        // Check if there are more than two digits after the decimal separator
                        if (txtRate.Text.Length - decimalIndex - 1 > 2)
                        {
                            MessageBox.Show("Please enter a rate with at most two decimal places.");
                        }
                        else if (rate < 0)
                        {
                            MessageBox.Show("Number should be positive!");
                        }
                        else
                        {
                            valid = true;
                        }
                    }
                    else if (rate < 0)
                    {
                        MessageBox.Show("Number should be positive!");
                    }
                    else
                    {
                        valid = true;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid input. Please enter a valid number.");
                }
            }
            if (valid)
            {
                MessageBox.Show("Changes made!");
                loadBillRateValues();
                insertBillRateRecord();
                parentForm.reloadBillRts();
                this.Close();
            }

        }

        private void loadBillRateValues()
        {
            string btId = type.ToString();
            string price = txtRate.Text;
            string date = billDate.Value.ToString("yyyy-MM-dd");

            billRateValues.Clear();

            billRateValues.Add(btId);
            billRateValues.Add(price);
            billRateValues.Add(date);

            MessageBox.Show(string.Join(", ", billRateValues)); // Testing
        }

        private void insertBillRateRecord()
        {
            string table = "tbl_bill_rate_record";
            string values = billRateValues[0] + ", " + billRateValues[1] + ", '" + billRateValues[2] + "'";
            string columns = string.Join(", ", billRateColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}