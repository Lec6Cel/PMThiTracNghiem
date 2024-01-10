using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMTHITN
{

    public partial class frmadmin : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        SqlCommand lenh = new SqlCommand();
        string sql, constr;
        // Trong class frmadmin, thêm một biến để theo dõi loại tài khoản (Giảng viên hoặc Sinh viên)
        public frmadmin()
        {
            InitializeComponent();

        }


        private void frmadmin_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'tHITRACNGHIEMDataSet1.SV' table. You can move, or remove it, as needed.
            //this.sVTableAdapter.Fill(this.tHITRACNGHIEMDataSet1.SV);
            //// TODO: This line of code loads data into the 'tHITRACNGHIEMDataSet1.GV' table. You can move, or remove it, as needed.
            //this.gVTableAdapter.Fill(this.tHITRACNGHIEMDataSet1.GV);
            constr = "Data Source=MSI\\MSSQLSERVER01;Initial Catalog=THITRACNGHIEM;Integrated Security=True;Encrypt=False";
            conn.ConnectionString = constr;
            conn.Open();

        }

        private void LoadData(string sql)
        {
            try
            {
                dt = new DataTable();
                da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
                dgvdanhsach.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi nạp dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void TaiKhoan(Boolean a)
        {
            txtID.Enabled = a;
            txthodem.Enabled = a;
            txtten.Enabled = a;
            dtpngaysinh.Enabled = a;
            txtmatkhau.Enabled = a;
            txttrangthai.Enabled = a;

        }
        private void Clean()
        {
            txtID.Clear();
            txthodem.Clear();
            txtten.Clear();
            txtmatkhau.Clear();
            dtpngaysinh.Text = "";
            txttrangthai.Clear();
        }

        private void dgvdanhsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.RowIndex < dgvdanhsach.Rows.Count)
            {
                // GIẢNG VIÊN
                if (grbdanhsach.Text == "Danh sách tài khoản giảng viên")
                {
                    txtID.Text = dgvdanhsach[0, e.RowIndex].Value?.ToString();
                    txthodem.Text = dgvdanhsach[1, e.RowIndex].Value?.ToString();
                    txtten.Text = dgvdanhsach[2, e.RowIndex].Value?.ToString();
                    txtmatkhau.Text = dgvdanhsach[3, e.RowIndex].Value?.ToString();
                    txttrangthai.Text = dgvdanhsach[4, e.RowIndex].Value?.ToString();
                }
                // SINH VIÊN
                if (grbdanhsach.Text == "Danh sách tài khoản sinh viên")
                {
                    txtID.Text = dgvdanhsach[0, e.RowIndex].Value?.ToString();
                    txthodem.Text = dgvdanhsach[1, e.RowIndex].Value?.ToString();
                    txtten.Text = dgvdanhsach[2, e.RowIndex].Value?.ToString();
                    dtpngaysinh.Text = dgvdanhsach[3, e.RowIndex].Value?.ToString();
                    txtmatkhau.Text = dgvdanhsach[4, e.RowIndex].Value?.ToString();
                    txttrangthai.Text = dgvdanhsach[5, e.RowIndex].Value?.ToString();
                }
               

                btnsua.Enabled = true;
                btnxoa.Enabled = true;
            }
        }


        private void dgvdanhsach_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvdanhsach.Rows.Count)
            {
                // GIẢNG VIÊN
                if (grbdanhsach.Text == "Danh sách tài khoản giảng viên")
                {
                    txtID.Text = dgvdanhsach[0, e.RowIndex].Value?.ToString();
                    txthodem.Text = dgvdanhsach[1, e.RowIndex].Value?.ToString();
                    txtten.Text = dgvdanhsach[2, e.RowIndex].Value?.ToString();
                    txtmatkhau.Text = dgvdanhsach[3, e.RowIndex].Value?.ToString();
                    txttrangthai.Text = dgvdanhsach[4, e.RowIndex].Value?.ToString();
                }
                // SINH VIÊN
                if (grbdanhsach.Text == "Danh sách tài khoản sinh viên")
                {
                    txtID.Text = dgvdanhsach[0, e.RowIndex].Value?.ToString();
                    txthodem.Text = dgvdanhsach[1, e.RowIndex].Value?.ToString();
                    txtten.Text = dgvdanhsach[2, e.RowIndex].Value?.ToString();
                    dtpngaysinh.Text = dgvdanhsach[3, e.RowIndex].Value?.ToString();
                    txtmatkhau.Text = dgvdanhsach[4, e.RowIndex].Value?.ToString();
                    txttrangthai.Text = dgvdanhsach[5, e.RowIndex].Value?.ToString();

                }

                btnsua.Enabled = true;
                btnxoa.Enabled = true;
            }
        }


        //PHẦN QUẢN LÝ GIẢNG VIÊN
        private void picGV_Click(object sender, EventArgs e)
        {
            //lblMaGV.Text = "Mã GV";
            //lblhodem.Text = "Họ đệm";
            //lblten.Text = "Tên";
            //lblmatkhau.Text = "Mật khẩu";



            lblMaSV.Visible = false;
            lblngaysinh.Visible = false;
            dtpngaysinh.Visible = false;

            lblMaGV.Visible = true;
            lblhodem.Visible = true;
            lblten.Visible = true;
            lblmatkhau.Visible = true;
            txtID.Visible = true;
            txthodem.Visible = true;
            txtten.Visible = true;
            txtmatkhau.Visible = true;
            txttrangthai.Visible = true;
            Clean();
            grbdanhsach.Text = "Danh sách tài khoản giảng viên";
            sql = "select ID_gv as 'Mã GV', Hodem as 'Họ đệm', Ten as ' Tên', Pass as 'Mật khẩu', Trangthai as 'Trạng thái' from GV";
            LoadData(sql);

            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            txtID.Enabled = false;
            txthodem.Enabled = false;
            txtten.Enabled = false;
            txtmatkhau.Enabled = false;
            txttrangthai.Enabled = false;
        }



        //PHẦN QUẢN LÝ SINH VIÊN
        private void picSV_Click(object sender, EventArgs e)
        {

            lblMaGV.Visible = false;

            lblMaSV.Visible = true;
            lblhodem.Visible = true;
            lblten.Visible = true;
            lblmatkhau.Visible = true;
            lblngaysinh.Visible = true;
            txtID.Visible = true;
            txthodem.Visible = true;
            txtten.Visible = true;
            txtmatkhau.Visible = true;
            dtpngaysinh.Visible = true;
            txttrangthai.Visible = true;
            Clean();
            grbdanhsach.Text = "Danh sách tài khoản sinh viên";
            sql = "select MaSV as 'Mã SV', Hodem as 'Họ đệm', Ten as ' Tên', Ngaysinh as 'Ngày sinh', Matkhau as 'Mật khẩu', Trangthai as 'Trạng thái' from SV";
            LoadData(sql);

            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            txtID.Enabled = false;
            txthodem.Enabled = false;
            txtten.Enabled = false;
            txtmatkhau.Enabled = false;
            dtpngaysinh.Enabled = false;
            txttrangthai.Enabled = false;

        }



        private void btnthem_Click(object sender, EventArgs e)
        {
            if (dgvdanhsach.Rows.Count > 0)
            {
                dgvdanhsach.CurrentCell = dgvdanhsach[0, dgvdanhsach.RowCount - 1];
                txtID.Focus();
                txtID.Focus();
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Hoặc thực hiện xử lý khác tùy thuộc vào logic ứng dụng của bạn.
            }
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            txttrangthai.Enabled = false;
            btnhuy.Enabled = true;
            btnluu.Enabled = true;
            TaiKhoan(true);
            Clean();
        }



        private void btnsua_Click(object sender, EventArgs e)
        {
            btnthem.Enabled = false;
            btnxoa.Enabled = false;
            txttrangthai.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            TaiKhoan(true);
        }



        private void btnhuy_Click(object sender, EventArgs e)
        {
            btnluu.Enabled = false;
            btnhuy.Enabled = false;
            txttrangthai.Enabled=false;
            btnxoa.Enabled = false;
            btnsua.Enabled = false;
            TaiKhoan(false);
            Clean();
            btnthem.Enabled = true;
        }

        private void dtpngaysinh_ValueChanged(object sender, EventArgs e)
        {

        }



        private void btnluu_Click(object sender, EventArgs e)
        {
            string ngaysinh = dtpngaysinh.Value.ToString("yyyy-MM-dd");
            string trangThai = "Active"; // Giá trị mặc định cho cột TrangThai
            string maSV = txtID.Text; // Giả sử MaSV được nhập từ người dùng
            bool maSVExists = false;

            try
            {
                if (btnthem.Enabled == true)
                {
                    maSVExists = KiemTraMaSVTonTai(txtID.Text);

                    if (maSVExists)
                    {
                        MessageBox.Show("Mã sinh viên đã tồn tại. Vui lòng chọn mã sinh viên khác.");
                        return;
                    }

                    string insertSql = (grbdanhsach.Text == "Danh sách tài khoản giảng viên")
                        ? "INSERT INTO GV VALUES (@ID, @Hodem, @Ten, @Matkhau, @TrangThai)"
                        : "INSERT INTO SV VALUES (@ID, @Hodem, @Ten, @Ngaysinh, @Matkhau, @TrangThai)";

                    ExecuteNonQueryWithParameters(insertSql, txtID.Text, txthodem.Text, txtten.Text, ngaysinh, txtmatkhau.Text, trangThai);

                    MessageBox.Show("Thêm mới thành công!");
                    LoadData(GetSelectSql());
                }

                if (btnsua.Enabled == true)
                {
                    string updateSql = (grbdanhsach.Text == "Danh sách tài khoản giảng viên")
                        ? "UPDATE GV SET  Hodem = @Hodem, Ten = @Ten, Pass = @Matkhau, Trangthai = @TrangThai WHERE ID_gv = @ID"
                        : "UPDATE SV SET Hodem = @Hodem, Ten = @Ten, Ngaysinh = @Ngaysinh, Matkhau = @Matkhau, Trangthai = @TrangThai WHERE MaSV = @ID";

                    ExecuteNonQueryWithParameters(updateSql, txtID.Text, txthodem.Text, txtten.Text, ngaysinh, txtmatkhau.Text, trangThai);

                    MessageBox.Show("Sửa thành công!");
                    LoadData(GetSelectSql());
                }

                // Các bước khác sau khi thêm/sửa
                btnluu.Enabled = false;
                btnhuy.Enabled = false;
                txttrangthai.Enabled = false;
                btnxoa.Enabled = false;
                btnsua.Enabled = false;
                TaiKhoan(false);
                Clean();
                btnthem.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Xử lý ngoại lệ theo nhu cầu của bạn
            }
        }

        private void ExecuteNonQueryWithParameters(string sql, params object[] values)
        {
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                string[] paramNames = { "@ID", "@Hodem", "@Ten", "@Ngaysinh", "@Matkhau", "@TrangThai" };

                for (int i = 0; i < paramNames.Length; i++)
                {
                    cmd.Parameters.AddWithValue(paramNames[i], values[i]);
                }

                // Thực hiện truy vấn
                cmd.ExecuteNonQuery();
            }
        }

        private string GetSelectSql()
        {
            return (grbdanhsach.Text == "Danh sách tài khoản giảng viên") ? "SELECT * FROM GV" : "SELECT * FROM SV";
        }

        private bool KiemTraMaSVTonTai(string maSV)
        {
            using (SqlConnection connection = new SqlConnection(constr))
            {
                connection.Open();
                string query = $"SELECT COUNT(*) FROM SV WHERE MaSV = @MaSV";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MaSV", maSV);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }



        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txthodem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtten_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttim_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sqlCommand = "";
                string parameterName = "@SearchTerm";
                string searchTerm = "%" + txttim.Text + "%";

                if (grbdanhsach.Text == "Danh sách tài khoản giảng viên")
                {
                    sqlCommand = "SELECT * FROM GV WHERE ID_gv LIKE @SearchTerm OR Ten LIKE N@SearchTerm";
                }

                if (grbdanhsach.Text == "Danh sách tài khoản sinh viên")
                {
                    sqlCommand = "SELECT * FROM SV WHERE MaSV LIKE @SearchTerm OR Ten LIKE N@SearchTerm";
                }

                using (SqlCommand cmd = new SqlCommand(sqlCommand, conn))
                {
                    cmd.Parameters.AddWithValue(parameterName, searchTerm);

                    LoadData(cmd.CommandText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}");
                // Xử lý ngoại lệ theo nhu cầu của bạn
            }

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {

            this.Close(); // đóng form này
            Form f = new frmlogin(); // mở lại form đăng nhập
            f.ShowDialog();
        }

        private void grbdanhsach_Enter(object sender, EventArgs e)
        {

        }

        private void grbtaikhoan_Enter(object sender, EventArgs e)
        {

        }


        private void btnmotaikhoan_Click(object sender, EventArgs e)
        {
            try
            {
                string updateSql = "";
                string selectSql = "";

                if (grbdanhsach.Text == "Danh sách tài khoản giảng viên")
                {
                    updateSql = "UPDATE GV SET Trangthai = 'Active' WHERE ID_gv = @ID";
                    selectSql = "SELECT * FROM GV";
                }

                if (grbdanhsach.Text == "Danh sách tài khoản sinh viên")
                {
                    updateSql = "UPDATE SV SET Trangthai = 'Active' WHERE MaSV = @ID";
                    selectSql = "SELECT * FROM SV";
                }

                using (SqlCommand updateCmd = new SqlCommand(updateSql, conn))
                {
                    updateCmd.Parameters.AddWithValue("@ID", txtID.Text);
                    updateCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Mở khóa tài khoản thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData(selectSql);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi mở khóa tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnkhoataikhoan_Click(object sender, EventArgs e)
        {
            try
            {
                string updateSql = "";
                string selectSql = "";

                if (grbdanhsach.Text == "Danh sách tài khoản giảng viên")
                {
                    updateSql = "UPDATE GV SET Trangthai = 'Khóa' WHERE ID_gv = @ID";
                    selectSql = "SELECT * FROM GV";
                }

                if (grbdanhsach.Text == "Danh sách tài khoản sinh viên")
                {
                    updateSql = "UPDATE SV SET Trangthai = 'Khóa' WHERE MaSV = @ID";
                    selectSql = "SELECT * FROM SV";
                }

                using (SqlCommand updateCmd = new SqlCommand(updateSql, conn))
                {
                    updateCmd.Parameters.AddWithValue("@ID", txtID.Text);
                    updateCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Đóng tài khoản thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData(selectSql);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đóng tài khoản: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Xóa dữ liệu", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string deleteSql = "";
                    string selectSql = "";

                    if (grbdanhsach.Text == "Danh sách tài khoản giảng viên")
                    {
                        deleteSql = "DELETE FROM GV WHERE ID_gv = @ID";
                        selectSql = "SELECT * FROM GV";
                    }

                    if (grbdanhsach.Text == "Danh sách tài khoản sinh viên")
                    {
                        deleteSql = "DELETE FROM SV WHERE MaSV = @ID";
                        selectSql = "SELECT * FROM SV";
                    }

                    using (SqlCommand deleteCmd = new SqlCommand(deleteSql, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@ID", txtID.Text);
                        deleteCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã Xóa", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadData(selectSql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
