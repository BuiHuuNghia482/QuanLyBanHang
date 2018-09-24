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
    public partial class FormBoPhanSua : Form
    {
        public List<BoPhan> bp = new List<BoPhan>();
        public FormBoPhanSua()
        {
            InitializeComponent();
        }
        public FormBoPhanSua(List<BoPhan> bophan)
        {
            InitializeComponent();
            bp = bophan;
        }

        private void FormBoPhanSua_Load(object sender, EventArgs e)
        {
            comboBoxMaBP.DataSource = bp;
            comboBoxMaBP.DisplayMember = "MaBP";
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            string ma = comboBoxMaBP.Text;
            string ten = textBoxTenBP.Text;
            if (ma != "" && ten != "")
            {
                bool Sua = XL_BoPhan.SuaBoPhan(ma, ten);
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

        private void comboBoxMaBP_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < bp.Count; i++)
            {
                if (comboBoxMaBP.Text == bp[i].MaBP)
                {
                    textBoxTenBP.Text = bp[i].TenBP;
                    break;
                }
            }
        }
    }
}
