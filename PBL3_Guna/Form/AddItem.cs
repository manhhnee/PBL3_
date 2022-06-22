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
            private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
            ItemDTO item = getItemDataToAdd();
            ItemBUS.Instance.AddItem(item);
            this.Close();
        }
    }
}
