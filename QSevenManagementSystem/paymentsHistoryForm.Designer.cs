namespace QSevenManagementSystem
{
    partial class paymentsHistoryForm
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
            label1 = new Label();
            label4 = new Label();
            dpnData = new DataGridView();
            label5 = new Label();
            receiptData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dpnData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)receiptData).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(888, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 25);
            comboBox1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(611, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 25);
            textBox1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(857, 84);
            label3.Name = "label3";
            label3.Size = new Size(27, 17);
            label3.TabIndex = 15;
            label3.Text = "By";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(548, 81);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 14;
            label2.Text = "Search ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 81);
            label1.Name = "label1";
            label1.Size = new Size(135, 17);
            label1.TabIndex = 12;
            label1.Text = "Payments History";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(79, 149);
            label4.Name = "label4";
            label4.Size = new Size(40, 17);
            label4.TabIndex = 22;
            label4.Text = "DPN";
            // 
            // dpnData
            // 
            dpnData.AllowUserToAddRows = false;
            dpnData.AllowUserToDeleteRows = false;
            dpnData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dpnData.Location = new Point(79, 169);
            dpnData.Name = "dpnData";
            dpnData.ReadOnly = true;
            dpnData.RowHeadersWidth = 51;
            dpnData.RowTemplate.Height = 29;
            dpnData.Size = new Size(974, 181);
            dpnData.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(79, 459);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 24;
            label5.Text = "Receipt";
            // 
            // receiptData
            // 
            receiptData.AllowUserToAddRows = false;
            receiptData.AllowUserToDeleteRows = false;
            receiptData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            receiptData.Location = new Point(79, 489);
            receiptData.Name = "receiptData";
            receiptData.ReadOnly = true;
            receiptData.RowHeadersWidth = 51;
            receiptData.RowTemplate.Height = 29;
            receiptData.Size = new Size(974, 181);
            receiptData.TabIndex = 23;
            // 
            // paymentsHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1132, 753);
            Controls.Add(label5);
            Controls.Add(receiptData);
            Controls.Add(label4);
            Controls.Add(dpnData);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "paymentsHistoryForm";
            Text = "paymentsHistoryForm";
            ((System.ComponentModel.ISupportInitialize)dpnData).EndInit();
            ((System.ComponentModel.ISupportInitialize)receiptData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private DataGridView receiptData;
        private Label label4;
        private DataGridView dpnData;
    }
}