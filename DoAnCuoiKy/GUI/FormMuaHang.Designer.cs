namespace DoAnCuoiKy.GUI
{
    partial class FormMuaHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMuaHang));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupNhapHang = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupBangKe = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemPhieuNhapHang = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemTheoHangHoa = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemTheoChungTu = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainer1.Size = new System.Drawing.Size(615, 390);
            this.splitContainer1.SplitterDistance = 131;
            this.splitContainer1.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroupNhapHang;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupNhapHang,
            this.navBarGroupBangKe});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemPhieuNhapHang,
            this.navBarItemTheoHangHoa,
            this.navBarItemTheoChungTu});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.Size = new System.Drawing.Size(131, 390);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroupNhapHang
            // 
            this.navBarGroupNhapHang.Caption = "Nhập Hàng";
            this.navBarGroupNhapHang.Expanded = true;
            this.navBarGroupNhapHang.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroupNhapHang.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemPhieuNhapHang)});
            this.navBarGroupNhapHang.Name = "navBarGroupNhapHang";
            // 
            // navBarGroupBangKe
            // 
            this.navBarGroupBangKe.Caption = "Bảng Kê";
            this.navBarGroupBangKe.Expanded = true;
            this.navBarGroupBangKe.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroupBangKe.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemTheoHangHoa),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemTheoChungTu)});
            this.navBarGroupBangKe.Name = "navBarGroupBangKe";
            // 
            // navBarItemPhieuNhapHang
            // 
            this.navBarItemPhieuNhapHang.Caption = "Phiếu Nhập Hàng";
            this.navBarItemPhieuNhapHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemPhieuNhapHang.ImageOptions.LargeImage")));
            this.navBarItemPhieuNhapHang.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemPhieuNhapHang.ImageOptions.SmallImage")));
            this.navBarItemPhieuNhapHang.Name = "navBarItemPhieuNhapHang";
            this.navBarItemPhieuNhapHang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemPhieuNhapHang_LinkClicked);
            // 
            // navBarItemTheoHangHoa
            // 
            this.navBarItemTheoHangHoa.Caption = "Theo Hàng Hóa";
            this.navBarItemTheoHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemTheoHangHoa.ImageOptions.LargeImage")));
            this.navBarItemTheoHangHoa.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemTheoHangHoa.ImageOptions.SmallImage")));
            this.navBarItemTheoHangHoa.Name = "navBarItemTheoHangHoa";
            // 
            // navBarItemTheoChungTu
            // 
            this.navBarItemTheoChungTu.Caption = "Theo Chứng Từ";
            this.navBarItemTheoChungTu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemTheoChungTu.ImageOptions.LargeImage")));
            this.navBarItemTheoChungTu.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemTheoChungTu.ImageOptions.SmallImage")));
            this.navBarItemTheoChungTu.Name = "navBarItemTheoChungTu";
            // 
            // FormMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(615, 390);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMuaHang";
            this.Text = "FormMuaHang";
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupNhapHang;
        private DevExpress.XtraNavBar.NavBarItem navBarItemPhieuNhapHang;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupBangKe;
        private DevExpress.XtraNavBar.NavBarItem navBarItemTheoHangHoa;
        private DevExpress.XtraNavBar.NavBarItem navBarItemTheoChungTu;
    }
}