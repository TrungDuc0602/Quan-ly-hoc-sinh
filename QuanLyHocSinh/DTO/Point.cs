using QuanLyHocSinh.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHocSinh.DTO
{
    public class Point
    {
        public string[] GetScores(string MaHocSinh,string MaHocKy,string MaNamHoc)
        {
            DataTable data = PointDAO.Instance.GetTablepoint(MaHocSinh, MaHocKy, MaNamHoc);
            int temp = data.Rows.Count;
            temp = temp / 4 * 6 + 1;

            /*
             - Sử dụng mảng result để lưu điểm
             - Thứ tự lần lượt lưu của result là:
                + result[0] lưu điểm trung bình học kỳ đó
                + result[1] lưu tên môn học
                + result[2] lưu điểm trung bình môn học đó
                + result[3] lưu điểm kiểm tra miệng
                + result[4] lưu điểm kiểm tra 15p
                + result[5] lưu điểm kiểm tra 1 tiết
                + result[6] lưu điểm kiểm tra học kỳ
            => Lặp lại các phần tử này ta sẽ được một mảng lưu điểm của học sinh truyền vô
            */

            string[] result = new string[temp];

            int i = 0, j = 0;

            result[i++]= data.Rows[0][3].ToString();

            while (i < temp)
            {
                result[i++] = data.Rows[j][1].ToString();   //lưu tên môn học
                result[i++] = data.Rows[j][2].ToString();   //lưu điểm trung bình môn học
                result[i++] = data.Rows[j++][0].ToString();   //lưu điểm kiểm tra miệng
                result[i++] = data.Rows[j++][0].ToString();   //lưu điểm kiểm tra 15p
                result[i++] = data.Rows[j++][0].ToString();   //lưu điểm kiểm tra 1 tiết
                result[i++] = data.Rows[j++][0].ToString();   //lưu điểm kiểm tra học kỳ
            }

            return result;
        }
    }
}
