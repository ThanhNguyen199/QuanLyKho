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
    public partial class Form_ListInputInfor : Form
    {
        public Form_ListInputInfor()
        {
            InitializeComponent();
        }

        private void Form_ListInputInfor_Load(object sender, EventArgs e)
        {
            dgv_data.AutoGenerateColumns = false;
            dgv_data.Enabled = false;
            dgv_data.DataSource = DataProvider.Instance.ExcuteQuery("exec product_listinputinfor @IdInput", new object[] { Form_ListInput.IdInput });

            lb_idinput.Text = Form_ListInput.IdInput;
            lb_supplier.Text = Form_ListInput.SupllierInput;
            lb_user.Text = Form_ListInput.UserInput;
            lb_date.Text = Form_ListInput.DateInput;

            string query = "select PriceTotal from Input where Id = N'" + Form_ListInput.IdInput + "'";
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
            Form_ReportInput f = new Form_ReportInput();
            f.ShowDialog();
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dl = new FolderBrowserDialog();
            if (dl.ShowDialog(this) == DialogResult.OK)
            {
                Form_ReportInput f = new Form_ReportInput(Form_ListInput.IdInput, dl.SelectedPath);
                MessageBox.Show("Export done ");
            }
        }
    }
}
