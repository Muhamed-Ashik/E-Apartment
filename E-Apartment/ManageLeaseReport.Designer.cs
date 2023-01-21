namespace E_Apartment
{
    partial class ManageLeaseReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.___E_ApartmentDataSet = new E_Apartment.@__E_ApartmentDataSet();
            this.tblOccupantLeaseDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_Occupant_Lease_DetailsTableAdapter = new E_Apartment.@__E_ApartmentDataSetTableAdapters.Tbl_Occupant_Lease_DetailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.___E_ApartmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOccupantLeaseDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "LeaseDataSet";
            reportDataSource1.Value = this.tblOccupantLeaseDetailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "E_Apartment.ManageLeaseReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 96);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1200, 480);
            this.reportViewer1.TabIndex = 0;
            // 
            // ___E_ApartmentDataSet
            // 
            this.___E_ApartmentDataSet.DataSetName = "__E_ApartmentDataSet";
            this.___E_ApartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblOccupantLeaseDetailsBindingSource
            // 
            this.tblOccupantLeaseDetailsBindingSource.DataMember = "Tbl_Occupant_Lease_Details";
            this.tblOccupantLeaseDetailsBindingSource.DataSource = this.___E_ApartmentDataSet;
            // 
            // tbl_Occupant_Lease_DetailsTableAdapter
            // 
            this.tbl_Occupant_Lease_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // ManageLeaseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 623);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ManageLeaseReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageLeaseReport";
            this.Load += new System.EventHandler(this.ManageLeaseReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.___E_ApartmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblOccupantLeaseDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private __E_ApartmentDataSet ___E_ApartmentDataSet;
        private System.Windows.Forms.BindingSource tblOccupantLeaseDetailsBindingSource;
        private __E_ApartmentDataSetTableAdapters.Tbl_Occupant_Lease_DetailsTableAdapter tbl_Occupant_Lease_DetailsTableAdapter;
    }
}