using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static BTL_QuanLyNhaTro.FunctionAll;

namespace BTL_QuanLyNhaTro
{
    public partial class ThanhToanHoaDonForm : Form
    {
        private string maHoaDon;

        public ThanhToanHoaDonForm(string maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            LoadHoaDonDetails();
        }

        private void LoadHoaDonDetails()
        {
            string query = @"SELECT hd.MaHoaDon, p.TenPhong, hd.NgayLapHoaDon, hd.HanHoaDon, hd.SoTienThanhToan, tthd.TenTrangThai
                             FROM HoaDon hd
                             JOIN Phong p ON hd.MaPhong = p.MaPhong
                             JOIN TrangThaiHoaDon tthd ON hd.MaTrangThaiHoaDon = tthd.MaTrangThai
                             WHERE hd.MaHoaDon = @MaHoaDon";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
            DataTable dt = GetData(cmd);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lbMaHoaDon.Text = row["MaHoaDon"].ToString();
                lbTenPhong.Text = row["TenPhong"].ToString();
                lbNgayLap.Text = Convert.ToDateTime(row["NgayLapHoaDon"]).ToString("dd/MM/yyyy");
                lbHanHoaDon.Text = Convert.ToDateTime(row["HanHoaDon"]).ToString("dd/MM/yyyy");
                lbSoTien.Text = row["SoTienThanhToan"].ToString();
                lbTrangThai.Text = row["TenTrangThai"].ToString();
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string phuongThucThanhToan = cBPhuongThuc.SelectedItem.ToString();

            SqlCommand cmd = new SqlCommand(@"UPDATE HoaDon 
                                              SET MaTrangThaiHoaDon = @MaTrangThai, 
                                                  PhuongThucThanhToan = @PhuongThucThanhToan 
                                              WHERE MaHoaDon = @MaHoaDon");
            cmd.Parameters.AddWithValue("@MaTrangThai", 1); // 1: Đã thanh toán
            cmd.Parameters.AddWithValue("@PhuongThucThanhToan", phuongThucThanhToan);
            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
            ExecuteNonQuery(cmd);


            MessageBox.Show("Thanh toán thành công!");
            this.Close();
        }
    }
}
