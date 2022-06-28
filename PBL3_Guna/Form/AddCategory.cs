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
    public partial class AddCategory : Form
    {
        public AddCategory()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CategoryDTO CT = new CategoryDTO();
            CT.Name = txtCategory.Text;
            if (txtCategory.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên mặt hàng !");
            }
            else
            {
                CategoryBUS.Instance.AddCategory(CT);
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
