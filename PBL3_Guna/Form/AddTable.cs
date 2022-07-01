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
    public partial class AddTable : Form
    {
        public AddTable()
        {
            InitializeComponent();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            TableDTO table = new TableDTO();
            table.Name = txtTableName.Text;
            if (txtTableName.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên bàn !");
            }
            else
            {
                if (TableBUS.Instance.CheckNameTable(txtTableName.Text))
                {
                    TableBUS.Instance.AddTable(table);
                    this.Close();
                }
                else MessageBox.Show("Tên bàn đã tồn tại!");
            }
        }

        private void btnExitTable_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
