namespace QSevenManagementSystem
{
    partial class rentersHistoryForm
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            rentersData = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)rentersData).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(888, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 25);
            comboBox1.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(611, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 25);
            textBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(857, 80);
            label3.Name = "label3";
            label3.Size = new Size(27, 17);
            label3.TabIndex = 9;
            label3.Text = "By";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(548, 77);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 8;
            label2.Text = "Search ";
            // 
            // rentersData
            // 
            rentersData.AllowUserToAddRows = false;
            rentersData.AllowUserToDeleteRows = false;
            rentersData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rentersData.Location = new Point(79, 146);
            rentersData.Name = "rentersData";
            rentersData.ReadOnly = true;
            rentersData.RowHeadersWidth = 51;
            rentersData.RowTemplate.Height = 29;
            rentersData.Size = new Size(586, 525);
            rentersData.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 77);
            label1.Name = "label1";
            label1.Size = new Size(122, 17);
            label1.TabIndex = 6;
            label1.Text = "Renters History";
            // 
            // rentersHistoryForm
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
            Name = "rentersHistoryForm";
            Text = "rentersHistoryForm";
            ((System.ComponentModel.ISupportInitialize)rentersData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private DataGridView rentersData;
        private Label label1;
    }
}