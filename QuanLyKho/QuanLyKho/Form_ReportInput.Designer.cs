namespace QuanLyKho
{
    partial class Form_ReportInput
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Database1DataSet = new QuanLyKho.Database1DataSet();
            this.EnterpriseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.EnterpriseTableAdapter = new QuanLyKho.Database1DataSetTableAdapters.EnterpriseTableAdapter();
            this.inputinfor_inforBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inputinfor_inforTableAdapter = new QuanLyKho.Database1DataSetTableAdapters.inputinfor_inforTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnterpriseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputinfor_inforBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.EnterpriseBindingSource;
            reportDataSource4.Name = "DataSet2";
            reportDataSource4.Value = this.inputinfor_inforBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyKho.Input.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(704, 521);
            this.reportViewer1.TabIndex = 0;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EnterpriseBindingSource
            // 
            this.EnterpriseBindingSource.DataMember = "Enterprise";
            this.EnterpriseBindingSource.DataSource = this.Database1DataSet;
            // 
            // EnterpriseTableAdapter
            // 
            this.EnterpriseTableAdapter.ClearBeforeFill = true;
            // 
            // inputinfor_inforBindingSource
            // 
            this.inputinfor_inforBindingSource.DataMember = "inputinfor_infor";
            this.inputinfor_inforBindingSource.DataSource = this.Database1DataSet;
            // 
            // inputinfor_inforTableAdapter
            // 
            this.inputinfor_inforTableAdapter.ClearBeforeFill = true;
            // 
            // Form_ReportInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 521);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_ReportInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ReportInput";
            this.Load += new System.EventHandler(this.Form_ReportInput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnterpriseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputinfor_inforBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EnterpriseBindingSource;
        private Database1DataSet Database1DataSet;
        private System.Windows.Forms.BindingSource inputinfor_inforBindingSource;
        private Database1DataSetTableAdapters.EnterpriseTableAdapter EnterpriseTableAdapter;
        private Database1DataSetTableAdapters.inputinfor_inforTableAdapter inputinfor_inforTableAdapter;
    }
}