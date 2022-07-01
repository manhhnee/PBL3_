using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class DataProvider
    {
        public static DataProvider _instance;
        public static DataProvider Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DataProvider();
                return _instance;
            }
        }

        private string strConn = @"Data Source=DESKTOP-8622U14;Initial Catalog=QuanLyQuanCaPhe;Integrated Security=True";
        
        public DataTable ExecuteQuery(string query, object[] parameter = null) //Trả về dữ liệu của bảng
        {
            DataTable data = new DataTable();
            //giải phóng bộ nhớ 
            using (SqlConnection conn = new SqlConnection(strConn)) //Kết nối từ client-server
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn); //câu truy vấn thực thi
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd); //trung gian lấy giữ liệu 
                dataAdapter.Fill(data);
                conn.Close();
            }
            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null) // trả về số row chạy thành công  
        {
            int row = 0;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string para in listPara)
                    {
                        if (para.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }   
                row = cmd.ExecuteNonQuery();
                conn.Close();
            }
            return row;
        }
        
        public object ExecuteScalar(string query, object[] parameter = null) //Trả về ô đầu tiên trong bảng kết quả
        {
            object data = 0;
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                if(parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach(string para in listPara)
                    {
                        if(para.Contains('@'))
                        {
                            cmd.Parameters.AddWithValue(para, parameter[i]);
                            i++;
                        }
                    }
                }
                data = cmd.ExecuteScalar();
                conn.Close();
            }
            return data;
        }
    }
}
