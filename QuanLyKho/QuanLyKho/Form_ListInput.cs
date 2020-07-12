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
            grb_supplier.Enabled = false;
            panel_id.Enabled = false;
            panel_show.Visible = false;
            txt_IdInput.Enabled = false;

            btn_change.Visible = false;
            btn_save.Visible = false;
            btn_cancel.Visible = false;
            btn_show.Visible = false;

            dgv_data.Enabled = true;

            dgv_data.AutoGenerateColumns = false;
            dgv_data.Enabled = true;
            dgv_data.DataSource = DataProvider.Instance.ExcuteQuery("exec product_listinfor", new object[] { });

            cbb_taxcode.DataSource = DataProvider.Instance.ExcuteQuery("select * from Supplier");
            cbb_taxcode.DisplayMember = "TaxCode";
            cbb_taxcode.ValueMember = "TaxCode";
            cbb_taxcode.Text = "";

            lb_supplier.Text = "";
            lb_phone.Text = "";
            lb_mail.Text = "";
            lb_note.Text = "";
            lb_address.Text = "";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            grb_supplier.Enabled = true;
            panel_id.Enabled = true;
            dgv_data.Enabled = false;

            btn_change.Enabled = false;
            btn_save.Visible = true;
            btn_cancel.Visible = true;
            btn_show.Visible = false;
        }

        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_change.Visible = true;
            btn_show.Visible = true;
            int i = dgv_data.CurrentRow.Index;


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Form_ListInput_Load(sender, e);
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            panel_show.Visible = true;
            openNewForm(new Form_InputProduct());
            panel_show.Visible = false;
        }
    }
}
