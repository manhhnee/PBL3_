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
    public partial class Staff : Form
    {
        public Staff()
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

        private void btnOrder_Click(object sender, EventArgs e)
        {
            UC_Order ucorder = new UC_Order();
            addUserControl(ucorder);
        }

        private void btnInformation_Click(object sender, EventArgs e)
        {
            UC_Information ucinfo = new UC_Information();
            addUserControl(ucinfo);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
