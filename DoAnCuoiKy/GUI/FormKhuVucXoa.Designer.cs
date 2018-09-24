namespace DoAnCuoiKy.GUI
{
    partial class FormKhuVucXoa
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
            this.buttonXoa = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxMaKhuVuc = new System.Windows.Forms.ComboBox();
            this.labelLoiKhuVuc = new System.Windows.Forms.Label();
            this.labelThongBao = new System.Windows.Forms.Label();
            this.textBoxTenKhuVuc = new System.Windows.Forms.TextBox();
            this.labelTenKhuVuc = new System.Windows.Forms.Label();
            this.labelMaKhuVuc = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(216, 140);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 7;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(122, 140);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 6;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.comboBoxMaKhuVuc);
            this.groupBox1.Controls.Add(this.labelLoiKhuVuc);
            this.groupBox1.Controls.Add(this.labelThongBao);
            this.groupBox1.Controls.Add(this.textBoxTenKhuVuc);
            this.groupBox1.Controls.Add(this.labelTenKhuVuc);
            this.groupBox1.Controls.Add(this.labelMaKhuVuc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // comboBoxMaKhuVuc
            // 
            this.comboBoxMaKhuVuc.FormattingEnabled = true;
            this.comboBoxMaKhuVuc.Location = new System.Drawing.Point(79, 22);
            this.comboBoxMaKhuVuc.Name = "comboBoxMaKhuVuc";
            this.comboBoxMaKhuVuc.Size = new System.Drawing.Size(190, 21);
            this.comboBoxMaKhuVuc.TabIndex = 6;
            this.comboBoxMaKhuVuc.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaKhuVuc_SelectedIndexChanged);
            // 
            // labelLoiKhuVuc
            // 
            this.labelLoiKhuVuc.AutoSize = true;
            this.labelLoiKhuVuc.Location = new System.Drawing.Point(7, 106);
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
            // textBoxTenKhuVuc
            // 
            this.textBoxTenKhuVuc.Enabled = false;
            this.textBoxTenKhuVuc.Location = new System.Drawing.Point(78, 73);
            this.textBoxTenKhuVuc.Name = "textBoxTenKhuVuc";
            this.textBoxTenKhuVuc.Size = new System.Drawing.Size(193, 20);
            this.textBoxTenKhuVuc.TabIndex = 3;
            // 
            // labelTenKhuVuc
            // 
            this.labelTenKhuVuc.AutoSize = true;
            this.labelTenKhuVuc.Location = new System.Drawing.Point(2, 76);
            this.labelTenKhuVuc.Name = "labelTenKhuVuc";
            this.labelTenKhuVuc.Size = new System.Drawing.Size(70, 13);
            this.labelTenKhuVuc.TabIndex = 1;
            this.labelTenKhuVuc.Text = "Tên Khu Vực";
            // 
            // labelMaKhuVuc
            // 
            this.labelMaKhuVuc.AutoSize = true;
            this.labelMaKhuVuc.Location = new System.Drawing.Point(7, 30);
            this.labelMaKhuVuc.Name = "labelMaKhuVuc";
            this.labelMaKhuVuc.Size = new System.Drawing.Size(66, 13);
            this.labelMaKhuVuc.TabIndex = 0;
            this.labelMaKhuVuc.Text = "Mã Khu Vực";
            // 
            // FormKhuVucXoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(311, 177);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormKhuVucXoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKhuVucXoa";
            this.Load += new System.EventHandler(this.FormKhuVucXoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxMaKhuVuc;
        private System.Windows.Forms.Label labelLoiKhuVuc;
        private System.Windows.Forms.Label labelThongBao;
        private System.Windows.Forms.TextBox textBoxTenKhuVuc;
        private System.Windows.Forms.Label labelTenKhuVuc;
        private System.Windows.Forms.Label labelMaKhuVuc;
    }
}