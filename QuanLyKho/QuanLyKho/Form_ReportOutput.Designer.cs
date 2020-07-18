namespace QuanLyKho
{
    partial class Form_ReportOutput
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ReportOutput));
            this.EnterpriseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database2 = new QuanLyKho.Database2();
            this.deliverybillinfor_inforBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.EnterpriseTableAdapter = new QuanLyKho.Database2TableAdapters.EnterpriseTableAdapter();
            this.deliverybillinfor_inforTableAdapter = new QuanLyKho.Database2TableAdapters.deliverybillinfor_inforTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.EnterpriseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliverybillinfor_inforBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EnterpriseBindingSource
            // 
            this.EnterpriseBindingSource.DataMember = "Enterprise";
            this.EnterpriseBindingSource.DataSource = this.Database2;
            // 
            // Database2
            // 
            this.Database2.DataSetName = "Database2";
            this.Database2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliverybillinfor_inforBindingSource
            // 
            this.deliverybillinfor_inforBindingSource.DataMember = "deliverybillinfor_infor";
            this.deliverybillinfor_inforBindingSource.DataSource = this.Database2;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.EnterpriseBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.deliverybillinfor_inforBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyKho.Output.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(704, 521);
            this.reportViewer1.TabIndex = 0;
            // 
            // EnterpriseTableAdapter
            // 
            this.EnterpriseTableAdapter.ClearBeforeFill = true;
            // 
            // deliverybillinfor_inforTableAdapter
            // 
            this.deliverybillinfor_inforTableAdapter.ClearBeforeFill = true;
            // 
            // Form_ReportOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 521);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_ReportOutput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ReportOutput";
            this.Load += new System.EventHandler(this.Form_ReportOutput_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EnterpriseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliverybillinfor_inforBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource EnterpriseBindingSource;
        private Database2 Database2;
        private System.Windows.Forms.BindingSource deliverybillinfor_inforBindingSource;
        private Database2TableAdapters.EnterpriseTableAdapter EnterpriseTableAdapter;
        private Database2TableAdapters.deliverybillinfor_inforTableAdapter deliverybillinfor_inforTableAdapter;
    }
}