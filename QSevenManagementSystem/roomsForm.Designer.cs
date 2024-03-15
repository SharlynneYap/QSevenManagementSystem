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
            searchCBox = new ComboBox();
            searchTBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            roomsData = new DataGridView();
            applyButton = new Button();
            removeButton = new Button();
            createButton = new Button();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            panel1 = new Panel();
            label1 = new Label();
            tableLayoutPanel5 = new TableLayoutPanel();
            availLabel = new Label();
            label13 = new Label();
            label14 = new Label();
            label16 = new Label();
            priceLabel = new Label();
            label21 = new Label();
            roomLabel = new Label();
            label22 = new Label();
            label20 = new Label();
            txtNoRenters = new TextBox();
            txtFloor = new TextBox();
            btnEdit = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)roomsData).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // searchCBox
            // 
            searchCBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchCBox.FormattingEnabled = true;
            searchCBox.Location = new Point(319, 56);
            searchCBox.Margin = new Padding(3, 2, 3, 2);
            searchCBox.Name = "searchCBox";
            searchCBox.Size = new Size(145, 22);
            searchCBox.TabIndex = 11;
            // 
            // searchTBox
            // 
            searchTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchTBox.Location = new Point(77, 56);
            searchTBox.Margin = new Padding(3, 2, 3, 2);
            searchTBox.Name = "searchTBox";
            searchTBox.Size = new Size(204, 21);
            searchTBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(292, 60);
            label3.Name = "label3";
            label3.Size = new Size(23, 14);
            label3.TabIndex = 9;
            label3.Text = "By";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 58);
            label2.Name = "label2";
            label2.Size = new Size(51, 14);
            label2.TabIndex = 8;
            label2.Text = "Search ";
            // 
            // roomsData
            // 
            roomsData.AllowUserToAddRows = false;
            roomsData.AllowUserToDeleteRows = false;
            roomsData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            roomsData.Location = new Point(23, 86);
            roomsData.Margin = new Padding(3, 2, 3, 2);
            roomsData.Name = "roomsData";
            roomsData.ReadOnly = true;
            roomsData.RowHeadersWidth = 51;
            roomsData.RowTemplate.Height = 29;
            roomsData.Size = new Size(527, 395);
            roomsData.TabIndex = 7;
            // 
            // applyButton
            // 
            applyButton.BackColor = Color.DarkSeaGreen;
            applyButton.Location = new Point(619, 282);
            applyButton.Margin = new Padding(3, 2, 3, 2);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(139, 32);
            applyButton.TabIndex = 26;
            applyButton.Text = "APPLY CHANGES";
            applyButton.UseVisualStyleBackColor = false;
            applyButton.Visible = false;
            applyButton.Click += applyButton_Click;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.Tomato;
            removeButton.Location = new Point(790, 282);
            removeButton.Margin = new Padding(3, 2, 3, 2);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(139, 32);
            removeButton.TabIndex = 27;
            removeButton.Text = "REMOVE ROOM";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // createButton
            // 
            createButton.BackColor = SystemColors.GradientActiveCaption;
            createButton.Location = new Point(709, 318);
            createButton.Margin = new Padding(3, 2, 3, 2);
            createButton.Name = "createButton";
            createButton.Size = new Size(139, 32);
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
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1008, 39);
            panel1.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 0;
            label1.Text = "Rooms";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = SystemColors.GradientInactiveCaption;
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.5F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.5F));
            tableLayoutPanel5.Controls.Add(availLabel, 1, 5);
            tableLayoutPanel5.Controls.Add(label13, 0, 2);
            tableLayoutPanel5.Controls.Add(label14, 0, 3);
            tableLayoutPanel5.Controls.Add(label16, 0, 4);
            tableLayoutPanel5.Controls.Add(priceLabel, 1, 2);
            tableLayoutPanel5.Controls.Add(label21, 0, 1);
            tableLayoutPanel5.Controls.Add(roomLabel, 1, 1);
            tableLayoutPanel5.Controls.Add(label22, 0, 5);
            tableLayoutPanel5.Controls.Add(label20, 0, 0);
            tableLayoutPanel5.Controls.Add(txtNoRenters, 1, 3);
            tableLayoutPanel5.Controls.Add(txtFloor, 1, 4);
            tableLayoutPanel5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel5.Location = new Point(558, 86);
            tableLayoutPanel5.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 6;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel5.Size = new Size(418, 179);
            tableLayoutPanel5.TabIndex = 69;
            // 
            // availLabel
            // 
            availLabel.AutoSize = true;
            availLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            availLabel.Location = new Point(161, 147);
            availLabel.Name = "availLabel";
            availLabel.Size = new Size(37, 15);
            availLabel.TabIndex = 72;
            availLabel.Text = "None";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(5, 60);
            label13.Name = "label13";
            label13.Size = new Size(41, 14);
            label13.TabIndex = 44;
            label13.Text = "Price:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(5, 89);
            label14.Name = "label14";
            label14.Size = new Size(107, 14);
            label14.TabIndex = 46;
            label14.Text = "Max # of Renters:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(5, 118);
            label16.Name = "label16";
            label16.Size = new Size(40, 14);
            label16.TabIndex = 47;
            label16.Text = "Floor:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(161, 60);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(37, 15);
            priceLabel.TabIndex = 54;
            priceLabel.Text = "None";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(5, 31);
            label21.Name = "label21";
            label21.Size = new Size(61, 14);
            label21.TabIndex = 49;
            label21.Text = "Room ID:";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomLabel.Location = new Point(161, 31);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new Size(37, 15);
            roomLabel.TabIndex = 56;
            roomLabel.Text = "None";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(5, 147);
            label22.Name = "label22";
            label22.Size = new Size(75, 14);
            label22.TabIndex = 43;
            label22.Text = "Availability:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(5, 2);
            label20.Name = "label20";
            label20.Size = new Size(113, 18);
            label20.TabIndex = 48;
            label20.Text = "Room Details";
            // 
            // txtNoRenters
            // 
            txtNoRenters.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoRenters.Location = new Point(161, 91);
            txtNoRenters.Margin = new Padding(3, 2, 3, 2);
            txtNoRenters.Name = "txtNoRenters";
            txtNoRenters.ReadOnly = true;
            txtNoRenters.Size = new Size(39, 21);
            txtNoRenters.TabIndex = 57;
            // 
            // txtFloor
            // 
            txtFloor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFloor.Location = new Point(161, 120);
            txtFloor.Margin = new Padding(3, 2, 3, 2);
            txtFloor.Name = "txtFloor";
            txtFloor.ReadOnly = true;
            txtFloor.Size = new Size(39, 21);
            txtFloor.TabIndex = 58;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkSeaGreen;
            btnEdit.Location = new Point(619, 282);
            btnEdit.Margin = new Padding(3, 2, 3, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(139, 32);
            btnEdit.TabIndex = 70;
            btnEdit.Text = "EDIT ROOM";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Crimson;
            btnCancel.Location = new Point(790, 282);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(139, 32);
            btnCancel.TabIndex = 71;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // roomsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1008, 565);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(tableLayoutPanel5);
            Controls.Add(panel1);
            Controls.Add(createButton);
            Controls.Add(removeButton);
            Controls.Add(applyButton);
            Controls.Add(searchCBox);
            Controls.Add(searchTBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(roomsData);
            Margin = new Padding(3, 2, 3, 2);
            Name = "roomsForm";
            Text = "roomsForm";
            ((System.ComponentModel.ISupportInitialize)roomsData).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox searchCBox;
        private TextBox searchTBox;
        private Label label3;
        private Label label2;
        private DataGridView roomsData;
        private Button applyButton;
        private Button removeButton;
        private Button createButton;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private Panel panel1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label13;
        private Label label14;
        private Label label16;
        private Label priceLabel;
        private Label label21;
        private Label roomLabel;
        private Label label22;
        private Label label20;
        private TextBox txtNoRenters;
        private TextBox txtFloor;
        private Button btnEdit;
        private Button btnCancel;
        private Label availLabel;
    }
}