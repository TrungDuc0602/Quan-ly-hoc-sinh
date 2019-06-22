using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DAO
{
    public class UpdateInforDAO
    {
        private static UpdateInforDAO instance;

        public static UpdateInforDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new UpdateInforDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private UpdateInforDAO() { }

        public void UpdateInfor(string MaHocSinh, string HoTen, bool GioiTinh, DateTime NgaySinh, string QueQuan, string DiaChi, string DanToc, string TonGiao, string NguoiThan)
        {
            DataProvider.Instance.ExecuteQuery("usp_UpdateStudentInformation @MaHocSinh = '" + MaHocSinh + "', @HoTen =N'" + HoTen + "', @GioiTinh ='" + GioiTinh + "', @NgaySinh ='" + NgaySinh + "', @QueQuan =N'" + QueQuan + "', @DiaChi =N'" + DiaChi + "', @DanToc =N'" + DanToc + "', @TonGiao =N'" + TonGiao + "', @NguoiThan =N'" + NguoiThan + "'  ");
        }
    }
}
