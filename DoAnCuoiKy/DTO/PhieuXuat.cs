using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DTO
{
    public class PhieuXuat
    {
        public string MaPhieuXuat { get; set; }
        public DateTime NgayXuat { get; set; }
        public string MaNV { get; set; }
        public string MaKho { get; set; }
        public string MaKhachHang { get; set; }
        public string MaHinhThucThanhToan { get; set; }
        public string MaDKThanhToan { get; set; }
        public float TongTienThanhToan { get; set; }
        public DateTime HanThanhToan { get; set; }
        public float TienTraTruoc { get; set; }
        public DateTime NgayGiao { get; set; }
    }
}
