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
        public string[] GetScores(string MaHocSinh, string MaHocKy, string MaNamHoc)
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

            result[i++] = data.Rows[0][3].ToString();

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

        public string[] GetScoreForTeacher(string MaHocSinh, string MaHocKy, string MaNamHoc)
        {
            string[] item = new string[20];

            DataTable data = PointDAO.Instance.GetScoreForTeacher(MaHocSinh, MaHocKy, MaNamHoc);

            for (int i = 0; i < 20; i++)
                item[i] = data.Rows[i][0].ToString();

            return item;
        }

        public void EditAllScoreStudent(string[] item, string MaHocSinhLop, string MaNamHoc, string MaHocKi)
        {
            string[] result = new string[8];
            float temp = 0;

            int j = 0;

            //lưu điểm trung bình của 5 môn học
            for (int i = 0; i < 20;)
            {
                result[j] = (1.0 * (Convert(item[i++]) + Convert(item[i++]) + Convert(item[i++]) * 2 + Convert(item[i++]) * 3) / 7).ToString();

                temp += Convert(result[j++]);
            }

            //lưu điểm trung bình học kỳ của học sinh
            result[j] = (temp / 5).ToString();

            //lưu học lực của học sinh
            if (Convert(result[j]) > 8)
                result[++j] = "G";
            else
            {
                if (Convert(result[j]) > 6.5)
                    result[++j] = "K";
                else
                {
                    if (Convert(result[j]) > 5)
                        result[++j] = "TB";
                    else
                        result[++j] = "Y";
                }
            }

            //lưu hạnh kiểm của học sinh
            if (item[item.Length - 1] == "Tốt")
                result[++j] = "T";
            else
            {
                if (item[item.Length - 1] == "Khá")
                    result[++j] = "K";
                else
                {
                    if (item[item.Length - 1] == "Trung bình")
                        result[++j] = "TB";
                    else
                        result[++j] = "Y";
                }
            }
          
            PointDAO.Instance.EditScoreStudent(item, MaHocSinhLop, MaNamHoc, MaHocKi);

            PointDAO.Instance.EditSubjectScoreStudent(result, MaHocSinhLop, MaNamHoc, MaHocKi);

            PointDAO.Instance.EditTermScoreStudent(result, MaHocSinhLop, MaNamHoc, MaHocKi);
        }

        float Convert(string str)
        {
            return float.Parse(str);
        }

        public string GetCodeClassStudent(string MaHocSinh, string MaNamHoc, string MaLop)
        {
             return PointDAO.Instance.GetCodeClassStudent(MaHocSinh, MaNamHoc, MaLop).Rows[0][0].ToString();
        }
    }
}
