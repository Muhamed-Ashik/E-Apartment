namespace E_Apartment
{
    partial class CustomerSignUp
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
            this.btnClearTextAll = new System.Windows.Forms.Button();
            this.btnCustomerSignUp = new System.Windows.Forms.Button();
            this.txtCustomerPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblIamAdmin = new System.Windows.Forms.Label();
            this.lblLoginPage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClearTextAll
            // 
            this.btnClearTextAll.BackColor = System.Drawing.Color.Red;
            this.btnClearTextAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClearTextAll.Location = new System.Drawing.Point(481, 305);
            this.btnClearTextAll.Name = "btnClearTextAll";
            this.btnClearTextAll.Size = new System.Drawing.Size(131, 45);
            this.btnClearTextAll.TabIndex = 13;
            this.btnClearTextAll.Text = "Clear All Text";
            this.btnClearTextAll.UseVisualStyleBackColor = false;
            this.btnClearTextAll.Click += new System.EventHandler(this.btnClearTextAll_Click);
            // 
            // btnCustomerSignUp
            // 
            this.btnCustomerSignUp.BackColor = System.Drawing.Color.Green;
            this.btnCustomerSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCustomerSignUp.Location = new System.Drawing.Point(320, 305);
            this.btnCustomerSignUp.Name = "btnCustomerSignUp";
            this.btnCustomerSignUp.Size = new System.Drawing.Size(134, 45);
            this.btnCustomerSignUp.TabIndex = 12;
            this.btnCustomerSignUp.Text = "SignUp";
            this.btnCustomerSignUp.UseVisualStyleBackColor = false;
            this.btnCustomerSignUp.Click += new System.EventHandler(this.btnCustomerSignUp_Click);
            // 
            // txtCustomerPassword
            // 
            this.txtCustomerPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCustomerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerPassword.Location = new System.Drawing.Point(355, 212);
            this.txtCustomerPassword.Multiline = true;
            this.txtCustomerPassword.Name = "txtCustomerPassword";
            this.txtCustomerPassword.Size = new System.Drawing.Size(292, 29);
            this.txtCustomerPassword.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(213, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password: ";
            // 
            // txtCustomerUsername
            // 
            this.txtCustomerUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCustomerUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerUsername.Location = new System.Drawing.Point(355, 150);
            this.txtCustomerUsername.Multiline = true;
            this.txtCustomerUsername.Name = "txtCustomerUsername";
            this.txtCustomerUsername.Size = new System.Drawing.Size(292, 29);
            this.txtCustomerUsername.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(213, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label1.Location = new System.Drawing.Point(320, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer SignUp";
            // 
            // lblIamAdmin
            // 
            this.lblIamAdmin.AutoSize = true;
            this.lblIamAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblIamAdmin.ForeColor = System.Drawing.Color.Green;
            this.lblIamAdmin.Location = new System.Drawing.Point(716, 9);
            this.lblIamAdmin.Name = "lblIamAdmin";
            this.lblIamAdmin.Size = new System.Drawing.Size(137, 25);
            this.lblIamAdmin.TabIndex = 14;
            this.lblIamAdmin.Text = "I am an Admin";
            this.lblIamAdmin.Click += new System.EventHandler(this.lblIamAdmin_Click);
            // 
            // lblLoginPage
            // 
            this.lblLoginPage.AutoSize = true;
            this.lblLoginPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblLoginPage.ForeColor = System.Drawing.Color.Green;
            this.lblLoginPage.Location = new System.Drawing.Point(521, 268);
            this.lblLoginPage.Name = "lblLoginPage";
            this.lblLoginPage.Size = new System.Drawing.Size(44, 18);
            this.lblLoginPage.TabIndex = 15;
            this.lblLoginPage.Text = "Login";
            this.lblLoginPage.Click += new System.EventHandler(this.lblLoginPage_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(389, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Already a Member:  ";
            // 
            // CustomerSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(865, 455);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLoginPage);
            this.Controls.Add(this.lblIamAdmin);
            this.Controls.Add(this.btnClearTextAll);
            this.Controls.Add(this.btnCustomerSignUp);
            this.Controls.Add(this.txtCustomerPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerSignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClearTextAll;
        private System.Windows.Forms.Button btnCustomerSignUp;
        private System.Windows.Forms.TextBox txtCustomerPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIamAdmin;
        private System.Windows.Forms.Label lblLoginPage;
        private System.Windows.Forms.Label label5;
    }
}