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
    }
}
