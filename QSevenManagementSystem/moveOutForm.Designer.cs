namespace QSevenManagementSystem
{
    partial class moveOutForm
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
            label2 = new Label();
            moveOutDate = new DateTimePicker();
            confirmButton = new Button();
            label3 = new Label();
            renterLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(597, 39);
            panel1.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(186, 28);
            label1.TabIndex = 0;
            label1.Text = "Move Out Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(46, 121);
            label2.Name = "label2";
            label2.Size = new Size(92, 14);
            label2.TabIndex = 37;
            label2.Text = "Move Out Date";
            // 
            // moveOutDate
            // 
            moveOutDate.Location = new Point(173, 116);
            moveOutDate.Margin = new Padding(3, 2, 3, 2);
            moveOutDate.Name = "moveOutDate";
            moveOutDate.Size = new Size(237, 23);
            moveOutDate.TabIndex = 39;
            // 
            // confirmButton
            // 
            confirmButton.BackColor = Color.DarkSeaGreen;
            confirmButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            confirmButton.Location = new Point(480, 212);
            confirmButton.Margin = new Padding(3, 2, 3, 2);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(90, 32);
            confirmButton.TabIndex = 40;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = false;
            confirmButton.Click += confirmButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 89);
            label3.Name = "label3";
            label3.Size = new Size(66, 14);
            label3.TabIndex = 41;
            label3.Text = "Renter ID:";
            // 
            // renterLabel
            // 
            renterLabel.AutoSize = true;
            renterLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            renterLabel.Location = new Point(173, 89);
            renterLabel.Name = "renterLabel";
            renterLabel.Size = new Size(37, 15);
            renterLabel.TabIndex = 42;
            renterLabel.Text = "None";
            // 
            // moveOutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(597, 265);
            Controls.Add(renterLabel);
            Controls.Add(label3);
            Controls.Add(confirmButton);
            Controls.Add(moveOutDate);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "moveOutForm";
            Text = "moveOutForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private DateTimePicker moveOutDate;
        private Button confirmButton;
        private Label label3;
        private Label renterLabel;
    }
}