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
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            confirmButton = new Button();
            panel1 = new Panel();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)roomsData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // rdDate
            // 
            rdDate.Location = new Point(783, 322);
            rdDate.Name = "rdDate";
            rdDate.Size = new Size(262, 27);
            rdDate.TabIndex = 59;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(594, 332);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 58;
            label3.Text = "Date";
            // 
            // totalTBox
            // 
            totalTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            totalTBox.Location = new Point(783, 276);
            totalTBox.Name = "totalTBox";
            totalTBox.Size = new Size(112, 25);
            totalTBox.TabIndex = 57;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(594, 279);
            label1.Name = "label1";
            label1.Size = new Size(106, 17);
            label1.TabIndex = 56;
            label1.Text = "Total damage";
            // 
            // descTBox
            // 
            descTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            descTBox.Location = new Point(783, 231);
            descTBox.Name = "descTBox";
            descTBox.Size = new Size(281, 25);
            descTBox.TabIndex = 55;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(594, 231);
            label9.Name = "label9";
            label9.Size = new Size(92, 17);
            label9.TabIndex = 54;
            label9.Text = "Description";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(594, 184);
            label10.Name = "label10";
            label10.Size = new Size(103, 17);
            label10.TabIndex = 52;
            label10.Text = "Damage type";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(74, 141);
            label11.Name = "label11";
            label11.Size = new Size(104, 17);
            label11.TabIndex = 51;
            label11.Text = "Room Details";
            // 
            // roomIdTBox
            // 
            roomIdTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomIdTBox.Location = new Point(263, 175);
            roomIdTBox.Name = "roomIdTBox";
            roomIdTBox.Size = new Size(47, 25);
            roomIdTBox.TabIndex = 50;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(74, 178);
            label12.Name = "label12";
            label12.Size = new Size(70, 17);
            label12.TabIndex = 49;
            label12.Text = "Room ID";
            // 
            // damageCBox
            // 
            damageCBox.FormattingEnabled = true;
            damageCBox.Location = new Point(783, 179);
            damageCBox.Name = "damageCBox";
            damageCBox.Size = new Size(151, 28);
            damageCBox.TabIndex = 61;
            // 
            // roomsData
            // 
            roomsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomsData.Location = new Point(74, 235);
            roomsData.Name = "roomsData";
            roomsData.RowHeadersWidth = 51;
            roomsData.RowTemplate.Height = 29;
            roomsData.Size = new Size(464, 302);
            roomsData.TabIndex = 62;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 215);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 63;
            label2.Text = "Select a room:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(591, 141);
            label4.Name = "label4";
            label4.Size = new Size(122, 17);
            label4.TabIndex = 64;
            label4.Text = "Damage Details";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(912, 279);
            label5.Name = "label5";
            label5.Size = new Size(51, 17);
            label5.TabIndex = 65;
            label5.Text = "pesos";
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.DarkSeaGreen;
            confirmButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            confirmButton.Location = new Point(961, 618);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(103, 42);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 52);
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
            label6.Size = new Size(626, 34);
            label6.TabIndex = 0;
            label6.Text = "Report Damage Form (2): Damage Details";
            // 
            // reportDamageForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1152, 753);
            Controls.Add(panel1);
            Controls.Add(confirmButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
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
            Name = "reportDamageForm";
            Text = "reportDamageForm";
            ((System.ComponentModel.ISupportInitialize)roomsData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label2;
        private Label label4;
        private Label label5;
        private Button confirmButton;
        private Panel panel1;
        private Label label6;
    }
}