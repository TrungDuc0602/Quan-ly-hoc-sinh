namespace QuanLyHocSinh
{
    partial class fTableManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txbDisplayNameStudent = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.tclStudent = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.tpDisplayPoint = new System.Windows.Forms.TabPage();
            this.lvShowPoint = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbChoseSchoolYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbChoseTerm = new System.Windows.Forms.ComboBox();
            this.tpInformation = new System.Windows.Forms.TabPage();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btEditInformation = new System.Windows.Forms.Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.txbParentName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txbReligion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txbNation = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.txbNativeBorn = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel19 = new System.Windows.Forms.Panel();
            this.ckbFemale = new System.Windows.Forms.CheckBox();
            this.ckbMale = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel20 = new System.Windows.Forms.Panel();
            this.txbDateBorn = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel22 = new System.Windows.Forms.Panel();
            this.txbCodeStudent = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel12.SuspendLayout();
            this.tclStudent.SuspendLayout();
            this.tpDisplayPoint.SuspendLayout();
            this.tpInformation.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel12);
            this.panel1.Controls.Add(this.tclStudent);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 503);
            this.panel1.TabIndex = 0;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txbDisplayNameStudent);
            this.panel12.Controls.Add(this.btnLogOut);
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(643, 33);
            this.panel12.TabIndex = 1;
            this.panel12.Paint += new System.Windows.Forms.PaintEventHandler(this.panel12_Paint);
            // 
            // txbDisplayNameStudent
            // 
            this.txbDisplayNameStudent.AutoSize = true;
            this.txbDisplayNameStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDisplayNameStudent.Location = new System.Drawing.Point(306, 8);
            this.txbDisplayNameStudent.Name = "txbDisplayNameStudent";
            this.txbDisplayNameStudent.Size = new System.Drawing.Size(101, 16);
            this.txbDisplayNameStudent.TabIndex = 0;
            this.txbDisplayNameStudent.Text = "Tên người dùng";
            this.txbDisplayNameStudent.Click += new System.EventHandler(this.txbDisplayNameStudent_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(480, 5);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Đăng xuất";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // tclStudent
            // 
            this.tclStudent.Controls.Add(this.tpHome);
            this.tclStudent.Controls.Add(this.tpDisplayPoint);
            this.tclStudent.Controls.Add(this.tpInformation);
            this.tclStudent.Location = new System.Drawing.Point(3, 35);
            this.tclStudent.Name = "tclStudent";
            this.tclStudent.SelectedIndex = 0;
            this.tclStudent.Size = new System.Drawing.Size(647, 463);
            this.tclStudent.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.Location = new System.Drawing.Point(4, 22);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(639, 437);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Trang chủ";
            this.tpHome.UseVisualStyleBackColor = true;
            this.tpHome.Click += new System.EventHandler(this.tIn_Click);
            // 
            // tpDisplayPoint
            // 
            this.tpDisplayPoint.Controls.Add(this.lvShowPoint);
            this.tpDisplayPoint.Controls.Add(this.btnChose);
            this.tpDisplayPoint.Controls.Add(this.label2);
            this.tpDisplayPoint.Controls.Add(this.cbbChoseSchoolYear);
            this.tpDisplayPoint.Controls.Add(this.label1);
            this.tpDisplayPoint.Controls.Add(this.cbbChoseTerm);
            this.tpDisplayPoint.Location = new System.Drawing.Point(4, 22);
            this.tpDisplayPoint.Name = "tpDisplayPoint";
            this.tpDisplayPoint.Padding = new System.Windows.Forms.Padding(3);
            this.tpDisplayPoint.Size = new System.Drawing.Size(639, 437);
            this.tpDisplayPoint.TabIndex = 1;
            this.tpDisplayPoint.Text = "Xem điểm";
            this.tpDisplayPoint.UseVisualStyleBackColor = true;
            // 
            // lvShowPoint
            // 
            this.lvShowPoint.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvShowPoint.GridLines = true;
            this.lvShowPoint.Location = new System.Drawing.Point(3, 40);
            this.lvShowPoint.Name = "lvShowPoint";
            this.lvShowPoint.Size = new System.Drawing.Size(633, 391);
            this.lvShowPoint.TabIndex = 5;
            this.lvShowPoint.UseCompatibleStateImageBehavior = false;
            this.lvShowPoint.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Môn học";
            this.columnHeader1.Width = 127;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ĐTB";
            this.columnHeader2.Width = 66;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Điểm miệng";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Điển kiếm tra 15p";
            this.columnHeader4.Width = 97;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Điểm kiểm tra 1 tiết";
            this.columnHeader5.Width = 106;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Điểm kiểm tra học kỳ";
            this.columnHeader6.Width = 114;
            // 
            // btnChose
            // 
            this.btnChose.Location = new System.Drawing.Point(476, 4);
            this.btnChose.Name = "btnChose";
            this.btnChose.Size = new System.Drawing.Size(75, 23);
            this.btnChose.TabIndex = 4;
            this.btnChose.Text = "Xem";
            this.btnChose.UseVisualStyleBackColor = true;
            this.btnChose.Click += new System.EventHandler(this.btnChose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Năm học:";
            // 
            // cbbChoseSchoolYear
            // 
            this.cbbChoseSchoolYear.FormattingEnabled = true;
            this.cbbChoseSchoolYear.Items.AddRange(new object[] {
            "2016-2017",
            "2017-2018",
            "2018-2019"});
            this.cbbChoseSchoolYear.Location = new System.Drawing.Point(305, 6);
            this.cbbChoseSchoolYear.Name = "cbbChoseSchoolYear";
            this.cbbChoseSchoolYear.Size = new System.Drawing.Size(80, 21);
            this.cbbChoseSchoolYear.TabIndex = 2;
            this.cbbChoseSchoolYear.Text = "2016-2017";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Học kỳ:";
            // 
            // cbbChoseTerm
            // 
            this.cbbChoseTerm.FormattingEnabled = true;
            this.cbbChoseTerm.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbbChoseTerm.Location = new System.Drawing.Point(126, 6);
            this.cbbChoseTerm.Name = "cbbChoseTerm";
            this.cbbChoseTerm.Size = new System.Drawing.Size(42, 21);
            this.cbbChoseTerm.TabIndex = 0;
            // 
            // tpInformation
            // 
            this.tpInformation.Controls.Add(this.panel13);
            this.tpInformation.Location = new System.Drawing.Point(4, 22);
            this.tpInformation.Name = "tpInformation";
            this.tpInformation.Padding = new System.Windows.Forms.Padding(3);
            this.tpInformation.Size = new System.Drawing.Size(639, 437);
            this.tpInformation.TabIndex = 2;
            this.tpInformation.Text = "Thông tin cá nhân";
            this.tpInformation.UseVisualStyleBackColor = true;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btEditInformation);
            this.panel13.Controls.Add(this.panel14);
            this.panel13.Controls.Add(this.panel15);
            this.panel13.Controls.Add(this.panel16);
            this.panel13.Controls.Add(this.panel17);
            this.panel13.Controls.Add(this.panel18);
            this.panel13.Controls.Add(this.panel19);
            this.panel13.Controls.Add(this.panel20);
            this.panel13.Controls.Add(this.panel21);
            this.panel13.Controls.Add(this.panel22);
            this.panel13.Location = new System.Drawing.Point(6, 7);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(627, 430);
            this.panel13.TabIndex = 1;
            this.panel13.Paint += new System.Windows.Forms.PaintEventHandler(this.panel13_Paint);
            this.panel13.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.panel13_MouseDoubleClick);
            // 
            // btEditInformation
            // 
            this.btEditInformation.Location = new System.Drawing.Point(496, 398);
            this.btEditInformation.Name = "btEditInformation";
            this.btEditInformation.Size = new System.Drawing.Size(75, 23);
            this.btEditInformation.TabIndex = 4;
            this.btEditInformation.Text = "Chỉnh sửa";
            this.btEditInformation.UseVisualStyleBackColor = true;
            this.btEditInformation.Click += new System.EventHandler(this.btEditInformation_Click);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.txbParentName);
            this.panel14.Controls.Add(this.label9);
            this.panel14.Location = new System.Drawing.Point(49, 357);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(525, 38);
            this.panel14.TabIndex = 3;
            // 
            // txbParentName
            // 
            this.txbParentName.Location = new System.Drawing.Point(139, 8);
            this.txbParentName.Name = "txbParentName";
            this.txbParentName.Size = new System.Drawing.Size(383, 20);
            this.txbParentName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên người thân:";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txbReligion);
            this.panel15.Controls.Add(this.label10);
            this.panel15.Location = new System.Drawing.Point(49, 313);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(525, 38);
            this.panel15.TabIndex = 3;
            // 
            // txbReligion
            // 
            this.txbReligion.Location = new System.Drawing.Point(139, 8);
            this.txbReligion.Name = "txbReligion";
            this.txbReligion.Size = new System.Drawing.Size(383, 20);
            this.txbReligion.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tôn giáo:";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txbNation);
            this.panel16.Controls.Add(this.label11);
            this.panel16.Location = new System.Drawing.Point(49, 269);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(525, 38);
            this.panel16.TabIndex = 3;
            // 
            // txbNation
            // 
            this.txbNation.Location = new System.Drawing.Point(139, 8);
            this.txbNation.Name = "txbNation";
            this.txbNation.Size = new System.Drawing.Size(383, 20);
            this.txbNation.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Dân tộc:";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.txbAddress);
            this.panel17.Controls.Add(this.label12);
            this.panel17.Location = new System.Drawing.Point(49, 225);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(525, 38);
            this.panel17.TabIndex = 3;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(139, 8);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(383, 20);
            this.txbAddress.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Địa chỉ:";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.txbNativeBorn);
            this.panel18.Controls.Add(this.label13);
            this.panel18.Location = new System.Drawing.Point(49, 181);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(525, 38);
            this.panel18.TabIndex = 3;
            // 
            // txbNativeBorn
            // 
            this.txbNativeBorn.Location = new System.Drawing.Point(139, 8);
            this.txbNativeBorn.Name = "txbNativeBorn";
            this.txbNativeBorn.Size = new System.Drawing.Size(383, 20);
            this.txbNativeBorn.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "Quê quán:";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.ckbFemale);
            this.panel19.Controls.Add(this.ckbMale);
            this.panel19.Controls.Add(this.label14);
            this.panel19.Location = new System.Drawing.Point(49, 137);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(525, 38);
            this.panel19.TabIndex = 3;
            // 
            // ckbFemale
            // 
            this.ckbFemale.AutoSize = true;
            this.ckbFemale.BackColor = System.Drawing.Color.Transparent;
            this.ckbFemale.Location = new System.Drawing.Point(231, 8);
            this.ckbFemale.Name = "ckbFemale";
            this.ckbFemale.Size = new System.Drawing.Size(40, 17);
            this.ckbFemale.TabIndex = 2;
            this.ckbFemale.Text = "Nữ";
            this.ckbFemale.UseVisualStyleBackColor = false;
            // 
            // ckbMale
            // 
            this.ckbMale.AutoSize = true;
            this.ckbMale.Location = new System.Drawing.Point(139, 8);
            this.ckbMale.Name = "ckbMale";
            this.ckbMale.Size = new System.Drawing.Size(48, 17);
            this.ckbMale.TabIndex = 1;
            this.ckbMale.Text = "Nam";
            this.ckbMale.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 16);
            this.label14.TabIndex = 0;
            this.label14.Text = "Phái:";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.txbDateBorn);
            this.panel20.Controls.Add(this.label15);
            this.panel20.Location = new System.Drawing.Point(49, 93);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(525, 38);
            this.panel20.TabIndex = 2;
            // 
            // txbDateBorn
            // 
            this.txbDateBorn.Location = new System.Drawing.Point(139, 8);
            this.txbDateBorn.Name = "txbDateBorn";
            this.txbDateBorn.Size = new System.Drawing.Size(383, 20);
            this.txbDateBorn.TabIndex = 1;
            this.txbDateBorn.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 16);
            this.label15.TabIndex = 0;
            this.label15.Text = "Ngày sinh:";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.txbName);
            this.panel21.Controls.Add(this.label16);
            this.panel21.Location = new System.Drawing.Point(49, 49);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(525, 38);
            this.panel21.TabIndex = 2;
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(139, 8);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(383, 20);
            this.txbName.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Họ và tên:";
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.txbCodeStudent);
            this.panel22.Controls.Add(this.label17);
            this.panel22.Location = new System.Drawing.Point(49, 5);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(525, 38);
            this.panel22.TabIndex = 1;
            // 
            // txbCodeStudent
            // 
            this.txbCodeStudent.Location = new System.Drawing.Point(139, 8);
            this.txbCodeStudent.Name = "txbCodeStudent";
            this.txbCodeStudent.Size = new System.Drawing.Size(383, 20);
            this.txbCodeStudent.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Mã học sinh:";
            // 
            // fTableManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 503);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "fTableManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phần mềm quản lý học sinh";
            this.panel1.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.tclStudent.ResumeLayout(false);
            this.tpDisplayPoint.ResumeLayout(false);
            this.tpDisplayPoint.PerformLayout();
            this.tpInformation.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tclStudent;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpDisplayPoint;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.TabPage tpInformation;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btEditInformation;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TextBox txbParentName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txbReligion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txbNation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox txbNativeBorn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.CheckBox ckbFemale;
        private System.Windows.Forms.CheckBox ckbMale;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox txbDateBorn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.TextBox txbCodeStudent;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label txbDisplayNameStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbChoseSchoolYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbChoseTerm;
        private System.Windows.Forms.Button btnChose;
        private System.Windows.Forms.ListView lvShowPoint;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}