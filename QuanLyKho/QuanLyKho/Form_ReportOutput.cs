using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class Form_ReportOutput : Form
    {
        public Form_ReportOutput()
        {
            InitializeComponent();
            loaddata();
        }

        public Form_ReportOutput(string id, string link)
        {
            InitializeComponent();
            GetFileInvoice(id, link);
        }

        private void loaddata()
        {
            // TODO: This line of code loads data into the 'DataSet2.Enterprise' table. You can move, or remove it, as needed.
            this.EnterpriseTableAdapter.Fill(this.Database2.Enterprise);
            // TODO: This line of code loads data into the 'DataSet2.deliverybillinfor_infor' table. You can move, or remove it, as needed.
            this.deliverybillinfor_inforTableAdapter.Fill(this.Database2.deliverybillinfor_infor, Form_ListOutput.IdOutput);

            this.reportViewer1.RefreshReport();
        }

        private void Form_ReportOutput_Load(object sender, EventArgs e)
        {

        }
        public void GetFileInvoice(string id, string link)
        {

            // TODO: This line of code loads data into the 'DataSet2.Enterprise' table. You can move, or remove it, as needed.
            this.EnterpriseTableAdapter.Fill(this.Database2.Enterprise);
            // TODO: This line of code loads data into the 'DataSet2.deliverybillinfor_infor' table. You can move, or remove it, as needed.
            this.deliverybillinfor_inforTableAdapter.Fill(this.Database2.deliverybillinfor_infor, id);

            this.reportViewer1.RefreshReport();

            byte[] temp = reportViewer1.LocalReport.Render("PDF");
            var fullpath = Path.Combine(link, id.ToString() + ".pdf");
            File.WriteAllBytes(fullpath, temp);
        }
    }
}
