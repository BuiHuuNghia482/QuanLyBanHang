using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKy.GUI
{
    public partial class FormBanHang : Form
    {
        public FormBanHang()
        {
            InitializeComponent();
        }

        private void FormBanHang_Load(object sender, EventArgs e)
        {

        }

        private void navBarItemPhieuBanHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FormBanHangPhieu phieu = new FormBanHangPhieu();
            phieu.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(phieu);
            phieu.Show();
        }
    }
}
