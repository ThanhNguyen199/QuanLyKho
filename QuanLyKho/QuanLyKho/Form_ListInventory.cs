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
    public partial class Form_ListInventory : Form
    {
        public Form_ListInventory()
        {
            InitializeComponent();
        }

        private DataTable Update(string taxcode)
        {
            string query = "exec enterprise_insertpricetotal @taxcode";
            return DataProvider.Instance.ExcuteQuery(query,
                new object[] { taxcode });
        }

        private void Form_ListInventory_Load(object sender, EventArgs e)
        {

            string tam = "0123456789";
            Update(tam);
            string query = "select WareHousePrice from Enterprise where Taxcode = N'" + tam + "'";
            string giatri = DataProvider.Instance.ExcuteScalar(query).ToString();
            lb_price.Text = Convert.ToDouble(giatri).ToString("N0") + " VNĐ";
        }

        private void dgv_data_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
    }
}
