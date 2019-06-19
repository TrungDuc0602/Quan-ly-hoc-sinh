using QuanLyHocSinh.DAO;
using QuanLyHocSinh.DTO;
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
    public partial class fEditInformation : Form
    {
        public fEditInformation(string str_Value)
        {
            InitializeComponent();

            loadStudentInformation(str_Value);
        }

        void loadStudentInformation(string StudentCode)
        {
            StudentInformation item = StudentInformationDAO.Instance.loadStudentInformationlist(StudentCode);

            txbCodeStudent.AppendText(item.MaHocSinh);

            this.txbName.Text = item.HoTen;

            if (item.GioiTinh)
                ckbMale.Checked = true;
            else
                ckbFemale.Checked = true;

            DateTime d = item.NgaySinh;
            txbDateBorn.AppendText(d.ToString("dd/MM/yyyy"));

            this.txbNativeBorn.AppendText(item.NoiSinh);

            this.txbAddress.AppendText(item.DiaChi);

            this.cbbNation.Text = item.MaDanToc;

            this.cbbReligion.Text = item.MaTonGiao;

            this.txbParentName.AppendText(item.TenNguoiThan);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_Information(txbCodeStudent.Text);

            MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo");
            this.Close();
        }

        void Update_Information(string MaHocSinh)
        {
            string HoTen = txbName.Text;

            bool GioiTinh;

            if (ckbMale.Checked)
                GioiTinh = true;
            else
                GioiTinh = false;

            DateTime NgaySinh = new DateTime(2004, 05, 05);

            string QueQuan = txbNativeBorn.Text;

            string DiaChi = txbAddress.Text;

            string DanToc = cbbNation.Text;

            string TonGiao = cbbReligion.Text;

            string NguoiThan = txbParentName.Text;


         UpdateInforDAO.Instance.UpdateInfor(MaHocSinh, HoTen, GioiTinh, NgaySinh, QueQuan, DiaChi, DanToc, TonGiao, NguoiThan);
        }
    }
}
