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
    public partial class AdTableManager : Form
    {
       
        public AdTableManager(string text)
        {
            InitializeComponent();
            this.txbDisplayNameNguoiDung.Text = text;
            LoadListUser();
            LoadListTeacher();
            LoadListStudent();
            LoadListAssigned();
            LoadListTeacherOfClass();
        }

        #region Loađata
        private void LoadListUser()
        {
            var tb = AdminDAO.Instance.LoadListUser();
            dataManagerUser.DataSource = tb;
        }

        private void LoadListTeacher()
        {
            var tb = AdminDAO.Instance.LoadListTeacher();
            dataManagerTeacher.DataSource = tb;
        }

        private void LoadListStudent()
        {
            var tb = AdminDAO.Instance.LoadListStudent();
            dataManagerStudent.DataSource = tb;
        }

        private void LoadListAssigned()
        {
            var tb = AdminDAO.Instance.LoadListAssigned();
            datAassigned.DataSource = tb;

            var gvl = AdminDAO.Instance.LoadListTeacherOfClass();
            comboMGV.DataSource = gvl;
            comboMGV.ValueMember = "MaGiaoVienLop";
            comboMGV.DisplayMember = "MaGiaoVien";

            var mh = AdminDAO.Instance.LoadListSubjects();
            comboMMH.DataSource = mh;
            comboMMH.ValueMember = "MaMonHoc";
            comboMMH.DisplayMember = "TenMonHoc";
        }

        private void LoadListTeacherOfClass()
        {
            var tb = AdminDAO.Instance.LoadListTeacherOfClass();
            dataGVL.DataSource = tb;

            var gv = AdminDAO.Instance.LoadListTeacher();
            cbxMGV.DataSource = gv;
            cbxMGV.ValueMember = "MaGiaoVien";
            cbxMGV.DisplayMember = "HoTen";

            var l = AdminDAO.Instance.LoadListClass();
            cbxML.DataSource = l;
            cbxML.ValueMember = "MaLop";
            cbxML.DisplayMember = "TenLop";

            var nh = AdminDAO.Instance.LoadListYear();
            cbxMNH.DataSource = nh;
            cbxMNH.ValueMember = "MaNamHoc";
            cbxMNH.DisplayMember = "TenNamHoc";
        }

        #endregion

        #region Event
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataManagerUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            txbUserName.Text = dataManagerUser.Rows[numrow].Cells[0].Value.ToString();
            textPass.Text = dataManagerUser.Rows[numrow].Cells[1].Value.ToString();

        }

        private void dataManagerTeacher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            textMGV.Text = dataManagerTeacher.Rows[numrow].Cells[0].Value.ToString();
            textNameT.Text = dataManagerTeacher.Rows[numrow].Cells[1].Value.ToString();
            string gioitinh = dataManagerTeacher.Rows[numrow].Cells[2].Value.ToString();
            if (gioitinh == "True")
            {
                ckbMale.Checked = true;
                ckbFemale.Checked = false;
            }
            else
            {
                ckbFemale.Checked = true;
                ckbMale.Checked = false;
            }
              
            textDate.Text = dataManagerTeacher.Rows[numrow].Cells[3].Value.ToString();
            textWhere.Text = dataManagerTeacher.Rows[numrow].Cells[4].Value.ToString();
            textAddress.Text = dataManagerTeacher.Rows[numrow].Cells[5].Value.ToString();
            textNumber.Text = dataManagerTeacher.Rows[numrow].Cells[6].Value.ToString();
        }

        private void dataManagerStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            textMHS.Text = dataManagerStudent.Rows[numrow].Cells[0].Value.ToString();
            textNameStudent.Text = dataManagerStudent.Rows[numrow].Cells[1].Value.ToString();
            string gioitinh = dataManagerStudent.Rows[numrow].Cells[2].Value.ToString();
            if (gioitinh == "True")
            {
                checkMan.Checked = true;
                checkFeMal.Checked = false;
            }
            else
            {
                checkFeMal.Checked = true;
                checkMan.Checked = false;
            }

            textDateS.Text = dataManagerStudent.Rows[numrow].Cells[3].Value.ToString();
            textQue.Text = dataManagerStudent.Rows[numrow].Cells[4].Value.ToString();
            textAddS.Text = dataManagerStudent.Rows[numrow].Cells[5].Value.ToString();
            cbbNation.Text = dataManagerStudent.Rows[numrow].Cells[6].Value.ToString();
            cbbReligion.Text = dataManagerStudent.Rows[numrow].Cells[7].Value.ToString();
            txbParentName.Text = dataManagerStudent.Rows[numrow].Cells[8].Value.ToString();

        }

        private void datAassigned_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            textMPC.Text = datAassigned.Rows[numrow].Cells[0].Value.ToString();
            comboMGV.Text = datAassigned.Rows[numrow].Cells[1].Value.ToString();
            comboMMH.Text = datAassigned.Rows[numrow].Cells[2].Value.ToString();
        }

        private void dataGVL_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            tbMGVL.Text = dataGVL.Rows[numrow].Cells[0].Value.ToString();
            cbxMGV.Text = dataGVL.Rows[numrow].Cells[1].Value.ToString();
            cbxML.Text = dataGVL.Rows[numrow].Cells[2].Value.ToString();
            cbxMNH.Text = dataGVL.Rows[numrow].Cells[3].Value.ToString();
        }

        #endregion

        #region TrashVoid
        // Manager User
        private void btAd_Click(object sender, EventArgs e)
        {
            string name = txbUserName.Text;
            string pass = textPass.Text;
       
                AdminDAO.Instance.AdNewUser(name, pass);
                MessageBox.Show("Thêm tài khoản thành công!", "Thông báo");
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string name = txbUserName.Text;
            string pass = textPass.Text;

          
  
                AdminDAO.Instance.EditUser(name, pass);
                MessageBox.Show("Cập nhập tài khoản thành công!", "Thông báo");
 
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            string name = txbUserName.Text;
            

       
                AdminDAO.Instance.DeleteUser(name);
                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo");
           
        }

        private void btUpdateData_Click(object sender, EventArgs e)
        {
            LoadListUser();
        }


        //Manager Teacher
        private void btAddT_Click(object sender, EventArgs e)
        {
            string ma = textMGV.Text;
            string name = textNameT.Text;

            bool tam;
            if (ckbMale.Checked)
                tam = true;
            else
                tam = false;

            DateTime sn = DateTime.Parse(textDate.Text);
            string ns = textWhere.Text;
            string dc = textAddress.Text;
            string dt = textNumber.Text;

            AdminDAO.Instance.SaveTaecher(ma, name, tam, sn, ns, dc, dt);
            MessageBox.Show("Thêm thành công!", "Thông báo");
           
        }

        private void btEditT_Click(object sender, EventArgs e)
        {
            string ma = textMGV.Text;
            string name = textNameT.Text;

            bool tam;
            if (ckbMale.Checked)
                tam = true;
            else
                tam = false;

            DateTime sn = DateTime.Parse(textDate.Text);
            string ns = textWhere.Text;
            string dc = textAddress.Text;
            string dt = textNumber.Text;

            AdminDAO.Instance.EditTeacher(ma, name, tam, sn, ns, dc, dt);
            MessageBox.Show("Thêm thành công!", "Thông báo");

        }

        private void btDeleteT_Click(object sender, EventArgs e)
        {
            string ma = textMGV.Text;
            AdminDAO.Instance.DeleteTeacher(ma);
            MessageBox.Show("Thêm thành công!", "Thông báo");
        }



        //Manager Student
        private void btAddS_Click(object sender, EventArgs e)
        {
            string ms = textMHS.Text;
            string name = textNameStudent.Text;

            bool tam;
            if (checkMan.Checked)
                tam = true;
            else
                tam = false;

            DateTime sn = DateTime.Parse(textDateS.Text);
            string que = textQue.Text;
            string dc = textAddS.Text;
            string dt = (string)cbbNation.SelectedValue;
            string tg = (string)cbbReligion.SelectedValue;
            string nt = txbParentName.Text;
            AdminDAO.Instance.SaveInfor(ms, name, tam, sn, que, dc, dt, tg, nt);

        }

        private void btEditS_Click(object sender, EventArgs e)
        {
            string ms = textMHS.Text;
            string name = textNameStudent.Text;

            bool tam;
            if (checkMan.Checked)
                tam = true;
            else
                tam = false;

            DateTime sn = DateTime.Parse(textDateS.Text);
            string que = textQue.Text;
            string dc = textAddS.Text;
            string dt = (string)cbbNation.SelectedValue;
            string tg = (string)cbbReligion.SelectedValue;
            string nt = txbParentName.Text;
            UpdateInforDAO.Instance.UpdateInfor(ms, name, tam, sn, que, dc, dt, tg, nt);
        }

        private void btDeleteS_Click(object sender, EventArgs e)
        {

        }


        //Assigned
        private void btAddAss_Click(object sender, EventArgs e)
        {
            string mapc = textMPC.Text;
            string magvl = (string)comboMGV.SelectedValue;
            string mamh = (string)comboMMH.SelectedValue;

            AdminDAO.Instance.SaveAssigned(mapc, magvl, mamh);
            MessageBox.Show("Thêm thành công!", "Thông báo");
        }

        private void btEditAss_Click(object sender, EventArgs e)
        {
            string mapc = textMPC.Text;
            string magvl = (string)comboMGV.SelectedValue;
            string mamh = (string)comboMMH.SelectedValue;

            AdminDAO.Instance.EditAssigned(mapc, magvl, mamh);
            MessageBox.Show("Cập nhập thành công!", "Thông báo");
        }

        private void btDeleteAss_Click(object sender, EventArgs e)
        {
            string mapc = textMPC.Text;

            AdminDAO.Instance.DeleteAssigned(mapc);
            MessageBox.Show("Xóa thành công!", "Thông báo");
        }

        //Teacher of Class

        private void btSave_Click(object sender, EventArgs e)
        {
            string mgvl = tbMGVL.Text;
            string mgv = (string)cbxMGV.SelectedValue;
            string ml = (string)cbxML.SelectedValue;
            string manh = (string)cbxMNH.SelectedValue;

            AdminDAO.Instance.SaveTaecherOfClass(mgvl, mgv, ml, manh);
            MessageBox.Show("Thêm thành công!", "Thông báo");
        }

        private void btDeleteGVL_Click(object sender, EventArgs e)
        {
            string mgvl = tbMGVL.Text;
            AdminDAO.Instance.DeleteTeacherOfClass(mgvl);
            MessageBox.Show("Thêm thành công!", "Thông báo");
        }

        private void btUpdateGVL_Click(object sender, EventArgs e)
        {
            string mgvl = tbMGVL.Text;
            string mgv = (string)cbxMGV.SelectedValue;
            string ml = (string)cbxML.SelectedValue;
            string manh = (string)cbxMNH.SelectedValue;

            AdminDAO.Instance.EditTeacherOfClass(mgvl, mgv, ml, manh);
            MessageBox.Show("Thêm thành công!", "Thông báo");
        }

        #endregion

     

        
    }
}
