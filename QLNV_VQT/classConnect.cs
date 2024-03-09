using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
namespace QLNV_VQT
{
    class classConnect
    {

        SqlConnection sqlconn;

        public classConnect()
        {
            string strDB = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Program_net\QLNV_VQT\QLNV_VQT\QLNV.mdf;Integrated Security=True";
            sqlconn = new SqlConnection(strDB);
        }

        //public int nonQuery(string sql)
        //{
        //    SqlCommand cmd = new SqlCommand(sql, sqlconn);
        //    sqlconn.Open();
        //    int result = cmd.ExecuteNonQuery();
        //    sqlconn.Close();
        //    return result;
        //}

        public int nonQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            try
            {
                sqlconn.Open();
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu cần
                throw ex;
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
            }
        }


        public DataTable fillData(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, sqlconn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public object scalar(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            sqlconn.Open();
            object result = cmd.ExecuteScalar();
            sqlconn.Close();
            return result;
        }

        public object reader(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, sqlconn);
            sqlconn.Open();
            object read = cmd.ExecuteReader();
            sqlconn.Close();
            return read;
        }
    }
}
