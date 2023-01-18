namespace E_Apartment
{
    partial class CustomerViewApartments
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
            this.btnCustomerLogout = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCustomerViewDashboard = new System.Windows.Forms.Button();
            this.btnApartmentSearch = new System.Windows.Forms.Button();
            this.txtApartmentSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgwApartmentList = new System.Windows.Forms.DataGridView();
            this.cmbApartmentStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtApartmentLocation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalParkingSlot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApartmentDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxSuite = new System.Windows.Forms.CheckBox();
            this.cbxClass3 = new System.Windows.Forms.CheckBox();
            this.cbxClass2 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxClass1 = new System.Windows.Forms.CheckBox();
            this.txtApartmentNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuildingNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdminApartmentInsert = new System.Windows.Forms.Button();
            this.btnClearSelectedApartment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwApartmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCustomerLogout
            // 
            this.btnCustomerLogout.Location = new System.Drawing.Point(1047, 5);
            this.btnCustomerLogout.Name = "btnCustomerLogout";
            this.btnCustomerLogout.Size = new System.Drawing.Size(161, 41);
            this.btnCustomerLogout.TabIndex = 3;
            this.btnCustomerLogout.Text = "Logout";
            this.btnCustomerLogout.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Apartment List";
            // 
            // btnCustomerViewDashboard
            // 
            this.btnCustomerViewDashboard.Location = new System.Drawing.Point(880, 5);
            this.btnCustomerViewDashboard.Name = "btnCustomerViewDashboard";
            this.btnCustomerViewDashboard.Size = new System.Drawing.Size(161, 41);
            this.btnCustomerViewDashboard.TabIndex = 2;
            this.btnCustomerViewDashboard.Text = "View Dashboard";
            this.btnCustomerViewDashboard.UseVisualStyleBackColor = true;
            this.btnCustomerViewDashboard.Click += new System.EventHandler(this.btnCustomerViewDashboard_Click);
            // 
            // btnApartmentSearch
            // 
            this.btnApartmentSearch.Location = new System.Drawing.Point(1064, 85);
            this.btnApartmentSearch.Name = "btnApartmentSearch";
            this.btnApartmentSearch.Size = new System.Drawing.Size(116, 23);
            this.btnApartmentSearch.TabIndex = 34;
            this.btnApartmentSearch.Text = "Search";
            this.btnApartmentSearch.UseVisualStyleBackColor = true;
            this.btnApartmentSearch.Click += new System.EventHandler(this.btnApartmentSearch_Click);
            // 
            // txtApartmentSearch
            // 
            this.txtApartmentSearch.Location = new System.Drawing.Point(716, 80);
            this.txtApartmentSearch.Multiline = true;
            this.txtApartmentSearch.Name = "txtApartmentSearch";
            this.txtApartmentSearch.Size = new System.Drawing.Size(342, 34);
            this.txtApartmentSearch.TabIndex = 33;
            this.txtApartmentSearch.TextChanged += new System.EventHandler(this.txtApartmentSearch_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Apartment / Building Number :  ";
            // 
            // dgwApartmentList
            // 
            this.dgwApartmentList.AllowDrop = true;
            this.dgwApartmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwApartmentList.Location = new System.Drawing.Point(50, 120);
            this.dgwApartmentList.Name = "dgwApartmentList";
            this.dgwApartmentList.Size = new System.Drawing.Size(1158, 182);
            this.dgwApartmentList.TabIndex = 31;
            this.dgwApartmentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwApartmentList_CellDoubleClick);
            // 
            // cmbApartmentStatus
            // 
            this.cmbApartmentStatus.Items.AddRange(new object[] {
            "Available",
            "Unavailable",
            "Occupied"});
            this.cmbApartmentStatus.Location = new System.Drawing.Point(154, 480);
            this.cmbApartmentStatus.Name = "cmbApartmentStatus";
            this.cmbApartmentStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbApartmentStatus.TabIndex = 74;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 484);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 73;
            this.label10.Text = "Status : ";
            // 
            // txtApartmentLocation
            // 
            this.txtApartmentLocation.Enabled = false;
            this.txtApartmentLocation.Location = new System.Drawing.Point(585, 385);
            this.txtApartmentLocation.Multiline = true;
            this.txtApartmentLocation.Name = "txtApartmentLocation";
            this.txtApartmentLocation.Size = new System.Drawing.Size(205, 26);
            this.txtApartmentLocation.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 388);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "Location: ";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(154, 332);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(205, 26);
            this.txtID.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 69;
            this.label8.Text = "Record ID : ";
            // 
            // txtTotalParkingSlot
            // 
            this.txtTotalParkingSlot.Enabled = false;
            this.txtTotalParkingSlot.Location = new System.Drawing.Point(585, 437);
            this.txtTotalParkingSlot.Multiline = true;
            this.txtTotalParkingSlot.Name = "txtTotalParkingSlot";
            this.txtTotalParkingSlot.Size = new System.Drawing.Size(205, 26);
            this.txtTotalParkingSlot.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Total Parking Slot : ";
            // 
            // txtApartmentDescription
            // 
            this.txtApartmentDescription.Enabled = false;
            this.txtApartmentDescription.Location = new System.Drawing.Point(154, 518);
            this.txtApartmentDescription.Multiline = true;
            this.txtApartmentDescription.Name = "txtApartmentDescription";
            this.txtApartmentDescription.Size = new System.Drawing.Size(651, 118);
            this.txtApartmentDescription.TabIndex = 66;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Apartment Description: ";
            // 
            // cbxSuite
            // 
            this.cbxSuite.AutoSize = true;
            this.cbxSuite.Enabled = false;
            this.cbxSuite.Location = new System.Drawing.Point(298, 440);
            this.cbxSuite.Name = "cbxSuite";
            this.cbxSuite.Size = new System.Drawing.Size(50, 17);
            this.cbxSuite.TabIndex = 64;
            this.cbxSuite.Text = "Suite";
            this.cbxSuite.UseVisualStyleBackColor = true;
            // 
            // cbxClass3
            // 
            this.cbxClass3.AutoSize = true;
            this.cbxClass3.Enabled = false;
            this.cbxClass3.Location = new System.Drawing.Point(232, 440);
            this.cbxClass3.Name = "cbxClass3";
            this.cbxClass3.Size = new System.Drawing.Size(60, 17);
            this.cbxClass3.TabIndex = 63;
            this.cbxClass3.Text = "Class 3";
            this.cbxClass3.UseVisualStyleBackColor = true;
            // 
            // cbxClass2
            // 
            this.cbxClass2.AutoSize = true;
            this.cbxClass2.Enabled = false;
            this.cbxClass2.Location = new System.Drawing.Point(166, 440);
            this.cbxClass2.Name = "cbxClass2";
            this.cbxClass2.Size = new System.Drawing.Size(60, 17);
            this.cbxClass2.TabIndex = 62;
            this.cbxClass2.Text = "Class 2";
            this.cbxClass2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Classes : ";
            // 
            // cbxClass1
            // 
            this.cbxClass1.AutoSize = true;
            this.cbxClass1.Enabled = false;
            this.cbxClass1.Location = new System.Drawing.Point(102, 441);
            this.cbxClass1.Name = "cbxClass1";
            this.cbxClass1.Size = new System.Drawing.Size(60, 17);
            this.cbxClass1.TabIndex = 60;
            this.cbxClass1.Text = "Class 1";
            this.cbxClass1.UseVisualStyleBackColor = true;
            // 
            // txtApartmentNumber
            // 
            this.txtApartmentNumber.Enabled = false;
            this.txtApartmentNumber.Location = new System.Drawing.Point(154, 385);
            this.txtApartmentNumber.Multiline = true;
            this.txtApartmentNumber.Name = "txtApartmentNumber";
            this.txtApartmentNumber.Size = new System.Drawing.Size(205, 26);
            this.txtApartmentNumber.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Apartment Number : ";
            // 
            // txtBuildingNumber
            // 
            this.txtBuildingNumber.Enabled = false;
            this.txtBuildingNumber.Location = new System.Drawing.Point(572, 332);
            this.txtBuildingNumber.Multiline = true;
            this.txtBuildingNumber.Name = "txtBuildingNumber";
            this.txtBuildingNumber.Size = new System.Drawing.Size(205, 26);
            this.txtBuildingNumber.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Building Number : ";
            // 
            // btnAdminApartmentInsert
            // 
            this.btnAdminApartmentInsert.Location = new System.Drawing.Point(866, 346);
            this.btnAdminApartmentInsert.Name = "btnAdminApartmentInsert";
            this.btnAdminApartmentInsert.Size = new System.Drawing.Size(286, 23);
            this.btnAdminApartmentInsert.TabIndex = 55;
            this.btnAdminApartmentInsert.Text = "Lease the Select Apartment";
            this.btnAdminApartmentInsert.UseVisualStyleBackColor = true;
            // 
            // btnClearSelectedApartment
            // 
            this.btnClearSelectedApartment.Location = new System.Drawing.Point(866, 385);
            this.btnClearSelectedApartment.Name = "btnClearSelectedApartment";
            this.btnClearSelectedApartment.Size = new System.Drawing.Size(286, 23);
            this.btnClearSelectedApartment.TabIndex = 75;
            this.btnClearSelectedApartment.Text = "Clear the Selected Apartment";
            this.btnClearSelectedApartment.UseVisualStyleBackColor = true;
            this.btnClearSelectedApartment.Click += new System.EventHandler(this.btnClearSelectedApartment_Click);
            // 
            // CustomerViewApartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 648);
            this.Controls.Add(this.btnClearSelectedApartment);
            this.Controls.Add(this.cmbApartmentStatus);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtApartmentLocation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label8);
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
            this.Controls.Add(this.btnAdminApartmentInsert);
            this.Controls.Add(this.btnApartmentSearch);
            this.Controls.Add(this.txtApartmentSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgwApartmentList);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCustomerLogout);
            this.Controls.Add(this.btnCustomerViewDashboard);
            this.MaximizeBox = false;
            this.Name = "CustomerViewApartments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Available Apartments";
            ((System.ComponentModel.ISupportInitialize)(this.dgwApartmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCustomerLogout;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnCustomerViewDashboard;
        private System.Windows.Forms.Button btnApartmentSearch;
        private System.Windows.Forms.TextBox txtApartmentSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgwApartmentList;
        private System.Windows.Forms.ComboBox cmbApartmentStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtApartmentLocation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalParkingSlot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApartmentDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbxSuite;
        private System.Windows.Forms.CheckBox cbxClass3;
        private System.Windows.Forms.CheckBox cbxClass2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxClass1;
        private System.Windows.Forms.TextBox txtApartmentNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuildingNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdminApartmentInsert;
        private System.Windows.Forms.Button btnClearSelectedApartment;
    }
}