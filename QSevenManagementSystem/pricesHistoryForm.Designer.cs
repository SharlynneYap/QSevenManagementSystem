namespace QSevenManagementSystem
{
    partial class pricesHistoryForm
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
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            pricesData = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            rateData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pricesData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rateData).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
<<<<<<< Updated upstream
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(79, 78);
            label2.Name = "label2";
            label2.Size = new Size(111, 17);
            label2.TabIndex = 9;
            label2.Text = "Prices History";
=======
            searchCBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchCBox.FormattingEnabled = true;
            searchCBox.Location = new Point(564, 101);
            searchCBox.Name = "searchCBox";
            searchCBox.Size = new Size(122, 25);
            searchCBox.TabIndex = 17;
>>>>>>> Stashed changes
            // 
            // comboBox1
            // 
<<<<<<< Updated upstream
            comboBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(888, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 25);
            comboBox1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(611, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 25);
            textBox1.TabIndex = 16;
=======
            searchTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchTBox.Location = new Point(98, 101);
            searchTBox.Name = "searchTBox";
            searchTBox.Size = new Size(197, 25);
            searchTBox.TabIndex = 16;
>>>>>>> Stashed changes
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< Updated upstream
            label3.Location = new Point(857, 84);
=======
            label3.Location = new Point(531, 104);
>>>>>>> Stashed changes
            label3.Name = "label3";
            label3.Size = new Size(27, 17);
            label3.TabIndex = 15;
            label3.Text = "By";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
<<<<<<< Updated upstream
            label1.Location = new Point(548, 81);
=======
            label1.Location = new Point(27, 104);
>>>>>>> Stashed changes
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 14;
            label1.Text = "Search ";
            // 
            // pricesData
            // 
            pricesData.AllowUserToAddRows = false;
            pricesData.AllowUserToDeleteRows = false;
            pricesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< Updated upstream
            pricesData.Location = new Point(79, 150);
=======
            pricesData.Location = new Point(27, 132);
>>>>>>> Stashed changes
            pricesData.Name = "pricesData";
            pricesData.ReadOnly = true;
            pricesData.RowHeadersWidth = 51;
            pricesData.RowTemplate.Height = 29;
<<<<<<< Updated upstream
            pricesData.Size = new Size(894, 201);
=======
            pricesData.Size = new Size(659, 589);
>>>>>>> Stashed changes
            pricesData.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(79, 130);
            label4.Name = "label4";
            label4.Size = new Size(93, 17);
            label4.TabIndex = 18;
            label4.Text = "Room Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(79, 431);
            label5.Name = "label5";
            label5.Size = new Size(69, 17);
            label5.TabIndex = 20;
            label5.Text = "Bill Rate";
            // 
            // rateData
            // 
            rateData.AllowUserToAddRows = false;
            rateData.AllowUserToDeleteRows = false;
            rateData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rateData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rateData.Location = new Point(27, 827);
            rateData.Name = "rateData";
            rateData.ReadOnly = true;
            rateData.RowHeadersWidth = 51;
            rateData.RowTemplate.Height = 29;
<<<<<<< Updated upstream
            rateData.Size = new Size(894, 211);
            rateData.TabIndex = 19;
            // 
