namespace QSevenManagementSystem
{
    partial class roomDamagesHistoryForm
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
            label2 = new Label();
            rDHData = new DataGridView();
            reportButton = new Button();
            applyButton = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            dateLabel6 = new Label();
            label1 = new Label();
            descLabel4 = new Label();
            damageLabel3 = new Label();
            label13 = new Label();
            label14 = new Label();
            label16 = new Label();
            roomLabel2 = new Label();
            label21 = new Label();
            roomDamageLabel1 = new Label();
            label22 = new Label();
            totalLabel5 = new Label();
            label20 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)rDHData).BeginInit();
            tableLayoutPanel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // searchCBox
            // 
            searchCBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchCBox.FormattingEnabled = true;
            searchCBox.Location = new Point(452, 67);
            searchCBox.Name = "searchCBox";
            searchCBox.Size = new Size(165, 25);
            searchCBox.TabIndex = 11;
            // 
            // searchTBox
            // 
            searchTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchTBox.Location = new Point(78, 67);
            searchTBox.Name = "searchTBox";
            searchTBox.Size = new Size(320, 25);
            searchTBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(421, 73);
            label3.Name = "label3";
            label3.Size = new Size(27, 17);
            label3.TabIndex = 9;
            label3.Text = "By";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 70);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 8;
            label2.Text = "Search ";
            // 
            // rDHData
            // 
            rDHData.AllowUserToAddRows = false;
            rDHData.AllowUserToDeleteRows = false;
            rDHData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rDHData.Location = new Point(15, 114);
            rDHData.Name = "rDHData";
            rDHData.ReadOnly = true;
            rDHData.RowHeadersWidth = 51;
            rDHData.RowTemplate.Height = 29;
            rDHData.Size = new Size(602, 562);
            rDHData.TabIndex = 7;
            // 
            // reportButton
            // 
            reportButton.BackColor = SystemColors.GradientActiveCaption;
            reportButton.Location = new Point(623, 428);
            reportButton.Name = "reportButton";
            reportButton.Size = new Size(174, 42);
            reportButton.TabIndex = 44;
            reportButton.Text = "REPORT DAMAGE";
            reportButton.UseVisualStyleBackColor = false;
            reportButton.Click += reportButton_Click;
            // 
            // applyButton
            // 
            applyButton.BackColor = Color.DarkSeaGreen;
            applyButton.Location = new Point(623, 380);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(145, 42);
            applyButton.TabIndex = 42;
            applyButton.Text = "APPLY CHANGES";
            applyButton.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel5.Controls.Add(dateLabel6, 1, 6);
            tableLayoutPanel5.Controls.Add(label1, 0, 6);
            tableLayoutPanel5.Controls.Add(descLabel4, 1, 4);
            tableLayoutPanel5.Controls.Add(damageLabel3, 1, 3);
            tableLayoutPanel5.Controls.Add(label13, 0, 2);
            tableLayoutPanel5.Controls.Add(label14, 0, 3);
            tableLayoutPanel5.Controls.Add(label16, 0, 4);
            tableLayoutPanel5.Controls.Add(roomLabel2, 1, 2);
            tableLayoutPanel5.Controls.Add(label21, 0, 1);
            tableLayoutPanel5.Controls.Add(roomDamageLabel1, 1, 1);
            tableLayoutPanel5.Controls.Add(label22, 0, 5);
            tableLayoutPanel5.Controls.Add(totalLabel5, 1, 5);
            tableLayoutPanel5.Controls.Add(label20, 0, 0);
            tableLayoutPanel5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel5.Location = new Point(623, 114);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 7;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel5.Size = new Size(502, 239);
            tableLayoutPanel5.TabIndex = 70;
            // 
            // dateLabel6
            // 
            dateLabel6.AutoSize = true;
            dateLabel6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel6.Location = new Point(193, 200);
            dateLabel6.Name = "dateLabel6";
            dateLabel6.Size = new Size(44, 18);
            dateLabel6.TabIndex = 72;
            dateLabel6.Text = "None";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(5, 200);
            label1.Name = "label1";
            label1.Size = new Size(47, 17);
            label1.TabIndex = 72;
            label1.Text = "Date:";
            // 
            // descLabel4
            // 
            descLabel4.AutoSize = true;
            descLabel4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            descLabel4.Location = new Point(193, 134);
            descLabel4.Name = "descLabel4";
            descLabel4.Size = new Size(44, 18);
            descLabel4.TabIndex = 56;
            descLabel4.Text = "None";
            // 
            // damageLabel3
            // 
            damageLabel3.AutoSize = true;
            damageLabel3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            damageLabel3.Location = new Point(193, 101);
            damageLabel3.Name = "damageLabel3";
            damageLabel3.Size = new Size(44, 18);
            damageLabel3.TabIndex = 56;
            damageLabel3.Text = "None";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(5, 68);
            label13.Name = "label13";
            label13.Size = new Size(70, 17);
            label13.TabIndex = 44;
            label13.Text = "Room ID";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(5, 101);
            label14.Name = "label14";
            label14.Size = new Size(112, 17);
            label14.TabIndex = 46;
            label14.Text = "Damage Type:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(5, 134);
            label16.Name = "label16";
            label16.Size = new Size(97, 17);
            label16.TabIndex = 47;
            label16.Text = "Description:";
            // 
            // roomLabel2
            // 
            roomLabel2.AutoSize = true;
            roomLabel2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomLabel2.Location = new Point(193, 68);
            roomLabel2.Name = "roomLabel2";
            roomLabel2.Size = new Size(44, 18);
            roomLabel2.TabIndex = 54;
            roomLabel2.Text = "None";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(5, 35);
            label21.Name = "label21";
            label21.Size = new Size(139, 17);
            label21.TabIndex = 49;
            label21.Text = "Room Damage ID:";
            // 
            // roomDamageLabel1
            // 
            roomDamageLabel1.AutoSize = true;
            roomDamageLabel1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomDamageLabel1.Location = new Point(193, 35);
            roomDamageLabel1.Name = "roomDamageLabel1";
            roomDamageLabel1.Size = new Size(44, 18);
            roomDamageLabel1.TabIndex = 56;
            roomDamageLabel1.Text = "None";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(5, 167);
            label22.Name = "label22";
            label22.Size = new Size(121, 17);
            label22.TabIndex = 43;
            label22.Text = "Total Damages:";
            // 
            // totalLabel5
            // 
            totalLabel5.AutoSize = true;
            totalLabel5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            totalLabel5.Location = new Point(193, 167);
            totalLabel5.Name = "totalLabel5";
            totalLabel5.Size = new Size(44, 18);
            totalLabel5.TabIndex = 53;
            totalLabel5.Text = "None";
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
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 52);
            panel1.TabIndex = 71;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLight;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(359, 34);
            label10.TabIndex = 0;
            label10.Text = "Room Damages History";
            // 
            // roomDamagesHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1152, 753);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(reportButton);
            Controls.Add(applyButton);
            Controls.Add(searchCBox);
            Controls.Add(searchTBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rDHData);
            Name = "roomDamagesHistoryForm";
            Text = "roomDamagesHistoryForm";
            ((System.ComponentModel.ISupportInitialize)rDHData).EndInit();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox searchCBox;
        private TextBox searchTBox;
        private Label label3;
        private Label label2;
        private DataGridView rDHData;
        private Button reportButton;
        private Button applyButton;
        private TableLayoutPanel tableLayoutPanel5;
        private Label descLabel4;
        private Label damageLabel3;
        private Label label13;
        private Label label14;
        private Label label16;
        private Label roomLabel2;
        private Label label21;
        private Label roomDamageLabel1;
        private Label label22;
        private Label totalLabel5;
        private Label label20;
        private Panel panel1;
        private Label label10;
        private Label dateLabel6;
        private Label label1;
    }
}