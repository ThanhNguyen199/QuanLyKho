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
    public partial class Form_DeliveryBillProduct : Form
    {
        public Form_DeliveryBillProduct()
        {
            InitializeComponent();
        }
        #region function
        private DataTable Product_Infor(string IdProduct)
        {
            string query = "exec product_infor @IdProduct ";
            return DataProvider.Instance.ExcuteQuery(query,
                new object[] { IdProduct });
        }

        public bool DeliveryBill_Insert(string IdDelivery, DateTime date, string IdCustomer, string username)
        {
            string query = "exec deliverybill_insert @IdDelivery , @DateOutput , @IdCustomer , @IdUser ";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { IdDelivery, date, IdCustomer, username }) > 0;
        }

        public bool DeliveryBillInfor_Insert(string IdDelivery, string IdProduct, int QuantityOut, float Price)
        {
            string query = "exec deliverybillinfo_insert @IdDelivery , @IdProduct , @QuantityOut , @Price ";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { IdDelivery, IdProduct, QuantityOut, Price }) > 0;
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

        public bool Delete_DeliveryBill(string id)
        {
            string query = "delete form DeliveryBill where IdDelivery = N'" + id + "'";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { id }) > 0;
        }

        public bool Delete_DeliveryBillInfor(string id)
        {
            string query = "delete form DeliveryBillInfo where IdDelivery = N'" + id + "'";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { id }) > 0;
        }
        public bool Update_PriceTotal(string Id)
        {
            string query = "exec deliverybill_insertpricetotal @IdOutput ";
            return DataProvider.Instance.ExcuteNunQuery(query, new object[] { Id }) > 0;
        }
        #endregion
        #region load
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int row;
        decimal sum_price;
        private void Form_DeliveryBillProduct_Load(object sender, EventArgs e)
        {
            while (dgv_data.Rows.Count > 1)
            {
                dgv_data.Rows.Clear();
            }
            grb_customer.Enabled = false;
            panel_add.Visible = false;

            btn_add.Enabled = true;
            btn_save.Visible = false;
            btn_cancel.Visible = false;
            dgv_data.Enabled = false;

            name.DataSource = DataProvider.Instance.ExcuteQuery("select * from Product");
            name.ValueMember = "Id";
            name.DisplayMember = "DisplayName";

            cbb_cusId.DataSource = DataProvider.Instance.ExcuteQuery("select * from Customer");
            cbb_cusId.DisplayMember = "Id";
            cbb_cusId.ValueMember = "Id";
            cbb_cusId.Text = "";

            cbb_user.DataSource = DataProvider.Instance.ExcuteQuery("select * from Users");
            cbb_user.DisplayMember = "DisplayName";
            cbb_user.ValueMember = "UserName";
            cbb_user.Text = "";

            lb_cusname.Text = "";
            lb_cusleganame.Text = "";
            lb_custaxcode.Text = "";
            lb_cusphone.Text = "";
            lb_cusmail.Text = "";
            lb_cusnote.Text = "";
            lb_cusaddress.Text = "";

            lb_IdDelivery.Text = DataProvider.Instance.ExcuteScalar("exec AutoOutput").ToString();
            sum_price = 0;
            row = 0;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            lb_cusname.Text = "";
            lb_cusleganame.Text = "";
            lb_custaxcode.Text = "";
            lb_cusphone.Text = "";
            lb_cusmail.Text = "";
            lb_cusnote.Text = "";
            lb_cusaddress.Text = "";

            panel_add.Visible = true;
            grb_customer.Enabled = true;

            btn_save.Visible = true;
            btn_cancel.Visible = true;
            btn_add.Enabled = false;
            dgv_data.Enabled = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Form_DeliveryBillProduct_Load(sender, e);
        }
        #endregion
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (dgv_data.Rows.Count > 1 && cbb_cusId.Text != "" && cbb_user.Text != "")
            {
                string id = lb_IdDelivery.Text;
                DateTime date = dateTimePicker1.Value;
                string idsupplier = cbb_cusId.SelectedValue.ToString();
                string useroutput = cbb_user.SelectedValue.ToString();
                
                int tam = 0;
                for (int j = 0; j < dgv_data.Rows.Count - 1; j++)
                {
                    int quantity = Convert.ToInt32(dgv_data.Rows[j].Cells[4].Value);
                    float price = (float)Convert.ToDouble(dgv_data.Rows[j].Cells[6].Value);

                    if (quantity <= Convert.ToInt32(dgv_data.Rows[j].Cells[5].Value))
                    {
                        tam += 1;
                    }
                }
                if (tam == dgv_data.Rows.Count - 1)
                {
                    try
                    {
                        if (DeliveryBill_Insert(id, date, useroutput, idsupplier))
                        {
                            int temp = 0;
                            for (int j = 0; j < dgv_data.Rows.Count - 1; j++)
                            {
                                string idproduct = dgv_data.Rows[j].Cells[1].Value.ToString();
                                int quantity = Convert.ToInt32(dgv_data.Rows[j].Cells[4].Value);
                                float price = (float)Convert.ToDouble(dgv_data.Rows[j].Cells[6].Value);

                                if (DeliveryBillInfor_Insert(id, idproduct, quantity, price))
                                {
                                    temp += 1;
                                    Product_DeleteInventory(idproduct, quantity);
                                }
                            }
                            if (temp == dgv_data.Rows.Count - 1)
                            {
                                string mail = lb_cusmail.Text.Trim().ToLower().ToString();
                                MessageBox.Show("Lập phiếu xuất " + id + " thành công!", "", MessageBoxButtons.OK);
                                Update_PriceTotal(id);
                                Form_DeliveryBillProduct_Load(sender, e);
                            }
                            else
                            {
                                for (int j = 0; j < dgv_data.Rows.Count - 1; j++)
                                {
                                    string idproduct = dgv_data.Rows[j].Cells[1].Value.ToString();
                                    int quantity = Convert.ToInt32(dgv_data.Rows[j].Cells[4].Value);
                                    float price = (float)Convert.ToDouble(dgv_data.Rows[j].Cells[6].Value);

                                    Product_Inventory(idproduct, quantity);
                                }
                                MessageBox.Show("Lập phiếu xuất " + id + " thất bại! Vui lòng thử lại sau!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Delete_DeliveryBill(id);
                                Delete_DeliveryBillInfor(id);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại!", "Cảnh báo", MessageBoxButtons.OK);
                        }
                    }
                    catch { }
                }
                else
                {
                    MessageBox.Show("Số hàng xuất không được lớn hơn hàng trong kho!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("không được để trống thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #region data cbb_dgv
        private void cbb_cusId_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = "select * from Customer where Id = N'" + cbb_cusId.Text + "'";
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                lb_cusname.Text = row["BuyerName"].ToString();
                lb_cusleganame.Text = row["BuyerLegaName"].ToString();
                lb_custaxcode.Text = row["Taxcode"].ToString();
                lb_cusphone.Text = row["Phone"].ToString();
                lb_cusmail.Text = row["Email"].ToString();
                lb_cusnote.Text = row["MoreInfo"].ToString();
                lb_cusaddress.Text = row["Address"].ToString();
            }
        }

        private void dgv_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
        }

        private void dgv_data_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgv_data.Rows.Count - 1; i++)
            {
                dgv_data.Rows[i].Cells[0].Value = i + 1;
            }
            try
            {
                DataTable dt = Product_Infor(dgv_data.Rows[row].Cells[1].Value.ToString());
                foreach (DataRow r in dt.Rows)
                {
                    dgv_data.Rows[row].Cells[2].Value = r["unit"].ToString();
                    dgv_data.Rows[row].Cells[3].Value = r["Price"].ToString();
                    dgv_data.Rows[row].Cells[5].Value = r["Inventory"].ToString();
                }
                dgv_data.Rows[row].Cells[6].Value = Convert.ToDouble(dgv_data.Rows[row].Cells[3].Value) * Convert.ToDouble(dgv_data.Rows[row].Cells[4].Value);
                sum_price += (decimal)Convert.ToDouble(dgv_data.Rows[row].Cells[6].Value);
            }
            catch { }
        }
    }
    #endregion
}
