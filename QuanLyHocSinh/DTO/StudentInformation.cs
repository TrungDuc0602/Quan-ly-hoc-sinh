

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DTO
{
    class StudentInformation
    {
        private string maHocSinh;
        public string MaHocSinh
        {
            get
            {
                return maHocSinh;
            }

            set
            {
                maHocSinh = value;
            }
        }

        private string hoTen;
        public string HoTen
        {
            get
            {
                return hoTen;
            }

            set
            {
                hoTen = value;
            }
        }

        private bool gioiTinh;
        public bool GioiTinh
        {
            get
            {
                return gioiTinh;
            }

            set
            {
                gioiTinh = value;
            }
        }

        private DateTime ngaySinh;
        public DateTime NgaySinh
        {
            get
            {
                return ngaySinh;
            }

            set
            {
                ngaySinh = value;
            }
        }

        private string noiSinh;
        public string NoiSinh
        {
            get
            {
                return noiSinh;
            }

            set
            {
                noiSinh = value;
            }
        }

        private string diaChi;
        public string DiaChi
        {
            get
            {
                return diaChi;
            }

            set
            {
                diaChi = value;
            }
        }

        private string maDanToc;
        public string MaDanToc
        {
            get
            {
                return maDanToc;
            }

            set
            {
                maDanToc = value;
            }
        }

        private string maTonGiao;
        public string MaTonGiao
        {
            get
            {
                return maTonGiao;
            }

            set
            {
                maTonGiao = value;
            }
        }

        private string tenNguoiThan;
        public string TenNguoiThan
        {
            get
            {
                return tenNguoiThan;
            }

            set
            {
                tenNguoiThan = value;
            }
        }

        public StudentInformation(DataTable data)
        {
            this.MaHocSinh= data.Rows[0].ItemArray[0].ToString();
            this.HoTen = data.Rows[0].ItemArray[1].ToString();
            this.GioiTinh = (bool)data.Rows[0][2];
            this.NgaySinh = (DateTime)data.Rows[0][3];
            this.NoiSinh = data.Rows[0].ItemArray[4].ToString();
            this.DiaChi = data.Rows[0].ItemArray[5].ToString();
            this.MaDanToc = data.Rows[0].ItemArray[6].ToString();
            this.MaTonGiao = data.Rows[0].ItemArray[7].ToString();
            this.TenNguoiThan = data.Rows[0].ItemArray[8].ToString();
        }
    }
}
