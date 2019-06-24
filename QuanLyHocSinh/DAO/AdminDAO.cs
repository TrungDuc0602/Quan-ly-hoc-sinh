using QuanLyHocSinh.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DAO
{
    class AdminDAO
    {
        private static AdminDAO instance;

        public static AdminDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new AdminDAO();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        #region LoadList
        public DataTable LoadListUser()
        {
            string sql = "Select * From NGUOI_DUNG";
            var rs = DataProvider.Instance.ExecuteQuery(sql);

            return rs;
        }

        public DataTable LoadListTeacher()
        {
            string sql = "Select * From GIAO_VIEN";
            var rs = DataProvider.Instance.ExecuteQuery(sql);

            return rs;
        }

        public DataTable LoadListStudent()
        {
            string sql = "Select * From HOC_SINH";
            var rs = DataProvider.Instance.ExecuteQuery(sql);

            return rs;
        }

        public DataTable LoadListAssigned()
        {
            string sql = "Select * From PHAN_CONG";
            var rs = DataProvider.Instance.ExecuteQuery(sql);

            return rs;
        }

        public DataTable LoadListTeacherOfClass()
        {
            string sql = "Select * From GIAO_VIEN_LOP";
            var rs = DataProvider.Instance.ExecuteQuery(sql);

            return rs;
        }

        public DataTable LoadListSubjects()
        {
            string sql = "Select * From MON_HOC";
            var rs = DataProvider.Instance.ExecuteQuery(sql);

            return rs;
        }

        public DataTable LoadListClass()
        {
            string sql = "Select * From LOP";
            var rs = DataProvider.Instance.ExecuteQuery(sql);

            return rs;
        }

        public DataTable LoadListYear()
        {
            string sql = "Select * From NAM_HOC";
            var rs = DataProvider.Instance.ExecuteQuery(sql);

            return rs;
        }

        #endregion

        #region Account
        public void AdNewUser(string MaNguoiDung, string MatKhau)
        {

            DataProvider.Instance.ExecuteQuery("usp_AddAccount @MaNguoiDung = '" + MaNguoiDung + "', @MatKhau ='" + MatKhau + "'  ");

        }

        public void EditUser(string MaNguoiDung, string MatKhau)
        {

            DataProvider.Instance.ExecuteQuery("usp_EditAccount @MaNguoiDung = '" + MaNguoiDung + "', @MatKhau ='" + MatKhau + "'  ");

        }

        public void DeleteUser(string MaNguoiDung)
        {
            DataProvider.Instance.ExecuteQuery("usp_DeleteAccount @MaNguoiDung = '" + MaNguoiDung + "'  ");
        }

        #endregion

        #region Teacher

        public void SaveTaecher(string MaGiaoVien, string HoTen, bool GioiTinh, DateTime NgaySinh, string NoiSinh, string DiaChi, string DienThoai)
        {

            DataProvider.Instance.ExecuteQuery("usp_AddTeacher @MaGiaoVien = '" + MaGiaoVien + "', @HoTen =N'" + HoTen + "', @GioiTinh ='" + GioiTinh + "', @NgaySinh ='" + NgaySinh + "' , @NoiSinh =N'" + NoiSinh + "' , @DiaChi =N'" + DiaChi + "', @DienThoai ='" + DienThoai + "' ");
            string mk = "1";
            AdNewUser(MaGiaoVien, mk);
        }

        public void EditTeacher(string MaGiaoVien, string HoTen, bool GioiTinh, DateTime NgaySinh, string NoiSinh, string DiaChi, string DienThoai)
        {
            DataProvider.Instance.ExecuteQuery("usp_UpdateTeacher @MaGiaoVien = '" + MaGiaoVien + "', @HoTen =N'" + HoTen + "', @GioiTinh ='" + GioiTinh + "', @NgaySinh ='" + NgaySinh + "' , @NoiSinh =N'" + NoiSinh + "' , @DiaChi =N'" + DiaChi + "', @DienThoai ='" + DienThoai + "' ");
        }

        public void DeleteTeacher(string MaGiaoVien)
        {

            DataProvider.Instance.ExecuteQuery("usp_DeleteTeacher @MaGiaoVien = '" + MaGiaoVien + "'  ");
        }

        #endregion

        #region Strudent
        public void SaveInfor(string MaHocSinh, string HoTen, bool GioiTinh, DateTime NgaySinh, string QueQuan, string DiaChi, string DanToc, string TonGiao, string NguoiThan)
        {
            DataProvider.Instance.ExecuteQuery("usp_AddStudentAm @MaHocSinh = '" + MaHocSinh + "', @HoTen =N'" + HoTen + "', @GioiTinh ='" + GioiTinh + "', @NgaySinh ='" + NgaySinh + "', @QueQuan =N'" + QueQuan + "', @DiaChi =N'" + DiaChi + "', @DanToc =N'" + DanToc + "', @TonGiao =N'" + TonGiao + "', @NguoiThan =N'" + NguoiThan + "'  ");
        }

        public void DeleteInforS(string MaHocSinh)
        {
            DataProvider.Instance.ExecuteQuery("usp_DeleteStudnetAm @MaHocSinh = '" + MaHocSinh + "' ");
        }

        #endregion

        #region Assigned

        public void SaveAssigned(string MaPhanCong, string MaGiaoVienLop, string MaMonHoc)
        {

            DataProvider.Instance.ExecuteQuery("usp_AddAssigned @MaPhanCong = '" + MaPhanCong + "', @MaGiaoVienLop ='" + MaGiaoVienLop + "',@MaMonHoc ='" + MaMonHoc + "'  ");

        }

        public void EditAssigned(string MaPhanCong, string MaGiaoVienLop, string MaMonHoc)
        {

            DataProvider.Instance.ExecuteQuery("usp_EditAssigned @MaPhanCong = '" + MaPhanCong + "', @MaGiaoVienLop ='" + MaGiaoVienLop + "',@MaMonHoc ='" + MaMonHoc + "'  ");

        }

        public void DeleteAssigned(string MaPhanCong)
        {
            DataProvider.Instance.ExecuteQuery("usp_DeleteAssigned @MaPhanCong = '" + MaPhanCong + "'  ");
        }

        #endregion

        #region Teacher Of Class

        public void SaveTaecherOfClass(string MaGiaoVienLop, string MaGiaoVien, string MaLop, string MaNamHoc)
        {
            DataProvider.Instance.ExecuteQuery("usp_AddTeacherOfStudent @MaGiaoVienLop = '" + MaGiaoVienLop + "', @MaGiaoVien ='" + MaGiaoVien + "' , @MaLop ='" + MaLop + "', @MaNamHoc ='" + MaNamHoc + "' ");

        }

        public void EditTeacherOfClass(string MaGiaoVienLop, string MaGiaoVien, string MaLop, string MaNamHoc)
        {
            DataProvider.Instance.ExecuteQuery("usp_UpdateTeacherOfClass @MaGiaoVienLop = '" + MaGiaoVienLop + "', @MaGiaoVien ='" + MaGiaoVien + "' , @MaLop ='" + MaLop + "', @MaNamHoc ='" + MaNamHoc + "' ");
        }

        public void DeleteTeacherOfClass(string MaGiaoVienLop)
        {
            DataProvider.Instance.ExecuteQuery("usp_DeleteTeacherOfClass @MaGiaoVienLop = '" + MaGiaoVienLop + "'  ");
        }

        #endregion
    }
}
