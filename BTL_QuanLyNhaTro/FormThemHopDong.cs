using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static BTL_QuanLyNhaTro.FunctionAll;

namespace BTL_QuanLyNhaTro
{
    public partial class FormThemHopDong : Form
    {
        private string maPhong;

        public FormThemHopDong(string maPhong)
        {
            InitializeComponent();
            this.maPhong = maPhong;
            LoadPhongDetails();
        }

        private void LoadPhongDetails()
        {
            string query = @"SELECT p.MaPhong, p.TenPhong, p.GiaThue, p.DienTich, p.Tang
                             FROM Phong p
                             WHERE p.MaPhong = @MaPhong";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MaPhong", maPhong);
            DataTable dt = GetData(cmd);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lbMaPhong.Text = row["MaPhong"].ToString();
                lbTenPhong.Text = row["TenPhong"].ToString();
                lbGiaThue.Text = row["GiaThue"].ToString();
                lbDienTich.Text = row["DienTich"].ToString();
                lbTang.Text = row["Tang"].ToString();
            }
        }

        private void btnThemHopDong_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"INSERT INTO HopDong (MaPhong, MaNguoiThue, NgayBatDau, NgayKetThuc, GiaThue)
                                              VALUES (@MaPhong, @MaNguoiThue, @NgayBatDau, @NgayKetThuc, @GiaThue)");
            cmd.Parameters.AddWithValue("@MaPhong", maPhong);
            cmd.Parameters.AddWithValue("@MaNguoiThue", tbMaNguoiThue.Text);
            cmd.Parameters.AddWithValue("@NgayBatDau", dtpNgayBatDau.Value);
            cmd.Parameters.AddWithValue("@NgayKetThuc", dtpNgayKetThuc.Value);
            cmd.Parameters.AddWithValue("@GiaThue", lbGiaThue.Text);
            ExecuteNonQuery(cmd);

            SqlCommand cmdUpdatePhong = new SqlCommand(@"UPDATE Phong SET MaTrangThai = 'Đã thuê' WHERE MaPhong = @MaPhong");
            cmdUpdatePhong.Parameters.AddWithValue("@MaPhong", maPhong);
            ExecuteNonQuery(cmdUpdatePhong);

            MessageBox.Show("Thêm hợp đồng thành công!");
            this.Close();
        }
    }
}
