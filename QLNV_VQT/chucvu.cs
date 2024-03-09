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
    public partial class chucvu : Form
    {
        classConnect clCn = new classConnect();
        
        public chucvu()
        {
            InitializeComponent();
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            string sql = "insert into chucvu values ('" + textBox_machucvu.Text + "', N'" + textBox_tenchucvu.Text + "', N'" + textBox_machucvu.Text + "')";
            try
            {
                int result = clCn.nonQuery(sql);
                if (result >= 1)
                {
                    MessageBox.Show("Thêm chức vụ thành công !");
                    frm_dangnhap.ad.loadCV();
                    clearTextBox();
                }
                else MessageBox.Show("Thêm chức vụ thất bại");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        public void clearTextBox()
        {
            textBox_machucvu.Text = "";
            textBox_tenchucvu.Text = "";
            textBox_motachuvu.Text = "";
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
        }
        private void chucvu_Load(object sender, EventArgs e)
        {
            clearTextBox();
        }


        public void fillTextBox(string ma, string ten, string mota)
        {
            textBox_machucvu.Text = ma;
            // textBox_machucvu.Enabled = false;
            textBox_tenchucvu.Text = ten;
            textBox_motachuvu.Text = mota;
            //button_luu.Enabled = false;
            button_sua.Enabled = true;
            button_xoa.Enabled = true;
        }



        private void button_sua_Click(object sender, EventArgs e)
        {
            string sql = "update chucvu set tencv=N'" + textBox_tenchucvu.Text + "', mota=N'" + textBox_motachuvu.Text + "' where macv=" + textBox_machucvu.Text;
            try
            {
                int result = clCn.nonQuery(sql);
                if (result >= 0)
                {
                    MessageBox.Show("Cập nhật thành công !!");
                    frm_dangnhap.ad.loadCV();
                    clearTextBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            string sql = "delete chucvu where macv=" + textBox_machucvu.Text;
            try
            {
                int result = clCn.nonQuery(sql);
                if (result >= 0)
                {
                    MessageBox.Show("Xóa thành công !! ");
                    frm_dangnhap.ad.loadCV();
                    clearTextBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
    }
}


