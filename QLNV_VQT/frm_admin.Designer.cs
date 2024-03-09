namespace QLNV_VQT
{
    partial class frm_admin
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
            this.button_QLdangNhap = new System.Windows.Forms.Button();
            this.button_QL = new System.Windows.Forms.Button();
            this.button_chucvu = new System.Windows.Forms.Button();
            this.button_phongban = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_exit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView_PBCV = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PBCV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button_QLdangNhap);
            this.panel1.Controls.Add(this.button_QL);
            this.panel1.Controls.Add(this.button_chucvu);
            this.panel1.Controls.Add(this.button_phongban);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 700);
            this.panel1.TabIndex = 0;
            // 
            // button_QLdangNhap
            // 
            this.button_QLdangNhap.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_QLdangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_QLdangNhap.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_QLdangNhap.Location = new System.Drawing.Point(34, 521);
            this.button_QLdangNhap.Name = "button_QLdangNhap";
            this.button_QLdangNhap.Size = new System.Drawing.Size(164, 53);
            this.button_QLdangNhap.TabIndex = 6;
            this.button_QLdangNhap.Text = "    QUẢN LÝ       ĐĂNG NHẬP";
            this.button_QLdangNhap.UseVisualStyleBackColor = false;
            this.button_QLdangNhap.Click += new System.EventHandler(this.button_QLdangNhap_Click);
            // 
            // button_QL
            // 
            this.button_QL.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_QL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_QL.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_QL.Location = new System.Drawing.Point(34, 425);
            this.button_QL.Name = "button_QL";
            this.button_QL.Size = new System.Drawing.Size(164, 53);
            this.button_QL.TabIndex = 5;
            this.button_QL.Text = "NHÂN VIÊN";
            this.button_QL.UseVisualStyleBackColor = false;
            this.button_QL.Click += new System.EventHandler(this.button_QL_Click);
            // 
            // button_chucvu
            // 
            this.button_chucvu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_chucvu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_chucvu.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_chucvu.Location = new System.Drawing.Point(34, 331);
            this.button_chucvu.Name = "button_chucvu";
            this.button_chucvu.Size = new System.Drawing.Size(164, 53);
            this.button_chucvu.TabIndex = 4;
            this.button_chucvu.Text = "CHỨC VỤ";
            this.button_chucvu.UseVisualStyleBackColor = false;
            this.button_chucvu.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_phongban
            // 
            this.button_phongban.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button_phongban.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_phongban.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_phongban.Location = new System.Drawing.Point(34, 235);
            this.button_phongban.Name = "button_phongban";
            this.button_phongban.Size = new System.Drawing.Size(164, 53);
            this.button_phongban.TabIndex = 0;
            this.button_phongban.Text = "PHÒNG BAN";
            this.button_phongban.UseVisualStyleBackColor = false;
            this.button_phongban.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN TRỊ VIÊN";
            // 
            // label_exit
            // 
            this.label_exit.AutoSize = true;
            this.label_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_exit.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label_exit.Location = new System.Drawing.Point(975, 0);
            this.label_exit.Name = "label_exit";
            this.label_exit.Size = new System.Drawing.Size(27, 29);
            this.label_exit.TabIndex = 2;
            this.label_exit.Text = "X";
            this.label_exit.Click += new System.EventHandler(this.label_exit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView_PBCV);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(240, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 291);
            this.panel2.TabIndex = 8;
            // 
            // dataGridView_PBCV
            // 
            this.dataGridView_PBCV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PBCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_PBCV.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_PBCV.Name = "dataGridView_PBCV";
            this.dataGridView_PBCV.RowTemplate.Height = 24;
            this.dataGridView_PBCV.Size = new System.Drawing.Size(760, 291);
            this.dataGridView_PBCV.TabIndex = 0;
            this.dataGridView_PBCV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_PBCV_CellClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLNV_VQT.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(61, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "frm_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_admin";
            this.Load += new System.EventHandler(this.frm_admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PBCV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_chucvu;
        private System.Windows.Forms.Button button_phongban;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_QL;
        public System.Windows.Forms.DataGridView dataGridView_PBCV;
        private System.Windows.Forms.Button button_QLdangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}