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
    public partial class FormDoiMatKhau : Form
    {
        public TaiKhoan tk = new TaiKhoan();
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }
        public FormDoiMatKhau(TaiKhoan taiKhoan)
        {
            InitializeComponent();
            tk = taiKhoan;
        }
        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonXong_Click(object sender, EventArgs e)
        {
            //bien ktra doi mat khau thanh cong hay k
            bool ktra = false;
            //co hieu
            if (textBoxMatKhauCu.Text == tk.MatKhau)
            {
                if (textBoxMatKhauMoi.Text == textBoxMatKhauMoiNhapLai.Text)
                {
                    ktra = XL_DangNhap.DoiMatKhau(tk.TenTaiKhoan, textBoxMatKhauMoi.Text);
                }
                else
                {
                    MessageBox.Show("Bạn nhập mật khẩu hay lần không giống nhau!!");
                }
            }
            else
            {
                MessageBox.Show("Bạn nhập mật khẩu cũ sai");
            }
            if (ktra==true)
            {
                MessageBox.Show("Bạn Cập nhật mật khẩu thành công");
                this.Close();
            }
            else if (ktra == false)
            {
                MessageBox.Show("Bạn Cập nhật mật khẩu thất bại");
                this.Close();
            }
        }
        private void textBoxMatKhauMoiNhapLai_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonXong.PerformClick();
            }
        }
    }
}
