using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DTO
{
    public class PhieuNhap
    {
        public string MaPhieuNhap { get; set; }
        public DateTime NgayNhap { get; set; }
        public string MaNV { get; set; }
        public string MaKho { get; set; }
        public string MaNhaCungCap { get; set; }
        public string MaDKThanhToan { get; set; }
        public string MaHinhThucThanhToan { get; set; }
        public DateTime HanThanhToan { get; set; }
        public float TienTraTruoc { get; set; }
    }
}
