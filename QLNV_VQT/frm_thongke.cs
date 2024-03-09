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
    public partial class frm_thongke : Form
    {
        classConnect clCn = new classConnect();
        public frm_thongke()
        {
            InitializeComponent();
        }

        private void checkBox_nhanvien_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_nhanvien.Checked == true)
            {
                label_chonnv.Visible = true;
                label_manv.Visible = true;
                comboBox_chonnhanvien.Visible = true;
                textBox_manv.Text = comboBox_chonnhanvien.SelectedValue.ToString();
                textBox_manv.Visible = true;
                textBox_manv.Enabled = false;
            }
            else
            {
                //noCheck();
                label_chonnv.Visible = false;
                label_manv.Visible = false;
                comboBox_chonnhanvien.Visible = false;
                textBox_manv.Visible = false;
            }

        }
        private void noCheck()
        {
            label_chonnv.Visible = false;
            label_manv.Visible = false;
            comboBox_chonnhanvien.Visible = false;
            textBox_manv.Visible = false;
            comboBox_chonthang.Visible = false;
            comboBox_chonnam.Visible = false;
            label_thang.Visible = false;
            label_nam.Visible = false;
        }
        private void frm_thongke_Load(object sender, EventArgs e)
        {
            noCheck();
            string sql = "select manv, hoten from nhanvien";
            try
            {
                comboBox_chonnhanvien.DataSource = clCn.fillData(sql);
                comboBox_chonnhanvien.DisplayMember = "hoten";
                comboBox_chonnhanvien.ValueMember = "manv";
            }
            catch (Exception)
            {

                throw;
            }

            string sqlthang = "select DISTINCT thang from luong";
            string sqlnam = "select DISTINCT nam from luong";

            try
            {
                comboBox_chonthang.DataSource = clCn.fillData(sqlthang);
                comboBox_chonnam.DataSource = clCn.fillData(sqlnam);

                comboBox_chonthang.DisplayMember = "thang";
                comboBox_chonthang.ValueMember = "thang";
                comboBox_chonnam.DisplayMember = "nam";
                comboBox_chonnam.ValueMember = "nam";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //throw;
            }
        }

 

        private void checkBox_thang_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_thang.Checked == true)
            {
                comboBox_chonthang.Visible = true;
                label_thang.Visible = true;
            }
            else
            {
                comboBox_chonthang.Visible = false;
                label_thang.Visible = false;
            }
        }

        private void checkBox_nam_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_nam.Checked == true)
            {
                comboBox_chonnam.Visible = true;
                label_nam.Visible = true;
            }
            else
            {
                comboBox_chonnam.Visible = false;
                label_nam.Visible = false;
            }

        }

        private void button_thongkeluong_Click(object sender, EventArgs e)
        {
            if (checkBox_nhanvien.Checked == false && checkBox_thang.Checked == false && checkBox_nam.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn đối tương thống kê !!!");
                dataGridView_thongkeluong.DataSource = null;
            }
            else if (checkBox_nhanvien.Checked == true && checkBox_thang.Checked == false && checkBox_nam.Checked == false)
            {
                string sqlTKluongNV = "select manv, sum(thuclanh) as [Tổng lương] from luong where manv='" + textBox_manv.Text + "' group by manv";

                try
                {
                    dataGridView_thongkeluong.DataSource = clCn.fillData(sqlTKluongNV);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (checkBox_nhanvien.Checked == true && checkBox_thang.Checked == true && checkBox_nam.Checked == false)
            {
                //MessageBox.Show(comboBox_chonthang.SelectedValue.ToString());
                string sqlTkluongThang = "select manv, thang, sum(thuclanh) as [Tổng lương] from luong where manv='"
                    + textBox_manv.Text + "' and thang="+ comboBox_chonthang.SelectedValue.ToString() + " group by manv, thang";
                try
                {
                    dataGridView_thongkeluong.DataSource = clCn.fillData(sqlTkluongThang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (checkBox_nhanvien.Checked == true && checkBox_thang.Checked == true && checkBox_nam.Checked == true)
            {
                string sqlTKluongTN = "select manv, thang, nam, sum(thuclanh) as [Tổng lương] from luong where manv='"
                    + textBox_manv.Text + "' and thang=" + comboBox_chonthang.SelectedValue.ToString()+" and nam="+comboBox_chonnam.SelectedValue.ToString()
                    + " group by manv, thang, nam";

                try
                {
                    dataGridView_thongkeluong.DataSource = clCn.fillData(sqlTKluongTN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (checkBox_nhanvien.Checked == false && checkBox_thang.Checked == false && checkBox_nam.Checked == true)
            {
                string sqlTKLN = "select nam, sum(thuclanh) as [Tổng lương năm] from luong where nam=" +
                    comboBox_chonnam.SelectedValue.ToString() + " group by nam";
                try
                {
                    dataGridView_thongkeluong.DataSource = clCn.fillData(sqlTKLN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else if (checkBox_nhanvien.Checked == false && checkBox_thang.Checked == true && checkBox_nam.Checked == true)
            {
                string sqlTKLTN = "select thang, nam, sum(thuclanh) as [Tổng lương tháng] from luong where nam=" +
                    comboBox_chonnam.SelectedValue.ToString() + " and thang="+comboBox_chonthang.SelectedValue.ToString()+" group by nam, thang";
                try
                {
                    dataGridView_thongkeluong.DataSource = clCn.fillData(sqlTKLTN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn năm !!");
            }
        }
    }
}
