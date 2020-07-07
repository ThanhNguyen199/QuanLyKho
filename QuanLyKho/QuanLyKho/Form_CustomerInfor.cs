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
    public partial class Form_CustomerInfor : Form
    {
        public Form_CustomerInfor()
        {
            InitializeComponent();
        }
        int chon;
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_CustomerInfor_Load(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_taxcode.Text = ""; 
            txt_buyer.Text = "";
            txt_legalname.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_address.Text = "";
            txt_note.Text = "";

            txt_id.Enabled = false;
            txt_buyer.Enabled = false;
            txt_taxcode.Enabled = false;
            txt_legalname.Enabled = false;
            txt_phone.Enabled = false;
            txt_email.Enabled = false;
            txt_address.Enabled = false;
            txt_note.Enabled = false;

            string query = "select IdRole from Users where UserName = N'" + Form_Login.userlogin + "'";
            if (DataProvider.Instance.ExcuteScalar(query).ToString() == "VANCHUYEN")
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
            dgv_data.DataSource = DataProvider.Instance.ExcuteQuery("exec customer_listinfor", new object[] { });
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_id.Text = "";
            txt_taxcode.Text = "";
            txt_buyer.Text = "";
            txt_legalname.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_address.Text = "";
            txt_note.Text = "";

            txt_id.Enabled = true;
            txt_buyer.Enabled = true;
            txt_taxcode.Enabled = true;
            txt_legalname.Enabled = true;
            txt_phone.Enabled = true;
            txt_email.Enabled = true;
            txt_address.Enabled = true;
            txt_note.Enabled = true;

            btn_add.Enabled = false;
            btn_change.Enabled = false;
            btn_save.Enabled = true;
            btn_cancel.Enabled = true;
            chon = 1;
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            txt_buyer.Enabled = true;
            txt_taxcode.Enabled = true;
            txt_legalname.Enabled = true;
            txt_phone.Enabled = true;
            txt_email.Enabled = true;
            txt_address.Enabled = true;
            txt_note.Enabled = true;

            btn_add.Enabled = false;
            btn_change.Enabled = false;
            btn_save.Enabled = true;
            btn_cancel.Enabled = true;
            chon = 2;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_id.Text != "" && txt_taxcode.Text != "" &&txt_buyer.Text != "" && txt_legalname.Text != "" && txt_phone.Text != "" && txt_email.Text != "" && txt_address.Text != "")
            {
                if (chon == 1)
                {
                    string id = txt_id.Text;
                    string tax = txt_taxcode.Text.Trim();
                    string buyer = txt_buyer.Text;
                    string legalname = txt_legalname.Text;
                    string address = txt_address.Text;
                    string phone = txt_phone.Text;
                    string email = txt_email.Text;
                    string note = txt_note.Text;

                    string query = "exec customer_insert @Id , @BuyerName , @BuyerLegaName , @Taxcode " +
                        ", @Address , @Phone , @Email , @MoreInfo ";
                    if (DataProvider.Instance.ExcuteNunQuery(query,
                        new object[] { id,  buyer, legalname, tax, address, phone, email, note }) > 0)
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK);
                        Form_CustomerInfor_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else if (chon == 2)
                {
                    string id = txt_id.Text;
                    string tax = txt_taxcode.Text.Trim();
                    string buyer = txt_buyer.Text;
                    string legalname = txt_legalname.Text;
                    string address = txt_address.Text;
                    string phone = txt_phone.Text;
                    string email = txt_email.Text;
                    string note = txt_note.Text;

                    string query = "exec customer_update @Id , @BuyerName , @BuyerLegaName , @Taxcode " +
                        ", @Address , @Phone , @Email , @MoreInfo ";
                    if (DataProvider.Instance.ExcuteNunQuery(query,
                        new object[] { id, buyer, legalname, tax, address, phone, email, note }) > 0)
                    {
                        MessageBox.Show("Thay đổi thành công!", "Thông báo", MessageBoxButtons.OK);
                        Form_CustomerInfor_Load(sender, e);
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
            Form_CustomerInfor_Load(sender, e);
        }

        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_data.CurrentRow.Index;
            txt_id.Text = dgv_data.Rows[i].Cells[0].Value.ToString();
            txt_taxcode.Text = dgv_data.Rows[i].Cells[1].Value.ToString();
            txt_buyer.Text = dgv_data.Rows[i].Cells[2].Value.ToString();
            txt_legalname.Text = dgv_data.Rows[i].Cells[3].Value.ToString();
            txt_phone.Text = dgv_data.Rows[i].Cells[4].Value.ToString();
            txt_email.Text = dgv_data.Rows[i].Cells[5].Value.ToString();
            txt_address.Text = dgv_data.Rows[i].Cells[6].Value.ToString();
            txt_note.Text = dgv_data.Rows[i].Cells[7].Value.ToString();
        }
    }
}
