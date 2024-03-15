namespace QSevenManagementSystem
{
    partial class calculateElec
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
            label1 = new Label();
            meterStartMonthTBox = new TextBox();
            meterEndMonthTBox = new TextBox();
            label2 = new Label();
            confirmButton = new Button();
            panel1 = new Panel();
            label6 = new Label();
            startMonthButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 131);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 0;
            label1.Text = "Start month meter";
            // 
            // meterStartMonthTBox
            // 
            meterStartMonthTBox.Location = new Point(288, 128);
            meterStartMonthTBox.Name = "meterStartMonthTBox";
            meterStartMonthTBox.Size = new Size(125, 27);
            meterStartMonthTBox.TabIndex = 1;
            // 
            // meterEndMonthTBox
            // 
            meterEndMonthTBox.Location = new Point(288, 179);
            meterEndMonthTBox.Name = "meterEndMonthTBox";
            meterEndMonthTBox.Size = new Size(125, 27);
            meterEndMonthTBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 182);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 2;
            label2.Text = "End month meter";
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.DarkSeaGreen;
            confirmButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            confirmButton.Location = new Point(527, 279);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(103, 42);
            confirmButton.TabIndex = 84;
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
            panel1.Size = new Size(682, 52);
            panel1.TabIndex = 85;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(603, 34);
            label6.TabIndex = 0;
            label6.Text = "Generate DPN (2): Electricity Bill Details";
            // 
            // startMonthButton
            // 
            startMonthButton.BackColor = Color.LightBlue;
            startMonthButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            startMonthButton.Location = new Point(419, 120);
            startMonthButton.Name = "startMonthButton";
            startMonthButton.Size = new Size(198, 42);
            startMonthButton.TabIndex = 87;
            startMonthButton.Text = "Get latest meter reading";
            startMonthButton.UseVisualStyleBackColor = false;
            startMonthButton.Click += startMonthButton_Click;
            // 
            // calculateElec
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 353);
            Controls.Add(startMonthButton);
            Controls.Add(panel1);
            Controls.Add(confirmButton);
            Controls.Add(meterEndMonthTBox);
            Controls.Add(label2);
            Controls.Add(meterStartMonthTBox);
            Controls.Add(label1);
            Name = "calculateElec";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "calculateElec";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox meterStartMonthTBox;
        private TextBox meterEndMonthTBox;
        private Label label2;
        private Button confirmButton;
        private Panel panel1;
        private Label label6;
        private Button startMonthButton;
    }
}