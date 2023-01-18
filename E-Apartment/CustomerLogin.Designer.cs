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
            this.SuspendLayout();
            // 
            // btnCustomerClearAllText
            // 
            this.btnCustomerClearAllText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCustomerClearAllText.Location = new System.Drawing.Point(366, 315);
            this.btnCustomerClearAllText.Name = "btnCustomerClearAllText";
            this.btnCustomerClearAllText.Size = new System.Drawing.Size(183, 45);
            this.btnCustomerClearAllText.TabIndex = 13;
            this.btnCustomerClearAllText.Text = "Clear All Text";
            this.btnCustomerClearAllText.UseVisualStyleBackColor = true;
            this.btnCustomerClearAllText.Click += new System.EventHandler(this.btnCustomerClearAllText_Click);
            // 
            // btnCustomerLogin
            // 
            this.btnCustomerLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCustomerLogin.Location = new System.Drawing.Point(157, 315);
            this.btnCustomerLogin.Name = "btnCustomerLogin";
            this.btnCustomerLogin.Size = new System.Drawing.Size(183, 45);
            this.btnCustomerLogin.TabIndex = 12;
            this.btnCustomerLogin.Text = "Login";
            this.btnCustomerLogin.UseVisualStyleBackColor = true;
            this.btnCustomerLogin.Click += new System.EventHandler(this.btnCustomerLogin_Click);
            // 
            // txtCustomerLoginPassword
            // 
            this.txtCustomerLoginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerLoginPassword.Location = new System.Drawing.Point(226, 229);
            this.txtCustomerLoginPassword.Multiline = true;
            this.txtCustomerLoginPassword.Name = "txtCustomerLoginPassword";
            this.txtCustomerLoginPassword.Size = new System.Drawing.Size(292, 29);
            this.txtCustomerLoginPassword.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(129, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password: ";
            // 
            // txtCustomerLoginUsername
            // 
            this.txtCustomerLoginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerLoginUsername.Location = new System.Drawing.Point(226, 167);
            this.txtCustomerLoginUsername.Multiline = true;
            this.txtCustomerLoginUsername.Name = "txtCustomerLoginUsername";
            this.txtCustomerLoginUsername.Size = new System.Drawing.Size(292, 29);
            this.txtCustomerLoginUsername.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(129, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(308, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Customer Login";
            // 
            // CustomerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCustomerClearAllText);
            this.Controls.Add(this.btnCustomerLogin);
            this.Controls.Add(this.txtCustomerLoginPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerLoginUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerLogin";
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
    }
}