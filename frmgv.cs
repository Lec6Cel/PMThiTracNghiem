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

namespace PMTHITN
{
    public partial class frmgv : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        SqlCommand lenh = new SqlCommand();
        string sql, constr;
        public frmgv()
        {
            InitializeComponent();
        }
        private void frmgv_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tHITRACNGHIEMDataSet.CAUHOI' table. You can move, or remove it, as needed.
            //this.cAUHOITableAdapter.Fill(this.tHITRACNGHIEMDataSet.CAUHOI);
            // TODO: This line of code loads data into the 'tHITRACNGHIEMDataSet.MONTHI' table. You can move, or remove it, as needed.
            //this.mONTHITableAdapter.Fill(this.tHITRACNGHIEMDataSet.MONTHI);
            constr = "Data Source=MSI\\MSSQLSERVER01;Initial Catalog=THITRACNGHIEM;Integrated Security=True;Encrypt=False";
            conn.ConnectionString = constr;
            conn.Open();

        }

        private void LoadDuLieu(string sql)
        {

            dt = new DataTable();
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            dgvmenu.DataSource = dt;
        }

        private void Chitiet(Boolean a)
        {
            txtmamon.Enabled = a;
            txtsocau.Enabled = a;
            txtthoigian.Enabled = a;
            txttenmon.Enabled = a;
            dtptgthi.Enabled = a;
            txtmach.Enabled = a;
            txtnoidung.Enabled = a;
            cmbdapan.Enabled = a;
            cmbmon.Enabled = a;
            comboBoxChuong.Enabled = a;

        }



        private void Lamsach()
        {
            txtmach.Clear();
            txtmamon.Clear();
            txtnoidung.Clear();
            txtsocau.Clear();
            txttenmon.Clear();
            dtptgthi.Text = "";
            txtthoigian.Clear();
            cmbdapan.Text = "";
            cmbmon.Text = "";
            comboBoxChuong.Text = "";   
        }


        // PHẦN CÂU HỎI CỦA QUẢN LÝ
        private void CapNhatTrangThaiNut(bool them, bool sua, bool xoa, bool luu, bool huy)
        {
            btnthem.Enabled = them;
            btnsua.Enabled = sua;
            btnxoa.Enabled = xoa;
            btnluu.Enabled = luu;
            btnhuy.Enabled = huy;
        }

        private void piccauhoi_Click(object sender, EventArgs e)
        {
            
            // Môn thi
            lblmamon.Visible = false;
            lbltenmon.Visible = false;
            lblsocau.Visible = false;
            lblthoigian.Visible = false;
            txtmamon.Visible = false;
            txttenmon.Visible = false;
            txtthoigian.Visible = false;
            txtsocau.Visible = false;
            dtptgthi.Visible = false;
            lbltgthi.Visible = false;
            // Câu hỏi
            lblmonthi.Visible = true;
            lblnoidungch.Visible = true;
            lbldapan.Visible = true;
            txtmach.Visible = true;
            cmbdapan.Visible = true;
            cmbmon.Visible = true;
            cmbloc.Visible = true;
            lblloc.Visible = true;
            txtnoidung.Visible = true;
            txtmach.Visible = true;
            lblmach.Visible = true;
            lblchuong.Visible = true;
            comboBoxChuong.Visible = true;

            // Làm sạch
            Lamsach();

            // Datagridview
            grbcauhoi.Text = "Danh sách câu hỏi";
            sql = "select MaCH as 'Mã câu hỏi', MaM as 'Mã môn', Noidung as 'Nội dung câu hỏi', Dapan as 'Đáp án', Chuong as 'Chương' from CAUHOI";
            LoadDuLieu(sql);

            dgvmenu.Columns["Mã câu hỏi"].DisplayIndex = 0;
            dgvmenu.Columns["Mã môn"].DisplayIndex = 1;
            //dgvmenu.Columns["Nội dung câu hỏi"].DisplayIndex = 2;
            //dgvmenu.Columns["Đáp án"].DisplayIndex = 3;

            // Ẩn hiện nút
            CapNhatTrangThaiNut(true, false, false, false, false);
            txtmach.Enabled = false;
            cmbmon.Enabled = false;
            comboBoxChuong.Enabled = false;
            txtnoidung.Enabled = false;
            cmbdapan.Enabled = false;
        }

        private void picmonthi_Click(object sender, EventArgs e)
        {
            // Môn thi
            lblmamon.Visible = true;
            lbltenmon.Visible = true;
            lblsocau.Visible = true;
            lblthoigian.Visible = true;
            txtmamon.Visible = true;
            txttenmon.Visible = true;
            txtthoigian.Visible = true;
            txtsocau.Visible = true;
            dtptgthi.Visible = true;
            lbltgthi.Visible = true;
            // Câu hỏi
            lblmonthi.Visible = false;
            lblnoidungch.Visible = false;
            lbldapan.Visible = false;
            txtmach.Visible = false;
            cmbdapan.Visible = false;
            lblchuong.Visible = false;
            comboBoxChuong.Visible = false;
            cmbmon.Visible = false;
            cmbloc.Visible = false;
            lblloc.Visible = false;
            txtnoidung.Visible = false;
            txtmach.Visible = false;
            lblmach.Visible = false;

            // Đổi tên lbl
            lblmamon.Text = "Mã môn:";
            lbltenmon.Text = "Tên môn:";
            lbltgthi.Text = "Thời gian thi:";
            lblsocau.Text = "Số câu:";
            lblthoigian.Text = "Thời gian:";

            // Làm sạch
            Lamsach();

            // Datagridview
            grbcauhoi.Text = "Danh sách môn thi";
            sql = "select MaM as 'Mã Môn', Tenmon as 'Tên môn', Socau as 'Số câu', TGlambai as 'Thời gian làm bài', Thoigianthi as 'Ngày thi' from MONTHI";
            LoadDuLieu(sql);

            //dgvmenu.Columns["Mã Môn"].DisplayIndex = 0;
            //dgvmenu.Columns["Tên môn"].DisplayIndex = 1;
            //dgvmenu.Columns["Số câu"].DisplayIndex = 2;
            //dgvmenu.Columns["Thời gian làm bài"].DisplayIndex = 3;
            //dgvmenu.Columns["Ngày thi"].DisplayIndex = 4;

            // Ẩn hiện nút chức năng
            CapNhatTrangThaiNut(true, false, false, false, false);
            txtmamon.Enabled = false;
            txtsocau.Enabled = false;
            txtthoigian.Enabled = false;
            txttenmon.Enabled = false;
            dtptgthi.Enabled = false;
        }

        private void picsv_Click(object sender, EventArgs e)
        {
            // Đổi tên lbl
            lblmamon.Text = "Mã SV:";
            lbltenmon.Text = "Họ đệm:";
            lbltgthi.Text = "Ngày sinh:";
            lblsocau.Text = "Tên:";
            lblthoigian.Text = "Mật khẩu:";
            grbcauhoi.Text = "Danh sách sinh viên";
            // Môn thi
            lblmamon.Visible = true;
            lbltenmon.Visible = true;
            lblsocau.Visible = true;
            lblthoigian.Visible = true;
            txtmamon.Visible = true;
            txttenmon.Visible = true;
            txtthoigian.Visible = true;
            txtsocau.Visible = true;
            dtptgthi.Visible = true;
            lbltgthi.Visible = true;
            // Câu hỏi
            lblmonthi.Visible = false;
            lblnoidungch.Visible = false;
            lbldapan.Visible = false;
            txtmach.Visible = false;
            cmbdapan.Visible = false;
            lblchuong.Visible = false;
            comboBoxChuong.Visible = false;
            cmbmon.Visible = false;
            cmbloc.Visible = false;
            lblloc.Visible = false;
            txtnoidung.Visible = false;
            txtmach.Visible = false;
            lblmach.Visible = false;
            txtthoigian.Text = "";

            // Ẩn hiện nút
            CapNhatTrangThaiNut(false, false, false, false, false);
            // làm sạch
            Lamsach();
            // Load dữ liệu
            sql = "select MaSV as 'Mã SV', Hodem as 'Họ đệm', Ten as 'Tên', Ngaysinh as 'Ngày sinh', Matkhau as 'Mật khẩu' from SV";
            LoadDuLieu(sql);
        }



        //THAY ĐỔI NỘI DUNG Ở PHẦN NGÂN HÀNG CÂU HỎI
        private void dgvmenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvmenu.Rows.Count)
            {
                // CÂU HỎI
                if (grbcauhoi.Text == "Danh sách câu hỏi")
                {
                    txtmach.Text = dgvmenu[0, e.RowIndex].Value.ToString();
                    cmbmon.Text = dgvmenu[1, e.RowIndex].Value.ToString();
                    txtnoidung.Text = dgvmenu[2, e.RowIndex].Value.ToString();
                    cmbdapan.Text = dgvmenu[3, e.RowIndex].Value.ToString();
                    comboBoxChuong.Text = dgvmenu[4, e.RowIndex].Value.ToString();

                    // Hiển thị nút btnsua và btnxoa khi chọn danh sách câu hỏi
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                }
                // MÔN THI
                else if (grbcauhoi.Text == "Danh sách môn thi")
                {
                    txtmamon.Text = dgvmenu[0, e.RowIndex].Value.ToString();
                    txttenmon.Text = dgvmenu[1, e.RowIndex].Value.ToString();
                    txtsocau.Text = dgvmenu[2, e.RowIndex].Value.ToString();
                    txtthoigian.Text = dgvmenu[3, e.RowIndex].Value.ToString();
                    dtptgthi.Text = dgvmenu[4, e.RowIndex].Value.ToString();

                    // Hiển thị nút btnsua và btnxoa khi chọn danh sách môn thi
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                }
                // SINH VIÊN
                else if (grbcauhoi.Text == "Danh sách sinh viên")
                {
                    txtmamon.Text = dgvmenu[0, e.RowIndex].Value.ToString();
                    txttenmon.Text = dgvmenu[1, e.RowIndex].Value.ToString();
                    txtsocau.Text = dgvmenu[2, e.RowIndex].Value.ToString();
                    txtthoigian.Text = dgvmenu[4, e.RowIndex].Value.ToString();
                    dtptgthi.Text = dgvmenu[3, e.RowIndex].Value.ToString();

                    // Ẩn nút btnsua và btnxoa khi chọn danh sách sinh viên
                    btnsua.Enabled = false;
                    btnxoa.Enabled = false;
                }
            }
        }


        // NÚT THÊM
        private void btnthem_Click(object sender, EventArgs e)
        {
            if (dgvmenu.Rows.Count > 0)
            {
                dgvmenu.CurrentCell = dgvmenu[0, dgvmenu.RowCount - 1];
                txtmach.Focus();
                txtmsv.Focus();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Hoặc thực hiện xử lý khác tùy thuộc vào logic ứng dụng của bạn.
            }
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnhuy.Enabled = true;
            btnluu.Enabled = true;
            Chitiet(true);
            Lamsach();
        }

        // NÚT SỬA
        private void btnsua_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            Chitiet(true);
        }



        // NÚT HUỶ
        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            Chitiet(false);
            Lamsach();
            btnthem.Enabled = true;
        }



        private void btnluu_Click(object sender, EventArgs e)
        {
            try
            {
                string ngaythi = dtptgthi.Value.ToString("yyyy-MM-dd");

                if (btnthem.Enabled == true)
                {
                    if (grbcauhoi.Text == "Danh sách môn thi")
                    {
                        InsertMonThi();
                    }
                    else if (grbcauhoi.Text == "Danh sách câu hỏi")
                    {
                        InsertCauHoi();
                    }

                    LoadData();
                    MessageBox.Show("Thêm mới thành công!");
                }

                if (btnsua.Enabled == true)
                {
                    if (grbcauhoi.Text == "Danh sách môn thi")
                    {
                        UpdateMonThi();
                    }
                    else if (grbcauhoi.Text == "Danh sách câu hỏi")
                    {
                        UpdateCauHoi();
                    }

                    LoadData();
                    MessageBox.Show("Sửa thành công!");
                }

                // Reset controls and buttons
                btnluu.Enabled = false;
                btnhuy.Enabled = false;
                btnxoa.Enabled = false;
                btnsua.Enabled = false;
                Chitiet(false);
                Lamsach();
                btnthem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Handle the exception as needed
            }
        }

        private void InsertMonThi()
        {
            string ngaythi = dtptgthi.Value.ToString("yyyy-MM-dd");
            string insertSql = "INSERT INTO MONTHI VALUES (@MaM, @Tenmon, @Socau, @TGlambai, @Thoigianthi)";
            ExecuteNonQueryWithParameters(insertSql, txtmamon.Text, txttenmon.Text, txtsocau.Text, txtthoigian.Text, ngaythi);
        }

        private void InsertCauHoi()
        {
            string insertSql = "INSERT INTO CAUHOI VALUES (@MaCH, @MaM, @Noidung, @Dapan)";
            ExecuteNonQueryWithParameters(insertSql, txtmach.Text, cmbmon.Text, txtnoidung.Text, cmbdapan.Text);
        }

        private void UpdateMonThi()
        {
            string ngaythi = dtptgthi.Value.ToString("yyyy-MM-dd");
            string updateSql = "UPDATE MONTHI SET Tenmon = @Tenmon, Socau = @Socau, TGlambai = @TGlambai, Thoigianthi = @Thoigianthi WHERE MaM = @MaM";
            ExecuteNonQueryWithParameters(updateSql, txtmamon.Text, txttenmon.Text, txtsocau.Text, txtthoigian.Text, ngaythi);
        }

        private void UpdateCauHoi()
        {
            string updateSql = "UPDATE CAUHOI SET MaM = @MaM, Noidung = @Noidung, Dapan = @Dapan WHERE MaCH = @MaCH";
            ExecuteNonQueryWithParameters(updateSql, cmbmon.Text, txtnoidung.Text, cmbdapan.Text, txtmach.Text);
        }

        private void ExecuteNonQueryWithParameters(string sql, params object[] values)
        {
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                string[] paramNames = { "@MaM", "@Tenmon", "@Socau", "@TGlambai", "@Thoigianthi", "@MaCH", "@Noidung", "@Dapan" };

                for (int i = 0; i < paramNames.Length; i++)
                {
                    cmd.Parameters.AddWithValue(paramNames[i], values[i]);
                }

                // Execute the query
                cmd.ExecuteNonQuery();
            }
        }

        private void LoadData()
        {
            string selectSql = (grbcauhoi.Text == "Danh sách môn thi") ? "SELECT * FROM MONTHI" : "SELECT * FROM CAUHOI";
            LoadDuLieu(selectSql);
        }




        //NÚT XOÁ
        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xóa dữ liệu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (grbcauhoi.Text == "Danh sách câu hỏi")
                {
                    sql = "DELETE FROM CAUHOI WHERE MaCH = @MaCH";
                }
                if (grbcauhoi.Text == "Danh sách môn thi")
                {
                    sql = "DELETE FROM MONTHI WHERE MaM = @MaM";
                }

                try
                {
                    cmd = new SqlCommand(sql, conn);

                    if (grbcauhoi.Text == "Danh sách câu hỏi")
                    {
                        cmd.Parameters.AddWithValue("@MaCH", txtmach.Text);
                    }
                    if (grbcauhoi.Text == "Danh sách môn thi")
                    {
                        cmd.Parameters.AddWithValue("@MaM", txtmamon.Text);
                    }

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đã Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (grbcauhoi.Text == "Danh sách câu hỏi")
                    {
                        sql = "SELECT * FROM CAUHOI";
                    }
                    if (grbcauhoi.Text == "Danh sách môn thi")
                    {
                        sql = "SELECT * FROM MONTHI";
                    }

                    LoadDuLieu(sql);
                }
                catch
                {
                    MessageBox.Show("Lỗi Ràng buộc dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tabbaocao_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbloc_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sử dụng tham số để tránh SQL injection
            sql = "SELECT CAUHOI.MaCH, CAUHOI.MaM, CAUHOI.Noidung, CAUHOI.Dapan " +
                  "FROM CAUHOI, MONTHI " +
                  "WHERE CAUHOI.MaM = MONTHI.MaM AND MONTHI.Tenmon LIKE N'%' + @TenMon + '%'";

            try
            {
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenMon", cmbloc.Text);

                LoadDuLieu(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thực hiện truy vấn: {ex.Message}");
                // Xử lý ngoại lệ theo nhu cầu của bạn
            }
        }



        // CÁC NÚT Ở PHẦN TRỢ GIÚP
        private void linktimch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbltrogiup.Text = "*Tìm kiếm câu hỏi" + Environment.NewLine + "1.Nhập thông tin tìm kiếm (mã câu hỏi hoặc mã môn) vào ô tìm kiếm " + Environment.NewLine + "2.Thông tin sẽ hiện ra bảng danh sách câu hỏi ở bên dưới" + Environment.NewLine + "3.Chọn tên môn thi tương ứng để lọc các câu hỏi theo từng môn";
        }

        private void linkthemch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbltrogiup.Text = "*Thêm câu hỏi " + Environment.NewLine + "1.Nhấp chuột vào Thêm " + Environment.NewLine + "2.nhập thông tin vào các ô tương ứng " + Environment.NewLine + "3.sau khi nhập đầy đủ thông tin thì nhấp chuột vào Lưu";
        }

        private void linksuach_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbltrogiup.Text = "*Sửa câu hỏi " + Environment.NewLine + "1.nhấp vào câu hỏi cần sửa " + Environment.NewLine + "2.thông tin câu hỏi sẽ hiện vào ô tương ứng" + Environment.NewLine + "3.nhấp vào Sửa " + Environment.NewLine + "4.sửa thông tin cần thay đổi" + Environment.NewLine + "5.sau khi sửa xong nhấp vào Lưu";
        
    }

        private void linkxoach_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbltrogiup.Text = "*Xóa câu hỏi" + Environment.NewLine + "1.nhấp vào câu hỏi cần xóa " + Environment.NewLine + " 2.thông tin câu hỏi sẽ hiện vào ô tương ứng" + Environment.NewLine + " 3.nhấp vào Xóa ";
        
    }

        private void linktimmt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbltrogiup.Text = "*Tìm kiếm môn thi" + Environment.NewLine + "1.Nhập thông tin tìm kiếm (mã môn hoặc tên môn) vào ô tìm kiếm " + Environment.NewLine + " 2.Thông tin sẽ hiện ra bảng danh sách Môn thi ở bên dưới";

        }

        private void linkthemmt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbltrogiup.Text = "*Thêm môn thi" + Environment.NewLine + "1.Nhấp chuột vào Thêm " + Environment.NewLine + " 2.nhập thông tin vào các ô tương ứng" + Environment.NewLine + " 3.sau khi nhập đầy đủ thông tin thì nhấp chuột vào Lưu";
        
    }

        private void linksuamt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbltrogiup.Text = "*Sửa môn thi" + Environment.NewLine + "1.nhấp vào môn thi cần sửa" + Environment.NewLine + " 2.thông tin môn thi sẽ hiện vào ô tương ứng" + Environment.NewLine + " 3.nhấp vào Sửa " + Environment.NewLine + "4.sửa thông tin cần thay đổi" + Environment.NewLine + " 5.sau khi sửa xong nhấp vào Lưu";

        }

        private void linkxoamt_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbltrogiup.Text = "*Xóa môn thi" + Environment.NewLine + "1.nhấp vào môn thi cần xóa" + Environment.NewLine + " 2.thông tin môn thi sẽ hiện vào ô tương ứng" + Environment.NewLine + "3.nhấp vào Xóa";
        
    }

        private void linktimsv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbltrogiup.Text = "* Tìm kiếm sinh viên" + Environment.NewLine + "1.Nhập thông tin tìm kiếm (mã sinh viên hoặc tên sinh viên) vào ô tìm kiếm" + Environment.NewLine + " 2.Thông tin sẽ hiện ra bảng ";
        
    }

        private void linkthemsv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbltrogiup.Text = "* Thêm sinh viên" + Environment.NewLine + "1.Nhấp chuột vào Thêm" + Environment.NewLine + " 2.nhập thông tin vào các ô tương ứng" + Environment.NewLine + " 3.sau khi nhập đầy đủ thông tin thì nhấp chuột vào Lưu";
        
    }

        private void linksuasv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbltrogiup.Text = "* Sửa thông tin sinh viên" + Environment.NewLine + "1.nhấp vào sinh viên cần sửa" + Environment.NewLine + " 2.thông tin sinh viên sẽ hiện vào ô tương ứng" + Environment.NewLine + "3.nhấp vào Sửa" + Environment.NewLine + " 4.sửa thông tin cần thay đổi" + Environment.NewLine + "5.sau khi sửa xong nhấp vào Lưu";
        
    }

        private void linkxoasv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbltrogiup.Text = "* Xóa thông tin sinh viên" + Environment.NewLine + "1.nhấp vào sinh viên cần xóa" + Environment.NewLine + " 2.thông tin sinh viên sẽ hiện vào ô tương ứng" + Environment.NewLine + "3.nhấp vào Xóa ";
        
    }

        private void label12_Click(object sender, EventArgs e)
        {
            lbltrogiup.Text = "*Xem bảng điểm " + Environment.NewLine + "1.Nhập tên lớp cần xem bảng điểm." + Environment.NewLine + "2.Chọn tên môn học." + Environment.NewLine + "3.Nhập vào MSV nếu cần xem điểm của 1 sinh viên." + Environment.NewLine + "4.Nhấn nút In nếu muốn in ra bảng điểm đã chọn.";
        
    }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbltrogiup.Text = "*Xem bảng điểm " + Environment.NewLine + "1.Nhập tên lớp cần xem bảng điểm." + Environment.NewLine + "2.Chọn tên môn học." + Environment.NewLine + "3.Nhập vào MSV nếu cần xem điểm của 1 sinh viên." + Environment.NewLine + "4.Nhấn nút In nếu muốn in ra bảng điểm đã chọn.";
        
    }

        private void label13_Click(object sender, EventArgs e)
        {
            lbltrogiup.Text = "*Xem bài thi " + Environment.NewLine + "1.Nhập MSV." + Environment.NewLine + "2.Chọn tên môn." + Environment.NewLine + "3.Chọn ngày thi." + Environment.NewLine + "4.Nhấn nút In nếu muốn in ra bài thi của sinh viên đó.";
        
    }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbltrogiup.Text = "*Xem bài thi " + Environment.NewLine + "1.Nhập MSV." + Environment.NewLine + "2.Chọn tên môn." + Environment.NewLine + "3.Chọn ngày thi." + Environment.NewLine + "4.Nhấn nút In nếu muốn in ra bài thi của sinh viên đó.";
        
    }


        //NÚT PHẦN BÁO CÁO
        private void txtmsv_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (grbtim.Text == "Bảng điểm")
                {
                    sql = "SELECT KETQUA.MaSV as 'Mã SV', SV.Hodem as 'Họ đệm', SV.Ten as 'Tên', MONTHI.Tenmon as 'Tên Môn', KETQUA.Diem AS 'Điểm', KETQUA.Lanthi as 'Lần thi', LOP.MaL AS 'Mã Lớp' " +
                          "FROM KETQUA " +
                          "INNER JOIN SV ON KETQUA.MaSV = SV.MaSV " +
                          "INNER JOIN MONTHI ON MONTHI.MaM = KETQUA.MaM " +
                          "INNER JOIN LOPSV ON LOPSV.MaSV = SV.MaSV " +
                          "INNER JOIN LOP ON LOP.MaL = LOPSV.MaL " +
                          "WHERE KETQUA.MaSV LIKE '%' + @MaSV + '%'";
                }
                else
                {
                    sql = "SELECT DISTINCT BAILAM.MaSV as 'Mã SV', SV.Hodem + '' + SV.Ten as 'Họ Tên', MONTHI.Tenmon as 'Tên môn', BAILAM.MaCH as 'Mã CH', BAILAM.Traloi as 'Trả lời', BAILAM.Ngaythi as 'Ngày thi' " +
                          "FROM BAILAM " +
                          "INNER JOIN SV ON BAILAM.MaSV = SV.MaSV " +
                          "INNER JOIN MONTHI ON MONTHI.MaM = CAUHOI.MaM " +
                          "INNER JOIN CAUHOI ON BAILAM.MaCH = CAUHOI.MaCH " +
                          "WHERE BAILAM.MaSV LIKE '%' + @MaSV + '%'";
                }

                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaSV", txtmsv.Text);

                dt = new DataTable();
                dt.Clear();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvbc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thực hiện truy vấn: {ex.Message}");
                // Xử lý ngoại lệ theo nhu cầu của bạn
            }
        }

        private void picbangdiem_Click(object sender, EventArgs e)
        {
            try
            {
                grbtim.Text = "Bảng điểm";
                sql = "SELECT KETQUA.MaSV as 'Mã SV', SV.Hodem as 'Họ đệm', SV.Ten as 'Tên', MONTHI.Tenmon as 'Tên Môn', LOP.MaL AS 'Mã Lớp', KETQUA.Diem AS 'Điểm', KETQUA.Lanthi as 'Lần thi' " +
                      "FROM KETQUA " +
                      "INNER JOIN SV ON KETQUA.MaSV = SV.MaSV " +
                      "INNER JOIN MONTHI ON MONTHI.MaM = KETQUA.MaM " +
                      "INNER JOIN LOPSV ON LOPSV.MaSV = SV.MaSV " +
                      "INNER JOIN LOP ON LOP.MaL = LOPSV.MaL";

                

                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Clear();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvbc.DataSource = dt;

                dgvbc.Columns["Tên"].DisplayIndex = 2;
                dgvbc.Columns["Tên Môn"].DisplayIndex = 3;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thực hiện truy vấn: {ex.Message}");
                // Xử lý ngoại lệ theo nhu cầu của bạn
            }
        }

        private void picbaithi_Click(object sender, EventArgs e)
        {
            try
            {
                grbtim.Text = "Bài làm";
                sql = "SELECT DISTINCT BAILAM.MaSV as 'Mã SV', SV.Hodem + '' + SV.Ten as 'Họ Tên', MONTHI.Tenmon as 'Tên môn', BAILAM.MaCH as 'Mã CH', BAILAM.Traloi as 'Trả lời', BAILAM.Ngaythi as 'Ngày thi' " +
                      "FROM BAILAM " +
                      "INNER JOIN SV ON BAILAM.MaSV = SV.MaSV " +
                      "INNER JOIN CAUHOI ON BAILAM.MaCH = CAUHOI.MaCH " +
                      "INNER JOIN MONTHI ON MONTHI.MaM = CAUHOI.MaM";

                cmd = new SqlCommand(sql, conn);
                dt = new DataTable();
                dt.Clear();
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvbc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thực hiện truy vấn: {ex.Message}");
                // Xử lý ngoại lệ theo nhu cầu của bạn
            }
        }
    




        private void tabquanly_Click(object sender, EventArgs e)
        {

        }

        private void grbtimch_Enter(object sender, EventArgs e)
        {

        }

        private void cmbtenmon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvmenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex >= 0 && e.RowIndex < dgvmenu.Rows.Count)
             {
                // CÂU HỎI
                if (grbcauhoi.Text == "Danh sách câu hỏi")
                {
                    txtmach.Text = dgvmenu[0, e.RowIndex].Value.ToString();
                    cmbmon.Text = dgvmenu[1, e.RowIndex].Value.ToString();
                    txtnoidung.Text = dgvmenu[2, e.RowIndex].Value.ToString();
                    cmbdapan.Text = dgvmenu[3, e.RowIndex].Value.ToString();
                    comboBoxChuong.Text = dgvmenu[4, e.RowIndex].Value.ToString();


                    // Hiển thị nút btnsua và btnxoa khi chọn danh sách câu hỏi
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                }
                // MÔN THI
                else if (grbcauhoi.Text == "Danh sách môn thi")
                {
                    txtmamon.Text = dgvmenu[0, e.RowIndex].Value.ToString();
                    txttenmon.Text = dgvmenu[1, e.RowIndex].Value.ToString();
                    txtsocau.Text = dgvmenu[2, e.RowIndex].Value.ToString();
                    txtthoigian.Text = dgvmenu[3, e.RowIndex].Value.ToString();
                    dtptgthi.Text = dgvmenu[4, e.RowIndex].Value.ToString();

                    // Hiển thị nút btnsua và btnxoa khi chọn danh sách môn thi
                    btnsua.Enabled = true;
                    btnxoa.Enabled = true;
                }
                // SINH VIÊN
                else if (grbcauhoi.Text == "Danh sách sinh viên")
                {
                    txtmamon.Text = dgvmenu[0, e.RowIndex].Value.ToString();
                    txttenmon.Text = dgvmenu[1, e.RowIndex].Value.ToString();
                    txtsocau.Text = dgvmenu[2, e.RowIndex].Value.ToString();
                    txtthoigian.Text = dgvmenu[4, e.RowIndex].Value.ToString();
                    dtptgthi.Text = dgvmenu[3, e.RowIndex].Value.ToString();

                    // Ẩn nút btnsua và btnxoa khi chọn danh sách sinh viên
                    btnsua.Enabled = false;
                    btnxoa.Enabled = false;
                }
             }    
    
        
    
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); // đóng form này
            Form f = new frmlogin(); // mở lại form đăng nhập
            f.ShowDialog();
        }

        private void btnexit2_Click(object sender, EventArgs e)
        {
            this.Close(); // đóng form này
            Form f = new frmlogin(); // mở lại form đăng nhập
            f.ShowDialog();
        }

        private void thoátChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
             this.Close(); // đóng form này
             Form f = new frmlogin(); // mở lại form đăng nhập
             f.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void dgvmenu_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbtenmon_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string maMonParam = $"%{cmbtenmon.Text}%";
                SqlParameter parameter = new SqlParameter("@MaMon", SqlDbType.NVarChar);
                parameter.Value = maMonParam;

                if (grbtim.Text == "Bảng điểm")
                {
                    sql = "SELECT KETQUA.MaSV as 'Mã SV', SV.Hodem as 'Họ đệm', SV.Ten as 'Tên', MONTHI.Tenmon as 'Tên Môn', LOP.MaL AS 'Mã Lớp', KETQUA.Diem AS 'Điểm', KETQUA.Lanthi as 'Lần thi' " +
                          "FROM KETQUA " +
                          "INNER JOIN SV ON KETQUA.MaSV = SV.MaSV " +
                          "INNER JOIN MONTHI ON MONTHI.MaM = KETQUA.MaM " +
                          "INNER JOIN LOPSV ON LOPSV.MaL = LOP.MaL AND LOPSV.MaSV = SV.MaSV " +
                          "INNER JOIN LOP ON LOP.MaM = MONTHI.MaM" +
                          " WHERE KETQUA.MaM LIKE @MaMon";
                }
                else
                {
                    sql = "SELECT DISTINCT BAILAM.MaSV as 'Mã SV', SV.Hodem + '' + SV.Ten as 'Họ Tên', MONTHI.Tenmon as 'Tên môn', BAILAM.MaCH as 'Mã CH', BAILAM.Traloi as 'Trả lời', BAILAM.Ngaythi as 'Ngày thi' " +
                          "FROM BAILAM " +
                          "INNER JOIN SV ON BAILAM.MaSV = SV.MaSV " +
                          "INNER JOIN MONTHI ON MONTHI.MaM = CAUHOI.MaM " +
                          "INNER JOIN CAUHOI ON BAILAM.MaCH = CAUHOI.MaCH" +
                          " WHERE MONTHI.MaM LIKE @MaMon";
                }

                dt = new DataTable();
                dt.Clear();
                cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(parameter);

                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dgvbc.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thực hiện truy vấn: {ex.Message}");
                // Xử lý ngoại lệ theo nhu cầu của bạn
            }
        }


        private void txtMalop_TextChanged(object sender, EventArgs e)
        {
            if (grbtim.Text == "Bảng điểm")
            {
                string query = "SELECT KETQUA.MaSV as 'Mã SV', SV.Hodem as 'Họ đệm', SV.Ten as 'Tên', MONTHI.Tenmon as 'Tên Môn', LOP.MaL AS 'Mã Lớp', KETQUA.Diem AS 'Điểm', KETQUA.Lanthi as 'Lần thi' " +
                               "FROM KETQUA, SV, MONTHI, LOP, LOPSV " +
                               "WHERE LOPSV.MaL = LOP.MaL AND LOP.MaM = MONTHI.MaM AND MONTHI.MaM = KETQUA.MaM AND LOPSV.MaSV = SV.MaSV AND KETQUA.MaSV = SV.MaSV and LOP.MaL like @MaLop";

                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaLop", "%" + txtMalop.Text + "%");

                        using (DataTable dt = new DataTable())
                        {
                            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            {
                                da.Fill(dt);
                                dgvbc.DataSource = dt;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi thực hiện truy vấn: {ex.Message}");
                }
            }
            else
            {
                txtMalop.Visible = false;
                label8.Visible = false;
            }
        }

        private void btnbclop_Click(object sender, EventArgs e)
        {
            try
            {
                rptlop rpt = new rptlop();
                string query = "SELECT DISTINCT LOP.MaL, TenL, SV.MaSV, Hodem, Ten, KETQUA.Diem, Lanthi " +
                               "FROM LOP, SV, KETQUA, LOPSV " +
                               "WHERE SV.MaSV = KETQUA.MaSV AND SV.MaSV = LOPSV.MaSV AND LOPSV.MaL = LOP.MaL AND LOPSV.MaL = @MaLop";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaLop", txtMalop.Text);

                    using (DataTable datarpt = new DataTable("dtDiemtheolop"))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(datarpt);
                            rpt.SetDataSource(datarpt);
                        }
                    }
                }

                rptlopprv rp = new rptlopprv(rpt);
                rp.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thực hiện truy vấn: {ex.Message}");
            }
        }

        private void btnbcmon_Click(object sender, EventArgs e)
        {
            try
            {
                rptmon rpt = new rptmon();
                string query = "SELECT DISTINCT MONTHI.MaM, MONTHI.Tenmon, SV.MaSV, Hodem, Ten, KETQUA.Diem, Lanthi " +
                               "FROM MONTHI, SV, KETQUA, LOP, LOPSV " +
                               "WHERE SV.MaSV = KETQUA.MaSV AND SV.MaSV = LOPSV.MaSV AND LOP.MaM = MONTHI.MaM AND LOPSV.MaL = LOP.MaL AND MONTHI.MaM = @MaMon";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MaMon", cmbtenmon.Text);

                    using (DataTable datarpt = new DataTable("dtDiemtheomon"))
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(datarpt);
                            rpt.SetDataSource(datarpt);
                        }
                    }
                }

                rptmonprv rp = new rptmonprv(rpt);
                rp.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thực hiện truy vấn: {ex.Message}");
            }
        }



        private void txtmach_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbmon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbtenmon_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbltrogiup_Click(object sender, EventArgs e)
        {

        }

        private void tabtrogiup_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dgvbc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grbtim_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panelcauhoi_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grbchitietch_Enter(object sender, EventArgs e)
        {

        }

        private void lblmonthi_Click(object sender, EventArgs e)
        {

        }

        private void txttenmon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnoidung_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtthoigian_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbdapan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbldapan_Click(object sender, EventArgs e)
        {

        }

        private void dtptgthi_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbltgthi_Click(object sender, EventArgs e)
        {

        }

        private void lblthoigian_Click(object sender, EventArgs e)
        {

        }

        private void txtsocau_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblsocau_Click(object sender, EventArgs e)
        {

        }

        private void lblnoidungch_Click(object sender, EventArgs e)
        {

        }

        private void lbltenmon_Click(object sender, EventArgs e)
        {

        }

        private void txtmamon_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblmach_Click(object sender, EventArgs e)
        {

        }

        private void lblmamon_Click(object sender, EventArgs e)
        {

        }

        private void grbcauhoi_Enter(object sender, EventArgs e)
        {

        }

        private void lblloc_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tHITRACNGHIEMDataSetBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void mONTHIBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        //NÚT TÌM KIẾM
        private void txttim_TextChanged(object sender, EventArgs e)
        {
            if (grbcauhoi.Text == "Danh sách câu hỏi")
            {
                sql = "select * from CAUHOI where MaCH like '%" + txttim.Text + "%' or MaM like '%" + txttim.Text + "%' or Noidung like '%" + txttim.Text + "%'" ;
            }
            if (grbcauhoi.Text == "Danh sách môn thi")
            {
                sql = " select * from MONTHI where MaM like '%" + txttim.Text + "%' or TenMon like N'%" + txttim.Text + "%'";
            }
            if (grbcauhoi.Text == "Danh sách sinh viên")
            {
                sql = "select * from SV where MaSV like '%" + txttim.Text + "%' or Ten like N'%" + txttim.Text + "%'";
            }
            try
            {
                LoadDuLieu(sql);
            }
            catch { }
        }







    }
    
}
