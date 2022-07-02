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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
            GUI();
            ShowBill(UC_Order._idTable);
        }
        public bool checkDigit(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsDigit(s[i]) == false)
                    return false;
            }
            return true;
        }

        void ShowBill(int id)
        {
            lvBill.Items.Clear();
            List<TempBillDTO> list = TempBillBUS.Instance.GetListTempBillByTableID(id);
            float totalPrice = 0;
            foreach (TempBillDTO item in list)
            {
                ListViewItem listView = new ListViewItem(item.ItemName.ToString());
                listView.SubItems.Add(item.AmountItem.ToString());
                listView.SubItems.Add(item.Price.ToString());
                listView.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lvBill.Items.Add(listView);
            }
            int discount = UC_Order._discount;
            txtTotalPrice.Text = totalPrice.ToString("c", new CultureInfo("vi-VN"));
            int total = Int32.Parse(txtTotalPrice.Text, NumberStyles.Currency, new CultureInfo("vi-VN"));
            int payment = total - ((total * discount) / 100);
            txtPayment.Text = payment.ToString();
            int paid = Int32.Parse(txtPaid.Text, NumberStyles.Currency, new CultureInfo("vi-VN"));

        }
        void GUI()
        {
            TableDTO table = new TableDTO();
            AccountDTO acc = AccountBUS.Instance.GetAccountByUserName(Login._username);
            int idTable = UC_Order._idTable;
            table.Name = TableBUS.Instance.GetNameTablebyID(idTable);
            int idBill = BillBUS.Instance.GetUnCheckIDBillByIDTable(idTable);
            txtIDBill.Text = idBill.ToString();
            txtTable.Text = table.Name;
            txtCashier.Text = acc.DisplayName.ToString();
            DateTime date = DateTime.Now;
            txtDateCheckOut.Text = date.ToShortDateString();
            BillDTO bill = BillBUS.Instance.getBillByID(idBill);
            DateTime date2 = DateTime.Parse(bill.DateCheckIn.ToString());
            txtTimeIn.Text = date2.ToLongTimeString();
            txtTimeOut.Text = date.ToLongTimeString();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            TableDTO table = new TableDTO();
            AccountDTO acc = AccountBUS.Instance.GetAccountByUserName(Login._username);
            int idTable = UC_Order._idTable;
            int idBill = BillBUS.Instance.GetUnCheckIDBillByIDTable(idTable);
            table.Name = TableBUS.Instance.GetNameTablebyID(idTable);
            int discount = UC_Order._discount;
            int total = Int32.Parse(txtTotalPrice.Text, NumberStyles.Currency, new CultureInfo("vi-VN"));
            int payment = total - ((total * discount) / 100);
            if (idTable != -1)
            {

                if (MessageBox.Show(String.Format("Bạn có chắc muốn thanh toán hóa đơn cho {0} \nTổng tiền = {1}", table.Name, payment.ToString("c", new CultureInfo("vi-VN"))), "Thông Báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    BillBUS.Instance.CheckOut(idBill, discount, payment);
                    ShowBill(idTable);
                    this.Close();
                }
                else this.Close();
            }

        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            if (checkDigit(txtPaid.Text) == true)
            {
                int discount = UC_Order._discount;
                int total = Int32.Parse(txtTotalPrice.Text, NumberStyles.Currency, new CultureInfo("vi-VN"));
                int payment = total - ((total * discount) / 100);
                int paid = 0;
                if (txtPaid.Text != "")
                {
                    paid = Int32.Parse(txtPaid.Text, NumberStyles.Currency, new CultureInfo("vi-VN"));
                }
                else txtPaid.Text = "0";
                int excesscash = paid - payment;
                if (excesscash < 0)
                {
                    txtExcessCash.Text = "Vui lòng trả đủ số tiền";
                }
                else txtExcessCash.Text = (paid - payment).ToString();
            }
            else txtPaid.Text = "Vui lòng nhập số!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            ShowBill(UC_Order._idTable);
        }

        Bitmap bitmap;
        private void btnPrintBill_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            formSize.Width += 112;
            formSize.Height -= 103;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X + 135, panelLocation.Y + 73, 0, 0, formSize);
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
    }
}
