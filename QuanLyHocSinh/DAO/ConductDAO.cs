using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DAO
{
    public class ConductDAO
    {
        private static ConductDAO instance;

        public static ConductDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ConductDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        ConductDAO() { }

        public DataTable GetConductStudent(string MaHocSinh, string MaHocKy, string MaNamHoc)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("usp_GetConductStudent @MaHocSinh ='" + MaHocSinh + "', @MaHocKy = '" + MaHocKy + "', @MaNamHoc ='" + MaNamHoc + "' ");

            return data;
        }
    }
}
