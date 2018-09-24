namespace DoAnCuoiKy.GUI
{
    partial class FormBoPhanXoa
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
            this.comboBoxBP = new System.Windows.Forms.ComboBox();
            this.labelLoiKhuVuc = new System.Windows.Forms.Label();
            this.labelThongBao = new System.Windows.Forms.Label();
            this.textBoxTenBP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(204, 153);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 10;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Location = new System.Drawing.Point(112, 153);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(75, 23);
            this.buttonXoa.TabIndex = 9;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.comboBoxBP);
            this.groupBox1.Controls.Add(this.labelLoiKhuVuc);
            this.groupBox1.Controls.Add(this.labelThongBao);
            this.groupBox1.Controls.Add(this.textBoxTenBP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 135);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // comboBoxBP
            // 
            this.comboBoxBP.FormattingEnabled = true;
            this.comboBoxBP.Location = new System.Drawing.Point(79, 22);
            this.comboBoxBP.Name = "comboBoxBP";
            this.comboBoxBP.Size = new System.Drawing.Size(190, 21);
            this.comboBoxBP.TabIndex = 6;
            this.comboBoxBP.SelectedIndexChanged += new System.EventHandler(this.comboBoxBP_SelectedIndexChanged);
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
            // textBoxTenBP
            // 
            this.textBoxTenBP.Enabled = false;
            this.textBoxTenBP.Location = new System.Drawing.Point(78, 73);
            this.textBoxTenBP.Name = "textBoxTenBP";
            this.textBoxTenBP.Size = new System.Drawing.Size(193, 20);
            this.textBoxTenBP.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên bộ phận";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã bộ phận";
            // 
            // FormBoPhanXoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 185);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBoPhanXoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBoPhanXoa";
            this.Load += new System.EventHandler(this.FormBoPhanXoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonThoat;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxBP;
        private System.Windows.Forms.Label labelLoiKhuVuc;
        private System.Windows.Forms.Label labelThongBao;
        private System.Windows.Forms.TextBox textBoxTenBP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}