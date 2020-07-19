using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private bool isEmail(string inputEmail)
        {
            inputEmail = inputEmail ?? string.Empty;
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        private void Form_CustomerInfor_Load(object sender, EventArgs e)
        {
            lb_id.Text = "";
            txt_taxcode.Text = ""; 
            txt_buyer.Text = "";
            txt_legalname.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_address.Text = "";
            txt_note.Text = "";
            
            txt_buyer.Enabled = false;
            txt_taxcode.Enabled = false;
            txt_legalname.Enabled = false;
            txt_phone.Enabled = false;
            txt_email.Enabled = false;
            txt_address.Enabled = false;
            txt_note.Enabled = false;

            btn_add.Visible = true;
            btn_change.Visible = false;
            btn_save.Visible = false;
            btn_cancel.Visible = false;
            btn_list.Visible = true;
            btn_lock.Visible = false;
            btn_unlock.Visible = false;

            btn_add.Enabled = true;
            btn_change.Enabled = true;
            btn_list.Enabled = true;

            string query = "select IdRole from Users where UserName = N'" + Form_Login.userlogin + "'";
            if (DataProvider.Instance.ExcuteScalar(query).ToString() == "VANCHUYEN")
            {
                btn_add.Visible = false;
                btn_change.Visible = false;
                btn_save.Visible = false;
                btn_cancel.Visible = false;
                btn_list.Visible = false;
                btn_lock.Visible = false;
                btn_unlock.Visible = false;
            }            

            dgv_data.AutoGenerateColumns = false;
            dgv_data.Enabled = true;
            dgv_data.DataSource = DataProvider.Instance.ExcuteQuery("exec customer_listinfor", new object[] { });
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            lb_id.Text = DataProvider.Instance.ExcuteScalar("exec AutoCustomer").ToString();
            txt_taxcode.Text = "";
            txt_buyer.Text = "";
            txt_legalname.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_address.Text = "";
            txt_note.Text = "";
            i = 0;
            
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
            if (lb_id.Text != "" && txt_taxcode.Text != "" &&txt_buyer.Text != "" && txt_legalname.Text != "" && txt_phone.Text != "" && txt_email.Text != "" && txt_address.Text != "")
            {
                if (isEmail(txt_email.Text))
                {
                    if (chon == 1)
                    {
                        string id = lb_id.Text;
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
                            new object[] { id, buyer, legalname, tax, address, phone, email, note }) > 0)
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
                        string id = lb_id.Text;
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
                else
                {
                    MessageBox.Show("Mail không đúng định dạng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Form_CustomerInfor_Load(sender, e);
        }
        int i;
        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(btn_list.Enabled == true)
            {
                btn_add.Visible = true;
                btn_change.Visible = true;
                btn_save.Visible = false;
                btn_cancel.Visible = true;
                btn_list.Visible = true;
                btn_lock.Visible = true;
                btn_unlock.Visible = false;
            }
            else
            {
                btn_add.Visible = false;
                btn_change.Visible = false;
                btn_save.Visible = false;
                btn_cancel.Visible = true;
                btn_list.Visible = true;
                btn_lock.Visible = false;
                btn_unlock.Visible = true;
            }

            string query = "select IdRole from Users where UserName = N'" + Form_Login.userlogin + "'";
            if (DataProvider.Instance.ExcuteScalar(query).ToString() == "VANCHUYEN")
            {
                btn_add.Visible = false;
                btn_change.Visible = false;
                btn_save.Visible = false;
                btn_cancel.Visible = false;
                btn_list.Visible = false;
                btn_lock.Visible = false;
                btn_unlock.Visible = false;
            }

            i = dgv_data.CurrentRow.Index;
            lb_id.Text = dgv_data.Rows[i].Cells[1].Value.ToString();
            txt_taxcode.Text = dgv_data.Rows[i].Cells[2].Value.ToString();
            txt_buyer.Text = dgv_data.Rows[i].Cells[3].Value.ToString();
            txt_legalname.Text = dgv_data.Rows[i].Cells[4].Value.ToString();
            txt_phone.Text = dgv_data.Rows[i].Cells[5].Value.ToString();
            txt_email.Text = dgv_data.Rows[i].Cells[6].Value.ToString();
            txt_address.Text = dgv_data.Rows[i].Cells[7].Value.ToString();
            txt_note.Text = dgv_data.Rows[i].Cells[8].Value.ToString();
        }

        private void dgv_data_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgv_data.Rows.Count - 1; i++)
            {
                dgv_data.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void txt_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            i = 0;
            btn_add.Visible = false;
            btn_change.Visible = false;
            btn_save.Visible = false;
            btn_cancel.Visible = true;
            btn_list.Visible = true;
            btn_list.Enabled = false;
            btn_lock.Visible = false;
            btn_unlock.Visible = true;
            dgv_data.DataSource = DataProvider.Instance.ExcuteQuery("exec customer_listinforlock", new object[] { });
        }

        private void btn_lock_Click(object sender, EventArgs e)
        {
            if (DataProvider.Instance.ExcuteNunQuery("exec customer_lock @Taxcode", new object[] { dgv_data.Rows[i].Cells[1].Value.ToString() }) > 0)
            {
                MessageBox.Show("Xoá thành công!", "Thông báo");
                Form_CustomerInfor_Load(sender, e);
            }
        }

        private void btn_unlock_Click(object sender, EventArgs e)
        {
            if (DataProvider.Instance.ExcuteNunQuery("exec customer_unlock @Taxcode", new object[] { dgv_data.Rows[i].Cells[1].Value.ToString() }) > 0)
            {
                MessageBox.Show("Khôi phục thành công!", "Thông báo");
                dgv_data.DataSource = DataProvider.Instance.ExcuteQuery("exec customer_listinforlock", new object[] { });
            }
        }
    }
}
