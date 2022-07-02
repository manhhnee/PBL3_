﻿using System;
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

namespace PBL3_Guna
{
    public partial class UC_Staff : UserControl
    {
        public UC_Staff()
        {
            InitializeComponent();
            showDTG_Staff("");
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
        public StaffDTO getStaffDataToUpdate()
        {
            StaffDTO staff = new StaffDTO();
            staff.ID = Convert.ToInt32(txtIDStaff.Text);
            staff.Name = txtDisplayName.Text;
            staff.Address = txtAddressStaff.Text;
            staff.Age = Convert.ToInt32(txtAgeStaff.Text);
            staff.PhoneNumber = txtPhoneNumberStaff.Text;
            staff.WorkingDays = Convert.ToInt32(txtWorkingDays.Text);
            staff.SalaryCoefficient = Convert.ToDouble(txtCoefficient.Text);
            return staff;
        }
        public void showDTG_Staff(string name)
        {
            dtgvStaff.DataSource = StaffBUS.Instance.GetStaffByName(name);
        }



        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            Form f = new AddStaff();
            f.ShowDialog();
            showDTG_Staff("");
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (dtgvStaff.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa  " + dtgvStaff.CurrentRow.Cells[1].Value.ToString() + " ra khỏi danh sách ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
                {
                    int DeleteID = Convert.ToInt32(dtgvStaff.CurrentRow.Cells[0].Value.ToString());
                    AccountBUS.Instance.DeleteAcount(DeleteID);
                    StaffBUS.Instance.DeleteStaff(DeleteID);
                }
            }

            showDTG_Staff("");
        }

        private void btnModifyStaff_Click(object sender, EventArgs e)
        {
            if (checkDigit(txtAgeStaff.Text))
            {
                StaffDTO staff = getStaffDataToUpdate();
                if (MessageBox.Show("Bạn có thật sự muốn cập nhập thông tin của " + dtgvStaff.CurrentRow.Cells[1].Value.ToString() + " ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
                {
                    StaffBUS.Instance.UpdateStaffBUS(staff);
                    showDTG_Staff("");
                }
            }
            else MessageBox.Show("Vui lòng nhập tuổi là một số!");
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            showDTG_Staff("");
            txtSearchStaff.Text = "";
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            string name = txtSearchStaff.Text;
            showDTG_Staff(name);
        }

        private void dtgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            int idStaff = Convert.ToInt32(dtgvStaff.CurrentRow.Cells[0].Value.ToString());
            txtIDStaff.Text = idStaff.ToString();
            txtDisplayName.Text = dtgvStaff.CurrentRow.Cells[1].Value.ToString();
            txtAddressStaff.Text = dtgvStaff.CurrentRow.Cells[2].Value.ToString();
            txtAgeStaff.Text = dtgvStaff.CurrentRow.Cells[3].Value.ToString();
            txtPhoneNumberStaff.Text = dtgvStaff.CurrentRow.Cells[4].Value.ToString();
            txtUserNameStaff.Text = AccountBUS.Instance.GetUserNameByIDStaff(idStaff);
            txtWorkingDays.Text = dtgvStaff.CurrentRow.Cells[5].Value.ToString();
            txtCoefficient.Text = dtgvStaff.CurrentRow.Cells[6].Value.ToString();
            int Workingdays = Convert.ToInt32(txtWorkingDays.Text);
            double Coefficient = Convert.ToDouble(txtCoefficient.Text);
            double salary = 0;
            if (Coefficient > 0)
            {
                salary = 100000 * Workingdays * Coefficient;
            }
            else salary = 100000 * Workingdays;

            txtSalary.Text = salary.ToString();
        }
    }
}
