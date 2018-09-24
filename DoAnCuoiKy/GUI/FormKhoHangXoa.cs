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
    public partial class FormKhoHangXoa : Form
    {
        List<KhoHang> kh = new List<KhoHang>();
        public FormKhoHangXoa()
        {
            InitializeComponent();
        }
        public FormKhoHangXoa(List<KhoHang> khohang)
        {
            InitializeComponent();
            kh = khohang;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKhoHangXoa_Load(object sender, EventArgs e)
        {
            comboBoxMaKho.DataSource = kh;
            comboBoxMaKho.DisplayMember = "MaKho";
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string ma = comboBoxMaKho.Text;
            if (ma != "")
            {
                bool Xoa = XL_KhoHang.XoaKhoHang(ma);
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

        private void comboBoxMaKho_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < kh.Count; i++)
            {
                if (comboBoxMaKho.Text == kh[i].MaKho)
                {
                    textBoxMaKhuVuc.Text = kh[i].MaKhuVuc;
                    textBoxTenKho.Text = kh[i].TenKho;
                }
            }
        }
    }
}
