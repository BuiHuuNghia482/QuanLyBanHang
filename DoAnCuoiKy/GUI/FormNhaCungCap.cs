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
    public partial class FormNhaCungCap : Form
    {
        List<VaiTroChucNang> vtcn = new List<VaiTroChucNang>();
        List<NhaCungCap> ncc = new List<NhaCungCap>();
        List<KhuVuc> kv = new List<KhuVuc>();
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        void load(DataTable bang)
        {
            if (ncc.Count != 0)
            {
                for (int i = 0; i < ncc.Count; i++)
                {
                    ncc.RemoveAt(i);
                }
                var bangNhaCungCap = bang;
                ncc = XL_NhaCungCap.ChuyenDoiDTONhaCungCap(bangNhaCungCap);
            } 
        }
        public FormNhaCungCap(List<VaiTroChucNang> vaitrochucnang)
        {
            InitializeComponent();
            vtcn = vaitrochucnang;
        }
        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            // lay ncc
            var bangNhaCungCap = XL_NhaCungCap.LayDuLieuNhaCungCap();
            gridControl1.DataSource = bangNhaCungCap;
            ncc = XL_NhaCungCap.ChuyenDoiDTONhaCungCap(bangNhaCungCap);
            //lay khu vuc
            var bangKhuVuc = XL_KhuVuc.LayDuLieuKhuVuc();
            kv = XL_KhuVuc.ChuyenDoiDTOKhuVuc(bangKhuVuc);
            //phan quyen
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
            load(XL_NhaCungCap.LayDuLieuNhaCungCap());
            //
            FormNhaCungCapThem them = new FormNhaCungCapThem(ncc, kv);
            them.ShowDialog();
            //
            var bangNhaCungCap = XL_NhaCungCap.LayDuLieuNhaCungCap();
            gridControl1.DataSource = bangNhaCungCap;
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            load(XL_NhaCungCap.LayDuLieuNhaCungCap());
            //
            FormNhaCungCapXoa Xoa = new FormNhaCungCapXoa(ncc);
            Xoa.ShowDialog();
            //
            var bangNhaCungCap = XL_NhaCungCap.LayDuLieuNhaCungCap();
            gridControl1.DataSource = bangNhaCungCap;
        }

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
            load(XL_NhaCungCap.LayDuLieuNhaCungCap());
            //
            FormNhaCungCapSua Sua = new FormNhaCungCapSua(ncc, kv);
            Sua.ShowDialog();
            //
            var bangNhaCungCap = XL_NhaCungCap.LayDuLieuNhaCungCap();
            gridControl1.DataSource = bangNhaCungCap;
        }

        private void ToolStripMenuItemThem_Click(object sender, EventArgs e)
        {
            load(XL_NhaCungCap.LayDuLieuNhaCungCap());
            //
            FormNhaCungCapThem them = new FormNhaCungCapThem(ncc, kv);
            them.ShowDialog();
            //
            var bangNhaCungCap = XL_NhaCungCap.LayDuLieuNhaCungCap();
            gridControl1.DataSource = bangNhaCungCap;
        }

        private void ToolStripMenuItemXoa_Click(object sender, EventArgs e)
        {
            load(XL_NhaCungCap.LayDuLieuNhaCungCap());
            //
            FormNhaCungCapXoa Xoa = new FormNhaCungCapXoa(ncc);
            Xoa.ShowDialog();
            //
            var bangNhaCungCap = XL_NhaCungCap.LayDuLieuNhaCungCap();
            gridControl1.DataSource = bangNhaCungCap;
        }

        private void ToolStripMenuItemSua_Click(object sender, EventArgs e)
        {
            load(XL_NhaCungCap.LayDuLieuNhaCungCap());
            //
            FormNhaCungCapSua Sua = new FormNhaCungCapSua(ncc, kv);
            Sua.ShowDialog();
            //
            var bangNhaCungCap = XL_NhaCungCap.LayDuLieuNhaCungCap();
            gridControl1.DataSource = bangNhaCungCap;
        }
    }
}
