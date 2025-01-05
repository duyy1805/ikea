using ikea.UI.Dashboard;
using ikea.UI.Kho;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ikea
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
            button1.Image = new Bitmap(ikea.Properties.Resources.close, new Size(20, 20));
            btnMaximize.Image = new Bitmap(ikea.Properties.Resources.maximize, new Size(20, 20));
            button3.Image = new Bitmap(ikea.Properties.Resources.minimize, new Size(20, 20));
        }

        private void adduc(UserControl uc)
        {
            //mainPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(uc);
            uc.BringToFront();
        }
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            adduc(new uc_dashboard());
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            adduc(new uc_kho());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal; // Thu nhỏ nếu đang ở trạng thái phóng to
                btnMaximize.Image = new Bitmap(ikea.Properties.Resources.maximize, new Size(20, 20));
            }
            else
            {
                this.WindowState = FormWindowState.Maximized; // Phóng to cửa sổ
                btnMaximize.Image = new Bitmap(ikea.Properties.Resources.minimize_tr, new Size(18, 18));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
