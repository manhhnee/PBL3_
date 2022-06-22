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
    public partial class AddStaff : Form
    {
        public AddStaff()
        {
            InitializeComponent();
        }
        public StaffDTO getStaffDataToAdd()
        
        {
            StaffDTO staff = new StaffDTO();
            staff.Name = txtDisplayName.Text;
            staff.Address = txtAddressStaff.Text;
            staff.Age = Convert.ToInt32(txtAgeStaff.Text);
            staff.PhoneNumber = txtPhoneNumberStaff.Text;
            return staff;
        }
        public AccountDTO getDataToCreateAccount()
        {
            AccountDTO account = new AccountDTO();
            account.UserName = txtUserNameStaff.Text;
            account.DisplayName = txtDisplayName.Text;
            account.Password = txtPassStaff.Text;
            return account;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StaffDTO staff = getStaffDataToAdd();
            AccountDTO account = getDataToCreateAccount();
            if (AccountBUS.Instance.CheckUserName(account.UserName.ToString()) == true)
            {
                if (txtPassStaff.Text != "")
                {
                    StaffBUS.Instance.AddStaffBUS(staff);
                    account.IDStaff = StaffBUS.Instance.GetIDStaffByName(staff.Name);
                    AccountBUS.Instance.AddAccountBUS(account);
                    this.Close();
                }
                else MessageBox.Show("Không được để trống mật khẩu !");
            }
            else MessageBox.Show("Đã tồn tại UserName này");
        }
    }
}
