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
    public partial class FormKhuVuc : Form
    {
        List<VaiTroChucNang> vtcn = new List<VaiTroChucNang>();
        List<KhuVuc> kv = new List<KhuVuc>();
        public FormKhuVuc()
        {
            InitializeComponent();
        }
        public FormKhuVuc(List<VaiTroChucNang>vaitrochucnang)
        {
            InitializeComponent();
            vtcn = vaitrochucnang;
        }

        void load(DataTable bang)
        {
            if (kv.Count != 0)
            {
                for (int i = 0; i < kv.Count; i++)
                {
                    kv.RemoveAt(i);
                }
                var bangKhuVuc = bang;
                kv = XL_KhuVuc.ChuyenDoiDTOKhuVuc(bangKhuVuc);
            }          
        }
        private void FormKhuVuc_Load(object sender, EventArgs e)
        {
            var bangKhuVuc = XL_KhuVuc.LayDuLieuKhuVuc();
            gridControl1.DataSource = bangKhuVuc;
            kv = XL_KhuVuc.ChuyenDoiDTOKhuVuc(bangKhuVuc);
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
            load(XL_KhuVuc.LayDuLieuKhuVuc());
            //
            FormKhuVucThem them = new FormKhuVucThem(kv);
            them.ShowDialog();
            //cap nhat csdl
            var bangKhuVuccapnhat = XL_KhuVuc.LayDuLieuKhuVuc();
            gridControl1.DataSource = bangKhuVuccapnhat;

        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            load(XL_KhuVuc.LayDuLieuKhuVuc());
            //
            FormKhuVucXoa Xoa = new FormKhuVucXoa(kv);
            Xoa.ShowDialog();
            //cap nhat csdl
            var bangKhuVuc = XL_KhuVuc.LayDuLieuKhuVuc();
            gridControl1.DataSource = bangKhuVuc;
        }

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
            load(XL_KhuVuc.LayDuLieuKhuVuc());
            //
            FormKhuVucSua sua = new FormKhuVucSua(kv);
            sua.ShowDialog();
            //cap nhat csdl
            var bangKhuVuccapnhat = XL_KhuVuc.LayDuLieuKhuVuc();
            gridControl1.DataSource = bangKhuVuccapnhat;
        }

        private void ToolStripMenuItemThem_Click(object sender, EventArgs e)
        {
            load(XL_KhuVuc.LayDuLieuKhuVuc());
            //
            FormKhuVucThem them = new FormKhuVucThem(kv);
            them.ShowDialog();
            //cap nhat csdl
            var bangKhuVuc = XL_KhuVuc.LayDuLieuKhuVuc();
            gridControl1.DataSource = bangKhuVuc;
        }

        private void ToolStripMenuItemXoa_Click(object sender, EventArgs e)
        {
            load(XL_KhuVuc.LayDuLieuKhuVuc());
            //
            FormKhuVucXoa Xoa = new FormKhuVucXoa(kv);
            Xoa.ShowDialog();
            //cap nhat csdl
            var bangKhuVuc = XL_KhuVuc.LayDuLieuKhuVuc();
            gridControl1.DataSource = bangKhuVuc;
        }

        private void ToolStripMenuItemSua_Click(object sender, EventArgs e)
        {
            load(XL_KhuVuc.LayDuLieuKhuVuc());
            //
            FormKhuVucSua sua = new FormKhuVucSua(kv);
            sua.ShowDialog();
            //cap nhat csdl
            var bangKhuVuc = XL_KhuVuc.LayDuLieuKhuVuc();
            gridControl1.DataSource = bangKhuVuc;
        }
    }
}
