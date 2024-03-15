namespace QSevenManagementSystem
{
    partial class registrationForm2
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
            label1 = new Label();
            nextButton = new Button();
            depositTBox = new TextBox();
            roomTBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            selectRoomData = new DataGridView();
            label5 = new Label();
            moveInDate = new DateTimePicker();
            prevButton = new Button();
            registrationDate = new DateTimePicker();
            label = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label14 = new Label();
            label16 = new Label();
            depositAmountTBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label19 = new Label();
            roomLabel = new Label();
            registerLabel = new Label();
            maxLabel = new Label();
            floorLabel = new Label();
            availLabel = new Label();
            priceLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            searchCBox = new ComboBox();
            searchTBox = new TextBox();
            label17 = new Label();
            label18 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectRoomData).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 39);
            panel1.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(478, 28);
            label1.TabIndex = 0;
            label1.Text = "Registration Form (2): Room Assignment";
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.DarkSeaGreen;
            nextButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nextButton.Location = new Point(878, 489);
            nextButton.Margin = new Padding(3, 2, 3, 2);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(90, 32);
            nextButton.TabIndex = 34;
            nextButton.Text = "Confirm";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // depositTBox
            // 
            depositTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            depositTBox.Location = new Point(3, 2);
            depositTBox.Margin = new Padding(3, 2, 3, 2);
            depositTBox.Name = "depositTBox";
            depositTBox.Size = new Size(224, 21);
            depositTBox.TabIndex = 29;
            // 
            // roomTBox
            // 
            roomTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomTBox.Location = new Point(142, 31);
            roomTBox.Margin = new Padding(3, 2, 3, 2);
            roomTBox.Name = "roomTBox";
            roomTBox.Size = new Size(64, 21);
            roomTBox.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(466, 0);
            label4.Name = "label4";
            label4.Size = new Size(100, 14);
            label4.TabIndex = 22;
            label4.Text = "Deposit Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(82, 14);
            label3.TabIndex = 21;
            label3.Text = "Move In Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(41, 14);
            label2.TabIndex = 20;
            label2.Text = "Room";
            // 
            // selectRoomData
            // 
            selectRoomData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectRoomData.Location = new Point(40, 182);
            selectRoomData.Margin = new Padding(3, 2, 3, 2);
            selectRoomData.Name = "selectRoomData";
            selectRoomData.RowHeadersWidth = 51;
            selectRoomData.RowTemplate.Height = 29;
            selectRoomData.Size = new Size(469, 288);
            selectRoomData.TabIndex = 37;
            selectRoomData.CellContentClick += selectRoomData_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(38, 144);
            label5.Name = "label5";
            label5.Size = new Size(90, 14);
            label5.TabIndex = 38;
            label5.Text = "Select a room:";
            // 
            // moveInDate
            // 
            moveInDate.Location = new Point(605, 31);
            moveInDate.Margin = new Padding(3, 2, 3, 2);
            moveInDate.Name = "moveInDate";
            moveInDate.Size = new Size(225, 23);
            moveInDate.TabIndex = 39;
            // 
            // prevButton
            // 
            prevButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            prevButton.Location = new Point(799, 489);
            prevButton.Margin = new Padding(3, 2, 3, 2);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(61, 32);
            prevButton.TabIndex = 40;
            prevButton.Text = "<";
            prevButton.UseVisualStyleBackColor = true;
            prevButton.Click += prevButton_Click;
            // 
            // registrationDate
            // 
            registrationDate.Location = new Point(142, 2);
            registrationDate.Margin = new Padding(3, 2, 3, 2);
            registrationDate.Name = "registrationDate";
            registrationDate.Size = new Size(230, 23);
            registrationDate.TabIndex = 42;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(5, 107);
            label6.Name = "label6";
            label6.Size = new Size(75, 14);
            label6.TabIndex = 44;
            label6.Text = "Availability:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(5, 37);
            label7.Name = "label7";
            label7.Size = new Size(61, 14);
            label7.TabIndex = 43;
            label7.Text = "Room ID:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(5, 2);
            label8.Name = "label8";
            label8.Size = new Size(113, 18);
            label8.TabIndex = 45;
            label8.Text = "Room Details";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(5, 142);
            label9.Name = "label9";
            label9.Size = new Size(40, 14);
            label9.TabIndex = 46;
            label9.Text = "Floor:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(5, 177);
            label10.Name = "label10";
            label10.Size = new Size(107, 14);
            label10.TabIndex = 47;
            label10.Text = "Max # of Renters:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(5, 212);
            label11.Name = "label11";
            label11.Size = new Size(122, 18);
            label11.TabIndex = 48;
            label11.Text = "Renter Details";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(5, 247);
            label14.Name = "label14";
            label14.Size = new Size(98, 14);
            label14.TabIndex = 49;
            label14.Text = "Registration ID:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(466, 29);
            label16.Name = "label16";
            label16.Size = new Size(52, 14);
            label16.TabIndex = 53;
            label16.Text = "Move In";
            // 
            // depositAmountTBox
            // 
            depositAmountTBox.Location = new Point(605, 2);
            depositAmountTBox.Margin = new Padding(3, 2, 3, 2);
            depositAmountTBox.Name = "depositAmountTBox";
            depositAmountTBox.Size = new Size(110, 23);
            depositAmountTBox.TabIndex = 54;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel1.Controls.Add(label19, 0, 2);
            tableLayoutPanel1.Controls.Add(label8, 0, 0);
            tableLayoutPanel1.Controls.Add(label7, 0, 1);
            tableLayoutPanel1.Controls.Add(roomLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(label14, 0, 7);
            tableLayoutPanel1.Controls.Add(registerLabel, 1, 7);
            tableLayoutPanel1.Controls.Add(label11, 0, 6);
            tableLayoutPanel1.Controls.Add(label10, 0, 5);
            tableLayoutPanel1.Controls.Add(maxLabel, 1, 5);
            tableLayoutPanel1.Controls.Add(label9, 0, 4);
            tableLayoutPanel1.Controls.Add(floorLabel, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 3);
            tableLayoutPanel1.Controls.Add(availLabel, 1, 3);
            tableLayoutPanel1.Controls.Add(priceLabel, 1, 2);
            tableLayoutPanel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(529, 182);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel1.Size = new Size(439, 288);
            tableLayoutPanel1.TabIndex = 55;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(5, 72);
            label19.Name = "label19";
            label19.Size = new Size(78, 14);
            label19.TabIndex = 61;
            label19.Text = "Room Price:";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomLabel.Location = new Point(169, 37);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new Size(37, 15);
            roomLabel.TabIndex = 53;
            roomLabel.Text = "None";
            // 
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            registerLabel.Location = new Point(169, 247);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(37, 15);
            registerLabel.TabIndex = 56;
            registerLabel.Text = "None";
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            maxLabel.Location = new Point(169, 177);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(37, 15);
            maxLabel.TabIndex = 56;
            maxLabel.Text = "None";
            // 
            // floorLabel
            // 
            floorLabel.AutoSize = true;
            floorLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            floorLabel.Location = new Point(169, 142);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new Size(37, 15);
            floorLabel.TabIndex = 56;
            floorLabel.Text = "None";
            // 
            // availLabel
            // 
            availLabel.AutoSize = true;
            availLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            availLabel.Location = new Point(169, 107);
            availLabel.Name = "availLabel";
            availLabel.Size = new Size(37, 15);
            availLabel.TabIndex = 54;
            availLabel.Text = "None";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(169, 72);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(37, 15);
            priceLabel.TabIndex = 62;
            priceLabel.Text = "None";
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
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(roomTBox, 1, 1);
            tableLayoutPanel2.Controls.Add(label4, 2, 0);
            tableLayoutPanel2.Controls.Add(depositAmountTBox, 3, 0);
            tableLayoutPanel2.Controls.Add(moveInDate, 3, 1);
            tableLayoutPanel2.Location = new Point(40, 64);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(928, 58);
            tableLayoutPanel2.TabIndex = 56;
            // 
            // searchCBox
            // 
            searchCBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchCBox.FormattingEnabled = true;
            searchCBox.Location = new Point(331, 159);
            searchCBox.Margin = new Padding(3, 2, 3, 2);
            searchCBox.Name = "searchCBox";
            searchCBox.Size = new Size(179, 22);
            searchCBox.TabIndex = 60;
            // 
            // searchTBox
            // 
            searchTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchTBox.Location = new Point(93, 159);
            searchTBox.Margin = new Padding(3, 2, 3, 2);
            searchTBox.Name = "searchTBox";
            searchTBox.Size = new Size(206, 21);
            searchTBox.TabIndex = 59;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(304, 164);
            label17.Name = "label17";
            label17.Size = new Size(23, 14);
            label17.TabIndex = 58;
            label17.Text = "By";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(38, 161);
            label18.Name = "label18";
            label18.Size = new Size(51, 14);
            label18.TabIndex = 57;
            label18.Text = "Search ";
            // 
            // registrationForm2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1008, 565);
            Controls.Add(searchCBox);
            Controls.Add(searchTBox);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(prevButton);
            Controls.Add(label5);
            Controls.Add(selectRoomData);
            Controls.Add(panel1);
            Controls.Add(nextButton);
            Controls.Add(depositTBox);
            Controls.Add(label3);
            Margin = new Padding(3, 2, 3, 2);
            Name = "registrationForm2";
            Text = "registrationForm2";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selectRoomData).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button nextButton;
        private TextBox depositTBox;
        private TextBox roomTBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView selectRoomData;
        private Label label5;
        private DateTimePicker moveInDate;
        private Button prevButton;
        private DateTimePicker registrationDate;
        private Label label;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label14;
        private Label label16;
        private TextBox depositAmountTBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label roomLabel;
        private Label availLabel;
        private Label registerLabel;
        private Label maxLabel;
        private Label floorLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox searchCBox;
        private TextBox searchTBox;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label priceLabel;
    }
}