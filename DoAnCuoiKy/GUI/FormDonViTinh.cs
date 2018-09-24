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
    public partial class FormDonViTinh : Form
    {
        List<VaiTroChucNang> vtcn = new List<VaiTroChucNang>();
        List<DonViTinh> dvt = new List<DonViTinh>();
        public FormDonViTinh()
        {
            InitializeComponent();
        }
        public FormDonViTinh(List<VaiTroChucNang> vaitrochucnang)
        {
            InitializeComponent();
            vtcn = vaitrochucnang;
        }
        void load(DataTable bang)
        {
            if (dvt.Count != 0)
            {
                for (int i = 0; i < dvt.Count; i++)
                {
                    dvt.RemoveAt(i);
                }
                var bangdonvitinh = bang;
                dvt = XL_DonViTinh.ChuyenDoiDTODonViTinh(bangdonvitinh);
            }
        }

        private void FormDonViTinh_Load(object sender, EventArgs e)
        {
            var bangdonvitinh = XL_DonViTinh.LayDuLieuDonViTinh();
            gridControl1.DataSource = bangdonvitinh;
            dvt = XL_DonViTinh.ChuyenDoiDTODonViTinh(bangdonvitinh);
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
            load(XL_DonViTinh.LayDuLieuDonViTinh());
            //
            FormDonViTinhThem them = new FormDonViTinhThem(dvt);
            them.ShowDialog();
            //cap nhat csdl
            var bangdonvitinh = XL_DonViTinh.LayDuLieuDonViTinh();
            gridControl1.DataSource = bangdonvitinh;
        }

        private void simpleButtonXoa_Click(object sender, EventArgs e)
        {
            load(XL_DonViTinh.LayDuLieuDonViTinh());
            //
            FormDonViTinhXoa xoa = new FormDonViTinhXoa(dvt);
            xoa.ShowDialog();
            //cap nhat csdl
            var bangdonvitinh = XL_DonViTinh.LayDuLieuDonViTinh();
            gridControl1.DataSource = bangdonvitinh;
        }

        private void simpleButtonSua_Click(object sender, EventArgs e)
        {
            load(XL_DonViTinh.LayDuLieuDonViTinh());
            //
            FormDonViTinhSua sua = new FormDonViTinhSua(dvt);
            sua.ShowDialog();
            //cap nhat csdl
            var bangdonvitinh = XL_DonViTinh.LayDuLieuDonViTinh();
            gridControl1.DataSource = bangdonvitinh;
        }

        private void ToolStripMenuItemThem_Click(object sender, EventArgs e)
        {
            load(XL_DonViTinh.LayDuLieuDonViTinh());
            //
            FormDonViTinhThem them = new FormDonViTinhThem(dvt);
            them.ShowDialog();
            //cap nhat csdl
            var bangdonvitinh = XL_DonViTinh.LayDuLieuDonViTinh();
            gridControl1.DataSource = bangdonvitinh;
        }

        private void ToolStripMenuItemXoa_Click(object sender, EventArgs e)
        {
            load(XL_DonViTinh.LayDuLieuDonViTinh());
            //
            FormDonViTinhXoa xoa = new FormDonViTinhXoa(dvt);
            xoa.ShowDialog();
            //cap nhat csdl
            var bangdonvitinh = XL_DonViTinh.LayDuLieuDonViTinh();
            gridControl1.DataSource = bangdonvitinh;
        }

        private void ToolStripMenuItemSua_Click(object sender, EventArgs e)
        {
            load(XL_DonViTinh.LayDuLieuDonViTinh());
            //
            FormDonViTinhSua sua = new FormDonViTinhSua(dvt);
            sua.ShowDialog();
            //cap nhat csdl
            var bangdonvitinh = XL_DonViTinh.LayDuLieuDonViTinh();
            gridControl1.DataSource = bangdonvitinh;
        }
    }
}
