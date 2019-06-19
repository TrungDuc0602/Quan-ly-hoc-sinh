using QuanLyHocSinh.DAO;
using QuanLyHocSinh.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class fTableManager : Form
    {
        public fTableManager(string str_Value)      //str_value là Mã học sinh được đưa từ fLogin qua
        {
            InitializeComponent();        

            loadStudentInformation(str_Value);
          
        }

        void loadStudentInformation(string StudentCode)
        {
            StudentInformation item = StudentInformationDAO.Instance.loadStudentInformationlist(StudentCode);

            this.txbDisplayNameStudent.Text = item.HoTen;

            txbCodeStudent.AppendText(item.MaHocSinh);

            txbName.AppendText(item.HoTen);

            if (item.GioiTinh)
                ckbMale.Checked = true;
            else
                ckbFemale.Checked = true;

            DateTime d = item.NgaySinh;
            txbDateBorn.AppendText(d.ToString("dd/MM/yyyy"));

            this.txbNativeBorn.AppendText(item.NoiSinh);

            this.txbAddress.AppendText(item.DiaChi);

            this.txbNation.AppendText(item.MaDanToc);

            this.txbReligion.AppendText(item.MaTonGiao);

            this.txbParentName.AppendText(item.TenNguoiThan);

        }

        void DisplayPoint(string MaHocSinh)
        {
            lvShowPoint.Items.Clear();

            string MaHocKy = cbbChoseTerm.SelectedItem.ToString();

            string MaNamHoc = null;

            if (cbbChoseSchoolYear.SelectedItem.ToString() == "2016-2017")
                MaNamHoc = "017";
            else
            {
                if (cbbChoseSchoolYear.SelectedItem.ToString() == "2017-2018")
                    MaNamHoc = "018";
                else
                    MaNamHoc = "019";
            }

            DTO.Point z = new DTO.Point();

            string [] item = z.GetScores(MaHocSinh, MaHocKy, MaNamHoc);

            for (int i = 1; i < item.Length; i++)
            {
                ListViewItem lvItem = new ListViewItem(item[i++]);
                lvItem.SubItems.Add(item[i++]);
                lvItem.SubItems.Add(item[i++]);
                lvItem.SubItems.Add(item[i++]);
                lvItem.SubItems.Add(item[i++]);
                lvItem.SubItems.Add(item[i]);

                lvShowPoint.Items.Add(lvItem);
            }

            ListViewItem lvItem1 = new ListViewItem();
            lvShowPoint.Items.Add(lvItem1);

            ListViewItem lvItem2 = new ListViewItem("Điểm trung bình học kỳ");
            lvItem2.SubItems.Add(item[0]);
            lvShowPoint.Items.Add(lvItem2);

        }

        private void btnChose_Click(object sender, EventArgs e)
        {
            string str_Value = txbCodeStudent.Text;

           DisplayPoint(str_Value);
        }


        #region Event
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEditInformation_Click(object sender, EventArgs e)
        {
            fEditInformation f = new fEditInformation(txbCodeStudent.Text);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        #endregion

        #region TrashVoid
        private void tIn_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbDisplayNameStudent_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel13_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void txbDisplayNameStudent_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
