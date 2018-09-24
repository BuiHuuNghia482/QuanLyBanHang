namespace DoAnCuoiKy.GUI
{
    partial class FormBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBanHang));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupBanHang = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupBangKe = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemPhieuBanHang = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemTheoChungTu = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemTheoHangHoa = new DevExpress.XtraNavBar.NavBarItem();
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
            this.splitContainer1.Size = new System.Drawing.Size(625, 422);
            this.splitContainer1.SplitterDistance = 129;
            this.splitContainer1.TabIndex = 0;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroupBanHang;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupBanHang,
            this.navBarGroupBangKe});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItemPhieuBanHang,
            this.navBarItemTheoChungTu,
            this.navBarItemTheoHangHoa});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.Size = new System.Drawing.Size(129, 422);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroupBanHang
            // 
            this.navBarGroupBanHang.Caption = "Bán Hàng";
            this.navBarGroupBanHang.Expanded = true;
            this.navBarGroupBanHang.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroupBanHang.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemPhieuBanHang)});
            this.navBarGroupBanHang.Name = "navBarGroupBanHang";
            // 
            // navBarGroupBangKe
            // 
            this.navBarGroupBangKe.Caption = "Bảng Kê";
            this.navBarGroupBangKe.Expanded = true;
            this.navBarGroupBangKe.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsList;
            this.navBarGroupBangKe.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemTheoChungTu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemTheoHangHoa)});
            this.navBarGroupBangKe.Name = "navBarGroupBangKe";
            // 
            // navBarItemPhieuBanHang
            // 
            this.navBarItemPhieuBanHang.Caption = "Phiếu Bán Hàng";
            this.navBarItemPhieuBanHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemPhieuBanHang.ImageOptions.LargeImage")));
            this.navBarItemPhieuBanHang.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemPhieuBanHang.ImageOptions.SmallImage")));
            this.navBarItemPhieuBanHang.Name = "navBarItemPhieuBanHang";
            this.navBarItemPhieuBanHang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemPhieuBanHang_LinkClicked);
            // 
            // navBarItemTheoChungTu
            // 
            this.navBarItemTheoChungTu.Caption = "Theo Chứng Từ";
            this.navBarItemTheoChungTu.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemTheoChungTu.ImageOptions.LargeImage")));
            this.navBarItemTheoChungTu.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemTheoChungTu.ImageOptions.SmallImage")));
            this.navBarItemTheoChungTu.Name = "navBarItemTheoChungTu";
            // 
            // navBarItemTheoHangHoa
            // 
            this.navBarItemTheoHangHoa.Caption = "Theo Hàng Hóa";
            this.navBarItemTheoHangHoa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemTheoHangHoa.ImageOptions.LargeImage")));
            this.navBarItemTheoHangHoa.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemTheoHangHoa.ImageOptions.SmallImage")));
            this.navBarItemTheoHangHoa.Name = "navBarItemTheoHangHoa";
            // 
            // FormBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(625, 422);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBanHang";
            this.Text = "FormBanHang";
            this.Load += new System.EventHandler(this.FormBanHang_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupBanHang;
        private DevExpress.XtraNavBar.NavBarItem navBarItemPhieuBanHang;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupBangKe;
        private DevExpress.XtraNavBar.NavBarItem navBarItemTheoChungTu;
        private DevExpress.XtraNavBar.NavBarItem navBarItemTheoHangHoa;
    }
}