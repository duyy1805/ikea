using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ikea.UI.Dashboard
{
    public partial class uc_dashboard : UserControl
    {
        public uc_dashboard()
        {
            InitializeComponent();
            adduc(new uc_dashboard_1());
        }

        private void adduc(UserControl uc)
        {
            //dashboardPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            dashboardPanel.Controls.Add(uc);
            uc.BringToFront();
        }
        private void btnDashboard_1_Click(object sender, EventArgs e)
        {
            adduc(new uc_dashboard_1());
        }

        private void btnDashboard_2_Click(object sender, EventArgs e)
        {
            adduc(new uc_dashboard_2());
        }
    }
}
