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
    public partial class frm_dangnhap : Form
    {
        public static frm_admin ad;
        public static frm_QLNhanVien ql;
        classConnect clCn = new classConnect();
        public frm_dangnhap()
        {
            InitializeComponent();
        }

        private void checkBox_hienthimatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_hienthimatkhau.Checked == true)
            {
                textBox_matkhau.UseSystemPasswordChar = false;
            }
            else textBox_matkhau.UseSystemPasswordChar = true;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_taotk_Click(object sender, EventArgs e)
        {
            frm_taotaikhoan ttk = new frm_taotaikhoan();
            ttk.Show();
            this.Hide();
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {

            //frm_admin ad = new frm_admin();
            //ad.Show();
            //this.Hide();



            //string sql = "select count (*) from dangnhap where tendangnhap='" + textBox_tendangnhap.Text + "' and matkhau='" + textBox_matkhau.Text + "'";
            string sqlTK = "select count (*) from dangnhap where tendangnhap='" + textBox_tendangnhap.Text + "' and matkhau='" + textBox_matkhau.Text + "'";
            try
            {
                int result = (int)clCn.scalar(sqlTK);
                if (result >= 1)
                {
                    string sqlTrangThai = "select trangthai from dangnhap where tendangnhap='" + textBox_tendangnhap.Text + "'";
                    try
                    {
                        int check = (int)clCn.scalar(sqlTrangThai);
                        //MessageBox.Show(check.ToString());
                        if (check != 1)
                        {
                            MessageBox.Show("Tài khoản của bạn hiện tại không thể đăng nhập vào hệ thống !! Vui lòng liên hệ admin để được mở khóa.");
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập thành công !!");
                            ad = new frm_admin();
                            ql = new frm_QLNhanVien();
                            if (textBox_tendangnhap.Text == "admin")
                            {
                                this.Hide();
                                ad.Show();
                            }
                            else
                            {
                                // ql = new frm_QLNhanVien();
                                this.Hide();
                                ql.Show();
                            }
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }

                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại !! Vui lòng kiểm tra lại tên đăng nhập và mật khẩu");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
