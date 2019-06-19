﻿using QuanLyHocSinh.DAO;
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
    public partial class flogin : Form
    {
        public string usertype;
        public flogin()
        {
            InitializeComponent();
        }

        private void flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình không?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUseName.Text;
            string password = txbPassWord.Text;

            if (login(username, password))
            {
                usertype = getutype(username);
                if( usertype == "1")
                {
                    AdTableManager f = new AdTableManager(txbUseName.Text);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    if( usertype == "2")
                    {
                        fTableManager f = new fTableManager(txbUseName.Text);
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else
                    {

                    }
                }
                
            }
            else
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo");           
        }

         string getutype(string username)
        {
            return AccountDAO.Instance.getUtype(username);
        }

        bool login(string username, string password)
        {
            return AccountDAO.Instance.login(username, password);
        }



        #region TrashVoid
        private void flogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
