using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

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
            dockForm(rForm);
        }
        public void rForm_nextButtonClick(object sender, EventArgs e)
        {
            ConnectToSQL.LoadDataGridView(rForm2.getTable(), "SELECT * FROM vw_current_rooms");
            dockForm(rForm2);
            Controls.Remove((Control)sender);
        }

        public void rForm2_nextButtonClick(object sender, EventArgs e)
        {
            dockForm(rForm3);
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
            ConnectToSQL.LoadDataGridView(rPForm.getTable(), "SELECT * FROM tbl_renter");
            dockForm(rPForm);
        }

        // renters history form buttons
        private void rentersHistoryButton_Click(object sender, EventArgs e)
        {
            ConnectToSQL.LoadDataGridView(rHForm.getTable(), "SELECT * FROM vw_renter_history;");
            dockForm(rHForm);
        }

        //rroms form buttons
        private void roomsButton_Click(object sender, EventArgs e)
        {
            ConnectToSQL.LoadDataGridView(roForm.getTable(), "SELECT * FROM tbl_room");
            dockForm(roForm);
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
            dockForm(roForm);
            Controls.Remove((Control)sender);
        }

        // room damage history form buttons
        private void damageHistoryButton_Click(object sender, EventArgs e)
        {
            ConnectToSQL.LoadDataGridView(rDHForm.getTable(), "select * from vw_room_damage_record");
            dockForm(rDHForm);
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
            dockForm(rDForm);
            Controls.Remove((Control)sender);
        }

        //room availability record form buttons
        private void availabilityHistoryButton_Click(object sender, EventArgs e)
        {
            ConnectToSQL.LoadDataGridView(rAHForm.getTable(), "SELECT * FROM vw_room_availability_history");
            dockForm(rAHForm);
        }

        //prices firm buttons
        private void pricesButton_Click(object sender, EventArgs e)
        {
            ConnectToSQL.LoadDataGridView(pForm.getData(), "SELECT * FROM vw_room_price_history");
            dockForm(pForm);
        }

        //dpn form buttons
        private void dpnButton_Click(object sender, EventArgs e)
        {

            ConnectToSQL.LoadDataGridView(gDForm.getTable(), "SELECT * from vw_current_renters");
            dockForm(gDForm);
        }

        //receipt form buttons
        private void receiptButton_Click(object sender, EventArgs e)
        {
            ConnectToSQL.LoadDataGridView(gRForm.getTable(), "SELECT * FROM vw_dpn_total;");
            dockForm(gRForm);
        }

        //payments history button
        private void paymentsHistoryButton_Click(object sender, EventArgs e)
        {
            ConnectToSQL.LoadDataGridView(paHForm.getTable(1), "SELECT * FROM vw_dpn_total;");
            ConnectToSQL.LoadDataGridView(paHForm.getTable(2), "SELECT * FROM vw_receipt_is_fully_paid;");
            dockForm(paHForm);
        }

        private void pricesHistoryButton_Click(object sender, EventArgs e)
        {
            ConnectToSQL.LoadDataGridView(pHForm.getTable(1), "SELECT * FROM tbl_room_price_record;");
            ConnectToSQL.LoadDataGridView(pHForm.getTable(2), "SELECT * FROM vw_bill_rate_history;");
            dockForm(pHForm);

        }
    }
}
