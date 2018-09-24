using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCuoiKy.DTO
{
    public class VaiTroChucNang
    {
        public string id { get; set; }
        public string MaVaiTro { get; set; }
        public string MaChucNang { get; set; }
        public bool TruyXuat { get; set; }
        public bool Them { get; set; }
        public bool Xoa { get; set; }
        public bool Sua { get; set; }
        public string TenTrongHeThong { get; set; }
    }
}
