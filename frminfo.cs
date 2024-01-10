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
    public partial class frminfo : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        public frminfo()
        {
            InitializeComponent();
        }

        private void btnvaothi_Click(object sender, EventArgs e)
        {
            // mở form bài thi
            this.Close();
            Form f = new frmbaithi();
            f.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grbtt_Enter(object sender, EventArgs e)
        {

        }

        private void lblhoten_Click(object sender, EventArgs e)
        {

        }

        private void lblhoten_Click_1(object sender, EventArgs e)
        {

        }

        private void frminfo_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("Data Source=MSI\\MSSQLSERVER01;Initial Catalog=THITRACNGHIEM;Integrated Security=True;Encrypt=False"))
                {
                    conn.Open();

                    DateTime today = DateTime.Now.Date;

                    string sql = "SELECT * FROM MONTHI WHERE Thoigianthi = @Today";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@Today", today);

                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }

                        if (dt.Rows.Count > 0)
                        {
                            lblmonthi.Text = dt.Rows[0][1].ToString();
                            lblsocau.Text = dt.Rows[0][2].ToString();
                            lblthoigian.Text = dt.Rows[0][3].ToString() + " phút";

                            string masinhvien = thongtinsv.MSV;

                            sql = "SELECT * FROM SV WHERE MaSV = @MaSV";

                            using (SqlCommand cmdSv = new SqlCommand(sql, conn))
                            {
                                cmdSv.Parameters.AddWithValue("@MaSV", masinhvien);

                                DataTable dtSv = new DataTable();
                                using (SqlDataAdapter daSv = new SqlDataAdapter(cmdSv))
                                {
                                    daSv.Fill(dtSv);
                                }

                                if (dtSv.Rows.Count > 0)
                                {
                                    lblhoten.Text = dtSv.Rows[0][1].ToString() + " " + dtSv.Rows[0][2].ToString();
                                    lblmsv.Text = thongtinsv.MSV;
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không có môn thi nào hôm nay. Vui lòng kiểm tra lại lịch thi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                            Form f = new frmlogin();
                            f.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thực hiện truy vấn: {ex.Message}");
            }
        }



    }
}

