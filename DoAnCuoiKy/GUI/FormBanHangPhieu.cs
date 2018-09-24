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
    public partial class FormBanHangPhieu : Form
    {
        List<PhieuXuat> px = new List<PhieuXuat>();//tuong duong voi hoa don
        List<CTPhieuXuat> ctpx = new List<CTPhieuXuat>();//chi tiet phieu nhap
        List<SanPham> sp = new List<SanPham>();
        
        public FormBanHangPhieu()
        {
            InitializeComponent();
        }

        void loadPhieuXuat(DataTable bang)
        {
            if (px.Count != 0)
            {
                for (int i = 0; i < px.Count; i++)
                {
                    px.RemoveAt(i);
                }
                px = XL_PhieuXuat.ChuyenDoiDTOPhieuXuat(bang);
            }
        }
        private void FormBanHangPhieu_Load(object sender, EventArgs e)
        {
            //hinhthucthanhtoan
            gridLookUpEditHinhThucThanhToan.Properties.DataSource = XL_HinhThucThanhToan.LayDuLieuHinhThucThanhToan();
            gridLookUpEditHinhThucThanhToan.Properties.DisplayMember = "MaHinhThuc";
            //nhanvien
            gridLookUpEditNhanVien.Properties.DataSource = XL_NhanVien.LayDuLieuNhanVien();
            gridLookUpEditNhanVien.Properties.DisplayMember = "MaNV";
            //dieu khoan
            gridLookUpEditDieuKhoanThanhToan.Properties.DataSource = XL_DieuKhoan.LayDuLieuDieuKhoan();
            gridLookUpEditDieuKhoanThanhToan.Properties.DisplayMember = "MaDieuKhoan";
            //khach hang
            gridLookUpEditMaKhachHang.Properties.DataSource = XL_KhachHang.LayDuLieuKhachHang();
            gridLookUpEditMaKhachHang.Properties.DisplayMember = "MaKhachHang";
            //datagrid sp
            MaSP.DataSource = XL_SanPham.LayDuLieuSanPham();
            MaSP.DisplayMember = "MaSP";
            sp = XL_SanPham.ChuyenDoiDTOSanPham(XL_SanPham.LayDuLieuSanPham());
            // ct phieu xuat
            ctpx = XL_CTPhieuXuat.ChuyenDoiDTOCTPhieuXuat(XL_CTPhieuXuat.LayCTPhieuXuat());
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            //load du lieu          
            loadPhieuXuat(XL_PhieuXuat.LayDuLieuPhieuXuat());
            //co hieu
            int cohieu = 1;
            //phieu nhap
            string maphieuxuat = textBoxMaPhieuXuat.Text;
            string ngayxuat = dateTimePickerNgayXuat.Value.ToString();
            string manhanvien = gridLookUpEditNhanVien.Text;
            string khachang = gridLookUpEditMaKhachHang.Text;
            string dieukhoan = gridLookUpEditDieuKhoanThanhToan.Text;
            string hinhthucthanhtoan = gridLookUpEditHinhThucThanhToan.Text;
            string hanthanhtoan = dateTimePickerHanThanhToan.Value.ToString();
            string tientratruoc = textBoxTienTraTruoc.Text;
            string ngaygiao = dateTimePickerNgayGiao.Value.ToString();
            //tien
            double TongTien = 0;
            int soluong;
            float gia;
            for (int i = 0; i < dataGridViewCTPhieuXuat.Rows.Count; i++)
            {
                //object m = dataGridViewCTPhieuXuat["SoLuong", i].Value;
                //object n = dataGridViewCTPhieuXuat["GiaLucNhap", i].Value;
                object n = dataGridViewCTPhieuXuat.Rows[i].Cells["GiaLucNhap"].Value;
                object m = dataGridViewCTPhieuXuat.Rows[i].Cells["SoLuong"].Value;
                if (m != null && n != null)
                {
                    soluong = int.Parse(m.ToString());
                    gia = float.Parse(n.ToString());
                    double thue = (soluong * gia) * 0.1;
                    TongTien += ((soluong * gia) + thue);
                }
            }
            textBoxTongTien.Text = TongTien.ToString();
            //xet ma px
            for (int i = 0; i < px.Count; i++)
            {
                if (maphieuxuat == px[i].MaPhieuXuat)
                {
                    cohieu = 0;
                    break;
                }

            }

            //phieunhap
            if (maphieuxuat != "" && cohieu == 1 && ngayxuat != "" && hanthanhtoan != "" && manhanvien != "" && ngaygiao!=""&&TongTien!=0
                && khachang != "" && dieukhoan != "" && hinhthucthanhtoan != "" && tientratruoc != "" && dataGridViewCTPhieuXuat.Rows.Count - 1 != 0)
            {
                bool ThemPhieuXuat = XL_PhieuXuat.ThemPhieuXuat(maphieuxuat, ngayxuat, manhanvien, khachang, hinhthucthanhtoan, dieukhoan, TongTien, hanthanhtoan, tientratruoc, ngaygiao);
                if (ThemPhieuXuat == true)
                {
                    List<bool> ThemCTPhieuXuat = new List<bool>();
                    int lengt = dataGridViewCTPhieuXuat.Rows.Count;
                    //ct phieu nhap
                    int sl = ctpx.Count;
                    for (int i = 0; i < lengt; i++)
                    {
                        //
                        object m = dataGridViewCTPhieuXuat.Rows[i].Cells["MaSP"].Value;
                        object n = dataGridViewCTPhieuXuat.Rows[i].Cells["GiaLucNhap"].Value;
                        object o = dataGridViewCTPhieuXuat.Rows[i].Cells["SoLuong"].Value;
                        object makho = dataGridViewCTPhieuXuat.Rows[i].Cells["MaKho"].Value;
                        if (m != null && n != null && o != null)
                        {
                            CTPhieuXuat temp = new CTPhieuXuat();
                            //cap phat ma ct phieu xuat tu dong
                            sl += 1;
                            temp.MaChiTietXuat = string.Format("CTPX" + sl.ToString());

                            temp.MaPhieuXuat = maphieuxuat;
                            temp.MaSP = m.ToString();
                            temp.MaKho = makho.ToString();
                            temp.DonGiaSP = float.Parse(n.ToString());
                            temp.SoLuongMua = int.Parse(o.ToString());
                            float thue = 0.1f;
                            temp.Thue = thue;
                            //tien moi loai sp 
                            float soluongsp = int.Parse(o.ToString());
                            float giasp = float.Parse(n.ToString());
                            double tienthue = (soluongsp * giasp * 0.1);
                            double tien = ((soluongsp * giasp) + tienthue);
                            temp.ThanhTien = float.Parse(tien.ToString());

                            bool Them = XL_CTPhieuXuat.ThemCTPhieuXuat(temp.MaChiTietXuat, temp.MaPhieuXuat, temp.MaSP, temp.MaKho, temp.DonGiaSP, temp.ThanhTien, temp.Thue, temp.SoLuongMua);
                            bool Sua = XL_SanPham.CapNhatSanPham(temp.MaKho, temp.MaSP, temp.SoLuongMua);

                            //  ThemCTPhieuNhap.Add(Them);
                        }
                    }
                    //bien dem xem co luu dc tat ca k
                    int dem = 0;
                    for (int i = 0; i < ThemCTPhieuXuat.Count; i++)
                    {
                        if (ThemCTPhieuXuat[i] == true)
                        {
                            dem++;
                        }
                    }
                    if (dem == ThemCTPhieuXuat.Count)
                    {
                        MessageBox.Show("Thêm thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại!");
                        this.Close();
                    }
                }

            }

        }

        private void dataGridViewCTPhieuXuat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter
                && dataGridViewCTPhieuXuat.CurrentCell.OwningColumn
                .Name == "SoLuong")
            {
                //Tới vị trí ô số lượng
                dataGridViewCTPhieuXuat.CurrentCell =
                    dataGridViewCTPhieuXuat.Rows[dataGridViewCTPhieuXuat.CurrentCell.RowIndex]
                    .Cells["MaSP"];
            }

            //Khi nhập liệu xong
            else if (e.KeyCode == Keys.Enter && dataGridViewCTPhieuXuat.CurrentCell.OwningColumn.Name == "MaSP")
            {
                var o_hien_tai = dataGridViewCTPhieuXuat.CurrentCell;
                var o_phia_tren = dataGridViewCTPhieuXuat.Rows[o_hien_tai.RowIndex - 1].Cells[0];
                string masp = o_phia_tren.Value.ToString();
                //sosanh
                for (int i = 0; i < sp.Count; i++)
                {
                    if (dataGridViewCTPhieuXuat.Rows[o_hien_tai.RowIndex - 1].Cells["MaSP"].Value.ToString() == sp[i].MaSP)
                    {
                        dataGridViewCTPhieuXuat.Rows[o_hien_tai.RowIndex - 1]
                          .Height = 100;
                        //Thể hiện lên lưới
                        dataGridViewCTPhieuXuat.Rows[o_hien_tai.RowIndex - 1]
                               .Cells["TenSP"]
                               .Value = sp[i].TenSP;
                        string maspk = dataGridViewCTPhieuXuat.Rows[o_hien_tai.RowIndex - 1].Cells["MaSP"].Value.ToString();
                        MaKho.DataSource = XL_SanPham.LayDuLieuSanPhamTheoSP(maspk);
                        MaKho.DisplayMember = "MaKho";

                        dataGridViewCTPhieuXuat.Rows[o_hien_tai.RowIndex - 1]
                            .Cells["MaDonViTinh"]
                            .Value = sp[i].MaDonViTinh;

                        dataGridViewCTPhieuXuat.Rows[o_hien_tai.RowIndex - 1]
                           .Cells["GiaLucNhap"]
                           .Value = sp[i].GiaLucNhap;

                        dataGridViewCTPhieuXuat.Rows[o_hien_tai.RowIndex - 1]
                            .Cells["HinhAnh"]
                            .Value = Image.FromFile("C:/Users/Huu Nghia/Desktop/1560299_1560318_1560360_1560373_1560379/imgSP/" + sp[i].HinhAnh);
                    }
                }
                //Tới vị trí ô số lượng
                dataGridViewCTPhieuXuat.CurrentCell =
                    dataGridViewCTPhieuXuat.Rows[o_hien_tai.RowIndex - 1]
                    .Cells["MaKho"];
            }
            //Khi nhập liệu xong
            else if (e.KeyCode == Keys.Enter && dataGridViewCTPhieuXuat.CurrentCell.OwningColumn.Name == "MaKho")
            {
                var o_hien_tai = dataGridViewCTPhieuXuat.CurrentCell;
                var o_phia_tren = dataGridViewCTPhieuXuat.Rows[o_hien_tai.RowIndex - 1].Cells[0];
                //Tới vị trí ô số lượng
                dataGridViewCTPhieuXuat.CurrentCell =
                    dataGridViewCTPhieuXuat.Rows[o_hien_tai.RowIndex - 1]
                    .Cells["SoLuong"];
            }

        }

        private void textBoxTienTraTruoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
