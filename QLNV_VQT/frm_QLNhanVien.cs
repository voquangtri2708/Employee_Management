using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV_VQT
{
    public partial class frm_QLNhanVien : Form
    {
        public frm_QLNhanVien()
        {
            InitializeComponent();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_ttNhanvien_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_luongnhanvien"] != null)
            {
                Application.OpenForms["frm_luongnhanvien"].Close();
            }
            if (Application.OpenForms["frm_ttnv"] == null)
            {
                frm_ttnv tt = new frm_ttnv();
                tt.MdiParent = this;
                tt.Dock = DockStyle.Fill;
                tt.Show();
            }
            else
            {
                Application.OpenForms["frm_ttnv"].Activate();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Bạn thật sự có muốn đăng xuất hay không ??", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
                frm_dangnhap login = new frm_dangnhap();
                login.Show();

                if (Application.OpenForms["frm_admin"] != null)
                {
                    Application.OpenForms["frm_admin"].Close();
                }
            }
        }

        private void button_luongnv_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ttnv"] != null)
            {
                Application.OpenForms["frm_ttnv"].Close();
            }
            if (Application.OpenForms["frm_thongke"] != null)
            {
                Application.OpenForms["frm_thongke"].Close();
            }

            if (Application.OpenForms["frm_luongnhanvien"] == null)
            {
                frm_luongnhanvien luong = new frm_luongnhanvien();
                luong.MdiParent = this;
                luong.Dock = DockStyle.Fill;
                luong.Show();
            }
            else
            {
                Application.OpenForms["frm_luongnhanvien"].Activate();
            }

        }

        private void frm_QLNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void button_thongke_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ttnv"] != null)
            {
                Application.OpenForms["frm_ttnv"].Close();
            }
            if (Application.OpenForms["frm_luongnhanvien"] != null)
            {
                Application.OpenForms["frm_luongnhanvien"].Close();
            }

            if (Application.OpenForms["frm_thongke"] == null)
            {
                frm_thongke thongke = new frm_thongke();
                thongke.MdiParent = this;
                thongke.Dock = DockStyle.Fill;
                thongke.Show();
            }
            else
            {
                Application.OpenForms["frm_thongke"].Activate();
            }
        }
    }
}
