namespace QLNV_VQT
{
    partial class phongban
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
            this.button_luu = new System.Windows.Forms.Button();
            this.textBox_motaphongban = new System.Windows.Forms.TextBox();
            this.textBox_tenphongban = new System.Windows.Forms.TextBox();
            this.textBox_maphongban = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_luu
            // 
            this.button_luu.Location = new System.Drawing.Point(224, 307);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(75, 23);
            this.button_luu.TabIndex = 28;
            this.button_luu.Text = "Lưu";
            this.button_luu.UseVisualStyleBackColor = true;
            this.button_luu.Click += new System.EventHandler(this.button_luu_Click);
            // 
            // textBox_motaphongban
            // 
            this.textBox_motaphongban.Location = new System.Drawing.Point(224, 191);
            this.textBox_motaphongban.Multiline = true;
            this.textBox_motaphongban.Name = "textBox_motaphongban";
            this.textBox_motaphongban.Size = new System.Drawing.Size(283, 98);
            this.textBox_motaphongban.TabIndex = 27;
            // 
            // textBox_tenphongban
            // 
            this.textBox_tenphongban.Location = new System.Drawing.Point(346, 117);
            this.textBox_tenphongban.Name = "textBox_tenphongban";
            this.textBox_tenphongban.Size = new System.Drawing.Size(155, 22);
            this.textBox_tenphongban.TabIndex = 26;
            // 
            // textBox_maphongban
            // 
            this.textBox_maphongban.Location = new System.Drawing.Point(346, 62);
            this.textBox_maphongban.Name = "textBox_maphongban";
            this.textBox_maphongban.Size = new System.Drawing.Size(155, 22);
            this.textBox_maphongban.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(221, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Mô tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Tên phòng ban :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Mã phòng ban :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(299, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 22);
            this.label2.TabIndex = 21;
            this.label2.Text = "PHÒNG BAN";
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(432, 307);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(75, 23);
            this.button_xoa.TabIndex = 38;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_sua
            // 
            this.button_sua.Location = new System.Drawing.Point(331, 307);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(75, 23);
            this.button_sua.TabIndex = 39;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // phongban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 359);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_luu);
            this.Controls.Add(this.textBox_motaphongban);
            this.Controls.Add(this.textBox_tenphongban);
            this.Controls.Add(this.textBox_maphongban);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "phongban";
            this.Text = "phongban";
            this.Load += new System.EventHandler(this.phongban_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_luu;
        private System.Windows.Forms.TextBox textBox_motaphongban;
        private System.Windows.Forms.TextBox textBox_tenphongban;
        private System.Windows.Forms.TextBox textBox_maphongban;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
    }
}