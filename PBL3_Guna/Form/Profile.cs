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
    public partial class Profile : Form
    {
        static int i = 0;
        public Profile()
        {
            InitializeComponent();
            GUI();
        }
        public void GUI()
        {
            txtUserNameStaff.Text = Login._username;
            AccountDTO dt = AccountBUS.Instance.GetAccountByUserName(txtUserNameStaff.Text);
            txtDisplayName.Text = dt.DisplayName.ToString();
            txtPassStaff.Text = dt.Password.ToString();
            if (dt.TypeID != 0)
            {
                txtChucVu.Text = "nhân viên";
            }
            else txtChucVu.Text = "quản lí";
           


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPass_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 != 0)
            {
                txtPassStaff.UseSystemPasswordChar = false;
            }
            else txtPassStaff.UseSystemPasswordChar = true;
        }
    }
}
