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
    public partial class FormKhoHang : Form
    {
        List<VaiTroChucNang> vtcn = new List<VaiTroChucNang>();
        List<KhoHang> kh = new List<KhoHang>();
        List<KhuVuc> kv = new List<KhuVuc>();
        public FormKhoHang()
        {
            InitializeComponent();
        }
        public FormKhoHang(List<VaiTroChucNang> vaitrochucnang)
        {
            InitializeComponent();
            vtcn = vaitrochucnang;
        }
        void load(DataTable bang)
        {
            if (kh.Count != 0)
            {
                for (int i = 0; i < kh.Count; i++)
                {
                    kh.RemoveAt(i);
                }
                var bangKhoHang = bang;
                kh = XL_KhoHang.ChuyenDoiDTOKhoHang(bangKhoHang);
            }
        }

        private void FormKhoHang_Load(object sender, EventArgs e)
        {
            //lay khu vuc
            kv = XL_KhuVuc.ChuyenDoiDTOKhuVuc(XL_KhuVuc.LayDuLieuKhuVuc());
            //
            var bangKhoHang = XL_KhoHang.LayDuLieuKhoHang();
            gridControl1.DataSource = bangKhoHang;
            kh = XL_KhoHang.ChuyenDoiDTOKhoHang(bangKhoHang);

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
            load(XL_KhoHang.LayDuLieuKhoHang());
            //
            FormKhoHangThem them = new FormKhoHangThem(kh, kv);
            them.ShowDialog();
            //
            var bangKhoHang = XL_KhoHang.LayDuLieuKhoHang();
            gridControl1.DataSource = bangKhoHang;
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            load(XL_KhoHang.LayDuLieuKhoHang());
            //
            FormKhoHangXoa xoa = new FormKhoHangXoa(kh);
            xoa.ShowDialog();
            //
            var bangKhoHang = XL_KhoHang.LayDuLieuKhoHang();
            gridControl1.DataSource = bangKhoHang;
        }

        private void simpleButtoSua_Click(object sender, EventArgs e)
        {
            load(XL_KhoHang.LayDuLieuKhoHang());
            //
            FormKhoHangSua sua = new FormKhoHangSua(kh, kv);
            sua.ShowDialog();
            //
            var bangKhoHang = XL_KhoHang.LayDuLieuKhoHang();
            gridControl1.DataSource = bangKhoHang;
        }

        private void ToolStripMenuItemThem_Click(object sender, EventArgs e)
        {
            load(XL_KhoHang.LayDuLieuKhoHang());
            //
            FormKhoHangThem them = new FormKhoHangThem(kh, kv);
            them.ShowDialog();
            //
            var bangKhoHang = XL_KhoHang.LayDuLieuKhoHang();
            gridControl1.DataSource = bangKhoHang;
        }

        private void ToolStripMenuItemXoa_Click(object sender, EventArgs e)
        {
            load(XL_KhoHang.LayDuLieuKhoHang());
            //
            FormKhoHangXoa xoa = new FormKhoHangXoa(kh);
            xoa.ShowDialog();
            //
            var bangKhoHang = XL_KhoHang.LayDuLieuKhoHang();
            gridControl1.DataSource = bangKhoHang;
        }

        private void ToolStripMenuItemSua_Click(object sender, EventArgs e)
        {
            load(XL_KhoHang.LayDuLieuKhoHang());
            //
            FormKhoHangSua sua = new FormKhoHangSua(kh, kv);
            sua.ShowDialog();
            //
            var bangKhoHang = XL_KhoHang.LayDuLieuKhoHang();
            gridControl1.DataSource = bangKhoHang;
        }
    }
}
