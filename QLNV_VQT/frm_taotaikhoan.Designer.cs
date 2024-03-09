namespace QLNV_VQT
{
    partial class frm_taotaikhoan
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.label_taotk = new System.Windows.Forms.Label();
            this.button_taotk = new System.Windows.Forms.Button();
            this.checkBox_hienthimatkhau = new System.Windows.Forms.CheckBox();
            this.textBox_tennguoidung = new System.Windows.Forms.TextBox();
            this.textBox_tendangnhap = new System.Windows.Forms.TextBox();
            this.label_matkhau = new System.Windows.Forms.Label();
            this.label_tendangnhap = new System.Windows.Forms.Label();
            this.label_DangNhap = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.textBox_matkhau = new System.Windows.Forms.TextBox();
            this.label_tennguoidung = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button_dangnhap);
            this.panel1.Controls.Add(this.label_taotk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(465, 680);
            this.panel1.TabIndex = 9;
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_dangnhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_dangnhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_dangnhap.Location = new System.Drawing.Point(48, 599);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(359, 43);
            this.button_dangnhap.TabIndex = 1;
            this.button_dangnhap.Text = "Đăng nhập";
            this.button_dangnhap.UseVisualStyleBackColor = true;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // label_taotk
            // 
            this.label_taotk.AutoSize = true;
            this.label_taotk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_taotk.ForeColor = System.Drawing.SystemColors.Control;
            this.label_taotk.Location = new System.Drawing.Point(132, 565);
            this.label_taotk.Name = "label_taotk";
            this.label_taotk.Size = new System.Drawing.Size(198, 19);
            this.label_taotk.TabIndex = 0;
            this.label_taotk.Text = "Đăng nhập tài khoản của bạn";
            // 
            // button_taotk
            // 
            this.button_taotk.BackColor = System.Drawing.Color.Navy;
            this.button_taotk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_taotk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_taotk.ForeColor = System.Drawing.SystemColors.Control;
            this.button_taotk.Location = new System.Drawing.Point(538, 508);
            this.button_taotk.Name = "button_taotk";
            this.button_taotk.Size = new System.Drawing.Size(124, 54);
            this.button_taotk.TabIndex = 17;
            this.button_taotk.Text = "Tạo tài khoản";
            this.button_taotk.UseVisualStyleBackColor = false;
            this.button_taotk.Click += new System.EventHandler(this.button_taotk_Click);
            // 
            // checkBox_hienthimatkhau
            // 
            this.checkBox_hienthimatkhau.AutoSize = true;
            this.checkBox_hienthimatkhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox_hienthimatkhau.Location = new System.Drawing.Point(507, 460);
            this.checkBox_hienthimatkhau.Name = "checkBox_hienthimatkhau";
            this.checkBox_hienthimatkhau.Size = new System.Drawing.Size(140, 21);
            this.checkBox_hienthimatkhau.TabIndex = 16;
            this.checkBox_hienthimatkhau.Text = "Hiển thị mật khẩu";
            this.checkBox_hienthimatkhau.UseVisualStyleBackColor = true;
            this.checkBox_hienthimatkhau.CheckedChanged += new System.EventHandler(this.checkBox_hienthimatkhau_CheckedChanged);
            // 
            // textBox_tennguoidung
            // 
            this.textBox_tennguoidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_tennguoidung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_tennguoidung.Location = new System.Drawing.Point(507, 306);
            this.textBox_tennguoidung.Name = "textBox_tennguoidung";
            this.textBox_tennguoidung.Size = new System.Drawing.Size(310, 30);
            this.textBox_tennguoidung.TabIndex = 15;
            // 
            // textBox_tendangnhap
            // 
            this.textBox_tendangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_tendangnhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_tendangnhap.Location = new System.Drawing.Point(508, 204);
            this.textBox_tendangnhap.Name = "textBox_tendangnhap";
            this.textBox_tendangnhap.Size = new System.Drawing.Size(310, 30);
            this.textBox_tendangnhap.TabIndex = 14;
            // 
            // label_matkhau
            // 
            this.label_matkhau.AutoSize = true;
            this.label_matkhau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_matkhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_matkhau.Location = new System.Drawing.Point(503, 360);
            this.label_matkhau.Name = "label_matkhau";
            this.label_matkhau.Size = new System.Drawing.Size(116, 27);
            this.label_matkhau.TabIndex = 13;
            this.label_matkhau.Text = "Mật khẩu :";
            // 
            // label_tendangnhap
            // 
            this.label_tendangnhap.AutoSize = true;
            this.label_tendangnhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_tendangnhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_tendangnhap.Location = new System.Drawing.Point(503, 163);
            this.label_tendangnhap.Name = "label_tendangnhap";
            this.label_tendangnhap.Size = new System.Drawing.Size(166, 27);
            this.label_tendangnhap.TabIndex = 12;
            this.label_tendangnhap.Text = "Tên đăng nhập :";
            // 
            // label_DangNhap
            // 
            this.label_DangNhap.AutoSize = true;
            this.label_DangNhap.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_DangNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_DangNhap.Location = new System.Drawing.Point(500, 104);
            this.label_DangNhap.Name = "label_DangNhap";
            this.label_DangNhap.Size = new System.Drawing.Size(256, 46);
            this.label_DangNhap.TabIndex = 11;
            this.label_DangNhap.Text = "Tạo Tài Khoản";
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_exit.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_exit.Location = new System.Drawing.Point(905, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(27, 29);
            this.label_exit.TabIndex = 10;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // textBox_matkhau
            // 
            this.textBox_matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_matkhau.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox_matkhau.Location = new System.Drawing.Point(507, 401);
            this.textBox_matkhau.Name = "textBox_matkhau";
            this.textBox_matkhau.Size = new System.Drawing.Size(310, 30);
            this.textBox_matkhau.TabIndex = 19;
            this.textBox_matkhau.UseSystemPasswordChar = true;
            // 
            // label_tennguoidung
            // 
            this.label_tennguoidung.AutoSize = true;
            this.label_tennguoidung.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_tennguoidung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_tennguoidung.Location = new System.Drawing.Point(503, 266);
            this.label_tennguoidung.Name = "label_tennguoidung";
            this.label_tennguoidung.Size = new System.Drawing.Size(175, 27);
            this.label_tennguoidung.TabIndex = 18;
            this.label_tennguoidung.Text = "Tên người dùng :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLNV_VQT.Properties.Resources.bgrlogin;
            this.pictureBox1.Location = new System.Drawing.Point(110, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(243, 255);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frm_taotaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(930, 680);
            this.Controls.Add(this.textBox_matkhau);
            this.Controls.Add(this.label_tennguoidung);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_taotk);
            this.Controls.Add(this.checkBox_hienthimatkhau);
            this.Controls.Add(this.textBox_tennguoidung);
            this.Controls.Add(this.textBox_tendangnhap);
            this.Controls.Add(this.label_matkhau);
            this.Controls.Add(this.label_tendangnhap);
            this.Controls.Add(this.label_DangNhap);
            this.Controls.Add(this.label_exit);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_taotaikhoan";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_taotaikhoan";
            this.Load += new System.EventHandler(this.frm_taotaikhoan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_dangnhap;
        private System.Windows.Forms.Label label_taotk;
        private System.Windows.Forms.Button button_taotk;
        private System.Windows.Forms.CheckBox checkBox_hienthimatkhau;
        private System.Windows.Forms.TextBox textBox_tennguoidung;
        private System.Windows.Forms.TextBox textBox_tendangnhap;
        private System.Windows.Forms.Label label_matkhau;
        private System.Windows.Forms.Label label_tendangnhap;
        private System.Windows.Forms.Label label_DangNhap;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.TextBox textBox_matkhau;
        private System.Windows.Forms.Label label_tennguoidung;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}