namespace QSevenManagementSystem
{
    partial class changeRateForm
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
            txtRate = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel1 = new Panel();
            label3 = new Label();
            applyButton = new Button();
            cancelButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(211, 110);
            label1.Name = "label1";
            label1.Size = new Size(214, 29);
            label1.TabIndex = 0;
            label1.Text = "Change bill rate to:";
            // 
            // txtRate
            // 
            txtRate.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtRate.Location = new Point(224, 156);
            txtRate.Name = "txtRate";
            txtRate.Size = new Size(182, 34);
            txtRate.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(198, 202);
            label2.Name = "label2";
            label2.Size = new Size(241, 29);
            label2.TabIndex = 2;
            label2.Text = "Change bill rate date:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(191, 251);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(258, 27);
            dateTimePicker1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-2, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 60);
            panel1.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 10);
            label3.Name = "label3";
            label3.Size = new Size(259, 34);
            label3.TabIndex = 0;
            label3.Text = "Change Bill Rate";
            // 
            // applyButton
            // 
            applyButton.BackColor = Color.DarkSeaGreen;
            applyButton.Location = new Point(198, 317);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(107, 40);
            applyButton.TabIndex = 5;
            applyButton.Text = "APPLY";
            applyButton.UseVisualStyleBackColor = false;
            applyButton.Click += applyButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.LightCoral;
            cancelButton.Location = new Point(332, 317);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(107, 40);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "CANCEL";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // changeRateForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 369);
            Controls.Add(cancelButton);
            Controls.Add(applyButton);
            Controls.Add(panel1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(txtRate);
            Controls.Add(label1);
            Name = "changeRateForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "changeRateForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtRate;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Panel panel1;
        private Label label3;
        private Button applyButton;
        private Button cancelButton;
    }
}