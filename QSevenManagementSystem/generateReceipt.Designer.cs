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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dpnData).BeginInit();
            SuspendLayout();
            // 
            // amountTBox
            // 
            amountTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            amountTBox.Location = new Point(783, 460);
            amountTBox.Name = "amountTBox";
            amountTBox.Size = new Size(112, 25);
            amountTBox.TabIndex = 114;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(594, 463);
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
            label4.Location = new Point(596, 424);
            label4.Name = "label4";
            label4.Size = new Size(125, 17);
            label4.TabIndex = 104;
            label4.Text = "Payment Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(74, 284);
            label2.Name = "label2";
            label2.Size = new Size(103, 17);
            label2.TabIndex = 103;
            label2.Text = "Select a DPN";
            // 
            // dpnData
            // 
            dpnData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dpnData.Location = new Point(74, 304);
            dpnData.Name = "dpnData";
            dpnData.RowHeadersWidth = 51;
            dpnData.RowTemplate.Height = 29;
            dpnData.Size = new Size(464, 302);
            dpnData.TabIndex = 102;
            // 
            // issuedDate
            // 
            issuedDate.Location = new Point(783, 317);
            issuedDate.Name = "issuedDate";
            issuedDate.Size = new Size(262, 27);
            issuedDate.TabIndex = 100;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(593, 324);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 99;
            label3.Text = "Date issued";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(594, 288);
            label10.Name = "label10";
            label10.Size = new Size(118, 17);
            label10.TabIndex = 95;
            label10.Text = "Receipt Details";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(74, 210);
            label11.Name = "label11";
            label11.Size = new Size(94, 17);
            label11.TabIndex = 94;
            label11.Text = "DPN Details";
            // 
            // dpnIdTBox
            // 
            dpnIdTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dpnIdTBox.Location = new Point(263, 244);
            dpnIdTBox.Name = "dpnIdTBox";
            dpnIdTBox.Size = new Size(47, 25);
            dpnIdTBox.TabIndex = 93;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(74, 247);
            label12.Name = "label12";
            label12.Size = new Size(60, 17);
            label12.TabIndex = 92;
            label12.Text = "DPN ID";
            // 
            // generateReceipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1152, 753);
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
    }
}