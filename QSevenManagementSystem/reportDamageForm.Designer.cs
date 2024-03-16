namespace QSevenManagementSystem
{
    partial class reportDamageForm
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
            rdDate = new DateTimePicker();
            label3 = new Label();
            totalTBox = new TextBox();
            label1 = new Label();
            descTBox = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            roomIdTBox = new TextBox();
            label12 = new Label();
            damageCBox = new ComboBox();
            roomsData = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            confirmButton = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label17 = new Label();
            label18 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label = new Label();
            registrationDate = new DateTimePicker();
            label16 = new Label();
            label7 = new Label();
            roomTBox = new TextBox();
            label8 = new Label();
            depositAmountTBox = new TextBox();
            moveInDate = new DateTimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            lNameLabel = new Label();
            mNameLabel = new Label();
            searchCBox = new ComboBox();
            searchTBox = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label34 = new Label();
            maxLabel = new Label();
            label30 = new Label();
            floorLabel = new Label();
            label28 = new Label();
            roomLabel = new Label();
            label25 = new Label();
            label24 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            priceLabel = new Label();
            label99 = new Label();
            availabilityLabel = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)roomsData).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // rdDate
            // 
            rdDate.Location = new Point(674, 178);
            rdDate.Margin = new Padding(3, 2, 3, 2);
            rdDate.Name = "rdDate";
            rdDate.Size = new Size(230, 23);
            rdDate.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(513, 184);
            label3.Name = "label3";
            label3.Size = new Size(34, 14);
            label3.TabIndex = 58;
            label3.Text = "Date";
            // 
            // totalTBox
            // 
            totalTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            totalTBox.Location = new Point(674, 144);
            totalTBox.Margin = new Padding(3, 2, 3, 2);
            totalTBox.Name = "totalTBox";
            totalTBox.Size = new Size(98, 21);
            totalTBox.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(513, 146);
            label1.Name = "label1";
            label1.Size = new Size(87, 14);
            label1.TabIndex = 56;
            label1.Text = "Total damage";
            // 
            // descTBox
            // 
            descTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            descTBox.Location = new Point(674, 112);
            descTBox.Margin = new Padding(3, 2, 3, 2);
            descTBox.Name = "descTBox";
            descTBox.Size = new Size(246, 21);
            descTBox.TabIndex = 55;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(513, 115);
            label9.Name = "label9";
            label9.Size = new Size(74, 14);
            label9.TabIndex = 54;
            label9.Text = "Description";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(513, 86);
            label10.Name = "label10";
            label10.Size = new Size(85, 14);
            label10.TabIndex = 52;
            label10.Text = "Damage type";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(59, 127);
            label11.Name = "label11";
            label11.Size = new Size(84, 14);
            label11.TabIndex = 51;
            label11.Text = "Room Details";
            // 
            // roomIdTBox
            // 
            roomIdTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomIdTBox.Location = new Point(224, 144);
            roomIdTBox.Margin = new Padding(3, 2, 3, 2);
            roomIdTBox.Name = "roomIdTBox";
            roomIdTBox.ReadOnly = true;
            roomIdTBox.Size = new Size(42, 21);
            roomIdTBox.TabIndex = 50;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(59, 146);
            label12.Name = "label12";
            label12.Size = new Size(57, 14);
            label12.TabIndex = 49;
            label12.Text = "Room ID";
            // 
            // damageCBox
            // 
            damageCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            damageCBox.FormattingEnabled = true;
            damageCBox.Location = new Point(674, 82);
            damageCBox.Margin = new Padding(3, 2, 3, 2);
            damageCBox.Name = "damageCBox";
            damageCBox.Size = new Size(133, 23);
            damageCBox.TabIndex = 61;
            // 
            // roomsData
            // 
            roomsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomsData.Location = new Point(58, 220);
            roomsData.Margin = new Padding(3, 2, 3, 2);
            roomsData.Name = "roomsData";
            roomsData.RowHeadersWidth = 51;
            roomsData.RowTemplate.Height = 29;
            roomsData.Size = new Size(413, 278);
            roomsData.TabIndex = 62;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(513, 55);
            label4.Name = "label4";
            label4.Size = new Size(99, 14);
            label4.TabIndex = 64;
            label4.Text = "Damage Details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(787, 146);
            label5.Name = "label5";
            label5.Size = new Size(43, 14);
            label5.TabIndex = 65;
            label5.Text = "pesos";
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.DarkSeaGreen;
            confirmButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            confirmButton.Location = new Point(862, 506);
            confirmButton.Margin = new Padding(3, 2, 3, 2);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(90, 32);
            confirmButton.TabIndex = 66;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 39);
            panel1.TabIndex = 67;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(492, 28);
            label6.TabIndex = 0;
            label6.Text = "Report Damage Form (2): Damage Details";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(348, 238);
            label17.Name = "label17";
            label17.Size = new Size(27, 17);
            label17.TabIndex = 73;
            label17.Text = "By";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(44, 235);
            label18.Name = "label18";
            label18.Size = new Size(65, 17);
            label18.TabIndex = 72;
            label18.Text = "Search ";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel2.Controls.Add(label, 0, 0);
            tableLayoutPanel2.Controls.Add(registrationDate, 1, 0);
            tableLayoutPanel2.Controls.Add(label16, 2, 1);
            tableLayoutPanel2.Controls.Add(label7, 0, 1);
            tableLayoutPanel2.Controls.Add(roomTBox, 1, 1);
            tableLayoutPanel2.Controls.Add(label8, 2, 0);
            tableLayoutPanel2.Controls.Add(depositAmountTBox, 3, 0);
            tableLayoutPanel2.Controls.Add(moveInDate, 3, 1);
            tableLayoutPanel2.Location = new Point(47, 105);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1061, 78);
            tableLayoutPanel2.TabIndex = 71;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(3, 0);
            label.Name = "label";
            label.Size = new Size(108, 14);
            label.TabIndex = 41;
            label.Text = "Registration Date";
            // 
            // registrationDate
            // 
            registrationDate.Location = new Point(162, 3);
            registrationDate.Name = "registrationDate";
            registrationDate.Size = new Size(262, 23);
            registrationDate.TabIndex = 42;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(533, 39);
            label16.Name = "label16";
            label16.Size = new Size(52, 14);
            label16.TabIndex = 53;
            label16.Text = "Move In";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(3, 39);
            label7.Name = "label7";
            label7.Size = new Size(41, 14);
            label7.TabIndex = 20;
            label7.Text = "Room";
            // 
            // roomTBox
            // 
            roomTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomTBox.Location = new Point(162, 42);
            roomTBox.Name = "roomTBox";
            roomTBox.Size = new Size(72, 21);
            roomTBox.TabIndex = 27;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(533, 0);
            label8.Name = "label8";
            label8.Size = new Size(100, 14);
            label8.TabIndex = 22;
            label8.Text = "Deposit Amount";
            // 
            // depositAmountTBox
            // 
            depositAmountTBox.Location = new Point(692, 3);
            depositAmountTBox.Name = "depositAmountTBox";
            depositAmountTBox.Size = new Size(125, 23);
            depositAmountTBox.TabIndex = 54;
            // 
            // moveInDate
            // 
            moveInDate.Location = new Point(692, 42);
            moveInDate.Name = "moveInDate";
            moveInDate.Size = new Size(257, 23);
            moveInDate.TabIndex = 39;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel1.Controls.Add(lNameLabel, 1, 9);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 10;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(200, 100);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lNameLabel
            // 
            lNameLabel.AutoSize = true;
            lNameLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lNameLabel.Location = new Point(79, 200);
            lNameLabel.Name = "lNameLabel";
            lNameLabel.Size = new Size(37, 15);
            lNameLabel.TabIndex = 56;
            lNameLabel.Text = "None";
            // 
            // mNameLabel
            // 
            mNameLabel.AutoSize = true;
            mNameLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mNameLabel.Location = new Point(79, 18);
            mNameLabel.Name = "mNameLabel";
            mNameLabel.Size = new Size(44, 18);
            mNameLabel.TabIndex = 56;
            mNameLabel.Text = "None";
            // 
            // searchCBox
            // 
            searchCBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchCBox.FormattingEnabled = true;
            searchCBox.Location = new Point(327, 190);
            searchCBox.Margin = new Padding(3, 2, 3, 2);
            searchCBox.Name = "searchCBox";
            searchCBox.Size = new Size(144, 22);
            searchCBox.TabIndex = 75;
            // 
            // searchTBox
            // 
            searchTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchTBox.Location = new Point(114, 190);
            searchTBox.Margin = new Padding(3, 2, 3, 2);
            searchTBox.Name = "searchTBox";
            searchTBox.Size = new Size(171, 21);
            searchTBox.TabIndex = 74;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(298, 196);
            label13.Name = "label13";
            label13.Size = new Size(23, 14);
            label13.TabIndex = 73;
            label13.Text = "By";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(59, 192);
            label14.Name = "label14";
            label14.Size = new Size(51, 14);
            label14.TabIndex = 72;
            label14.Text = "Search ";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label34.Location = new Point(58, 175);
            label34.Name = "label34";
            label34.Size = new Size(90, 14);
            label34.TabIndex = 69;
            label34.Text = "Select a room:";
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            maxLabel.Location = new Point(169, 140);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(37, 15);
            maxLabel.TabIndex = 56;
            maxLabel.Text = "None";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(5, 140);
            label30.Name = "label30";
            label30.Size = new Size(107, 14);
            label30.TabIndex = 47;
            label30.Text = "Max # of Renters:";
            // 
            // floorLabel
            // 
            floorLabel.AutoSize = true;
            floorLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            floorLabel.Location = new Point(169, 186);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new Size(37, 15);
            floorLabel.TabIndex = 56;
            floorLabel.Text = "None";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(5, 186);
            label28.Name = "label28";
            label28.Size = new Size(40, 14);
            label28.TabIndex = 46;
            label28.Text = "Floor:";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomLabel.Location = new Point(169, 48);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new Size(37, 15);
            roomLabel.TabIndex = 53;
            roomLabel.Text = "None";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(5, 48);
            label25.Name = "label25";
            label25.Size = new Size(61, 14);
            label25.TabIndex = 43;
            label25.Text = "Room ID:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(5, 2);
            label24.Name = "label24";
            label24.Size = new Size(113, 18);
            label24.TabIndex = 45;
            label24.Text = "Room Details";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel4.Controls.Add(priceLabel, 1, 2);
            tableLayoutPanel4.Controls.Add(label99, 0, 2);
            tableLayoutPanel4.Controls.Add(availabilityLabel, 1, 5);
            tableLayoutPanel4.Controls.Add(label2, 0, 5);
            tableLayoutPanel4.Controls.Add(label24, 0, 0);
            tableLayoutPanel4.Controls.Add(label25, 0, 1);
            tableLayoutPanel4.Controls.Add(roomLabel, 1, 1);
            tableLayoutPanel4.Controls.Add(label30, 0, 3);
            tableLayoutPanel4.Controls.Add(maxLabel, 1, 3);
            tableLayoutPanel4.Controls.Add(label28, 0, 4);
            tableLayoutPanel4.Controls.Add(floorLabel, 1, 4);
            tableLayoutPanel4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel4.Location = new Point(513, 220);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel4.Size = new Size(439, 278);
            tableLayoutPanel4.TabIndex = 70;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(169, 94);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(37, 15);
            priceLabel.TabIndex = 76;
            priceLabel.Text = "None";
            // 
            // label99
            // 
            label99.AutoSize = true;
            label99.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label99.Location = new Point(5, 94);
            label99.Name = "label99";
            label99.Size = new Size(41, 14);
            label99.TabIndex = 76;
            label99.Text = "Price:";
            // 
            // availabilityLabel
            // 
            availabilityLabel.AutoSize = true;
            availabilityLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            availabilityLabel.Location = new Point(169, 232);
            availabilityLabel.Name = "availabilityLabel";
            availabilityLabel.Size = new Size(37, 15);
            availabilityLabel.TabIndex = 76;
            availabilityLabel.Text = "None";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 232);
            label2.Name = "label2";
            label2.Size = new Size(75, 14);
            label2.TabIndex = 76;
            label2.Text = "Availability:";
            // 
            // reportDamageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1008, 565);
            Controls.Add(searchCBox);
            Controls.Add(searchTBox);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(label34);
            Controls.Add(panel1);
            Controls.Add(confirmButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(roomsData);
            Controls.Add(damageCBox);
            Controls.Add(rdDate);
            Controls.Add(label3);
            Controls.Add(totalTBox);
            Controls.Add(label1);
            Controls.Add(descTBox);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(roomIdTBox);
            Controls.Add(label12);
            Margin = new Padding(3, 2, 3, 2);
            Name = "reportDamageForm";
            Text = "reportDamageForm";
            ((System.ComponentModel.ISupportInitialize)roomsData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker rdDate;
        private Label label3;
        private TextBox totalTBox;
        private Label label1;
        private TextBox descTBox;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox roomIdTBox;
        private Label label12;
        private ComboBox damageCBox;
        private DataGridView roomsData;
        private Label label4;
        private Label label5;
        private Button confirmButton;
        private Panel panel1;
        private Label label6;
        private Label label17;
        private Label label18;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label;
        private DateTimePicker registrationDate;
        private Label label16;
        private Label label7;
        private TextBox roomTBox;
        private Label label8;
        private TextBox depositAmountTBox;
        private DateTimePicker moveInDate;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lNameLabel;
        private Label mNameLabel;
        private ComboBox searchCBox;
        private TextBox searchTBox;
        private Label label13;
        private Label label14;
        private Label label34;
        private Label maxLabel;
        private Label label30;
        private Label floorLabel;
        private Label label28;
        private Label roomLabel;
        private Label label25;
        private Label label24;
        private TableLayoutPanel tableLayoutPanel4;
        private Label priceLabel;
        private Label label99;
        private Label availabilityLabel;
        private Label label2;
    }
}