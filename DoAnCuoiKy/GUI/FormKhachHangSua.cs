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
    public partial class FormKhachHangSua : Form
    {
        List<KhachHang> kh = new List<KhachHang>();
        List<KhuVuc> kv = new List<KhuVuc>();
        public FormKhachHangSua()
        {
            InitializeComponent();
        }
        public FormKhachHangSua(List<KhachHang> khachHang, List<KhuVuc> khuVuc)
        {
            InitializeComponent();
            kh = khachHang;
            kv = khuVuc;
        }

        private void FormKhachHangSua_Load(object sender, EventArgs e)
        {
            comboBoxMaKhachHang.DataSource = kh;
            comboBoxMaKhachHang.DisplayMember = "MaKhachHang";

            comboBoxMaKhuVuc.DataSource = kv;
            comboBoxMaKhuVuc.DisplayMember = "MaKhuVuc";
        }


        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxMaKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < kh.Count; i++)
            {
                if (comboBoxMaKhachHang.Text == kh[i].MaKhachHang)
                {
                    comboBoxMaKhuVuc.Text = kh[i].MaKhuVuc;
                    textBoxTenKhachHang.Text = kh[i].TenKhachHang;
                    textBoxDiaChi.Text = kh[i].DiaChi;
                    textBoxDienThoai.Text = kh[i].DienThoai;
                    break;
                }
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string ma = comboBoxMaKhachHang.Text;
            string ten = textBoxTenKhachHang.Text;
            string diachi = textBoxDiaChi.Text;
            string dienthoai = textBoxDienThoai.Text;
            string makhuvuc = comboBoxMaKhuVuc.Text;

            if (ten != "" && diachi != "" && dienthoai != "" && ma != "" && makhuvuc != "")
            {
                bool Sua = XL_KhachHang.SuaKhachHang(ma, ten, diachi, dienthoai, makhuvuc);
                if (Sua)
                {
                    MessageBox.Show("Cập nhật khách hàng thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật khách hàng thất bại !");
                    this.Close();
                }
            }
        }

        private void textBoxDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
