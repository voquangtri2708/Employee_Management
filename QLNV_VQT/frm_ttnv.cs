using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNV_VQT
{
    public partial class frm_ttnv : Form
    {
        classConnect clCn = new classConnect();
        public frm_ttnv()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void clearAll()
        {
            textBox_manhanvien.Text = "";
            textBox_tennhanvien.Text = "";
            //dateTimePicker_ngaysinh = null;
            comboBox_gioitinh.SelectedItem = null;
            textBox_diachi.Text = "";
            textBox_sdt.Text = "";
            textBox_mail.Text = "";
            comboBox_phongban.SelectedItem = null;
            comboBox_chucvu.SelectedItem = null;
            pictureBox_hinh.Image = null;
        }
        private void loadDataGriV()
        {
            string sqlGridV = "select * from nhanvien";
            try
            {
                dataGridView_ttnv.DataSource = clCn.fillData(sqlGridV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
        private void frm_ttnv_Load(object sender, EventArgs e)
        {
            string sqlPB = "select * from phongban";
            string sqlCV = "select * from chucvu";
            try
            {
                comboBox_phongban.DataSource = clCn.fillData(sqlPB);
                comboBox_phongban.DisplayMember = "tenpb";
                comboBox_phongban.ValueMember = "mapb";

                comboBox_chucvu.DataSource = clCn.fillData(sqlCV);
                comboBox_chucvu.DisplayMember = "tencv";
                comboBox_chucvu.ValueMember = "macv";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }

            clearAll();
            loadDataGriV();
        }
        private string selectedImagePath;
        private void button_them_Click(object sender, EventArgs e)
        {
            if (textBox_manhanvien.Text == ""
                || textBox_tennhanvien.Text == ""
                || textBox_diachi.Text == ""
                || textBox_sdt.Text == ""
                || textBox_mail.Text == ""
                || pictureBox_hinh.Image == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!");
            }
            else
            {
                string path = Path.Combine(@"D:\Program_net\QLNV_VQT\QLNV_VQT\imagesNV\" + textBox_manhanvien.Text.Trim() + ".jpg");
                
                //string path = Path.Combine(@"imagesNV\" + textBox_manhanvien.Text.Trim() + ".jpg");


                //string directoryPath = Path.GetDirectoryName(path);

                //if (!Directory.Exists(directoryPath))
                //{
                //    Directory.CreateDirectory(directoryPath);
                //}



                //if (string.IsNullOrEmpty(pictureBox_hinh.ImageLocation))
                //{
                //    MessageBox.Show("Please select an image to save.");
                //    return; // Exit the copying process
                //}

                //string path = Path.Combine(@"D:\Program_net\QLNV_VQT\QLNV_VQT\imagesNV\" + textBox_manhanvien.Text.Trim() + ".jpg");
                //string directoryPath = Path.GetDirectoryName(path);

                //if (!Directory.Exists(directoryPath))
                //{
                //    Directory.CreateDirectory(directoryPath);
                //}

                //try
                //{
                //    File.Copy(pictureBox_hinh.ImageLocation, path, false); // Don't overwrite by default
                //    MessageBox.Show("Image saved successfully!");
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Error saving image: " + ex.Message);
                //}


                string sql = "insert into nhanvien values ('" + textBox_manhanvien.Text + "', N'" + textBox_tennhanvien.Text
                    + "', convert (datetime,'" + dateTimePicker_ngaysinh.Text + "', 103), N'" + comboBox_gioitinh.SelectedItem.ToString() + "', N'" +
                    textBox_diachi.Text + "', '" + textBox_sdt.Text + "', '" + textBox_mail.Text + "', N'" + comboBox_phongban.SelectedValue + "', N'"
                    + comboBox_chucvu.SelectedValue + "', '" + path + "')";

                try
                {
                    int result = clCn.nonQuery(sql);
                    if (result >= 1)
                    {
                        MessageBox.Show("Thêm nhân viên thành công !!");

                        File.Copy(selectedImagePath, path, true);

                        loadDataGriV();
                        clearAll();
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
            if (textBox_tennhanvien.Text == ""
               && textBox_diachi.Text == ""
               && textBox_sdt.Text == ""
               && textBox_mail.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !!");
            }
            else
            {
                string sql = "update nhanvien set hoten=N'" + textBox_tennhanvien.Text + "', ngaysinh=convert(datetime, '" + dateTimePicker_ngaysinh.Text + "',103), gioitinh=N'" +
                comboBox_gioitinh.SelectedItem + "', diachi=N'" + textBox_diachi.Text + "', sodienthoai='" + textBox_sdt.Text + "', email='" +
                textBox_mail.Text + "', mapb=N'" + comboBox_phongban.SelectedValue + "', macv=N'" + comboBox_chucvu.SelectedValue + "' where manv='" + textBox_manhanvien + "'";

                try
                {
                    int result = clCn.nonQuery(sql);
                    if (result >= 1)
                    {
                        MessageBox.Show("Cập nhật thành công !!");
                        loadDataGriV();
                        clearAll();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void button_hinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "Chọn ảnh nhân viên";
            op.Filter = "Tất cả các file|*.*|Ảnh PNG|*.png";
            if (op.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = op.FileName;
                pictureBox_hinh.Image = Image.FromFile(selectedImagePath);
            }

            //MessageBox.Show(dateTimePicker_ngaysinh.Text);
        }

        private void dataGridView_ttnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_manhanvien.Text = dataGridView_ttnv.CurrentRow.Cells[0].Value.ToString();
            textBox_manhanvien.Enabled = false;
            textBox_tennhanvien.Text = dataGridView_ttnv.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker_ngaysinh.Text = dataGridView_ttnv.CurrentRow.Cells[2].Value.ToString();
            if (dataGridView_ttnv.CurrentRow.Cells[3].Value.ToString() == "")
            {
                comboBox_gioitinh.SelectedItem = null;
            }
            else comboBox_gioitinh.SelectedItem = dataGridView_ttnv.CurrentRow.Cells[3].Value.ToString();
            textBox_diachi.Text = dataGridView_ttnv.CurrentRow.Cells[4].Value.ToString();
            textBox_sdt.Text = dataGridView_ttnv.CurrentRow.Cells[5].Value.ToString();
            textBox_mail.Text = dataGridView_ttnv.CurrentRow.Cells[6].Value.ToString();
            comboBox_phongban.SelectedValue = dataGridView_ttnv.CurrentRow.Cells[7].Value.ToString();
            comboBox_chucvu.SelectedValue = dataGridView_ttnv.CurrentRow.Cells[8].Value.ToString();
            button_sua.Enabled = true;
            button_xoa.Enabled = true;
            button_them.Enabled = false;
            string imagePath = dataGridView_ttnv.CurrentRow.Cells[9].Value.ToString();
            try
            {
                if (imagePath == null)
                {
                    pictureBox_hinh.Image = null;

                }
                else
                {
                    pictureBox_hinh.Image = Image.FromFile(imagePath);
                    //button_hinh.Visible = false;
                }
            }
            catch (Exception)
            {
                textBox_manhanvien.Enabled = true;
                pictureBox_hinh.Image = null;
                comboBox_gioitinh.SelectedItem = null;

                button_sua.Enabled = false;
                button_xoa.Enabled = false;
                button_them.Enabled = true;
                //return;
            }

        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (textBox_manhanvien.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên để xóa !!");
            }
            else
            {
                string sql = "delete nhanvien where manv='" + textBox_manhanvien.Text + "'";
                try
                {
                    int result = clCn.nonQuery(sql);
                    if (result >= 1)
                    {
                        MessageBox.Show("Xóa nhân viên thành công !!");

                        //string delImagePath = @"D:\Program_net\QLNV_VQT\QLNV_VQT\imagesNV\" + textBox_manhanvien.Text.Trim() + ".jpg";
                        //if (File.Exists(delImagePath))
                        //{
                        //    FileStream fileStream = new FileStream(delImagePath, FileMode.Open);
                        //    // Sử dụng fileStream ở đây
                        //    fileStream.Close(); // hoặc fileStream.Dispose();

                        //    // Nếu tệp tồn tại, xóa nó
                        //    File.Delete(delImagePath);
                        //}
                        loadDataGriV();
                        clearAll();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
