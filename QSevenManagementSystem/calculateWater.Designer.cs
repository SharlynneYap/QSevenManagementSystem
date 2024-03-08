namespace QSevenManagementSystem
{
    partial class calculateWater
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
            label3 = new Label();
            meterEndMonthTBox = new TextBox();
            label2 = new Label();
            meterStartMonthTBox = new TextBox();
            label1 = new Label();
            billRateLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 52);
            panel1.TabIndex = 93;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(542, 34);
            label6.TabIndex = 0;
            label6.Text = "Generate DPN (3): Water Bill Details";
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.DarkSeaGreen;
            confirmButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            confirmButton.Location = new Point(524, 275);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(103, 42);
            confirmButton.TabIndex = 92;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(87, 236);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 90;
            label3.Text = "Bill rate";
            // 
            // meterEndMonthTBox
            // 
            meterEndMonthTBox.Location = new Point(269, 175);
            meterEndMonthTBox.Name = "meterEndMonthTBox";
            meterEndMonthTBox.Size = new Size(125, 27);
            meterEndMonthTBox.TabIndex = 89;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(87, 178);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 88;
            label2.Text = "End month meter";
            // 
            // meterStartMonthTBox
            // 
            meterStartMonthTBox.Location = new Point(269, 124);
            meterStartMonthTBox.Name = "meterStartMonthTBox";
            meterStartMonthTBox.Size = new Size(125, 27);
            meterStartMonthTBox.TabIndex = 87;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 127);
            label1.Name = "label1";
            label1.Size = new Size(130, 20);
            label1.TabIndex = 86;
            label1.Text = "Start month meter";
            // 
            // billRateLabel
            // 
            billRateLabel.AutoSize = true;
            billRateLabel.Location = new Point(269, 236);
            billRateLabel.Name = "billRateLabel";
            billRateLabel.Size = new Size(45, 20);
            billRateLabel.TabIndex = 94;
            billRateLabel.Text = "None";
            // 
            // calculateWater
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 353);
            Controls.Add(billRateLabel);
            Controls.Add(panel1);
            Controls.Add(confirmButton);
            Controls.Add(label3);
            Controls.Add(meterEndMonthTBox);
            Controls.Add(label2);
            Controls.Add(meterStartMonthTBox);
            Controls.Add(label1);
            Name = "calculateWater";
            Text = "calculateWater";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Button confirmButton;
        private Label label3;
        private TextBox meterEndMonthTBox;
        private Label label2;
        private TextBox meterStartMonthTBox;
        private Label label1;
        private Label billRateLabel;
    }
}