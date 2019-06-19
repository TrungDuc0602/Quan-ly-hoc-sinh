using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DAO
{
    public class PointDAO
    {
        private static PointDAO instance;

        public static PointDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new PointDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private PointDAO() { }

        public DataTable GetTablepoint(string MaHocSinh, string MaHocKy, string MaNamHoc)
        {
            //DataTable data = DataProvider.Instance.ExecuteQuery("usp_GetStudentPoint @MaHocSinh = '" + MaHocSinh + "', @MaHocKi '" + MaHocKy + "', @MaNamHoc '" + MaNamHoc + "'");
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT D.Diem, MH.TenMonHoc, KQMH.DTBMonHoc, KQHK.DTBHK, D.MaLoai FROM DIEM D, HOC_SINH_LOP HSL, MON_HOC MH, KQ_MON_HOC KQMH, KQ_HOC_KY KQHK WHERE HSL.MaHocSinh = '" + MaHocSinh + "' AND D.MaHocKi = '" + MaHocKy + "' AND D.MaNamHoc = '" + MaNamHoc + "' AND D.MaHocSinhLop = HSL.MaHocSinhLop AND MH.MaMonHoc = D.MaMonHoc AND D.MaHocSinhLop = KQMH.MaHocSinhLop AND D.MaMonHoc = KQMH.MaMonHoc AND D.MaHocKi = KQMH.MaHocKi AND D.MaNamHoc = KQMH.MaNamHoc AND D.MaHocSinhLop = KQHK.MaHocSinhLop AND D.MaHocKi = KQHK.MaHocKi AND D.MaNamHoc = KQHK.MaNamHoc");
            //DataTable data = DataProvider.Instance.ExecuteQuery("usp_GetStudentPoint 'S017001', '1', '017'");

            return data;
        }

    }
}
