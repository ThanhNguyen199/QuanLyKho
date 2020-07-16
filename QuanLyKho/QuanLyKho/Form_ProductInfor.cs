using System;
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
    public partial class Form_ProductInfor : Form
    {
        public Form_ProductInfor()
        {
            InitializeComponent();
        }
        int chon;
        int chonanh;

        private DataTable product(string taxcode)
        {
            string query = "exec product_inforofsupplier @Idsupplier ";
            return DataProvider.Instance.ExcuteQuery(query,
                new object[] { taxcode });
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form_ProductInfor_Load(object sender, EventArgs e)
        {
            lb_id.Text = "";
            txt_name.Text = "";
            txt_price.Text = "";
            txt_from.Text = "";
            pictureBox1.Image = null;

            txt_name.Enabled = false;
            cbb_loai.Enabled = false;
            cbb_unit.Enabled = false;
            txt_price.Enabled = false;
            txt_from.Enabled = false;
            chonanh = 0;

            btn_add.Enabled = true;
            btn_change.Enabled = false;
            btn_save.Enabled = false;
            btn_cancel.Enabled = false;
            btn_choose.Enabled = false;

            cbb_loai.DataSource = DataProvider.Instance.ExcuteQuery("select * from ProductCategory");
            cbb_loai.DisplayMember = "DisplayName";
            cbb_loai.ValueMember = "Id";
            cbb_loai.Text = "";

            cbb_unit.DataSource = DataProvider.Instance.ExcuteQuery("select * from Unit");
            cbb_unit.DisplayMember = "DisplayName";
            cbb_unit.ValueMember = "Id";
            cbb_unit.Text = "";

            dgv_data.AutoGenerateColumns = false;
            dgv_data.Enabled = true;
            dgv_data.DataSource = product(Form_InputProduct.IdSupplier);
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            lb_id.Text = DataProvider.Instance.ExcuteScalar("exec AutoProduct").ToString();
            cbb_loai.Text = "";
            txt_name.Text = "";
            cbb_unit.Text = "";
            txt_price.Text = "";
            txt_from.Text = "";
            pictureBox1.Image = null;

            txt_name.Enabled = true;
            cbb_loai.Enabled = true;
            cbb_unit.Enabled = true;
            txt_price.Enabled = true;
            txt_from.Enabled = true;

            btn_add.Enabled = false;
            btn_change.Enabled = false;
            btn_save.Enabled = true;
            btn_cancel.Enabled = true;
            btn_choose.Enabled = true;
            chon = 1;
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            txt_name.Enabled = true;
            cbb_loai.Enabled = true;
            cbb_unit.Enabled = true;
            txt_price.Enabled = true;
            txt_from.Enabled = true;

            btn_add.Enabled = false;
            btn_change.Enabled = false;
            btn_save.Enabled = true;
            btn_cancel.Enabled = true;
            btn_choose.Enabled = true;
            chon = 2;

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (lb_id.Text != "" && txt_price.Text != "" && txt_from.Text != "")
            {

                string id = lb_id.Text;
                string loai = cbb_loai.SelectedValue.ToString();
                string name = txt_name.Text;
                string unit = cbb_unit.SelectedValue.ToString();
                string price = txt_price.Text;
                string from = txt_from.Text;

                if (chon == 1)
                {
                    byte[] imageData = null;

                    using (FileStream fs = new FileStream(open.FileName, FileMode.Open, FileAccess.Read))
                    {
                        imageData = new Byte[fs.Length];
                        fs.Read(imageData, 0, Convert.ToInt32(fs.Length));
                    }
                    if (imageData == null)
                    {
                        MessageBox.Show("Hãy chọn ảnh!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        string query = "exec product_insert @Id , @IdCategory , @DisplayName , @Inventory " +
                        ", @IdUnit , @Price , @Froms , @Images , @IdSuppiler ";
                        if (DataProvider.Instance.ExcuteNunQuery(query,
                            new object[] { id, loai, name, 0, unit, price, from, imageData, Form_InputProduct.IdSupplier }) > 0)
                        {
                            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK);
                            Form_ProductInfor_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (chon == 2)
                {
                    if (chonanh == 1)
                    {
                        byte[] imageData = null;
                        using (FileStream fs = new FileStream(open.FileName, FileMode.Open, FileAccess.Read))
                        {
                            imageData = new Byte[fs.Length];
                            fs.Read(imageData, 0, Convert.ToInt32(fs.Length));
                        }
                        string query = "exec product_update @Id , @IdCategory , @DisplayName " +
                        ", @IdUnit , @Price , @Froms , @Images ";
                        if (DataProvider.Instance.ExcuteNunQuery(query,
                            new object[] { id, loai, name, unit, price, from, imageData }) > 0)
                        {
                            MessageBox.Show("Thay đổi thành công!", "Thông báo", MessageBoxButtons.OK);
                            Form_ProductInfor_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Thay đổi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        string query = "exec product_updatenoimage @Id , @IdCategory , @DisplayName " +
                        ", @IdUnit , @Price , @Froms ";
                        if (DataProvider.Instance.ExcuteNunQuery(query,
                            new object[] { id, loai, name, unit, price, from }) > 0)
                        {
                            MessageBox.Show("Thay đổi thành công!", "Thông báo", MessageBoxButtons.OK);
                            Form_ProductInfor_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Thay đổi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Form_ProductInfor_Load(sender, e);
        }

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
            if (pictureBox1.Image != null) { chonanh = 1; }
        }

        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_change.Enabled = true;
            int i = dgv_data.CurrentRow.Index;
            lb_id.Text = dgv_data.Rows[i].Cells[1].Value.ToString();
            cbb_loai.Text = dgv_data.Rows[i].Cells[2].Value.ToString();
            txt_name.Text = dgv_data.Rows[i].Cells[3].Value.ToString();
            cbb_unit.Text = dgv_data.Rows[i].Cells[4].Value.ToString();
            txt_price.Text = dgv_data.Rows[i].Cells[5].Value.ToString();
            txt_from.Text = dgv_data.Rows[i].Cells[6].Value.ToString();

            string query = "select * from Product where Id = N'" + lb_id.Text + "'";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                string check = item["images"].ToString();
                if (check != "")
                {
                    Byte[] image = (Byte[])item["images"]; ;
                    MemoryStream ms = new MemoryStream(image);
                    pictureBox1.Image = Image.FromStream(ms);
                    ms.Close();
                }
                else
                {
                    pictureBox1.Image = null;
                }
            }
        }

        private void dgv_data_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int i = 0; i < dgv_data.Rows.Count - 1; i++)
            {
                dgv_data.Rows[i].Cells[0].Value = i + 1;
            }
        }
    }
}
