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
            this.SuspendLayout();
            // 
            // btnClearTextAll
            // 
            this.btnClearTextAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClearTextAll.Location = new System.Drawing.Point(426, 314);
            this.btnClearTextAll.Name = "btnClearTextAll";
            this.btnClearTextAll.Size = new System.Drawing.Size(183, 45);
            this.btnClearTextAll.TabIndex = 13;
            this.btnClearTextAll.Text = "Clear All Text";
            this.btnClearTextAll.UseVisualStyleBackColor = true;
            this.btnClearTextAll.Click += new System.EventHandler(this.btnClearTextAll_Click);
            // 
            // btnCustomerSignUp
            // 
            this.btnCustomerSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCustomerSignUp.Location = new System.Drawing.Point(217, 314);
            this.btnCustomerSignUp.Name = "btnCustomerSignUp";
            this.btnCustomerSignUp.Size = new System.Drawing.Size(183, 45);
            this.btnCustomerSignUp.TabIndex = 12;
            this.btnCustomerSignUp.Text = "SignUp";
            this.btnCustomerSignUp.UseVisualStyleBackColor = true;
            this.btnCustomerSignUp.Click += new System.EventHandler(this.btnCustomerSignUp_Click);
            // 
            // txtCustomerPassword
            // 
            this.txtCustomerPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerPassword.Location = new System.Drawing.Point(302, 217);
            this.txtCustomerPassword.Multiline = true;
            this.txtCustomerPassword.Name = "txtCustomerPassword";
            this.txtCustomerPassword.Size = new System.Drawing.Size(292, 29);
            this.txtCustomerPassword.TabIndex = 11;
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
            // txtCustomerUsername
            // 
            this.txtCustomerUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCustomerUsername.Location = new System.Drawing.Point(302, 155);
            this.txtCustomerUsername.Multiline = true;
            this.txtCustomerUsername.Name = "txtCustomerUsername";
            this.txtCustomerUsername.Size = new System.Drawing.Size(292, 29);
            this.txtCustomerUsername.TabIndex = 9;
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
            // CustomerSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearTextAll);
            this.Controls.Add(this.btnCustomerSignUp);
            this.Controls.Add(this.txtCustomerPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerSignUp";
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
    }
}