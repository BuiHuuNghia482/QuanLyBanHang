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
    public partial class FormKhoHangSua : Form
    {
        List<KhoHang> kh = new List<KhoHang>();
        List<KhuVuc> kv = new List<KhuVuc>();
        public FormKhoHangSua()
        {
            InitializeComponent();
        }
        public FormKhoHangSua(List<KhoHang> khohang,List<KhuVuc> khuvuc)
        {
            InitializeComponent();
            kh = khohang;
            kv = khuvuc;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string ma = comboBoxMaKho.Text;
            string ten = textBoxTenKho.Text;
            string makhuvuc = comboBoxMaKhuVuc.Text;

            if (ma != "" && ten != "" && makhuvuc != "")
            {
                bool Sua = XL_KhoHang.SuaKhoHang(ma, ten, makhuvuc);
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

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKhoHangSua_Load(object sender, EventArgs e)
        {
            comboBoxMaKho.DataSource = kh;
            comboBoxMaKho.DisplayMember = "MaKho";

            comboBoxMaKhuVuc.DataSource = kv;
            comboBoxMaKhuVuc.DisplayMember = "MaKhuVuc";
        }

        private void comboBoxMaKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < kh.Count; i++)
            {
                if (comboBoxMaKho.Text == kh[i].MaKho)
                {
                    comboBoxMaKhuVuc.Text = kh[i].MaKhuVuc;
                    textBoxTenKho.Text = kh[i].TenKho;
                    break;
                }
            }
        }
    }
}
