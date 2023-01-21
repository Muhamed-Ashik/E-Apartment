namespace E_Apartment
{
    partial class EmployeeViewApartments
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
            this.btnApartmentSearch = new System.Windows.Forms.Button();
            this.txtApartmentSearch = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgwViewApartmentList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwViewApartmentList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApartmentSearch
            // 
            this.btnApartmentSearch.BackColor = System.Drawing.Color.Green;
            this.btnApartmentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnApartmentSearch.ForeColor = System.Drawing.Color.White;
            this.btnApartmentSearch.Location = new System.Drawing.Point(1086, 63);
            this.btnApartmentSearch.Name = "btnApartmentSearch";
            this.btnApartmentSearch.Size = new System.Drawing.Size(140, 34);
            this.btnApartmentSearch.TabIndex = 38;
            this.btnApartmentSearch.Text = "Search";
            this.btnApartmentSearch.UseVisualStyleBackColor = false;
            this.btnApartmentSearch.Click += new System.EventHandler(this.btnApartmentSearch_Click);
            // 
            // txtApartmentSearch
            // 
            this.txtApartmentSearch.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtApartmentSearch.Location = new System.Drawing.Point(738, 63);
            this.txtApartmentSearch.Multiline = true;
            this.txtApartmentSearch.Name = "txtApartmentSearch";
            this.txtApartmentSearch.Size = new System.Drawing.Size(342, 34);
            this.txtApartmentSearch.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(465, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Apartment / Building Number / Location :  ";
            // 
            // dgwViewApartmentList
            // 
            this.dgwViewApartmentList.AllowDrop = true;
            this.dgwViewApartmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwViewApartmentList.Location = new System.Drawing.Point(34, 103);
            this.dgwViewApartmentList.Name = "dgwViewApartmentList";
            this.dgwViewApartmentList.Size = new System.Drawing.Size(1196, 148);
            this.dgwViewApartmentList.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 31);
            this.label1.TabIndex = 39;
            this.label1.Text = "View Apartments";
            // 
            // EmployeeViewApartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1253, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnApartmentSearch);
            this.Controls.Add(this.txtApartmentSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgwViewApartmentList);
            this.Name = "EmployeeViewApartments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeViewApartments";
            ((System.ComponentModel.ISupportInitialize)(this.dgwViewApartmentList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApartmentSearch;
        private System.Windows.Forms.TextBox txtApartmentSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgwViewApartmentList;
        private System.Windows.Forms.Label label1;
    }
}