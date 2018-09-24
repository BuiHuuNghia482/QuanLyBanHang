namespace DoAnCuoiKy.GUI
{
    partial class FormDoiMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxMatKhauCu = new System.Windows.Forms.TextBox();
            this.textBoxMatKhauMoi = new System.Windows.Forms.TextBox();
            this.textBoxMatKhauMoiNhapLai = new System.Windows.Forms.TextBox();
            this.buttonXong = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập Mật Khẩu Cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập Mật Khẩu Mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập Lại Mật Khẩu Mới";
            // 
            // textBoxMatKhauCu
            // 
            this.textBoxMatKhauCu.Location = new System.Drawing.Point(134, 40);
            this.textBoxMatKhauCu.Name = "textBoxMatKhauCu";
            this.textBoxMatKhauCu.PasswordChar = '*';
            this.textBoxMatKhauCu.Size = new System.Drawing.Size(144, 20);
            this.textBoxMatKhauCu.TabIndex = 3;
            // 
            // textBoxMatKhauMoi
            // 
            this.textBoxMatKhauMoi.Location = new System.Drawing.Point(134, 66);
            this.textBoxMatKhauMoi.Name = "textBoxMatKhauMoi";
            this.textBoxMatKhauMoi.PasswordChar = '*';
            this.textBoxMatKhauMoi.Size = new System.Drawing.Size(144, 20);
            this.textBoxMatKhauMoi.TabIndex = 4;
            // 
            // textBoxMatKhauMoiNhapLai
            // 
            this.textBoxMatKhauMoiNhapLai.Location = new System.Drawing.Point(134, 96);
            this.textBoxMatKhauMoiNhapLai.Name = "textBoxMatKhauMoiNhapLai";
            this.textBoxMatKhauMoiNhapLai.PasswordChar = '*';
            this.textBoxMatKhauMoiNhapLai.Size = new System.Drawing.Size(144, 20);
            this.textBoxMatKhauMoiNhapLai.TabIndex = 5;
            this.textBoxMatKhauMoiNhapLai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxMatKhauMoiNhapLai_KeyDown);
            // 
            // buttonXong
            // 
            this.buttonXong.Location = new System.Drawing.Point(134, 122);
            this.buttonXong.Name = "buttonXong";
            this.buttonXong.Size = new System.Drawing.Size(75, 23);
            this.buttonXong.TabIndex = 6;
            this.buttonXong.Text = "Xong";
            this.buttonXong.UseVisualStyleBackColor = true;
            this.buttonXong.Click += new System.EventHandler(this.buttonXong_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Thay Đổi Mật Khẩu";
            // 
            // buttonThoat
            // 
            this.buttonThoat.Location = new System.Drawing.Point(215, 122);
            this.buttonThoat.Name = "buttonThoat";
            this.buttonThoat.Size = new System.Drawing.Size(75, 23);
            this.buttonThoat.TabIndex = 8;
            this.buttonThoat.Text = "Thoát";
            this.buttonThoat.UseVisualStyleBackColor = true;
            this.buttonThoat.Click += new System.EventHandler(this.buttonThoat_Click);
            // 
            // FormDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 151);
            this.Controls.Add(this.buttonThoat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonXong);
            this.Controls.Add(this.textBoxMatKhauMoiNhapLai);
            this.Controls.Add(this.textBoxMatKhauMoi);
            this.Controls.Add(this.textBoxMatKhauCu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDoiMatKhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxMatKhauCu;
        private System.Windows.Forms.TextBox textBoxMatKhauMoi;
        private System.Windows.Forms.TextBox textBoxMatKhauMoiNhapLai;
        private System.Windows.Forms.Button buttonXong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonThoat;
    }
}