using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class Form_ChangePass : Form
    {
        public Form_ChangePass()
        {
            InitializeComponent();
        }

        private string Encrypt(string pass)
        {
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            return sb.ToString();

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_pass.Text == Form_Login.passlogin)
            {
                if(txt_newpass1.Text == txt_newpass2.Text)
                {
                    string query = "exec user_updateaccout @username , @password ";
                    if (DataProvider.Instance.ExcuteNunQuery(query,
                        new object[] { Form_Login.userlogin, Encrypt(txt_newpass1.Text) }) > 0)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                        Form_Login.passlogin = txt_newpass1.Text;
                        this.Close();
                    }
                    else
                    {
                        lb_notification.Text = "Lỗi không xác định";
                    }
                }
                else
                {
                    lb_notification.Text = "Mật khẩu nhập lại không trùng!";
                }
            }
            else
            {
                lb_notification.Text = "Mật khẩu cũ không đúng!";
            }
        }

        private void Form_ChangePass_Load(object sender, EventArgs e)
        {
            lb_notification.Text = "";
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            Form_ChangePass_Load(sender, e);
        }

        private void txt_newpass1_TextChanged(object sender, EventArgs e)
        {
            Form_ChangePass_Load(sender, e);
        }

        private void txt_newpass2_TextChanged(object sender, EventArgs e)
        {
            Form_ChangePass_Load(sender, e);
        }
    }
}
