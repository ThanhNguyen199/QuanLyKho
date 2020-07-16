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
        public static string IdSupplier;
        #region funtion
        private Form activeForm = null;
        private void openNewForm(Form newForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

        private DataTable Product_Infor(string IdProduct)
        {
            string query = "exec product_infor @IdProduct ";
            return DataProvider.Instance.ExcuteQuery(query,
                new object[] { IdProduct });
        }

        private DataTable Product(string taxcode)
        {
            string query = "exec product_inforofsupplier @Idsupplier ";
            return DataProvider.Instance.ExcuteQuery(query,
                new object[] { taxcode });
        }

        public bool InsertInput(string Id, DateTime date, string name, string IdSupplier)
        {
            string query = "exec input_insert @Id , @DateInput , @IdUser , @IdSupplier";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { Id, date, name, IdSupplier }) > 0;
        }

        public bool Insert_InputInfor(string IdInput, string IdProduct, int Quantity, float Price)
        {
            string query = "exec inputinfor_insert @IdInput , @IdProduct , @Quantity , @Price ";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { IdInput, IdProduct, Quantity, Price }) > 0;
        }

        private DataTable Product_Inventory(string IdProduct, int Quantity)
        {
            string query = "exec input_insertinventory @IdProduct , @Quantity ";
            return DataProvider.Instance.ExcuteQuery(query,
                new object[] { IdProduct, Quantity });
        }

        private DataTable Product_DeleteInventory(string IdProduct, int Quantity)
        {
            string query = "exec input_deleteinventory @IdProduct , @Quantity ";
            return DataProvider.Instance.ExcuteQuery(query,
                new object[] { IdProduct, Quantity });
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
            if (panel_show.Visible == true)
            {
                panel_show.Visible = false;

                name.DataSource = Product(cbb_taxcode.Text);
                name.ValueMember = "Id";
                name.DisplayMember = "DisplayName";
            }
            else
            {
                this.Close();
            }
        }

        private void Form_InputProduct_Load(object sender, EventArgs e)
        {
            while (dgv_data.Rows.Count > 1)
            {
                dgv_data.Rows.Clear();
            }
            panel_show.Visible = false;
            grb_supplier.Enabled = false;
            panel_add.Visible = false;

            btn_save.Visible = false;
            btn_cancel.Visible = false;
            btn_addproduct.Visible = false;
            btn_add.Enabled = true;
            dgv_data.Enabled = false;
            
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

            lb_IdInput.Text = DataProvider.Instance.ExcuteScalar("exec AutoInput").ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            cbb_taxcode.Text = "";
            lb_supplier.Text = "";
            lb_phone.Text = "";
            lb_mail.Text = "";
            lb_note.Text = "";
            lb_address.Text = "";

            panel_add.Visible = true;
            grb_supplier.Enabled = true;
            dgv_data.Enabled = false;

            btn_save.Visible = true;
            btn_cancel.Visible = true;
            btn_addproduct.Visible = true;
            btn_add.Enabled = false;
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
                string id = lb_IdInput.Text;
                DateTime date = dateTimePicker1.Value;
                string userinput = cbb_user.SelectedValue.ToString();
                string idsupplier = cbb_taxcode.SelectedValue.ToString();

                try
                {
                    if (InsertInput(id, date, userinput, idsupplier))
                    {
                        int temp = 0;
                        for (int j = 0; j < dgv_data.Rows.Count - 1; j++)
                        {
                            string idproduct = dgv_data.Rows[j].Cells[1].Value.ToString();
                            int quantity = Convert.ToInt32(dgv_data.Rows[j].Cells[4].Value);
                            float price = (float)Convert.ToDouble(dgv_data.Rows[j].Cells[5].Value);

                            if (Insert_InputInfor(id, idproduct, quantity, price))
                            {
                                temp += 1;
                                Product_Inventory(idproduct, quantity);
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
                            for (int j = 0; j < dgv_data.Rows.Count - 1; j++)
                            {
                                string idproduct = dgv_data.Rows[j].Cells[1].Value.ToString();
                                int quantity = Convert.ToInt32(dgv_data.Rows[j].Cells[4].Value);

                                Product_DeleteInventory(idproduct, quantity);

                            }
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
            IdSupplier = cbb_taxcode.Text;
            dgv_data.Enabled = true;
            name.DataSource = Product(cbb_taxcode.Text);
            name.ValueMember = "Id";
            name.DisplayMember = "DisplayName";
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

        private void button1_Click(object sender, EventArgs e)
        {
            if(cbb_taxcode.Text != "")
            {
                panel_show.Visible = true;
                openNewForm(new Form_ProductInfor());
            }
            else
            {
                MessageBox.Show("Hãy chọn nhà cung cấp","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
