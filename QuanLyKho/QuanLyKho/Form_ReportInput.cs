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
    public partial class Form_ReportInput : Form
    {
        public Form_ReportInput()
        {
            InitializeComponent();
            Loaddata();
        }

        public Form_ReportInput(string id, string link)
        {
            InitializeComponent();
            GetFileInvoice(id, link);            
        }

        private void Form_ReportInput_Load(object sender, EventArgs e)
        {

        }
        private void Loaddata()
        {
            this.reportViewer1.RefreshReport();
            // TODO: This line of code loads data into the 'Database1DataSet.Enterprise' table.You can move, or remove it, as needed.
            this.EnterpriseTableAdapter.Fill(this.Database1DataSet.Enterprise);
            // TODO: This line of code loads data into the 'Database1DataSet.inputinfor_infor' table. You can move, or remove it, as needed.
            this.inputinfor_inforTableAdapter.Fill(this.Database1DataSet.inputinfor_infor, Form_ListInput.IdInput);                        
        }
        public void GetFileInvoice(string id, string link)
        {
            this.reportViewer1.RefreshReport();
            // TODO: This line of code loads data into the 'Database1DataSet.Enterprise' table. You can move, or remove it, as needed.
            this.EnterpriseTableAdapter.Fill(this.Database1DataSet.Enterprise);
            // TODO: This line of code loads data into the 'Database1DataSet.inputinfor_infor' table. You can move, or remove it, as needed.
            this.inputinfor_inforTableAdapter.Fill(this.Database1DataSet.inputinfor_infor, id);
            

            byte[] temp = reportViewer1.LocalReport.Render("PDF");
            var fullpath = Path.Combine(link, id.ToString() + ".pdf");
            File.WriteAllBytes(fullpath, temp);
        }
    }
}
