﻿namespace QSevenManagementSystem
{
    partial class otherChargesForm
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
            totalTBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            descriptionTBox = new RichTextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 39);
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
            label6.Size = new Size(399, 28);
            label6.TabIndex = 0;
            label6.Text = "Generate DPN (4): Other Charges";
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.DarkSeaGreen;
            confirmButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            confirmButton.Location = new Point(461, 221);
            confirmButton.Margin = new Padding(3, 2, 3, 2);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(90, 32);
            confirmButton.TabIndex = 92;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // totalTBox
            // 
            totalTBox.Location = new Point(252, 167);
            totalTBox.Margin = new Padding(3, 2, 3, 2);
            totalTBox.Name = "totalTBox";
            totalTBox.Size = new Size(110, 23);
            totalTBox.TabIndex = 90;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 170);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 89;
            label2.Text = "Total:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 76);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 87;
            label1.Text = "Description:";
            // 
            // descriptionTBox
            // 
            descriptionTBox.Location = new Point(252, 76);
            descriptionTBox.Margin = new Padding(3, 2, 3, 2);
            descriptionTBox.Name = "descriptionTBox";
            descriptionTBox.Size = new Size(196, 74);
            descriptionTBox.TabIndex = 95;
            descriptionTBox.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(367, 170);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 96;
            label3.Text = "pesos";
            // 
            // otherChargesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(597, 265);
            Controls.Add(label3);
            Controls.Add(descriptionTBox);
            Controls.Add(panel1);
            Controls.Add(confirmButton);
            Controls.Add(totalTBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "otherChargesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "otherChargesForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Label label6;
        private Button confirmButton;
        private TextBox totalTBox;
        private Label label2;
        private Label label1;
        private RichTextBox descriptionTBox;
        private Label label3;
    }
}