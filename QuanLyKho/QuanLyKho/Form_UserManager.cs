﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKho
{
    public partial class Form_UserManager : Form
    {
        public Form_UserManager()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int chon;
        private void form_UserManager_Load(object sender, EventArgs e)
        {
            txt_username.Text = "";
            cbb_quyen.Text = null;
            txt_name.Text = "";
            txt_cmnd.Text = "";
            txt_male.Text = "";
            dateTimePicker1.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_address.Text = "";
            pictureBox1.Image = null;
            chonanh = 0;

            txt_username.Enabled = false;
            cbb_quyen.Enabled = false;
            txt_name.Enabled = false;
            txt_cmnd.Enabled = false;
            txt_male.Enabled = false;
            dateTimePicker1.Enabled = false;
            txt_phone.Enabled = false;
            txt_email.Enabled = false;
            txt_address.Enabled = false;

            btn_add.Visible = true;
            btn_change.Visible = false;
            btn_save.Visible = false;
            btn_cancel.Visible = false;
            btn_choose.Visible = false;
            btn_add.Enabled = true;
            btn_change.Enabled = true;
            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
            btn_choose.Enabled = false;

            cbb_quyen.DataSource = DataProvider.Instance.ExcuteQuery("select * from UserRole");
            cbb_quyen.DisplayMember = "Description";
            cbb_quyen.ValueMember = "Id";

            dgv_data.AutoGenerateColumns = false;
            dgv_data.Enabled = true;
            dgv_data.DataSource = DataProvider.Instance.ExcuteQuery("exec user_listinfo",new object[] {});
        }

        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_data.CurrentRow.Index;
            txt_username.Text = dgv_data.Rows[i].Cells[0].Value.ToString();
            cbb_quyen.Text = dgv_data.Rows[i].Cells[1].Value.ToString();
            txt_name.Text = dgv_data.Rows[i].Cells[2].Value.ToString();
            txt_cmnd.Text = dgv_data.Rows[i].Cells[3].Value.ToString();
            txt_male.Text = dgv_data.Rows[i].Cells[4].Value.ToString();
            dateTimePicker1.Text = dgv_data.Rows[i].Cells[5].Value.ToString();
            txt_phone.Text = dgv_data.Rows[i].Cells[6].Value.ToString();
            txt_email.Text = dgv_data.Rows[i].Cells[7].Value.ToString();
            txt_address.Text = dgv_data.Rows[i].Cells[8].Value.ToString();

            string query = "select * from Users where UserName = N'" + txt_username.Text + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                string check = item["image"].ToString();
                if (check != "")
                {
                    Byte[] image = (Byte[])item["image"]; ;
                    MemoryStream ms = new MemoryStream(image);
                    pictureBox1.Image = Image.FromStream(ms);
                    ms.Close();
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
            if (txt_username.Text == "admin")
            {
                btn_add.Visible = false;
                btn_change.Visible = false;
                btn_save.Visible = false;
                btn_cancel.Visible = false;
                btn_choose.Visible = false;
            }
            else
            {
                btn_add.Visible = true;
                btn_change.Visible = true;
                btn_save.Visible = true;
                btn_cancel.Visible = true;
                btn_choose.Visible = true;
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            form_UserManager_Load(sender, e);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if ( txt_username.Text != "" && txt_name.Text != "" && txt_cmnd.Text != "" && txt_male.Text != "" && txt_email.Text != "")
            {
                if (chon == 1)
                {
                    string query = "select IdRole from Users where UserName = N'" + Form_Login.userlogin + "'";
                    if (DataProvider.Instance.ExcuteScalar(query).ToString() == "ADMIN")
                    {
                        string user = txt_username.Text.Trim().ToLower();
                        string name = txt_name.Text;
                        string cmnd = txt_cmnd.Text;
                        string male = txt_male.Text;
                        string role = cbb_quyen.SelectedValue.ToString();
                        DateTime dayofbirth = dateTimePicker1.Value;
                        string phone = txt_phone.Text;
                        string email = txt_email.Text;
                        string address = txt_address.Text;
                        string pass = "c4ca4238a0b923820dcc509a6f75849b";
                        byte[] imageData = null;

                        query = "exec user_insert @username , @password , @IdRole , @DisplayName , " +
                                "@CMND , @Male , @DateOfBirth , @Phone , @Email , @Address , @Image ";
                        if (chonanh == 1)
                        {
                            using (FileStream fs = new FileStream(open.FileName, FileMode.Open, FileAccess.Read))
                            {
                                imageData = new Byte[fs.Length];
                                fs.Read(imageData, 0, Convert.ToInt32(fs.Length));
                                if (DataProvider.Instance.ExcuteNunQuery(query,
                                new object[] { user, pass, role, name, cmnd, male, dayofbirth, phone, email, address, imageData }) > 0)
                                {
                                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK);
                                    form_UserManager_Load(sender, e);
                                }
                                else
                                {
                                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Hãy chọn ảnh cho nhanh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (cbb_quyen.Text == "Admin")
                        {
                            MessageBox.Show("Không được phép cấp quyền admin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else 
                        {
                            string user = txt_username.Text.Trim().ToLower();
                            string name = txt_name.Text;
                            string cmnd = txt_cmnd.Text;
                            string male = txt_male.Text;
                            string role = cbb_quyen.SelectedValue.ToString();
                            DateTime dayofbirth = dateTimePicker1.Value;
                            string phone = txt_phone.Text;
                            string email = txt_email.Text;
                            string address = txt_address.Text;
                            string pass = "c4ca4238a0b923820dcc509a6f75849b";
                            byte[] imageData = null;

                            query = "exec user_insert @username , @password , @IdRole , @DisplayName , " +
                                "@CMND , @Male , @DateOfBirth , @Phone , @Email , @Address , @Image ";
                            if (chonanh == 1)
                            {
                                using (FileStream fs = new FileStream(open.FileName, FileMode.Open, FileAccess.Read))
                                {
                                    imageData = new Byte[fs.Length];
                                    fs.Read(imageData, 0, Convert.ToInt32(fs.Length));
                                    if (DataProvider.Instance.ExcuteNunQuery(query,
                                    new object[] { user, pass, role, name, cmnd, male, dayofbirth, phone, email, address, imageData }) > 0)
                                    {
                                        MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK);
                                        form_UserManager_Load(sender, e);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Hãy chọn ảnh cho nhanh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                else if (chon == 2)
                {
                    string query = "select IdRole from Users where UserName = N'" + Form_Login.userlogin + "'";
                    if (DataProvider.Instance.ExcuteScalar(query).ToString() == "ADMIN")
                    {
                        string user = txt_username.Text.Trim().ToLower();
                        string name = txt_name.Text;
                        string cmnd = txt_cmnd.Text;
                        string male = txt_male.Text;
                        string role = cbb_quyen.SelectedValue.ToString();
                        DateTime dayofbirth = dateTimePicker1.Value;
                        string phone = txt_phone.Text;
                        string email = txt_email.Text;
                        string address = txt_address.Text;
                        byte[] imageData = null;

                        if (chonanh == 1)
                        {
                            using (FileStream fs = new FileStream(open.FileName, FileMode.Open, FileAccess.Read))
                            {
                                imageData = new Byte[fs.Length];
                                fs.Read(imageData, 0, Convert.ToInt32(fs.Length));
                            }
                            query = "exec user_update @username  , @IdRole , @DisplayName , " +
                            "@CMND , @Male , @DateOfBirth , @Phone , @Email , @Address , @Image ";
                            if (DataProvider.Instance.ExcuteNunQuery(query,
                            new object[] { user, role, name, cmnd, male, dayofbirth, phone, email, address, imageData }) > 0)
                            {
                                MessageBox.Show("Thay đổi thành công!", "Thông báo", MessageBoxButtons.OK);
                                form_UserManager_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Thay đổi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            query = "exec user_updatenoimage @username  , @IdRole , @DisplayName , " +
                            "@CMND , @Male , @DateOfBirth , @Phone , @Email , @Address ";
                            if (DataProvider.Instance.ExcuteNunQuery(query,
                            new object[] { user, role, name, cmnd, male, dayofbirth, phone, email, address }) > 0)
                            {
                                MessageBox.Show("Thay đổi thành công!", "Thông báo", MessageBoxButtons.OK);
                                form_UserManager_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Thay đổi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        if (cbb_quyen.Text == "Admin")
                        {
                            MessageBox.Show("Không được phép cấp quyền admin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string user = txt_username.Text.Trim().ToLower();
                            string name = txt_name.Text;
                            string cmnd = txt_cmnd.Text;
                            string male = txt_male.Text;
                            string role = cbb_quyen.SelectedValue.ToString();
                            DateTime dayofbirth = dateTimePicker1.Value;
                            string phone = txt_phone.Text;
                            string email = txt_email.Text;
                            string address = txt_address.Text;
                            byte[] imageData = null;

                            if (chonanh == 1)
                            {
                                using (FileStream fs = new FileStream(open.FileName, FileMode.Open, FileAccess.Read))
                                {
                                    imageData = new Byte[fs.Length];
                                    fs.Read(imageData, 0, Convert.ToInt32(fs.Length));
                                }
                                query = "exec user_update @username  , @IdRole , @DisplayName , " +
                                "@CMND , @Male , @DateOfBirth , @Phone , @Email , @Address , @Image ";
                                if (DataProvider.Instance.ExcuteNunQuery(query,
                                new object[] { user, role, name, cmnd, male, dayofbirth, phone, email, address, imageData }) > 0)
                                {
                                    MessageBox.Show("Thay đổi thành công!", "Thông báo", MessageBoxButtons.OK);
                                    form_UserManager_Load(sender, e);
                                }
                                else
                                {
                                    MessageBox.Show("Thay đổi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                query = "exec user_updatenoimage @username  , @IdRole , @DisplayName , " +
                                "@CMND , @Male , @DateOfBirth , @Phone , @Email , @Address ";
                                if (DataProvider.Instance.ExcuteNunQuery(query,
                                new object[] { user, role, name, cmnd, male, dayofbirth, phone, email, address }) > 0)
                                {
                                    MessageBox.Show("Thay đổi thành công!", "Thông báo", MessageBoxButtons.OK);
                                    form_UserManager_Load(sender, e);
                                }
                                else
                                {
                                    MessageBox.Show("Thay đổi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Không được để trống thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            txt_username.Text = "nv_";
            cbb_quyen.Text = null;
            txt_name.Text = "";
            txt_cmnd.Text = "";
            txt_male.Text = "";
            dateTimePicker1.Text = "";
            txt_phone.Text = "";
            txt_email.Text = "";
            txt_address.Text = "";
            pictureBox1.Image = null;

            txt_username.Enabled = true;
            cbb_quyen.Enabled = true;
            txt_name.Enabled = true;
            txt_cmnd.Enabled = true;
            txt_male.Enabled = true;
            dateTimePicker1.Enabled = true;
            txt_phone.Enabled = true;
            txt_email.Enabled = true;
            txt_address.Enabled = true;

            btn_add.Enabled = false;
            btn_change.Enabled = false;
            btn_save.Enabled = true;
            btn_cancel.Enabled = true;
            btn_choose.Enabled = true;

            btn_save.Visible = true;
            btn_cancel.Visible = true;
            btn_choose.Visible = true;
            dgv_data.Enabled = false;
            chon = 1;
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            if(txt_username.Text != "")
            {
                cbb_quyen.Enabled = true;
                txt_name.Enabled = true;
                txt_cmnd.Enabled = true;
                txt_male.Enabled = true;
                dateTimePicker1.Enabled = true;
                txt_phone.Enabled = true;
                txt_email.Enabled = true;
                txt_address.Enabled = true;

                btn_add.Enabled = false;
                btn_change.Enabled = false;
                btn_save.Enabled = true;
                btn_cancel.Enabled = true;
                btn_choose.Enabled = true;
                btn_add.Visible = false;
                dgv_data.Enabled = false;
                chon = 2;
            }
            else
            {
                MessageBox.Show("Hãy chọn 1 đối tượng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        int chonanh;
        OpenFileDialog open = new OpenFileDialog();
        private void btn_choose_Click(object sender, EventArgs e)
        {
            open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
            else
            {
                pictureBox1.Image = null;
            }
            if(pictureBox1.Image != null) { chonanh = 1; }
        }
    }
}