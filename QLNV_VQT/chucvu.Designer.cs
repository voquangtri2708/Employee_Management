namespace QLNV_VQT
{
    partial class chucvu
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
            this.textBox_motachuvu = new System.Windows.Forms.TextBox();
            this.textBox_tenchucvu = new System.Windows.Forms.TextBox();
            this.textBox_machucvu = new System.Windows.Forms.TextBox();
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
            this.button_luu.Location = new System.Drawing.Point(231, 307);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(75, 23);
            this.button_luu.TabIndex = 36;
            this.button_luu.Text = "Lưu";
            this.button_luu.UseVisualStyleBackColor = true;
            this.button_luu.Click += new System.EventHandler(this.button_luu_Click);
            // 
            // textBox_motachuvu
            // 
            this.textBox_motachuvu.Location = new System.Drawing.Point(231, 192);
            this.textBox_motachuvu.Multiline = true;
            this.textBox_motachuvu.Name = "textBox_motachuvu";
            this.textBox_motachuvu.Size = new System.Drawing.Size(283, 98);
            this.textBox_motachuvu.TabIndex = 35;
            // 
            // textBox_tenchucvu
            // 
            this.textBox_tenchucvu.Location = new System.Drawing.Point(353, 118);
            this.textBox_tenchucvu.Name = "textBox_tenchucvu";
            this.textBox_tenchucvu.Size = new System.Drawing.Size(155, 22);
            this.textBox_tenchucvu.TabIndex = 34;
            // 
            // textBox_machucvu
            // 
            this.textBox_machucvu.Location = new System.Drawing.Point(353, 63);
            this.textBox_machucvu.Name = "textBox_machucvu";
            this.textBox_machucvu.Size = new System.Drawing.Size(155, 22);
            this.textBox_machucvu.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Mô tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(228, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 31;
            this.label6.Text = "Tên chức vụ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mã chức vụ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(336, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "CHỨC VỤ";
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(448, 307);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(75, 23);
            this.button_xoa.TabIndex = 37;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_sua
            // 
            this.button_sua.Location = new System.Drawing.Point(340, 307);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(75, 23);
            this.button_sua.TabIndex = 38;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // chucvu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 359);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_luu);
            this.Controls.Add(this.textBox_motachuvu);
            this.Controls.Add(this.textBox_tenchucvu);
            this.Controls.Add(this.textBox_machucvu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "chucvu";
            this.Text = "chucvu";
            this.Load += new System.EventHandler(this.chucvu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_luu;
        private System.Windows.Forms.TextBox textBox_motachuvu;
        private System.Windows.Forms.TextBox textBox_tenchucvu;
        private System.Windows.Forms.TextBox textBox_machucvu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
    }
}