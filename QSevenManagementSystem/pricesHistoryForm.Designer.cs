namespace QSevenManagementSystem
{
    partial class pricesHistoryForm
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
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            pricesData = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            rateData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)pricesData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rateData).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(79, 78);
            label2.Name = "label2";
            label2.Size = new Size(111, 17);
            label2.TabIndex = 9;
            label2.Text = "Prices History";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(548, 81);
            label1.Name = "label1";
            label1.Size = new Size(65, 17);
            label1.TabIndex = 14;
            label1.Text = "Search ";
            // 
            // pricesData
            // 
            pricesData.AllowUserToAddRows = false;
            pricesData.AllowUserToDeleteRows = false;
            pricesData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pricesData.Location = new Point(79, 150);
            pricesData.Name = "pricesData";
            pricesData.ReadOnly = true;
            pricesData.RowHeadersWidth = 51;
            pricesData.RowTemplate.Height = 29;
            pricesData.Size = new Size(894, 201);
            pricesData.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(79, 130);
            label4.Name = "label4";
            label4.Size = new Size(93, 17);
            label4.TabIndex = 18;
            label4.Text = "Room Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(79, 431);
            label5.Name = "label5";
            label5.Size = new Size(69, 17);
            label5.TabIndex = 20;
            label5.Text = "Bill Rate";
            // 
            // rateData
            // 
            rateData.AllowUserToAddRows = false;
            rateData.AllowUserToDeleteRows = false;
            rateData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rateData.Location = new Point(79, 451);
            rateData.Name = "rateData";
            rateData.ReadOnly = true;
            rateData.RowHeadersWidth = 51;
            rateData.RowTemplate.Height = 29;
            rateData.Size = new Size(894, 211);
            rateData.TabIndex = 19;
            // 
            // pricesHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1132, 753);
            Controls.Add(label5);
            Controls.Add(rateData);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pricesData);
            Controls.Add(label2);
            Name = "pricesHistoryForm";
            Text = "pricesHistoryForm";
            ((System.ComponentModel.ISupportInitialize)pricesData).EndInit();
            ((System.ComponentModel.ISupportInitialize)rateData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label1;
        private DataGridView pricesData;
        private Label label4;
        private Label label5;
        private DataGridView rateData;
    }
}