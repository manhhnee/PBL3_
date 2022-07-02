using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace PBL3_Guna
{
    public partial class UC_Item : UserControl
    {
        public UC_Item()
        {
            InitializeComponent();
            LoadCatergory();
            showDTG_Item("");
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

        void LoadCatergory()
        {
            cxbCategoryItem.Items.Clear();
            cxbCategoryItem.Items.AddRange(CategoryBUS.Instance.GetListCategory().ToArray());
            cxbCategoryItem.DisplayMember = "Name";

        }
        public void showDTG_Item(string name)
        {
            dtgvItem.DataSource = ItemBUS.Instance.GetItemByName(name);

        }


        public ItemDTO getItemDataToUpdate()
        {
            ItemDTO item = new ItemDTO();
            item.ID = Convert.ToInt32(txtIDItem.Text);
            item.Name = txtNameItem.Text;
            item.IDCategory = (CategoryBUS.Instance.GetIDbyNameCategory(cxbCategoryItem.Text));
            item.Price = Convert.ToInt32(txtPriceItem.Text);
            return item;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Form f = new AddItem();
            f.ShowDialog();
            showDTG_Item("");
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dtgvItem.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa  " + dtgvItem.CurrentRow.Cells[1].Value.ToString() + " ra khỏi danh sách ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
                {
                    int DeleteID = Convert.ToInt32(dtgvItem.CurrentRow.Cells[0].Value.ToString());
                    BillInforBUS.Instance.SetBillInforDefault(DeleteID);
                    ItemBUS.Instance.DeleteItem(DeleteID);
                }

            }

            showDTG_Item("");
        }

        private void btnModifyItem_Click(object sender, EventArgs e)
        {
            if (checkDigit(txtPriceItem.Text))
            {
                if (MessageBox.Show("Bạn có thật sự muốn sửa " + dtgvItem.CurrentRow.Cells[1].Value.ToString() + " ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
                {
                    ItemDTO item = getItemDataToUpdate();
                    ItemBUS.Instance.UpdateItem(item);
                    showDTG_Item("");
                }
            }
            else MessageBox.Show("Vui lòng nhập giá là số!");


        }

        private void btnShowItem_Click(object sender, EventArgs e)
        {

            showDTG_Item("");
            txtSearchItem.Text = "";
        }

        private void dtgvItem_SelectionChanged(object sender, EventArgs e)
        {
            txtIDItem.Text = dtgvItem.CurrentRow.Cells[0].Value.ToString();
            txtNameItem.Text = dtgvItem.CurrentRow.Cells[1].Value.ToString();
            cxbCategoryItem.Text = CategoryBUS.Instance.GetNamebyIDCategory(Convert.ToInt32(dtgvItem.CurrentRow.Cells[2].Value.ToString()));
            txtPriceItem.Text = dtgvItem.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {
            string name = txtSearchItem.Text;
            showDTG_Item(name);

        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Form f = new AddCategory();
            f.ShowDialog();
            LoadCatergory();
        }
    }
}
