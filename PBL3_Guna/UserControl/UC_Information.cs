using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_Guna
{
    public partial class UC_Information : UserControl
    {
        public static int _id;
        public static int _total;
        public UC_Information()
        {
            InitializeComponent();
            LoadListBillByDate(DateTime.Today, DateTime.Now);
        }

        void LoadListBillByDate(DateTime CheckIn, DateTime CheckOut)
        {
            dtgvInfor.DataSource = BillBUS.Instance.GetListBillByDate(CheckIn, CheckOut);
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (dtgvInfor.SelectedRows.Count > 0)
            {
                _id = Convert.ToInt32(dtgvInfor.CurrentRow.Cells[0].Value.ToString());
                _total = Convert.ToInt32(dtgvInfor.CurrentRow.Cells[2].Value.ToString());
                Form detailsbill = new DetailsBill();
                detailsbill.ShowDialog();
            }
            else MessageBox.Show("Vui lòng chọn hóa đơn để xem");
        }
    }
}
