using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static BTL_QuanLyNhaTro.AuthenticationService;
using static BTL_QuanLyNhaTro.FunctionAll;

namespace BTL_QuanLyNhaTro
{
    public partial class FormThanhToanHoaDon : Form
    {
        public FormThanhToanHoaDon()
        {
            InitializeComponent();
            AutoResizeDataGridView(dGV_HoaDon);
            dGV_HoaDon.CellMouseDown += DataGridView_CellMouseDown;
        }

        private void FormThanhToanHoaDon_Load(object sender, EventArgs e)
        {
            LoadHoaDonList();
        }

        private void LoadHoaDonList()
        {
            string query = "";

            if (User.RoleID == 1) // KhachThue
            {
                query = @"SELECT hd.MaHoaDon, hd.MaPhong, p.TenPhong, hd.NgayLapHoaDon, hd.HanHoaDon, hd.SoTienThanhToan, tthd.TenTrangThai
                          FROM HoaDon hd
                          JOIN Phong p ON hd.MaPhong = p.MaPhong
                          JOIN TrangThaiHoaDon tthd ON hd.MaTrangThaiHoaDon = tthd.MaTrangThai
                          JOIN HopDong hdg ON hd.MaPhong = hdg.MaPhong
                          WHERE hdg.MaNguoiThue = @UserID and hd.MaTrangThaiHoaDon != 1" ;
            }
            else if (User.RoleID == 3) // Admin
            {
                query = @"SELECT hd.MaHoaDon, hd.MaPhong, p.TenPhong, hd.NgayLapHoaDon, hd.HanHoaDon, hd.SoTienThanhToan, tthd.TenTrangThai
                          FROM HoaDon hd
                          JOIN Phong p ON hd.MaPhong = p.MaPhong
                          JOIN TrangThaiHoaDon tthd ON hd.MaTrangThaiHoaDon = tthd.MaTrangThai
                          WHERE hd.MaTrangThaiHoaDon != 1";
            }

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@UserID", User.UserID);
            DataTable dt = GetData(cmd);
            dGV_HoaDon.DataSource = dt;
        }

        private void DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dGV_HoaDon.ClearSelection();
                dGV_HoaDon.Rows[e.RowIndex].Selected = true;
                dGV_HoaDon.CurrentCell = dGV_HoaDon.Rows[e.RowIndex].Cells[0];
            }
        }

        private void ThanhToanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dGV_HoaDon.CurrentRow.Index;
            var maHoaDon = dGV_HoaDon.Rows[selectedRowIndex].Cells["MaHoaDon"].Value.ToString();
            ThanhToanHoaDonForm thanhToanForm = new ThanhToanHoaDonForm(maHoaDon);
            thanhToanForm.ShowDialog();
            LoadHoaDonList(); // Tải lại danh sách hóa đơn sau khi thanh toán
        }
    }
}
