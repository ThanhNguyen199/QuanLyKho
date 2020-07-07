using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        #region function
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

        private bool SendMail(string displayname,string toMail, string verificationCode)
        {
            string bodyemail = "Xin Chào " + displayname + " Chúng Tôi Đã Nhận Được Yêu Cầu Cần Hổ Trợ Của Bạn: \n\n"
                                + "\t\t=> Mã Xác Minh Của Bạn Là: " + verificationCode;
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("tvfahasa@gmail.com");
                mail.To.Add(toMail);
                mail.Subject = "Công ty TNHH Thanh Nguyễn";
                mail.Body = bodyemail;
                SmtpClient smptClient = new SmtpClient();
                smptClient.Host = "smtp.gmail.com";
                System.Net.NetworkCredential credential = new NetworkCredential();
                credential.UserName = "congtythanhnguyen199@gmail.com";
                credential.Password = "Thanh123456789";
                smptClient.Credentials = credential;
                smptClient.Port = 587;
                smptClient.EnableSsl = true;
                smptClient.Send(mail);
                return true;
            }
            catch
            {
                return false;
            }
            
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

        private bool CheckLogin(string username, string password)
        {
            string query = "exec user_login @username , @password ";
            return DataProvider.Instance.ExcuteQuery(query, 
                new object[] { username, Encrypt(password) }).Rows.Count > 0;
        }

        private DataTable CheckMail(string username, string mail)
        {
            string query = "exec user_mail @username , @mail ";
            return DataProvider.Instance.ExcuteQuery(query,
                new object[] { username, mail });
        }
        #endregion
        public static string userlogin = "";
        public static string passlogin = "";
        private void form_Login_Load(object sender, EventArgs e)
        {
            panel_login.Visible = true;
            panel_mail.Visible = false;
            panel_changepass.Visible = false;

            lb_notification.Text = "";
            lb_notification.Visible = false;
            lb_notificationmail.Text = "";
            lb_notificationmail.Visible = false;
            lb_notificationPass.Text = "";
            lb_notificationPass.Visible = false;
        }
        #region Login
        private void txt_user_OnValueChanged(object sender, EventArgs e)
        {
            lb_notification.Visible = false;
        }

        private void txt_pass_OnValueChanged(object sender, EventArgs e)
        {
            txt_pass.isPassword = true;
            lb_notification.Visible = false;
        }
        
        private void btn_login_Click(object sender, EventArgs e)
        {
            string user = txt_user.Text.TrimEnd();
            string pass = txt_pass.Text;
            if (CheckLogin(user, pass))
            {
                userlogin = user;
                passlogin = pass;
                MessageBox.Show("Welcome!");
                Form_Main f = new Form_Main();
                this.Hide();
                f.Show();
            }
            else if ( txt_user.Text == "" || txt_pass.Text == "")
            {
                lb_notification.Visible = true;
                lb_notification.Text = "Không được để trống!";
            }
            else
            {
                lb_notification.Visible = true;
                lb_notification.Text = "Tài khoản hoặc mật khẩu không đúng, vui lòng nhập lại!";
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel_login.Visible = false;
            panel_mail.Visible = true;
        }
        #endregion
        #region Mail
        string xacnhan = "";
        private void txt_usermail_OnValueChanged(object sender, EventArgs e)
        {
            lb_notificationmail.Visible = false;
        }

        private void txt_mail_OnValueChanged(object sender, EventArgs e)
        {
            lb_notificationmail.Visible = false;
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {

            string user = txt_usermail.Text.TrimEnd().ToLower();
            string email = txt_mail.Text.Trim().ToLower();
            if (user != "" && email != "")
            {
                if (isEmail(email))
                {
                    DataTable dt = CheckMail(user, email);
                    if (dt.Rows.Count == 1)
                    {
                        string displayname = "";

                        string query = "select password from Users where UserName = N'" + user+"'";
                        xacnhan = DataProvider.Instance.ExcuteScalar(query).ToString();
                        string query2 = "select DisplayName from Users where username = N'" + user + "'";
                        displayname = DataProvider.Instance.ExcuteScalar(query2).ToString();
                        Random random = new Random();
                        int rd = random.Next(0, 26);
                        xacnhan = xacnhan.Substring(rd, 5);
                        if (SendMail(displayname,email,xacnhan))
                        {
                            MessageBox.Show("Gửi mail thành công! Vui lòng kiểm tra mail", "Thông báo", MessageBoxButtons.OK);
                        }
                        else
                        {
                            lb_notificationmail.Visible = true;
                            lb_notificationmail.Text = "Gửi mail không thành công!";
                        }
                        panel_mail.Visible = false;
                        panel_changepass.Visible = true;
                    }
                    else
                    {
                        lb_notificationmail.Visible = true;
                        lb_notificationmail.Text = "Thông tin không đúng";
                    }
                }
                else
                {
                    lb_notificationmail.Visible = true;
                    lb_notificationmail.Text = "Mail không đúng định dạng!";
                }
            }
            else
            {
                lb_notificationmail.Visible = true;
                lb_notificationmail.Text = "Không được để trống!";
            }
            
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            form_Login_Load(sender, e);
        }
        #endregion
        #region ChangePass
        private void btn_change_Click(object sender, EventArgs e)
        {
            if (txt_xacnhan.Text.Trim().ToString() == xacnhan)
            {
                if (txt_changepass1.Text == txt_changepass2.Text)
                {
                    string username = txt_usermail.Text.TrimEnd().ToLower();
                    string password = txt_changepass1.Text.Trim().ToLower();
                    string query = "exec user_updateaccout @username , @password ";
                    if (DataProvider.Instance.ExcuteNunQuery(query,
                        new object[] { username, Encrypt(password) }) > 0)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                        form_Login_Load(sender, e);
                    }
                    else
                    {
                        lb_notificationPass.Text = "Lỗi không xác định";
                    }
                }
                else
                {
                    lb_notificationPass.Text = "Mật khẩu nhập lại không trùng!";
                }
            }
            else
            {
                lb_notificationPass.Text = "Mã xác nhận không đúng!";
            }
        }

        private void txt_xacnhan_OnValueChanged(object sender, EventArgs e)
        {
            lb_notificationPass.Text = "";
        }

        private void txt_changepass1_OnValueChanged(object sender, EventArgs e)
        {
            lb_notificationPass.Text = "";
            txt_changepass1.isPassword = true;
        }

        private void txt_changepass2_OnValueChanged(object sender, EventArgs e)
        {
            lb_notificationPass.Text = "";
            txt_changepass2.isPassword = true;
        }

        private void btn_passback_Click(object sender, EventArgs e)
        {
            form_Login_Load(sender, e);
        }
        #endregion
    }
}
