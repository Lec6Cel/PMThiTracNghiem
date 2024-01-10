using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PMTHITN
{
    public partial class frmbaithi : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        public frmbaithi()
        {

            InitializeComponent();

        }
        private string LayDapAn(TableLayoutPanel table)
        {

            string chon = "f";
            RadioButton radio = null;
            try
            {
                foreach (RadioButton item in table.Controls)
                {
                    if (item.Checked == true)
                    {
                        radio = item;
                        break;
                    }
                }
                if (radio != null)
                {
                    chon = radio.Tag.ToString();
                }
                else
                {
                    chon = "f";
                }


            }
            catch
            { }
            return chon;

        }
        private void khoitao()
        {
            ckbdatco1.Visible = true;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
        }
        private void frmbaithi_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            // tách lấy số câu hiện tại
            String chuoi = grbnoidung.Text;
            string[] so = chuoi.Split(' ');
            int k = so.Length;
            int i = Convert.ToInt32(so[k - 1]);
            if (i > 1)
            {
                // hiển thị số câu.
                grbnoidung.Text = "Câu số " + (i - 1).ToString();
                // Chuyển nội dung câu hỏi tiếp theo
                lblnoidungcauhoi.Text = dt.Rows[i - 2][2].ToString();
            }
            else
            { }

        }


        private void btndone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void init()
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
        }
        private void btnnext_Click(object sender, EventArgs e)
        {
            // tách lấy số câu hiện tại
            String chuoi = grbnoidung.Text;
            string[] so = chuoi.Split(' ');
            int k = so.Length;
            int i = Convert.ToInt32(so[k - 1]);
            if (i < dulieu.TONGSOCAU)
            {
                //
                if ((i + 1) == 1)
                {
                    khoitao();
                }
                else if ((i + 1) == 2)
                {
                    init();
                    ckbdatco2.Visible = true;

                }
                else if ((i + 1) == 3)
                {
                    init();
                    ckbdatco3.Visible = true;
                }
                else if ((i + 1) == 4)
                {
                    init();
                    ckbdatco4.Visible = true;
                }
                else if ((i + 1) == 5)
                {
                    init();
                    ckbdatco5.Visible = true;
                }
                else if ((i + 1) == 6)
                {
                    init();
                    ckbdatco6.Visible = true;
                }
                else if ((i + 1) == 7)
                {
                    init();
                    ckbdatco7.Visible = true;
                }
                else if ((i + 1) == 8)
                {
                    init();
                    ckbdatco8.Visible = true;
                }
                else if ((i + 1) == 9)
                {
                    init();
                    ckbdatco9.Visible = true;
                }
                else if ((i + 1) == 10)
                {
                    init();
                    ckbdatco10.Visible = true;
                }
                else if ((i + 1) == 11)
                {
                    init();
                    ckbdatco11.Visible = true;
                }
                else if ((i + 1) == 12)
                {
                    init();
                    ckbdatco12.Visible = true;
                }
                else if ((i + 1) == 13)
                {
                    init();
                    ckbdatco13.Visible = true;
                }
                else if ((i + 1) == 14)
                {
                    init();
                    ckbdatco14.Visible = true;
                }
                else if ((i + 1) == 15)
                {
                    init();
                    ckbdatco15.Visible = true;
                }
                else if ((i + 1) == 16)
                {
                    init();
                    ckbdatco16.Visible = true;
                }
                else if ((i + 1) == 17)
                {
                    init();
                    ckbdatco17.Visible = true;
                }
                else if ((i + 1) == 18)
                {
                    init();
                    ckbdatco18.Visible = true;
                }
                else if ((i + 1) == 19)
                {
                    init();
                    ckbdatco19.Visible = true;
                }
                else if ((i + 1) == 20)
                {
                    init();
                    ckbdatco20.Visible = true;
                }
                else if ((i + 1) == 21)
                {
                    init();
                    ckbdatco21.Visible = true;
                }
                else if ((i + 1) == 22)
                {
                    init();
                    ckbdatco22.Visible = true;
                }
                else if ((i + 1) == 23)
                {
                    init();
                    ckbdatco23.Visible = true;
                }
                else if ((i + 1) == 24)
                {
                    init();
                    ckbdatco24.Visible = true;
                }
                else if ((i + 1) == 25)
                {
                    init();
                    ckbdatco25.Visible = true;
                }
                else if ((i + 1) == 26)
                {
                    init();
                    ckbdatco26.Visible = true;
                }
                else if ((i + 1) == 27)
                {
                    init();
                    ckbdatco27.Visible = true;
                }
                else if ((i + 1) == 28)
                {
                    init();
                    ckbdatco28.Visible = true;
                }
                else if ((i + 1) == 29)
                {
                    init();
                    ckbdatco29.Visible = true;
                }
                else if ((i + 1) == 30)
                {
                    init();
                    ckbdatco30.Visible = true;
                }
                else if ((i + 1) == 31)
                {
                    init();
                    ckbdatco31.Visible = true;
                }
                else if ((i + 1) == 32)
                {
                    init();
                    ckbdatco32.Visible = true;
                }
                else if ((i + 1) == 33)
                {
                    init();
                    ckbdatco33.Visible = true;
                }
                else if ((i + 1) == 34)
                {
                    init();
                    ckbdatco34.Visible = true;
                }
                else if ((i + 1) == 35)
                {
                    init();
                    ckbdatco35.Visible = true;
                }
                else if ((i + 1) == 36)
                {
                    init();
                    ckbdatco36.Visible = true;
                }
                else if ((i + 1) == 37)
                {
                    init();
                    ckbdatco37.Visible = true;
                }
                else if ((i + 1) == 38)
                {
                    init();
                    ckbdatco38.Visible = true;
                }
                else if ((i + 1) == 39)
                {
                    init();
                    ckbdatco39.Visible = true;
                }
                else if ((i + 1) == 40)
                {
                    init();
                    ckbdatco40.Visible = true;
                }
                // hiển thị số câu.
                grbnoidung.Text = "Câu số " + (i + 1).ToString();
                // Chuyển nội dung câu hỏi tiếp theo
                lblnoidungcauhoi.Text = dt.Rows[i][2].ToString();
            }
            else
            { }

        }


        private void timer1_Tick(object sender, EventArgs e)
        {   // Lấy thông tin thời gian từ lbl
            int giay = Int32.Parse(lblgiay.Text);
            int phut = Int32.Parse(lblphut.Text);
            giay--;
            if (phut == 5 && giay == 0)
            {
                lblthongbaohetgio.Visible = true;
            }
            if (giay < 1)
            {
                giay = 59;
                phut--;
            }
            if (giay < 10)
            {
                lblgiay.Text = "0" + giay;
            }
            else
            {
                lblgiay.Text = giay + "";
            }
            if (phut < 10)
            {
                lblphut.Text = "0" + phut;
            }
            else
            {
                lblphut.Text = phut + "";
            }
            if (phut == 0)
            {
                if (giay == 1)
                {
                    timer1.Stop();
                    MessageBox.Show("Hết Giờ !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // chấm điểm.
                    // Dừng đồng hồ
                    //timer1.Stop();

                    // dừng bài làm
                    tableLayoutPanelcaform.Enabled = false;

                    string[] a = new string[100];
                    try
                    {
                        a[0] = LayDapAn(tbl1);
                        a[1] = LayDapAn(tbl2);
                        a[2] = LayDapAn(tbl3);
                        a[3] = LayDapAn(tbl4);
                        a[4] = LayDapAn(tbl5);
                        a[5] = LayDapAn(tbl6);
                        a[6] = LayDapAn(tbl7);
                        a[7] = LayDapAn(tbl8);
                        a[8] = LayDapAn(tbl9);
                        a[9] = LayDapAn(tbl10);
                        a[10] = LayDapAn(tbl11);
                        a[11] = LayDapAn(tbl12);
                        a[12] = LayDapAn(tbl13);
                        a[13] = LayDapAn(tbl14);
                        a[14] = LayDapAn(tbl15);
                        a[15] = LayDapAn(tbl16);
                        a[16] = LayDapAn(tbl17);
                        a[17] = LayDapAn(tbl18);
                        a[18] = LayDapAn(tbl19);
                        a[19] = LayDapAn(tbl20);

                        a[20] = LayDapAn(tbl21);
                        a[21] = LayDapAn(tbl22);
                        a[22] = LayDapAn(tbl23);
                        a[23] = LayDapAn(tbl24);
                        a[24] = LayDapAn(tbl25);
                        a[25] = LayDapAn(tbl30);
                        a[26] = LayDapAn(tbl27);
                        a[27] = LayDapAn(tbl28);
                        a[28] = LayDapAn(tbl29);
                        a[29] = LayDapAn(tbl34);
                        a[30] = LayDapAn(tbl31);
                        a[31] = LayDapAn(tbl32);
                        a[32] = LayDapAn(tbl33);
                        a[33] = LayDapAn(tbl38);
                        a[34] = LayDapAn(tbl35);
                        a[35] = LayDapAn(tbl36);
                        a[36] = LayDapAn(tbl37);
                        a[37] = LayDapAn(tbl42);
                        a[38] = LayDapAn(tbl39);
                        a[39] = LayDapAn(tbl40);

                    }
                    catch
                    { }

                    // đếm số câu đúng ( so sánh mảng với cột đáp án)
                    int dem = 0;
                    for (int i = 0; i < dulieu.TONGSOCAU; i++)
                    {
                        if (a[i] == dt.Rows[i][3].ToString())
                        {
                            dem = dem + 1;
                        }
                    }
                    // Tính điểm
                    double diem = (Convert.ToDouble(dem) * 10 / 40);
                    // Thông báo
                    MessageBox.Show($"Bạn đã trả lời đúng: {dem}/{dulieu.TONGSOCAU} câu: {diem} Điểm", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Lưu bài làm của sinh viên
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.Append("INSERT INTO BAILAM (MaSV, MaCH, Traloi, Ngaythi) VALUES ");

                            for (int j = 0; j < dulieu.TONGSOCAU; j++)
                            {
                                string macauhoi = dt.Rows[j][0].ToString();
                                sb.AppendFormat("('{0}', '{1}', '{2}', '{3}')", thongtinsv.MSV, macauhoi, a[j], DateTime.Now.ToString("yyyy-MM-dd"));

                                if (j < dulieu.TONGSOCAU - 1)
                                {
                                    sb.Append(", ");
                                }
                            }

                            cmd.CommandText = sb.ToString();
                            cmd.Connection = conn;
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ cụ thể (nếu cần)
                        MessageBox.Show($"Lỗi khi lưu bài làm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    int lanthu = 1;

                    try
                    {
                        // Xem trong bảng KETQUA xem sinh viên thi lần mấy
                        sql = "SELECT COUNT(*) FROM KETQUA WHERE MaSV = @MaSV";
                        using (SqlCommand cmdCount = new SqlCommand(sql, conn))
                        {
                            cmdCount.Parameters.AddWithValue("@MaSV", thongtinsv.MSV);
                            int val = (int)cmdCount.ExecuteScalar();

                            if (val >= 1)
                            {
                                sql = "SELECT Lanthi FROM KETQUA WHERE MaSV = @MaSV";
                                using (SqlCommand cmdLan = new SqlCommand(sql, conn))
                                {
                                    cmdLan.Parameters.AddWithValue("@MaSV", thongtinsv.MSV);
                                    int lan = (int)cmdLan.ExecuteScalar();
                                    lanthu = lan + 1;
                                }
                            }
                            else
                            {
                                lanthu = 1;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ cụ thể (nếu cần)
                        MessageBox.Show($"Lỗi khi xem số lần thi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    float DIEM = (float)diem;

                    try
                    {
                        // Lưu vào bảng kết quả
                        sql = "INSERT INTO KETQUA VALUES (@MaSV, @MaMonThi, @Diem, @LanThi)";
                        using (SqlCommand cmdInsert = new SqlCommand(sql, conn))
                        {
                            cmdInsert.Parameters.AddWithValue("@MaSV", thongtinsv.MSV);
                            cmdInsert.Parameters.AddWithValue("@MaMonThi", dulieu.MAMONTHI);
                            cmdInsert.Parameters.AddWithValue("@Diem", DIEM);
                            cmdInsert.Parameters.AddWithValue("@LanThi", lanthu);

                            cmdInsert.ExecuteNonQuery();
                        }

                        MessageBox.Show("Done");
                    }
                    catch (Exception ex)
                    {
                        // Xử lý ngoại lệ cụ thể (nếu cần)
                        MessageBox.Show($"Lỗi khi lưu kết quả: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }
        }


        private void grbnoidung_TextChanged(object sender, EventArgs e)
        {
            // tách lấy số câu hiện tại
            String chuoi = grbnoidung.Text;
            string[] so = chuoi.Split(' ');
            int k = so.Length;
            int i = Convert.ToInt32(so[k - 1]);
            // hiển thị nội dung câu hiện tại
            try
            {
                lblnoidungcauhoi.Text = dt.Rows[i][2].ToString();
            }
            catch
            { }
            // tô màu table câu hiện tại

            foreach (Control c in this.Controls)
            {   // TableLayoutPanel cả form, chứa tất cả các control và nội dung
                if (c is TableLayoutPanel)
                {
                    foreach (Control a in this.tableLayoutPanelcaform.Controls)
                    {   // các panel nằm trong tableLayoutPanel của toàn form
                        if (a is Panel)
                        {   // cột 1
                            foreach (Control b in this.tableLayoutPanelcot1.Controls)
                                if (b is TableLayoutPanel && b.Name == "tbl" + i.ToString())
                                {
                                    b.BackColor = Color.LightBlue;

                                }
                                else
                                {
                                    b.BackColor = SystemColors.Control;
                                }
                            // cột thứ 2 trong bảng trả lời
                            foreach (Control b in this.tableLayoutPanelcot2.Controls)
                                if (b is TableLayoutPanel && b.Name == "tbl" + i.ToString())
                                {
                                    b.BackColor = Color.LightBlue;
                                }
                                else
                                {
                                    b.BackColor = SystemColors.Control;
                                }

                        }
                    }
                }
            }
        }



        private void lbl1_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = true;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;

            grbnoidung.Text = "Câu số 1";
            lblnoidungcauhoi.Text = dt.Rows[0][2].ToString();
        }

        private void lbl2_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = true;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;

            grbnoidung.Text = "Câu số 2";
            lblnoidungcauhoi.Text = dt.Rows[1][2].ToString();
        }

        private void lbl3_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = true;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 3";
            lblnoidungcauhoi.Text = dt.Rows[2][2].ToString();
        }

        private void lbl4_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = true;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 4";
            lblnoidungcauhoi.Text = dt.Rows[3][2].ToString();
        }

        private void lbl5_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = true;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 5";
            lblnoidungcauhoi.Text = dt.Rows[4][2].ToString();
        }

        private void lbl6_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = true;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 6";
            lblnoidungcauhoi.Text = dt.Rows[5][2].ToString();
        }

        private void lbl7_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = true;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 7";
            lblnoidungcauhoi.Text = dt.Rows[6][2].ToString();
        }

        private void lbl8_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = true;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 8";
            lblnoidungcauhoi.Text = dt.Rows[7][2].ToString();
        }

        private void lbl9_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = true;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 9";
            lblnoidungcauhoi.Text = dt.Rows[8][2].ToString();
        }

        private void lbl10_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = true;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 10";
            lblnoidungcauhoi.Text = dt.Rows[9][2].ToString();
        }

        private void lbl11_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = true;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 11";
            lblnoidungcauhoi.Text = dt.Rows[10][2].ToString();
        }

        private void lbl12_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = true;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 12";
            lblnoidungcauhoi.Text = dt.Rows[11][2].ToString();
        }

        private void lbl13_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = true;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 13";
            lblnoidungcauhoi.Text = dt.Rows[12][2].ToString();
        }
        private void lbl14_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = true;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            ckbdatco17.Visible = false;
            grbnoidung.Text = "Câu số 14";
            lblnoidungcauhoi.Text = dt.Rows[13][2].ToString();
        }

        private void lbl15_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = true;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 15";
            lblnoidungcauhoi.Text = dt.Rows[14][2].ToString();
        }

        private void lbl16_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = true;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 16";
            lblnoidungcauhoi.Text = dt.Rows[15][2].ToString();
        }

        private void lbl17_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = true;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 17";
            lblnoidungcauhoi.Text = dt.Rows[16][2].ToString();
        }

        private void lbl18_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = true;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 18";
            lblnoidungcauhoi.Text = dt.Rows[17][2].ToString();
        }

        private void lbl19_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = true;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 19";
            lblnoidungcauhoi.Text = dt.Rows[18][2].ToString();
        }

        private void lbl20_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = true;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 20";
            lblnoidungcauhoi.Text = dt.Rows[19][2].ToString();
        }

        private void lbl21_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = true;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 21";
            lblnoidungcauhoi.Text = dt.Rows[20][2].ToString();
        }

        private void lbl22_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = true;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 22";
            lblnoidungcauhoi.Text = dt.Rows[21][2].ToString();
        }

        private void lbl23_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = true;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 23";
            lblnoidungcauhoi.Text = dt.Rows[22][2].ToString();
        }

        private void lbl24_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = true;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 24";
            lblnoidungcauhoi.Text = dt.Rows[23][2].ToString();
        }

        private void lbl25_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = true;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 25";
            lblnoidungcauhoi.Text = dt.Rows[24][2].ToString();
        }

        private void lbl26_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = true;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 26";
            lblnoidungcauhoi.Text = dt.Rows[25][2].ToString();
        }

        private void lbl27_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = true;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 27";
            lblnoidungcauhoi.Text = dt.Rows[26][2].ToString();
        }

        private void lbl28_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = true;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 28";
            lblnoidungcauhoi.Text = dt.Rows[27][2].ToString();

        }

        private void lbl29_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = true;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 29";
            lblnoidungcauhoi.Text = dt.Rows[28][2].ToString();
        }

        private void lbl30_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = true;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 30";
            lblnoidungcauhoi.Text = dt.Rows[29][2].ToString();
        }

        private void lbl31_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = true;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 31";
            lblnoidungcauhoi.Text = dt.Rows[30][2].ToString();
        }

        private void lbl32_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = true;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 32";
            lblnoidungcauhoi.Text = dt.Rows[31][2].ToString();
        }

        private void lbl33_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = true;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 33";
            lblnoidungcauhoi.Text = dt.Rows[32][2].ToString();

        }

        private void lbl34_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = true;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 34";
            lblnoidungcauhoi.Text = dt.Rows[33][2].ToString();
        }

        private void lbl35_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = true;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 35";
            lblnoidungcauhoi.Text = dt.Rows[34][2].ToString();
        }

        private void lbl36_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = true;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 36";
            lblnoidungcauhoi.Text = dt.Rows[35][2].ToString();
        }

        private void lbl37_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = true;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 37";
            lblnoidungcauhoi.Text = dt.Rows[36][2].ToString();
        }

        private void lbl38_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = true;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 38";
            lblnoidungcauhoi.Text = dt.Rows[37][2].ToString();
        }

        private void lbl39_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = true;
            ckbdatco40.Visible = false;
            grbnoidung.Text = "Câu số 39";
            lblnoidungcauhoi.Text = dt.Rows[38][2].ToString();
        }

        private void lbl40_Click(object sender, EventArgs e)
        {
            ckbdatco1.Visible = false;
            ckbdatco2.Visible = false;
            ckbdatco3.Visible = false;
            ckbdatco4.Visible = false;
            ckbdatco5.Visible = false;
            ckbdatco6.Visible = false;
            ckbdatco7.Visible = false;
            ckbdatco8.Visible = false;
            ckbdatco9.Visible = false;
            ckbdatco10.Visible = false;
            ckbdatco11.Visible = false;
            ckbdatco12.Visible = false;
            ckbdatco13.Visible = false;
            ckbdatco14.Visible = false;
            ckbdatco15.Visible = false;
            ckbdatco16.Visible = false;
            ckbdatco17.Visible = false;
            ckbdatco18.Visible = false;
            ckbdatco19.Visible = false;
            ckbdatco20.Visible = false;
            ckbdatco21.Visible = false;
            ckbdatco22.Visible = false;
            ckbdatco23.Visible = false;
            ckbdatco24.Visible = false;
            ckbdatco25.Visible = false;
            ckbdatco26.Visible = false;
            ckbdatco27.Visible = false;
            ckbdatco28.Visible = false;
            ckbdatco29.Visible = false;
            ckbdatco30.Visible = false;
            ckbdatco31.Visible = false;
            ckbdatco32.Visible = false;
            ckbdatco33.Visible = false;
            ckbdatco34.Visible = false;
            ckbdatco35.Visible = false;
            ckbdatco36.Visible = false;
            ckbdatco37.Visible = false;
            ckbdatco38.Visible = false;
            ckbdatco39.Visible = false;
            ckbdatco40.Visible = true;
            grbnoidung.Text = "Câu số 40";
            lblnoidungcauhoi.Text = dt.Rows[39][2].ToString();
        }



        private void lblphut_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }
        private void tble1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grbnoidung_Enter(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label84_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void rd3d_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void lbltime_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            // tách lấy số câu hiện tại
            String chuoi = grbnoidung.Text;
            string[] so = chuoi.Split(' ');
            int k = so.Length;
            int i = Convert.ToInt32(so[k - 1]);
            if (i > 1)
            {
                if (i - 1 == 1)
                {
                    khoitao();
                }
                else if (i - 1 == 2)
                {
                    init();
                    ckbdatco2.Visible = true;

                }
                else if (i - 1 == 3)
                {
                    init();
                    ckbdatco3.Visible = true;
                }
                else if (i - 1 == 4)
                {
                    init();
                    ckbdatco4.Visible = true;
                }
                else if (i - 1 == 5)
                {
                    init();
                    ckbdatco5.Visible = true;
                }
                else if (i - 1 == 6)
                {
                    init();
                    ckbdatco6.Visible = true;
                }
                else if (i - 1 == 7)
                {
                    init();
                    ckbdatco7.Visible = true;
                }
                else if (i - 1 == 8)
                {
                    init();
                    ckbdatco8.Visible = true;
                }
                else if (i - 1 == 9)
                {
                    init();
                    ckbdatco9.Visible = true;
                }
                else if (i - 1 == 10)
                {
                    init();
                    ckbdatco10.Visible = true;
                }
                else if (i - 1 == 11)
                {
                    init();
                    ckbdatco11.Visible = true;
                }
                else if (i - 1 == 12)
                {
                    init();
                    ckbdatco12.Visible = true;
                }
                else if (i - 1 == 13)
                {
                    init();
                    ckbdatco13.Visible = true;
                }
                else if (i - 1 == 14)
                {
                    init();
                    ckbdatco14.Visible = true;
                }
                else if (i - 1 == 15)
                {
                    init();
                    ckbdatco15.Visible = true;
                }
                else if (i - 1 == 16)
                {
                    init();
                    ckbdatco16.Visible = true;
                }
                else if (i - 1 == 17)
                {
                    init();
                    ckbdatco17.Visible = true;
                }
                else if (i - 1 == 18)
                {
                    init();
                    ckbdatco18.Visible = true;
                }
                else if (i - 1 == 19)
                {
                    init();
                    ckbdatco19.Visible = true;
                }
                else if (i - 1 == 20)
                {
                    init();
                    ckbdatco20.Visible = true;
                }
                else if (i - 1 == 21)
                {
                    init();
                    ckbdatco21.Visible = true;
                }
                else if (i - 1 == 22)
                {
                    init();
                    ckbdatco22.Visible = true;
                }
                else if (i - 1 == 23)
                {
                    init();
                    ckbdatco23.Visible = true;
                }
                else if (i - 1 == 24)
                {
                    init();
                    ckbdatco24.Visible = true;
                }
                else if (i - 1 == 25)
                {
                    init();
                    ckbdatco25.Visible = true;
                }
                else if (i - 1 == 26)
                {
                    init();
                    ckbdatco26.Visible = true;
                }
                else if (i - 1 == 27)
                {
                    init();
                    ckbdatco27.Visible = true;
                }
                else if (i - 1 == 28)
                {
                    init();
                    ckbdatco28.Visible = true;
                }
                else if (i - 1 == 29)
                {
                    init();
                    ckbdatco29.Visible = true;
                }
                else if (i - 1 == 30)
                {
                    init();
                    ckbdatco30.Visible = true;
                }
                else if (i - 1 == 31)
                {
                    init();
                    ckbdatco31.Visible = true;
                }
                else if (i - 1 == 32)
                {
                    init();
                    ckbdatco32.Visible = true;
                }
                else if (i - 1 == 33)
                {
                    init();
                    ckbdatco33.Visible = true;
                }
                else if (i - 1 == 34)
                {
                    init();
                    ckbdatco34.Visible = true;
                }
                else if (i - 1 == 35)
                {
                    init();
                    ckbdatco35.Visible = true;
                }
                else if (i - 1 == 36)
                {
                    init();
                    ckbdatco36.Visible = true;
                }
                else if (i - 1 == 37)
                {
                    init();
                    ckbdatco37.Visible = true;
                }
                else if (i - 1 == 38)
                {
                    init();
                    ckbdatco38.Visible = true;
                }
                else if (i - 1 == 39)
                {
                    init();
                    ckbdatco39.Visible = true;
                }
                else if (i - 1 == 40)
                {
                    init();
                    ckbdatco40.Visible = true;
                }
                // hiển thị số câu.
                grbnoidung.Text = "Câu số " + (i - 1).ToString();
                // Chuyển nội dung câu hỏi tiếp theo
                lblnoidungcauhoi.Text = dt.Rows[i - 2][2].ToString();
            }
            else
            { }
        }

        private void btndone_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn nộp bài không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                // Dừng đồng hồ
                timer1.Stop();

                // dừng bài làm
                tableLayoutPanelcaform.Enabled = false;

                string[] a = new string[100];
                try
                {
                    a[0] = LayDapAn(tbl1);
                    a[1] = LayDapAn(tbl2);
                    a[2] = LayDapAn(tbl3);
                    a[3] = LayDapAn(tbl4);
                    a[4] = LayDapAn(tbl5);
                    a[5] = LayDapAn(tbl6);
                    a[6] = LayDapAn(tbl7);
                    a[7] = LayDapAn(tbl8);
                    a[8] = LayDapAn(tbl9);
                    a[9] = LayDapAn(tbl10);
                    a[10] = LayDapAn(tbl11);
                    a[11] = LayDapAn(tbl12);
                    a[12] = LayDapAn(tbl13);
                    a[13] = LayDapAn(tbl14);
                    a[14] = LayDapAn(tbl15);
                    a[15] = LayDapAn(tbl16);
                    a[16] = LayDapAn(tbl17);
                    a[17] = LayDapAn(tbl18);
                    a[18] = LayDapAn(tbl19);
                    a[19] = LayDapAn(tbl20);

                    a[24] = LayDapAn(tbl21);
                    a[25] = LayDapAn(tbl22);
                    a[26] = LayDapAn(tbl23);
                    a[27] = LayDapAn(tbl24);
                    a[28] = LayDapAn(tbl25);
                    a[29] = LayDapAn(tbl30);
                    a[30] = LayDapAn(tbl27);
                    a[31] = LayDapAn(tbl28);
                    a[32] = LayDapAn(tbl29);
                    a[33] = LayDapAn(tbl34);
                    a[34] = LayDapAn(tbl31);
                    a[35] = LayDapAn(tbl32);
                    a[36] = LayDapAn(tbl33);
                    a[37] = LayDapAn(tbl38);
                    a[38] = LayDapAn(tbl35);
                    a[39] = LayDapAn(tbl36);
                    a[40] = LayDapAn(tbl37);
                    a[41] = LayDapAn(tbl42);
                    a[42] = LayDapAn(tbl39);
                    a[43] = LayDapAn(tbl40);

                }
                catch
                { }

                int dem = 0;

                try
                {
                    // Lấy danh sách đáp án từ cơ sở dữ liệu (thay đổi thành câu lệnh SQL thích hợp)
                    string sqlDapAn = "SELECT DapAn FROM CAUHOI WHERE MaM = @MaMonThi";
                    using (SqlCommand cmdDapAn = new SqlCommand(sqlDapAn, conn))
                    {
                        cmdDapAn.Parameters.AddWithValue("@MaMonThi", dulieu.MAMONTHI);

                        DataTable dtDapAn = new DataTable();
                        using (SqlDataAdapter daDapAn = new SqlDataAdapter(cmdDapAn))
                        {
                            daDapAn.Fill(dtDapAn);
                        }

                        // Kiểm tra từng câu hỏi và so sánh với đáp án
                        for (int i = 0; i < dulieu.TONGSOCAU; i++)
                        {
                            if (a[i] == dtDapAn.Rows[i]["DapAn"].ToString())
                            {
                                dem++;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ (nếu cần)
                    MessageBox.Show($"Lỗi khi đếm số câu đúng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Tính điểm
                double diem = (Convert.ToDouble(dem) * 10 / 40);

                // Thông báo
                MessageBox.Show($"Bạn đã trả lời đúng: {dem}/{dulieu.TONGSOCAU} câu: {diem} Điểm", "Kết Quả", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Lưu bài làm của sinh viên
                try
                {
                    for (int j = 0; j < dulieu.TONGSOCAU; j++)
                    {
                        string macauhoi = dt.Rows[j][0].ToString();

                        // Sử dụng tham số trong truy vấn SQL
                        sql = "INSERT INTO BAILAM VALUES (@MaSV, @MaCauHoi, @TraLoi, @NgayThi)";
                        using (SqlCommand cmdInsertBaiLam = new SqlCommand(sql, conn))
                        {
                            cmdInsertBaiLam.Parameters.AddWithValue("@MaSV", thongtinsv.MSV);
                            cmdInsertBaiLam.Parameters.AddWithValue("@MaCauHoi", macauhoi);
                            cmdInsertBaiLam.Parameters.AddWithValue("@TraLoi", (a.Length > j) ? a[j] : (object)DBNull.Value);
                            cmdInsertBaiLam.Parameters.AddWithValue("@NgayThi", DateTime.Now.ToString("yyyy-MM-dd"));

                            cmdInsertBaiLam.ExecuteNonQuery();
                        }
                    }
                }
                catch
                { }


                //Xem trong bảng KETQUA xem sinh viên thi lần mấy
                int lanthu = 1;

                sql = "select count(*) from KETQUA where MaSV = '" + thongtinsv.MSV + "' and MaM = '" + dulieu.MAMONTHI + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                int val = (int)cmd.ExecuteScalar();
                if (val >= 1)
                {
                    lanthu = val + 1;
                }
                else
                {
                    lanthu = 1;
                }



                // Lấy phần nguyên và phần thập phân của điểm
                String tach = diem.ToString("0.00");
                string[] td = tach.Split('.');
                int nguyen = Convert.ToInt32(td[0]);
                int thapphan = Convert.ToInt32(td[1]);

                // Sử dụng tham số trong truy vấn SQL
                sql = "INSERT INTO KETQUA VALUES (@MaSV, @MaMonThi, @Diem, @LanThi)";
                using (SqlCommand cmdInsertKetQua = new SqlCommand(sql, conn))
                {
                    cmdInsertKetQua.Parameters.AddWithValue("@MaSV", thongtinsv.MSV);
                    cmdInsertKetQua.Parameters.AddWithValue("@MaMonThi", dulieu.MAMONTHI);
                    cmdInsertKetQua.Parameters.AddWithValue("@Diem", $"{nguyen}.{thapphan}");
                    cmdInsertKetQua.Parameters.AddWithValue("@LanThi", lanthu);

                    cmdInsertKetQua.ExecuteNonQuery();
                }

                // Đóng ứng dụng chính
                Application.Exit();


            }
            else
            { }
        }

        private void frmbaithi_Load_1(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            constr = "Data Source=MSI\\MSSQLSERVER01;Initial Catalog=THITRACNGHIEM;Integrated Security=True;Encrypt=False";
            conn.ConnectionString = constr;
            conn.Open();
            int day = DateTime.Now.Day;
            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            // Lấy thông tin môn thi
            sql = "SELECT * FROM MONTHI WHERE Thoigianthi = @Thoigianthi";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                // Sử dụng SqlParameter để tránh lỗi SQL injection và tăng tính bảo mật
                cmd.Parameters.AddWithValue("@Thoigianthi", new DateTime(year, month, day));

                // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                }
            }


            // hiển thị thông tin môn thi
            lblmonthi.Text = dt.Rows[0][1].ToString();
            lblsocau.Text = dt.Rows[0][2].ToString();
            lblthoigian.Text = dt.Rows[0][3].ToString();
            // lấy mã môn thi
            string mamonthi = dt.Rows[0][0].ToString();
            dulieu.MAMONTHI = mamonthi.Trim();
            // lấy thời gian môn thi để tính giờ
            lblphut.Text = dt.Rows[0][3].ToString();
            // Lấy số câu hỏi của đề thi
            string tongsocau = dt.Rows[0][2].ToString();
            int socau = Convert.ToInt32(tongsocau);
            // lưu số câu hỏi vào data public
            dulieu.TONGSOCAU = socau;
            // Lấy thông tin thí sinh
            // 1. Nhận thông tin Mã sinh viên từ form đăng nhập thông qua class public
            string masinhvien = thongtinsv.MSV;

            // 2. Lấy thông tin trong SQL
            sql = "SELECT * FROM SV WHERE MaSV = @MaSV";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                // Sử dụng SqlParameter để tránh lỗi SQL injection và tăng tính bảo mật
                cmd.Parameters.AddWithValue("@MaSV", masinhvien);

                // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                }
            }

            // Hiển thị thông tin trên giao diện
            lblhoten.Text = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
            lblmsv.Text = thongtinsv.MSV;

            // Tạo đề ngẫu nhiên tùy theo môn học
            sql = "SELECT TOP (@SoCau) * FROM CAUHOI WHERE MaM = @MaMonThi ORDER BY NEWID(), Chuong";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                // Sử dụng SqlParameter để tránh lỗi SQL injection và tăng tính bảo mật
                cmd.Parameters.AddWithValue("@SoCau", socau);
                cmd.Parameters.AddWithValue("@MaMonThi", mamonthi);

                // Sử dụng SqlDataAdapter để điền dữ liệu vào DataTable
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    dt = new DataTable();
                    dt.Clear();
                    da.Fill(dt);
                }
            }

            // Khởi tạo dữ liệu cần thiết
            khoitao();

            // load nội dung câu hỏi 1.
            int i = 0;
            grbnoidung.Text = "Câu số " + (i + 1).ToString();

            lblnoidungcauhoi.Text = dt.Rows[i][2].ToString();
            //lblchuong.Text = "Chương: " + dt.Rows[i]["Chuong"].ToString(); // Display the chapter
            // bắt đầu đếm giờ
            timer1.Start();
        }

        private void lblnoidungcauhoi_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void grbnoidung_Enter_1(object sender, EventArgs e)
        {

        }

        private void tbl18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbl35_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btndone_MouseEnter(object sender, EventArgs e)
        {
            btndone.BackColor = System.Drawing.Color.Red;
        }

        private void btndone_MouseLeave(object sender, EventArgs e)
        {
            btndone.BackColor = System.Drawing.Color.White;
        }

        private void ckbdatco_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco1.Checked)
            {
                lbl1.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl1.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
        private void ckbdatco40_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco40.Checked)
            {
                lbl40.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl40.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco39_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco39.Checked)
            {
                lbl39.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl39.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco38_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco38.Checked)
            {
                lbl38.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl38.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco37_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco37.Checked)
            {
                lbl37.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl37.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco36_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco36.Checked)
            {
                lbl36.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl36.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco35_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco35.Checked)
            {
                lbl35.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl35.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco34_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco34.Checked)
            {
                lbl34.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl34.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco33_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco33.Checked)
            {
                lbl33.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl33.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco32_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco32.Checked)
            {
                lbl32.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl32.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco31_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco31.Checked)
            {
                lbl31.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl31.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco30_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco30.Checked)
            {
                lbl30.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl30.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco29_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco29.Checked)
            {
                lbl29.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl29.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco28_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco28.Checked)
            {
                lbl28.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl28.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco27_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco27.Checked)
            {
                lbl27.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl27.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco26_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco26.Checked)
            {
                lbl26.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl26.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco25_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco25.Checked)
            {
                lbl25.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl25.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco24_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco24.Checked)
            {
                lbl24.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl24.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco23_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco23.Checked)
            {
                lbl23.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl23.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco22_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco22.Checked)
            {
                lbl22.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl22.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco21_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco21.Checked)
            {
                lbl21.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl21.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco20_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco20.Checked)
            {
                lbl20.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl20.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco19_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco19.Checked)
            {
                lbl19.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl19.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco18_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco18.Checked)
            {
                lbl18.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl18.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }
        private void ckbdatco17_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco17.Checked)
            {
                lbl17.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl17.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }

        private void ckbdatco16_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco16.Checked)
            {
                lbl16.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl16.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }

        private void ckbdatco15_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco15.Checked)
            {
                lbl15.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl15.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }

        private void ckbdatco14_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco14.Checked)
            {
                lbl14.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl14.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }

        private void ckbdatco13_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco13.Checked)
            {
                lbl13.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl13.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }

        private void ckbdatco12_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco12.Checked)
            {
                lbl12.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl12.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }

        private void ckbdatco11_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco11.Checked)
            {
                lbl11.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl11.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }

        private void ckbdatco10_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco10.Checked)
            {
                lbl10.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl10.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }

        private void ckbdatco9_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco9.Checked)
            {
                lbl9.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl9.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }

        private void ckbdatco8_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco8.Checked)
            {
                lbl8.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl8.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }

        private void ckbdatco7_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco7.Checked)
            {
                lbl7.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl7.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }

        private void ckbdatco6_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco6.Checked)
            {
                lbl6.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl6.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }

        private void ckbdatco5_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco5.Checked)
            {
                lbl5.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl5.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }

        private void ckbdatco4_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco4.Checked)
            {
                lbl4.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl4.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }

        private void ckbdatco3_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbdatco3.Checked)
            {
                lbl3.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl3.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)
            }
        }

        private void ckbdatco2_CheckedChanged(object sender, EventArgs e)
        {


            if (ckbdatco2.Checked)
            {
                lbl2.BackColor = System.Drawing.Color.Red; // Màu đỏ
            }
            else
            {
                lbl2.BackColor = System.Drawing.Color.Transparent; // Màu trong suốt (mặc định)Câu 1:
            }
        }

        private void lbl1_MouseLeave(object sender, EventArgs e)
        {
            lbl1.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void lbl1_MouseEnter(object sender, EventArgs e)
        {
            lbl1.BackColor = System.Drawing.Color.LightBlue;
        }

        private void lbl2_MouseEnter(object sender, EventArgs e)
        {
            lbl2.BackColor = System.Drawing.Color.LightBlue;
        }

        private void lbl2_MouseLeave(object sender, EventArgs e)
        {
            lbl2.BackColor = System.Drawing.Color.Gainsboro;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblgiay_Click(object sender, EventArgs e)
        {

        }

        private void lblthongbaohetgio_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }


    }
}












