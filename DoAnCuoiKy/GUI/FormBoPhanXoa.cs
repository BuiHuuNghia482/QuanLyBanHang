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
    public partial class FormBoPhanXoa : Form
    {
        public List<BoPhan> bp = new List<BoPhan>();
        public FormBoPhanXoa()
        {
            InitializeComponent();
        }
        public FormBoPhanXoa(List<BoPhan> bophan)
        {
            InitializeComponent();
            bp = bophan;
        }

        private void FormBoPhanXoa_Load(object sender, EventArgs e)
        {
            comboBoxBP.DataSource = bp;
            comboBoxBP.DisplayMember = "MaBP";
            // 
            for (int i = 0; i < bp.Count; i++)
            {
                if (bp[i].MaBP == comboBoxBP.Text)
                {
                    textBoxTenBP.Text = bp[i].TenBP;
                    return;
                }
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxBP_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < bp.Count; i++)
            {
                if (bp[i].MaBP == comboBoxBP.Text)
                {
                    textBoxTenBP.Text = bp[i].TenBP;
                    return;
                }
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string ma = comboBoxBP.Text;
            if (ma != "")
            {
                bool Xoa = XL_BoPhan.XoaBoPhan(ma);
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

    }
}
