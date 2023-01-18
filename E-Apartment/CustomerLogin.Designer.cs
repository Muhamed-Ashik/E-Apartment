namespace E_Apartment
{
    partial class CustomerLogin
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
            this.btnCustomerClearAllText = new System.Windows.Forms.Button();
            this.btnCustomerLogin = new System.Windows.Forms.Button();
            this.txtCustomerLoginPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerLoginUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblIamAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCustomerClearAllText
            // 
            this.btnCustomerClearAllText.BackColor = System.Drawing.Color.Red;
            this.btnCustomerClearAllText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCustomerClearAllText.Location = new System.Drawing.Point(489, 304);
            this.btnCustomerClearAllText.Name = "btnCustomerClearAllText";
            this.btnCustomerClearAllText.Size = new System.Drawing.Size(157, 45);
            this.btnCustomerClearAllText.TabIndex = 13;
            this.btnCustomerClearAllText.Text = "Clear All Text";
            this.btnCustomerClearAllText.UseVisualStyleBackColor = false;
            this.btnCustomerClearAllText.Click += new System.EventHandler(this.btnCustomerClearAllText_Click);
            // 
            // btnCustomerLogin
            // 
            this.btnCustomerLogin.BackColor = System.Drawing.Color.Green;
            this.btnCustomerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCustomerLogin.ForeColor = System.Drawing.Color.Black;
            this.btnCustomerLogin.Location = new System.Drawing.Point(336, 304);
            this.btnCustomerLogin.Name = "btnCustomerLogin";
            this.btnCustomerLogin.Size = new System.Drawing.Size(147, 45);
            this.btnCustomerLogin.TabIndex = 12;
            this.btnCustomerLogin.Text = "Login";
            this.btnCustomerLogin.UseVisualStyleBackColor = false;
            this.btnCustomerLogin.Click += new System.EventHandler(this.btnCustomerLogin_Click);
            // 
            // txtCustomerLoginPassword
            // 
            this.txtCustomerLoginPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCustomerLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerLoginPassword.Location = new System.Drawing.Point(315, 199);
            this.txtCustomerLoginPassword.Multiline = true;
            this.txtCustomerLoginPassword.Name = "txtCustomerLoginPassword";
            this.txtCustomerLoginPassword.Size = new System.Drawing.Size(331, 29);
            this.txtCustomerLoginPassword.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(218, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password: ";
            // 
            // txtCustomerLoginUsername
            // 
            this.txtCustomerLoginUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCustomerLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerLoginUsername.Location = new System.Drawing.Point(315, 137);
            this.txtCustomerLoginUsername.Multiline = true;
            this.txtCustomerLoginUsername.Name = "txtCustomerLoginUsername";
            this.txtCustomerLoginUsername.Size = new System.Drawing.Size(331, 29);
            this.txtCustomerLoginUsername.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(218, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(309, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(311, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Want become a Member : ";
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblSignUp.ForeColor = System.Drawing.Color.Green;
            this.lblSignUp.Location = new System.Drawing.Point(486, 254);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(56, 18);
            this.lblSignUp.TabIndex = 15;
            this.lblSignUp.Text = "SignUp";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // lblIamAdmin
            // 
            this.lblIamAdmin.AutoSize = true;
            this.lblIamAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblIamAdmin.ForeColor = System.Drawing.Color.Green;
            this.lblIamAdmin.Location = new System.Drawing.Point(651, 9);
            this.lblIamAdmin.Name = "lblIamAdmin";
            this.lblIamAdmin.Size = new System.Drawing.Size(137, 25);
            this.lblIamAdmin.TabIndex = 16;
            this.lblIamAdmin.Text = "I am an Admin";
            this.lblIamAdmin.Click += new System.EventHandler(this.lblIamAdmin_Click);
            // 
            // CustomerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIamAdmin);
            this.Controls.Add(this.lblSignUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCustomerClearAllText);
            this.Controls.Add(this.btnCustomerLogin);
            this.Controls.Add(this.txtCustomerLoginPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerLoginUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerClearAllText;
        private System.Windows.Forms.Button btnCustomerLogin;
        private System.Windows.Forms.TextBox txtCustomerLoginPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerLoginUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblIamAdmin;
    }
}