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
using static BTL_QuanLyNhaTro.AuthenticationService;
using static BTL_QuanLyNhaTro.FunctionAll;

namespace BTL_QuanLyNhaTro
{
    public partial class FormXemChiTietHoaDon : Form
    {
        private string maHoaDon;
        public FormXemChiTietHoaDon(string maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            AutoResizeDataGridView(dataGridView1);
            LoadHoaDonDetails();
            LoadDichVuList();
        }
        private void LoadHoaDonDetails()
        {
            string query1 = @"
            SELECT hd.NguoiLap, hd.NgayLapHoaDon, hd.HanHoaDon, hd.SoTienThanhToan,hd.MaPhong,
                   p.TenPhong,p.GiaThue, tthd.TenTrangThai
            FROM HoaDon hd
            JOIN Phong p ON hd.MaPhong = p.MaPhong
            JOIN TrangThaiHoaDon tthd ON hd.MaTrangThaiHoaDon = tthd.MaTrangThai
            WHERE hd.MaHoaDon = @MaHoaDon";
            SqlCommand query = new SqlCommand(query1);
            query.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
            DataTable dt = GetData(query);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lb_NguoiLap.Text = row["NguoiLap"].ToString();
                tB_ngayLap.Text = Convert.ToDateTime(row["NgayLapHoaDon"]).ToString("dd/MM/yyyy");
                tB_ngayHetHan.Text = Convert.ToDateTime(row["HanHoaDon"]).ToString("dd/MM/yyyy");
                tB_Phong.Text = row["TenPhong"].ToString();
                tB_giaPhong.Text = row["GiaThue"].ToString(); ;
                tB_tongTien.Text = row["SoTienThanhToan"].ToString();
                tB_TrangThai.Text = row["TenTrangThai"].ToString(); // Có thể join để lấy tên trạng thái
                setTenKhachThue(row["MaPhong"].ToString());
            }
        }
        private void setTenKhachThue(string maPhong)
        {
            SqlCommand cmdSPhongKT = new SqlCommand(@"select * from HopDong 
                                    inner join NguoiThue ON NguoiThue.MaNguoiThue = HopDong.MaNguoiThue
                                    where HopDong.MaPhong = '" + maPhong + "'");
            DataTable dt = GetData(cmdSPhongKT);
            if (HasData(dt))
            {
                DataRow dr = dt.Rows[0];
                if (dr["HoTen"].ToString() != null)
                {
                    tB_khachThue.Text = dr["HoTen"].ToString();
                }
                else
                {
                    MessageBox.Show("Có 1 vài lỗi xảy ra");
                }
            }
        }
        private void LoadDichVuList()
        {
            string query = @"
            SELECT dv.MaDichVu, dv.TenDichVu, dv.DonGia, hd_dv.SoLuong, dv.DonVi, hd_dv.ThanhTien
            FROM HoaDon_DichVu hd_dv
            INNER JOIN DichVu dv ON hd_dv.MaDichVu = dv.MaDichVu
            WHERE hd_dv.MaHoaDon = @MaHoaDon";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
            DataTable dt = GetData(cmd);
            dataGridView1.DataSource = dt;
        }
    }
}
