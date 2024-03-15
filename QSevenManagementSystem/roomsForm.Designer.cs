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
            txtAvail = new TextBox();
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
            searchCBox.Location = new Point(365, 74);
            searchCBox.Name = "searchCBox";
            searchCBox.Size = new Size(165, 25);
            searchCBox.TabIndex = 11;
            // 
            // searchTBox
            // 
            searchTBox.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            searchTBox.Location = new Point(88, 74);
            searchTBox.Name = "searchTBox";
            searchTBox.Size = new Size(232, 25);
            searchTBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(334, 80);
            label3.Name = "label3";
            label3.Size = new Size(27, 17);
            label3.TabIndex = 9;
            label3.Text = "By";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 77);
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
            roomsData.Location = new Point(26, 115);
            roomsData.Name = "roomsData";
            roomsData.ReadOnly = true;
            roomsData.RowHeadersWidth = 51;
            roomsData.RowTemplate.Height = 29;
            roomsData.Size = new Size(602, 527);
            roomsData.TabIndex = 7;
            // 
            // applyButton
            // 
            applyButton.BackColor = Color.DarkSeaGreen;
            applyButton.Location = new Point(707, 376);
            applyButton.Name = "applyButton";
            applyButton.Size = new Size(159, 42);
            applyButton.TabIndex = 26;
            applyButton.Text = "APPLY CHANGES";
            applyButton.UseVisualStyleBackColor = false;
            applyButton.Visible = false;
            applyButton.Click += applyButton_Click;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.Tomato;
            removeButton.Location = new Point(903, 376);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(159, 42);
            removeButton.TabIndex = 27;
            removeButton.Text = "REMOVE ROOM";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += removeButton_Click;
            // 
            // createButton
            // 
            createButton.BackColor = SystemColors.GradientActiveCaption;
            createButton.Location = new Point(810, 424);
            createButton.Name = "createButton";
            createButton.Size = new Size(159, 42);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 52);
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
            label1.Size = new Size(116, 34);
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
            tableLayoutPanel5.Controls.Add(txtAvail, 1, 5);
            tableLayoutPanel5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tableLayoutPanel5.Location = new Point(638, 115);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 6;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel5.Size = new Size(478, 239);
            tableLayoutPanel5.TabIndex = 69;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(5, 80);
            label13.Name = "label13";
            label13.Size = new Size(52, 17);
            label13.TabIndex = 44;
            label13.Text = "Price:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(5, 119);
            label14.Name = "label14";
            label14.Size = new Size(134, 17);
            label14.TabIndex = 46;
            label14.Text = "Max # of Renters:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(5, 158);
            label16.Name = "label16";
            label16.Size = new Size(51, 17);
            label16.TabIndex = 47;
            label16.Text = "Floor:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            priceLabel.Location = new Point(184, 80);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(44, 18);
            priceLabel.TabIndex = 54;
            priceLabel.Text = "None";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(5, 41);
            label21.Name = "label21";
            label21.Size = new Size(75, 17);
            label21.TabIndex = 49;
            label21.Text = "Room ID:";
            // 
            // roomLabel
            // 
            roomLabel.AutoSize = true;
            roomLabel.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            roomLabel.Location = new Point(184, 41);
            roomLabel.Name = "roomLabel";
            roomLabel.Size = new Size(44, 18);
            roomLabel.TabIndex = 56;
            roomLabel.Text = "None";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(5, 197);
            label22.Name = "label22";
            label22.Size = new Size(92, 17);
            label22.TabIndex = 43;
            label22.Text = "Availability:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(5, 2);
            label20.Name = "label20";
            label20.Size = new Size(138, 23);
            label20.TabIndex = 48;
            label20.Text = "Room Details";
            // 
            // txtNoRenters
            // 
            txtNoRenters.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNoRenters.Location = new Point(184, 122);
            txtNoRenters.Name = "txtNoRenters";
            txtNoRenters.ReadOnly = true;
            txtNoRenters.Size = new Size(44, 24);
            txtNoRenters.TabIndex = 57;
            // 
            // txtFloor
            // 
            txtFloor.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFloor.Location = new Point(184, 161);
            txtFloor.Name = "txtFloor";
            txtFloor.ReadOnly = true;
            txtFloor.Size = new Size(44, 24);
            txtFloor.TabIndex = 58;
            // 
            // txtAvail
            // 
            txtAvail.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAvail.Location = new Point(184, 200);
            txtAvail.Name = "txtAvail";
            txtAvail.ReadOnly = true;
            txtAvail.Size = new Size(121, 24);
            txtAvail.TabIndex = 59;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkSeaGreen;
            btnEdit.Location = new Point(707, 376);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(159, 42);
            btnEdit.TabIndex = 70;
            btnEdit.Text = "EDIT ROOM";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Crimson;
            btnCancel.Location = new Point(903, 376);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(159, 42);
            btnCancel.TabIndex = 71;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // roomsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1152, 753);
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
        private TextBox txtAvail;
        private Button btnEdit;
        private Button btnCancel;
    }
}