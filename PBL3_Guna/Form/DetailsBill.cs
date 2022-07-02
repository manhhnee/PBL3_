using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_Guna
{
    public partial class DetailsBill : Form
    {
        public DetailsBill()
        {
            InitializeComponent();
            GUI();
            showBill();
        }
        public void GUI()
        {
            bool a = true;
            int id = UC_Revenue._id;
            if (UC_Revenue._id == 0)
            {
                a = false;
                id = UC_Information._id;
            }
            int idTable = BillBUS.Instance.GetIDTableByID(id);
            TableDTO table = new TableDTO();
            table.Name = TableBUS.Instance.GetNameTablebyID(idTable);
            txtTable.Text = table.Name;
            txt_id.Text = id.ToString();
            BillDTO bill = BillBUS.Instance.getBillByID(id);
            DateTime date = DateTime.Parse(bill.DateCheckOut.ToString());
            txtDate.Text = date.ToString();
        }
        void showBill()
        {
            bool a = true;
            int id = UC_Revenue._id;
            if (UC_Revenue._id == 0)
            {
                a = false;
                id = UC_Information._id;
            }
            lvDetailBill.Items.Clear();
            List<TempBillDTO> list = TempBillBUS.Instance.GetListTempBillByID(id);

            foreach (TempBillDTO item in list)
            {
                ListViewItem listView = new ListViewItem(item.ItemName.ToString());
                listView.SubItems.Add(item.AmountItem.ToString());
                listView.SubItems.Add(item.Price.ToString());
                listView.SubItems.Add(item.TotalPrice.ToString());

                lvDetailBill.Items.Add(listView);
            }
            if (a)
            {
                txtToTal.Text = UC_Revenue._total.ToString("c", new CultureInfo("vi-VN"));
            }
            else txtToTal.Text = UC_Information._total.ToString("c", new CultureInfo("vi-VN"));
        }


    }
}
