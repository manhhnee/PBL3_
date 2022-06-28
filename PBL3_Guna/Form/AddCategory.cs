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

<<<<<<< HEAD
        private void btnAdd_Click(object sender, EventArgs e)
=======
       

        

        private void btnAddCategory_Click(object sender, EventArgs e)
>>>>>>> e464e67c1292c8aa6135da52988d256fb2504dbe
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
