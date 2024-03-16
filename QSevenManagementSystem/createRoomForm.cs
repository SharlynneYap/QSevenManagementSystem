using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QSevenManagementSystem
{
    public partial class createRoomForm : Form
    {
        List<string> roomValues;
        List<string> roomColumns;

        List<string> priceValues;
        List<string> priceColumns;

        List<string> rAValues;
        List<string> rAColumns;

        public createRoomForm()
        {
            InitializeComponent();
            roomValues = new List<string>();
            roomColumns = new List<string> { "room_id", "room_floor", "room_max_renters" };

            priceValues = new List<string>();
            priceColumns = new List<string> { "room_id", "rp_price", "rp_date" };

            rAValues = new List<string>();
            rAColumns = new List<string> { "room_id", "rat_id", "ra_date" };
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                mainForm mainForm = (mainForm)this.ParentForm;
                mainForm.createRoomForm_submitButtonClick(this, EventArgs.Empty);

                loadRoomValues();
                loadPriceValues();
                loadRAValues();

                insertRoomRecords();
                insertPriceRecords();
                insertRARecords();
            }

        }

        private void loadRoomValues()
        {
            string roomId = roomIdTBox.Text;
            string floor = floorTBox.Text;
            string maxRenters = maxTBox.Text;

            roomValues.Clear();

            roomValues.Add(roomId);
            roomValues.Add(floor);
            roomValues.Add(maxRenters);

            MessageBox.Show(string.Join(", ", roomValues)); // Testing
        }

        private void loadPriceValues()
        {
            string roomID = roomIdTBox.Text;
            string price = priceTBox.Text;
            string date = raDate.Value.ToShortDateString();
            date = raDate.Value.ToString("yyyy-MM-dd");

            priceValues.Clear();

            priceValues.Add(roomID);
            priceValues.Add(price);
            priceValues.Add(date);

            MessageBox.Show(string.Join(", ", priceValues)); // Testing
        }

        private void loadRAValues()
        {
            string roomID = roomIdTBox.Text;
            string ratID = "1";
            string date = raDate.Value.ToShortDateString();
            date = raDate.Value.ToString("yyyy-MM-dd");

            rAValues.Clear();

            rAValues.Add(roomID);
            rAValues.Add(ratID);
            rAValues.Add(date);
        }

        private void insertRoomRecords()
        {
            string table = "tbl_room";
            string values = "'" + roomValues[0] + "', " + roomValues[1] + ", " + roomValues[2];
            string columns = string.Join(", ", roomColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void insertPriceRecords()
        {
            string table = "tbl_room_price_record";
            string values = "'" + priceValues[0] + "', " + priceValues[1] + ",'" + priceValues[2] + "'";
            string columns = string.Join(", ", priceColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        private void insertRARecords()
        {
            string table = "tbl_room_availability_record";
            string values = "'" + rAValues[0] + "', " + rAValues[1] + ", '" + rAValues[2] + "'";
            string columns = string.Join(", ", rAColumns);

            MessageBox.Show(table + "!!!" + columns + " !!!" + values);//testing
            ConnectToSQL.insertRecord(table, columns, values);
        }

        public List<string> getRoomColumns()
        {
            return roomColumns;
        }

        public List<string> getRoomValues()
        {
            return roomValues;
        }

        public List<string> getPriceColumns()
        {
            return priceColumns;
        }

        public List<string> getPriceValues()
        {
            return priceValues;
        }

        public List<string> getRAColumns()
        {
            return rAColumns;
        }

        public List<string> getRAValues()
        {
            return rAValues;
        }

        private void createRoomForm_Load(object sender, EventArgs e)
        {

        }

        private bool validate()
        {
            int roomNumOfRecords = int.Parse(ConnectToSQL.readTableString($"SELECT COUNT(*) FROM vw_room_availability_history WHERE `Room ID` = '{roomIdTBox.Text}'; "));
            if (roomNumOfRecords > 0)
            {
                MessageBox.Show("Error: Room ID has been used. Please try again.");
            }

            else if (string.IsNullOrEmpty(priceTBox.Text))
            {
                MessageBox.Show("Input missing in room price field!");
            }
            else if (priceTBox.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Letters are not allowed in room price field!");
            }
            else if (priceTBox.Text.Any(c => !char.IsDigit(c) && c != '.' && c != '-'))
            {
                MessageBox.Show("Special characters are not allowed in room price field!");
            }
            else if (priceTBox.Text.Any(char.IsDigit))
            {
                try
                {
                    double rate = double.Parse(priceTBox.Text);

                    if (priceTBox.Text.Contains("."))
                    {
                        // Get the index of the decimal separator
                        int decimalIndex = priceTBox.Text.IndexOf(".");

                        // Check if there are more than two digits after the decimal separator
                        if (priceTBox.Text.Length - decimalIndex - 1 > 2)
                        {
                            MessageBox.Show("Please enter a rate with at most two decimal places in room price field.");
                        }
                        else if (rate < 0)
                        {
                            MessageBox.Show("Number should be positive in room price field!");
                        }

                    }
                    else if (rate < 0)
                    {
                        MessageBox.Show("Number should be positive in room price field!");
                    }

                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid input. Please enter a valid number in total field.");
                }
            }

            if (string.IsNullOrEmpty(floorTBox.Text))
            {
                MessageBox.Show("Floors field  is empty!");
            }
            else if (floorTBox.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Floors field cannot contain letters!");
            }
            else if (floorTBox.Text.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("Floors field cannot contain special characters!");
            }
            else if (string.IsNullOrEmpty(maxTBox.Text))
            {
                MessageBox.Show("Max field is empty!");
            }
            else if (maxTBox.Text.Any(char.IsLetter))
            {
                MessageBox.Show("Max renters field cannot contain letters!");
            }
            else if (maxTBox.Text.Any(c => !char.IsLetterOrDigit(c)))
            {
                MessageBox.Show("Max renters field cannot contain special characters!");
            }
            else if (int.Parse(maxTBox.Text) > 10)
            {
                MessageBox.Show("Max renters exceeded!");
            }
            else
            {
                return true;
            }

            return false;
        }
    }
}
