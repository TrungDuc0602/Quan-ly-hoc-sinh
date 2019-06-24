using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DAO
{
    public class DataProvider
    {
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }

            private set
            {
                instance = value;
            }
        }

      private DataProvider() { }

        private string connectionSTR = @"Data Source=DESKTOP-IPHSMFJ\SQL2008;Initial Catalog=QuanLyHocSinh;Integrated Security=True";   //xác định kết nối với gì

        public DataTable ExecuteQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection); //Thực thi câu truy vấn 

                SqlDataAdapter adapter = new SqlDataAdapter(command);    //trung gian thực hiện câu truy vấn lấy dữ liệu ra 


                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }
    }
}
