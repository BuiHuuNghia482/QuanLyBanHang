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
    public partial class FormKhuVucThem : Form
    {
        public List<KhuVuc> kv = new List<KhuVuc>();
        public FormKhuVucThem()
        {
            InitializeComponent();
        }
        public FormKhuVucThem(List<KhuVuc> khuVuc)
        {
            InitializeComponent();
            kv = khuVuc;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonThem_Click(object sender, EventArgs e)
        {
            //co hieu
            bool cohieu = true;

            string ma = textBoxMaKhuVuc.Text;
            string ten = textBoxTenKhuVuc.Text;
            //xu ly
            if (ma != "")
            {
                for (int i = 0; i < kv.Count; i++)
                {
                    if (ma == kv[i].MaKhuVuc)
                    {
                        labelThongBao.Text = "Mã nhập không được trùng với mã khác! ";
                        cohieu = false;
                        break;
                    }
                }
            }
            if (ma != "" && ten != "" && cohieu == true)
            {
                bool Them = XL_KhuVuc.ThemKhuVuc(ma, ten);
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

        private void textBoxMaKhuVuc_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMaKhuVuc.Text == "")
            {
                labelThongBao.Text = "";
            }

        }

        private void textBoxMaKhuVuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonThem.PerformClick();
            }
        }

        private void textBoxTenKhuVuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonThem.PerformClick();
            }
        }
    }
}
