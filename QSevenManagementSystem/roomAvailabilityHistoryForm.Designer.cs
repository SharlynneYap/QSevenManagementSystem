namespace QSevenManagementSystem
{
    partial class roomAvailabilityHistoryForm
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
            rAData = new DataGridView();
            panel1 = new Panel();
            label10 = new Label();
            searchCBox = new ComboBox();
            searchTBox = new TextBox();
            label4 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            label2 = new Label();
            label20 = new Label();
            label1 = new Label();
            dateLabel = new Label();
            roomLabel = new Label();
            label21 = new Label();
            rALabel = new Label();
            label22 = new Label();
            availabilityLabel = new Label();
            label13 = new Label();
            priceLabel = new Label();
            label16 = new Label();
            label14 = new Label();
            floorLabel = new Label();
            maxLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)rAData).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // rAData
            // 
            rAData.AllowUserToAddRows = false;
            rAData.AllowUserToDeleteRows = false;
            rAData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rAData.Location = new Point(12, 113);
            rAData.Name = "rAData";
            rAData.ReadOnly = true;
            rAData.RowHeadersWidth = 51;
            rAData.RowTemplate.Height = 29;
            rAData.Size = new Size(602, 527);
            rAData.TabIndex = 13;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 52);
            panel1.TabIndex = 75;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLight;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(381, 34);
            label10.TabIndex = 0;
            label10.Text = "Room Availability History";
            // 
            // searchCBox
            // 
            searchCBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchCBox.FormattingEnabled = true;
            searchCBox.Location = new Point(449, 82);
            searchCBox.Name = "searchCBox";
            searchCBox.Size = new Size(165, 25);
            searchCBox.TabIndex = 74;
            // 
            // searchTBox
            // 
            searchTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchTBox.Location = new Point(75, 82);
            searchTBox.Name = "searchTBox";
            searchTBox.Size = new Size(320, 25);
            searchTBox.TabIndex = 73;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 85);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 72;
            label4.Text = "Search ";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel5.Controls.Add(label2, 0, 1);
            tableLayoutPanel5.Controls.Add(label20, 0, 0);
            tableLayoutPanel5.Controls.Add(label1, 0, 7);
            tableLayoutPanel5.Controls.Add(dateLabel, 1, 7);
            tableLayoutPanel5.Controls.Add(roomLabel, 1, 2);
            tableLayoutPanel5.Controls.Add(label21, 0, 2);
            tableLayoutPanel5.Controls.Add(rALabel, 1, 1);
            tableLayoutPanel5.Controls.Add(label22, 0, 3);
            tableLayoutPanel5.Controls.Add(availabilityLabel, 1, 3);
            tableLayoutPanel5.Controls.Add(label13, 0, 4);
            tableLayoutPanel5.Controls.Add(priceLabel, 1, 4);
            tableLayoutPanel5.Controls.Add(label16, 0, 6);
            tableLayoutPanel5.Controls.Add(label14, 0, 5);
            tableLayoutPanel5.Controls.Add(floorLabel, 1, 6);
            tableLayoutPanel5.Controls.Add(maxLabel, 1, 5);
            tableLayoutPanel5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel5.Location = new Point(638, 113);
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
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel5.Size = new Size(482, 239);
            tableLayoutPanel5.TabIndex = 76;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 31);
            label2.Name = "label2";
            label2.Size = new Size(158, 17);
            label2.TabIndex = 77;
            label2.Text = "Room Availability ID:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(5, 2);
            label20.Name = "label20";
            label20.Size = new Size(138, 23);
            label20.TabIndex = 48;
            label20.Text = "Room Details";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 205);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 77;
            label1.Text = "Date:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(185, 205);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(44, 18);
            dateLabel.TabIndex = 77;
            dateLabel.Text = "None";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomLabel.Location = new Point(185, 60);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new Size(44, 18);
            roomLabel.TabIndex = 56;
            roomLabel.Text = "None";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(5, 60);
            label21.Name = "label21";
            label21.Size = new Size(75, 17);
            label21.TabIndex = 49;
            label21.Text = "Room ID:";
            // 
            // rALabel
            // 
            rALabel.AutoSize = true;
            rALabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rALabel.Location = new Point(185, 31);
            rALabel.Name = "rALabel";
            rALabel.Size = new Size(44, 18);
            rALabel.TabIndex = 78;
            rALabel.Text = "None";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(5, 89);
            label22.Name = "label22";
            label22.Size = new Size(92, 17);
            label22.TabIndex = 43;
            label22.Text = "Availability:";
            // 
            // availabilityLabel
            // 
            availabilityLabel.AutoSize = true;
            availabilityLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            availabilityLabel.Location = new Point(185, 89);
            availabilityLabel.Name = "availabilityLabel";
            availabilityLabel.Size = new Size(44, 18);
            availabilityLabel.TabIndex = 53;
            availabilityLabel.Text = "None";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(5, 118);
            label13.Name = "label13";
            label13.Size = new Size(52, 17);
            label13.TabIndex = 44;
            label13.Text = "Price:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(185, 118);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(44, 18);
            priceLabel.TabIndex = 54;
            priceLabel.Text = "None";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(5, 176);
            label16.Name = "label16";
            label16.Size = new Size(51, 17);
            label16.TabIndex = 47;
            label16.Text = "Floor:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(5, 147);
            label14.Name = "label14";
            label14.Size = new Size(134, 17);
            label14.TabIndex = 46;
            label14.Text = "Max # of Renters:";
            // 
            // floorLabel
            // 
            floorLabel.AutoSize = true;
            floorLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            floorLabel.Location = new Point(185, 176);
            floorLabel.Name = "floorLabel";
            floorLabel.Size = new Size(44, 18);
            floorLabel.TabIndex = 56;
            floorLabel.Text = "None";
            // 
            // maxLabel
            // 
            maxLabel.AutoSize = true;
            maxLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            maxLabel.Location = new Point(185, 147);
            maxLabel.Name = "maxLabel";
            maxLabel.Size = new Size(44, 18);
            maxLabel.TabIndex = 56;
            maxLabel.Text = "None";
            // 
            // roomAvailabilityHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1152, 753);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(panel1);
            Controls.Add(searchCBox);
            Controls.Add(searchTBox);
            Controls.Add(label4);
            Controls.Add(rAData);
            Name = "roomAvailabilityHistoryForm";
            Text = "roomAvailabilityHistoryForm";
            ((System.ComponentModel.ISupportInitialize)rAData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView rAData;
        private Panel panel1;
        private Label label10;
        private ComboBox searchCBox;
        private TextBox searchTBox;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel5;
        private Label floorLabel;
        private Label maxLabel;
        private Label label13;
        private Label label14;
        private Label label16;
        private Label priceLabel;
        private Label label21;
        private Label roomLabel;
        private Label label22;
        private Label availabilityLabel;
        private Label label20;
        private Label dateLabel;
        private Label label1;
        private Label label2;
        private Label rALabel;
    }
}