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
    public partial class FormKhuVucSua : Form
    {
        public List<KhuVuc> kv = new List<KhuVuc>();
        public FormKhuVucSua()
        {
            InitializeComponent();
        }
        public FormKhuVucSua(List<KhuVuc> khuvuc)
        {
            InitializeComponent();
            kv = khuvuc;
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string ma = comboBoxMaKhuVuc.Text;
            string ten = textBoxTenKhuVuc.Text;
            if (ma != "" && ten != "")
            {
                bool Sua = XL_KhuVuc.SuaKhuVuc(ma, ten);
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

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKhuVucSua_Load(object sender, EventArgs e)
        {
            comboBoxMaKhuVuc.DataSource = kv;
            comboBoxMaKhuVuc.DisplayMember = "MaKhuVuc";
        }

        private void comboBoxMaKhuVuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < kv.Count; i++)
            {
                if (comboBoxMaKhuVuc.Text == kv[i].MaKhuVuc)
                {
                    textBoxTenKhuVuc.Text = kv[i].TenKhuVuc;
                    break;
                }
            }
        }

        private void textBoxTenKhuVuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSua.PerformClick();
            }
        }

        private void comboBoxMaKhuVuc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSua.PerformClick();
            }
        }
    }
}
