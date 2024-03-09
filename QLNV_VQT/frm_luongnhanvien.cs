using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV_VQT
{
    public partial class frm_luongnhanvien : Form
    {
        classConnect clCn = new classConnect();
        public frm_luongnhanvien()
        {
            InitializeComponent();
        }

        private double luongcb;
        private double phucap;
        private double thuong;
        private double thue;
        private double thuclanh;

        private void clearAll()
        {
            textBox_manv.Text = "";
            textBox_tennv.Text = "";
            textBox_chucvu.Text = "";
            textBox_phongban.Text = "";
            textBox_thang.Text = "";
            textBox_nam.Text = "";
            checkBox_thue5.Checked = false;
            checkBox_thue10.Checked = false;
            button_luu.Enabled = false;
            textBox_luongcb.Text = "";
            textBox_thuong.Text = "";
            textBox_phucap.Text = "";
            label_thuclanh.Text = "";
            label10.Text = "Tính lương thực lãnh ?";
        }

        private void loadGridV()
        {
            string sqlLoadNV = "select manv, hoten, chucvu.tencv, phongban.tenpb from nhanvien " +
                "inner join chucvu on nhanvien.macv=chucvu.macv " +
                "inner join phongban on nhanvien.mapb=phongban.mapb";
            try
            {
                dataGridView_nhanvienLuong.DataSource = clCn.fillData(sqlLoadNV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void luongnhanvien_Load(object sender, EventArgs e)
        {
            loadGridV();
            clearAll();
        }

        private void dataGridView_nhanvienLuong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_thang.Text = DateTime.Now.Month.ToString();
            textBox_nam.Text = DateTime.Now.Year.ToString();

            textBox_manv.Text = dataGridView_nhanvienLuong.CurrentRow.Cells[0].Value.ToString();
            textBox_tennv.Text = dataGridView_nhanvienLuong.CurrentRow.Cells[1].Value.ToString();
            textBox_chucvu.Text = dataGridView_nhanvienLuong.CurrentRow.Cells[2].Value.ToString();
            textBox_phongban.Text = dataGridView_nhanvienLuong.CurrentRow.Cells[3].Value.ToString();

            textBox_manv.Enabled = false;
            textBox_tennv.Enabled = false;
            textBox_chucvu.Enabled = false;
            textBox_phongban.Enabled = false;
        }

        private void checkBox_5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_thue5.Checked == true)
            {
                checkBox_thue10.Checked = false;
            }
        }

        private void checkBox_10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_thue10.Checked == true)
            {
                checkBox_thue5.Checked = false;
            }
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            string sqlInsertLuong = "insert into luong values('" + textBox_manv.Text + "', " + textBox_thang.Text
                + ", " + textBox_nam.Text + ", " + luongcb.ToString(CultureInfo.InvariantCulture) + ", " + phucap.ToString(CultureInfo.InvariantCulture) +
                ", " + thuong.ToString(CultureInfo.InvariantCulture) + ", " + thue.ToString(CultureInfo.InvariantCulture) + ", "
                + thuclanh.ToString(CultureInfo.InvariantCulture) + ")";
            // MessageBox.Show(thuclanh.ToString(CultureInfo.InvariantCulture));

            DialogResult dialog = MessageBox.Show("Có chắc bạn muốn lưu không ??", "Lưu lương nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    int result = clCn.nonQuery(sqlInsertLuong);
                    if (result >= 1)
                    {
                        MessageBox.Show("Nhập lương thành công !!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Tháng này đã được lưu lương rồi !!");
                }
                finally
                {
                    loadGridV();
                    clearAll();
                }
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            if (textBox_luongcb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lương cơ bản !!");
            }
            else
            {
                try
                {
                    luongcb = double.Parse(textBox_luongcb.Text);

                    if (textBox_phucap.Text == "") phucap = 0;
                    else phucap = double.Parse(textBox_phucap.Text);

                    if (textBox_thuong.Text == "") thuong = 0;
                    else thuong = double.Parse(textBox_thuong.Text);

                    if (checkBox_thue5.Checked == true) thue = 0.05;
                    else if (checkBox_thue10.Checked == true) thue = 0.1;
                    else thue = 0;

                    thuclanh = luongcb * (1 - thue) + thuong + phucap;

                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng của tiền tệ !!");
                    textBox_luongcb.Text = "";
                    textBox_phucap.Text = "";
                    textBox_thuong.Text = "";
                    checkBox_thue5.Checked = false;
                    checkBox_thue10.Checked = false;
                }
                if (thuclanh != 0)
                {
                    label10.Text = "Thực lãnh : ";
                    label_thuclanh.Text = thuclanh.ToString();
                    button_luu.Enabled = true;
                }


            }
        }
    }
}
