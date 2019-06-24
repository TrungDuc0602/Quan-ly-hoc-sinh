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

        public DataTable GetScoreForTeacher(string MaHocSinh, string MaHocKy, string MaNamHoc)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("usp_GetScoreStudentForTeacher @MaHocSinh ='" + MaHocSinh + "', @MaNamHoc ='" + MaNamHoc + "', @MaHocKy = '" + MaHocKy + "' ");

            return data;
        }

        public DataTable EditScoreStudent(string[] item, string MaHocSinhLop, string MaNamHoc, string MaHocKi)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(" usp_EditScoreStudent @MaHocSinhLop = '"+ MaHocSinhLop +"', @MaNamHoc = '"+ MaNamHoc +"', @HocKi = '"+ MaHocKi +"', @TOMieng = '"+ item[0] +"', @TO15p = '" + item[1] + "', @TO1T = '" + item[2] + "', @TOHK = '" + item[3] + "', @HOMieng = '" + item[4] + "', @HO15p = '" + item[5] + "', @HO1T = '" + item[6] + "', @HOHK = '" + item[7] + "', @TAMieng = '" + item[8] + "', @TA15p = '" + item[9] + "', @TA1T = '" + item[10] + "', @TAHK = '" + item[11] + "', @LIMieng = '" + item[12] + "', @LI15p = '" + item[13] + "', @LI1T = '" + item[14] + "', @LIHK = '" + item[15] + "', @VAMieng = '" + item[16] + "', @VA15p = '" + item[17] + "', @VA1T = '" + item[18] + "', @VAHK  = '" + item[19] + "'  ");

            return data;
        }

        public DataTable EditTermScoreStudent(string[] result, string MaHocSinhLop, string MaNamHoc, string MaHocKi)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(" usp_EditTermScoreStudent @MaHocSinhLop = '"+ MaHocSinhLop +"', @MaNamHoc = '"+ MaNamHoc +"', @MaHocKi = '"+ MaHocKi +"', @Score = '"+ result[5] +"', @MaHocLuc = '"+ result[6] +"', @MaHanhKiem = '"+ result[7] +"' ");

            return data;
        }

        public DataTable EditSubjectScoreStudent(string[] result, string MaHocSinhLop, string MaNamHoc, string MaHocKi)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(" usp_EditSubjectScoreStudent @MaHocSinhLop = '"+ MaHocSinhLop +"', @MaNamHoc = '"+ MaNamHoc +"', @MaHocKi = '"+ MaHocKi +"', @TO = '"+ result[0] +"', @HO = '"+ result[1] +"', @TA = '"+ result[2] +"', @LI = '"+ result[3] +"', @VA = '"+ result[4] +"' ");

            return data;
        }

        public DataTable GetCodeClassStudent(string MaHocSinh, string MaNamHoc, string MaLop)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery(" usp_GetCodeStudent @MaHocSinh ='"+ MaHocSinh +"', @MaNamHoc = '"+ MaNamHoc +"', @MaLop = '"+ MaLop +"' ");

            return data;
        }
    }
}
