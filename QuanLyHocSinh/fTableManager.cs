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
        public fTableManager(string str_Value)
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
            fEditInformation f = new fEditInformation();
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
