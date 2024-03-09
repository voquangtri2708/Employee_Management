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
    public partial class frm_admin : Form
    {

        classConnect clCn = new classConnect();
        public static string ma { get; set; }
        public static string ten { get; set; }
        public static string mota { get; set; }
        //public static qlyDangNhap qldn;
        //public static string tendangnhap { get; set; }
        //public static string tennguoidung { get; set; }
        //public static string matkhau { get; set; }
        //public static int trangthai { get; set; }
        public frm_admin()
        {
            InitializeComponent();
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["phongban"] == null)
            {
                if (Application.OpenForms["chucvu"] != null)
                {
                    Application.OpenForms["chucvu"].Close();
                }
                if (Application.OpenForms["qlyDangNhap"] != null)
                {
                    Application.OpenForms["qlyDangNhap"].Close();
                }

                phongban pb = new phongban();
                pb.MdiParent = this;
                pb.clearTextBox();
                pb.Dock = DockStyle.Fill;
                pb.Show();
            }
            else
            {
                Application.OpenForms["phongban"].Activate();
            }
            //fillGridV();
            loadPB();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["chuvu"] == null)
            {
                if (Application.OpenForms["phongban"] != null)
                {
                    Application.OpenForms["phongban"].Close();
                }
                if (Application.OpenForms["qlyDangNhap"] != null)
                {
                    Application.OpenForms["qlyDangNhap"].Close();
                }

                chucvu cv = new chucvu();
                cv.MdiParent = this;
                cv.clearTextBox();
                cv.Dock = DockStyle.Fill;
                cv.Show();

            }
            else
            {
                Application.OpenForms["chucvu"].Activate();
            }
            //fillGridV();
            loadCV();

        }

        private void button_QL_Click(object sender, EventArgs e)
        {
            //frm_QLNhanVien ql = new frm_QLNhanVien();
            //this.Hide();
            frm_dangnhap.ql.Show();
            //ql.Show();
        }

        public void loadPB()
        {
            string sql = "select *from phongban";
            try
            {
                //dataGridView_PBCV.DataSource = clCn.fillData(sql);
                gridV(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void loadCV()
        {
            string sql = "select *from chucvu";
            try
            {
                //dataGridView_PBCV.DataSource = clCn.fillData(sql);
                gridV(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //public void dataGridView_PBCV_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    ma = dataGridView_PBCV.CurrentRow.Cells[0].Value.ToString();
        //    ten = dataGridView_PBCV.CurrentRow.Cells[1].Value.ToString();
        //    mota = dataGridView_PBCV.CurrentRow.Cells[2].Value.ToString();

        //    if (Application.OpenForms["chuvu"] != null)
        //    {
        //        chucvu cv = new chucvu();
        //        cv.fillTextBox(ma, ten, mota);
        //    }
        //    else
        //    {
        //        phongban pb = new phongban();
        //        pb.fillTextBox(ma, ten, mota);
        //    }
        //}

        public void dataGridView_PBCV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ma = dataGridView_PBCV.CurrentRow.Cells[0].Value.ToString();
            ten = dataGridView_PBCV.CurrentRow.Cells[1].Value.ToString();
            mota = dataGridView_PBCV.CurrentRow.Cells[2].Value.ToString();

            // Kiểm tra xem có bất kỳ form nào đang mở hay không
            Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
            foreach (Form form in forms)
            {
                if (form is chucvu || form is phongban || form is qlyDangNhap)
                {
                    if (form is chucvu)
                    {
                        try
                        {
                            chucvu cv = (chucvu)form;
                            cv.fillTextBox(ma, ten, mota);
                        }
                        catch (Exception)
                        {
                            chucvu cv = (chucvu)form;
                            cv.clearTextBox();
                        }

                    }
                    else if (form is phongban)
                    {
                        try
                        {
                            phongban pb = (phongban)form;
                            pb.fillTextBox(ma, ten, mota);
                        }
                        catch (Exception)
                        {
                            phongban pb = (phongban)form;
                            pb.clearTextBox();
                        }

                    }
                    else if (form is qlyDangNhap)
                    {
                        try
                        {
                            string tendangnhap = dataGridView_PBCV.CurrentRow.Cells[0].Value.ToString();
                            string tennguoidung = dataGridView_PBCV.CurrentRow.Cells[1].Value.ToString();
                            string matkhau = dataGridView_PBCV.CurrentRow.Cells[2].Value.ToString();
                            int trangthai = (int)dataGridView_PBCV.CurrentRow.Cells[3].Value;

                            qlyDangNhap qldn = (qlyDangNhap)form;
                            qldn.fillTextBox(tendangnhap, tennguoidung, matkhau, trangthai);
                        }
                        catch (Exception)
                        {
                            qlyDangNhap qldn = (qlyDangNhap)form;
                            qldn.clearTextBox();
                        }

                    }
                    //return; // Đảm bảo chỉ gọi fillTextBox trên một form duy nhất
                }
            }

        }


        //public void fillGridV()
        //{
        //    Form[] forms = Application.OpenForms.Cast<Form>().ToArray();
        //    foreach (Form form in forms)
        //    {
        //        if (form is chucvu || form is phongban)
        //        {
        //            if (form is chucvu)
        //            {
        //                string sql = "select *from chucvu";
        //                try
        //                {
        //                    dataGridView_PBCV.DataSource = clCn.fillData(sql);
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show(ex.ToString());
        //                }
        //            }
        //            else if (form is phongban)
        //            {
        //                string sql = "select *from phongban";
        //                try
        //                {
        //                    dataGridView_PBCV.DataSource = clCn.fillData(sql);
        //                }
        //                catch (Exception ex)
        //                {
        //                    MessageBox.Show(ex.ToString());
        //                }
        //            }
        //            return; 
        //        }
        //    }
        //}

        public void gridV(string sql)
        {
            dataGridView_PBCV.DataSource = clCn.fillData(sql);
        }

        public void loadDN()
        {
            string sql = "select * from dangnhap";
            try
            {
                dataGridView_PBCV.DataSource = clCn.fillData(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }

        private void button_QLdangNhap_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["phongban"] != null)
            {
                Application.OpenForms["phongban"].Close();
            }
            if (Application.OpenForms["chucvu"] != null)
            {
                Application.OpenForms["chucvu"].Close();
            }
            qlyDangNhap qldn = new qlyDangNhap();
            qldn.MdiParent = this;
            //cv.clearTextBox();
            qldn.Dock = DockStyle.Fill;
            qldn.Show();
            loadDN();

        }

        private void frm_admin_Load(object sender, EventArgs e)
        {

        }
    }
}
