namespace QSevenManagementSystem
{
    partial class registrationForm2
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
            panel1 = new Panel();
            label1 = new Label();
            nextButton = new Button();
            depositTBox = new TextBox();
            roomTBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            selectRoomData = new DataGridView();
            label5 = new Label();
            moveInDate = new DateTimePicker();
            prevButton = new Button();
            registrationDate = new DateTimePicker();
            label = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectRoomData).BeginInit();
            SuspendLayout();
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
            label1.Size = new Size(610, 34);
            label1.TabIndex = 0;
            label1.Text = "Registration Form (2): Room Assignment";
            // 
            // nextButton
            // 
            nextButton.BackColor = Color.DarkSeaGreen;
            nextButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            nextButton.Location = new Point(956, 650);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(103, 42);
            nextButton.TabIndex = 34;
            nextButton.Text = "Confirm";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // depositTBox
            // 
            depositTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            depositTBox.Location = new Point(797, 153);
            depositTBox.Name = "depositTBox";
            depositTBox.Size = new Size(262, 25);
            depositTBox.TabIndex = 29;
            // 
            // roomTBox
            // 
            roomTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomTBox.Location = new Point(247, 150);
            roomTBox.Name = "roomTBox";
            roomTBox.Size = new Size(72, 25);
            roomTBox.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(632, 156);
            label4.Name = "label4";
            label4.Size = new Size(123, 17);
            label4.TabIndex = 22;
            label4.Text = "Deposit Amount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(632, 119);
            label3.Name = "label3";
            label3.Size = new Size(102, 17);
            label3.TabIndex = 21;
            label3.Text = "Move In Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(79, 153);
            label2.Name = "label2";
            label2.Size = new Size(50, 17);
            label2.TabIndex = 20;
            label2.Text = "Room";
            // 
            // selectRoomData
            // 
            selectRoomData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            selectRoomData.Location = new Point(79, 243);
            selectRoomData.Name = "selectRoomData";
            selectRoomData.RowHeadersWidth = 51;
            selectRoomData.RowTemplate.Height = 29;
            selectRoomData.Size = new Size(501, 449);
            selectRoomData.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(79, 213);
            label5.Name = "label5";
            label5.Size = new Size(114, 17);
            label5.TabIndex = 38;
            label5.Text = "Select a room:";
            // 
            // moveInDate
            // 
            moveInDate.Location = new Point(797, 112);
            moveInDate.Name = "moveInDate";
            moveInDate.Size = new Size(262, 27);
            moveInDate.TabIndex = 39;
            // 
            // prevButton
            // 
            prevButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            prevButton.Location = new Point(865, 650);
            prevButton.Name = "prevButton";
            prevButton.Size = new Size(70, 42);
            prevButton.TabIndex = 40;
            prevButton.Text = "<";
            prevButton.UseVisualStyleBackColor = true;
            prevButton.Click += prevButton_Click;
            // 
            // registrationDate
            // 
            registrationDate.Location = new Point(247, 112);
            registrationDate.Name = "registrationDate";
            registrationDate.Size = new Size(262, 27);
            registrationDate.TabIndex = 42;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(79, 119);
            label.Name = "label";
            label.Size = new Size(135, 17);
            label.TabIndex = 41;
            label.Text = "Registration Date";
            // 
            // registrationForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1152, 753);
            Controls.Add(registrationDate);
            Controls.Add(label);
            Controls.Add(prevButton);
            Controls.Add(moveInDate);
            Controls.Add(label5);
            Controls.Add(selectRoomData);
            Controls.Add(panel1);
            Controls.Add(nextButton);
            Controls.Add(depositTBox);
            Controls.Add(roomTBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "registrationForm2";
            Text = "registrationForm2";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)selectRoomData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button nextButton;
        private TextBox depositTBox;
        private TextBox roomTBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView selectRoomData;
        private Label label5;
        private DateTimePicker moveInDate;
        private Button prevButton;
        private DateTimePicker registrationDate;
        private Label label;
    }
}