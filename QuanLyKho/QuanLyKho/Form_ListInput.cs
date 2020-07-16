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
        #endregion
        private void Form_ListInput_Load(object sender, EventArgs e)
        {
            panel_show.Visible = false;

            btn_delete.Visible = false;
            btn_show.Visible = false;
            btn_cancel.Visible = false;

            dgv_data.AutoGenerateColumns = false;
            dgv_data.Enabled = true;
            dgv_data.DataSource = DataProvider.Instance.ExcuteQuery("exec input_listinfor", new object[] { });

            txt_idinput.Text = "";
            txt_codetax.Text = "";
            txt_supplier.Text = "";
            txt_user.Text = "";
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
            else
            {
                this.Close();
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
            btn_delete.Visible = true;
            btn_show.Visible = true;

            string query = "select IdRole from Users where UserName = N'" + Form_Login.userlogin + "'";
            if (DataProvider.Instance.ExcuteScalar(query).ToString() == "VANCHUYEN")
            {
                btn_delete.Visible = false;
            }

            int i = dgv_data.CurrentRow.Index;
            IdInput = dgv_data.Rows[i].Cells[1].Value.ToString();       
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            panel_show.Visible = true;
            openNewForm(new Form_InputProduct());
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

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
    }
}
