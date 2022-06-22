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
using BUS;
using DTO;

namespace PBL3_Guna
{
    public partial class UC_Order : UserControl
    {
        public static int _idTable;
        public static int _discount;
        public static int _totalPrice;
        
        public UC_Order()
        {
            InitializeComponent();
            LoadTable();
            LoadCatergory();
            LoadComboboxTable();
        }
        void LoadComboboxTable()
        {
            cbSwapTable.Items.AddRange(TableBUS.Instance.GetListTable().ToArray());
            cbSwapTable.DisplayMember = "Name";
            cbSwapTable.SelectedIndex = 0;
        }
        void LoadCatergory()
        {
            cbCategory.Items.AddRange(CategoryBUS.Instance.GetListCategory().ToArray());
            cbCategory.DisplayMember = "Name";
            cbCategory.SelectedIndex = 0;
        }
        void LoadItemListByIDCategory(int id)
        {
            cbItem.Items.Clear();
            cbItem.Items.AddRange(ItemBUS.Instance.GetItemByIDCategory(id).ToArray());
            cbItem.DisplayMember = "Name";
        }
        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<TableDTO> tableList = TableBUS.Instance.GetListTable();
            foreach (TableDTO item in tableList)
            {
                Button btn = new Button() { Width = TableBUS.TableWidth, Height = TableBUS.TableHeight };
                btn.Text = item.Name + "\n" + item.Status;
                btn.Click += Btn_Click;
                btn.Tag = item;
                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.AliceBlue;
                        break;
                    default:
                        btn.BackColor = Color.Red;
                        break;

                }
                flpTable.Controls.Add(btn);
            }
            
        }
        void ShowBill(int id)
        {
            lvBill.Items.Clear();
            List<TempBillDTO> listBillInfor = TempBillBUS.Instance.GetListTempBillByTableID(id);
            float TotalPrice = 0;
            foreach (TempBillDTO item in listBillInfor)
            {
                ListViewItem listView = new ListViewItem(item.ItemName.ToString());
                listView.SubItems.Add(item.AmountItem.ToString());
                listView.SubItems.Add(item.Price.ToString());
                listView.SubItems.Add(item.TotalPrice.ToString());
                TotalPrice += item.TotalPrice;
                lvBill.Items.Add(listView);
            }
            
            txbTotalPrice.Text = TotalPrice.ToString("c", new CultureInfo("vi-VN"));
            
            
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            _idTable = ((TableDTO)(sender as Button).Tag).ID;
            lvBill.Tag = ((Button)sender).Tag;
            _discount = (int)nmDiscount.Value;
            ShowBill(_idTable);
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbItem.Text = string.Empty;
            LoadItemListByIDCategory(((CategoryDTO)cbCategory.SelectedItem).ID);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (cbItem.Text != string.Empty)
            {
                TableDTO tableDTO = lvBill.Tag as TableDTO;
                int idBill = BillBUS.Instance.GetUnCheckIDBillByIDTable(tableDTO.ID);
                int idItem = (cbItem.SelectedItem as ItemDTO).ID;
                int amount = (int)nmItemAmount.Value;
                if (idBill == -1)
                {
                    BillBUS.Instance.InsertBill(tableDTO.ID);
                    BillInforBUS.Instance.InsertBillInfor(BillBUS.Instance.GetMaxIDBill(), idItem, amount);
                }
                else
                {
                    BillInforBUS.Instance.InsertBillInfor(idBill, idItem, amount);
                }
                ShowBill(tableDTO.ID);
                LoadTable();
            }
            else MessageBox.Show("vui lòng chọn món");

        }

        private void btnSwapTable_Click(object sender, EventArgs e)
        {
            int id1 = (lvBill.Tag as TableDTO).ID;
            int id2 = (cbSwapTable.SelectedItem as TableDTO).ID;


            if (MessageBox.Show(String.Format("Bạn có thật sự muốn chuyển từ {0} sang {1} ?", (lvBill.Tag as TableDTO).Name, (cbSwapTable.SelectedItem as TableDTO).Name), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TableBUS.Instance.SwapTable(id1, id2);
                LoadTable();
            }
        }
        
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            TableDTO table = lvBill.Tag as TableDTO;
            int idBill = BillBUS.Instance.GetUnCheckIDBillByIDTable(table.ID);
            if (idBill != -1)
            {
                Bill bill = new Bill();
                bill.ShowDialog();
                ShowBill(idBill);
                LoadTable();
            }
            else MessageBox.Show("Không tồn tại hóa đơn !");
            
            
            
        }
    }
}
