using DevExpress.XtraTab;
using DoAnCuoiKy.DTO;
using DoAnCuoiKy.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DoAnCuoiKy
{
    public partial class Form1 : Form
    {
        public VaiTro vt = new VaiTro();
        public List<DTO.VaiTroChucNang> vtcn = new List<VaiTroChucNang>();
        public TaiKhoan tk = new TaiKhoan();
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(List<DTO.VaiTroChucNang> vaitrochucnang,VaiTro vaitro,TaiKhoan taiKhoan)
        {
            InitializeComponent();
            vt = vaitro;
            vtcn = vaitrochucnang;
            tk = taiKhoan;

        }
        private void barButtonItemKetThuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // lay gio he thong 
            barHeaderItemNgay.Caption += DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss");
            //lay ten may tinh
            barHeaderItemTenMayTinh.Caption += Environment.MachineName;
            //lay ten vai tro nguoi dang nhap la admin hay nhanvien hay quanly
            barHeaderItemQuyen.Caption += vt.TenVaiTro;
            //XtraTabPage a = new XtraTabPage();
            //a.Name = "xtraTabPage";
            //a.Text = "HuuNghia";
            //xtraTabControlNoiDung.TabPages.Add(a);

            //phan quyen
            int n = ribbonControlMain.Items.Count;//dem buton
            int m = vtcn.Count;
            //Cap 3
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (ribbonControlMain.Items[i].Name == vtcn[j].TenTrongHeThong && vtcn[j].TruyXuat == true)
                    {
                        ribbonControlMain.Items[i].Enabled = true;
                        break;
                    }
                }

            }
            //link https://documentation.devexpress.com/WindowsForms/DevExpress.XtraBars.Ribbon.RibbonControl.class

        }

        private void barButtonItemThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormThongTin tt = new FormThongTin();
            tt.ShowDialog();
        }

        private void barButtonItemTGThongTin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormThongTin tt = new FormThongTin();
            tt.ShowDialog();
        }

        private void barButtonItemLienHe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormLienHe lh = new FormLienHe();
            lh.ShowDialog();
        }

        private void barButtonItemDoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormDoiMatKhau dmk = new FormDoiMatKhau(tk);
            dmk.ShowDialog();
        }

        private void barButtonItemPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //PageVisible trang thay tat hay mo
            // true la on .. false la off
            //enable cung dc

        }

        private void barButtonItemSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormSaoLuu saoLuu = new FormSaoLuu();
            saoLuu.ShowDialog();
        }

        private void barButtonItemPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormPhucHoi phucHoi = new FormPhucHoi();
            phucHoi.ShowDialog();
        }

        private void barButtonItemKhuVuc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //co hieu
            bool falg = false;
            for (int i = 0; i < xtraTabControlNoiDung.TabPages.Count; i++)
            {
                if(xtraTabControlNoiDung.TabPages[i].Name== "xtraTabPageKhuVuc")
                {
                    falg = true;
                    xtraTabControlNoiDung.SelectedTabPage = xtraTabControlNoiDung.TabPages[i];
                    break;
                }
            }
            if (falg == false)
            {
                FormKhuVuc khuVuc = new FormKhuVuc(vtcn);
                //tao tabpase s do chen vo tabcontrol
                XtraTabPage tab = new XtraTabPage();
                tab.Name = "xtraTabPageKhuVuc";
                tab.Text = "Khu Vực";
                xtraTabControlNoiDung.TabPages.Add(tab);
                //nhan vao button hien thi tab
                xtraTabControlNoiDung.SelectedTabPage = tab;

                khuVuc.TopLevel = false;
                khuVuc.Parent = tab;
                //  Form.MdiParent = this;
                khuVuc.Show();

                khuVuc.Dock = DockStyle.Fill;
            }

        }

        private void barButtonItemKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool falg = false;
            for (int i = 0; i < xtraTabControlNoiDung.TabPages.Count; i++)
            {
                if (xtraTabControlNoiDung.TabPages[i].Name == "xtraTabPageKhachHang")
                {
                    falg = true;
                    xtraTabControlNoiDung.SelectedTabPage = xtraTabControlNoiDung.TabPages[i];
                    break;
                }
            }
            if (falg == false)
            {
                FormKhachHang khachHang = new FormKhachHang(vtcn);
                //tao tabpase s do chen vo tabcontrol
                XtraTabPage tab = new XtraTabPage();
                tab.Name = "xtraTabPageKhachHang";
                tab.Text = "Khách Hàng";
                xtraTabControlNoiDung.TabPages.Add(tab);
                //nhan vao button hien thi tab
                xtraTabControlNoiDung.SelectedTabPage = tab;

                khachHang.TopLevel = false;
                khachHang.Parent = tab;
                //  Form.MdiParent = this;
                khachHang.Show();

                khachHang.Dock = DockStyle.Fill;
            }
        }

        private void barButtonItemNhaCungCap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool falg = false;
            for (int i = 0; i < xtraTabControlNoiDung.TabPages.Count; i++)
            {
                if (xtraTabControlNoiDung.TabPages[i].Name == "xtraTabPageNhaCungCap")
                {
                    falg = true;
                    xtraTabControlNoiDung.SelectedTabPage = xtraTabControlNoiDung.TabPages[i];
                    break;
                }
            }
            if (falg == false)
            {

                FormNhaCungCap nhaCungCap = new FormNhaCungCap(vtcn);
                //tao tabpase s do chen vo tabcontrol
                XtraTabPage tab = new XtraTabPage();
                tab.Name = "xtraTabPageNhaCungCap";
                tab.Text = "Nhà Cung Cấp";
                xtraTabControlNoiDung.TabPages.Add(tab);
                //nhan vao button hien thi tab
                xtraTabControlNoiDung.SelectedTabPage = tab;

                nhaCungCap.TopLevel = false;
                nhaCungCap.Parent = tab;
                //  Form.MdiParent = this;
                nhaCungCap.Show();

                nhaCungCap.Dock = DockStyle.Fill;
            }
        }

        private void barButtonItemKhoHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool falg = false;
            for (int i = 0; i < xtraTabControlNoiDung.TabPages.Count; i++)
            {
                if (xtraTabControlNoiDung.TabPages[i].Name == "xtraTabPageKhoHang")
                {
                    falg = true;
                    xtraTabControlNoiDung.SelectedTabPage = xtraTabControlNoiDung.TabPages[i];
                    break;
                }
            }
            if (falg == false)
            {
                FormKhoHang khoHang = new FormKhoHang(vtcn);
                //tao tabpase s do chen vo tabcontrol
                XtraTabPage tab = new XtraTabPage();
                tab.Name = "xtraTabPageKhoHang";
                tab.Text = "Kho Hàng";
                xtraTabControlNoiDung.TabPages.Add(tab);
                //nhan vao button hien thi tab
                xtraTabControlNoiDung.SelectedTabPage = tab;

                khoHang.TopLevel = false;
                khoHang.Parent = tab;
                //  Form.MdiParent = this;
                khoHang.Show();

                khoHang.Dock = DockStyle.Fill;
            }
        }

        private void barButtonItemDonViTinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool falg = false;
            for (int i = 0; i < xtraTabControlNoiDung.TabPages.Count; i++)
            {
                if (xtraTabControlNoiDung.TabPages[i].Name == "xtraTabPageDonViTinh")
                {
                    falg = true;
                    xtraTabControlNoiDung.SelectedTabPage = xtraTabControlNoiDung.TabPages[i];
                    break;
                }
            }
            if (falg == false)
            {
                FormDonViTinh donvitinh = new FormDonViTinh(vtcn);
                //tao tabpase s do chen vo tabcontrol
                XtraTabPage tab = new XtraTabPage();
                tab.Name = "xtraTabPageDonViTinh";
                tab.Text = "Đơn Vị Tính";
                xtraTabControlNoiDung.TabPages.Add(tab);
                //nhan vao button hien thi tab
                xtraTabControlNoiDung.SelectedTabPage = tab;

                donvitinh.TopLevel = false;
                donvitinh.Parent = tab;
                //  Form.MdiParent = this;
                donvitinh.Show();

                donvitinh.Dock = DockStyle.Fill;
            }
        }

        private void barButtonItemNhomHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool falg = false;
            for (int i = 0; i < xtraTabControlNoiDung.TabPages.Count; i++)
            {
                if (xtraTabControlNoiDung.TabPages[i].Name == "xtraTabPageNhomHang")
                {
                    falg = true;
                    xtraTabControlNoiDung.SelectedTabPage = xtraTabControlNoiDung.TabPages[i];
                    break;
                }
            }
            if (falg == false)
            {
                FormNhomHang nhomHang = new FormNhomHang(vtcn);
                //tao tabpase s do chen vo tabcontrol
                XtraTabPage tab = new XtraTabPage();
                tab.Name = "xtraTabPageNhomHang";
                tab.Text = "Nhóm Hàng";
                xtraTabControlNoiDung.TabPages.Add(tab);
                //nhan vao button hien thi tab
                xtraTabControlNoiDung.SelectedTabPage = tab;

                nhomHang.TopLevel = false;
                nhomHang.Parent = tab;
                //  Form.MdiParent = this;
                nhomHang.Show();

                nhomHang.Dock = DockStyle.Fill;
            }
        }

        private void barButtonItemHangHoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //FormHangHoa hangHoa = new FormHangHoa(vtcn);
            ////tao tabpase s do chen vo tabcontrol
            //XtraTabPage tab = new XtraTabPage();
            //tab.Name = "xtraTabPageHangHoa";
            //tab.Text = "Hàng Hóa";
            //xtraTabControlNoiDung.TabPages.Add(tab);
            ////nhan vao button hien thi tab
            //xtraTabControlNoiDung.SelectedTabPage = tab;

            //hangHoa.TopLevel = false;
            //hangHoa.Parent = tab;
            ////  Form.MdiParent = this;
            //hangHoa.Show();

            //hangHoa.Dock = DockStyle.Fill;
        }

        private void barButtonItemTyGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool falg = false;
            for (int i = 0; i < xtraTabControlNoiDung.TabPages.Count; i++)
            {
                if (xtraTabControlNoiDung.TabPages[i].Name == "xtraTabPageTyGia")
                {
                    falg = true;
                    xtraTabControlNoiDung.SelectedTabPage = xtraTabControlNoiDung.TabPages[i];
                    break;
                }
            }
            if (falg == false)
            {
                FormTyGia tygia = new FormTyGia(vtcn);
                //tao tabpase s do chen vo tabcontrol
                XtraTabPage tab = new XtraTabPage();
                tab.Name = "xtraTabPageTyGia";
                tab.Text = "Tỷ Giá";
                xtraTabControlNoiDung.TabPages.Add(tab);
                //nhan vao button hien thi tab
                xtraTabControlNoiDung.SelectedTabPage = tab;

                tygia.TopLevel = false;
                tygia.Parent = tab;
                //  Form.MdiParent = this;
                tygia.Show();

                tygia.Dock = DockStyle.Fill;
            }
        }
        private void barButtonItemBoPhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool falg = false;
            for (int i = 0; i < xtraTabControlNoiDung.TabPages.Count; i++)
            {
                if (xtraTabControlNoiDung.TabPages[i].Name == "xtraTabPageBoPhan")
                {
                    falg = true;
                    xtraTabControlNoiDung.SelectedTabPage = xtraTabControlNoiDung.TabPages[i];
                    break;
                }
            }
            if (falg == false)
            {
                FormBoPhan boPhan = new FormBoPhan(vtcn);
                //tao tabpase s do chen vo tabcontrol
                XtraTabPage tab = new XtraTabPage();
                tab.Name = "xtraTabPageBoPhan";
                tab.Text = "Bộ Phận";
                xtraTabControlNoiDung.TabPages.Add(tab);
                //nhan vao button hien thi tab
                xtraTabControlNoiDung.SelectedTabPage = tab;

                //dua form vao tab
                boPhan.TopLevel = false;
                boPhan.Parent = tab;
                //  Form.MdiParent = this;
                boPhan.Show();

                boPhan.Dock = DockStyle.Fill;
            }
        }
        private void barButtonItemNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool falg = false;
            for (int i = 0; i < xtraTabControlNoiDung.TabPages.Count; i++)
            {
                if (xtraTabControlNoiDung.TabPages[i].Name == "xtraTabPageNhanVien")
                {
                    falg = true;
                    xtraTabControlNoiDung.SelectedTabPage = xtraTabControlNoiDung.TabPages[i];
                    break;
                }
            }
            if (falg == false)
            {
                FormNhanVien nhanvien = new FormNhanVien(vtcn);
                //tao tabpase s do chen vo tabcontrol
                XtraTabPage tab = new XtraTabPage();
                tab.Name = "xtraTabPageNhanVien";
                tab.Text = "Nhân Viên";
                xtraTabControlNoiDung.TabPages.Add(tab);
                //nhan vao button hien thi tab
                xtraTabControlNoiDung.SelectedTabPage = tab;

                nhanvien.TopLevel = false;
                nhanvien.Parent = tab;
                //  Form.MdiParent = this;
                nhanvien.Show();

                nhanvien.Dock = DockStyle.Fill;
            }
        }
        private void barButtonItemMuaHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool falg = false;
            for (int i = 0; i < xtraTabControlNoiDung.TabPages.Count; i++)
            {
                if (xtraTabControlNoiDung.TabPages[i].Name == "xtraTabPageMuaHang")
                {
                    falg = true;
                    xtraTabControlNoiDung.SelectedTabPage = xtraTabControlNoiDung.TabPages[i];
                    break;
                }
            }
            if (falg == false)
            {
                FormMuaHang muaHang = new FormMuaHang();
                //tao tabpase s do chen vo tabcontrol
                XtraTabPage tab = new XtraTabPage();
                tab.Name = "xtraTabPageMuaHang";
                tab.Text = "Mua Hàng";
                xtraTabControlNoiDung.TabPages.Add(tab);
                //nhan vao button hien thi tab
                xtraTabControlNoiDung.SelectedTabPage = tab;

                muaHang.TopLevel = false;
                muaHang.Parent = tab;
                //  Form.MdiParent = this;
                muaHang.Show();

                muaHang.Dock = DockStyle.Fill;
            }
        }

        private void barButtonItemBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool falg = false;
            for (int i = 0; i < xtraTabControlNoiDung.TabPages.Count; i++)
            {
                if (xtraTabControlNoiDung.TabPages[i].Name == "xtraTabPageBanHang")
                {
                    falg = true;
                    xtraTabControlNoiDung.SelectedTabPage = xtraTabControlNoiDung.TabPages[i];
                    break;
                }
            }
            if (falg == false)
            {
                FormBanHang banHang = new FormBanHang();
                //tao tabpase s do chen vo tabcontrol
                XtraTabPage tab = new XtraTabPage();
                tab.Name = "xtraTabPageBanHang";
                tab.Text = "Bán Hàng";
                xtraTabControlNoiDung.TabPages.Add(tab);
                //nhan vao button hien thi tab
                xtraTabControlNoiDung.SelectedTabPage = tab;

                banHang.TopLevel = false;
                banHang.Parent = tab;
                //  Form.MdiParent = this;
                banHang.Show();

                banHang.Dock = DockStyle.Fill;
            }
        }

        private void barButtonItemTonKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool falg = false;
            for (int i = 0; i < xtraTabControlNoiDung.TabPages.Count; i++)
            {
                if (xtraTabControlNoiDung.TabPages[i].Name == "xtraTabPageTonKho")
                {
                    falg = true;
                    xtraTabControlNoiDung.SelectedTabPage = xtraTabControlNoiDung.TabPages[i];
                    break;
                }
            }
            if (falg == false)
            {
                FormTonKho tonkho = new FormTonKho();
                //tao tabpase s do chen vo tabcontrol
                XtraTabPage tab = new XtraTabPage();
                tab.Name = "xtraTabPageTonKho";
                tab.Text = "Tồn Kho";
                xtraTabControlNoiDung.TabPages.Add(tab);
                //nhan vao button hien thi tab
                xtraTabControlNoiDung.SelectedTabPage = tab;

                tonkho.TopLevel = false;
                tonkho.Parent = tab;
                //  Form.MdiParent = this;
                tonkho.Show();

                tonkho.Dock = DockStyle.Fill;
            }
        }

        private void barButtonItemChuyenKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool falg = false;
            for (int i = 0; i < xtraTabControlNoiDung.TabPages.Count; i++)
            {
                if (xtraTabControlNoiDung.TabPages[i].Name == "xtraTabPageChuyenKho")
                {
                    falg = true;
                    xtraTabControlNoiDung.SelectedTabPage = xtraTabControlNoiDung.TabPages[i];
                    break;
                }
            }
            if (falg == false)
            {
                FormTonKho chuyenKho = new FormTonKho();
                //tao tabpase s do chen vo tabcontrol
                XtraTabPage tab = new XtraTabPage();
                tab.Name = "xtraTabPageChuyenKho";
                tab.Text = "Chuyển Kho";
                xtraTabControlNoiDung.TabPages.Add(tab);
                //nhan vao button hien thi tab
                xtraTabControlNoiDung.SelectedTabPage = tab;

                chuyenKho.TopLevel = false;
                chuyenKho.Parent = tab;
                //  Form.MdiParent = this;
                chuyenKho.Show();

                chuyenKho.Dock = DockStyle.Fill;
            }
        }

        private void barButtonItemThuTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItemTraTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItemBaoCaoKhoHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItemBaoCaoBanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItemDangKy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItemNhatKyHeThong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        //link https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-add-and-remove-tabs-with-the-windows-forms-tabcontrol
        private void xtraTabControlNoiDung_CloseButtonClick(object sender, EventArgs e)
        {
            xtraTabControlNoiDung.TabPages.Remove(xtraTabControlNoiDung.SelectedTabPage);
        }

    }
}
