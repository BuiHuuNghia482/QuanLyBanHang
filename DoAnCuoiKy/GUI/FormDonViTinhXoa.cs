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
    public partial class FormDonViTinhXoa : Form
    {
        public List<DonViTinh> dvt = new List<DonViTinh>();
        public FormDonViTinhXoa()
        {
            InitializeComponent();
        }
        public FormDonViTinhXoa(List<DonViTinh> donvitinh)
        {
            InitializeComponent();
            dvt = donvitinh;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {

            string ma = comboBoxMaDonViTinh.Text;
            if (ma != "")
            {
                bool Xoa = XL_DonViTinh.XoaDonViTinh(ma);
                if (Xoa)
                {
                    MessageBox.Show("Xóa thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công !");
                    this.Close();
                }
            }
        }

        private void comboBoxMaDonViTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dvt.Count; i++)
            {
                if (dvt[i].MaDonViTinh == comboBoxMaDonViTinh.Text)
                {
                    textBoxTenDonViTinh.Text = dvt[i].TenDonViTinh;
                    return;
                }
            }
        }

        private void FormDonViTinhXoa_Load(object sender, EventArgs e)
        {
            comboBoxMaDonViTinh.DataSource = dvt;
            comboBoxMaDonViTinh.DisplayMember = "MaDonViTinh";
            // 
            for (int i = 0; i < dvt.Count; i++)
            {
                if (dvt[i].MaDonViTinh == comboBoxMaDonViTinh.Text)
                {
                    textBoxTenDonViTinh.Text = dvt[i].TenDonViTinh;
                    return;
                }
            }
        }
    }
}
