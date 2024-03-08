namespace QSevenManagementSystem
{
    partial class registrationForm3
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
            label1 = new Label();
            renterLabel = new Label();
            label6 = new Label();
            registrationLabel = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            nextButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 52);
            panel1.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(497, 34);
            label1.TabIndex = 0;
            label1.Text = "Registration Form (3): Confirmed";
            // 
            // renterLabel
            // 
            renterLabel.AutoSize = true;
            renterLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            renterLabel.Location = new Point(436, 278);
            renterLabel.Name = "renterLabel";
            renterLabel.Size = new Size(46, 17);
            renterLabel.TabIndex = 26;
            renterLabel.Text = "None";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(229, 484);
            label6.Name = "label6";
            label6.Size = new Size(0, 17);
            label6.TabIndex = 25;
            // 
            // registrationLabel
            // 
            registrationLabel.AutoSize = true;
            registrationLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            registrationLabel.Location = new Point(436, 241);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(46, 17);
            registrationLabel.TabIndex = 24;
            registrationLabel.Text = "None";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(229, 278);
            label4.Name = "label4";
            label4.Size = new Size(83, 17);
            label4.TabIndex = 23;
            label4.Text = "Renter ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(229, 241);
            label3.Name = "label3";
            label3.Size = new Size(122, 17);
            label3.TabIndex = 22;
            label3.Text = "Registration ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(229, 168);
            label2.Name = "label2";
            label2.Size = new Size(224, 17);
            label2.TabIndex = 21;
            label2.Text = "A renter has been registered!";
            // 
            // nextButton
            // 
            nextButton.BackColor = SystemColors.ButtonHighlight;
            nextButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nextButton.ForeColor = SystemColors.ActiveCaptionText;
            nextButton.Location = new Point(956, 650);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(90, 44);
            nextButton.TabIndex = 35;
            nextButton.Text = "OKE";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // registrationForm3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1152, 753);
            Controls.Add(nextButton);
            Controls.Add(panel1);
            Controls.Add(renterLabel);
            Controls.Add(label6);
            Controls.Add(registrationLabel);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "registrationForm3";
            Text = "registrationForm3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label1;
        private Label renterLabel;
        private Label label6;
        private Label registrationLabel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button nextButton;
    }
}