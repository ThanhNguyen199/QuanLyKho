using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class Form_ListOutputInfor : Form
    {
        public Form_ListOutputInfor()
        {
            InitializeComponent();
        }
        private void Form_ListOutputInfor_Load(object sender, EventArgs e)
        {
            dgv_data.AutoGenerateColumns = false;
            dgv_data.Enabled = false;
            dgv_data.DataSource = DataProvider.Instance.ExcuteQuery("exec product_listoutputinfor @IdOutput", 
                new object[] { Form_ListOutput.IdOutput });

            lb_idinput.Text = Form_ListOutput.IdOutput;
            lb_customer.Text = Form_ListOutput.CustomerOutput;
            lb_user.Text = Form_ListOutput.UserOutput;
            lb_date.Text = Form_ListOutput.DateOutput;

            string query = "exec customer_buyerleganame @IdOutput";
            lb_supplier.Text = DataProvider.Instance.ExcuteScalar(query,
                new object[] { Form_ListOutput.IdOutput }).ToString();

            query = "select PriceTotal from DeliveryBill where Id = N'" + Form_ListOutput.IdOutput + "'";
            string giatri = DataProvider.Instance.ExcuteScalar(query).ToString();
            lb_pricetotal.Text = Convert.ToDouble(giatri).ToString("N0") + " VNĐ";
        }

        private void dgv_data_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgv_data.Rows.Count - 1; i++)
            {
                dgv_data.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            Form_ReportOutput f = new Form_ReportOutput();
            f.ShowDialog();
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dl = new FolderBrowserDialog();
            if (dl.ShowDialog(this) == DialogResult.OK)
            {
                Form_ReportOutput f = new Form_ReportOutput(Form_ListOutput.IdOutput, dl.SelectedPath);
                MessageBox.Show("Export done ");
            }
        }
    }
}
