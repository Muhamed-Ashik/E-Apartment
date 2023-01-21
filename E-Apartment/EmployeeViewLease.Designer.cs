namespace E_Apartment
{
    partial class EmployeeViewLease
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
            this.btnLeaseSearch = new System.Windows.Forms.Button();
            this.txtLeaseSearch = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dgwLeaseList = new System.Windows.Forms.DataGridView();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwLeaseList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeaseSearch
            // 
            this.btnLeaseSearch.BackColor = System.Drawing.Color.Green;
            this.btnLeaseSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLeaseSearch.ForeColor = System.Drawing.Color.White;
            this.btnLeaseSearch.Location = new System.Drawing.Point(1080, 89);
            this.btnLeaseSearch.Name = "btnLeaseSearch";
            this.btnLeaseSearch.Size = new System.Drawing.Size(140, 34);
            this.btnLeaseSearch.TabIndex = 171;
            this.btnLeaseSearch.Text = "Search";
            this.btnLeaseSearch.UseVisualStyleBackColor = false;
            this.btnLeaseSearch.Click += new System.EventHandler(this.btnLeaseSearch_Click);
            // 
            // txtLeaseSearch
            // 
            this.txtLeaseSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtLeaseSearch.Location = new System.Drawing.Point(732, 89);
            this.txtLeaseSearch.Multiline = true;
            this.txtLeaseSearch.Name = "txtLeaseSearch";
            this.txtLeaseSearch.Size = new System.Drawing.Size(342, 34);
            this.txtLeaseSearch.TabIndex = 170;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label13.Location = new System.Drawing.Point(380, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(350, 17);
            this.label13.TabIndex = 169;
            this.label13.Text = "Building / Aparmtent Number / Location / Name / NIC:  ";
            // 
            // dgwLeaseList
            // 
            this.dgwLeaseList.AllowDrop = true;
            this.dgwLeaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwLeaseList.Location = new System.Drawing.Point(28, 141);
            this.dgwLeaseList.Name = "dgwLeaseList";
            this.dgwLeaseList.Size = new System.Drawing.Size(1196, 148);
            this.dgwLeaseList.TabIndex = 168;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1063, 31);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(161, 41);
            this.btnLogout.TabIndex = 167;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnViewDashboard
            // 
            this.btnViewDashboard.BackColor = System.Drawing.Color.Green;
            this.btnViewDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnViewDashboard.ForeColor = System.Drawing.Color.White;
            this.btnViewDashboard.Location = new System.Drawing.Point(896, 31);
            this.btnViewDashboard.Name = "btnViewDashboard";
            this.btnViewDashboard.Size = new System.Drawing.Size(161, 41);
            this.btnViewDashboard.TabIndex = 166;
            this.btnViewDashboard.Text = "View Dashboard";
            this.btnViewDashboard.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 165;
            this.label1.Text = "View Lease";
            // 
            // EmployeeViewLease
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1236, 333);
            this.Controls.Add(this.btnLeaseSearch);
            this.Controls.Add(this.txtLeaseSearch);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dgwLeaseList);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewDashboard);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeViewLease";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeViewLease";
            ((System.ComponentModel.ISupportInitialize)(this.dgwLeaseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLeaseSearch;
        private System.Windows.Forms.TextBox txtLeaseSearch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgwLeaseList;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewDashboard;
        private System.Windows.Forms.Label label1;
    }
}