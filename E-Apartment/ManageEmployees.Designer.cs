namespace E_Apartment
{
    partial class ManageEmployees
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
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnViewDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwUserList = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbxUserType = new System.Windows.Forms.ComboBox();
            this.btnClearAllText = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnInsertUser = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwUserList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(912, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(161, 41);
            this.btnLogout.TabIndex = 127;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnViewDashboard
            // 
            this.btnViewDashboard.BackColor = System.Drawing.Color.Green;
            this.btnViewDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnViewDashboard.ForeColor = System.Drawing.Color.White;
            this.btnViewDashboard.Location = new System.Drawing.Point(745, 12);
            this.btnViewDashboard.Name = "btnViewDashboard";
            this.btnViewDashboard.Size = new System.Drawing.Size(161, 41);
            this.btnViewDashboard.TabIndex = 126;
            this.btnViewDashboard.Text = "View Dashboard";
            this.btnViewDashboard.UseVisualStyleBackColor = false;
            this.btnViewDashboard.Click += new System.EventHandler(this.btnViewDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 125;
            this.label1.Text = "Manage Employee";
            // 
            // dgwUserList
            // 
            this.dgwUserList.AllowDrop = true;
            this.dgwUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwUserList.Location = new System.Drawing.Point(649, 59);
            this.dgwUserList.Name = "dgwUserList";
            this.dgwUserList.Size = new System.Drawing.Size(425, 324);
            this.dgwUserList.TabIndex = 128;
            this.dgwUserList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwUserList_CellDoubleClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label16.Location = new System.Drawing.Point(12, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(132, 20);
            this.label16.TabIndex = 162;
            this.label16.Text = "Employee Details";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 233);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 160;
            this.label8.Text = "User Type : ";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtUsername.Location = new System.Drawing.Point(103, 171);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(487, 26);
            this.txtUsername.TabIndex = 159;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 158;
            this.label14.Text = "Username : ";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtPassword.Location = new System.Drawing.Point(103, 288);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(487, 26);
            this.txtPassword.TabIndex = 164;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 163;
            this.label2.Text = "Password : ";
            // 
            // cmbxUserType
            // 
            this.cmbxUserType.FormattingEnabled = true;
            this.cmbxUserType.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.cmbxUserType.Location = new System.Drawing.Point(103, 233);
            this.cmbxUserType.Name = "cmbxUserType";
            this.cmbxUserType.Size = new System.Drawing.Size(487, 21);
            this.cmbxUserType.TabIndex = 165;
            // 
            // btnClearAllText
            // 
            this.btnClearAllText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnClearAllText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnClearAllText.ForeColor = System.Drawing.Color.White;
            this.btnClearAllText.Location = new System.Drawing.Point(451, 342);
            this.btnClearAllText.Name = "btnClearAllText";
            this.btnClearAllText.Size = new System.Drawing.Size(139, 41);
            this.btnClearAllText.TabIndex = 169;
            this.btnClearAllText.Text = "Clear All Text";
            this.btnClearAllText.UseVisualStyleBackColor = false;
            this.btnClearAllText.Click += new System.EventHandler(this.btnClearAllText_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.Red;
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(306, 342);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(139, 41);
            this.btnDeleteUser.TabIndex = 168;
            this.btnDeleteUser.Text = "Delete";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.Green;
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.White;
            this.btnUpdateUser.Location = new System.Drawing.Point(161, 342);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(139, 41);
            this.btnUpdateUser.TabIndex = 167;
            this.btnUpdateUser.Text = "Update";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnInsertUser
            // 
            this.btnInsertUser.BackColor = System.Drawing.Color.Green;
            this.btnInsertUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInsertUser.ForeColor = System.Drawing.Color.White;
            this.btnInsertUser.Location = new System.Drawing.Point(16, 342);
            this.btnInsertUser.Name = "btnInsertUser";
            this.btnInsertUser.Size = new System.Drawing.Size(139, 41);
            this.btnInsertUser.TabIndex = 166;
            this.btnInsertUser.Text = "Insert";
            this.btnInsertUser.UseVisualStyleBackColor = false;
            this.btnInsertUser.Click += new System.EventHandler(this.btnInsertUser_Click);
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(103, 116);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(91, 26);
            this.txtID.TabIndex = 171;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 170;
            this.label3.Text = "Record ID  : ";
            // 
            // ManageEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 422);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClearAllText);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnInsertUser);
            this.Controls.Add(this.cmbxUserType);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dgwUserList);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewDashboard);
            this.Controls.Add(this.label1);
            this.Name = "ManageEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Employees";
            ((System.ComponentModel.ISupportInitialize)(this.dgwUserList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnViewDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwUserList;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbxUserType;
        private System.Windows.Forms.Button btnClearAllText;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnInsertUser;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
    }
}