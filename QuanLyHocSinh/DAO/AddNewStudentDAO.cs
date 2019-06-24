using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DAO
{
    public class AddNewStudentDAO
    {
        private static AddNewStudentDAO instance;

        public static AddNewStudentDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AddNewStudentDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        AddNewStudentDAO() { }

        public void NewStudent(string Name, string ClassStudent, string Academic, string Term)
        {
            string ClassCodeStudent = AutoCodeClassStudent(Academic);

            string StudentCode = AutoCodeStudent(Academic);

            DataTable data = DataProvider.Instance.ExecuteQuery("usp_AddNewStudent @TenHocSinh =N'" + Name + "', @MaHocSinh ='" + StudentCode + "', @TenLop ='" + ClassStudent + "', @MaHocSinhLop = N'" + ClassCodeStudent + "', @MaNamHoc=N'" + Academic + "', @MaHocKy=N'" + Term + "'");
        }

        string AutoCodeStudent(string Academic)
        {
            DataTable temp = DataProvider.Instance.ExecuteQuery(" usp_GetCodeStu @MaLop = 'K12A1', @MaNamHoc = '" + Academic + "' ");
            string Code = temp.Rows[0][0].ToString();
            int a = int.Parse(Code[6].ToString());
            a += 1;
            return Code.Replace(Code[6].ToString(), a.ToString());
        }

        string AutoCodeClassStudent(string Academic)
        {
            DataTable temp = DataProvider.Instance.ExecuteQuery(" usp_GetClassStu @MaLop = 'K12A1', @MaNamHoc = '" + Academic + "' ");
            string Code = temp.Rows[0][0].ToString();
            int a = int.Parse(Code[6].ToString());
            a += 1;
            return Code.Replace(Code[6].ToString(), a.ToString());
        }
    }
}
