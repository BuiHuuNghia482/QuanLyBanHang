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
    public partial class FormNhaCungCapXoa : Form
    {
        List<NhaCungCap> ncc = new List<NhaCungCap>();
        public FormNhaCungCapXoa()
        {
            InitializeComponent();
        }
        public FormNhaCungCapXoa(List<NhaCungCap> nhacungcap)
        {
            InitializeComponent();
            ncc = nhacungcap;
        }

        private void FormNhaCungCapXoa_Load(object sender, EventArgs e)
        {
            comboBoxMaNhaCungCap.DataSource = ncc;
            comboBoxMaNhaCungCap.DisplayMember = "MaNhaCungCap";
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxMaNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ncc.Count; i++)
            {
                if (comboBoxMaNhaCungCap.Text == ncc[i].MaNhaCungCap)
                {      
                    textBoxTenNhaCungCap.Text = ncc[i].TenNhaCungCap;
                    textBoxDiaChi.Text = ncc[i].DiaChi;
                    textBoxDienThoai.Text = ncc[i].DienThoai;
                    textBoxMaKhuVuc.Text = ncc[i].MaKhuVuc;
                    break;
                }
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string ma = comboBoxMaNhaCungCap.Text;
            if (ma != "")
            {
                bool Xoa = XL_NhaCungCap.XoaNhaCungCap(ma);
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
    }
}
