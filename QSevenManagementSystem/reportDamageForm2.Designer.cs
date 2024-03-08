namespace QSevenManagementSystem
{
    partial class reportDamageForm2
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
            okButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
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
            panel1.TabIndex = 42;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(548, 34);
            label1.TabIndex = 0;
            label1.Text = "Report Damage Form (2): Confirmed";
            // 
            // okButton
            // 
            okButton.BackColor = SystemColors.ButtonHighlight;
            okButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            okButton.ForeColor = SystemColors.ActiveCaptionText;
            okButton.Location = new Point(956, 679);
            okButton.Name = "okButton";
            okButton.Size = new Size(90, 44);
            okButton.TabIndex = 43;
            okButton.Text = "OKE";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += okButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(229, 513);
            label6.Name = "label6";
            label6.Size = new Size(0, 17);
            label6.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(436, 270);
            label5.Name = "label5";
            label5.Size = new Size(100, 17);
            label5.TabIndex = 39;
            label5.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(229, 270);
            label3.Name = "label3";
            label3.Size = new Size(93, 17);
            label3.TabIndex = 37;
            label3.Text = "Damage ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(229, 197);
            label2.Name = "label2";
            label2.Size = new Size(224, 17);
            label2.TabIndex = 36;
            label2.Text = "A renter has been registered!";
            // 
            // reportDamageForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1152, 753);
            Controls.Add(panel1);
            Controls.Add(okButton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "reportDamageForm2";
            Text = "reportDamageForm2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button okButton;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
    }
}