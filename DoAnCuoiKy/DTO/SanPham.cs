using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DTO
{
    public class SanPham
    {
        public string ID { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MaDonViTinh { get; set; }
        public string XuatXu { get; set; }
        public int SoLuongTon { get; set; }
        public string MaKho { get; set; }
        public string MaNhaCungCap { get; set; }
        public string MaNhomHang { get; set; }
        public double GiaLucNhap { get; set; }
        public string HinhAnh { get; set; }
    }
}
