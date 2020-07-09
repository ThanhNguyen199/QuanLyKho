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
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            customDesing();
        }

        private void customDesing()
        {
            panel_btn1.Visible = false;
            panel_btn2.Visible = false;
            panel_btn3.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panel_btn1.Visible == true)
                panel_btn1.Visible = false;
            if (panel_btn2.Visible == true)
                panel_btn2.Visible = false;
            if (panel_btn3.Visible == true)
                panel_btn3.Visible = false;
        }

        private void showSubMenu(Panel panelshow)
        {
            if (panelshow.Visible == false)
            {
                hideSubMenu();
                panelshow.Visible = true;
            }
            else
                panelshow.Visible = false;
        }

        private Form activeForm = null;
        private void openNewForm(Form newForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_btn1);
        }
        #region QuanLyKho
        private void button2_Click(object sender, EventArgs e)
        {
            openNewForm(new Form_InputProduct());
            hideSubMenu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_btn2);
        }
        #region BaoCao-ThongKe
        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        #endregion

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_btn3);
        }
        #region DanhMuc
        private void button15_Click(object sender, EventArgs e)
        {
            openNewForm(new Form_SupplierInfor());
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            openNewForm(new Form_CustomerInfor());
            hideSubMenu();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            openNewForm(new Form_ProductInfor());
            hideSubMenu();
        }
        #endregion
        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            openNewForm(new Form_UserManager());
            hideSubMenu();
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            openNewForm(new Form_Enterprise());
            hideSubMenu();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Form_Login f = new Form_Login();
                f.Close();
                Application.Exit();
            }
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form_Login lout = new Form_Login();
                this.Hide();
                lout.Show();
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            openNewForm(new Form_UserInfor());
            hideSubMenu();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            string query = "select IdRole from Users where UserName = N'" + Form_Login.userlogin + "'";
            if (DataProvider.Instance.ExcuteScalar(query).ToString() == "KETOAN" || DataProvider.Instance.ExcuteScalar(query).ToString() == "VANCHUYEN")
            {
                bunifuFlatButton4.Visible = false;
            }
        }
    }
}
