using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            ConnectToSQL.initialize();

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

        private void reloadAllForms()
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
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            dockForm(rForm);
        }

        private void rentersProfileButton_Click(object sender, EventArgs e)
        {
            dockForm(rPForm);
        }

        private void rentersHistoryButton_Click(object sender, EventArgs e)
        {
            dockForm(rHForm);
        }

        private void roomsButton_Click(object sender, EventArgs e)
        {
            dockForm(roForm);
        }

        private void damageHistoryButton_Click(object sender, EventArgs e)
        {
            dockForm(rDHForm);
        }

        private void availabilityHistoryButton_Click(object sender, EventArgs e)
        {
            dockForm(rAHForm);
        }

        private void pricesButton_Click(object sender, EventArgs e)
        {
            dockForm(pForm);
        }

        private void dpnButton_Click(object sender, EventArgs e)
        {
            dockForm(gDForm);
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            dockForm(gRForm);
        }

        private void paymentsHistoryButton_Click(object sender, EventArgs e)
        {
            dockForm(paHForm);
        }

        private void pricesHistoryButton_Click(object sender, EventArgs e)
        {
            dockForm(pHForm);

        }
        public void Form1_nextButtonClick(object sender, EventArgs e)
        {
            dockForm(rForm2);
            Controls.Remove((Control)sender);
        }

        public void Form2_nextButtonClick(object sender, EventArgs e)
        {
            dockForm(rForm3);
            Controls.Remove((Control)sender);
        }

        public void Form2_prevButtonClick(object sender, EventArgs e)
        {
            dockForm(rForm);
            Controls.Remove((Control)sender);
        }

        public void Form3_nextButtonClick(object sender, EventArgs e)
        {
            Controls.Remove((Control)sender);
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

        public void rDHForm_reportButtonClick(object sender, EventArgs e)
        {
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
    }
}
