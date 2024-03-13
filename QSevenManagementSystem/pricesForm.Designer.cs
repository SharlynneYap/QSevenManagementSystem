namespace QSevenManagementSystem
{
    partial class pricesForm
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
            priceData = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            elecTBox = new TextBox();
            waterTBox = new TextBox();
            label6 = new Label();
            priceTBox = new TextBox();
            roomTBox = new Label();
            roomIdTBox = new TextBox();
            label8 = new Label();
            applyRoomButton = new Button();
            label10 = new Label();
            priceDate = new DateTimePicker();
            changeElecBillBtn = new Button();
            changeWaterBillBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)priceData).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(888, 77);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 25);
            comboBox1.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(611, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 25);
            textBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(857, 83);
            label3.Name = "label3";
            label3.Size = new Size(27, 17);
            label3.TabIndex = 9;
            label3.Text = "By";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(548, 80);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 8;
            label2.Text = "Search ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(79, 80);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 6;
            label1.Text = "Prices";
            // 
            // priceData
            // 
            priceData.AllowUserToAddRows = false;
            priceData.AllowUserToDeleteRows = false;
            priceData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            priceData.Location = new Point(79, 149);
            priceData.Name = "priceData";
            priceData.ReadOnly = true;
            priceData.RowHeadersWidth = 51;
            priceData.RowTemplate.Height = 29;
            priceData.Size = new Size(546, 489);
            priceData.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(79, 120);
            label4.Name = "label4";
            label4.Size = new Size(157, 17);
            label4.TabIndex = 12;
            label4.Text = "Current room prices";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(676, 398);
            label5.Name = "label5";
            label5.Size = new Size(201, 17);
            label5.TabIndex = 13;
            label5.Text = "Current electricity bill rate";
            // 
            // elecTBox
            // 
            elecTBox.Location = new Point(888, 393);
            elecTBox.Name = "elecTBox";
            elecTBox.Size = new Size(125, 27);
            elecTBox.TabIndex = 14;
            // 
            // waterTBox
            // 
            waterTBox.Location = new Point(888, 427);
            waterTBox.Name = "waterTBox";
            waterTBox.Size = new Size(125, 27);
            waterTBox.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(676, 432);
            label6.Name = "label6";
            label6.Size = new Size(170, 17);
            label6.TabIndex = 15;
            label6.Text = "Current water bill rate";
            // 
            // priceTBox
            // 
            priceTBox.Location = new Point(836, 182);
            priceTBox.Name = "priceTBox";
            priceTBox.Size = new Size(125, 27);
            priceTBox.TabIndex = 85;
            // 
            // roomTBox
            // 
            roomTBox.AutoSize = true;
            roomTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomTBox.Location = new Point(676, 187);
            roomTBox.Name = "roomTBox";
            roomTBox.Size = new Size(149, 17);
            roomTBox.TabIndex = 84;
            roomTBox.Text = "Current room price";
            // 
            // roomIdTBox
            // 
            roomIdTBox.Location = new Point(836, 149);
            roomIdTBox.Name = "roomIdTBox";
            roomIdTBox.Size = new Size(44, 27);
            roomIdTBox.TabIndex = 87;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(676, 154);
            label8.Name = "label8";
            label8.Size = new Size(70, 17);
            label8.TabIndex = 86;
            label8.Text = "Room ID";
            // 
            // applyRoomButton
            // 
            applyRoomButton.BackColor = Color.DarkSeaGreen;
            applyRoomButton.Location = new Point(961, 258);
            applyRoomButton.Name = "applyRoomButton";
            applyRoomButton.Size = new Size(145, 42);
            applyRoomButton.TabIndex = 88;
            applyRoomButton.Text = "APPLY CHANGES";
            applyRoomButton.UseVisualStyleBackColor = false;
            applyRoomButton.Click += applyRoomButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(676, 223);
            label10.Name = "label10";
            label10.Size = new Size(124, 17);
            label10.TabIndex = 94;
            label10.Text = "Change price at";
            // 
            // priceDate
            // 
            priceDate.Location = new Point(836, 216);
            priceDate.Name = "priceDate";
            priceDate.Size = new Size(270, 27);
            priceDate.TabIndex = 93;
            // 
            // changeElecBillBtn
            // 
            changeElecBillBtn.BackColor = SystemColors.ActiveCaption;
            changeElecBillBtn.Location = new Point(1026, 391);
            changeElecBillBtn.Name = "changeElecBillBtn";
            changeElecBillBtn.Size = new Size(94, 29);
            changeElecBillBtn.TabIndex = 95;
            changeElecBillBtn.Text = "CHANGE";
            changeElecBillBtn.UseVisualStyleBackColor = false;
            changeElecBillBtn.Click += changeElecBillBtn_Click;
            // 
            // changeWaterBillBtn
            // 
            changeWaterBillBtn.BackColor = SystemColors.ActiveCaption;
            changeWaterBillBtn.Location = new Point(1026, 426);
            changeWaterBillBtn.Name = "changeWaterBillBtn";
            changeWaterBillBtn.Size = new Size(94, 29);
            changeWaterBillBtn.TabIndex = 96;
            changeWaterBillBtn.Text = "CHANGE";
            changeWaterBillBtn.UseVisualStyleBackColor = false;
            // 
            // pricesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1132, 753);
            Controls.Add(changeWaterBillBtn);
            Controls.Add(changeElecBillBtn);
            Controls.Add(label10);
            Controls.Add(priceDate);
            Controls.Add(applyRoomButton);
            Controls.Add(roomIdTBox);
            Controls.Add(label8);
            Controls.Add(priceTBox);
            Controls.Add(roomTBox);
            Controls.Add(waterTBox);
            Controls.Add(label6);
            Controls.Add(elecTBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(priceData);
            Controls.Add(label1);
            Name = "pricesForm";
            Text = "pricesForm";
            Load += pricesForm_Load;
            ((System.ComponentModel.ISupportInitialize)priceData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView priceData;
        private Label label4;
        private Label label5;
        private TextBox elecTBox;
        private TextBox waterTBox;
        private Label label6;
        private TextBox priceTBox;
        private Label roomTBox;
        private TextBox roomIdTBox;
        private Label label8;
        private Button applyRoomButton;
        private Label label10;
        private DateTimePicker priceDate;
        private Button changeElecBillBtn;
        private Button changeWaterBillBtn;
    }
}