=======
            rateData.Size = new Size(659, 587);
            rateData.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1137, 52);
            panel1.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(221, 34);
            label2.TabIndex = 0;
            label2.Text = "Prices History";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(dateLabel, 1, 3);
            tableLayoutPanel5.Controls.Add(label18, 0, 3);
            tableLayoutPanel5.Controls.Add(label22, 0, 1);
            tableLayoutPanel5.Controls.Add(label20, 0, 0);
            tableLayoutPanel5.Controls.Add(label16, 0, 2);
            tableLayoutPanel5.Controls.Add(roomPLabel, 1, 2);
            tableLayoutPanel5.Controls.Add(roomPIDLabel, 1, 1);
            tableLayoutPanel5.Controls.Add(label14, 0, 7);
            tableLayoutPanel5.Controls.Add(maxLabel, 1, 7);
            tableLayoutPanel5.Controls.Add(label13, 0, 6);
            tableLayoutPanel5.Controls.Add(flLabel, 1, 6);
            tableLayoutPanel5.Controls.Add(label21, 0, 5);
            tableLayoutPanel5.Controls.Add(roomIDLabel, 1, 5);
            tableLayoutPanel5.Controls.Add(label24, 0, 4);
            tableLayoutPanel5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel5.Location = new Point(706, 132);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 8;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel5.Size = new Size(379, 589);
            tableLayoutPanel5.TabIndex = 70;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(193, 221);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(44, 18);
            dateLabel.TabIndex = 73;
            dateLabel.Text = "None";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(5, 221);
            label18.Name = "label18";
            label18.Size = new Size(47, 17);
            label18.TabIndex = 73;
            label18.Text = "Date:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(5, 75);
            label22.Name = "label22";
            label22.Size = new Size(118, 17);
            label22.TabIndex = 72;
            label22.Text = "Room Price ID:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(5, 2);
            label20.Name = "label20";
            label20.Size = new Size(122, 23);
            label20.TabIndex = 48;
            label20.Text = "Room Price";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(5, 148);
            label16.Name = "label16";
            label16.Size = new Size(98, 17);
            label16.TabIndex = 47;
            label16.Text = "Room Price:";
            // 
            // roomPLabel
            // 
            roomPLabel.AutoSize = true;
            roomPLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomPLabel.Location = new Point(193, 148);
            roomPLabel.Name = "roomPLabel";
            roomPLabel.Size = new Size(44, 18);
            roomPLabel.TabIndex = 56;
            roomPLabel.Text = "None";
            // 
            // roomPIDLabel
            // 
            roomPIDLabel.AutoSize = true;
            roomPIDLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomPIDLabel.Location = new Point(193, 75);
            roomPIDLabel.Name = "roomPIDLabel";
            roomPIDLabel.Size = new Size(44, 18);
            roomPIDLabel.TabIndex = 72;
            roomPIDLabel.Text = "None";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(5, 513);
            label14.Name = "label14";
            label14.Size = new Size(134, 17);
            label14.TabIndex = 46;
            label14.Text = "Max # of Renters:";
            // 
            // maxLabel
            // 
            maxLabel.AccessibleDescription = "maxLabel";
            maxLabel.AutoSize = true;
            maxLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            maxLabel.Location = new Point(193, 513);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(44, 18);
            maxLabel.TabIndex = 56;
            maxLabel.Text = "None";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(5, 440);
            label13.Name = "label13";
            label13.Size = new Size(51, 17);
            label13.TabIndex = 44;
            label13.Text = "Floor:";
            // 
            // flLabel
            // 
            flLabel.AutoSize = true;
            flLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            flLabel.Location = new Point(193, 440);
            flLabel.Name = "flLabel";
            flLabel.Size = new Size(44, 18);
            flLabel.TabIndex = 54;
            flLabel.Text = "None";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(5, 367);
            label21.Name = "label21";
            label21.Size = new Size(75, 17);
            label21.TabIndex = 49;
            label21.Text = "Room ID:";
            // 
            // roomIDLabel
            // 
            roomIDLabel.AutoSize = true;
            roomIDLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomIDLabel.Location = new Point(193, 367);
            roomIDLabel.Name = "roomIDLabel";
            roomIDLabel.Size = new Size(44, 18);
            roomIDLabel.TabIndex = 56;
            roomIDLabel.Text = "None";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(5, 294);
            label24.Name = "label24";
            label24.Size = new Size(138, 23);
            label24.TabIndex = 72;
            label24.Text = "Room Details";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel1.Controls.Add(rateLabel, 1, 3);
            tableLayoutPanel1.Controls.Add(label8, 0, 2);
            tableLayoutPanel1.Controls.Add(label9, 0, 3);
            tableLayoutPanel1.Controls.Add(typeLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(label12, 0, 1);
            tableLayoutPanel1.Controls.Add(rateIDLabel, 1, 1);
            tableLayoutPanel1.Controls.Add(label19, 0, 0);
            tableLayoutPanel1.Controls.Add(label10, 0, 4);
            tableLayoutPanel1.Controls.Add(dateLabel2, 1, 4);
            tableLayoutPanel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel1.Location = new Point(706, 827);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.Size = new Size(380, 259);
            tableLayoutPanel1.TabIndex = 71;
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rateLabel.Location = new Point(147, 155);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new Size(44, 18);
            rateLabel.TabIndex = 56;
            rateLabel.Text = "None";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(5, 104);
            label8.Name = "label8";
            label8.Size = new Size(75, 17);
            label8.TabIndex = 44;
            label8.Text = "Bill Type:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(5, 155);
            label9.Name = "label9";
            label9.Size = new Size(74, 17);
            label9.TabIndex = 46;
            label9.Text = "Bill Rate:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            typeLabel.Location = new Point(147, 104);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(44, 18);
            typeLabel.TabIndex = 54;
            typeLabel.Text = "None";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(5, 53);
            label12.Name = "label12";
            label12.Size = new Size(94, 17);
            label12.TabIndex = 49;
            label12.Text = "Bill Rate ID:";
            // 
            // rateIDLabel
            // 
            rateIDLabel.AutoSize = true;
            rateIDLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rateIDLabel.Location = new Point(147, 53);
            rateIDLabel.Name = "rateIDLabel";
            rateIDLabel.Size = new Size(44, 18);
            rateIDLabel.TabIndex = 56;
            rateIDLabel.Text = "None";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(5, 2);
            label19.Name = "label19";
            label19.Size = new Size(89, 23);
            label19.TabIndex = 48;
            label19.Text = "Bill Rate";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(5, 206);
            label10.Name = "label10";
            label10.Size = new Size(47, 17);
            label10.TabIndex = 47;
            label10.Text = "Date:";
            // 
            // dateLabel2
            // 
            dateLabel2.AutoSize = true;
            dateLabel2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel2.Location = new Point(147, 206);
            dateLabel2.Name = "dateLabel2";
            dateLabel2.Size = new Size(44, 18);
            dateLabel2.TabIndex = 56;
            dateLabel2.Text = "None";
            // 
            // searchCBox2
            // 
            searchCBox2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchCBox2.FormattingEnabled = true;
            searchCBox2.Location = new Point(564, 796);
            searchCBox2.Name = "searchCBox2";
            searchCBox2.Size = new Size(122, 25);
            searchCBox2.TabIndex = 76;
            // 
            // searchTBox2
            // 
            searchTBox2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchTBox2.Location = new Point(108, 796);
            searchTBox2.Name = "searchTBox2";
            searchTBox2.Size = new Size(197, 25);
            searchTBox2.TabIndex = 75;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(533, 802);
            label26.Name = "label26";
            label26.Size = new Size(27, 17);
            label26.TabIndex = 74;
            label26.Text = "By";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(27, 799);
            label27.Name = "label27";
            label27.Size = new Size(65, 17);
            label27.TabIndex = 73;
            label27.Text = "Search ";
            // 
>>>>>>> Stashed changes
            // pricesHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(0, 40);
            BackColor = SystemColors.ControlLight;
<<<<<<< Updated upstream
            ClientSize = new Size(1132, 753);
            Controls.Add(label5);
=======
            ClientSize = new Size(1158, 766);
            Controls.Add(searchCBox2);
            Controls.Add(searchTBox2);
            Controls.Add(label26);
            Controls.Add(label27);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(panel1);
>>>>>>> Stashed changes
            Controls.Add(rateData);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pricesData);
<<<<<<< Updated upstream
            Controls.Add(label2);
=======
            FormBorderStyle = FormBorderStyle.None;
>>>>>>> Stashed changes
            Name = "pricesHistoryForm";
            Text = "pricesHistoryForm";
            ((System.ComponentModel.ISupportInitialize)pricesData).EndInit();
            ((System.ComponentModel.ISupportInitialize)rateData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label1;
        private DataGridView pricesData;
        private Label label4;
        private Label label5;
        private DataGridView rateData;
    }
}