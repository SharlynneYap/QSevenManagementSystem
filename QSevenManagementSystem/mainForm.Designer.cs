namespace QSevenManagementSystem
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            sideMenuPanel = new Panel();
            pricesHistoryButton = new Button();
            panel4 = new Panel();
            paymentsHistoryButton = new Button();
            receiptButton = new Button();
            dpnButton = new Button();
            pricesButton = new Button();
            paymentsButton = new Button();
            panel3 = new Panel();
            availabilityHistoryButton = new Button();
            damageHistoryButton = new Button();
            roomsButton = new Button();
            roomButton = new Button();
            panel2 = new Panel();
            rentersHistoryButton = new Button();
            rentersProfileButton = new Button();
            registrationButton = new Button();
            rentersButton = new Button();
            panel1 = new Panel();
            sideMenuPanel.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // sideMenuPanel
            // 
            sideMenuPanel.BackColor = Color.MidnightBlue;
            sideMenuPanel.Controls.Add(pricesHistoryButton);
            sideMenuPanel.Controls.Add(panel4);
            sideMenuPanel.Controls.Add(paymentsButton);
            sideMenuPanel.Controls.Add(panel3);
            sideMenuPanel.Controls.Add(roomButton);
            sideMenuPanel.Controls.Add(panel2);
            sideMenuPanel.Controls.Add(rentersButton);
            sideMenuPanel.Controls.Add(panel1);
            sideMenuPanel.Dock = DockStyle.Left;
            sideMenuPanel.Location = new Point(0, 0);
            sideMenuPanel.Name = "sideMenuPanel";
            sideMenuPanel.Size = new Size(250, 753);
            sideMenuPanel.TabIndex = 0;
            // 
            // pricesHistoryButton
            // 
            pricesHistoryButton.BackColor = Color.DarkBlue;
            pricesHistoryButton.Dock = DockStyle.Top;
            pricesHistoryButton.FlatAppearance.BorderSize = 0;
            pricesHistoryButton.FlatStyle = FlatStyle.Flat;
            pricesHistoryButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pricesHistoryButton.ForeColor = SystemColors.ControlLight;
            pricesHistoryButton.Location = new Point(0, 599);
            pricesHistoryButton.Name = "pricesHistoryButton";
            pricesHistoryButton.Padding = new Padding(30, 0, 0, 0);
            pricesHistoryButton.Size = new Size(250, 35);
            pricesHistoryButton.TabIndex = 8;
            pricesHistoryButton.Text = "Prices History";
            pricesHistoryButton.TextAlign = ContentAlignment.MiddleLeft;
            pricesHistoryButton.UseVisualStyleBackColor = false;
            pricesHistoryButton.Click += pricesHistoryButton_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(paymentsHistoryButton);
            panel4.Controls.Add(receiptButton);
            panel4.Controls.Add(dpnButton);
            panel4.Controls.Add(pricesButton);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 457);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 142);
            panel4.TabIndex = 7;
            // 
            // paymentsHistoryButton
            // 
            paymentsHistoryButton.BackColor = Color.DarkBlue;
            paymentsHistoryButton.Dock = DockStyle.Top;
            paymentsHistoryButton.FlatAppearance.BorderSize = 0;
            paymentsHistoryButton.FlatStyle = FlatStyle.Flat;
            paymentsHistoryButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            paymentsHistoryButton.ForeColor = SystemColors.ControlLight;
            paymentsHistoryButton.Location = new Point(0, 105);
            paymentsHistoryButton.Name = "paymentsHistoryButton";
            paymentsHistoryButton.Padding = new Padding(30, 0, 0, 0);
            paymentsHistoryButton.Size = new Size(250, 35);
            paymentsHistoryButton.TabIndex = 4;
            paymentsHistoryButton.Text = "Payments History";
            paymentsHistoryButton.TextAlign = ContentAlignment.MiddleLeft;
            paymentsHistoryButton.UseVisualStyleBackColor = false;
            paymentsHistoryButton.Click += paymentsHistoryButton_Click;
            // 
            // receiptButton
            // 
            receiptButton.BackColor = Color.DarkBlue;
            receiptButton.Dock = DockStyle.Top;
            receiptButton.FlatAppearance.BorderSize = 0;
            receiptButton.FlatStyle = FlatStyle.Flat;
            receiptButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            receiptButton.ForeColor = SystemColors.ControlLight;
            receiptButton.Location = new Point(0, 70);
            receiptButton.Name = "receiptButton";
            receiptButton.Padding = new Padding(30, 0, 0, 0);
            receiptButton.Size = new Size(250, 35);
            receiptButton.TabIndex = 3;
            receiptButton.Text = "Generate Receipt";
            receiptButton.TextAlign = ContentAlignment.MiddleLeft;
            receiptButton.UseVisualStyleBackColor = false;
            receiptButton.Click += receiptButton_Click;
            // 
            // dpnButton
            // 
            dpnButton.BackColor = Color.DarkBlue;
            dpnButton.Dock = DockStyle.Top;
            dpnButton.FlatAppearance.BorderSize = 0;
            dpnButton.FlatStyle = FlatStyle.Flat;
            dpnButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dpnButton.ForeColor = SystemColors.ControlLight;
            dpnButton.Location = new Point(0, 35);
            dpnButton.Name = "dpnButton";
            dpnButton.Padding = new Padding(30, 0, 0, 0);
            dpnButton.Size = new Size(250, 35);
            dpnButton.TabIndex = 2;
            dpnButton.Text = "Generate DPN";
            dpnButton.TextAlign = ContentAlignment.MiddleLeft;
            dpnButton.UseVisualStyleBackColor = false;
            dpnButton.Click += dpnButton_Click;
            // 
            // pricesButton
            // 
            pricesButton.BackColor = Color.DarkBlue;
            pricesButton.Dock = DockStyle.Top;
            pricesButton.FlatAppearance.BorderSize = 0;
            pricesButton.FlatStyle = FlatStyle.Flat;
            pricesButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pricesButton.ForeColor = SystemColors.ControlLight;
            pricesButton.Location = new Point(0, 0);
            pricesButton.Name = "pricesButton";
            pricesButton.Padding = new Padding(30, 0, 0, 0);
            pricesButton.Size = new Size(250, 35);
            pricesButton.TabIndex = 1;
            pricesButton.Text = "Prices";
            pricesButton.TextAlign = ContentAlignment.MiddleLeft;
            pricesButton.UseVisualStyleBackColor = false;
            pricesButton.Click += pricesButton_Click;
            // 
            // paymentsButton
            // 
            paymentsButton.Dock = DockStyle.Top;
            paymentsButton.FlatAppearance.BorderSize = 0;
            paymentsButton.FlatStyle = FlatStyle.Flat;
            paymentsButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            paymentsButton.ForeColor = SystemColors.ControlLight;
            paymentsButton.Location = new Point(0, 417);
            paymentsButton.Name = "paymentsButton";
            paymentsButton.Padding = new Padding(15, 0, 0, 0);
            paymentsButton.Size = new Size(250, 40);
            paymentsButton.TabIndex = 6;
            paymentsButton.Text = "Payments";
            paymentsButton.TextAlign = ContentAlignment.MiddleLeft;
            paymentsButton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(availabilityHistoryButton);
            panel3.Controls.Add(damageHistoryButton);
            panel3.Controls.Add(roomsButton);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 311);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 106);
            panel3.TabIndex = 5;
            // 
            // availabilityHistoryButton
            // 
            availabilityHistoryButton.BackColor = Color.DarkBlue;
            availabilityHistoryButton.Dock = DockStyle.Top;
            availabilityHistoryButton.FlatAppearance.BorderSize = 0;
            availabilityHistoryButton.FlatStyle = FlatStyle.Flat;
            availabilityHistoryButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            availabilityHistoryButton.ForeColor = SystemColors.ControlLight;
            availabilityHistoryButton.Location = new Point(0, 70);
            availabilityHistoryButton.Name = "availabilityHistoryButton";
            availabilityHistoryButton.Padding = new Padding(30, 0, 0, 0);
            availabilityHistoryButton.Size = new Size(250, 35);
            availabilityHistoryButton.TabIndex = 4;
            availabilityHistoryButton.Text = "Room Availability History";
            availabilityHistoryButton.TextAlign = ContentAlignment.MiddleLeft;
            availabilityHistoryButton.UseVisualStyleBackColor = false;
            availabilityHistoryButton.Click += availabilityHistoryButton_Click;
            // 
            // damageHistoryButton
            // 
            damageHistoryButton.BackColor = Color.DarkBlue;
            damageHistoryButton.Dock = DockStyle.Top;
            damageHistoryButton.FlatAppearance.BorderSize = 0;
            damageHistoryButton.FlatStyle = FlatStyle.Flat;
            damageHistoryButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            damageHistoryButton.ForeColor = SystemColors.ControlLight;
            damageHistoryButton.Location = new Point(0, 35);
            damageHistoryButton.Name = "damageHistoryButton";
            damageHistoryButton.Padding = new Padding(30, 0, 0, 0);
            damageHistoryButton.Size = new Size(250, 35);
            damageHistoryButton.TabIndex = 3;
            damageHistoryButton.Text = "Room Damages History";
            damageHistoryButton.TextAlign = ContentAlignment.MiddleLeft;
            damageHistoryButton.UseVisualStyleBackColor = false;
            damageHistoryButton.Click += damageHistoryButton_Click;
            // 
            // roomsButton
            // 
            roomsButton.BackColor = Color.DarkBlue;
            roomsButton.Dock = DockStyle.Top;
            roomsButton.FlatAppearance.BorderSize = 0;
            roomsButton.FlatStyle = FlatStyle.Flat;
            roomsButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomsButton.ForeColor = SystemColors.ControlLight;
            roomsButton.Location = new Point(0, 0);
            roomsButton.Name = "roomsButton";
            roomsButton.Padding = new Padding(30, 0, 0, 0);
            roomsButton.Size = new Size(250, 35);
            roomsButton.TabIndex = 1;
            roomsButton.Text = "Rooms";
            roomsButton.TextAlign = ContentAlignment.MiddleLeft;
            roomsButton.UseVisualStyleBackColor = false;
            roomsButton.Click += roomsButton_Click;
            // 
            // roomButton
            // 
            roomButton.Dock = DockStyle.Top;
            roomButton.FlatAppearance.BorderSize = 0;
            roomButton.FlatStyle = FlatStyle.Flat;
            roomButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomButton.ForeColor = SystemColors.ControlLight;
            roomButton.Location = new Point(0, 271);
            roomButton.Name = "roomButton";
            roomButton.Padding = new Padding(15, 0, 0, 0);
            roomButton.Size = new Size(250, 40);
            roomButton.TabIndex = 4;
            roomButton.Text = "Rooms";
            roomButton.TextAlign = ContentAlignment.MiddleLeft;
            roomButton.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(rentersHistoryButton);
            panel2.Controls.Add(rentersProfileButton);
            panel2.Controls.Add(registrationButton);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 106);
            panel2.TabIndex = 3;
            // 
            // rentersHistoryButton
            // 
            rentersHistoryButton.BackColor = Color.DarkBlue;
            rentersHistoryButton.Dock = DockStyle.Top;
            rentersHistoryButton.FlatAppearance.BorderSize = 0;
            rentersHistoryButton.FlatStyle = FlatStyle.Flat;
            rentersHistoryButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rentersHistoryButton.ForeColor = SystemColors.ControlLight;
            rentersHistoryButton.Location = new Point(0, 70);
            rentersHistoryButton.Name = "rentersHistoryButton";
            rentersHistoryButton.Padding = new Padding(30, 0, 0, 0);
            rentersHistoryButton.Size = new Size(250, 35);
            rentersHistoryButton.TabIndex = 2;
            rentersHistoryButton.Text = "Renters History";
            rentersHistoryButton.TextAlign = ContentAlignment.MiddleLeft;
            rentersHistoryButton.UseVisualStyleBackColor = false;
            rentersHistoryButton.Click += rentersHistoryButton_Click;
            // 
            // rentersProfileButton
            // 
            rentersProfileButton.BackColor = Color.DarkBlue;
            rentersProfileButton.Dock = DockStyle.Top;
            rentersProfileButton.FlatAppearance.BorderSize = 0;
            rentersProfileButton.FlatStyle = FlatStyle.Flat;
            rentersProfileButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rentersProfileButton.ForeColor = SystemColors.ControlLight;
            rentersProfileButton.Location = new Point(0, 35);
            rentersProfileButton.Name = "rentersProfileButton";
            rentersProfileButton.Padding = new Padding(30, 0, 0, 0);
            rentersProfileButton.Size = new Size(250, 35);
            rentersProfileButton.TabIndex = 1;
            rentersProfileButton.Text = "Renters Profile";
            rentersProfileButton.TextAlign = ContentAlignment.MiddleLeft;
            rentersProfileButton.UseVisualStyleBackColor = false;
            rentersProfileButton.Click += rentersProfileButton_Click;
            // 
            // registrationButton
            // 
            registrationButton.BackColor = Color.DarkBlue;
            registrationButton.Dock = DockStyle.Top;
            registrationButton.FlatAppearance.BorderSize = 0;
            registrationButton.FlatStyle = FlatStyle.Flat;
            registrationButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            registrationButton.ForeColor = SystemColors.ControlLight;
            registrationButton.Location = new Point(0, 0);
            registrationButton.Name = "registrationButton";
            registrationButton.Padding = new Padding(30, 0, 0, 0);
            registrationButton.Size = new Size(250, 35);
            registrationButton.TabIndex = 0;
            registrationButton.Text = "Registration";
            registrationButton.TextAlign = ContentAlignment.MiddleLeft;
            registrationButton.UseVisualStyleBackColor = false;
            registrationButton.Click += registrationButton_Click;
            // 
            // rentersButton
            // 
            rentersButton.Dock = DockStyle.Top;
            rentersButton.FlatAppearance.BorderSize = 0;
            rentersButton.FlatStyle = FlatStyle.Flat;
            rentersButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rentersButton.ForeColor = SystemColors.ControlLight;
            rentersButton.Location = new Point(0, 125);
            rentersButton.Name = "rentersButton";
            rentersButton.Padding = new Padding(15, 0, 0, 0);
            rentersButton.Size = new Size(250, 40);
            rentersButton.TabIndex = 2;
            rentersButton.Text = "Renters";
            rentersButton.TextAlign = ContentAlignment.MiddleLeft;
            rentersButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 1;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1382, 753);
            Controls.Add(sideMenuPanel);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainMenuForm";
            Load += mainForm_Load;
            sideMenuPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sideMenuPanel;
        private Panel panel1;
        private Panel panel2;
        private Button registrationButton;
        private Button rentersHistoryButton;
        private Button rentersProfileButton;
        private Panel panel4;
        private Button paymentsHistoryButton;
        private Button receiptButton;
        private Button dpnButton;
        private Button pricesButton;
        private Panel panel3;
        private Button availabilityHistoryButton;
        private Button damageHistoryButton;
        private Button roomsButton;
        private Button paymentsButton;
        private Button roomButton;
        private Button rentersButton;
        private Button pricesHistoryButton;
    }
}