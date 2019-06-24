using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DTO
{
    class AdminInformation
    {
        private string maNguoiDung;
        public string MaNguoiDung
        {
            get
            {
                return maNguoiDung;
            }

            set
            {
                maNguoiDung = value;
            }
        }

        private string matKhau;
        public string MatKhau
        {
            get
            {
                return matKhau;
            }

            set
            {
                matKhau = value;
            }
        }




        public AdminInformation(DataTable data)
        {
            this.MaNguoiDung = data.Rows[0].ItemArray[0].ToString();
            this.MatKhau = data.Rows[0].ItemArray[1].ToString();

        }
    }
}
