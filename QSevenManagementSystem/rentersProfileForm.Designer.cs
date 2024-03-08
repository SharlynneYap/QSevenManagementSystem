namespace QSevenManagementSystem
{
    partial class rentersProfileForm
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
            rentersData = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)rentersData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(92, 58);
            label1.Name = "label1";
            label1.Size = new Size(118, 17);
            label1.TabIndex = 0;
            label1.Text = "Renters Profile";
            // 
            // rentersData
            // 
            rentersData.AllowUserToAddRows = false;
            rentersData.AllowUserToDeleteRows = false;
            rentersData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rentersData.Location = new Point(92, 127);
            rentersData.Name = "rentersData";
            rentersData.ReadOnly = true;
            rentersData.RowHeadersWidth = 51;
            rentersData.RowTemplate.Height = 29;
            rentersData.Size = new Size(602, 527);
            rentersData.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(561, 58);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 2;
            label2.Text = "Search ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(870, 61);
            label3.Name = "label3";
            label3.Size = new Size(27, 17);
            label3.TabIndex = 3;
            label3.Text = "By";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(624, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 25);
            textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(901, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 25);
            comboBox1.TabIndex = 5;
            // 
            // rentersProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1132, 753);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(rentersData);
            Controls.Add(label1);
            Name = "rentersProfileForm";
            Text = "rentersProfile";
            ((System.ComponentModel.ISupportInitialize)rentersData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView rentersData;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}