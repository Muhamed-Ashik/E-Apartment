namespace E_Apartment
{
    partial class AdminDashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnManageEmployees = new System.Windows.Forms.Button();
            this.btnManageBuildings = new System.Windows.Forms.Button();
            this.btnAdminLogout = new System.Windows.Forms.Button();
            this.btnAdminManageReports = new System.Windows.Forms.Button();
            this.btnAdminManageLease = new System.Windows.Forms.Button();
            this.btnAdminManageCustomer = new System.Windows.Forms.Button();
            this.btnAdminManageApartments = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalLeaseApprovedCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalLeaseRequestCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblTotalApartmentsCount = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnManageEmployees);
            this.panel1.Controls.Add(this.btnManageBuildings);
            this.panel1.Controls.Add(this.btnAdminLogout);
            this.panel1.Controls.Add(this.btnAdminManageReports);
            this.panel1.Controls.Add(this.btnAdminManageLease);
            this.panel1.Controls.Add(this.btnAdminManageCustomer);
            this.panel1.Controls.Add(this.btnAdminManageApartments);
            this.panel1.Location = new System.Drawing.Point(4, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 120);
            this.panel1.TabIndex = 0;
            // 
            // btnManageEmployees
            // 
            this.btnManageEmployees.BackColor = System.Drawing.Color.Green;
            this.btnManageEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnManageEmployees.Location = new System.Drawing.Point(523, 59);
            this.btnManageEmployees.Name = "btnManageEmployees";
            this.btnManageEmployees.Size = new System.Drawing.Size(148, 41);
            this.btnManageEmployees.TabIndex = 11;
            this.btnManageEmployees.Text = "Manage Employees";
            this.btnManageEmployees.UseVisualStyleBackColor = false;
            this.btnManageEmployees.Click += new System.EventHandler(this.btnManageEmployees_Click);
            // 
            // btnManageBuildings
            // 
            this.btnManageBuildings.BackColor = System.Drawing.Color.Green;
            this.btnManageBuildings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnManageBuildings.Location = new System.Drawing.Point(464, 12);
            this.btnManageBuildings.Name = "btnManageBuildings";
            this.btnManageBuildings.Size = new System.Drawing.Size(144, 41);
            this.btnManageBuildings.TabIndex = 10;
            this.btnManageBuildings.Text = "Manage Building";
            this.btnManageBuildings.UseVisualStyleBackColor = false;
            this.btnManageBuildings.Click += new System.EventHandler(this.btnManageBuildings_Click);
            // 
            // btnAdminLogout
            // 
            this.btnAdminLogout.BackColor = System.Drawing.Color.Red;
            this.btnAdminLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdminLogout.Location = new System.Drawing.Point(1070, 12);
            this.btnAdminLogout.Name = "btnAdminLogout";
            this.btnAdminLogout.Size = new System.Drawing.Size(139, 41);
            this.btnAdminLogout.TabIndex = 9;
            this.btnAdminLogout.Text = "Logout";
            this.btnAdminLogout.UseVisualStyleBackColor = false;
            this.btnAdminLogout.Click += new System.EventHandler(this.btnAdminLogout_Click);
            // 
            // btnAdminManageReports
            // 
            this.btnAdminManageReports.BackColor = System.Drawing.Color.Green;
            this.btnAdminManageReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdminManageReports.Location = new System.Drawing.Point(301, 59);
            this.btnAdminManageReports.Name = "btnAdminManageReports";
            this.btnAdminManageReports.Size = new System.Drawing.Size(139, 41);
            this.btnAdminManageReports.TabIndex = 6;
            this.btnAdminManageReports.Text = "Manage Reports";
            this.btnAdminManageReports.UseVisualStyleBackColor = false;
            // 
            // btnAdminManageLease
            // 
            this.btnAdminManageLease.BackColor = System.Drawing.Color.Green;
            this.btnAdminManageLease.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdminManageLease.ForeColor = System.Drawing.Color.Black;
            this.btnAdminManageLease.Location = new System.Drawing.Point(89, 59);
            this.btnAdminManageLease.Name = "btnAdminManageLease";
            this.btnAdminManageLease.Size = new System.Drawing.Size(139, 41);
            this.btnAdminManageLease.TabIndex = 4;
            this.btnAdminManageLease.Text = "Manage Lease";
            this.btnAdminManageLease.UseVisualStyleBackColor = false;
            this.btnAdminManageLease.Click += new System.EventHandler(this.btnAdminManageLease_Click);
            // 
            // btnAdminManageCustomer
            // 
            this.btnAdminManageCustomer.BackColor = System.Drawing.Color.Green;
            this.btnAdminManageCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdminManageCustomer.Location = new System.Drawing.Point(242, 12);
            this.btnAdminManageCustomer.Name = "btnAdminManageCustomer";
            this.btnAdminManageCustomer.Size = new System.Drawing.Size(144, 41);
            this.btnAdminManageCustomer.TabIndex = 2;
            this.btnAdminManageCustomer.Text = "Manage Customers";
            this.btnAdminManageCustomer.UseVisualStyleBackColor = false;
            // 
            // btnAdminManageApartments
            // 
            this.btnAdminManageApartments.BackColor = System.Drawing.Color.Green;
            this.btnAdminManageApartments.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAdminManageApartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdminManageApartments.Location = new System.Drawing.Point(30, 12);
            this.btnAdminManageApartments.Name = "btnAdminManageApartments";
            this.btnAdminManageApartments.Size = new System.Drawing.Size(150, 41);
            this.btnAdminManageApartments.TabIndex = 0;
            this.btnAdminManageApartments.Text = "Manage Apartments";
            this.btnAdminManageApartments.UseVisualStyleBackColor = false;
            this.btnAdminManageApartments.Click += new System.EventHandler(this.btnAdminManageApartments_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblTotalLeaseApprovedCount);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(18, 330);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(309, 144);
            this.panel3.TabIndex = 2;
            // 
            // lblTotalLeaseApprovedCount
            // 
            this.lblTotalLeaseApprovedCount.AutoSize = true;
            this.lblTotalLeaseApprovedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalLeaseApprovedCount.ForeColor = System.Drawing.Color.Green;
            this.lblTotalLeaseApprovedCount.Location = new System.Drawing.Point(174, 50);
            this.lblTotalLeaseApprovedCount.Name = "lblTotalLeaseApprovedCount";
            this.lblTotalLeaseApprovedCount.Size = new System.Drawing.Size(18, 20);
            this.lblTotalLeaseApprovedCount.TabIndex = 1;
            this.lblTotalLeaseApprovedCount.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(36, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Buildings : ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lblTotalLeaseRequestCount);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(333, 330);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(293, 144);
            this.panel4.TabIndex = 3;
            // 
            // lblTotalLeaseRequestCount
            // 
            this.lblTotalLeaseRequestCount.AutoSize = true;
            this.lblTotalLeaseRequestCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalLeaseRequestCount.ForeColor = System.Drawing.Color.Green;
            this.lblTotalLeaseRequestCount.Location = new System.Drawing.Point(219, 49);
            this.lblTotalLeaseRequestCount.Name = "lblTotalLeaseRequestCount";
            this.lblTotalLeaseRequestCount.Size = new System.Drawing.Size(18, 20);
            this.lblTotalLeaseRequestCount.TabIndex = 1;
            this.lblTotalLeaseRequestCount.Text = "7";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(36, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Lease Request : ";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.lblTotalApartmentsCount);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Location = new System.Drawing.Point(632, 330);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(291, 144);
            this.panel5.TabIndex = 4;
            // 
            // lblTotalApartmentsCount
            // 
            this.lblTotalApartmentsCount.AutoSize = true;
            this.lblTotalApartmentsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalApartmentsCount.ForeColor = System.Drawing.Color.Green;
            this.lblTotalApartmentsCount.Location = new System.Drawing.Point(227, 50);
            this.lblTotalApartmentsCount.Name = "lblTotalApartmentsCount";
            this.lblTotalApartmentsCount.Size = new System.Drawing.Size(18, 20);
            this.lblTotalApartmentsCount.TabIndex = 1;
            this.lblTotalApartmentsCount.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(66, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total Apartments  : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(933, 330);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 144);
            this.panel2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(201, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(58, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Customers : ";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1238, 639);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdminManageApartments;
        private System.Windows.Forms.Button btnAdminManageCustomer;
        private System.Windows.Forms.Button btnAdminManageReports;
        private System.Windows.Forms.Button btnAdminManageLease;
        private System.Windows.Forms.Button btnAdminLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTotalLeaseApprovedCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblTotalLeaseRequestCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblTotalApartmentsCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnManageEmployees;
        private System.Windows.Forms.Button btnManageBuildings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}