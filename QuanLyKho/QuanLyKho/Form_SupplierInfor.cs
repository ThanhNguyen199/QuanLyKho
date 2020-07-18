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
    public partial class Form_SupplierInfor : Form
    {
        public Form_SupplierInfor()
        {
            InitializeComponent();
        }
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
        int chon;

        private void Form_SupplierInfor_Load(object sender, EventArgs e)
        {
            btn_add.Visible = true;
            btn_change.Visible = false;
            btn_save.Visible = false;
            btn_cancel.Visible = false;

            btn_add.Enabled = true;
            btn_change.Enabled = true;

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

            dgv_data.AutoGenerateColumns = false;
            dgv_data.Enabled = true;
            dgv_data.DataSource = DataProvider.Instance.ExcuteQuery("exec supplier_listinfor", new object[] { });
        }

        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_add.Visible = true;
            btn_change.Visible = true; 

            int i = dgv_data.CurrentRow.Index;
            txt_taxcode.Text = dgv_data.Rows[i].Cells[1].Value.ToString();
            txt_name.Text = dgv_data.Rows[i].Cells[2].Value.ToString();
            txt_phone.Text = dgv_data.Rows[i].Cells[3].Value.ToString();
            txt_email.Text = dgv_data.Rows[i].Cells[4].Value.ToString();
            txt_address.Text = dgv_data.Rows[i].Cells[5].Value.ToString();
            txt_note.Text = dgv_data.Rows[i].Cells[6].Value.ToString();
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
            btn_change.Visible = false;
            btn_save.Visible = true;
            btn_cancel.Visible = true;
            dgv_data.Enabled = false;
            chon = 1;
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            btn_add.Visible = false;
            btn_change.Enabled = false;
            btn_save.Visible = true;
            btn_cancel.Visible = true;

            txt_name.Enabled = true;
            txt_phone.Enabled = true;
            txt_email.Enabled = true;
            txt_address.Enabled = true;
            txt_note.Enabled = true;            
            
            dgv_data.Enabled = false;
            chon = 2;            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_taxcode.Text != "" && txt_name.Text != "" && txt_phone.Text != "" && txt_email.Text != "" && txt_address.Text != "")
            {
                if (isEmail(txt_email.Text))
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
                else
                {
                    MessageBox.Show("Mail sai định dạng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Form_SupplierInfor_Load(sender, e);
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
    }
}
