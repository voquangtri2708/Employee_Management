namespace QLNV_VQT
{
    partial class frm_thongke
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_nhanvien = new System.Windows.Forms.CheckBox();
            this.checkBox_nam = new System.Windows.Forms.CheckBox();
            this.checkBox_thang = new System.Windows.Forms.CheckBox();
            this.label_chonnv = new System.Windows.Forms.Label();
            this.comboBox_chonnhanvien = new System.Windows.Forms.ComboBox();
            this.label_manv = new System.Windows.Forms.Label();
            this.textBox_manv = new System.Windows.Forms.TextBox();
            this.label_thang = new System.Windows.Forms.Label();
            this.comboBox_chonthang = new System.Windows.Forms.ComboBox();
            this.comboBox_chonnam = new System.Windows.Forms.ComboBox();
            this.label_nam = new System.Windows.Forms.Label();
            this.button_thongkeluong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_thongkeluong = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thongkeluong)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "THỐNG KÊ LƯƠNG";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 46);
            this.panel1.TabIndex = 2;
            // 
            // checkBox_nhanvien
            // 
            this.checkBox_nhanvien.AutoSize = true;
            this.checkBox_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBox_nhanvien.Location = new System.Drawing.Point(116, 82);
            this.checkBox_nhanvien.Name = "checkBox_nhanvien";
            this.checkBox_nhanvien.Size = new System.Drawing.Size(150, 29);
            this.checkBox_nhanvien.TabIndex = 2;
            this.checkBox_nhanvien.Text = "NHÂN VIÊN";
            this.checkBox_nhanvien.UseVisualStyleBackColor = true;
            this.checkBox_nhanvien.CheckedChanged += new System.EventHandler(this.checkBox_nhanvien_CheckedChanged);
            // 
            // checkBox_nam
            // 
            this.checkBox_nam.AutoSize = true;
            this.checkBox_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBox_nam.Location = new System.Drawing.Point(594, 82);
            this.checkBox_nam.Name = "checkBox_nam";
            this.checkBox_nam.Size = new System.Drawing.Size(82, 29);
            this.checkBox_nam.TabIndex = 3;
            this.checkBox_nam.Text = "NĂM";
            this.checkBox_nam.UseVisualStyleBackColor = true;
            this.checkBox_nam.CheckedChanged += new System.EventHandler(this.checkBox_nam_CheckedChanged);
            // 
            // checkBox_thang
            // 
            this.checkBox_thang.AutoSize = true;
            this.checkBox_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.checkBox_thang.Location = new System.Drawing.Point(369, 82);
            this.checkBox_thang.Name = "checkBox_thang";
            this.checkBox_thang.Size = new System.Drawing.Size(109, 29);
            this.checkBox_thang.TabIndex = 4;
            this.checkBox_thang.Text = "THÁNG";
            this.checkBox_thang.UseVisualStyleBackColor = true;
            this.checkBox_thang.CheckedChanged += new System.EventHandler(this.checkBox_thang_CheckedChanged);
            // 
            // label_chonnv
            // 
            this.label_chonnv.AutoSize = true;
            this.label_chonnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_chonnv.Location = new System.Drawing.Point(48, 144);
            this.label_chonnv.Name = "label_chonnv";
            this.label_chonnv.Size = new System.Drawing.Size(110, 18);
            this.label_chonnv.TabIndex = 5;
            this.label_chonnv.Text = "Chọn nhân viên";
            // 
            // comboBox_chonnhanvien
            // 
            this.comboBox_chonnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_chonnhanvien.FormattingEnabled = true;
            this.comboBox_chonnhanvien.Location = new System.Drawing.Point(164, 137);
            this.comboBox_chonnhanvien.Name = "comboBox_chonnhanvien";
            this.comboBox_chonnhanvien.Size = new System.Drawing.Size(130, 26);
            this.comboBox_chonnhanvien.TabIndex = 6;
            // 
            // label_manv
            // 
            this.label_manv.AutoSize = true;
            this.label_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_manv.Location = new System.Drawing.Point(48, 181);
            this.label_manv.Name = "label_manv";
            this.label_manv.Size = new System.Drawing.Size(99, 18);
            this.label_manv.TabIndex = 7;
            this.label_manv.Text = "Mã nhân viên ";
            // 
            // textBox_manv
            // 
            this.textBox_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_manv.Location = new System.Drawing.Point(164, 176);
            this.textBox_manv.Name = "textBox_manv";
            this.textBox_manv.Size = new System.Drawing.Size(130, 24);
            this.textBox_manv.TabIndex = 8;
            // 
            // label_thang
            // 
            this.label_thang.AutoSize = true;
            this.label_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_thang.Location = new System.Drawing.Point(321, 144);
            this.label_thang.Name = "label_thang";
            this.label_thang.Size = new System.Drawing.Size(84, 18);
            this.label_thang.TabIndex = 9;
            this.label_thang.Text = "Chọn tháng";
            // 
            // comboBox_chonthang
            // 
            this.comboBox_chonthang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_chonthang.FormattingEnabled = true;
            this.comboBox_chonthang.Location = new System.Drawing.Point(421, 137);
            this.comboBox_chonthang.Name = "comboBox_chonthang";
            this.comboBox_chonthang.Size = new System.Drawing.Size(70, 26);
            this.comboBox_chonthang.TabIndex = 10;
            // 
            // comboBox_chonnam
            // 
            this.comboBox_chonnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox_chonnam.FormattingEnabled = true;
            this.comboBox_chonnam.Location = new System.Drawing.Point(636, 136);
            this.comboBox_chonnam.Name = "comboBox_chonnam";
            this.comboBox_chonnam.Size = new System.Drawing.Size(76, 26);
            this.comboBox_chonnam.TabIndex = 12;
            // 
            // label_nam
            // 
            this.label_nam.AutoSize = true;
            this.label_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_nam.Location = new System.Drawing.Point(553, 144);
            this.label_nam.Name = "label_nam";
            this.label_nam.Size = new System.Drawing.Size(77, 18);
            this.label_nam.TabIndex = 11;
            this.label_nam.Text = "Chọn năm";
            // 
            // button_thongkeluong
            // 
            this.button_thongkeluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_thongkeluong.Location = new System.Drawing.Point(305, 264);
            this.button_thongkeluong.Name = "button_thongkeluong";
            this.button_thongkeluong.Size = new System.Drawing.Size(173, 58);
            this.button_thongkeluong.TabIndex = 13;
            this.button_thongkeluong.Text = "THỐNG KÊ LƯƠNG";
            this.button_thongkeluong.UseVisualStyleBackColor = true;
            this.button_thongkeluong.Click += new System.EventHandler(this.button_thongkeluong_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_thongkeluong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(793, 292);
            this.panel2.TabIndex = 14;
            // 
            // dataGridView_thongkeluong
            // 
            this.dataGridView_thongkeluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_thongkeluong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_thongkeluong.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_thongkeluong.Name = "dataGridView_thongkeluong";
            this.dataGridView_thongkeluong.RowTemplate.Height = 24;
            this.dataGridView_thongkeluong.Size = new System.Drawing.Size(793, 292);
            this.dataGridView_thongkeluong.TabIndex = 0;
            // 
            // frm_thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(793, 653);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button_thongkeluong);
            this.Controls.Add(this.comboBox_chonnam);
            this.Controls.Add(this.label_nam);
            this.Controls.Add(this.comboBox_chonthang);
            this.Controls.Add(this.label_thang);
            this.Controls.Add(this.textBox_manv);
            this.Controls.Add(this.label_manv);
            this.Controls.Add(this.comboBox_chonnhanvien);
            this.Controls.Add(this.label_chonnv);
            this.Controls.Add(this.checkBox_thang);
            this.Controls.Add(this.checkBox_nam);
            this.Controls.Add(this.checkBox_nhanvien);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_thongke";
            this.Text = "frm_thongke";
            this.Load += new System.EventHandler(this.frm_thongke_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_thongkeluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox_nhanvien;
        private System.Windows.Forms.CheckBox checkBox_nam;
        private System.Windows.Forms.CheckBox checkBox_thang;
        private System.Windows.Forms.Label label_chonnv;
        private System.Windows.Forms.ComboBox comboBox_chonnhanvien;
        private System.Windows.Forms.Label label_manv;
        private System.Windows.Forms.TextBox textBox_manv;
        private System.Windows.Forms.Label label_thang;
        private System.Windows.Forms.ComboBox comboBox_chonthang;
        private System.Windows.Forms.ComboBox comboBox_chonnam;
        private System.Windows.Forms.Label label_nam;
        private System.Windows.Forms.Button button_thongkeluong;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_thongkeluong;
    }
}