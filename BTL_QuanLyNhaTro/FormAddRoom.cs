using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static BTL_QuanLyNhaTro.AuthenticationService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BTL_QuanLyNhaTro
{
    public partial class FormAddRoom : Form
    {
        // Kết nối từ file cấu hình
        public static string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;
        private int ma = User.RoleID;
        public FormAddRoom()
        {
            InitializeComponent();
            LoadOwnCode();
            checkRule();
        }
        public void checkRule()
        {
            if (ma == 2)
            {
                comboBoxOwnCode.Enabled = false;
            }
        }
        // Hàm thêm phòng
        public void ThemPhong(string maPhong, string tenPhong, string maChuTro, int soPhong, decimal dienTich, int tang, decimal giaThue, string maTrangThai, string diaChi)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_ThemPhong", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@MaPhong", maPhong);
                        cmd.Parameters.AddWithValue("@TenPhong", tenPhong);
                        cmd.Parameters.AddWithValue("@MaChuTro", maChuTro);
                        cmd.Parameters.AddWithValue("@SoPhong", soPhong);
                        cmd.Parameters.AddWithValue("@DienTich", dienTich);
                        cmd.Parameters.AddWithValue("@Tang", tang);
                        cmd.Parameters.AddWithValue("@GiaThue", giaThue);
                        cmd.Parameters.AddWithValue("@MaTrangThai", maTrangThai);
                        cmd.Parameters.AddWithValue("@DiaChi", diaChi);

                        cmd.ExecuteNonQuery();
                       
                        MessageBox.Show("Thêm phòng thành công!");
                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }
        //Hàm lấy mã trạng thái
        public List<string> LayDanhSachMaTrangThai()
        {
            List<string> danhSachMaTrangThai = new List<string>();

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT MaTrangThai FROM [QlyNhaTro].[dbo].[TrangThaiPhong]";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string maTrangThai = reader["MaTrangThai"].ToString();
                                danhSachMaTrangThai.Add(maTrangThai);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi lấy danh sách mã chủ trọ: " + ex.Message);
            }

            return danhSachMaTrangThai;
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
            comboBoxOwnCode.DataSource = danhSachMaChuTro;
            List<string> danhSachMaTrangThai = LayDanhSachMaTrangThai();
            comboBoxStatus.DataSource = danhSachMaTrangThai;
        }

        // Sự kiện khi bấm nút thêm phòng
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string maChuTro = comboBoxOwnCode.SelectedItem?.ToString() ?? "";
                string maTrangThai = comboBoxStatus.SelectedItem?.ToString() ?? "";

                // Chuyển đổi dữ liệu và bắt lỗi nếu có
                int soPhong = int.Parse(textBoxRoomNumber.Text);
                decimal dienTich = decimal.Parse(textBoxArea.Text);
                int tang = int.Parse(textBoxFloor.Text);
                decimal giaThue = decimal.Parse(textBoxRentPrice.Text);

                ThemPhong(
                    textBoxRoomCode.Text,
                    textBoxRoomName.Text,
                    maChuTro,
                    soPhong,
                    dienTich,
                    tang,
                    giaThue,
                    maTrangThai,
                    textBoxAddress.Text
                );
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng kiểm tra lại định dạng dữ liệu nhập vào.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message);
            }
        }

        

    }
}
