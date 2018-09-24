using DoAnCuoiKy.BUS;
using DoAnCuoiKy.DTO;
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
    public partial class FormBoPhan : Form
    {
        List<VaiTroChucNang> vtcn = new List<VaiTroChucNang>();
        List<BoPhan> bp = new List<BoPhan>();
        public FormBoPhan()
        {
            InitializeComponent();
        }
        public FormBoPhan(List<VaiTroChucNang> vaitrochucnang)
        {
            InitializeComponent();
            vtcn = vaitrochucnang;
        }
        void load(DataTable bang)
        {
            if (bp.Count != 0)
            {
                for (int i = 0; i < bp.Count; i++)
                {
                    bp.RemoveAt(i);
                }
                var bangbophan = bang;
                bp = XL_BoPhan.ChuyenDoiDTOBoPhan(bangbophan);
            }
        }

        private void FormBoPhan_Load(object sender, EventArgs e)
        {
            var bangbophan = XL_BoPhan.LayDuLieuBoPhan();
            gridControl1.DataSource = bangbophan;
            bp= XL_BoPhan.ChuyenDoiDTOBoPhan(bangbophan);
            //phan quyen button
            for (int i = 0; i < vtcn.Count; i++)
            {
                if (vtcn[i].TenTrongHeThong == this.Tag.ToString())
                {

                    if (vtcn[i].Them == true)
                    {
                        simpleButtonThem.Enabled = true;
                    }
                    if (vtcn[i].Xoa == true)
                    {
                        simpleButtonXoa.Enabled = true;
                    }
                    if (vtcn[i].Sua == true)
                    {
                        simpleButtonSua.Enabled = true;
                    }
                    break;
                }
            }
            //phan quyen contextMenuStrip
            for (int i = 0; i < vtcn.Count; i++)
            {
                if (vtcn[i].TenTrongHeThong == this.Tag.ToString())
                {
                    for (int j = 0; j < contextMenuStrip1.Items.Count; j++)
                    {
                        if (contextMenuStrip1.Items[j].Text == "Thêm" && vtcn[i].Them == true)
                        {
                            contextMenuStrip1.Items[j].Enabled = true;
                        }
                        if (contextMenuStrip1.Items[j].Text == "Xóa" && vtcn[i].Xoa == true)
                        {
                            contextMenuStrip1.Items[j].Enabled = true;
                        }
                        if (contextMenuStrip1.Items[j].Text == "Sửa" && vtcn[i].Sua == true)
                        {
                            contextMenuStrip1.Items[j].Enabled = true;
                        }
                    }
                    break;
                }
            }
        }

        private void simpleButtonThem_Click(object sender, EventArgs e)
        {
            load(XL_BoPhan.LayDuLieuBoPhan());
            //
            FormBoPhanThem them = new FormBoPhanThem(bp);
            them.ShowDialog();
            //cap nhat csdl
            var bangbophan = XL_BoPhan.LayDuLieuBoPhan();
            gridControl1.DataSource = bangbophan;
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            load(XL_BoPhan.LayDuLieuBoPhan());
            //
            FormBoPhanXoa xoa = new FormBoPhanXoa(bp);
            xoa.ShowDialog();
            //cap nhat csdl
            var bangbophan = XL_BoPhan.LayDuLieuBoPhan();
            gridControl1.DataSource = bangbophan;
        }

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
            load(XL_BoPhan.LayDuLieuBoPhan());
            //
            FormBoPhanSua sua = new FormBoPhanSua(bp);
            sua.ShowDialog();
            //cap nhat csdl
            var bangbophan = XL_BoPhan.LayDuLieuBoPhan();
            gridControl1.DataSource = bangbophan;
        }

        private void ToolStripMenuItemThem_Click(object sender, EventArgs e)
        {
            load(XL_BoPhan.LayDuLieuBoPhan());
            //
            FormBoPhanThem them = new FormBoPhanThem(bp);
            them.ShowDialog();
            //cap nhat csdl
            var bangbophan = XL_BoPhan.LayDuLieuBoPhan();
            gridControl1.DataSource = bangbophan;
        }

        private void ToolStripMenuItemXoa_Click(object sender, EventArgs e)
        {
            load(XL_BoPhan.LayDuLieuBoPhan());
            //
            FormBoPhanXoa xoa = new FormBoPhanXoa(bp);
            xoa.ShowDialog();
            //cap nhat csdl
            var bangbophan = XL_BoPhan.LayDuLieuBoPhan();
            gridControl1.DataSource = bangbophan;
        }

        private void ToolStripMenuItemSua_Click(object sender, EventArgs e)
        {
            load(XL_BoPhan.LayDuLieuBoPhan());
            //
            FormBoPhanSua sua = new FormBoPhanSua(bp);
            sua.ShowDialog();
            //cap nhat csdl
            var bangbophan = XL_BoPhan.LayDuLieuBoPhan();
            gridControl1.DataSource = bangbophan;
        }
    }
}
