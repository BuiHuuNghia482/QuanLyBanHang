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
    public partial class FormNhaCungCapSua : Form
    {
        List<NhaCungCap> ncc = new List<NhaCungCap>();
        List<KhuVuc> kv = new List<KhuVuc>();
        public FormNhaCungCapSua()
        {
            InitializeComponent();
        }
        public FormNhaCungCapSua(List<NhaCungCap> nhacungcap, List<KhuVuc> khuvuc)
        {
            InitializeComponent();
            ncc = nhacungcap;
            kv = khuvuc;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string ma = comboBoxMaNhaCungCap.Text;
            string ten = textBoxTenNhaCungCap.Text;
            string diachi = textBoxDiaChi.Text;
            string dienthoai = textBoxDienThoai.Text;
            string makhuvuc = comboBoxMaKhuVuc.Text;

            if (ten != "" && diachi != "" && dienthoai != "" && ma != "")
            {
                bool Sua = XL_NhaCungCap.SuaNhaCungCap(ma, ten, diachi, dienthoai, makhuvuc);
                if (Sua)
                {
                    MessageBox.Show("Cập nhật nhà cung cấp thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật nhà cung cấp thất bại !");
                    this.Close();
                }
            }
        }

        private void FormNhaCungCapSua_Load(object sender, EventArgs e)
        {
            comboBoxMaNhaCungCap.DataSource = ncc;
            comboBoxMaNhaCungCap.DisplayMember = "MaNhaCungCap";

            comboBoxMaKhuVuc.DataSource = kv;
            comboBoxMaKhuVuc.DisplayMember = "MaKhuVuc";
        }

        private void comboBoxMaNhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < ncc.Count; i++)
            {
                if (comboBoxMaNhaCungCap.Text == ncc[i].MaNhaCungCap)
                {
                    textBoxTenNhaCungCap.Text = ncc[i].TenNhaCungCap;
                    textBoxDiaChi.Text = ncc[i].DiaChi;
                    textBoxDienThoai.Text = ncc[i].DienThoai;
                    comboBoxMaKhuVuc.Text = ncc[i].MaKhuVuc;
                    break;
                }
            }
        }
    }
}
