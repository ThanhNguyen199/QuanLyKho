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
    public partial class Form_InputProduct : Form
    {
        public Form_InputProduct()
        {
            InitializeComponent();
        }
        #region funtion
        private DataTable Product_Infor(string IdProduct)
        {
            string query = "exec product_infor @IdProduct ";
            return DataProvider.Instance.ExcuteQuery(query,
                new object[] { IdProduct });
        }

        public bool InsertInput(string Id, DateTime date,string name)
        {
            string query = "exec input_insert @Id , @DateInput , @IdUser ";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { Id, date, name }) > 0;
        }

        public bool Insert_InputInfor(string IdInput, string IdProduct, string IdSupplier, int Quantity, float Price)
        {
            string query = "exec inputinfor_insert @IdInput , @IdProduct , @IdSupplier , @Quantity , @Price ";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { IdInput, IdProduct, IdSupplier, Quantity, Price }) > 0;
        }

        public bool Delete_Input(string id)
        {
            string query = "delete form Input where IdInput = N'" + id + "'";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { id }) > 0;
        }

        public bool Delete_InputInfor(string id)
        {
            string query = "delete form InputInfo where IdInput = N'" + id + "'";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { id }) > 0;
        }

        public bool Update_PriceTotal(string Id)
        {
            string query = "exec input_insertpricetotal @IdInput ";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { Id }) > 0;
        }
        
        #endregion
        #region load
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_InputProduct_Load(object sender, EventArgs e)
        {
            while (dgv_data.Rows.Count > 1)
            {
                dgv_data.Rows.Clear();
            }
            grb_supplier.Enabled = false;
            panel_add.Visible = false;

            btn_save.Visible = false;
            btn_cancel.Visible = false;
            btn_add.Enabled = true;
            dgv_data.Enabled = false;

            name.DataSource = DataProvider.Instance.ExcuteQuery("select * from Product");
            name.ValueMember = "Id";
            name.DisplayMember = "DisplayName";


            cbb_taxcode.DataSource = DataProvider.Instance.ExcuteQuery("select * from Supplier");
            cbb_taxcode.DisplayMember = "TaxCode";
            cbb_taxcode.ValueMember = "TaxCode";
            cbb_taxcode.Text = "";

            cbb_user.DataSource = DataProvider.Instance.ExcuteQuery("select * from Users");
            cbb_user.DisplayMember = "DisplayName";
            cbb_user.ValueMember = "UserName";
            cbb_user.Text = "";

            lb_supplier.Text = "";
            lb_phone.Text = "";
            lb_mail.Text = "";
            lb_note.Text = "";
            lb_address.Text = "";
            sum_price = 0;
            row = 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cbb_taxcode.Text = "";
            lb_supplier.Text = "";
            lb_phone.Text = "";
            lb_mail.Text = "";
            lb_note.Text = "";
            lb_address.Text = "";
            txt_IdInput.Text = "PN";

            panel_add.Visible = true;
            grb_supplier.Enabled = true;

            btn_save.Visible = true;
            btn_cancel.Visible = true;
            btn_add.Enabled = false;
            dgv_data.Enabled = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Form_InputProduct_Load(sender, e);
        }
        #endregion
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dgv_data.Rows.Count > 1 && cbb_taxcode.Text != "")
            {
                string id = txt_IdInput.Text;
                DateTime date = dateTimePicker1.Value;

                string query = "select * from Input where Id = N'" + id + "'";
                if (DataProvider.Instance.ExcuteQuery(query).Rows.Count > 0)
                {
                    MessageBox.Show("Mã phiếu nhập đã tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        if (InsertInput(id, date, cbb_user.SelectedValue.ToString()))
                        {
                            int temp = 0;
                            for (int j = 0; j < dgv_data.Rows.Count - 1; j++)
                            {
                                string idproduct = dgv_data.Rows[j].Cells[1].Value.ToString();
                                string idsupplier = cbb_taxcode.SelectedValue.ToString();
                                int quantity = Convert.ToInt32(dgv_data.Rows[j].Cells[4].Value);
                                float price = (float)Convert.ToDouble(dgv_data.Rows[j].Cells[5].Value);

                                if (Insert_InputInfor(id, idproduct, idsupplier, quantity, price))
                                {
                                    temp += 1;
                                }
                            }
                            if (temp == dgv_data.Rows.Count - 1)
                            {
                                string mail = lb_mail.Text.Trim().ToLower().ToString();
                                MessageBox.Show("Lập phiếu nhập " + id + " thành công!", "", MessageBoxButtons.OK);
                                Update_PriceTotal(id);
                                Form_InputProduct_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Lập phiếu nhập " + id + " thất bại! Vui lòng thử lại sau.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Delete_Input(id);
                                Delete_InputInfor(id);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Cảnh báo", MessageBoxButtons.OK);
                        }
                    }
                    catch { }
                }                
            }
            else
            {
                MessageBox.Show("không được để trống thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #region data cbb_dgv
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
        int row;
        decimal sum_price;
        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }

        private void dgv_data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgv_data.Rows.Count - 1; i++)
            {
                dgv_data.Rows[i].Cells[0].Value = i + 1;
            }
            try
            {
                DataTable dt = Product_Infor(dgv_data.Rows[row].Cells[1].Value.ToString());
                foreach (DataRow r in dt.Rows)
                {
                    dgv_data.Rows[row].Cells[2].Value = r["unit"].ToString();
                    dgv_data.Rows[row].Cells[3].Value = r["Price"].ToString();
                }

                dgv_data.Rows[row].Cells[5].Value = Convert.ToDouble(dgv_data.Rows[row].Cells[3].Value) * Convert.ToDouble(dgv_data.Rows[row].Cells[4].Value);
                sum_price += (decimal)Convert.ToDouble(dgv_data.Rows[row].Cells[5].Value);
            }
            catch { }
        }
        #endregion

        private void txt_IdInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
