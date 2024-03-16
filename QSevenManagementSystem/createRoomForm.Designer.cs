namespace QSevenManagementSystem
{
    partial class createRoomForm
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
            maxTBox = new TextBox();
            label1 = new Label();
            floorTBox = new TextBox();
            label9 = new Label();
            priceTBox = new TextBox();
            label10 = new Label();
            label11 = new Label();
            roomIdTBox = new TextBox();
            label12 = new Label();
            submitButton = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            raDate = new DateTimePicker();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // maxTBox
            // 
            maxTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            maxTBox.Location = new Point(338, 262);
            maxTBox.Margin = new Padding(3, 2, 3, 2);
            maxTBox.Name = "maxTBox";
            maxTBox.Size = new Size(42, 21);
            maxTBox.TabIndex = 43;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(172, 264);
            label1.Name = "label1";
            label1.Size = new Size(99, 14);
            label1.TabIndex = 42;
            label1.Text = "Max # of renters";
            // 
            // floorTBox
            // 
            floorTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            floorTBox.Location = new Point(338, 224);
            floorTBox.Margin = new Padding(3, 2, 3, 2);
            floorTBox.Name = "floorTBox";
            floorTBox.Size = new Size(42, 21);
            floorTBox.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(172, 226);
            label9.Name = "label9";
            label9.Size = new Size(97, 14);
            label9.TabIndex = 40;
            label9.Text = "Located at floor";
            // 
            // priceTBox
            // 
            priceTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            priceTBox.Location = new Point(338, 189);
            priceTBox.Margin = new Padding(3, 2, 3, 2);
            priceTBox.Name = "priceTBox";
            priceTBox.Size = new Size(82, 21);
            priceTBox.TabIndex = 39;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(172, 191);
            label10.Name = "label10";
            label10.Size = new Size(74, 14);
            label10.TabIndex = 38;
            label10.Text = "Room price";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(172, 127);
            label11.Name = "label11";
            label11.Size = new Size(84, 14);
            label11.TabIndex = 37;
            label11.Text = "Room Details";
            // 
            // roomIdTBox
            // 
            roomIdTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomIdTBox.Location = new Point(338, 158);
            roomIdTBox.Margin = new Padding(3, 2, 3, 2);
            roomIdTBox.Name = "roomIdTBox";
            roomIdTBox.Size = new Size(42, 21);
            roomIdTBox.TabIndex = 36;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(172, 160);
            label12.Name = "label12";
            label12.Size = new Size(57, 14);
            label12.TabIndex = 35;
            label12.Text = "Room ID";
            // 
            // submitButton
            // 
            submitButton.BackColor = Color.DarkSeaGreen;
            submitButton.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            submitButton.ForeColor = SystemColors.ActiveCaptionText;
            submitButton.Location = new Point(824, 482);
            submitButton.Margin = new Padding(3, 2, 3, 2);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(91, 38);
            submitButton.TabIndex = 44;
            submitButton.Text = "Confirm";
            submitButton.UseVisualStyleBackColor = false;
            submitButton.Click += submitButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 39);
            panel1.TabIndex = 45;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(329, 28);
            label2.TabIndex = 0;
            label2.Text = "Room Form (1): Room's Info";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(172, 304);
            label3.Name = "label3";
            label3.Size = new Size(120, 14);
            label3.TabIndex = 46;
            label3.Text = "Room creation date";
            // 
            // raDate
            // 
            raDate.Location = new Point(338, 296);
            raDate.Margin = new Padding(3, 2, 3, 2);
            raDate.Name = "raDate";
            raDate.Size = new Size(230, 23);
            raDate.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(437, 195);
            label4.Name = "label4";
            label4.Size = new Size(43, 14);
            label4.TabIndex = 48;
            label4.Text = "pesos";
            // 
            // createRoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1008, 565);
            Controls.Add(label4);
            Controls.Add(raDate);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(submitButton);
            Controls.Add(maxTBox);
            Controls.Add(label1);
            Controls.Add(floorTBox);
            Controls.Add(label9);
            Controls.Add(priceTBox);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(roomIdTBox);
            Controls.Add(label12);
            Margin = new Padding(3, 2, 3, 2);
            Name = "createRoomForm";
            Text = "createRoomForm";
            Load += createRoomForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox maxTBox;
        private Label label1;
        private TextBox floorTBox;
        private Label label9;
        private TextBox priceTBox;
        private Label label10;
        private Label label11;
        private TextBox roomIdTBox;
        private Label label12;
        private Button submitButton;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private DateTimePicker raDate;
        private Label label4;
    }
}