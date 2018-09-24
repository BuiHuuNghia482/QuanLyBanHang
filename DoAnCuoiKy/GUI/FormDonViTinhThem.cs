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
    public partial class FormDonViTinhThem : Form
    {
        public List<DonViTinh> dvt = new List<DonViTinh>();
        public FormDonViTinhThem()
        {
            InitializeComponent();
        }
        public FormDonViTinhThem(List<DonViTinh> donvitinh)
        {
            InitializeComponent();
            dvt = donvitinh;
        }

        private void FormDonViTinhThem_Load(object sender, EventArgs e)
        {

        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            //co hieu
            bool cohieu = true;
            string ma = textBoxMaDonViTinh.Text;
            string ten = textBoxTenDonViTinh.Text;
            //xu ly
            if (ma != "")
            {
                for (int i = 0; i < dvt.Count; i++)
                {
                    if (ma == dvt[i].MaDonViTinh)
                    {
                        cohieu = false;
                        break;
                    }
                }
            }
            if (ma != "" && ten != "" && cohieu == true)
            {
                bool Them = XL_DonViTinh.ThemDonViTinh(ma, ten);
                if (Them)
                {
                    MessageBox.Show("Thêm thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!");
                    this.Close();
                }

            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
