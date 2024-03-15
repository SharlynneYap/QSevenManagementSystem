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
            searchCBox = new ComboBox();
            searchTBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            pricesData = new DataGridView();
            rateData = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            dateLabel = new Label();
            label18 = new Label();
            label22 = new Label();
            label20 = new Label();
            label16 = new Label();
            roomPLabel = new Label();
            roomPIDLabel = new Label();
            label14 = new Label();
            maxLabel = new Label();
            label13 = new Label();
            flLabel = new Label();
            label21 = new Label();
            roomIDLabel = new Label();
            label24 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            rateLabel = new Label();
            label8 = new Label();
            label9 = new Label();
            typeLabel = new Label();
            label12 = new Label();
            rateIDLabel = new Label();
            label19 = new Label();
            label10 = new Label();
            dateLabel2 = new Label();
            searchCBox2 = new ComboBox();
            searchTBox2 = new TextBox();
            label26 = new Label();
            label27 = new Label();
            ((System.ComponentModel.ISupportInitialize)pricesData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rateData).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // searchCBox
            // 
            searchCBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchCBox.FormattingEnabled = true;
            searchCBox.Location = new Point(475, 76);
            searchCBox.Margin = new Padding(3, 2, 3, 2);
            searchCBox.Name = "searchCBox";
            searchCBox.Size = new Size(107, 22);
            searchCBox.TabIndex = 17;
            // 
            // searchTBox
            // 
            searchTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchTBox.Location = new Point(83, 77);
            searchTBox.Margin = new Padding(3, 2, 3, 2);
            searchTBox.Name = "searchTBox";
            searchTBox.Size = new Size(173, 21);
            searchTBox.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(448, 80);
            label3.Name = "label3";
            label3.Size = new Size(23, 14);
            label3.TabIndex = 15;
            label3.Text = "By";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 80);
            label1.Name = "label1";
            label1.Size = new Size(51, 14);
            label1.TabIndex = 14;
            label1.Text = "Search ";
            // 
            // pricesData
            // 
            pricesData.AllowUserToAddRows = false;
            pricesData.AllowUserToDeleteRows = false;
            pricesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pricesData.Location = new Point(30, 103);
            pricesData.Margin = new Padding(3, 2, 3, 2);
            pricesData.Name = "pricesData";
            pricesData.ReadOnly = true;
            pricesData.RowHeadersWidth = 51;
            pricesData.RowTemplate.Height = 29;
            pricesData.Size = new Size(552, 443);
            pricesData.TabIndex = 13;
            // 
            // rateData
            // 
            rateData.AllowUserToAddRows = false;
            rateData.AllowUserToDeleteRows = false;
            rateData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rateData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rateData.Location = new Point(30, 622);
            rateData.Margin = new Padding(3, 2, 3, 2);
            rateData.Name = "rateData";
            rateData.ReadOnly = true;
            rateData.RowHeadersWidth = 51;
            rateData.RowTemplate.Height = 29;
            rateData.Size = new Size(552, 491);
            rateData.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(991, 39);
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
            label2.Size = new Size(177, 28);
            label2.TabIndex = 0;
            label2.Text = "Prices History";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.75F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 56.25F));
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
            tableLayoutPanel5.Location = new Point(609, 103);
            tableLayoutPanel5.Margin = new Padding(3, 2, 3, 2);
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
            tableLayoutPanel5.Size = new Size(370, 341);
            tableLayoutPanel5.TabIndex = 70;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(166, 128);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(37, 15);
            dateLabel.TabIndex = 73;
            dateLabel.Text = "None";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(5, 128);
            label18.Name = "label18";
            label18.Size = new Size(38, 14);
            label18.TabIndex = 73;
            label18.Text = "Date:";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(5, 44);
            label22.Name = "label22";
            label22.Size = new Size(94, 14);
            label22.TabIndex = 72;
            label22.Text = "Room Price ID:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(5, 2);
            label20.Name = "label20";
            label20.Size = new Size(100, 18);
            label20.TabIndex = 48;
            label20.Text = "Room Price";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(5, 86);
            label16.Name = "label16";
            label16.Size = new Size(78, 14);
            label16.TabIndex = 47;
            label16.Text = "Room Price:";
            // 
            // roomPLabel
            // 
            roomPLabel.AutoSize = true;
            roomPLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomPLabel.Location = new Point(166, 86);
            roomPLabel.Name = "roomPLabel";
            roomPLabel.Size = new Size(37, 15);
            roomPLabel.TabIndex = 56;
            roomPLabel.Text = "None";
            // 
            // roomPIDLabel
            // 
            roomPIDLabel.AutoSize = true;
            roomPIDLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomPIDLabel.Location = new Point(166, 44);
            roomPIDLabel.Name = "roomPIDLabel";
            roomPIDLabel.Size = new Size(37, 15);
            roomPIDLabel.TabIndex = 72;
            roomPIDLabel.Text = "None";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(5, 296);
            label14.Name = "label14";
            label14.Size = new Size(107, 14);
            label14.TabIndex = 46;
            label14.Text = "Max # of Renters:";
            // 
            // maxLabel
            // 
            maxLabel.AccessibleDescription = "maxLabel";
            maxLabel.AutoSize = true;
            maxLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            maxLabel.Location = new Point(166, 296);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(37, 15);
            maxLabel.TabIndex = 56;
            maxLabel.Text = "None";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(5, 254);
            label13.Name = "label13";
            label13.Size = new Size(40, 14);
            label13.TabIndex = 44;
            label13.Text = "Floor:";
            // 
            // flLabel
            // 
            flLabel.AutoSize = true;
            flLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            flLabel.Location = new Point(166, 254);
            flLabel.Name = "flLabel";
            flLabel.Size = new Size(37, 15);
            flLabel.TabIndex = 54;
            flLabel.Text = "None";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(5, 212);
            label21.Name = "label21";
            label21.Size = new Size(61, 14);
            label21.TabIndex = 49;
            label21.Text = "Room ID:";
            // 
            // roomIDLabel
            // 
            roomIDLabel.AutoSize = true;
            roomIDLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomIDLabel.Location = new Point(166, 212);
            roomIDLabel.Name = "roomIDLabel";
            roomIDLabel.Size = new Size(37, 15);
            roomIDLabel.TabIndex = 56;
            roomIDLabel.Text = "None";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(5, 170);
            label24.Name = "label24";
            label24.Size = new Size(113, 18);
            label24.TabIndex = 72;
            label24.Text = "Room Details";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 44.02174F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.97826F));
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
            tableLayoutPanel1.Location = new Point(609, 622);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel1.Size = new Size(370, 194);
            tableLayoutPanel1.TabIndex = 71;
            // 
            // rateLabel
            // 
            rateLabel.AutoSize = true;
            rateLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rateLabel.Location = new Point(167, 116);
            rateLabel.Name = "rateLabel";
            rateLabel.Size = new Size(37, 15);
            rateLabel.TabIndex = 56;
            rateLabel.Text = "None";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(5, 78);
            label8.Name = "label8";
            label8.Size = new Size(62, 14);
            label8.TabIndex = 44;
            label8.Text = "Bill Type:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(5, 116);
            label9.Name = "label9";
            label9.Size = new Size(59, 14);
            label9.TabIndex = 46;
            label9.Text = "Bill Rate:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            typeLabel.Location = new Point(167, 78);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(37, 15);
            typeLabel.TabIndex = 54;
            typeLabel.Text = "None";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(5, 40);
            label12.Name = "label12";
            label12.Size = new Size(75, 14);
            label12.TabIndex = 49;
            label12.Text = "Bill Rate ID:";
            // 
            // rateIDLabel
            // 
            rateIDLabel.AutoSize = true;
            rateIDLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rateIDLabel.Location = new Point(167, 40);
            rateIDLabel.Name = "rateIDLabel";
            rateIDLabel.Size = new Size(37, 15);
            rateIDLabel.TabIndex = 56;
            rateIDLabel.Text = "None";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(5, 2);
            label19.Name = "label19";
            label19.Size = new Size(74, 18);
            label19.TabIndex = 48;
            label19.Text = "Bill Rate";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(5, 154);
            label10.Name = "label10";
            label10.Size = new Size(38, 14);
            label10.TabIndex = 47;
            label10.Text = "Date:";
            // 
            // dateLabel2
            // 
            dateLabel2.AutoSize = true;
            dateLabel2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel2.Location = new Point(167, 154);
            dateLabel2.Name = "dateLabel2";
            dateLabel2.Size = new Size(37, 15);
            dateLabel2.TabIndex = 56;
            dateLabel2.Text = "None";
            // 
            // searchCBox2
            // 
            searchCBox2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchCBox2.FormattingEnabled = true;
            searchCBox2.Location = new Point(475, 595);
            searchCBox2.Margin = new Padding(3, 2, 3, 2);
            searchCBox2.Name = "searchCBox2";
            searchCBox2.Size = new Size(107, 22);
            searchCBox2.TabIndex = 76;
            // 
            // searchTBox2
            // 
            searchTBox2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchTBox2.Location = new Point(87, 594);
            searchTBox2.Margin = new Padding(3, 2, 3, 2);
            searchTBox2.Name = "searchTBox2";
            searchTBox2.Size = new Size(173, 21);
            searchTBox2.TabIndex = 75;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(446, 598);
            label26.Name = "label26";
            label26.Size = new Size(23, 14);
            label26.TabIndex = 74;
            label26.Text = "By";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(30, 597);
            label27.Name = "label27";
            label27.Size = new Size(51, 14);
            label27.TabIndex = 73;
            label27.Text = "Search ";
            // 
            // pricesHistoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoScrollMargin = new Size(0, 30);
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1008, 565);
            Controls.Add(searchCBox2);
            Controls.Add(searchTBox2);
            Controls.Add(label26);
            Controls.Add(label27);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(panel1);
            Controls.Add(rateData);
            Controls.Add(searchCBox);
            Controls.Add(searchTBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pricesData);
            Margin = new Padding(3, 2, 3, 2);
            Name = "pricesHistoryForm";
            Text = "pricesHistoryForm";
            ((System.ComponentModel.ISupportInitialize)pricesData).EndInit();
            ((System.ComponentModel.ISupportInitialize)rateData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox searchCBox;
        private TextBox searchTBox;
        private Label label3;
        private Label label1;
        private DataGridView pricesData;
        private DataGridView rateData;
        private Panel panel1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel5;
        private Label maxLabel;
        private Label roomPLabel;
        private Label label13;
        private Label label14;
        private Label label16;
        private Label flLabel;
        private Label label21;
        private Label roomIDLabel;
        private Label label20;
        private TableLayoutPanel tableLayoutPanel1;
        private Label dateLabel2;
        private Label rateLabel;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label typeLabel;
        private Label label12;
        private Label rateIDLabel;
        private Label label19;
        private Label label22;
        private Label label24;
        private Label roomPIDLabel;
        private Label dateLabel;
        private Label label18;
        private ComboBox searchCBox2;
        private TextBox searchTBox2;
        private Label label26;
        private Label label27;
    }
}