namespace QSevenManagementSystem
{
    partial class createRoomForm2
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
            roomIDLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            okButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // roomIDLabel
            // 
            roomIDLabel.AutoSize = true;
            roomIDLabel.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomIDLabel.Location = new Point(486, 292);
            roomIDLabel.Name = "roomIDLabel";
            roomIDLabel.Size = new Size(100, 17);
            roomIDLabel.TabIndex = 30;
            roomIDLabel.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(279, 292);
            label3.Name = "label3";
            label3.Size = new Size(75, 17);
            label3.TabIndex = 28;
            label3.Text = "Room ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(279, 219);
            label2.Name = "label2";
            label2.Size = new Size(197, 17);
            label2.TabIndex = 27;
            label2.Text = "A room has been created!";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 52);
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
            label1.Size = new Size(402, 34);
            label1.TabIndex = 0;
            label1.Text = "Room Form (2): Confirmed";
            // 
            // okButton
            // 
            okButton.BackColor = SystemColors.ButtonHighlight;
            okButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            okButton.ForeColor = SystemColors.ActiveCaptionText;
            okButton.Location = new Point(956, 650);
            okButton.Name = "okButton";
            okButton.Size = new Size(90, 44);
            okButton.TabIndex = 45;
            okButton.Text = "OKE";
            okButton.UseVisualStyleBackColor = false;
            okButton.Click += okButton_Click;
            // 
            // createRoomForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1152, 753);
            Controls.Add(okButton);
            Controls.Add(panel1);
            Controls.Add(roomIDLabel);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "createRoomForm2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "createRoomForm2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label roomIDLabel;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button okButton;
    }
}