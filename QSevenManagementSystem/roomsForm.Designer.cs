namespace QSevenManagementSystem
{
    partial class roomsForm
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
            roomsData = new DataGridView();
            label1 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            label11 = new Label();
            applyButton = new Button();
            removeButton = new Button();
            createButton = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            ((System.ComponentModel.ISupportInitialize)roomsData).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(418, 108);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(165, 25);
            comboBox1.TabIndex = 11;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(141, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(232, 25);
            textBox1.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(387, 114);
            label3.Name = "label3";
            label3.Size = new Size(27, 17);
            label3.TabIndex = 9;
            label3.Text = "By";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(78, 111);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 8;
            label2.Text = "Search ";
            // 
            // roomsData
            // 
            roomsData.AllowUserToAddRows = false;
            roomsData.AllowUserToDeleteRows = false;
            roomsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomsData.Location = new Point(79, 149);
            roomsData.Name = "roomsData";
            roomsData.ReadOnly = true;
            roomsData.RowHeadersWidth = 51;
            roomsData.RowTemplate.Height = 29;
            roomsData.Size = new Size(602, 527);
            roomsData.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(77, 55);
            label1.Name = "label1";
            label1.Size = new Size(58, 17);
            label1.TabIndex = 6;
            label1.Text = "Rooms";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(846, 182);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(67, 25);
            textBox2.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(716, 185);
            label4.Name = "label4";
            label4.Size = new Size(70, 17);
            label4.TabIndex = 12;
            label4.Text = "Room ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(716, 149);
            label5.Name = "label5";
            label5.Size = new Size(104, 17);
            label5.TabIndex = 14;
            label5.Text = "Room Details";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(846, 213);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(93, 25);
            textBox3.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(716, 216);
            label6.Name = "label6";
            label6.Size = new Size(92, 17);
            label6.TabIndex = 15;
            label6.Text = "Room price";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(846, 244);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(67, 25);
            textBox4.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(716, 247);
            label7.Name = "label7";
            label7.Size = new Size(123, 17);
            label7.TabIndex = 17;
            label7.Text = "Located at floor";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(846, 275);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(67, 25);
            textBox5.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(716, 278);
            label8.Name = "label8";
            label8.Size = new Size(125, 17);
            label8.TabIndex = 19;
            label8.Text = "Max # of renters";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(716, 364);
            label9.Name = "label9";
            label9.Size = new Size(133, 17);
            label9.TabIndex = 21;
            label9.Text = "Room Availability";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(716, 397);
            label10.Name = "label10";
            label10.Size = new Size(0, 17);
            label10.TabIndex = 22;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(722, 389);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(145, 25);
            textBox6.TabIndex = 23;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(908, 389);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(145, 25);
            textBox7.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(873, 392);
            label11.Name = "label11";
            label11.Size = new Size(22, 17);
            label11.TabIndex = 24;
            label11.Text = "at";
            // 
            // applyButton
            // 
            applyButton.BackColor = Color.DarkSeaGreen;
            applyButton.Location = new Point(722, 452);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(145, 42);
            applyButton.TabIndex = 26;
            applyButton.Text = "APPLY CHANGES";
            applyButton.UseVisualStyleBackColor = false;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.Tomato;
            removeButton.Location = new Point(873, 452);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(145, 42);
            removeButton.TabIndex = 27;
            removeButton.Text = "REMOVE ROOM";
            removeButton.UseVisualStyleBackColor = false;
            // 
            // createButton
            // 
            createButton.BackColor = SystemColors.GradientActiveCaption;
            createButton.Location = new Point(722, 538);
            createButton.Name = "createButton";
            createButton.Size = new Size(174, 42);
            createButton.TabIndex = 28;
            createButton.Text = "CREATE NEW ROOM";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // roomsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1132, 753);
            Controls.Add(createButton);
            Controls.Add(removeButton);
            Controls.Add(applyButton);
            Controls.Add(textBox7);
            Controls.Add(label11);
            Controls.Add(textBox6);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(roomsData);
            Controls.Add(label1);
            Name = "roomsForm";
            Text = "roomsForm";
            ((System.ComponentModel.ISupportInitialize)roomsData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private DataGridView roomsData;
        private Label label1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox6;
        private TextBox textBox7;
        private Label label11;
        private Button applyButton;
        private Button removeButton;
        private Button createButton;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}