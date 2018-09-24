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
    public partial class FormKhachHang : Form
    {
        List<VaiTroChucNang> vtcn = new List<VaiTroChucNang>();
        List<KhachHang> kh = new List<KhachHang>();
        List<KhuVuc> kv = new List<KhuVuc>();
        public FormKhachHang()
        {
            InitializeComponent();
        }
        void load(DataTable bang)
        {
            if (kh.Count != 0)
            {
                for (int i = 0; i < kh.Count; i++)
                {
                    kh.RemoveAt(i);
                }
                var bangKhachHang = bang;
                kh = XL_KhachHang.ChuyenDoiDTOKhachHang(bangKhachHang);
            }
        }
        public FormKhachHang(List<VaiTroChucNang> vaitrochucnang)
        {
            InitializeComponent();
            vtcn = vaitrochucnang;
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            //lay khu vuc
            var bangKhuVuc = XL_KhuVuc.LayDuLieuKhuVuc();
            kv = XL_KhuVuc.ChuyenDoiDTOKhuVuc(bangKhuVuc);


            var bangKhachHang = XL_KhachHang.LayDuLieuKhachHang();
            kh = XL_KhachHang.ChuyenDoiDTOKhachHang(bangKhachHang);
            gridControl1.DataSource = bangKhachHang;

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
            load(XL_KhachHang.LayDuLieuKhachHang());
            //
            FormKhachHangThem them = new FormKhachHangThem(kh,kv);
            them.ShowDialog();
            //
            var bangKhachHang = XL_KhachHang.LayDuLieuKhachHang();
            gridControl1.DataSource = bangKhachHang;
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            load(XL_KhachHang.LayDuLieuKhachHang());
            //
            FormKhachHangXoa them = new FormKhachHangXoa(kh);
            them.ShowDialog();
            //
            var bangKhachHang = XL_KhachHang.LayDuLieuKhachHang();
            gridControl1.DataSource = bangKhachHang;
        }

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
            load(XL_KhachHang.LayDuLieuKhachHang());
            //
            FormKhachHangSua sua = new FormKhachHangSua(kh, kv);
            sua.ShowDialog();
            //
            var bangKhachHang = XL_KhachHang.LayDuLieuKhachHang();
            gridControl1.DataSource = bangKhachHang;
        }

        private void ToolStripMenuItemThem_Click(object sender, EventArgs e)
        {
            load(XL_KhachHang.LayDuLieuKhachHang());
            //
            FormKhachHangThem them = new FormKhachHangThem(kh, kv);
            them.ShowDialog();
            //
            var bangKhachHang = XL_KhachHang.LayDuLieuKhachHang();
            gridControl1.DataSource = bangKhachHang;
        }

        private void ToolStripMenuItemXoa_Click(object sender, EventArgs e)
        {
            load(XL_KhachHang.LayDuLieuKhachHang());
            //
            FormKhachHangXoa them = new FormKhachHangXoa(kh);
            them.ShowDialog();
            //
            var bangKhachHang = XL_KhachHang.LayDuLieuKhachHang();
            gridControl1.DataSource = bangKhachHang;

        }

        private void ToolStripMenuItemSua_Click(object sender, EventArgs e)
        {
            load(XL_KhachHang.LayDuLieuKhachHang());
            //
            FormKhachHangSua sua = new FormKhachHangSua(kh, kv);
            sua.ShowDialog();
            //
            var bangKhachHang = XL_KhachHang.LayDuLieuKhachHang();
            gridControl1.DataSource = bangKhachHang;
        }
    }
}
