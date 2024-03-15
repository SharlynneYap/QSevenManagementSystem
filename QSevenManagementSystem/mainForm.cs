namespace QSevenManagementSystem
{
    public partial class mainForm : Form
    {
        registrationForm rForm = new registrationForm();
        rentersProfileForm rPForm = new rentersProfileForm();
        rentersHistoryForm rHForm = new rentersHistoryForm();
        roomsForm roForm = new roomsForm();
        roomDamagesHistoryForm rDHForm = new roomDamagesHistoryForm();
        roomAvailabilityHistoryForm rAHForm = new roomAvailabilityHistoryForm();
        pricesForm pForm = new pricesForm();
        paymentsHistoryForm paHForm = new paymentsHistoryForm();
        pricesHistoryForm pHForm = new pricesHistoryForm();
        registrationForm2 rForm2;
        registrationForm3 rForm3 = new registrationForm3();
        createRoomForm cRForm = new createRoomForm();
        createRoomForm2 cRForm2 = new createRoomForm2();
        reportDamageForm rDForm = new reportDamageForm();
        reportDamageForm2 rDForm2 = new reportDamageForm2();
        generateDPN gDForm = new generateDPN();
        calculateElec cEForm = new calculateElec();
        calculateWater cWForm = new calculateWater();
        generateReceipt gRForm = new generateReceipt();

        public mainForm()
        {
            InitializeComponent();
            loadMainFormPanels();
            rForm2 = new registrationForm2(rForm.getRenterValues(), rForm.getRenterColumns());
        }
        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        public void closeAllForms()
        {
            rForm.Visible = false;
            rPForm.Visible = false;
            rHForm.Visible = false;
            roForm.Visible = false;
            rDHForm.Visible = false;
            rAHForm.Visible = false;
            pForm.Visible = false;
            paHForm.Visible = false;
            pHForm.Visible = false;
            cRForm.Visible = false;
            cRForm2.Visible = false;
            rDForm.Visible = false;
            rDForm2.Visible = false;
            gDForm.Visible = false;
            cEForm.Visible = false;
            cWForm.Visible = false;
            gRForm.Visible = false;

            //panels from mainForm
            this.roomsPanel.Visible = false;
            this.occupiedPanel.Visible = false;
            this.unoccupiedPanel.Visible = false;
            this.reservedPanel.Visible = false;
            this.rentersPanel.Visible = false;
        }

        private void loadMainFormPanels()
        {
            this.roomsPanel.Visible = true;
            this.occupiedPanel.Visible = true;
            this.unoccupiedPanel.Visible = true;
            this.reservedPanel.Visible = true;
            this.rentersPanel.Visible = true;


            this.roomsLabel.Text = ConnectToSQL.readTableString("SELECT COUNT(*) FROM vw_current_rooms;");
            this.occupiedLabel.Text = ConnectToSQL.readTableString("SELECT COUNT(*) FROM vw_current_rooms WHERE Availability = 'Occupied';");
            this.unoccupiedLabel.Text = ConnectToSQL.readTableString("SELECT COUNT(*) FROM vw_current_rooms WHERE Availability = 'Unoccupied';");
            this.reservedLabel.Text = ConnectToSQL.readTableString("SELECT COUNT(*) FROM vw_current_rooms WHERE Availability = 'Reserved';");
            this.rentersLabel.Text = ConnectToSQL.readTableString("SELECT COUNT(*) FROM vw_renters_profile;");
            
        }

        private void dockForm(Form form)
        {
            closeAllForms();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.Location = new Point(this.Width - form.Width, 0);
            form.Show();
            this.Controls.Add(form);
        }

        // registration forms buttons
        private void registrationButton_Click(object sender, EventArgs e)
        {
            if (rForm.Visible == true)
            {
                rForm.Visible = false;
                loadMainFormPanels();
            }
            else
            {
                dockForm(rForm);
            }
        }
        public void rForm_nextButtonClick(object sender, EventArgs e)
        {
            ConnectToSQL.LoadDataGridView(rForm2.getTable(), "SELECT * FROM vw_current_rooms_tenants");
            dockForm(rForm2);
            Controls.Remove((Control)sender);
        }

        public void rForm2_nextButtonClick(object sender, EventArgs e)
        {
            dockForm(rForm3);
            rForm.clearForm();
            Controls.Remove((Control)sender);

        }

        public void rForm2_prevButtonClick(object sender, EventArgs e)
        {
            dockForm(rForm);
            Controls.Remove((Control)sender);
        }

        public void rForm3_nextButtonClick(object sender, EventArgs e)
        {
            dockForm(rForm);
            Controls.Remove((Control)sender);
        }

        // renters profile form buttons
        public void rentersProfileButton_Click(object sender, EventArgs e)
        {
            if (rPForm.Visible == true)
            {
                rPForm.Visible = false;
                loadMainFormPanels();
            }
            else
            {
                ConnectToSQL.LoadDataGridView(rPForm.getTable(), "SELECT * FROM vw_renters_profile");
                dockForm(rPForm);
            }

        }

        // renters history form buttons
        private void rentersHistoryButton_Click(object sender, EventArgs e)
        {
            if (rHForm.Visible == true)
            {
                rHForm.Visible = false;
                loadMainFormPanels();
            }
            else
            {
                ConnectToSQL.LoadDataGridView(rHForm.getTable(1), "SELECT * FROM vw_movein_history;");
                ConnectToSQL.LoadDataGridView(rHForm.getTable(2), "SELECT * FROM vw_moveout_history;");
                dockForm(rHForm);
            }
        }

        //rooms form buttons
        private void roomsButton_Click(object sender, EventArgs e)
        {
            if (roForm.Visible == true)
            {
                roForm.Visible = false;
                loadMainFormPanels();
            }
            else
            {
                ConnectToSQL.LoadDataGridView(roForm.getTable(), "SELECT * FROM vw_current_rooms");
                dockForm(roForm);
            }
        }
        public void roomsForm_createButtonClick(object sender, EventArgs e)
        {
            dockForm(cRForm);
            Controls.Remove((Control)sender);

        }

        public void createRoomForm_submitButtonClick(object sender, EventArgs e)
        {
            dockForm(cRForm2);
            Controls.Remove((Control)sender);
        }

        public void createRoomForm2_okButtonClick(object sender, EventArgs e)
        {
            ConnectToSQL.LoadDataGridView(roForm.getTable(), "SELECT * FROM vw_current_rooms");
            dockForm(roForm);
            Controls.Remove((Control)sender);
        }

        // room damage history form buttons
        private void damageHistoryButton_Click(object sender, EventArgs e)
        {
            if (rDHForm.Visible == true)
            {
                rDHForm.Visible = false;
                loadMainFormPanels();
            }
            else
            {
                ConnectToSQL.LoadDataGridView(rDHForm.getTable(), "select * from vw_room_damage_record");
                dockForm(rDHForm);
            }
        }

        public void rDHForm_reportButtonClick(object sender, EventArgs e)
        {
            ConnectToSQL.LoadDataGridView(rDForm.getTable(), "select * from vw_current_tenants");
            dockForm(rDForm);
            Controls.Remove((Control)sender);
        }

        public void rDForm_confirmButtonClick(object sender, EventArgs e)
        {
            dockForm(rDForm2);
            Controls.Remove((Control)sender);
        }

        public void rDForm2_okButtonClick(object sender, EventArgs e)
        {
            ConnectToSQL.LoadDataGridView(rDHForm.getTable(), "select * from vw_room_damage_record");
            dockForm(rDHForm);
            Controls.Remove((Control)sender);
        }

        //room availability record form buttons
        private void availabilityHistoryButton_Click(object sender, EventArgs e)
        {
            if (rAHForm.Visible == true)
            {
                rAHForm.Visible = false;
                loadMainFormPanels();
            }
            else
            {
                ConnectToSQL.LoadDataGridView(rAHForm.getTable(), "SELECT * FROM vw_room_availability_history");
                dockForm(rAHForm);
            }
        }

        //prices firm buttons
        private void pricesButton_Click(object sender, EventArgs e)
        {
            if (pForm.Visible == true)
            {
                pForm.Visible = false;
                loadMainFormPanels();
            }
            else
            {
                ConnectToSQL.LoadDataGridView(pForm.getTable(), "SELECT * FROM vw_rooms_current_prices");
                dockForm(pForm);
            }
        }

        //dpn form buttons
        private void dpnButton_Click(object sender, EventArgs e)
        {
            if (gDForm.Visible == true)
            {
                gDForm.Visible = false;
                loadMainFormPanels();
            }
            else
            {
                ConnectToSQL.LoadDataGridView(gDForm.getTable(), "SELECT * from vw_current_renters");
                dockForm(gDForm);
            }
        }

        //receipt form buttons
        private void receiptButton_Click(object sender, EventArgs e)
        {
            if (gRForm.Visible == true)
            {
                gRForm.Visible = false;
                loadMainFormPanels();
            }
            else
            {
                ConnectToSQL.LoadDataGridView(gRForm.getTable(), "SELECT * FROM vw_dpn_total;");
                dockForm(gRForm);
            }
        }

        //payments history button
        private void paymentsHistoryButton_Click(object sender, EventArgs e)
        {
            if (paHForm.Visible == true)
            {
                paHForm.Visible = false;
                loadMainFormPanels();
            }
            else
            {
                ConnectToSQL.LoadDataGridView(paHForm.getTable(1), "SELECT * FROM vw_dpn_total;");
                ConnectToSQL.LoadDataGridView(paHForm.getTable(2), "SELECT * FROM vw_receipt_is_fully_paid;");
                ConnectToSQL.LoadDataGridView(paHForm.getTable(3), "SELECT * FROM vw_bills_history;");
                ConnectToSQL.LoadDataGridView(paHForm.getTable(4), "SELECT * FROM vw_other_charges_history;");
                dockForm(paHForm);
            }
        }

        //price history button
        private void pricesHistoryButton_Click(object sender, EventArgs e)
        {
            if (pHForm.Visible == true)
            {
                pHForm.Visible = false;
                loadMainFormPanels();
            }
            else
            {
                ConnectToSQL.LoadDataGridView(pHForm.getTable(1), "SELECT * FROM vw_room_price_history;");
                ConnectToSQL.LoadDataGridView(pHForm.getTable(2), "SELECT * FROM vw_bill_rate_history;");
                dockForm(pHForm);
            }
        }
    }
}
