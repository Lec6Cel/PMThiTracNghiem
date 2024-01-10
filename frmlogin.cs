
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
    public partial class frmlogin : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        Boolean gvflag = false;
        Boolean svflag = false;
        Boolean adminflag = false;
        bool loginflag;

        public frmlogin()
        {
            InitializeComponent();
        }

        private void linkquenmk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Bạn vui lòng thông báo với giám thị coi thi để xin cấp lại Mật khẩu)", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (loginflag == false)
            {
                if (gvflag == false && svflag == false && adminflag == false)
                {
                    MessageBox.Show("Vui lòng chọn 'Sinh viên', 'Giảng viên', hoặc 'Admin' trước khi đăng nhập.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string taiKhoan = txtuser.Text;
                string matKhau = txtmk.Text;

                bool loginSuccess = false;
                bool accountLocked = false;
                bool adminfail = false;

                if (gvflag)
                {
                    loginSuccess = KiemTraDangNhapGV(taiKhoan, matKhau, out accountLocked);
                    if (loginSuccess)
                    {
                        // Đăng nhập thành công, mở form giảng viên
                        frmgv child = new frmgv();
                        child.Show();
                        this.Hide();
                        loginflag = true;
                    }
                }
                else if (svflag)
                {
                    loginSuccess = KiemTraDangNhapSV(taiKhoan, matKhau, out accountLocked);

                    if (loginSuccess)
                    {
                        // Thực hiện kiểm tra đăng nhập sử dụng tham số để tránh SQL injection
                        sql = "SELECT COUNT(*) FROM SV WHERE MaSV = @MaSV AND Matkhau = @Matkhau";
                        try
                        {
                            if (conn.State == ConnectionState.Closed)
                            {
                                conn.Open();
                            }

                            using (SqlCommand cmd = new SqlCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@MaSV", txtuser.Text);
                                cmd.Parameters.AddWithValue("@Matkhau", txtmk.Text);

                                int val = (int)cmd.ExecuteScalar();

                                if (val == 1)
                                {
                                    // Lấy thông tin MSV truyền vào public
                                    try
                                    {
                                        thongtinsv.MSV = txtuser.Text.ToString();
                                    }
                                    catch { }

                                    // Đăng nhập thành công, mở form sinh viên
                                    frminfo child = new frminfo();
                                    child.Show();
                                    this.Hide();
                                    loginflag = true;
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Lỗi khi thực hiện truy vấn: {ex.Message}");
                        }
                        finally
                        {
                            // Đảm bảo đóng kết nối sau khi sử dụng
                            if (conn.State == ConnectionState.Open)
                            {
                                conn.Close();
                            }
                        }
                    }
                }

                else if (adminflag)
                {
                    loginSuccess = KiemTraDangNhapAdmin(taiKhoan, matKhau, out adminfail);
                    if (loginSuccess)
                    {
                        // Đăng nhập thành công, mở form admin
                        frmadmin child = new frmadmin();
                        child.Show();
                        this.Hide();
                        loginflag = true;
                    }

                }
                // Kiểm tra tài khoản bị khóa
              
                if (!loginSuccess && accountLocked)
                {
                    MessageBox.Show("Tài khoản đã bị khóa. Vui lòng liên hệ quản trị viên.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (!loginSuccess)
                {
                    if (adminflag && adminfail)
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu hoặc tài khoản bị khóa.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    loginflag = false;
                }
            }
        }

        private bool KiemTraDangNhapAdmin(string taiKhoan, string matKhau, out bool adminfail)
        {
            adminfail = false; // Khởi tạo giá trị mặc định

            try
            {
                using (SqlConnection connection = new SqlConnection(constr))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM ADMIN WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                        command.Parameters.AddWithValue("@MatKhau", matKhau);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            return true;
                        }
                        else
                        {
                            // Nếu đăng nhập không thành công, thiết lập adminfail và trả về false
                            adminfail = true;
                            return false;
                        }
                    }
                }
            }
            catch (Exception)
            {
                // Nếu có lỗi xảy ra, thiết lập adminfail và trả về false
                adminfail = true;
                return false;
            }
        }




        private bool KiemTraDangNhapGV(string taiKhoan, string matKhau, out bool accountLocked)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(constr))
                {
                    connection.Open();

                    // Sử dụng tham số để tránh SQL injection
                    string query = "SELECT COUNT(*) FROM GV WHERE ID_gv = @TaiKhoan AND Pass = @MatKhau";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                        command.Parameters.AddWithValue("@MatKhau", matKhau);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            // Kiểm tra trạng thái tài khoản
                            query = "SELECT TrangThai FROM GV WHERE ID_gv = @TaiKhoan";
                            command.CommandText = query;

                            string trangThai = command.ExecuteScalar()?.ToString();

                            if (trangThai == "Active")
                            {
                                accountLocked = false;
                                return true; // Tài khoản hợp lệ và mở
                            }
                            else if (trangThai == "Khóa")
                            {
                                accountLocked = true;
                                return false; // Tài khoản bị khóa
                            }
                        }
                    }

                    accountLocked = false;
                    return false; // Tài khoản không hợp lệ
                }
            }
            catch (Exception)
            {
                accountLocked = false;
                return false;
            }
        }


        private bool KiemTraDangNhapSV(string taiKhoan, string matKhau, out bool accountLocked)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(constr))
                {
                    connection.Open();

                    // Sử dụng tham số để tránh SQL injection
                    string query = "SELECT COUNT(*) FROM SV WHERE MaSV = @TaiKhoan AND MatKhau = @MatKhau";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TaiKhoan", taiKhoan);
                        command.Parameters.AddWithValue("@MatKhau", matKhau);

                        int count = (int)command.ExecuteScalar();

                        if (count > 0)
                        {
                            // Kiểm tra trạng thái tài khoản
                            query = "SELECT TrangThai FROM SV WHERE MaSV = @TaiKhoan";
                            command.CommandText = query;

                            string trangThai = command.ExecuteScalar()?.ToString();

                            if (trangThai == "Active")
                            {
                                accountLocked = false;
                                return true; // Tài khoản hợp lệ và mở
                            }
                            else if (trangThai == "Khóa")
                            {
                                accountLocked = true;
                                return false; // Tài khoản bị khóa
                            }
                        }
                    }

                    accountLocked = false;
                    return false; // Tài khoản không hợp lệ
                }
            }
            catch (Exception)
            {
                accountLocked = false;
                return false;
            }
        }




        private void btngv_Click(object sender, EventArgs e)
        {
            gvflag = true;
            svflag = false;
            adminflag = false;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
            loginflag = false;
            Application.Exit();
        }

        private void btngv_MouseClick(object sender, MouseEventArgs e)
        {
            btngv.BackColor = Color.DodgerBlue;
            btngv.TextColor = Color.White;
            gvflag = true;
            btnsv.BackColor = Color.FromName("Control");
            btnsv.TextColor = Color.Black;
            btnAdmin.BackColor = Color.FromName("Control");
            btnAdmin.TextColor = Color.Black;
            svflag = false;
            adminflag = false;
        }

        private void btnsv_MouseClick(object sender, MouseEventArgs e)
        {
            btnsv.BackColor = Color.DodgerBlue;
            btnsv.TextColor = Color.White;
            svflag = true;
            btngv.BackColor = Color.FromName("Control");
            btngv.TextColor = Color.Black;
            btnAdmin.BackColor = Color.FromName("Control");
            btnAdmin.TextColor = Color.Black;
            gvflag = false;
            adminflag = false;
        }

        private void btnAdmin_MouseClick(object sender, MouseEventArgs e)
        {
            btnAdmin.BackColor = Color.Red;
            btnAdmin.TextColor = Color.White;
            adminflag = true;
            btngv.BackColor = Color.FromName("Control");
            btngv.TextColor = Color.Black;
            btnsv.BackColor = Color.FromName("Control");
            btnsv.TextColor = Color.Black;
            gvflag = false;
            svflag = false;
        }

        private void btnsv_MouseHover(object sender, EventArgs e)
        {
            if (svflag == false)
            {
                btnsv.BackColor = Color.Black;
                btnsv.TextColor = Color.White;
            }
        }

        private void btngv_MouseHover(object sender, EventArgs e)
        {
            if (gvflag == false)
            {
                btngv.BackColor = Color.Black;
                btngv.TextColor = Color.White;
            }
        }

        private void btnAdmin_MouseHover(object sender, EventArgs e)
        {
            if (adminflag == false)
            {
                btnAdmin.BackColor = Color.Black;
                btnAdmin.TextColor = Color.White;
            }
        }


    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsv_Click(object sender, EventArgs e)
        {
            //gvflag = false;
            //svflag = true; // Bỏ chọn nút sinh viên
            //adminflag = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            //gvflag = false;
            //svflag = false; // Bỏ chọn nút sinh viên
            //adminflag = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

            constr = "Data Source=MSI\\MSSQLSERVER01;Initial Catalog=THITRACNGHIEM;Integrated Security=True;Encrypt=False";
            conn.ConnectionString = constr;
            conn.Open();
        }

    }
}
