using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AccountDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private AccountDAO() { }

        public bool login(string username, string password)
        {
            string query = "SELECT * FROM NGUOI_DUNG WHERE MaNguoiDung = '" + username + "' AND MatKhau = '" + password + "'";

            DataTable resutl = DataProvider.Instance.ExecuteQuery(query);

            return resutl.Rows.Count > 0;
        }

        public string getUtype(string username)
        {
            string query = "SELECT * FROM NGUOI_DUNG WHERE MaNguoiDung = '" + username + "'";

            DataTable resutl = DataProvider.Instance.ExecuteQuery(query);

            return resutl.Rows[0][2].ToString();
        }
    }
}
