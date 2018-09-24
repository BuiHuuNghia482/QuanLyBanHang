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
    public partial class FormKhachHangXoa : Form
    {
        List<KhachHang> kh = new List<KhachHang>();
        public FormKhachHangXoa()
        {
            InitializeComponent();
        }
        public FormKhachHangXoa(List<KhachHang> khachHang)
        {
            InitializeComponent();
            kh = khachHang;
        }

        private void FormKhachHangXoa_Load(object sender, EventArgs e)
        {
            comboBoxMaKhachHang.DataSource = kh;
            comboBoxMaKhachHang.DisplayMember = "MaKhachHang";
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string ma = comboBoxMaKhachHang.Text;
            if (ma != "")
            {
                bool Xoa = XL_KhachHang.XoaKhachHang(ma);
                if (Xoa)
                {
                    MessageBox.Show("Xóa thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại !");
                    this.Close();
                }
            }
        }

        private void comboBoxMaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < kh.Count; i++)
            {
                if (comboBoxMaKhachHang.Text == kh[i].MaKhachHang)
                {
                    textBoxMaKhuVuc.Text = kh[i].MaKhuVuc;
                    textBoxTenKhachHang.Text = kh[i].TenKhachHang;
                    textBoxDiaChi.Text = kh[i].DiaChi;
                    textBoxDienThoai.Text = kh[i].DienThoai;
                    break;
                }
            }
        }
    }
}
