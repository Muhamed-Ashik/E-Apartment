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
            this.txtApartmentLocation = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotalParkingSlot = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApartmentNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuildingNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLeaseSelectedApartment = new System.Windows.Forms.Button();
            this.btnClearSelectedApartment = new System.Windows.Forms.Button();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLeasedPostedDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtOccupantParkingSlotNeeded = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDurationOfLease = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtOccupantContactNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOccupantAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtOccupantNIC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtOccupantName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnClearAllText = new System.Windows.Forms.Button();
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
            this.dgwApartmentList.Size = new System.Drawing.Size(1158, 131);
            this.dgwApartmentList.TabIndex = 31;
            this.dgwApartmentList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwApartmentList_CellDoubleClick);
            // 
            // txtApartmentLocation
            // 
            this.txtApartmentLocation.Enabled = false;
            this.txtApartmentLocation.Location = new System.Drawing.Point(673, 261);
            this.txtApartmentLocation.Multiline = true;
            this.txtApartmentLocation.Name = "txtApartmentLocation";
            this.txtApartmentLocation.Size = new System.Drawing.Size(167, 26);
            this.txtApartmentLocation.TabIndex = 72;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(613, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 71;
            this.label9.Text = "Location: ";
            // 
            // txtTotalParkingSlot
            // 
            this.txtTotalParkingSlot.Enabled = false;
            this.txtTotalParkingSlot.Location = new System.Drawing.Point(999, 264);
            this.txtTotalParkingSlot.Multiline = true;
            this.txtTotalParkingSlot.Name = "txtTotalParkingSlot";
            this.txtTotalParkingSlot.Size = new System.Drawing.Size(205, 26);
            this.txtTotalParkingSlot.TabIndex = 68;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(847, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Total Parking Slot Available : ";
            // 
            // txtApartmentNumber
            // 
            this.txtApartmentNumber.Enabled = false;
            this.txtApartmentNumber.Location = new System.Drawing.Point(455, 260);
            this.txtApartmentNumber.Multiline = true;
            this.txtApartmentNumber.Name = "txtApartmentNumber";
            this.txtApartmentNumber.Size = new System.Drawing.Size(133, 26);
            this.txtApartmentNumber.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Apartment Number : ";
            // 
            // txtBuildingNumber
            // 
            this.txtBuildingNumber.Enabled = false;
            this.txtBuildingNumber.Location = new System.Drawing.Point(150, 257);
            this.txtBuildingNumber.Multiline = true;
            this.txtBuildingNumber.Name = "txtBuildingNumber";
            this.txtBuildingNumber.Size = new System.Drawing.Size(163, 26);
            this.txtBuildingNumber.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Building Number : ";
            // 
            // btnLeaseSelectedApartment
            // 
            this.btnLeaseSelectedApartment.Location = new System.Drawing.Point(894, 491);
            this.btnLeaseSelectedApartment.Name = "btnLeaseSelectedApartment";
            this.btnLeaseSelectedApartment.Size = new System.Drawing.Size(286, 23);
            this.btnLeaseSelectedApartment.TabIndex = 55;
            this.btnLeaseSelectedApartment.Text = "Lease the Select Apartment";
            this.btnLeaseSelectedApartment.UseVisualStyleBackColor = true;
            this.btnLeaseSelectedApartment.Click += new System.EventHandler(this.btnLeaseSelectedApartment_Click);
            // 
            // btnClearSelectedApartment
            // 
            this.btnClearSelectedApartment.Location = new System.Drawing.Point(894, 520);
            this.btnClearSelectedApartment.Name = "btnClearSelectedApartment";
            this.btnClearSelectedApartment.Size = new System.Drawing.Size(286, 23);
            this.btnClearSelectedApartment.TabIndex = 75;
            this.btnClearSelectedApartment.Text = "Clear the Selected Apartment";
            this.btnClearSelectedApartment.UseVisualStyleBackColor = true;
            this.btnClearSelectedApartment.Click += new System.EventHandler(this.btnClearSelectedApartment_Click);
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(172, 469);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(675, 196);
            this.txtComments.TabIndex = 118;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 117;
            this.label1.Text = "Leave a Comment : ";
            // 
            // txtLeasedPostedDate
            // 
            this.txtLeasedPostedDate.Enabled = false;
            this.txtLeasedPostedDate.Location = new System.Drawing.Point(567, 411);
            this.txtLeasedPostedDate.Multiline = true;
            this.txtLeasedPostedDate.Name = "txtLeasedPostedDate";
            this.txtLeasedPostedDate.Size = new System.Drawing.Size(205, 26);
            this.txtLeasedPostedDate.TabIndex = 116;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(443, 414);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 115;
            this.label12.Text = "Lease Posted Date : ";
            // 
            // txtOccupantParkingSlotNeeded
            // 
            this.txtOccupantParkingSlotNeeded.Location = new System.Drawing.Point(172, 413);
            this.txtOccupantParkingSlotNeeded.Multiline = true;
            this.txtOccupantParkingSlotNeeded.Name = "txtOccupantParkingSlotNeeded";
            this.txtOccupantParkingSlotNeeded.Size = new System.Drawing.Size(205, 26);
            this.txtOccupantParkingSlotNeeded.TabIndex = 114;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(52, 416);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 13);
            this.label11.TabIndex = 113;
            this.label11.Text = "Parking Slot Needed : ";
            // 
            // txtDurationOfLease
            // 
            this.txtDurationOfLease.Location = new System.Drawing.Point(971, 413);
            this.txtDurationOfLease.Multiline = true;
            this.txtDurationOfLease.Name = "txtDurationOfLease";
            this.txtDurationOfLease.Size = new System.Drawing.Size(205, 26);
            this.txtDurationOfLease.TabIndex = 112;

            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(847, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 13);
            this.label10.TabIndex = 111;
            this.label10.Text = "Duration of the Lease : ";
            // 
            // txtOccupantContactNo
            // 
            this.txtOccupantContactNo.Location = new System.Drawing.Point(936, 351);
            this.txtOccupantContactNo.Multiline = true;
            this.txtOccupantContactNo.Name = "txtOccupantContactNo";
            this.txtOccupantContactNo.Size = new System.Drawing.Size(205, 26);
            this.txtOccupantContactNo.TabIndex = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(854, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 109;
            this.label4.Text = "Contact No : ";
            // 
            // txtOccupantAddress
            // 
            this.txtOccupantAddress.Location = new System.Drawing.Point(635, 351);
            this.txtOccupantAddress.Multiline = true;
            this.txtOccupantAddress.Name = "txtOccupantAddress";
            this.txtOccupantAddress.Size = new System.Drawing.Size(205, 26);
            this.txtOccupantAddress.TabIndex = 108;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(575, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 107;
            this.label5.Text = "Address : ";
            // 
            // txtOccupantNIC
            // 
            this.txtOccupantNIC.Location = new System.Drawing.Point(360, 348);
            this.txtOccupantNIC.Multiline = true;
            this.txtOccupantNIC.Name = "txtOccupantNIC";
            this.txtOccupantNIC.Size = new System.Drawing.Size(205, 26);
            this.txtOccupantNIC.TabIndex = 106;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(310, 351);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 105;
            this.label8.Text = "NIC : ";
            // 
            // txtOccupantName
            // 
            this.txtOccupantName.Location = new System.Drawing.Point(100, 345);
            this.txtOccupantName.Multiline = true;
            this.txtOccupantName.Name = "txtOccupantName";
            this.txtOccupantName.Size = new System.Drawing.Size(205, 26);
            this.txtOccupantName.TabIndex = 104;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(50, 351);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(44, 13);
            this.label14.TabIndex = 103;
            this.label14.Text = "Name : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(50, 299);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 102;
            this.label15.Text = "Customer Details";
            // 
            // btnClearAllText
            // 
            this.btnClearAllText.Location = new System.Drawing.Point(890, 549);
            this.btnClearAllText.Name = "btnClearAllText";
            this.btnClearAllText.Size = new System.Drawing.Size(286, 23);
            this.btnClearAllText.TabIndex = 119;
            this.btnClearAllText.Text = "Clear All Text";
            this.btnClearAllText.UseVisualStyleBackColor = true;
            this.btnClearAllText.Click += new System.EventHandler(this.btnClearAllText_Click);
            // 
            // CustomerViewApartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 789);
            this.Controls.Add(this.btnClearAllText);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLeasedPostedDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtOccupantParkingSlotNeeded);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDurationOfLease);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtOccupantContactNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOccupantAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOccupantNIC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtOccupantName);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnClearSelectedApartment);
            this.Controls.Add(this.txtApartmentLocation);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotalParkingSlot);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApartmentNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuildingNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLeaseSelectedApartment);
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
        private System.Windows.Forms.TextBox txtApartmentLocation;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalParkingSlot;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtApartmentNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuildingNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLeaseSelectedApartment;
        private System.Windows.Forms.Button btnClearSelectedApartment;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLeasedPostedDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtOccupantParkingSlotNeeded;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDurationOfLease;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtOccupantContactNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOccupantAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtOccupantNIC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOccupantName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnClearAllText;
    }
}