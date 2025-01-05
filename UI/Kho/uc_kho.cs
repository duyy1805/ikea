using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikea.UI.Kho
{
    public partial class uc_kho : UserControl
    {
        public uc_kho()
        {
            InitializeComponent();
            adduc(new uc_kho_1());
        }
        private void adduc(UserControl uc)
        {
            //dashboardPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Add(uc);
            uc.BringToFront();
        }
        private void btnKho_1_Click(object sender, EventArgs e)
        {
            adduc(new uc_kho_1());
        }

        private void btnKho_2_Click(object sender, EventArgs e)
        {
            adduc(new uc_kho_2());
        }
    }
}
