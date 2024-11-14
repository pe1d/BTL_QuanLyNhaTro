using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static BTL_QuanLyNhaTro.FunctionAll;
namespace BTL_QuanLyNhaTro
{
    public partial class FormBaoCaoDoanhThuChiTiet : Form
    {
        private int month, year;
        private string TenChuTro;
        private decimal tong;
        public FormBaoCaoDoanhThuChiTiet(decimal tong, string TenChuTro, int month, int year)
        {
            InitializeComponent();
            this.month = month;
            this.year = year;
            this.TenChuTro = TenChuTro;
            this.tong = tong;
            tb_Tong.Text = tong.ToString();
            tb_Tong.Enabled = false;
            if (month == 0 && year == 0)
            {
                lb_title.Text += $" - {TenChuTro}";
            }
            else
            {
                lb_title.Text += $" - {TenChuTro} - Tháng {month}/{year}";
            }
            LoadDataToGridView();
        }
        private void LoadDataToGridView()
        {
            string query = @"
                SELECT hd.MaHoaDon, ct.TenChuTro, hd.NguoiLap, hd.NgayLapHoaDon, hd.HanHoaDon, hd.SoTienThanhToan, hd.PhuongThucThanhToan, tt.TenTrangThai
                FROM HoaDon hd
                INNER JOIN Phong p ON hd.MaPhong = p.MaPhong
                INNER JOIN ChuTro ct ON p.MaChuTro = ct.MaChuTro
                INNER JOIN TrangThaiHoaDon tt ON tt.MaTrangThai = hd.MaTrangThaiHoaDon
                WHERE ct.TenChuTro = @TenChuTro
            ";
            if (month != 0)
            {
                query += " AND MONTH(hd.NgayLapHoaDon) = @Thang";
            }
            if (year != 0)
            {
                query += " AND YEAR(hd.NgayLapHoaDon) = @Nam";
            }
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@TenChuTro", TenChuTro);
            if(month!=0 && year != 0)
            {
                cmd.Parameters.AddWithValue("@Thang", month);
                cmd.Parameters.AddWithValue("@Nam", year);
            }
            DataTable dt = GetData(cmd);
            dGV_DanhSachHoaDon.DataSource = dt;
            dGV_DanhSachHoaDon.Columns["MaHoaDon"].HeaderText = "Mã Hóa Đơn";
            dGV_DanhSachHoaDon.Columns["TenChuTro"].HeaderText = "Tên Chủ Trọ";
            dGV_DanhSachHoaDon.Columns["NguoiLap"].HeaderText = "Người Lập";
            dGV_DanhSachHoaDon.Columns["NgayLapHoaDon"].HeaderText = "Ngày Lập Hóa Đơn";
            dGV_DanhSachHoaDon.Columns["HanHoaDon"].HeaderText = "Hạn Hóa Đơn";
            dGV_DanhSachHoaDon.Columns["SoTienThanhToan"].HeaderText = "Số Tiền Thanh Toán";
            dGV_DanhSachHoaDon.Columns["PhuongThucThanhToan"].HeaderText = "Phương Thức Thanh Toán";
            dGV_DanhSachHoaDon.Columns["TenTrangThai"].HeaderText = "Trạng Thái";
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThu bcRPT = new BaoCaoDoanhThu();
            DataSet1 dataSet1 = new DataSet1();
            string query = @"
                SELECT hd.MaHoaDon,hd.MaPhong, ct.TenChuTro, hd.NguoiLap, hd.NgayLapHoaDon, hd.HanHoaDon, hd.SoTienThanhToan, hd.PhuongThucThanhToan, tt.TenTrangThai
                FROM HoaDon hd
                INNER JOIN Phong p ON hd.MaPhong = p.MaPhong
                INNER JOIN ChuTro ct ON p.MaChuTro = ct.MaChuTro
                INNER JOIN TrangThaiHoaDon tt ON tt.MaTrangThai = hd.MaTrangThaiHoaDon
                WHERE ct.TenChuTro = @TenChuTro
            ";
            if (month != 0)
            {
                query += " AND MONTH(hd.NgayLapHoaDon) = @Thang";
            }
            if (year != 0)
            {
                query += " AND YEAR(hd.NgayLapHoaDon) = @Nam";
            }
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@TenChuTro", TenChuTro);
            if (month != 0 && year != 0)
            {
                cmd.Parameters.AddWithValue("@Thang", month);
                cmd.Parameters.AddWithValue("@Nam", year);
            }
            DataTable dt = GetData(cmd);
            FormReportBaoCao f = new FormReportBaoCao(dt,tong,TenChuTro,month,year);
            f.Show();
        }
    }
}
