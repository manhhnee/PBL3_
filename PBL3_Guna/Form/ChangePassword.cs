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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AccountDTO acc = AccountBUS.Instance.GetAccountByUserName(Login._username);
            if (txtOldPass.Text == acc.Password.ToString() && txtAgainPass.Text == txtNewPass.Text && txtNewPass.Text != "")
            {
                acc.Password = txtNewPass.Text;
                AccountBUS.Instance.ChangePassAcc(acc);
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
            }
            else if (txtOldPass.Text != acc.Password.ToString())
            {
                MessageBox.Show("Mật khẩu cũ không chính xác");
            }
            else if (txtAgainPass.Text != txtNewPass.Text)
            {
                MessageBox.Show("Mật khẩu mới không trùng với mật khẩu cũ");
            }
            else if (txtNewPass.Text == "")
            {
                MessageBox.Show("Không được để trống");
            }
            else MessageBox.Show("Lỗi!!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
