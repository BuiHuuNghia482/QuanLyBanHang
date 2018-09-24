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
    public partial class FormBoPhanThem : Form
    {
        public List<BoPhan> bp = new List<BoPhan>();
        public FormBoPhanThem()
        {
            InitializeComponent();
        }
        public FormBoPhanThem(List<BoPhan> bophan)
        {
            InitializeComponent();
            bp = bophan;
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            //co hieu
            bool cohieu = true;
            string ma = textBoxMaBP.Text;
            string ten = textBoxTenBP.Text;
            //xu ly
            if (ma != "")
            {
                for (int i = 0; i < bp.Count; i++)
                {
                    if (ma == bp[i].MaBP)
                    {
                        labelThongBao.Text = "Mã nhập không được trùng với mã khác! ";
                        cohieu = false;
                        break;
                    }
                }
            }
            if (ma != "" && ten != "" && cohieu == true)
            {
                bool Them = XL_BoPhan.ThemBoPhan(ma, ten);
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

        private void textBoxMaBP_TextChanged(object sender, EventArgs e)
        {
            if (textBoxMaBP.Text == "")
            {
                labelThongBao.Text = "";
            }
        }
    }
}
