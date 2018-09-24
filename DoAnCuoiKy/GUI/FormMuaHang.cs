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
    public partial class FormMuaHang : Form
    {
        public FormMuaHang()
        {
            InitializeComponent();
        }

        private void navBarItemPhieuNhapHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            splitContainer1.Panel2.Controls.Clear();
            FormMuaHangPhieu phieu = new FormMuaHangPhieu();
            phieu.TopLevel = false;
            splitContainer1.Panel2.Controls.Add(phieu);
            phieu.Show();
        }
    }
}
