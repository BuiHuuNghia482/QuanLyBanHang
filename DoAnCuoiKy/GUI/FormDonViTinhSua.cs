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
    public partial class FormDonViTinhSua : Form
    {
        public List<DonViTinh> dvt = new List<DonViTinh>();
        public FormDonViTinhSua()
        {
            InitializeComponent();
        }
        public FormDonViTinhSua(List<DonViTinh> donvitinh)
        {
            InitializeComponent();
            dvt = donvitinh;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string ma = comboBoxMaDonViTinh.Text;
            string ten = textBoxTenDonViTinh.Text;
            if (ma != "" && ten != "")
            {
                bool Sua = XL_DonViTinh.SuaDonViTinh(ma, ten);
                if (Sua)
                {
                    MessageBox.Show("Cập nhật thành công !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại !");
                    this.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < dvt.Count; i++)
            {
                if(comboBoxMaDonViTinh.Text==dvt[i].MaDonViTinh)
                {
                    textBoxTenDonViTinh.Text = dvt[i].TenDonViTinh;
                    break;
                }
            }
        }

        private void FormDonViTinhSua_Load(object sender, EventArgs e)
        {
            comboBoxMaDonViTinh.DataSource = dvt;
            comboBoxMaDonViTinh.DisplayMember = "MaDonViTinh";
        }
    }
}
