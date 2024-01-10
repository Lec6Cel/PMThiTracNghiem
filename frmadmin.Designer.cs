namespace PMTHITN
{
    partial class frmadmin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmadmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.picSV = new System.Windows.Forms.PictureBox();
            this.picGV = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txttim = new System.Windows.Forms.TextBox();
            this.lbltim = new System.Windows.Forms.Label();
            this.grbtaikhoan = new System.Windows.Forms.GroupBox();
            this.lbltrangthai = new System.Windows.Forms.Label();
            this.txttrangthai = new System.Windows.Forms.TextBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtmatkhau = new System.Windows.Forms.TextBox();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnkhoataikhoan = new System.Windows.Forms.Button();
            this.btnmotaikhoan = new System.Windows.Forms.Button();
            this.txtten = new System.Windows.Forms.TextBox();
            this.txthodem = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblmatkhau = new System.Windows.Forms.Label();
            this.lblngaysinh = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            this.lblhodem = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.grbdanhsach = new System.Windows.Forms.GroupBox();
            this.dgvdanhsach = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tHITRACNGHIEMDataSet1 = new PMTHITN.THITRACNGHIEMDataSet1();
            this.tHITRACNGHIEMDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gVTableAdapter = new PMTHITN.THITRACNGHIEMDataSet1TableAdapters.GVTableAdapter();
            this.sVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sVTableAdapter = new PMTHITN.THITRACNGHIEMDataSet1TableAdapters.SVTableAdapter();
            this.gVBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.grbtaikhoan.SuspendLayout();
            this.grbdanhsach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHITRACNGHIEMDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHITRACNGHIEMDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.picSV);
            this.panel1.Controls.Add(this.picGV);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1478, 113);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Giảng viên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(224, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 29);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sinh viên";
            // 
            // picSV
            // 
            this.picSV.BackColor = System.Drawing.Color.Transparent;
            this.picSV.Image = ((System.Drawing.Image)(resources.GetObject("picSV.Image")));
            this.picSV.InitialImage = null;
            this.picSV.Location = new System.Drawing.Point(229, 3);
            this.picSV.Name = "picSV";
            this.picSV.Size = new System.Drawing.Size(100, 75);
            this.picSV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSV.TabIndex = 1;
            this.picSV.TabStop = false;
            this.picSV.Click += new System.EventHandler(this.picSV_Click);
            // 
            // picGV
            // 
            this.picGV.BackColor = System.Drawing.Color.Transparent;
            this.picGV.Image = ((System.Drawing.Image)(resources.GetObject("picGV.Image")));
            this.picGV.InitialImage = null;
            this.picGV.Location = new System.Drawing.Point(37, 3);
            this.picGV.Name = "picGV";
            this.picGV.Size = new System.Drawing.Size(105, 75);
            this.picGV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGV.TabIndex = 0;
            this.picGV.TabStop = false;
            this.picGV.Click += new System.EventHandler(this.picGV_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.grbtaikhoan);
            this.panel2.Controls.Add(this.grbdanhsach);
            this.panel2.Location = new System.Drawing.Point(0, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1481, 563);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txttim);
            this.panel3.Controls.Add(this.lbltim);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(807, 77);
            this.panel3.TabIndex = 2;
            // 
            // txttim
            // 
            this.txttim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttim.Location = new System.Drawing.Point(196, 34);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(256, 30);
            this.txttim.TabIndex = 17;
            this.txttim.TextChanged += new System.EventHandler(this.txttim_TextChanged);
            // 
            // lbltim
            // 
            this.lbltim.AutoSize = true;
            this.lbltim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltim.Location = new System.Drawing.Point(67, 34);
            this.lbltim.Name = "lbltim";
            this.lbltim.Size = new System.Drawing.Size(99, 25);
            this.lbltim.TabIndex = 18;
            this.lbltim.Text = "Tìm kiếm";
            // 
            // grbtaikhoan
            // 
            this.grbtaikhoan.Controls.Add(this.lbltrangthai);
            this.grbtaikhoan.Controls.Add(this.txttrangthai);
            this.grbtaikhoan.Controls.Add(this.btnsua);
            this.grbtaikhoan.Controls.Add(this.dtpngaysinh);
            this.grbtaikhoan.Controls.Add(this.txtmatkhau);
            this.grbtaikhoan.Controls.Add(this.btnthoat);
            this.grbtaikhoan.Controls.Add(this.btnhuy);
            this.grbtaikhoan.Controls.Add(this.btnluu);
            this.grbtaikhoan.Controls.Add(this.btnxoa);
            this.grbtaikhoan.Controls.Add(this.btnthem);
            this.grbtaikhoan.Controls.Add(this.btnkhoataikhoan);
            this.grbtaikhoan.Controls.Add(this.btnmotaikhoan);
            this.grbtaikhoan.Controls.Add(this.txtten);
            this.grbtaikhoan.Controls.Add(this.txthodem);
            this.grbtaikhoan.Controls.Add(this.txtID);
            this.grbtaikhoan.Controls.Add(this.lblmatkhau);
            this.grbtaikhoan.Controls.Add(this.lblngaysinh);
            this.grbtaikhoan.Controls.Add(this.lblten);
            this.grbtaikhoan.Controls.Add(this.lblhodem);
            this.grbtaikhoan.Controls.Add(this.lblMaGV);
            this.grbtaikhoan.Controls.Add(this.lblMaSV);
            this.grbtaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbtaikhoan.Location = new System.Drawing.Point(816, 3);
            this.grbtaikhoan.Name = "grbtaikhoan";
            this.grbtaikhoan.Size = new System.Drawing.Size(662, 573);
            this.grbtaikhoan.TabIndex = 1;
            this.grbtaikhoan.TabStop = false;
            this.grbtaikhoan.Text = "Tài khoản";
            this.grbtaikhoan.Enter += new System.EventHandler(this.grbtaikhoan_Enter);
            // 
            // lbltrangthai
            // 
            this.lbltrangthai.AutoSize = true;
            this.lbltrangthai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltrangthai.Location = new System.Drawing.Point(40, 316);
            this.lbltrangthai.Name = "lbltrangthai";
            this.lbltrangthai.Size = new System.Drawing.Size(110, 25);
            this.lbltrangthai.TabIndex = 21;
            this.lbltrangthai.Text = "Trạng thái";
            // 
            // txttrangthai
            // 
            this.txttrangthai.Location = new System.Drawing.Point(201, 316);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(113, 34);
            this.txttrangthai.TabIndex = 20;
            // 
            // btnsua
            // 
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Location = new System.Drawing.Point(367, 430);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(101, 37);
            this.btnsua.TabIndex = 19;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaysinh.Location = new System.Drawing.Point(201, 267);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(267, 30);
            this.dtpngaysinh.TabIndex = 17;
            this.dtpngaysinh.Value = new System.DateTime(2024, 5, 1, 22, 17, 0, 0);
            this.dtpngaysinh.ValueChanged += new System.EventHandler(this.dtpngaysinh_ValueChanged);
            // 
            // txtmatkhau
            // 
            this.txtmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatkhau.Location = new System.Drawing.Point(205, 215);
            this.txtmatkhau.Name = "txtmatkhau";
            this.txtmatkhau.Size = new System.Drawing.Size(147, 30);
            this.txtmatkhau.TabIndex = 16;
            this.txtmatkhau.TextChanged += new System.EventHandler(this.txtmatkhau_TextChanged);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(406, 488);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(148, 54);
            this.btnthoat.TabIndex = 15;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhuy.Location = new System.Drawing.Point(94, 488);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(141, 54);
            this.btnhuy.TabIndex = 14;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnluu
            // 
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Location = new System.Drawing.Point(486, 432);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(101, 36);
            this.btnluu.TabIndex = 13;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Location = new System.Drawing.Point(173, 430);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(98, 38);
            this.btnxoa.TabIndex = 12;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthem
            // 
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Location = new System.Drawing.Point(32, 430);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(109, 38);
            this.btnthem.TabIndex = 11;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnkhoataikhoan
            // 
            this.btnkhoataikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkhoataikhoan.Location = new System.Drawing.Point(367, 371);
            this.btnkhoataikhoan.Name = "btnkhoataikhoan";
            this.btnkhoataikhoan.Size = new System.Drawing.Size(220, 44);
            this.btnkhoataikhoan.TabIndex = 10;
            this.btnkhoataikhoan.Text = "Khóa tài khoản";
            this.btnkhoataikhoan.UseVisualStyleBackColor = true;
            this.btnkhoataikhoan.Click += new System.EventHandler(this.btnkhoataikhoan_Click);
            // 
            // btnmotaikhoan
            // 
            this.btnmotaikhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmotaikhoan.Location = new System.Drawing.Point(32, 371);
            this.btnmotaikhoan.Name = "btnmotaikhoan";
            this.btnmotaikhoan.Size = new System.Drawing.Size(228, 44);
            this.btnmotaikhoan.TabIndex = 9;
            this.btnmotaikhoan.Text = "Mở khóa tài khoản";
            this.btnmotaikhoan.UseVisualStyleBackColor = true;
            this.btnmotaikhoan.Click += new System.EventHandler(this.btnmotaikhoan_Click);
            // 
            // txtten
            // 
            this.txtten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtten.Location = new System.Drawing.Point(205, 161);
            this.txtten.Name = "txtten";
            this.txtten.Size = new System.Drawing.Size(100, 30);
            this.txtten.TabIndex = 7;
            this.txtten.TextChanged += new System.EventHandler(this.txtten_TextChanged);
            // 
            // txthodem
            // 
            this.txthodem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthodem.Location = new System.Drawing.Point(205, 113);
            this.txthodem.Name = "txthodem";
            this.txthodem.Size = new System.Drawing.Size(220, 30);
            this.txthodem.TabIndex = 6;
            this.txthodem.TextChanged += new System.EventHandler(this.txthodem_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(201, 68);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(224, 30);
            this.txtID.TabIndex = 5;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // lblmatkhau
            // 
            this.lblmatkhau.AutoSize = true;
            this.lblmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmatkhau.Location = new System.Drawing.Point(40, 218);
            this.lblmatkhau.Name = "lblmatkhau";
            this.lblmatkhau.Size = new System.Drawing.Size(101, 25);
            this.lblmatkhau.TabIndex = 4;
            this.lblmatkhau.Text = "Mật khẩu";
            // 
            // lblngaysinh
            // 
            this.lblngaysinh.AutoSize = true;
            this.lblngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblngaysinh.Location = new System.Drawing.Point(40, 267);
            this.lblngaysinh.Name = "lblngaysinh";
            this.lblngaysinh.Size = new System.Drawing.Size(108, 25);
            this.lblngaysinh.TabIndex = 3;
            this.lblngaysinh.Text = "Ngày sinh";
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblten.Location = new System.Drawing.Point(40, 166);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(50, 25);
            this.lblten.TabIndex = 2;
            this.lblten.Text = "Tên";
            // 
            // lblhodem
            // 
            this.lblhodem.AutoSize = true;
            this.lblhodem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhodem.Location = new System.Drawing.Point(40, 118);
            this.lblhodem.Name = "lblhodem";
            this.lblhodem.Size = new System.Drawing.Size(86, 25);
            this.lblhodem.TabIndex = 1;
            this.lblhodem.Text = "Họ đệm";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaGV.Location = new System.Drawing.Point(47, 73);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(79, 25);
            this.lblMaGV.TabIndex = 0;
            this.lblMaGV.Text = "Mã GV";
            // 
            // lblMaSV
            // 
            this.lblMaSV.AutoSize = true;
            this.lblMaSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSV.Location = new System.Drawing.Point(40, 73);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(78, 25);
            this.lblMaSV.TabIndex = 18;
            this.lblMaSV.Text = "Mã SV";
            // 
            // grbdanhsach
            // 
            this.grbdanhsach.Controls.Add(this.dgvdanhsach);
            this.grbdanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbdanhsach.Location = new System.Drawing.Point(3, 76);
            this.grbdanhsach.Name = "grbdanhsach";
            this.grbdanhsach.Size = new System.Drawing.Size(807, 497);
            this.grbdanhsach.TabIndex = 0;
            this.grbdanhsach.TabStop = false;
            this.grbdanhsach.Text = "Danh sách";
            this.grbdanhsach.Enter += new System.EventHandler(this.grbdanhsach_Enter);
            // 
            // dgvdanhsach
            // 
            this.dgvdanhsach.AllowUserToDeleteRows = false;
            this.dgvdanhsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdanhsach.Location = new System.Drawing.Point(6, 45);
            this.dgvdanhsach.Name = "dgvdanhsach";
            this.dgvdanhsach.ReadOnly = true;
            this.dgvdanhsach.RowHeadersWidth = 51;
            this.dgvdanhsach.RowTemplate.Height = 24;
            this.dgvdanhsach.Size = new System.Drawing.Size(792, 424);
            this.dgvdanhsach.TabIndex = 0;
            this.dgvdanhsach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsach_cellclick);
            this.dgvdanhsach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdanhsach_CellContentClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tHITRACNGHIEMDataSet1
            // 
            this.tHITRACNGHIEMDataSet1.DataSetName = "THITRACNGHIEMDataSet1";
            this.tHITRACNGHIEMDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tHITRACNGHIEMDataSet1BindingSource
            // 
            this.tHITRACNGHIEMDataSet1BindingSource.DataSource = this.tHITRACNGHIEMDataSet1;
            this.tHITRACNGHIEMDataSet1BindingSource.Position = 0;
            // 
            // gVBindingSource
            // 
            this.gVBindingSource.DataMember = "GV";
            this.gVBindingSource.DataSource = this.tHITRACNGHIEMDataSet1;
            // 
            // gVTableAdapter
            // 
            this.gVTableAdapter.ClearBeforeFill = true;
            // 
            // sVBindingSource
            // 
            this.sVBindingSource.DataMember = "SV";
            this.sVBindingSource.DataSource = this.tHITRACNGHIEMDataSet1BindingSource;
            // 
            // sVTableAdapter
            // 
            this.sVTableAdapter.ClearBeforeFill = true;
            // 
            // gVBindingSource1
            // 
            this.gVBindingSource1.DataMember = "GV";
            this.gVBindingSource1.DataSource = this.tHITRACNGHIEMDataSet1BindingSource;
            // 
            // frmadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1483, 694);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmadmin";
            this.Text = "frmadmin";
            this.Load += new System.EventHandler(this.frmadmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.grbtaikhoan.ResumeLayout(false);
            this.grbtaikhoan.PerformLayout();
            this.grbdanhsach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdanhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHITRACNGHIEMDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHITRACNGHIEMDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox grbdanhsach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox grbtaikhoan;
        private System.Windows.Forms.TextBox txtten;
        private System.Windows.Forms.TextBox txthodem;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblmatkhau;
        private System.Windows.Forms.Label lblngaysinh;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.Label lblhodem;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.DataGridView dgvdanhsach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picSV;
        private System.Windows.Forms.PictureBox picGV;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Label lbltim;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnkhoataikhoan;
        private System.Windows.Forms.Button btnmotaikhoan;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource tHITRACNGHIEMDataSet1BindingSource;
        private THITRACNGHIEMDataSet1 tHITRACNGHIEMDataSet1;
        private System.Windows.Forms.BindingSource gVBindingSource;
        private THITRACNGHIEMDataSet1TableAdapters.GVTableAdapter gVTableAdapter;
        private System.Windows.Forms.BindingSource sVBindingSource;
        private THITRACNGHIEMDataSet1TableAdapters.SVTableAdapter sVTableAdapter;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Label lbltrangthai;
        private System.Windows.Forms.TextBox txttrangthai;
        private System.Windows.Forms.BindingSource gVBindingSource1;
    }
}