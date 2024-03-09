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
    public partial class qlyDangNhap : Form
    {
        classConnect clCn = new classConnect();
        public qlyDangNhap()
        {
            InitializeComponent();
        }
        public void clearTextBox()
        {
            textBox_tendangnhap.Text = "";
            textBox_tennguoidung.Text = "";
            textBox_matkhau.Text = "";
            checkBox_trangthai.Checked = false;

            button_them.Enabled = true;
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
        }

        public void fillTextBox(string tendn, string tennd, string mk, int tt)
        {
            textBox_tendangnhap.Text = tendn;
            textBox_tennguoidung.Text = tennd;
            textBox_matkhau.Text = mk;
            if (tt == 0)
            {
                checkBox_trangthai.Checked = false;
            }
            else checkBox_trangthai.Checked = true;

            button_them.Enabled = false;
            button_sua.Enabled = true;
            button_xoa.Enabled = true;
        }

        private void qlyDangNhap_Load(object sender, EventArgs e)
        {
            clearTextBox();
        }

        private void button_them_Click(object sender, EventArgs e)
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
                    int trangthai;
                    if (checkBox_trangthai.Checked == true) trangthai = 1;
                    else trangthai = 0;
                    string sqlCreateAcc = "insert into dangnhap values('" + textBox_tendangnhap.Text + "', N'" + textBox_matkhau.Text
                        + "', '" + textBox_tennguoidung.Text + "', "+trangthai+", convert(datetime, '" + today.ToShortDateString() + "'))";
                    int kq = clCn.nonQuery(sqlCreateAcc);
                    if (kq >= 1)
                    {
                        MessageBox.Show("Tạo tài khoản thành công !!");
                        frm_dangnhap.ad.loadDN();
                        clearTextBox();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            string sql = "delete dangnhap where tendangnhap='" + textBox_tendangnhap.Text + "'";
            if (textBox_tendangnhap.Text == "admin")
            {
                MessageBox.Show("Không thể xóa admin hệ thống !!");
            } else
            {
                try
                {
                    int result = clCn.nonQuery(sql);
                    if (result >= 1)
                    {
                        MessageBox.Show("Xóa tài khoản thành công !!");
                        frm_dangnhap.ad.loadDN();
                        clearTextBox();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            int tt;
            if (checkBox_trangthai.Checked == true) tt = 1;
            else tt = 0;
            string sql = "update dangnhap set tennguoidung='" + textBox_tennguoidung.Text + "', matkhau='" + textBox_matkhau.Text +
                "', trangthai="+tt.ToString()+" where tendangnhap='"+textBox_tendangnhap.Text+"'";
            try
            {
                int result = clCn.nonQuery(sql);
                if (result >= 1)
                {
                    MessageBox.Show("Cập nhật thành công !!");
                    frm_dangnhap.ad.loadDN();
                    clearTextBox();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cập nhật thất bại !!");
                clearTextBox();
            }
        }
    }
}

