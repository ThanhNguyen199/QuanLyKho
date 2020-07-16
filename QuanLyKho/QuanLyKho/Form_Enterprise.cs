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
    public partial class Form_Enterprise : Form
    {
        public Form_Enterprise()
        {
            InitializeComponent();
        }

        private DataTable Infor(string taxcode)
        {
            string query = "exec enterprise_infor @taxcode";
            return DataProvider.Instance.ExcuteQuery(query,
                new object[] { taxcode });
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            panel_change.Visible = true;
            btn_change.Enabled = false;
            txt_2.Enabled = true;
            txt_3.Enabled = true;
            txt_4.Enabled = true;
            txt_5.Enabled = true;
            txt_6.Enabled = true;
            txt_7.Enabled = true;
            txt_8.Enabled = true;
            txt_9.Enabled = true;
        }

        public void Form_Enterprise_Load(object sender, EventArgs e)
        {
            string query = "select IdRole from Users where UserName = N'" + Form_Login.userlogin +"'";
            if (DataProvider.Instance.ExcuteScalar(query).ToString() == "ADMIN")
            {
                btn_change.Visible = true;
                btn_change.Enabled = true;
            }
            else
            {
                btn_change.Visible = false;
            }
            
            panel_change.Visible = false;
            txt_1.Enabled = false;
            txt_2.Enabled = false;
            txt_3.Enabled = false;
            txt_4.Enabled = false;
            txt_5.Enabled = false;
            txt_6.Enabled = false;
            txt_7.Enabled = false;
            txt_8.Enabled = false;
            txt_9.Enabled = false;
            txt_1.Text = "0123456789";
            DataTable dt = Infor(txt_1.Text);
            foreach(DataRow row in dt.Rows)
            {
                txt_2.Text = row["EnterpriseName"].ToString();
                txt_3.Text = row["Address"].ToString();
                txt_4.Text = row["Phone"].ToString();
                txt_5.Text = row["Email"].ToString();
                txt_6.Text = row["MoreInfo"].ToString();
                txt_7.Text = row["BankAccoutNumber"].ToString();
                txt_8.Text = row["BankName"].ToString();
                txt_9.Text = row["WebSite"].ToString();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Form_Enterprise_Load(sender, e);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string query = "exec enterprise_update @username , @EnterpriseName , @Address , @Phone " +
                ", @Email , @MoreInfo , @BankAccoutNumber , @BankName , @WebSite ";
            if (DataProvider.Instance.ExcuteNunQuery(query,
                        new object[] { txt_1.Text, txt_2.Text, txt_3.Text, txt_4.Text, txt_5.Text,
                        txt_6.Text, txt_7.Text, txt_8.Text, txt_9.Text}) > 0)
            {
                MessageBox.Show("Thay đổi thông tin thành công!", "Thông báo", MessageBoxButtons.OK);
                Form_Enterprise_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Thay đổi thất bại!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
