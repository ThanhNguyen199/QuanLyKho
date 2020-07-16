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
    public partial class Form_ListInventory : Form
    {
        public Form_ListInventory()
        {
            InitializeComponent();
        }
        public static string IdInput;
        private DataTable Update(string taxcode)
        {
            string query = "exec enterprise_insertpricetotal @taxcode";
            return DataProvider.Instance.ExcuteQuery(query,
                new object[] { taxcode });
        }

        private DataTable Product(string taxcode)
        {
            string query = "exec product_inventoryofsupplier @Idsupplier ";
            return DataProvider.Instance.ExcuteQuery(query,
                new object[] { taxcode });
        }

        private DataTable ProductInfor()
        {
            string query = "exec product_inforinventory";
            return DataProvider.Instance.ExcuteQuery(query,
                new object[] {});
        }

        private void Form_ListInventory_Load(object sender, EventArgs e)
        {
            btn_cancel.Visible = false;

            cbb_taxcode.DataSource = DataProvider.Instance.ExcuteQuery("select * from Supplier");
            cbb_taxcode.DisplayMember = "TaxCode";
            cbb_taxcode.ValueMember = "TaxCode";
            cbb_taxcode.Text = "";

            dgv_data.AutoGenerateColumns = false;
            dgv_data.Enabled = true;
            dgv_data.DataSource = ProductInfor();

            lb_supplier.Text = "";
            lb_phone.Text = "";
            lb_mail.Text = "";
            lb_note.Text = "";
            lb_address.Text = "";

            string tam = "0123456789";
            Update(tam);
            string query = "select WareHousePrice from Enterprise where Taxcode = N'" + tam + "'";
            string giatri = DataProvider.Instance.ExcuteScalar(query).ToString();
            lb_price.Text = Convert.ToDouble(giatri).ToString("N0") + " VNĐ";
        }

        private void dgv_data_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgv_data.Rows.Count - 1; i++)
            {
                dgv_data.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_data.CurrentRow.Index;
            IdInput = dgv_data.Rows[i].Cells[1].Value.ToString();

        }

        private void cbb_taxcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from Supplier where TaxCode = N'" + cbb_taxcode.Text + "'";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow r in dt.Rows)
            {
                lb_supplier.Text = r["DisplayName"].ToString();
                lb_phone.Text = r["Phone"].ToString();
                lb_mail.Text = r["Email"].ToString();
                lb_note.Text = r["MoreInfo"].ToString();
                lb_address.Text = r["Address"].ToString();
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            btn_cancel.Visible = true;

            dgv_data.AutoGenerateColumns = false;
            dgv_data.Enabled = true;
            dgv_data.DataSource = Product(cbb_taxcode.Text);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Form_ListInventory_Load(sender, e);
        }
    }
}
