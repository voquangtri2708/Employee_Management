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
    public partial class phongban : Form
    {
        classConnect clCn = new classConnect();
        //frm_admin ad = new frm_admin();
        public phongban()
        {
            InitializeComponent();
        }

        private void button_luu_Click(object sender, EventArgs e)
        {
            string sql = "insert into phongban values ('" + textBox_maphongban.Text + "', N'" + textBox_tenphongban.Text + "', N'" + textBox_motaphongban.Text + "')";

            try
            {
                int result = clCn.nonQuery(sql);
                if (result >= 1)
                {
                    MessageBox.Show("Thêm phòng ban thành công !");
                    //loadDataGridV();
                    frm_dangnhap.ad.loadPB();
                    clearTextBox();
                }
                else MessageBox.Show("Thêm phòng ban thất bại !!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //finally
            //{

            //}


        }

        public void fillTextBox(string ma, string ten, string mota)
        {
            textBox_maphongban.Text = ma;
            //textBox_maphongban.Enabled = false;
            textBox_tenphongban.Text = ten;
            textBox_motaphongban.Text = mota;
            //button_luu.Enabled = false;
            button_sua.Enabled = true;
            button_xoa.Enabled = true;
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            string sql = "update phongban set tenpb=N'" + textBox_tenphongban.Text + "', mota=N'" + textBox_motaphongban.Text + "' where mapb=" + textBox_maphongban.Text;
            try
            {
                int result = clCn.nonQuery(sql);
                if (result >= 0)
                {
                    MessageBox.Show("Cập nhật thành công !!");
                    //loadDataGridV();
                    frm_dangnhap.ad.loadPB();
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
            string sql = "delete phongban where mapb=" + textBox_maphongban.Text;
            try
            {
                int result = clCn.nonQuery(sql);
                if (result >= 1)
                {
                    MessageBox.Show("Xóa thành công !! ");
                    //loadDataGridV();
                    frm_dangnhap.ad.loadPB();
                    clearTextBox();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        //public void loadDataGridV()
        //{

        //    string sql = "select * from phongban";
        //    try
        //    {
        //        frm_admin ad = new frm_admin();
        //        ad.gridV(sql);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        public void clearTextBox()
        {
            textBox_maphongban.Text = "";
            textBox_tenphongban.Text = "";
            textBox_motaphongban.Text = "";

            //button_luu.Enabled = true;
            button_sua.Enabled = false;
            button_xoa.Enabled = false;
        }

        private void phongban_Load(object sender, EventArgs e)
        {
            clearTextBox();
        }
    }
}
