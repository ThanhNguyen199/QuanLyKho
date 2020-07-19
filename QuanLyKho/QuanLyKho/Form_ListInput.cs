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
    public partial class Form_ListInput : Form
    {
        public Form_ListInput()
        {
            InitializeComponent();
        }
        public static string IdInput;
        public static string UserInput;
        public static string DateInput;
        public static string SupllierInput;
        #region function
        private Form activeForm = null;
        private void openNewForm(Form newForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.Dock = DockStyle.Fill;
            panel_show.Controls.Add(newForm);
            newForm.BringToFront();
            newForm.Show();
        }

        private DataTable Product_Inventory(string IdProduct, int Quantity)
        {
            string query = "exec input_insertinventory @IdProduct , @Quantity ";
            return DataProvider.Instance.ExcuteQuery(query,
                new object[] { IdProduct, Quantity });
        }

        private DataTable Product_DeleteInventory(string IdProduct, int Quantity)
        {
            string query = "exec input_deleteinventory @IdProduct , @Quantity ";
            return DataProvider.Instance.ExcuteQuery(query,
                new object[] { IdProduct, Quantity });
        }

        public void LockUpdate(string Idinput)
        {
            dgv_dataupdate.AutoGenerateColumns = false;
            dgv_dataupdate.DataSource = DataProvider.Instance.ExcuteQuery("exec product_listinputinfor @IdInput",
                new object[] { Idinput });
            for (int j = 0; j < dgv_dataupdate.Rows.Count - 1; j++)
            {
                string idproduct = dgv_dataupdate.Rows[j].Cells[1].Value.ToString();
                string quantity = dgv_dataupdate.Rows[j].Cells[4].Value.ToString();

                Product_DeleteInventory(idproduct, Convert.ToInt32(quantity));
            }
        }
        public void UnLockUpdate(string Idinput)
        {
            dgv_dataupdate.AutoGenerateColumns = false;
            dgv_dataupdate.DataSource = DataProvider.Instance.ExcuteQuery("exec product_listinputinfor @IdInput",
                new object[] { Idinput });

            for (int j = 0; j < dgv_dataupdate.Rows.Count - 1; j++)
            {
                string idproduct = dgv_dataupdate.Rows[j].Cells[1].Value.ToString();
                string quantity = dgv_dataupdate.Rows[j].Cells[4].Value.ToString();

                Product_Inventory(idproduct, Convert.ToInt32(quantity));
            }
        }
        #endregion
        private void Form_ListInput_Load(object sender, EventArgs e)
        {
            panel_show.Visible = false;
            panel_lock.Visible = false;
            panel_id.Enabled = true;

            btn_search.Visible = true;
            btn_list.Visible = true;
            btn_list.Enabled = true;

            btn_lock.Visible = false;
            btn_lock.Enabled = true;
            btn_unlock.Visible = false;
            btn_close.Visible = false;
            btn_show.Visible = false;
            btn_cancel.Visible = false;

            dgv_data.AutoGenerateColumns = false;
            dgv_data.Enabled = true;
            dgv_data.DataSource = DataProvider.Instance.ExcuteQuery("exec input_listinfor", new object[] { });

            dgv_show.AutoGenerateColumns = false;
            dgv_show.Visible = false;

            string query = "select IdRole from Users where UserName = N'" + Form_Login.userlogin + "'";
            if (DataProvider.Instance.ExcuteScalar(query).ToString() == "VANCHUYEN")
            {
                btn_list.Visible = false;
            }

            IdInput = "";
            UserInput = "";
            DateInput = "";
            SupllierInput = "";

            txt_idinput.Text = "";
            txt_codetax.Text = "";
            txt_supplier.Text = "";
            txt_user.Text = "";
            txt_lock.Text = "";
            DateTime d = DateTime.Now;
            dateTimePicker2.Value = new DateTime(d.Year, d.Month, 1);
            dateTimePicker1.Value = dateTimePicker2.Value.AddMonths(1).AddDays(-1);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            if (panel_show.Visible == true)
            {
                panel_show.Visible = false;
                Form_ListInput_Load(sender, e);
            }
        }

        private void dgv_data_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            for (int j = 0; j < dgv_data.Rows.Count - 1; j++)
            {
                dgv_data.Rows[j].Cells[0].Value = j + 1;
            }
        }

        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_show.Visible = true;
            btn_lock.Visible = true;

            string query = "select IdRole from Users where UserName = N'" + Form_Login.userlogin + "'";
            if (DataProvider.Instance.ExcuteScalar(query).ToString() == "VANCHUYEN")
            {
                btn_lock.Visible = false;
            }

            int i = dgv_data.CurrentRow.Index;
            IdInput = dgv_data.Rows[i].Cells[1].Value.ToString();
            UserInput = dgv_data.Rows[i].Cells[2].Value.ToString();
            DateInput = dgv_data.Rows[i].Cells[3].Value.ToString();
            SupllierInput = dgv_data.Rows[i].Cells[4].Value.ToString();       
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            panel_show.Visible = true;
            btn_close.Visible = true;
            openNewForm(new Form_ListInputInfor());
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Form_ListInput_Load(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_cancel.Visible = true;
            dgv_data.AutoGenerateColumns = false;
            dgv_data.Enabled = true;
            string query = "exec getInput @FromDate , @ToDate , @IdInput , @SupplierName , @Taxcode , @Usersname ";
            dgv_data.DataSource = DataProvider.Instance.ExcuteQuery(query, 
                new object[] { dateTimePicker2.Value, dateTimePicker1.Value, txt_idinput.Text, txt_supplier.Text, txt_codetax.Text,txt_user.Text });
        }

        private void btn_list_Click(object sender, EventArgs e)
        {
            string query = "select IdRole from Users where UserName = N'" + Form_Login.userlogin + "'";
            if (DataProvider.Instance.ExcuteScalar(query).ToString() == "VANCHUYEN")
            {
                btn_unlock.Visible = false;
            }
            else
            {
                btn_unlock.Visible = true;
            }

            btn_cancel.Visible = true;
            btn_search.Visible = false;
            panel_id.Enabled = false;

            btn_lock.Visible = false;
            btn_close.Visible = false;
            btn_show.Visible = false;
            btn_search.Visible = false;
            btn_list.Enabled = false;
            btn_unlock.Visible = false;

            dgv_show.Visible = true;
            dgv_show.DataSource = DataProvider.Instance.ExcuteQuery("exec input_listinforlock ", new object[] { });
        }

        private void btn_lock_Click(object sender, EventArgs e)
        {
            panel_lock.Visible = true;
            btn_cancel.Visible = true;

            panel_id.Enabled = false;

            btn_lock.Enabled = false;
            btn_unlock.Visible = false;
            btn_close.Visible = false;
            btn_show.Visible = false;
            btn_search.Visible = false;
            btn_list.Visible = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_lock.Text != "")
            {
                if (DataProvider.Instance.ExcuteQuery("exec input_lock @IdOutput , @Status",
                new object[] { IdInput, txt_lock.Text }).Rows.Count == 0)
                {
                    MessageBox.Show("Xoá thành công!", "Thông báo");
                    LockUpdate(IdInput);
                    Form_ListInput_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Ghi chú k được để trống!", "Thông báo");
            }
        }

        private void btn_unlock_Click(object sender, EventArgs e)
        {
            if (DataProvider.Instance.ExcuteQuery("exec input_unlock @IdOutput",
                new object[] { IdInput }).Rows.Count == 0)
            {
                MessageBox.Show("Khôi phục thành công!", "Thông báo");
                UnLockUpdate(IdInput);
                dgv_show.DataSource = DataProvider.Instance.ExcuteQuery("exec output_listinforlock ", new object[] { });
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!", "Cảnh báo");
            }
        }

        private void dgv_show_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgv_show.CurrentRow.Index;
            IdInput = dgv_show.Rows[i].Cells[1].Value.ToString();

            btn_unlock.Visible = true;
        }
    }
}
