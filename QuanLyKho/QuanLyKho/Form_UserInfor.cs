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
    public partial class Form_UserInfor : Form
    {
        public Form_UserInfor()
        {
            InitializeComponent();
        }

        private DataTable Infor(string username)
        {
            string query = "exec user_info @username";
            return DataProvider.Instance.ExcuteQuery(query,
                new object[] { username });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            panel_change.Visible = true;
            btn_change.Enabled = false;
            btn_changepass.Visible = false;
            txt4.Enabled = true;
            txt5.Enabled = true;
            txt6.Enabled = true;
            dateTimePicker1.Enabled = true;
            txt8.Enabled = true;
            txt9.Enabled = true;
            txt10.Enabled = true;
        }

        private void form_UserInfor_Load(object sender, EventArgs e)
        {
            btn_changepass.Visible = true;
            btn_change.Enabled = true;
            panel_change.Visible = false;
            txt1.Enabled = false;
            txt2.Enabled = false;
            txt4.Enabled = false;
            txt5.Enabled = false;
            txt6.Enabled = false;
            dateTimePicker1.Enabled = false;
            txt8.Enabled = false;
            txt9.Enabled = false;
            txt10.Enabled = false;
            txt1.Text = Form_Login.userlogin;
            DataTable dt = Infor(txt1.Text);
            foreach (DataRow row in dt.Rows)
            {
                txt2.Text = row["Description"].ToString();
                txt4.Text = row["DisplayName"].ToString();
                txt5.Text = row["CMND"].ToString();
                txt6.Text = row["Male"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row["DateOfBirth"]);
                txt8.Text = row["Phone"].ToString();
                txt9.Text = row["Email"].ToString();
                txt10.Text = row["Address"].ToString();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt6.Text.Trim().ToLower() == "nam"|| txt6.Text.Trim().ToLower() == "nữ")
            {
                string query = "exec user_update @username , @DisplayName , @CMND , @Male ," +
                " @DateOfBirth , @Phone , @Email , @Address ";
                if (DataProvider.Instance.ExcuteNunQuery(query,
                    new object[] { Form_Login.userlogin, txt4.Text, txt5.Text,
                        txt6.Text, dateTimePicker1.Value, txt8.Text, txt9.Text, txt10.Text }) > 0)
                {
                    MessageBox.Show("Thay đổi thành công!", "Thông báo", MessageBoxButtons.OK);
                    form_UserInfor_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Thay đổi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Nhập sai giới tính", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            form_UserInfor_Load(sender, e);
        }

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            Form_ChangePass f = new Form_ChangePass();
            f.ShowDialog();
        }
    }
}
