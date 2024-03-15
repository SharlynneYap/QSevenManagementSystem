namespace QSevenManagementSystem
{
    partial class generateReceipt
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
            amountTBox = new TextBox();
            label13 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            confirmButton = new Button();
            label4 = new Label();
            label2 = new Label();
            dpnData = new DataGridView();
            issuedDate = new DateTimePicker();
            label3 = new Label();
            label10 = new Label();
            label11 = new Label();
            dpnIdTBox = new TextBox();
            label12 = new Label();
            searchCBox = new ComboBox();
            searchTBox = new TextBox();
            label18 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            lbl8 = new Label();
            label14 = new Label();
            lbl6 = new Label();
            label8 = new Label();
            lbl5 = new Label();
            label5 = new Label();
            label24 = new Label();
            label28 = new Label();
            label1 = new Label();
            lbl7 = new Label();
            lbl2 = new Label();
            label25 = new Label();
            lbl3 = new Label();
            label30 = new Label();
            label99 = new Label();
            lbl1 = new Label();
            lbl4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dpnData).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // amountTBox
            // 
            amountTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            amountTBox.Location = new Point(791, 273);
            amountTBox.Name = "amountTBox";
            amountTBox.Size = new Size(112, 25);
            amountTBox.TabIndex = 114;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(602, 276);
            label13.Name = "label13";
            label13.Size = new Size(99, 17);
            label13.TabIndex = 113;
            label13.Text = "Amount paid";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 52);
            panel1.TabIndex = 107;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(563, 34);
            label6.TabIndex = 0;
            label6.Text = "Generate Receipt (1): Receipt Details";
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.DarkSeaGreen;
            confirmButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            confirmButton.Location = new Point(961, 687);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(103, 42);
            confirmButton.TabIndex = 106;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(604, 237);
            label4.Name = "label4";
            label4.Size = new Size(125, 17);
            label4.TabIndex = 104;
            label4.Text = "Payment Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 273);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 103;
            label2.Text = "Select a DPN";
            // 
            // dpnData
            // 
            dpnData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dpnData.Location = new Point(67, 325);
            dpnData.Name = "dpnData";
            dpnData.RowHeadersWidth = 51;
            dpnData.RowTemplate.Height = 29;
            dpnData.Size = new Size(464, 302);
            dpnData.TabIndex = 102;
            // 
            // issuedDate
            // 
            issuedDate.Location = new Point(791, 192);
            issuedDate.Name = "issuedDate";
            issuedDate.Size = new Size(262, 27);
            issuedDate.TabIndex = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(601, 199);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 99;
            label3.Text = "Date issued";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(602, 163);
            label10.Name = "label10";
            label10.Size = new Size(118, 17);
            label10.TabIndex = 95;
            label10.Text = "Receipt Details";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(76, 158);
            label11.Name = "label11";
            label11.Size = new Size(94, 17);
            label11.TabIndex = 94;
            label11.Text = "DPN Details";
            // 
            // dpnIdTBox
            // 
            dpnIdTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dpnIdTBox.Location = new Point(265, 192);
            dpnIdTBox.Name = "dpnIdTBox";
            dpnIdTBox.Size = new Size(47, 25);
            dpnIdTBox.TabIndex = 93;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(76, 195);
            label12.Name = "label12";
            label12.Size = new Size(60, 17);
            label12.TabIndex = 92;
            label12.Text = "DPN ID";
            // 
            // searchCBox
            // 
            searchCBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchCBox.FormattingEnabled = true;
            searchCBox.Location = new Point(384, 294);
            searchCBox.Name = "searchCBox";
            searchCBox.Size = new Size(147, 25);
            searchCBox.TabIndex = 117;
            // 
            // searchTBox
            // 
            searchTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchTBox.Location = new Point(133, 294);
            searchTBox.Name = "searchTBox";
            searchTBox.Size = new Size(235, 25);
            searchTBox.TabIndex = 116;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(70, 297);
            label18.Name = "label18";
            label18.Size = new Size(65, 17);
            label18.TabIndex = 115;
            label18.Text = "Search ";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel4.Controls.Add(lbl8, 1, 8);
            tableLayoutPanel4.Controls.Add(label14, 0, 8);
            tableLayoutPanel4.Controls.Add(lbl6, 1, 6);
            tableLayoutPanel4.Controls.Add(label8, 0, 6);
            tableLayoutPanel4.Controls.Add(lbl5, 1, 5);
            tableLayoutPanel4.Controls.Add(label5, 0, 5);
            tableLayoutPanel4.Controls.Add(label24, 0, 0);
            tableLayoutPanel4.Controls.Add(label28, 0, 7);
            tableLayoutPanel4.Controls.Add(label1, 0, 2);
            tableLayoutPanel4.Controls.Add(lbl7, 1, 7);
            tableLayoutPanel4.Controls.Add(lbl2, 1, 2);
            tableLayoutPanel4.Controls.Add(label25, 0, 3);
            tableLayoutPanel4.Controls.Add(lbl3, 1, 3);
            tableLayoutPanel4.Controls.Add(label30, 0, 1);
            tableLayoutPanel4.Controls.Add(label99, 0, 4);
            tableLayoutPanel4.Controls.Add(lbl1, 1, 1);
            tableLayoutPanel4.Controls.Add(lbl4, 1, 4);
            tableLayoutPanel4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel4.Location = new Point(578, 325);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 9;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1111107F));
            tableLayoutPanel4.Size = new Size(463, 302);
            tableLayoutPanel4.TabIndex = 118;
            // 
            // lbl8
            // 
            lbl8.AutoSize = true;
            lbl8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl8.Location = new Point(178, 266);
            lbl8.Name = "lbl8";
            lbl8.Size = new Size(44, 18);
            lbl8.TabIndex = 119;
            lbl8.Text = "None";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(5, 266);
            label14.Name = "label14";
            label14.Size = new Size(130, 17);
            label14.TabIndex = 119;
            label14.Text = "DPN Date Issued";
            // 
            // lbl6
            // 
            lbl6.AutoSize = true;
            lbl6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl6.Location = new Point(178, 200);
            lbl6.Name = "lbl6";
            lbl6.Size = new Size(44, 18);
            lbl6.TabIndex = 120;
            lbl6.Text = "None";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(5, 200);
            label8.Name = "label8";
            label8.Size = new Size(44, 17);
            label8.TabIndex = 120;
            label8.Text = "Total";
            // 
            // lbl5
            // 
            lbl5.AutoSize = true;
            lbl5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl5.Location = new Point(178, 167);
            lbl5.Name = "lbl5";
            lbl5.Size = new Size(44, 18);
            lbl5.TabIndex = 119;
            lbl5.Text = "None";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(5, 167);
            label5.Name = "label5";
            label5.Size = new Size(121, 17);
            label5.TabIndex = 119;
            label5.Text = "Is Deposit Used";
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
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label28.Location = new Point(5, 233);
            label28.Name = "label28";
            label28.Size = new Size(132, 17);
            label28.TabIndex = 46;
            label28.Text = "For the month of:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 68);
            label1.Name = "label1";
            label1.Size = new Size(122, 17);
            label1.TabIndex = 76;
            label1.Text = "Registration ID:";
            // 
            // lbl7
            // 
            lbl7.AutoSize = true;
            lbl7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl7.Location = new Point(178, 233);
            lbl7.Name = "lbl7";
            lbl7.Size = new Size(44, 18);
            lbl7.TabIndex = 56;
            lbl7.Text = "None";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl2.Location = new Point(178, 68);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(44, 18);
            lbl2.TabIndex = 76;
            lbl2.Text = "None";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(5, 101);
            label25.Name = "label25";
            label25.Size = new Size(75, 17);
            label25.TabIndex = 43;
            label25.Text = "Room ID:";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl3.Location = new Point(178, 101);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(44, 18);
            lbl3.TabIndex = 53;
            lbl3.Text = "None";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(5, 35);
            label30.Name = "label30";
            label30.Size = new Size(65, 17);
            label30.TabIndex = 47;
            label30.Text = "DPN ID:";
            // 
            // label99
            // 
            label99.AutoSize = true;
            label99.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label99.Location = new Point(5, 134);
            label99.Name = "label99";
            label99.Size = new Size(98, 17);
            label99.TabIndex = 76;
            label99.Text = "Room Price:";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(178, 35);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(44, 18);
            lbl1.TabIndex = 56;
            lbl1.Text = "None";
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl4.Location = new Point(178, 134);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(44, 18);
            lbl4.TabIndex = 76;
            lbl4.Text = "None";
            // 
            // generateReceipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1152, 753);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(searchCBox);
            Controls.Add(searchTBox);
            Controls.Add(label18);
            Controls.Add(amountTBox);
            Controls.Add(label13);
            Controls.Add(panel1);
            Controls.Add(confirmButton);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(dpnData);
            Controls.Add(issuedDate);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(dpnIdTBox);
            Controls.Add(label12);
            Name = "generateReceipt";
            Text = "generateReceipt";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dpnData).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox amountTBox;
        private Label label13;
        private Panel panel1;
        private Label label6;
        private Button confirmButton;
        private Label label4;
        private Label label2;
        private DataGridView dpnData;
        private DateTimePicker issuedDate;
        private Label label3;
        private Label label10;
        private Label label11;
        private TextBox dpnIdTBox;
        private Label label12;
        private ComboBox searchCBox;
        private TextBox searchTBox;
        private Label label18;
        private TableLayoutPanel tableLayoutPanel4;
        private Label lbl4;
        private Label label99;
        private Label lbl2;
        private Label label1;
        private Label label24;
        private Label label25;
        private Label lbl3;
        private Label label28;
        private Label label30;
        private Label lbl7;
        private Label lbl1;
        private Label lbl8;
        private Label label14;
        private Label lbl6;
        private Label label8;
        private Label lbl5;
        private Label label5;
    }
}