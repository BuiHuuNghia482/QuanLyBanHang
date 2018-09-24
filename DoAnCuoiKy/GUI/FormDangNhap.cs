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
   
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {      
            InitializeComponent();          
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            string TaiKhoan = textBoxTaiKhoan.Text;
            string MatKhau = textBoxMatKhau.Text;
            string MaVaiTro = XL_DangNhap.KiemTraDangNhap(TaiKhoan, MatKhau);
            if (MaVaiTro == "")
            {
                MessageBox.Show("Bạn Nhập Mật Khẩu Hoặc Tài Khoản Sai!!");
                this.Close();
            }
            else
            {
                //phan quyen
                //lay csdl vai tro chuc nang vao bang 
                DataTable bang = XL_VaiTroChucNang.KiemTraVaiTroChucNang(MaVaiTro);
                //chuyen bang thanh list
                List<VaiTroChucNang> vtcn = XL_VaiTroChucNang.ChuyenDoiDTOVaiTroChucNang(bang);

                //dung de thay doi mat khau
                //lay csdl tai khoan vao bang
                DataTable bangTaiKhoan = XL_TaiKhoan.KtraTaiKhoan(TaiKhoan);
                //chuyen bang thanh taikhoan
                TaiKhoan tk = XL_TaiKhoan.ChuyenDoiDTOTaiKhoan(bangTaiKhoan);

                //dung de hien thi thanh status
                //lay csdl vai tro vao bang
                DataTable bangVaiTro = XL_VaiTro.KiemTraVaiTro(MaVaiTro);
                //chuyen bang thanh taikhoan
                VaiTro vt = XL_VaiTro.ChuyenDoiDTOVaiTro(bangVaiTro);

                this.Hide();
                Form1 form1 = new Form1(vtcn, vt, tk);
                form1.ShowDialog();
                this.Close();
            }
        }


        private void buttonKetThuc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void textBoxMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonDangNhap.PerformClick();
            }
        }

        private void textBoxTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonDangNhap.PerformClick();
            }
        }
    }
}
