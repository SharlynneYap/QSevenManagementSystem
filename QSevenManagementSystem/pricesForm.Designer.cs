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
            searchCBox = new ComboBox();
            searchTBox = new TextBox();
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
            editBtn = new Button();
            cancelBtn = new Button();
            label7 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)priceData).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // searchCBox
            // 
            searchCBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchCBox.FormattingEnabled = true;
            searchCBox.Location = new Point(746, 57);
            searchCBox.Margin = new Padding(3, 2, 3, 2);
            searchCBox.Name = "searchCBox";
            searchCBox.Size = new Size(145, 22);
            searchCBox.TabIndex = 11;
            // 
            // searchTBox
            // 
            searchTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchTBox.Location = new Point(503, 57);
            searchTBox.Margin = new Padding(3, 2, 3, 2);
            searchTBox.Name = "searchTBox";
            searchTBox.Size = new Size(204, 21);
            searchTBox.TabIndex = 10;
            searchTBox.TextChanged += searchTBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(718, 62);
            label3.Name = "label3";
            label3.Size = new Size(23, 14);
            label3.TabIndex = 9;
            label3.Text = "By";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(448, 59);
            label2.Name = "label2";
            label2.Size = new Size(51, 14);
            label2.TabIndex = 8;
            label2.Text = "Search ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(38, 59);
            label1.Name = "label1";
            label1.Size = new Size(44, 14);
            label1.TabIndex = 6;
            label1.Text = "Prices";
            // 
            // priceData
            // 
            priceData.AllowUserToAddRows = false;
            priceData.AllowUserToDeleteRows = false;
            priceData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            priceData.Location = new Point(38, 111);
            priceData.Margin = new Padding(3, 2, 3, 2);
            priceData.Name = "priceData";
            priceData.ReadOnly = true;
            priceData.RowHeadersWidth = 51;
            priceData.RowTemplate.Height = 29;
            priceData.Size = new Size(478, 367);
            priceData.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(38, 89);
            label4.Name = "label4";
            label4.Size = new Size(124, 14);
            label4.TabIndex = 12;
            label4.Text = "Current room prices";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(560, 298);
            label5.Name = "label5";
            label5.Size = new Size(157, 14);
            label5.TabIndex = 13;
            label5.Text = "Current electricity bill rate";
            // 
            // elecTBox
            // 
            elecTBox.Location = new Point(746, 294);
            elecTBox.Margin = new Padding(3, 2, 3, 2);
            elecTBox.Name = "elecTBox";
            elecTBox.ReadOnly = true;
            elecTBox.Size = new Size(110, 23);
            elecTBox.TabIndex = 14;
            // 
            // waterTBox
            // 
            waterTBox.Location = new Point(746, 320);
            waterTBox.Margin = new Padding(3, 2, 3, 2);
            waterTBox.Name = "waterTBox";
            waterTBox.ReadOnly = true;
            waterTBox.Size = new Size(110, 23);
            waterTBox.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(560, 323);
            label6.Name = "label6";
            label6.Size = new Size(133, 14);
            label6.TabIndex = 15;
            label6.Text = "Current water bill rate";
            // 
            // priceTBox
            // 
            priceTBox.Location = new Point(700, 136);
            priceTBox.Margin = new Padding(3, 2, 3, 2);
            priceTBox.Name = "priceTBox";
            priceTBox.ReadOnly = true;
            priceTBox.Size = new Size(110, 23);
            priceTBox.TabIndex = 85;
            // 
            // roomTBox
            // 
            roomTBox.AutoSize = true;
            roomTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomTBox.Location = new Point(560, 140);
            roomTBox.Name = "roomTBox";
            roomTBox.Size = new Size(117, 14);
            roomTBox.TabIndex = 84;
            roomTBox.Text = "Current room price";
            // 
            // roomIdTBox
            // 
            roomIdTBox.Location = new Point(700, 111);
            roomIdTBox.Margin = new Padding(3, 2, 3, 2);
            roomIdTBox.Name = "roomIdTBox";
            roomIdTBox.ReadOnly = true;
            roomIdTBox.Size = new Size(39, 23);
            roomIdTBox.TabIndex = 87;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(560, 115);
            label8.Name = "label8";
            label8.Size = new Size(57, 14);
            label8.TabIndex = 86;
            label8.Text = "Room ID";
            // 
            // applyRoomButton
            // 
            applyRoomButton.BackColor = Color.DarkSeaGreen;
            applyRoomButton.Location = new Point(809, 193);
            applyRoomButton.Margin = new Padding(3, 2, 3, 2);
            applyRoomButton.Name = "applyRoomButton";
            applyRoomButton.Size = new Size(127, 32);
            applyRoomButton.TabIndex = 88;
            applyRoomButton.Text = "APPLY CHANGES";
            applyRoomButton.UseVisualStyleBackColor = false;
            applyRoomButton.Visible = false;
            applyRoomButton.Click += applyRoomButton_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(560, 166);
            label10.Name = "label10";
            label10.Size = new Size(99, 14);
            label10.TabIndex = 94;
            label10.Text = "Change price at";
            // 
            // priceDate
            // 
            priceDate.Enabled = false;
            priceDate.Location = new Point(700, 161);
            priceDate.Margin = new Padding(3, 2, 3, 2);
            priceDate.Name = "priceDate";
            priceDate.Size = new Size(237, 23);
            priceDate.TabIndex = 93;
            // 
            // changeElecBillBtn
            // 
            changeElecBillBtn.BackColor = SystemColors.ActiveCaption;
            changeElecBillBtn.Location = new Point(866, 292);
            changeElecBillBtn.Margin = new Padding(3, 2, 3, 2);
            changeElecBillBtn.Name = "changeElecBillBtn";
            changeElecBillBtn.Size = new Size(82, 22);
            changeElecBillBtn.TabIndex = 95;
            changeElecBillBtn.Text = "CHANGE";
            changeElecBillBtn.UseVisualStyleBackColor = false;
            changeElecBillBtn.Click += changeElecBillBtn_Click;
            // 
            // changeWaterBillBtn
            // 
            changeWaterBillBtn.BackColor = SystemColors.ActiveCaption;
            changeWaterBillBtn.Location = new Point(866, 319);
            changeWaterBillBtn.Margin = new Padding(3, 2, 3, 2);
            changeWaterBillBtn.Name = "changeWaterBillBtn";
            changeWaterBillBtn.Size = new Size(82, 22);
            changeWaterBillBtn.TabIndex = 96;
            changeWaterBillBtn.Text = "CHANGE";
            changeWaterBillBtn.UseVisualStyleBackColor = false;
            changeWaterBillBtn.Click += changeWaterBillBtn_Click;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.DarkSeaGreen;
            editBtn.Location = new Point(848, 193);
            editBtn.Margin = new Padding(3, 2, 3, 2);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(88, 32);
            editBtn.TabIndex = 97;
            editBtn.Text = "EDIT";
            editBtn.UseVisualStyleBackColor = false;
            editBtn.Click += editBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = Color.Crimson;
            cancelBtn.Location = new Point(715, 193);
            cancelBtn.Margin = new Padding(3, 2, 3, 2);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(88, 32);
            cancelBtn.TabIndex = 98;
            cancelBtn.Text = "CANCEL";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Visible = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(87, 28);
            label7.TabIndex = 0;
            label7.Text = "Prices";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1007, 39);
            panel1.TabIndex = 99;
            // 
            // pricesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1007, 565);
            Controls.Add(panel1);
            Controls.Add(cancelBtn);
            Controls.Add(editBtn);
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
            Controls.Add(searchCBox);
            Controls.Add(searchTBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(priceData);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "pricesForm";
            Text = "pricesForm";
            Load += pricesForm_Load;
            ((System.ComponentModel.ISupportInitialize)priceData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox searchCBox;
        private TextBox searchTBox;
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
        private Button editBtn;
        private Button cancelBtn;
        private Label label7;
        private Panel panel1;
    }
}