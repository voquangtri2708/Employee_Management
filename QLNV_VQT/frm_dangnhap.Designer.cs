namespace QLNV_VQT
{
    partial class frm_dangnhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_taotk = new System.Windows.Forms.Button();
            this.label_taotk = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.label_DangNhap = new System.Windows.Forms.Label();
            this.label_tendangnhap = new System.Windows.Forms.Label();
            this.label_matkhau = new System.Windows.Forms.Label();
            this.textBox_tendangnhap = new System.Windows.Forms.TextBox();
            this.textBox_matkhau = new System.Windows.Forms.TextBox();
            this.checkBox_hienthimatkhau = new System.Windows.Forms.CheckBox();
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button_taotk);
            this.panel1.Controls.Add(this.label_taotk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 550);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(113, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "HỆ THỐNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(63, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLNV_VQT.Properties.Resources.bgrlogin;
            this.pictureBox1.Location = new System.Drawing.Point(68, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // button_taotk
            // 
            this.button_taotk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_taotk.Location = new System.Drawing.Point(39, 480);
            this.button_taotk.Name = "button_taotk";
            this.button_taotk.Size = new System.Drawing.Size(276, 43);
            this.button_taotk.TabIndex = 1;
            this.button_taotk.Text = "Tạo tài khoản";
            this.button_taotk.UseVisualStyleBackColor = true;
            this.button_taotk.Click += new System.EventHandler(this.button_taotk_Click);
            // 
            // label_taotk
            // 
            this.label_taotk.AutoSize = true;
            this.label_taotk.ForeColor = System.Drawing.SystemColors.Control;
            this.label_taotk.Location = new System.Drawing.Point(98, 456);
            this.label_taotk.Name = "label_taotk";
            this.label_taotk.Size = new System.Drawing.Size(168, 19);
            this.label_taotk.TabIndex = 0;
            this.label_taotk.Text = "Bạn chưa có tài khoản ?";
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_exit.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_exit.Location = new System.Drawing.Point(675, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(27, 29);
            this.label_exit.TabIndex = 1;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // label_DangNhap
            // 
            this.label_DangNhap.AutoSize = true;
            this.label_DangNhap.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_DangNhap.Location = new System.Drawing.Point(367, 93);
            this.label_DangNhap.Name = "label_DangNhap";
            this.label_DangNhap.Size = new System.Drawing.Size(204, 46);
            this.label_DangNhap.TabIndex = 2;
            this.label_DangNhap.Text = "Đăng Nhập";
            // 
            // label_tendangnhap
            // 
            this.label_tendangnhap.AutoSize = true;
            this.label_tendangnhap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_tendangnhap.Location = new System.Drawing.Point(371, 193);
            this.label_tendangnhap.Name = "label_tendangnhap";
            this.label_tendangnhap.Size = new System.Drawing.Size(166, 27);
            this.label_tendangnhap.TabIndex = 3;
            this.label_tendangnhap.Text = "Tên đăng nhập :";
            // 
            // label_matkhau
            // 
            this.label_matkhau.AutoSize = true;
            this.label_matkhau.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_matkhau.Location = new System.Drawing.Point(371, 296);
            this.label_matkhau.Name = "label_matkhau";
            this.label_matkhau.Size = new System.Drawing.Size(121, 27);
            this.label_matkhau.TabIndex = 4;
            this.label_matkhau.Text = "Mật Khẩu :";
            // 
            // textBox_tendangnhap
            // 
            this.textBox_tendangnhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_tendangnhap.Location = new System.Drawing.Point(376, 234);
            this.textBox_tendangnhap.Name = "textBox_tendangnhap";
            this.textBox_tendangnhap.Size = new System.Drawing.Size(283, 30);
            this.textBox_tendangnhap.TabIndex = 5;
            // 
            // textBox_matkhau
            // 
            this.textBox_matkhau.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_matkhau.Location = new System.Drawing.Point(375, 337);
            this.textBox_matkhau.Name = "textBox_matkhau";
            this.textBox_matkhau.Size = new System.Drawing.Size(283, 30);
            this.textBox_matkhau.TabIndex = 6;
            this.textBox_matkhau.UseSystemPasswordChar = true;
            // 
            // checkBox_hienthimatkhau
            // 
            this.checkBox_hienthimatkhau.AutoSize = true;
            this.checkBox_hienthimatkhau.Location = new System.Drawing.Point(376, 378);
            this.checkBox_hienthimatkhau.Name = "checkBox_hienthimatkhau";
            this.checkBox_hienthimatkhau.Size = new System.Drawing.Size(150, 23);
            this.checkBox_hienthimatkhau.TabIndex = 7;
            this.checkBox_hienthimatkhau.Text = "Hiển thị mật khẩu";
            this.checkBox_hienthimatkhau.UseVisualStyleBackColor = true;
            this.checkBox_hienthimatkhau.CheckedChanged += new System.EventHandler(this.checkBox_hienthimatkhau_CheckedChanged);
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.BackColor = System.Drawing.Color.Navy;
            this.button_dangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_dangnhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_dangnhap.ForeColor = System.Drawing.SystemColors.Control;
            this.button_dangnhap.Location = new System.Drawing.Point(395, 430);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(97, 45);
            this.button_dangnhap.TabIndex = 8;
            this.button_dangnhap.Text = "Đăng nhập";
            this.button_dangnhap.UseVisualStyleBackColor = false;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // frm_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.button_dangnhap);
            this.Controls.Add(this.checkBox_hienthimatkhau);
            this.Controls.Add(this.textBox_matkhau);
            this.Controls.Add(this.textBox_tendangnhap);
            this.Controls.Add(this.label_matkhau);
            this.Controls.Add(this.label_tendangnhap);
            this.Controls.Add(this.label_DangNhap);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_taotk;
        private System.Windows.Forms.Label label_taotk;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label_DangNhap;
        private System.Windows.Forms.Label label_tendangnhap;
        private System.Windows.Forms.Label label_matkhau;
        private System.Windows.Forms.TextBox textBox_tendangnhap;
        private System.Windows.Forms.TextBox textBox_matkhau;
        private System.Windows.Forms.CheckBox checkBox_hienthimatkhau;
        private System.Windows.Forms.Button button_dangnhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

