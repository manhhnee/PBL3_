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
    public partial class UC_Table : UserControl
    {
        public UC_Table()
        {
            InitializeComponent();
            ShowDTG_Table();
        }
        
        public void ShowDTG_Table()
        {
            dtgvTable.DataSource = TableBUS.Instance.GetListTable();
            dtgvTable.Columns[2].Visible = false;
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            AddTable addTable = new AddTable();
            addTable.ShowDialog();
            ShowDTG_Table();
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            if (dtgvTable.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("Bạn có thật sự muốn xóa  " + dtgvTable.CurrentRow.Cells[1].Value.ToString() + " ra khỏi danh sách ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
                {
                    int DeleteID = Convert.ToInt32(dtgvTable.CurrentRow.Cells[0].Value.ToString());
                    TableBUS.Instance.DeleteTable(DeleteID);
                }
            }
            ShowDTG_Table();
        }

        private void btnModifyTable_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn sửa " + dtgvTable.CurrentRow.Cells[1].Value.ToString() + " ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.Cancel)
            {
                TableBUS.Instance.UpdateTable(Convert.ToInt32(txtIDTable.Text), txtTableName.Text);
                ShowDTG_Table();
            }
        }

        private void dtgvTable_SelectionChanged(object sender, EventArgs e)
        {
            txtIDTable.Text = dtgvTable.CurrentRow.Cells[0].Value.ToString();
            txtTableName.Text = dtgvTable.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
