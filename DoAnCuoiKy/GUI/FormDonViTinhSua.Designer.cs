namespace DoAnCuoiKy.GUI
{
    partial class FormDonViTinhSua
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
            this.buttonThoat = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLoiKhuVuc = new System.Windows.Forms.Label();
            this.labelThongBao = new System.Windows.Forms.Label();
            this.textBoxTenDonViTinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxMaDonViTinh = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(214, 125);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 7;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Location = new System.Drawing.Point(121, 125);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(75, 23);
            this.buttonSua.TabIndex = 6;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.comboBoxMaDonViTinh);
            this.groupBox1.Controls.Add(this.labelLoiKhuVuc);
            this.groupBox1.Controls.Add(this.labelThongBao);
            this.groupBox1.Controls.Add(this.textBoxTenDonViTinh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 107);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // labelLoiKhuVuc
            // 
            this.labelLoiKhuVuc.AutoSize = true;
            this.labelLoiKhuVuc.Location = new System.Drawing.Point(2, 78);
            this.labelLoiKhuVuc.Name = "labelLoiKhuVuc";
            this.labelLoiKhuVuc.Size = new System.Drawing.Size(152, 13);
            this.labelLoiKhuVuc.TabIndex = 5;
            this.labelLoiKhuVuc.Text = "* Các ô không được để trống !";
            // 
            // labelThongBao
            // 
            this.labelThongBao.AutoSize = true;
            this.labelThongBao.Location = new System.Drawing.Point(78, 50);
            this.labelThongBao.Name = "labelThongBao";
            this.labelThongBao.Size = new System.Drawing.Size(0, 13);
            this.labelThongBao.TabIndex = 4;
            // 
            // textBoxTenDonViTinh
            // 
            this.textBoxTenDonViTinh.Location = new System.Drawing.Point(89, 55);
            this.textBoxTenDonViTinh.Name = "textBoxTenDonViTinh";
            this.textBoxTenDonViTinh.Size = new System.Drawing.Size(162, 20);
            this.textBoxTenDonViTinh.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đơn vị tính";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đơn vị tính";
            // 
            // comboBoxMaDonViTinh
            // 
            this.comboBoxMaDonViTinh.FormattingEnabled = true;
            this.comboBoxMaDonViTinh.Location = new System.Drawing.Point(90, 19);
            this.comboBoxMaDonViTinh.Name = "comboBoxMaDonViTinh";
            this.comboBoxMaDonViTinh.Size = new System.Drawing.Size(161, 21);
            this.comboBoxMaDonViTinh.TabIndex = 6;
            this.comboBoxMaDonViTinh.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // FormDonViTinhSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(296, 159);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDonViTinhSua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDonViTinhSua";
            this.Load += new System.EventHandler(this.FormDonViTinhSua_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelLoiKhuVuc;
        private System.Windows.Forms.Label labelThongBao;
        private System.Windows.Forms.TextBox textBoxTenDonViTinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxMaDonViTinh;
    }
}