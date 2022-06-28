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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        public void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(userControl);
            PanelContainer.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            UC_Home uchome = new UC_Home();
            addUserControl(uchome);
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            UC_Item ucitem = new UC_Item();
            addUserControl(ucitem);
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            UC_Staff ucstaff = new UC_Staff();
            addUserControl(ucstaff);
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            UC_Revenue ucrevenue = new UC_Revenue();
            addUserControl(ucrevenue);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UC_Revenue._id = 0;
            this.Close();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
