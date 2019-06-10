using QuanLyHocSinh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DAO
{
    class StudentInformationDAO
    {
        private static StudentInformationDAO instance;

        public static StudentInformationDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new StudentInformationDAO();
                return instance;
            }

           private set
            {
                instance = value;
            }
        }

        private StudentInformationDAO() { }

        public StudentInformation loadStudentInformationlist(string StudentCode)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("usp_GetStudentInformationByStudentCode @MaHocSinh ='" + StudentCode + "'");

            StudentInformation Infor = new StudentInformation(data);

            return Infor;
        }
    }
}
