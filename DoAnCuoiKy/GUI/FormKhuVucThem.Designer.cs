namespace DoAnCuoiKy.GUI
{
    partial class FormKhuVucThem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelLoiKhuVuc = new System.Windows.Forms.Label();
            this.labelThongBao = new System.Windows.Forms.Label();
            this.textBoxTenKhuVuc = new System.Windows.Forms.TextBox();
            this.textBoxMaKhuVuc = new System.Windows.Forms.TextBox();
            this.labelTenKhuVuc = new System.Windows.Forms.Label();
            this.labelMaKhuVuc = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.labelLoiKhuVuc);
            this.groupBox1.Controls.Add(this.labelThongBao);
            this.groupBox1.Controls.Add(this.textBoxTenKhuVuc);
            this.groupBox1.Controls.Add(this.textBoxMaKhuVuc);
            this.groupBox1.Controls.Add(this.labelTenKhuVuc);
            this.groupBox1.Controls.Add(this.labelMaKhuVuc);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
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
            this.textBoxTenKhuVuc.Location = new System.Drawing.Point(78, 73);
            this.textBoxTenKhuVuc.Name = "textBoxTenKhuVuc";
            this.textBoxTenKhuVuc.Size = new System.Drawing.Size(193, 20);
            this.textBoxTenKhuVuc.TabIndex = 3;
            this.textBoxTenKhuVuc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxTenKhuVuc_KeyDown);
            // 
            // textBoxMaKhuVuc
            // 
            this.textBoxMaKhuVuc.Location = new System.Drawing.Point(79, 23);
            this.textBoxMaKhuVuc.Name = "textBoxMaKhuVuc";
            this.textBoxMaKhuVuc.Size = new System.Drawing.Size(192, 20);
            this.textBoxMaKhuVuc.TabIndex = 2;
            this.textBoxMaKhuVuc.TextChanged += new System.EventHandler(this.textBoxMaKhuVuc_TextChanged);
            this.textBoxMaKhuVuc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMaKhuVuc_KeyDown);
            // 
            // labelTenKhuVuc
            // 
            this.labelTenKhuVuc.AutoSize = true;
            this.labelTenKhuVuc.Location = new System.Drawing.Point(7, 80);
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
            // buttonThem
            // 
            this.buttonThem.Location = new System.Drawing.Point(82, 140);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(75, 23);
            this.buttonThem.TabIndex = 1;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(208, 140);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 2;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // FormKhuVucThem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(301, 166);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormKhuVucThem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Khu Vực";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.TextBox textBoxTenKhuVuc;
        private System.Windows.Forms.TextBox textBoxMaKhuVuc;
        private System.Windows.Forms.Label labelTenKhuVuc;
        private System.Windows.Forms.Label labelMaKhuVuc;
        private System.Windows.Forms.Label labelLoiKhuVuc;
        private System.Windows.Forms.Label labelThongBao;
    }
}