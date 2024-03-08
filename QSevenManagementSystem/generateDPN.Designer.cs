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
            label2 = new Label();
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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)roomData).BeginInit();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 307);
            label2.Name = "label2";
            label2.Size = new Size(114, 17);
            label2.TabIndex = 80;
            label2.Text = "Select a room:";
            // 
            // roomData
            // 
            roomData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomData.Location = new Point(74, 327);
            roomData.Name = "roomData";
            roomData.RowHeadersWidth = 51;
            roomData.RowTemplate.Height = 29;
            roomData.Size = new Size(464, 302);
            roomData.TabIndex = 79;
            // 
            // monthCBox
            // 
            monthCBox.FormattingEnabled = true;
            monthCBox.Location = new Point(791, 186);
            monthCBox.Name = "monthCBox";
            monthCBox.Size = new Size(151, 28);
            monthCBox.TabIndex = 78;
            // 
            // issuedDate
            // 
            issuedDate.Location = new Point(791, 230);
            issuedDate.Name = "issuedDate";
            issuedDate.Size = new Size(262, 27);
            issuedDate.TabIndex = 77;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(601, 237);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 76;
            label3.Text = "Date issued";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(602, 191);
            label9.Name = "label9";
            label9.Size = new Size(127, 17);
            label9.TabIndex = 72;
            label9.Text = "For the month of";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(602, 153);
            label10.Name = "label10";
            label10.Size = new Size(94, 17);
            label10.TabIndex = 71;
            label10.Text = "DPN Details";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(74, 152);
            label11.Name = "label11";
            label11.Size = new Size(151, 17);
            label11.TabIndex = 70;
            label11.Text = "Registration Details";
            // 
            // roomTBox
            // 
            roomTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomTBox.Location = new Point(263, 182);
            roomTBox.Name = "roomTBox";
            roomTBox.Size = new Size(47, 25);
            roomTBox.TabIndex = 69;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(74, 185);
            label12.Name = "label12";
            label12.Size = new Size(70, 17);
            label12.TabIndex = 68;
            label12.Text = "Room ID";
            // 
            // priceTBox
            // 
            priceTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            priceTBox.Location = new Point(263, 249);
            priceTBox.Name = "priceTBox";
            priceTBox.Size = new Size(112, 25);
            priceTBox.TabIndex = 91;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(74, 249);
            label13.Name = "label13";
            label13.Size = new Size(92, 17);
            label13.TabIndex = 90;
            label13.Text = "Room price";
            // 
            // registrationTBox
            // 
            registrationTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            registrationTBox.Location = new Point(263, 215);
            registrationTBox.Name = "registrationTBox";
            registrationTBox.Size = new Size(47, 25);
            registrationTBox.TabIndex = 93;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(74, 218);
            label14.Name = "label14";
            label14.Size = new Size(117, 17);
            label14.TabIndex = 92;
            label14.Text = "Registration ID";
            // 
            // depositCheckBox
            // 
            depositCheckBox.AutoSize = true;
            depositCheckBox.Location = new Point(604, 280);
            depositCheckBox.Name = "depositCheckBox";
            depositCheckBox.Size = new Size(118, 24);
            depositCheckBox.TabIndex = 95;
            depositCheckBox.Text = "Deposit used";
            depositCheckBox.UseVisualStyleBackColor = true;
            // 
            // generateDPN
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1152, 753);
            Controls.Add(depositCheckBox);
            Controls.Add(registrationTBox);
            Controls.Add(label14);
            Controls.Add(priceTBox);
            Controls.Add(label13);
            Controls.Add(panel1);
            Controls.Add(confirmButton);
            Controls.Add(label2);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Button confirmButton;
        private Label label2;
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
    }
}