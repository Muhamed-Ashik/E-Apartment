namespace E_Apartment
{
    partial class ManageApartments
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuildingNumber = new System.Windows.Forms.TextBox();
            this.txtApartmentNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxClass1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxClass2 = new System.Windows.Forms.CheckBox();
            this.cbxClass3 = new System.Windows.Forms.CheckBox();
            this.cbxSuite = new System.Windows.Forms.CheckBox();
            this.txtApartmentDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalParkingSlot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgwApartmentList = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApartmentSearch = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtApartmentLocation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbApartmentStatus = new System.Windows.Forms.ComboBox();
            this.btnManageApartmentsToDashboard = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAdminApartmentInsert = new System.Windows.Forms.Button();
            this.btnAdminApartmentUpdate = new System.Windows.Forms.Button();
            this.btnAdminApartmentDelete = new System.Windows.Forms.Button();
            this.btnApartmentTextClear = new System.Windows.Forms.Button();
            this.btnApartmentSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwApartmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Apartments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(448, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Building Number : ";
            // 
            // txtBuildingNumber
            // 
            this.txtBuildingNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtBuildingNumber.Location = new System.Drawing.Point(560, 80);
            this.txtBuildingNumber.Multiline = true;
            this.txtBuildingNumber.Name = "txtBuildingNumber";
            this.txtBuildingNumber.Size = new System.Drawing.Size(205, 26);
            this.txtBuildingNumber.TabIndex = 9;
            // 
            // txtApartmentNumber
            // 
            this.txtApartmentNumber.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtApartmentNumber.Location = new System.Drawing.Point(129, 123);
            this.txtApartmentNumber.Multiline = true;
            this.txtApartmentNumber.Name = "txtApartmentNumber";
            this.txtApartmentNumber.Size = new System.Drawing.Size(205, 26);
            this.txtApartmentNumber.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Apartment Number : ";
            // 
            // cbxClass1
            // 
            this.cbxClass1.AutoSize = true;
            this.cbxClass1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxClass1.Location = new System.Drawing.Point(80, 172);
            this.cbxClass1.Name = "cbxClass1";
            this.cbxClass1.Size = new System.Drawing.Size(60, 17);
            this.cbxClass1.TabIndex = 12;
            this.cbxClass1.Text = "Class 1";
            this.cbxClass1.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Classes : ";
            // 
            // cbxClass2
            // 
            this.cbxClass2.AutoSize = true;
            this.cbxClass2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxClass2.Location = new System.Drawing.Point(143, 171);
            this.cbxClass2.Name = "cbxClass2";
            this.cbxClass2.Size = new System.Drawing.Size(60, 17);
            this.cbxClass2.TabIndex = 14;
            this.cbxClass2.Text = "Class 2";
            this.cbxClass2.UseVisualStyleBackColor = false;
            // 
            // cbxClass3
            // 
            this.cbxClass3.AutoSize = true;
            this.cbxClass3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxClass3.Location = new System.Drawing.Point(209, 171);
            this.cbxClass3.Name = "cbxClass3";
            this.cbxClass3.Size = new System.Drawing.Size(60, 17);
            this.cbxClass3.TabIndex = 15;
            this.cbxClass3.Text = "Class 3";
            this.cbxClass3.UseVisualStyleBackColor = false;
            // 
            // cbxSuite
            // 
            this.cbxSuite.AutoSize = true;
            this.cbxSuite.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxSuite.Location = new System.Drawing.Point(284, 171);
            this.cbxSuite.Name = "cbxSuite";
            this.cbxSuite.Size = new System.Drawing.Size(50, 17);
            this.cbxSuite.TabIndex = 16;
            this.cbxSuite.Text = "Suite";
            this.cbxSuite.UseVisualStyleBackColor = false;
            // 
            // txtApartmentDescription
            // 
            this.txtApartmentDescription.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtApartmentDescription.Location = new System.Drawing.Point(147, 250);
            this.txtApartmentDescription.Multiline = true;
            this.txtApartmentDescription.Name = "txtApartmentDescription";
            this.txtApartmentDescription.Size = new System.Drawing.Size(618, 118);
            this.txtApartmentDescription.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Apartment Description: ";
            // 
            // txtTotalParkingSlot
            // 
            this.txtTotalParkingSlot.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTotalParkingSlot.Location = new System.Drawing.Point(560, 174);
            this.txtTotalParkingSlot.Multiline = true;
            this.txtTotalParkingSlot.Name = "txtTotalParkingSlot";
            this.txtTotalParkingSlot.Size = new System.Drawing.Size(205, 26);
            this.txtTotalParkingSlot.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(448, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Total Parking Slot : ";
            // 
            // dgwApartmentList
            // 
            this.dgwApartmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwApartmentList.Location = new System.Drawing.Point(26, 430);
            this.dgwApartmentList.Name = "dgwApartmentList";
            this.dgwApartmentList.Size = new System.Drawing.Size(1158, 195);
            this.dgwApartmentList.TabIndex = 21;
            this.dgwApartmentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwApartmentList_CellDoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(416, 395);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Apartment / Building Number :/ Location  ";
            // 
            // txtApartmentSearch
            // 
            this.txtApartmentSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtApartmentSearch.Location = new System.Drawing.Point(689, 383);
            this.txtApartmentSearch.Multiline = true;
            this.txtApartmentSearch.Name = "txtApartmentSearch";
            this.txtApartmentSearch.Size = new System.Drawing.Size(342, 41);
            this.txtApartmentSearch.TabIndex = 23;
            this.txtApartmentSearch.TextChanged += new System.EventHandler(this.txtApartmentSearch_TextChanged);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(90, 80);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(244, 26);
            this.txtID.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Record ID : ";
            // 
            // txtApartmentLocation
            // 
            this.txtApartmentLocation.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtApartmentLocation.Location = new System.Drawing.Point(560, 125);
            this.txtApartmentLocation.Multiline = true;
            this.txtApartmentLocation.Name = "txtApartmentLocation";
            this.txtApartmentLocation.Size = new System.Drawing.Size(205, 26);
            this.txtApartmentLocation.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Location: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "Status : ";
            // 
            // cmbApartmentStatus
            // 
            this.cmbApartmentStatus.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cmbApartmentStatus.FormattingEnabled = true;
            this.cmbApartmentStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable",
            "Occupied"});
            this.cmbApartmentStatus.Location = new System.Drawing.Point(75, 208);
            this.cmbApartmentStatus.Name = "cmbApartmentStatus";
            this.cmbApartmentStatus.Size = new System.Drawing.Size(167, 21);
            this.cmbApartmentStatus.TabIndex = 29;
            // 
            // btnManageApartmentsToDashboard
            // 
            this.btnManageApartmentsToDashboard.BackColor = System.Drawing.Color.Green;
            this.btnManageApartmentsToDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnManageApartmentsToDashboard.ForeColor = System.Drawing.Color.White;
            this.btnManageApartmentsToDashboard.Location = new System.Drawing.Point(946, 12);
            this.btnManageApartmentsToDashboard.Name = "btnManageApartmentsToDashboard";
            this.btnManageApartmentsToDashboard.Size = new System.Drawing.Size(139, 41);
            this.btnManageApartmentsToDashboard.TabIndex = 31;
            this.btnManageApartmentsToDashboard.Text = "Dashboard";
            this.btnManageApartmentsToDashboard.UseVisualStyleBackColor = false;
            this.btnManageApartmentsToDashboard.Click += new System.EventHandler(this.btnManageApartmentsToDashboard_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(1091, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 41);
            this.button2.TabIndex = 32;
            this.button2.Text = "Logout";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnAdminApartmentInsert
            // 
            this.btnAdminApartmentInsert.BackColor = System.Drawing.Color.Green;
            this.btnAdminApartmentInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdminApartmentInsert.ForeColor = System.Drawing.Color.White;
            this.btnAdminApartmentInsert.Location = new System.Drawing.Point(1046, 80);
            this.btnAdminApartmentInsert.Name = "btnAdminApartmentInsert";
            this.btnAdminApartmentInsert.Size = new System.Drawing.Size(139, 41);
            this.btnAdminApartmentInsert.TabIndex = 33;
            this.btnAdminApartmentInsert.Text = "Insert";
            this.btnAdminApartmentInsert.UseVisualStyleBackColor = false;
            // 
            // btnAdminApartmentUpdate
            // 
            this.btnAdminApartmentUpdate.BackColor = System.Drawing.Color.Green;
            this.btnAdminApartmentUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdminApartmentUpdate.ForeColor = System.Drawing.Color.White;
            this.btnAdminApartmentUpdate.Location = new System.Drawing.Point(1046, 144);
            this.btnAdminApartmentUpdate.Name = "btnAdminApartmentUpdate";
            this.btnAdminApartmentUpdate.Size = new System.Drawing.Size(139, 41);
            this.btnAdminApartmentUpdate.TabIndex = 34;
            this.btnAdminApartmentUpdate.Text = "Update";
            this.btnAdminApartmentUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdminApartmentDelete
            // 
            this.btnAdminApartmentDelete.BackColor = System.Drawing.Color.Red;
            this.btnAdminApartmentDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdminApartmentDelete.ForeColor = System.Drawing.Color.White;
            this.btnAdminApartmentDelete.Location = new System.Drawing.Point(1046, 208);
            this.btnAdminApartmentDelete.Name = "btnAdminApartmentDelete";
            this.btnAdminApartmentDelete.Size = new System.Drawing.Size(139, 41);
            this.btnAdminApartmentDelete.TabIndex = 35;
            this.btnAdminApartmentDelete.Text = "Delete";
            this.btnAdminApartmentDelete.UseVisualStyleBackColor = false;
            // 
            // btnApartmentTextClear
            // 
            this.btnApartmentTextClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnApartmentTextClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnApartmentTextClear.ForeColor = System.Drawing.Color.White;
            this.btnApartmentTextClear.Location = new System.Drawing.Point(1046, 277);
            this.btnApartmentTextClear.Name = "btnApartmentTextClear";
            this.btnApartmentTextClear.Size = new System.Drawing.Size(139, 41);
            this.btnApartmentTextClear.TabIndex = 36;
            this.btnApartmentTextClear.Text = "Clear All Text";
            this.btnApartmentTextClear.UseVisualStyleBackColor = false;
            // 
            // btnApartmentSearch
            // 
            this.btnApartmentSearch.BackColor = System.Drawing.Color.Green;
            this.btnApartmentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnApartmentSearch.ForeColor = System.Drawing.Color.White;
            this.btnApartmentSearch.Location = new System.Drawing.Point(1046, 383);
            this.btnApartmentSearch.Name = "btnApartmentSearch";
            this.btnApartmentSearch.Size = new System.Drawing.Size(139, 41);
            this.btnApartmentSearch.TabIndex = 37;
            this.btnApartmentSearch.Text = "Clear All Text";
            this.btnApartmentSearch.UseVisualStyleBackColor = false;
            // 
            // ManageApartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1245, 637);
            this.Controls.Add(this.btnApartmentSearch);
            this.Controls.Add(this.btnApartmentTextClear);
            this.Controls.Add(this.btnAdminApartmentDelete);
            this.Controls.Add(this.btnAdminApartmentUpdate);
            this.Controls.Add(this.btnAdminApartmentInsert);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnManageApartmentsToDashboard);
            this.Controls.Add(this.cmbApartmentStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtApartmentLocation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtApartmentSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgwApartmentList);
            this.Controls.Add(this.txtTotalParkingSlot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApartmentDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxSuite);
            this.Controls.Add(this.cbxClass3);
            this.Controls.Add(this.cbxClass2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxClass1);
            this.Controls.Add(this.txtApartmentNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuildingNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ManageApartments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Apartments ";
            ((System.ComponentModel.ISupportInitialize)(this.dgwApartmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuildingNumber;
        private System.Windows.Forms.TextBox txtApartmentNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbxClass1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxClass2;
        private System.Windows.Forms.CheckBox cbxClass3;
        private System.Windows.Forms.CheckBox cbxSuite;
        private System.Windows.Forms.TextBox txtApartmentDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalParkingSlot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgwApartmentList;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApartmentSearch;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtApartmentLocation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbApartmentStatus;
        private System.Windows.Forms.Button btnManageApartmentsToDashboard;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdminApartmentInsert;
        private System.Windows.Forms.Button btnAdminApartmentUpdate;
        private System.Windows.Forms.Button btnAdminApartmentDelete;
        private System.Windows.Forms.Button btnApartmentTextClear;
        private System.Windows.Forms.Button btnApartmentSearch;
    }
}