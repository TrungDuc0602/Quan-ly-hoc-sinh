using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DAO
{
    class AdminInformationDAO
    {
        private static AdminInformationDAO instance;

        public static AdminInformationDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AdminInformationDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private AdminInformationDAO() { }

       // public DTO.AdminInformation loadAdminInformationlist(string StudentCode)
        //{
          //  DataTable data = DataProvider.Instance.ExecuteQuery("usp_GetAdminInformationByAdminCode @MaNguoiDung ='" + AdminCode + "'");

          //  DTO.AdminInformation Infor = new DTO.AdminInformation(data);

          //  return Infor;
       // }
    }
}
