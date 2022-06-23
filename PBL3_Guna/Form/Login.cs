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
using System.Threading;

namespace PBL3_Guna
{
    public partial class Login : Form
    {
        int i = 0;
        public static string _username;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            _username = txtUser.Text;
            AccountDTO account = new AccountDTO(txtUser.Text, txtPass.Text);
            object kq = AccountBUS.Instance.CheckLogin(account);
            int code = Convert.ToInt32(kq);
            if (code == 0)
            {

                MessageBox.Show("Đăng nhập thành công !");
                Admin ql = new Admin();
                this.Hide();
                ql.ShowDialog();
                this.Show();
                txtUser.Text = "";
                txtPass.Text = "";

                txtUser.Focus();
            }
            else if (code == 1)
            {

                MessageBox.Show("Đăng nhập thành công !");
                Staff nv = new Staff();
                this.Hide();
                nv.ShowDialog();
                this.Show();
                txtUser.Text = "";
                txtPass.Text = "";

                txtUser.Focus();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng tài khoản hoặc mật khẩu", "Cảnh báo đăng nhập!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUser.Text = "";
                txtPass.Text = "";
                txtUser.Focus();
            }
        }

        

        private void ShowPass_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 != 0)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else txtPass.UseSystemPasswordChar = true;

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                this.Close();
            }
        }
    }
}
