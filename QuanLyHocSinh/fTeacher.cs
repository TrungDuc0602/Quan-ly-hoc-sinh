using QuanLyHocSinh.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class fTeacher : Form
    {
        public fTeacher(string str_Value)
        {
            InitializeComponent();
        }

        void AddNewStudent(string  Name, string ClassStudent, string Academic, string Term)
        {
            AddNewStudentDAO.Instance.NewStudent(Name, ClassStudent, Academic, Term);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        string GetAcademic()
        {
            string Academic;

            if (cbbAcademic.Text == "2016 - 2017")
                Academic = "017";
            else
            {
                if (cbbAcademic.Text == "2017 - 2018")
                    Academic = "018";
                else
                    Academic = "019";
            }

            return Academic;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Term = cbbTerm.Text;

            string Name = txbNameStudent.Text;

            string ClassStudent = cbbClassStudent.Text;

            AddNewStudent(Name, ClassStudent, GetAcademic(), Term);

            MessageBox.Show("Thêm học sinh thành công", "Thông báo");
        }

        void LoadListStudent(string ClassName, string Academic)
        {
            DataTable data=StudentInformationDAO.Instance.LoadListStudent(ClassName, Academic);
            int i = data.Rows.Count;
            dtgrvStudent.DataSource = data;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ClassName = cbbClassStudent.Text;

            LoadListStudent(ClassName, GetAcademic());

            AddStudentBinding(GetAcademic());

            GetScoreForTeacher(txbCodeStudent.Text, cbbTerm.Text, GetAcademic());
            cbbConduct.Text = ConductDAO.Instance.GetConductStudent(txbCodeStudent.Text, cbbTerm.Text, GetAcademic()).Rows[0][0].ToString();
        }

        void AddStudentBinding(string Academic)
        {
            txbNameStudent.DataBindings.Add(new Binding("Text", dtgrvStudent.DataSource, "Họ tên học sinh"));

            txbCodeStudent.DataBindings.Add(new Binding("Text", dtgrvStudent.DataSource, "Mã học sinh"));

            GetScoreForTeacher(txbCodeStudent.Text, cbbTerm.Text, Academic);
        }

        void GetScoreForTeacher(string MaHocSinh, string MaHocKy, string MaNamHoc)
        {
            DTO.Point temp = new DTO.Point();

            string[] item = temp.GetScoreForTeacher(MaHocSinh, MaHocKy, MaNamHoc);

            tbMath1.Text = item[0];
            tbMath2.Text = item[1];
            tbMath3.Text = item[2];
            tbMath4.Text = item[3];

            tbChem1.Text = item[4];
            tbChem2.Text = item[5];
            tbChem3.Text = item[6];
            tbChem4.Text = item[7];

            tbEng1.Text = item[8];
            tbEng2.Text = item[9];
            tbEng3.Text = item[10];
            tbEng4.Text = item[11];

            tbPhy1.Text = item[12];
            tbPhy2.Text = item[13];
            tbPhy3.Text = item[14];
            tbPhy4.Text = item[15];

            tbPhi1.Text = item[16];
            tbPhi2.Text = item[17];
            tbPhi3.Text = item[18];
            tbPhi4.Text = item[19];

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
       

        private void btEdit_Click(object sender, EventArgs e)
        {
            string[] item = new string[21];

            int i = 0;

            item[i++] = tbMath1.Text;
            item[i++] = tbMath2.Text;
            item[i++] = tbMath3.Text;
            item[i++] = tbMath4.Text;

            item[i++] = tbChem1.Text;
            item[i++] = tbChem2.Text;
            item[i++] = tbChem3.Text;
            item[i++] = tbChem4.Text;

            item[i++] = tbEng1.Text;
            item[i++] = tbEng2.Text;
            item[i++] = tbEng3.Text;
            item[i++] = tbEng4.Text;

            item[i++] = tbPhy1.Text;
            item[i++] = tbPhy2.Text;
            item[i++] = tbPhy3.Text;
            item[i++] = tbPhy4.Text;

            item[i++] = tbPhi1.Text;
            item[i++] = tbPhi2.Text;
            item[i++] = tbPhi3.Text;
            item[i++] = tbPhi4.Text;

            item[i] = cbbConduct.Text;

            EditScoreStudent(item);
        }

        void EditScoreStudent(string[] item)
        {
            DTO.Point z = new DTO.Point() ;

            string CodeClass = z.GetCodeClassStudent(txbCodeStudent.Text, GetAcademic(), "K12A1");

            z.EditAllScoreStudent(item, CodeClass, GetAcademic(), cbbTerm.Text);
        }

        private void dtgrvStudent_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            GetScoreForTeacher(txbCodeStudent.Text, cbbTerm.Text, GetAcademic());
        }
    }
}
