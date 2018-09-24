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
    public partial class FormKhachHangThem : Form
    {
        List<KhachHang> kh = new List<KhachHang>();
        List<KhuVuc> kv = new List<KhuVuc>();
        public FormKhachHangThem()
        {
            InitializeComponent();
        }
        public FormKhachHangThem(List<KhachHang> khachHang, List<KhuVuc> khuVuc)
        {
            InitializeComponent();
            kh = khachHang;
            kv = khuVuc;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string ma = textBoxMaKhachHang.Text;
            string ten = textBoxTenKhachHang.Text;
            string diachi = textBoxDiaChi.Text;
            string dienthoai = textBoxDienThoai.Text;
            string makhuvuc = comboBoxMaKhuVuc.Text;
            //co hieu
            int k = 0;
            //xu ly
            for(int i = 0; i < kh.Count; i++)
            {
                if (ma == kh[i].MaKhachHang)
                {
                    MessageBox.Show("Mã khách hàng bạn nhập trùng xin nhập mã khác !");
                    k = 1;
                    break;
                }
            }
            if (ten != "" && k == 0 && diachi != "" && dienthoai != "" && ma != "" && makhuvuc != "")
            {
                bool them = XL_KhachHang.ThemKhachHang(ma, ten, diachi, dienthoai, makhuvuc);
                if (them)
                {
                    MessageBox.Show("Thêm khách hàng thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm khách hàng thất bại !");
                    this.Close();
                }
            }
        }

        private void FormKhachHangThem_Load(object sender, EventArgs e)
        {
            comboBoxMaKhuVuc.DataSource = kv;
            comboBoxMaKhuVuc.DisplayMember = "MaKhuVuc";
        }
        //chi cho nhap so vao sdt
        private void textBoxDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
