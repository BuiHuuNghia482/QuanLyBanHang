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
    public partial class FormKhuVucXoa : Form
    {
        public List<KhuVuc> kv = new List<KhuVuc>();
        public FormKhuVucXoa()
        {
            InitializeComponent();
        }
        public FormKhuVucXoa(List<KhuVuc> khuvuc)
        {
            InitializeComponent();
            kv = khuvuc;
        }

        private void FormKhuVucXoa_Load(object sender, EventArgs e)
        {
            comboBoxMaKhuVuc.DataSource = kv;
            comboBoxMaKhuVuc.DisplayMember = "MaKhuVuc";
            // 
            for (int i = 0; i < kv.Count; i++)
            {
                if (kv[i].MaKhuVuc == comboBoxMaKhuVuc.Text)
                {
                    textBoxTenKhuVuc.Text = kv[i].TenKhuVuc;
                    return;
                }
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string ma = comboBoxMaKhuVuc.Text;
            bool Xoa = XL_KhuVuc.XoaKhuVuc(ma);
            if (ma != "")
            {
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

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxMaKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < kv.Count; i++)
            {
                if (kv[i].MaKhuVuc == comboBoxMaKhuVuc.Text)
                {
                    textBoxTenKhuVuc.Text = kv[i].TenKhuVuc;
                    return;
                }
            }
        }
    }
}
