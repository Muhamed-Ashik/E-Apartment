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
            this.btnCustomerTextClear = new System.Windows.Forms.Button();
            this.btnCustomerSignUp = new System.Windows.Forms.Button();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdminUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCustomerTextClear
            // 
            this.btnCustomerTextClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCustomerTextClear.Location = new System.Drawing.Point(427, 362);
            this.btnCustomerTextClear.Name = "btnCustomerTextClear";
            this.btnCustomerTextClear.Size = new System.Drawing.Size(183, 45);
            this.btnCustomerTextClear.TabIndex = 13;
            this.btnCustomerTextClear.Text = "Clear";
            this.btnCustomerTextClear.UseVisualStyleBackColor = true;
            // 
            // btnCustomerSignUp
            // 
            this.btnCustomerSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCustomerSignUp.Location = new System.Drawing.Point(218, 362);
            this.btnCustomerSignUp.Name = "btnCustomerSignUp";
            this.btnCustomerSignUp.Size = new System.Drawing.Size(183, 45);
            this.btnCustomerSignUp.TabIndex = 12;
            this.btnCustomerSignUp.Text = "Login";
            this.btnCustomerSignUp.UseVisualStyleBackColor = true;
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAdminPassword.Location = new System.Drawing.Point(302, 217);
            this.txtAdminPassword.Multiline = true;
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.Size = new System.Drawing.Size(292, 29);
            this.txtAdminPassword.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(143, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password: ";
            // 
            // txtAdminUsername
            // 
            this.txtAdminUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAdminUsername.Location = new System.Drawing.Point(302, 155);
            this.txtAdminUsername.Multiline = true;
            this.txtAdminUsername.Name = "txtAdminUsername";
            this.txtAdminUsername.Size = new System.Drawing.Size(292, 29);
            this.txtAdminUsername.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(143, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(322, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer SignUp";
            // 
            // txtCustomerConfirmPassword
            // 
            this.txtCustomerConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerConfirmPassword.Location = new System.Drawing.Point(302, 282);
            this.txtCustomerConfirmPassword.Multiline = true;
            this.txtCustomerConfirmPassword.Name = "txtCustomerConfirmPassword";
            this.txtCustomerConfirmPassword.Size = new System.Drawing.Size(292, 29);
            this.txtCustomerConfirmPassword.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(143, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Confirm Password: ";
            // 
            // CustomerSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCustomerConfirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCustomerTextClear);
            this.Controls.Add(this.btnCustomerSignUp);
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdminUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerSignUp";
            this.Text = "Customer SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCustomerTextClear;
        private System.Windows.Forms.Button btnCustomerSignUp;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdminUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerConfirmPassword;
        private System.Windows.Forms.Label label4;
    }
}