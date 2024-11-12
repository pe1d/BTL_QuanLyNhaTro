using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static BTL_QuanLyNhaTro.WelcomeForm;
using static BTL_QuanLyNhaTro.AuthenticationService;
namespace BTL_QuanLyNhaTro
{
    public partial class FormShowListRooms : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;
        private int ma = User.RoleID;
        public FormShowListRooms()
        {
            InitializeComponent();
            LoadListRooms();
            LoadOwnCode();
            checkRule();
        }
        public void checkRule()
        {
            if (ma == 2)
            {
                // Disable (vô hiệu hóa) ComboBox
                comboBoxRole.Enabled = false;

                // Hoặc nếu bạn muốn ẩn ComboBox
                //comboBoxOwnCode.Visible = false;
            }
        }

        // Tạo hàm lấy danh sách phòng
        public DataTable LayDanhSachPhong()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT TOP (1000) [MaPhong], [TenPhong], [MaChuTro], [SoPhong], [DienTich], [Tang], [GiaThue], [MaTrangThai], [DiaChi] FROM [QlyNhaTro].[dbo].[Phong]";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lấy danh sách phòng: " + ex.Message);
            }

            return dataTable;
        }

        // Hiển thị danh sách phòng lên DataGridView
        public void LoadListRooms()
        {
            DataTable danhSachPhong = LayDanhSachPhong();
            dgvRoom.DataSource = danhSachPhong;
        }

        private void FormShowListRooms_Load(object sender, EventArgs e)
        {
        }

        // Hàm lấy danh sách mã chủ trọ
        public List<string> LayDanhSachMaChuTro()
        {
            List<string> danhSachMaChuTro = new List<string>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MaChuTro FROM [QlyNhaTro].[dbo].[ChuTro]";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string maChuTro = reader["MaChuTro"].ToString();
                                danhSachMaChuTro.Add(maChuTro);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lấy danh sách mã chủ trọ: " + ex.Message);
            }

            return danhSachMaChuTro;
        }

        // Hàm tải mã chủ trọ lên ComboBox
        public void LoadOwnCode()
        {
            List<string> danhSachMaChuTro = LayDanhSachMaChuTro();
            comboBoxRole.DataSource = danhSachMaChuTro;
        }

        // Tìm kiếm phòng theo mã chủ trọ
        public DataTable TimKiemTheoMaChuTro(string maChuTro)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT [MaPhong], [TenPhong], [MaChuTro], [SoPhong], [DienTich], [Tang], [GiaThue], [MaTrangThai], [DiaChi] " +
                                   "FROM [QlyNhaTro].[dbo].[Phong] " +
                                   "WHERE [MaChuTro] = @MaChuTro";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaChuTro", maChuTro);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tìm kiếm phòng: " + ex.Message);
            }

            return dataTable;
        }

        // Sự kiện khi chọn một mã chủ trọ từ ComboBox
        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maChuTro = comboBoxRole.SelectedItem?.ToString() ?? "";

            if (string.IsNullOrEmpty(maChuTro))
            {
                MessageBox.Show("Vui lòng chọn mã chủ trọ.");
                return;
            }

            // Thực hiện tìm kiếm và hiển thị kết quả
            DataTable danhSachPhong = TimKiemTheoMaChuTro(maChuTro);
            dgvRoom.DataSource = danhSachPhong; // Hiển thị kết quả trong DataGridView
        }
    }

    // Định nghĩa lớp Phong nếu cần
    public class Phong
    {
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }
        public string MaChuTro { get; set; }
        public int SoPhong { get; set; }
        public double DienTich { get; set; }
        public int Tang { get; set; }
        public double GiaThue { get; set; }
        public string MaTrangThai { get; set; }
        public string DiaChi { get; set; }
    }
}
