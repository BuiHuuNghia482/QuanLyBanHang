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
    public partial class FormKhoHangThem : Form
    {
        List<KhoHang> kh = new List<KhoHang>();
        List<KhuVuc> kv = new List<KhuVuc>();
        public FormKhoHangThem()
        {
            InitializeComponent();
        }
        public FormKhoHangThem(List<KhoHang> khoHang,List<KhuVuc> khuVuc)
        {
            InitializeComponent();
            kh = khoHang;
            kv = khuVuc;
        }

        private void FormKhoHangThem_Load(object sender, EventArgs e)
        {
            comboBoxMaKhuVuc.DataSource = kv;
            comboBoxMaKhuVuc.DisplayMember = "MaKhuVuc";
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string ma = textBoxMaKho.Text;
            string ten = textBoxTenKho.Text;
            string makhuvuc = comboBoxMaKhuVuc.Text;
            //co hieu
            int k = 0;
            //xu ly
            for (int i = 0; i < kh.Count; i++)
            {
                if (ma == kh[i].MaKho)
                {
                    MessageBox.Show("Mã Kho bạn nhập trùng xin nhập mã khác !");
                    k = 1;
                    break;
                }
            }
            if (ten != "" && k == 0 && ma != "" && makhuvuc != "")
            {
                bool them = XL_KhoHang.ThemKhoHang(ma, ten, makhuvuc);
                if (them)
                {
                    MessageBox.Show("Thêm kho hàng thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm kho hàng thất bại !");
                    this.Close();
                }
            }
        }

    }
}
