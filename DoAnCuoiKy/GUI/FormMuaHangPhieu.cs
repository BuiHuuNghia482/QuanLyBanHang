using DoAnCuoiKy.BUS;
using DoAnCuoiKy.DAO;
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
    public partial class FormMuaHangPhieu : Form
    {
        List<PhieuNhap> pn = new List<PhieuNhap>();//tuong duong voi hoa don
        List<CTPhieuNhap> ctpn = new List<CTPhieuNhap>();//chi tiet phieu nhap
        List<SanPham> sp = new List<SanPham>();
        public FormMuaHangPhieu()
        {
            InitializeComponent();
        }

        void loadPhieuNhap(DataTable bang)
        {
            if (pn.Count != 0)
            {
                for (int i = 0; i < pn.Count; i++)
                {
                    pn.RemoveAt(i);
                }
                pn = XL_PhieuNhap.ChuyenDoiDTOPhieuNhap(bang);
            }
        }
        private void FormMuaHangPhieu_Load(object sender, EventArgs e)
        {
            //hinhthucthanhtoan
            gridLookUpEditHinhThucThanhToan.Properties.DataSource = XL_HinhThucThanhToan.LayDuLieuHinhThucThanhToan();
            gridLookUpEditHinhThucThanhToan.Properties.DisplayMember = "MaHinhThuc";
            //nhanvien
            gridLookUpEditNhanVien.Properties.DataSource = XL_NhanVien.LayDuLieuNhanVien();
            gridLookUpEditNhanVien.Properties.DisplayMember = "MaNV";
            //kho
            gridLookUpEditKho.Properties.DataSource = XL_KhoHang.LayDuLieuKhoHang();
            gridLookUpEditKho.Properties.DisplayMember = "MaKho";
            //dieu khoan
            gridLookUpEditDieuKhoanThanhToan.Properties.DataSource = XL_DieuKhoan.LayDuLieuDieuKhoan();
            gridLookUpEditDieuKhoanThanhToan.Properties.DisplayMember = "MaDieuKhoan";
            //ncc
            gridLookUpEditNCC.Properties.DataSource = XL_NhaCungCap.LayDuLieuNhaCungCap();
            gridLookUpEditNCC.Properties.DisplayMember = "MaNhaCungCap";
            //datagridn sp
            MaSP.DataSource = XL_SanPham.LayDuLieuSanPham();
            MaSP.DisplayMember = "MaSP";
            sp = XL_SanPham.ChuyenDoiDTOSanPham(XL_SanPham.LayDuLieuSanPham());
            // ct phieu nhap
            ctpn = XL_CTPhieuNhap.ChuyenDoiDTOCTPhieuNhap(XL_CTPhieuNhap.LayCTPhieuNhap());
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            //load du lieu          
            loadPhieuNhap(XL_PhieuNhap.LayDuLieuPhieuNhap());
            //co hieu
            int cohieu = 1;
            //phieu nhap
            string maphieunhap = textBoxMaPhieuNhap.Text;
            string ngaynhap = dateTimePickerNgayNhap.Value.ToString();
            string hanthanhtoan = dateTimePickerHanThanhToan.Value.ToString();
            string manhanvien = gridLookUpEditNhanVien.Text;
            string kho = gridLookUpEditKho.Text;
            string manhacungcap = gridLookUpEditNCC.Text;
            string dieukhoan = gridLookUpEditDieuKhoanThanhToan.Text;
            string hinhthucthanhtoan = gridLookUpEditHinhThucThanhToan.Text;
            string tientratruoc = textBoxTienTraTruoc.Text;
            //tien
            double TongTien = 0;
            int soluong;
            float gia;
            for (int i = 0; i < dataGridViewCTPhieuNhap.Rows.Count; i++)
            {
                //object m = dataGridViewCTPhieuNhap["SoLuong", i].Value;
                //object n = dataGridViewCTPhieuNhap["GiaLucNhap", i].Value;
                object n = dataGridViewCTPhieuNhap.Rows[i].Cells["GiaLucNhap"].Value;
                object m = dataGridViewCTPhieuNhap.Rows[i].Cells["SoLuong"].Value;
                if (m != null && n != null)
                {
                    soluong = int.Parse(m.ToString());
                    gia = float.Parse(n.ToString());
                    double thue = (soluong * gia) * 0.1;
                    TongTien += ((soluong * gia) + thue);
                }
            }
            textBoxTongTien.Text = TongTien.ToString();
            //xet ma hoa don
            for (int i = 0; i < pn.Count; i++)
            {
                if (maphieunhap == pn[i].MaPhieuNhap)
                {
                    cohieu = 0;
                    break;
                }

            }
            
            //phieunhap
            if (maphieunhap != "" && cohieu == 1 && ngaynhap != "" && hanthanhtoan != "" && manhanvien != ""
                && kho != "" && manhacungcap != "" && dieukhoan != "" && hinhthucthanhtoan != "" && tientratruoc != "" && dataGridViewCTPhieuNhap.Rows.Count - 1 != 0)
            {
                bool ThemPhieuNhap = XL_PhieuNhap.ThemPhieuNhap(maphieunhap, ngaynhap, manhanvien, kho, manhacungcap, hinhthucthanhtoan, dieukhoan, TongTien, hanthanhtoan, tientratruoc);
                if (ThemPhieuNhap == true)
                {
                    List<bool> ThemCTPhieuNhap = new List<bool>();
                    int lengt = dataGridViewCTPhieuNhap.Rows.Count;
                    //ct phieu nhap
                    int sl = ctpn.Count;
                    for (int i = 0; i < lengt; i++)
                    {                        
                        //
                        object m=dataGridViewCTPhieuNhap.Rows[i].Cells["MaSP"].Value;
                        object n = dataGridViewCTPhieuNhap.Rows[i].Cells["GiaLucNhap"].Value;
                        object o = dataGridViewCTPhieuNhap.Rows[i].Cells["SoLuong"].Value;
                        if (m != null && n != null && o != null)
                        {
                            CTPhieuNhap temp = new CTPhieuNhap();
                            //cap phat ma ct phieu nhap tu dong
                            sl += 1;
                            temp.MaChiTietNhap = string.Format("CTPN" + sl.ToString());

                            temp.MaPhieuNhap = maphieunhap;
                            temp.MaSP = m.ToString();
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

                            bool Them = XL_CTPhieuNhap.ThemCTPhieuNhap(temp.MaChiTietNhap, temp.MaPhieuNhap, temp.MaSP, temp.DonGiaSP, temp.ThanhTien, temp.Thue, temp.SoLuongMua);
                            bool Sua = XL_CTPhieuNhap.CapNhatSanPham(kho, temp.MaSP, temp.SoLuongMua);

                            ThemCTPhieuNhap.Add(Them);
                        }
                    }
                    //bien dem xem co luu dc tat ca k
                    int dem = 0;
                    for (int i = 0; i < ThemCTPhieuNhap.Count; i++)
                    {
                        if (ThemCTPhieuNhap[i] == true)
                        {
                            dem++;
                        }
                    }
                    if (dem == ThemCTPhieuNhap.Count)
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

        private void dataGridViewCTPhieuNhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter
                && dataGridViewCTPhieuNhap.CurrentCell.OwningColumn
                .Name == "SoLuong")
            {
                //Tới vị trí ô số lượng
                dataGridViewCTPhieuNhap.CurrentCell =
                    dataGridViewCTPhieuNhap.Rows[dataGridViewCTPhieuNhap.CurrentCell.RowIndex]
                    .Cells["MaSP"];
            }
            //Khi nhập liệu xong
            else if (e.KeyCode == Keys.Enter && dataGridViewCTPhieuNhap.CurrentCell.OwningColumn.Name == "MaSP")
            {
                var o_hien_tai = dataGridViewCTPhieuNhap.CurrentCell;
                var o_phia_tren = dataGridViewCTPhieuNhap.Rows[o_hien_tai.RowIndex - 1].Cells[0];
                string masp = o_phia_tren.Value.ToString();
                //sosanh
                for (int i = 0; i < sp.Count; i++)
                {
                    if (dataGridViewCTPhieuNhap.Rows[o_hien_tai.RowIndex - 1].Cells["MaSP"].Value.ToString() == sp[i].MaSP)
                    {
                        dataGridViewCTPhieuNhap.Rows[o_hien_tai.RowIndex - 1]
                          .Height = 100;
                        //Thể hiện lên lưới
                        dataGridViewCTPhieuNhap.Rows[o_hien_tai.RowIndex - 1]
                               .Cells["TenSP"]
                               .Value = sp[i].TenSP;

                        dataGridViewCTPhieuNhap.Rows[o_hien_tai.RowIndex - 1]
                            .Cells["XuatXu"]
                            .Value = sp[i].XuatXu;

                        dataGridViewCTPhieuNhap.Rows[o_hien_tai.RowIndex - 1]
                            .Cells["MaDonViTinh"]
                            .Value = sp[i].MaDonViTinh;

                        dataGridViewCTPhieuNhap.Rows[o_hien_tai.RowIndex - 1]
                           .Cells["GiaLucNhap"]
                           .Value = sp[i].GiaLucNhap;

                        dataGridViewCTPhieuNhap.Rows[o_hien_tai.RowIndex - 1]
                            .Cells["HinhAnh"]
                            .Value = Image.FromFile("C:/Users/Huu Nghia/Desktop/1560299_1560318_1560360_1560373_1560379/imgSP/" + sp[i].HinhAnh);
                    }
                }
                //Tới vị trí ô số lượng
                dataGridViewCTPhieuNhap.CurrentCell =
                    dataGridViewCTPhieuNhap.Rows[o_hien_tai.RowIndex - 1]
                    .Cells["SoLuong"];

            }
        }


    }
}
