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
        static int i = 0;
        public AddStaff()
        {
            InitializeComponent();
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
        private void ShowPass_Click(object sender, EventArgs e)
        {
            i++;
            if (i % 2 != 0)
            {
                txtPassStaff.UseSystemPasswordChar = false;
            }
            else txtPassStaff.UseSystemPasswordChar = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUserNameStaff.Text.Trim() != "" && txtDisplayName.Text.Trim() != "" && txtAgeStaff.Text.Trim() != "" && txtAddressStaff.Text.Trim() != "" && txtPhoneNumberStaff.Text.Trim() != "" && txtPassStaff.Text.Trim() != "")
            {
                if (checkDigit(txtAgeStaff.Text))
                {
                    StaffDTO staff = getStaffDataToAdd();
                    AccountDTO account = getDataToCreateAccount();
                    if (AccountBUS.Instance.CheckUserName(account.UserName.ToString()) == true)
                    {
                        StaffBUS.Instance.AddStaffBUS(staff);
                        account.IDStaff = StaffBUS.Instance.GetIDStaffByName(staff.Name);
                        AccountBUS.Instance.AddAccountBUS(account);
                        this.Close();
                    }
                    else MessageBox.Show("Đã tồn tại UserName này");
                }
                else MessageBox.Show("Vui lòng nhập tuổi là một số!");
            }
            else MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
