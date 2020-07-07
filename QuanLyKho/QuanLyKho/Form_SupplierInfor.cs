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
    public partial class Form_SupplierInfor : Form
    {
        public Form_SupplierInfor()
        {
            InitializeComponent();
        }
        int chon;
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_SupplierInfor_Load(object sender, EventArgs e)
        {
            txt_taxcode.Text = "";
            txt_name.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_address.Text = "";
            txt_note.Text = "";

            txt_taxcode.Enabled = false;
            txt_name.Enabled = false;
            txt_phone.Enabled = false;
            txt_email.Enabled = false;
            txt_address.Enabled = false;
            txt_note.Enabled = false;

            string query = "select IdRole from Users where UserName = N'" + Form_Login.userlogin + "'";
            if (DataProvider.Instance.ExcuteScalar(query).ToString() == "KETOAN" || DataProvider.Instance.ExcuteScalar(query).ToString() == "VANCHUYEN")
            {
                btn_add.Visible = false;
                btn_change.Visible = false;
                btn_save.Visible = false;
                btn_cancel.Visible = false;
            }

            btn_add.Enabled = true;
            btn_change.Enabled = true;
            btn_save.Enabled = false;
            btn_cancel.Enabled = false;

            dgv_data.AutoGenerateColumns = false;
            dgv_data.Enabled = true;
            dgv_data.DataSource = DataProvider.Instance.ExcuteQuery("exec supplier_listinfor", new object[] { });
        }

        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_data.CurrentRow.Index;
            txt_taxcode.Text = dgv_data.Rows[i].Cells[0].Value.ToString();
            txt_name.Text = dgv_data.Rows[i].Cells[1].Value.ToString();
            txt_phone.Text = dgv_data.Rows[i].Cells[2].Value.ToString();
            txt_email.Text = dgv_data.Rows[i].Cells[3].Value.ToString();
            txt_address.Text = dgv_data.Rows[i].Cells[4].Value.ToString();
            txt_note.Text = dgv_data.Rows[i].Cells[5].Value.ToString();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_taxcode.Text = "";
            txt_name.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_address.Text = "";
            txt_note.Text = "";

            txt_taxcode.Enabled = true;
            txt_name.Enabled = true;
            txt_phone.Enabled = true;
            txt_email.Enabled = true;
            txt_address.Enabled = true;
            txt_note.Enabled = true;

            btn_add.Enabled = false;
            btn_change.Enabled = false;
            btn_save.Enabled = true;
            btn_cancel.Enabled = true;
            dgv_data.Enabled = false;
            chon = 1;
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if (txt_taxcode.Text != "")
            {
                txt_name.Enabled = true;
                txt_phone.Enabled = true;
                txt_email.Enabled = true;
                txt_address.Enabled = true;
                txt_note.Enabled = true;

                btn_add.Enabled = false;
                btn_change.Enabled = false;
                btn_save.Enabled = true;
                btn_cancel.Enabled = true;
                dgv_data.Enabled = false;
                chon = 2;
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 đối tượng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_taxcode.Text != "" && txt_name.Text != "" && txt_phone.Text != "" && txt_email.Text != "" && txt_address.Text != "")
            {
                if (chon == 1)
                {
                    string tax = txt_taxcode.Text.Trim();
                    string name = txt_name.Text;
                    string phone = txt_phone.Text;
                    string email = txt_email.Text;
                    string address = txt_address.Text;
                    string note = txt_note.Text;

                    string query = "exec supplier_insert @TaxCode , @DisplayName , @Address " +
                        ", @Phone , @Email , @MoreInfo ";
                    if (DataProvider.Instance.ExcuteNunQuery(query,
                        new object[] { tax, name, address, phone, email, note }) > 0)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK);
                        Form_SupplierInfor_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else if (chon == 2)
                {
                    string tax = txt_taxcode.Text.Trim();
                    string name = txt_name.Text;
                    string phone = txt_phone.Text;
                    string email = txt_email.Text;
                    string address = txt_address.Text;
                    string note = txt_note.Text;

                    string query = "exec supplier_update @TaxCode , @DisplayName , @Address " +
                        ", @Phone , @Email , @MoreInfo ";
                    if (DataProvider.Instance.ExcuteNunQuery(query,
                        new object[] { tax, name, address, phone, email, note }) > 0)
                    {
                        MessageBox.Show("Thay đổi thành công!", "Thông báo", MessageBoxButtons.OK);
                        Form_SupplierInfor_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }                    
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Form_SupplierInfor_Load(sender, e);
        }
    }
}
