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
    public partial class FormNhaCungCapThem : Form
    {
        List<NhaCungCap> ncc = new List<NhaCungCap>();
        List<KhuVuc> kv = new List<KhuVuc>();
        public FormNhaCungCapThem()
        {
            InitializeComponent();
        }
        public FormNhaCungCapThem(List<NhaCungCap> nhacungcap, List<KhuVuc> khuvuc)
        {
            InitializeComponent();
            ncc = nhacungcap;
            kv = khuvuc;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            string ma = textBoxMaNhaCungCap.Text;
            string ten = textBoxTenNhaCungCap.Text;
            string diachi = textBoxDiaChi.Text;
            string dienthoai = textBoxDienThoai.Text;
            string makhuvuc = comboBoxMaKhuVuc.Text;
            int k = 0;
            for (int i = 0; i < ncc.Count; i++)
            {
                if (ma == ncc[i].MaNhaCungCap)
                {
                    MessageBox.Show("Mã nhà cung cấp bạn nhập trùng !");
                    k = 1;
                    break;
                }
            }
            if (k == 0 && ten != "" && k == 0 && diachi != "" && dienthoai != "" && makhuvuc != "")
            {
                bool them = XL_NhaCungCap.ThemNhaCungCap(ma, ten, diachi, dienthoai, makhuvuc);
                if (them)
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm nhà cung cấp thất bại !");
                    this.Close();
                }
            }
        }

        private void FormNhaCungCapThem_Load(object sender, EventArgs e)
        {
            comboBoxMaKhuVuc.DataSource = kv;
            comboBoxMaKhuVuc.DisplayMember = "MaKhuVuc";
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