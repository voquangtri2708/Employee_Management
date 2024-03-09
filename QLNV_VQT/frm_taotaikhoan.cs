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
    public partial class frm_taotaikhoan : Form
    {
        classConnect clCn = new classConnect();
        public frm_taotaikhoan()
        {
            InitializeComponent();
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            frm_dangnhap login = new frm_dangnhap();
            login.Show();
            this.Hide();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox_hienthimatkhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_hienthimatkhau.Checked == true)
            {
                textBox_matkhau.UseSystemPasswordChar = false;
            }
            else textBox_matkhau.UseSystemPasswordChar = true;
        }
        private void clearAll()
        {
            textBox_tendangnhap.Text = "";
            textBox_matkhau.Text = "";
            textBox_tennguoidung.Text = "";
        }
        private void button_taotk_Click(object sender, EventArgs e)
        {
            if (textBox_tendangnhap.Text == "" || textBox_matkhau.Text == "" || textBox_tennguoidung.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để tạo tài khoản !!");
            }
            else
            {
                if (textBox_tendangnhap.Text.ToLower() == "admin")
                {
                    MessageBox.Show("Bạn không thể tạo tên đăng nhập là admin !!");
                }
                else
                {
                    string sqlCount = "select count(*) from dangnhap where tendangnhap='" + textBox_tendangnhap.Text + "'";
                    try
                    {
                        int result = (int)clCn.scalar(sqlCount);
                        if (result >= 1)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại !! Vui lòng chọn tên đăng nhập khác.");
                        }
                        else
                        {
                            DateTime today = DateTime.Today;
                            string sqlCreateAcc = "insert into dangnhap values('" + textBox_tendangnhap.Text + "', N'" + textBox_matkhau.Text
                                + "', '" + textBox_tennguoidung.Text + "', 1, convert(datetime, '" + today.ToShortDateString() + "'))";


                            int kq = clCn.nonQuery(sqlCreateAcc);
                            if (kq >= 1)
                            {
                                //MessageBox.Show("Tạo tài khoản thành công !!");

                                DialogResult dialog = MessageBox.Show("Tạo tài khoản thành công !! Bạn có muốn đăng nhập không?", "Gợi ý đăng nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dialog == DialogResult.Yes)
                                {
                                    frm_dangnhap login = new frm_dangnhap();
                                    login.Show();
                                } else clearAll();
                            }

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void frm_taotaikhoan_Load(object sender, EventArgs e)
        {
        }

 
    }
}
