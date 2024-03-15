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
            roomsPanel = new TableLayoutPanel();
            roomsLabel = new Label();
            label2 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            label5 = new Label();
            label6 = new Label();
            unoccupiedPanel = new TableLayoutPanel();
            unoccupiedLabel = new Label();
            label8 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label9 = new Label();
            label10 = new Label();
            occupiedPanel = new TableLayoutPanel();
            occupiedLabel = new Label();
            label12 = new Label();
            rentersPanel = new TableLayoutPanel();
            rentersLabel = new Label();
            label14 = new Label();
            reservedPanel = new TableLayoutPanel();
            reservedLabel = new Label();
            label7 = new Label();
            sideMenuPanel.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            roomsPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            unoccupiedPanel.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            occupiedPanel.SuspendLayout();
            rentersPanel.SuspendLayout();
            reservedPanel.SuspendLayout();
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
            // roomsPanel
            // 
            roomsPanel.BackColor = SystemColors.HotTrack;
            roomsPanel.ColumnCount = 1;
            roomsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            roomsPanel.Controls.Add(roomsLabel, 0, 0);
            roomsPanel.Controls.Add(label2, 0, 1);
            roomsPanel.ForeColor = SystemColors.ControlLight;
            roomsPanel.Location = new Point(269, 40);
            roomsPanel.Name = "roomsPanel";
            roomsPanel.Padding = new Padding(5);
            roomsPanel.RowCount = 2;
            roomsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            roomsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            roomsPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            roomsPanel.Size = new Size(350, 195);
            roomsPanel.TabIndex = 1;
            // 
            // roomsLabel
            // 
            roomsLabel.AutoSize = true;
            roomsLabel.Dock = DockStyle.Left;
            roomsLabel.Font = new Font("Arial Rounded MT Bold", 70.8F, FontStyle.Regular, GraphicsUnit.Point);
            roomsLabel.ForeColor = SystemColors.ControlLight;
            roomsLabel.Location = new Point(8, 5);
            roomsLabel.Name = "roomsLabel";
            roomsLabel.Size = new Size(128, 129);
            roomsLabel.TabIndex = 2;
            roomsLabel.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 134);
            label2.Name = "label2";
            label2.Size = new Size(180, 23);
            label2.TabIndex = 3;
            label2.Text = "Number of rooms";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.HotTrack;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.ForeColor = SystemColors.ControlLight;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5);
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(200, 100);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Left;
            label3.Font = new Font("Arial Rounded MT Bold", 70.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(8, 5);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 2;
            label3.Text = "0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(8, 142);
            label4.Name = "label4";
            label4.Size = new Size(180, 23);
            label4.TabIndex = 3;
            label4.Text = "Number of rooms";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = SystemColors.HotTrack;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(label5, 0, 0);
            tableLayoutPanel3.ForeColor = SystemColors.ControlLight;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(5);
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 100);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Left;
            label5.Font = new Font("Arial Rounded MT Bold", 70.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(8, 5);
            label5.Name = "label5";
            label5.Size = new Size(128, 20);
            label5.TabIndex = 2;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(8, 142);
            label6.Name = "label6";
            label6.Size = new Size(180, 23);
            label6.TabIndex = 3;
            label6.Text = "Number of rooms";
            // 
            // unoccupiedPanel
            // 
            unoccupiedPanel.BackColor = SystemColors.HotTrack;
            unoccupiedPanel.ColumnCount = 1;
            unoccupiedPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            unoccupiedPanel.Controls.Add(unoccupiedLabel, 0, 0);
            unoccupiedPanel.Controls.Add(label8, 0, 1);
            unoccupiedPanel.ForeColor = SystemColors.ControlLight;
            unoccupiedPanel.Location = new Point(1020, 40);
            unoccupiedPanel.Name = "unoccupiedPanel";
            unoccupiedPanel.Padding = new Padding(5);
            unoccupiedPanel.RowCount = 2;
            unoccupiedPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            unoccupiedPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            unoccupiedPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            unoccupiedPanel.Size = new Size(350, 195);
            unoccupiedPanel.TabIndex = 2;
            // 
            // unoccupiedLabel
            // 
            unoccupiedLabel.AutoSize = true;
            unoccupiedLabel.Dock = DockStyle.Left;
            unoccupiedLabel.Font = new Font("Arial Rounded MT Bold", 70.8F, FontStyle.Regular, GraphicsUnit.Point);
            unoccupiedLabel.ForeColor = SystemColors.ControlLight;
            unoccupiedLabel.Location = new Point(8, 5);
            unoccupiedLabel.Name = "unoccupiedLabel";
            unoccupiedLabel.Size = new Size(128, 129);
            unoccupiedLabel.TabIndex = 2;
            unoccupiedLabel.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(8, 134);
            label8.Name = "label8";
            label8.Size = new Size(300, 23);
            label8.TabIndex = 3;
            label8.Text = "Number of unoccupied rooms";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = SystemColors.HotTrack;
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(label9, 0, 0);
            tableLayoutPanel5.ForeColor = SystemColors.ControlLight;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new Padding(5);
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(200, 100);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Left;
            label9.Font = new Font("Arial Rounded MT Bold", 70.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLight;
            label9.Location = new Point(8, 5);
            label9.Name = "label9";
            label9.Size = new Size(128, 20);
            label9.TabIndex = 2;
            label9.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(8, 142);
            label10.Name = "label10";
            label10.Size = new Size(130, 69);
            label10.TabIndex = 3;
            label10.Text = "Number of unoccupied rooms";
            // 
            // occupiedPanel
            // 
            occupiedPanel.BackColor = SystemColors.HotTrack;
            occupiedPanel.ColumnCount = 1;
            occupiedPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            occupiedPanel.Controls.Add(occupiedLabel, 0, 0);
            occupiedPanel.Controls.Add(label12, 0, 1);
            occupiedPanel.ForeColor = SystemColors.ControlLight;
            occupiedPanel.Location = new Point(642, 40);
            occupiedPanel.Name = "occupiedPanel";
            occupiedPanel.Padding = new Padding(5);
            occupiedPanel.RowCount = 2;
            occupiedPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            occupiedPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            occupiedPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            occupiedPanel.Size = new Size(350, 195);
            occupiedPanel.TabIndex = 3;
            // 
            // occupiedLabel
            // 
            occupiedLabel.AutoSize = true;
            occupiedLabel.Dock = DockStyle.Left;
            occupiedLabel.Font = new Font("Arial Rounded MT Bold", 70.8F, FontStyle.Regular, GraphicsUnit.Point);
            occupiedLabel.ForeColor = SystemColors.ControlLight;
            occupiedLabel.Location = new Point(8, 5);
            occupiedLabel.Name = "occupiedLabel";
            occupiedLabel.Size = new Size(128, 129);
            occupiedLabel.TabIndex = 2;
            occupiedLabel.Text = "0";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(8, 134);
            label12.Name = "label12";
            label12.Size = new Size(276, 23);
            label12.TabIndex = 3;
            label12.Text = "Number of occupied rooms";
            // 
            // rentersPanel
            // 
            rentersPanel.BackColor = SystemColors.HotTrack;
            rentersPanel.ColumnCount = 1;
            rentersPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rentersPanel.Controls.Add(rentersLabel, 0, 0);
            rentersPanel.Controls.Add(label14, 0, 1);
            rentersPanel.ForeColor = SystemColors.ControlLight;
            rentersPanel.Location = new Point(642, 262);
            rentersPanel.Name = "rentersPanel";
            rentersPanel.Padding = new Padding(5);
            rentersPanel.RowCount = 2;
            rentersPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            rentersPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            rentersPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rentersPanel.Size = new Size(350, 195);
            rentersPanel.TabIndex = 4;
            // 
            // rentersLabel
            // 
            rentersLabel.AutoSize = true;
            rentersLabel.Dock = DockStyle.Left;
            rentersLabel.Font = new Font("Arial Rounded MT Bold", 70.8F, FontStyle.Regular, GraphicsUnit.Point);
            rentersLabel.ForeColor = SystemColors.ControlLight;
            rentersLabel.Location = new Point(8, 5);
            rentersLabel.Name = "rentersLabel";
            rentersLabel.Size = new Size(128, 129);
            rentersLabel.TabIndex = 2;
            rentersLabel.Text = "0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(8, 134);
            label14.Name = "label14";
            label14.Size = new Size(190, 23);
            label14.TabIndex = 3;
            label14.Text = "Number of renters";
            // 
            // reservedPanel
            // 
            reservedPanel.BackColor = SystemColors.HotTrack;
            reservedPanel.ColumnCount = 1;
            reservedPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            reservedPanel.Controls.Add(reservedLabel, 0, 0);
            reservedPanel.Controls.Add(label7, 0, 1);
            reservedPanel.ForeColor = SystemColors.ControlLight;
            reservedPanel.Location = new Point(269, 262);
            reservedPanel.Name = "reservedPanel";
            reservedPanel.Padding = new Padding(5);
            reservedPanel.RowCount = 2;
            reservedPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            reservedPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            reservedPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            reservedPanel.Size = new Size(350, 195);
            reservedPanel.TabIndex = 5;
            // 
            // reservedLabel
            // 
            reservedLabel.AutoSize = true;
            reservedLabel.Dock = DockStyle.Left;
            reservedLabel.Font = new Font("Arial Rounded MT Bold", 70.8F, FontStyle.Regular, GraphicsUnit.Point);
            reservedLabel.ForeColor = SystemColors.ControlLight;
            reservedLabel.Location = new Point(8, 5);
            reservedLabel.Name = "reservedLabel";
            reservedLabel.Size = new Size(128, 129);
            reservedLabel.TabIndex = 2;
            reservedLabel.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(8, 134);
            label7.Name = "label7";
            label7.Size = new Size(274, 23);
            label7.TabIndex = 3;
            label7.Text = "Number of reserved rooms";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1382, 753);
            Controls.Add(reservedPanel);
            Controls.Add(rentersPanel);
            Controls.Add(occupiedPanel);
            Controls.Add(unoccupiedPanel);
            Controls.Add(roomsPanel);
            Controls.Add(sideMenuPanel);
            Name = "mainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainMenuForm";
            Load += mainForm_Load;
            sideMenuPanel.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            roomsPanel.ResumeLayout(false);
            roomsPanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            unoccupiedPanel.ResumeLayout(false);
            unoccupiedPanel.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            occupiedPanel.ResumeLayout(false);
            occupiedPanel.PerformLayout();
            rentersPanel.ResumeLayout(false);
            rentersPanel.PerformLayout();
            reservedPanel.ResumeLayout(false);
            reservedPanel.PerformLayout();
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
        private TableLayoutPanel roomsPanel;
        private Label roomsLabel;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label5;
        private Label label6;
        private TableLayoutPanel unoccupiedPanel;
        private Label unoccupiedLabel;
        private Label label8;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label9;
        private Label label10;
        private TableLayoutPanel occupiedPanel;
        private Label occupiedLabel;
        private Label label12;
        private TableLayoutPanel rentersPanel;
        private Label rentersLabel;
        private Label label14;
        private TableLayoutPanel reservedPanel;
        private Label reservedLabel;
        private Label label7;
    }
}