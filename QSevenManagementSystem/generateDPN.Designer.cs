namespace QSevenManagementSystem
{
    partial class generateDPN
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
            panel1 = new Panel();
            label6 = new Label();
            confirmButton = new Button();
            roomData = new DataGridView();
            monthCBox = new ComboBox();
            issuedDate = new DateTimePicker();
            label3 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            roomTBox = new TextBox();
            label12 = new Label();
            priceTBox = new TextBox();
            label13 = new Label();
            registrationTBox = new TextBox();
            label14 = new Label();
            depositCheckBox = new CheckBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            availabilityLabel = new Label();
            label2 = new Label();
            label24 = new Label();
            label25 = new Label();
            roomLabel = new Label();
            label28 = new Label();
            label1 = new Label();
            label99 = new Label();
            priceLabel = new Label();
            maxLabel = new Label();
            floorLabel = new Label();
            searchCBox = new ComboBox();
            searchTBox = new TextBox();
            label18 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomData).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 52);
            panel1.TabIndex = 84;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(465, 34);
            label6.TabIndex = 0;
            label6.Text = "Generate DPN (1): DPN Details";
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.DarkSeaGreen;
            confirmButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            confirmButton.Location = new Point(961, 664);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(103, 42);
            confirmButton.TabIndex = 83;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // roomData
            // 
            roomData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomData.Location = new Point(77, 296);
            roomData.Name = "roomData";
            roomData.RowHeadersWidth = 51;
            roomData.RowTemplate.Height = 29;
            roomData.Size = new Size(464, 302);
            roomData.TabIndex = 79;
            // 
            // monthCBox
            // 
            monthCBox.FormattingEnabled = true;
            monthCBox.Location = new Point(791, 136);
            monthCBox.Name = "monthCBox";
            monthCBox.Size = new Size(151, 28);
            monthCBox.TabIndex = 78;
            // 
            // issuedDate
            // 
            issuedDate.Location = new Point(791, 180);
            issuedDate.Name = "issuedDate";
            issuedDate.Size = new Size(262, 27);
            issuedDate.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(601, 187);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 76;
            label3.Text = "Date issued";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(602, 141);
            label9.Name = "label9";
            label9.Size = new Size(127, 17);
            label9.TabIndex = 72;
            label9.Text = "For the month of";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(602, 103);
            label10.Name = "label10";
            label10.Size = new Size(94, 17);
            label10.TabIndex = 71;
            label10.Text = "DPN Details";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(74, 102);
            label11.Name = "label11";
            label11.Size = new Size(151, 17);
            label11.TabIndex = 70;
            label11.Text = "Registration Details";
            // 
            // roomTBox
            // 
            roomTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomTBox.Location = new Point(263, 132);
            roomTBox.Name = "roomTBox";
            roomTBox.Size = new Size(47, 25);
            roomTBox.TabIndex = 69;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(74, 135);
            label12.Name = "label12";
            label12.Size = new Size(70, 17);
            label12.TabIndex = 68;
            label12.Text = "Room ID";
            // 
            // priceTBox
            // 
            priceTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            priceTBox.Location = new Point(263, 199);
            priceTBox.Name = "priceTBox";
            priceTBox.Size = new Size(112, 25);
            priceTBox.TabIndex = 91;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(74, 199);
            label13.Name = "label13";
            label13.Size = new Size(92, 17);
            label13.TabIndex = 90;
            label13.Text = "Room price";
            // 
            // registrationTBox
            // 
            registrationTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            registrationTBox.Location = new Point(263, 165);
            registrationTBox.Name = "registrationTBox";
            registrationTBox.Size = new Size(47, 25);
            registrationTBox.TabIndex = 93;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(74, 168);
            label14.Name = "label14";
            label14.Size = new Size(117, 17);
            label14.TabIndex = 92;
            label14.Text = "Registration ID";
            // 
            // depositCheckBox
            // 
            depositCheckBox.AutoSize = true;
            depositCheckBox.Location = new Point(604, 230);
            depositCheckBox.Name = "depositCheckBox";
            depositCheckBox.Size = new Size(118, 24);
            depositCheckBox.TabIndex = 95;
            depositCheckBox.Text = "Deposit used";
            depositCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel4.Controls.Add(availabilityLabel, 1, 5);
            tableLayoutPanel4.Controls.Add(label2, 0, 5);
            tableLayoutPanel4.Controls.Add(label24, 0, 0);
            tableLayoutPanel4.Controls.Add(label25, 0, 1);
            tableLayoutPanel4.Controls.Add(roomLabel, 1, 1);
            tableLayoutPanel4.Controls.Add(label28, 0, 3);
            tableLayoutPanel4.Controls.Add(label1, 0, 2);
            tableLayoutPanel4.Controls.Add(label99, 0, 4);
            tableLayoutPanel4.Controls.Add(priceLabel, 1, 2);
            tableLayoutPanel4.Controls.Add(maxLabel, 1, 3);
            tableLayoutPanel4.Controls.Add(floorLabel, 1, 4);
            tableLayoutPanel4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel4.Location = new Point(604, 296);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(463, 302);
            tableLayoutPanel4.TabIndex = 96;
            // 
            // availabilityLabel
            // 
            availabilityLabel.AutoSize = true;
            availabilityLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            availabilityLabel.Location = new Point(178, 252);
            availabilityLabel.Name = "availabilityLabel";
            availabilityLabel.Size = new Size(44, 18);
            availabilityLabel.TabIndex = 101;
            availabilityLabel.Text = "None";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 252);
            label2.Name = "label2";
            label2.Size = new Size(92, 17);
            label2.TabIndex = 101;
            label2.Text = "Availability:";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(5, 2);
            label24.Name = "label24";
            label24.Size = new Size(138, 23);
            label24.TabIndex = 45;
            label24.Text = "Room Details";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(5, 52);
            label25.Name = "label25";
            label25.Size = new Size(70, 17);
            label25.TabIndex = 43;
            label25.Text = "Room ID";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomLabel.Location = new Point(178, 52);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new Size(44, 18);
            roomLabel.TabIndex = 53;
            roomLabel.Text = "None";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(5, 152);
            label28.Name = "label28";
            label28.Size = new Size(134, 17);
            label28.TabIndex = 46;
            label28.Text = "Max # of Renters;";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 102);
            label1.Name = "label1";
            label1.Size = new Size(98, 17);
            label1.TabIndex = 76;
            label1.Text = "Room Price:";
            // 
            // label99
            // 
            label99.AutoSize = true;
            label99.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label99.Location = new Point(5, 202);
            label99.Name = "label99";
            label99.Size = new Size(51, 17);
            label99.TabIndex = 76;
            label99.Text = "Floor:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(178, 102);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(44, 18);
            priceLabel.TabIndex = 76;
            priceLabel.Text = "None";
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            maxLabel.Location = new Point(178, 152);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(44, 18);
            maxLabel.TabIndex = 76;
            maxLabel.Text = "None";
            // 
            // floorLabel
            // 
            floorLabel.AutoSize = true;
            floorLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            floorLabel.Location = new Point(178, 202);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new Size(44, 18);
            floorLabel.TabIndex = 56;
            floorLabel.Text = "None";
            // 
            // searchCBox
            // 
            searchCBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchCBox.FormattingEnabled = true;
            searchCBox.Location = new Point(391, 265);
            searchCBox.Name = "searchCBox";
            searchCBox.Size = new Size(147, 25);
            searchCBox.TabIndex = 100;
            // 
            // searchTBox
            // 
            searchTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchTBox.Location = new Point(140, 265);
            searchTBox.Name = "searchTBox";
            searchTBox.Size = new Size(235, 25);
            searchTBox.TabIndex = 99;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(77, 268);
            label18.Name = "label18";
            label18.Size = new Size(65, 17);
            label18.TabIndex = 98;
            label18.Text = "Search ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(77, 245);
            label5.Name = "label5";
            label5.Size = new Size(59, 17);
            label5.TabIndex = 97;
            label5.Text = "Select:";
            // 
            // generateDPN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1152, 753);
            Controls.Add(searchCBox);
            Controls.Add(searchTBox);
            Controls.Add(label18);
            Controls.Add(label5);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(depositCheckBox);
            Controls.Add(registrationTBox);
            Controls.Add(label14);
            Controls.Add(priceTBox);
            Controls.Add(label13);
            Controls.Add(panel1);
            Controls.Add(confirmButton);
            Controls.Add(roomData);
            Controls.Add(monthCBox);
            Controls.Add(issuedDate);
            Controls.Add(label3);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(roomTBox);
            Controls.Add(label12);
            Name = "generateDPN";
            Text = "generateDPN";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)roomData).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Button confirmButton;
        private DataGridView roomData;
        private ComboBox monthCBox;
        private DateTimePicker issuedDate;
        private Label label3;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox roomTBox;
        private Label label12;
        private TextBox priceTBox;
        private Label label13;
        private TextBox registrationTBox;
        private Label label14;
        private CheckBox depositCheckBox;
        private TableLayoutPanel tableLayoutPanel4;
        private Label priceLabel;
        private Label label99;
        private Label maxLabel;
        private Label label1;
        private Label label24;
        private Label label25;
        private Label roomLabel;
        private Label label28;
        private Label floorLabel;
        private ComboBox searchCBox;
        private TextBox searchTBox;
        private Label label18;
        private Label label5;
        private Label label2;
        private Label availabilityLabel;
    }
}