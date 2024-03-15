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
            label4 = new Label();
            dpnData = new DataGridView();
            label5 = new Label();
            receiptData = new DataGridView();
            billData = new DataGridView();
            otherChargesData = new DataGridView();
            panel1 = new Panel();
            label1 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dpnData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)receiptData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)billData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)otherChargesData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(353, 67);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 25);
            comboBox1.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(76, 67);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 25);
            textBox1.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(322, 73);
            label3.Name = "label3";
            label3.Size = new Size(27, 17);
            label3.TabIndex = 15;
            label3.Text = "By";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 70);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 14;
            label2.Text = "Search ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 101);
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
            dpnData.Location = new Point(12, 121);
            dpnData.Name = "dpnData";
            dpnData.ReadOnly = true;
            dpnData.RowHeadersWidth = 51;
            dpnData.RowTemplate.Height = 29;
            dpnData.Size = new Size(505, 277);
            dpnData.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 446);
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
            receiptData.Location = new Point(13, 466);
            receiptData.Name = "receiptData";
            receiptData.ReadOnly = true;
            receiptData.RowHeadersWidth = 51;
            receiptData.RowTemplate.Height = 29;
            receiptData.Size = new Size(505, 275);
            receiptData.TabIndex = 23;
            // 
            // billData
            // 
            billData.AllowUserToAddRows = false;
            billData.AllowUserToDeleteRows = false;
            billData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            billData.Location = new Point(595, 121);
            billData.Name = "billData";
            billData.ReadOnly = true;
            billData.RowHeadersWidth = 51;
            billData.RowTemplate.Height = 29;
            billData.Size = new Size(505, 277);
            billData.TabIndex = 25;
            // 
            // otherChargesData
            // 
            otherChargesData.AllowUserToAddRows = false;
            otherChargesData.AllowUserToDeleteRows = false;
            otherChargesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            otherChargesData.Location = new Point(595, 466);
            otherChargesData.Name = "otherChargesData";
            otherChargesData.ReadOnly = true;
            otherChargesData.RowHeadersWidth = 51;
            otherChargesData.RowTemplate.Height = 29;
            otherChargesData.Size = new Size(505, 275);
            otherChargesData.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 52);
            panel1.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(272, 34);
            label1.TabIndex = 0;
            label1.Text = "Payments History";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(595, 101);
            label6.Name = "label6";
            label6.Size = new Size(196, 17);
            label6.TabIndex = 40;
            label6.Text = "Electricity and Water Bills";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(595, 446);
            label7.Name = "label7";
            label7.Size = new Size(116, 17);
            label7.TabIndex = 41;
            label7.Text = "Other Charges";
            // 
            // paymentsHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1152, 753);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(otherChargesData);
            Controls.Add(billData);
            Controls.Add(label5);
            Controls.Add(receiptData);
            Controls.Add(label4);
            Controls.Add(dpnData);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "paymentsHistoryForm";
            Text = "paymentsHistoryForm";
            ((System.ComponentModel.ISupportInitialize)dpnData).EndInit();
            ((System.ComponentModel.ISupportInitialize)receiptData).EndInit();
            ((System.ComponentModel.ISupportInitialize)billData).EndInit();
            ((System.ComponentModel.ISupportInitialize)otherChargesData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label5;
        private DataGridView receiptData;
        private Label label4;
        private DataGridView dpnData;
        private DataGridView billData;
        private DataGridView otherChargesData;
        private Panel panel1;
        private Label label1;
        private Label label6;
        private Label label7;
    }
}