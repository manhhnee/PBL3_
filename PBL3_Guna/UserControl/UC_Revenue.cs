﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using System.Globalization;

namespace PBL3_Guna
{
    public partial class UC_Revenue : UserControl
    {
        public static int _id = 0;
        public static int _total;

        public UC_Revenue()
        {
            InitializeComponent();
            
        }

        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dtgvBill.DataSource = BillBUS.Instance.GetListBillByDate(checkIn, checkOut);
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            ShowBill(dtpkFromDate.Value, dtpkToDate.Value);
        }
        public void ShowBill(DateTime checkIn, DateTime checkOut)
        {
            double total = 0;
            for (int i = 0; i < dtgvBill.Rows.Count - 1; i++)
            {
                total += Convert.ToDouble(dtgvBill.Rows[i].Cells[2].Value.ToString());
            }
            double total2 = Double.Parse(total.ToString(), NumberStyles.Currency, new CultureInfo("vi-VN"));

            lblTotalPrice.Text = total.ToString("c", new CultureInfo("vi-VN"));
        }

        private void btnDetailsBill_Click(object sender, EventArgs e)
        {
            if (dtgvBill.SelectedRows.Count > 0)
            {
                _id = Convert.ToInt32(dtgvBill.CurrentRow.Cells[0].Value.ToString());
                _total = Convert.ToInt32(dtgvBill.CurrentRow.Cells[2].Value.ToString());
                Form detailsbill = new DetailsBill();
                detailsbill.ShowDialog();
            }
            else MessageBox.Show("vui lòng chọn hóa đơn để xem");
        }

        private void txtFirstPage_Click(object sender, EventArgs e)
        {
            txtPage.Text = "1";
        }

        private void txtLastPage_Click(object sender, EventArgs e)
        {
            int sum = BillBUS.Instance.GetNumBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            int lastSum = sum / 10;
            if(sum % 10 != 0)
            {
                lastSum++;
            }    
            txtPage.Text = lastSum.ToString();
        }

        private void txtPage_TextChanged(object sender, EventArgs e)
        {
            dtgvBill.DataSource = BillBUS.Instance.GetListBillByDateAndPage(dtpkFromDate.Value, dtpkToDate.Value, Convert.ToInt32(txtPage.Text));
        }

        private void txtPreviousPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPage.Text);
            if (page > 1)
                page--;
            txtPage.Text = page.ToString();
        }

        private void txtNextPage_Click(object sender, EventArgs e)
        {
            int page = Convert.ToInt32(txtPage.Text);
            int sumPage = BillBUS.Instance.GetNumBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            int lastSum = sumPage / 10;
            if (page <= lastSum)
            {
                page++;
            }
            txtPage.Text = page.ToString();
            
        }
    }
}
