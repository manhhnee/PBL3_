using BUS;
using DTO;
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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent();
            LoadCatergory();
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
        public ItemDTO getItemDataToAdd()
        {
            ItemDTO item = new ItemDTO();
            
            item.Name = txtNameItem.Text;
            item.IDCategory = (CategoryBUS.Instance.GetIDbyNameCategory(cxbCategoryItem.Text));
            item.Price = Convert.ToInt32(txtPriceItem.Text);
            return item;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtNameItem.Text.Trim() != "" && txtPriceItem.Text.Trim() != "" && cxbCategoryItem.SelectedItem != null)
            {
                if (checkDigit(txtPriceItem.Text))
                {
                    ItemDTO item = getItemDataToAdd();
                    if (ItemBUS.Instance.CheckNameItem(item.Name.ToString()) == true)
                    {
                        ItemBUS.Instance.AddItem(item);
                        this.Close();
                    }
                    else MessageBox.Show("Đã tồn tại món này!");
                }
                else MessageBox.Show("Vui lòng nhập giá là số!");
            }
            else MessageBox.Show("Vui lòng nhập đầy đủ!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
