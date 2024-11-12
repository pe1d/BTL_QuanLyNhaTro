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
using static BTL_QuanLyNhaTro.FunctionAll;

namespace BTL_QuanLyNhaTro
{
    public partial class FormThemChuTro : Form
    {
        public FormThemChuTro()
        {
            InitializeComponent();
            LoadBankNames();
        }

        private void btn_ThemChuTro_Click(object sender, EventArgs e)
        {
            string ma = "CT_" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
            string taiKhoan = tb_TaiKhoan.Text;
            string matKhau = tb_MatKhau.Text;
            string hoTen = tb_HoTen.Text;
            string canCuocCongDan = tb_CanCuoc.Text;
            string soDienThoai = tb_SoDienThoai.Text;
            DateTime ngaySinh = date_NgaySinh.Value;
            string gioiTinh = rB_Nam.Checked ? "Nam" : "Nu"; // Assuming rbtnNam and rbtnNu for gender
            string nganHang = cB_NganHang.Text;
            string soTaiKhoan = tb_SoTaiKhoan.Text;
            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau) ||
                string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(canCuocCongDan) ||
                string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(nganHang) ||
                string.IsNullOrEmpty(soTaiKhoan))
            {
                MessageBox.Show("Vui lòng điền tất cả các trường bắt buộc (*)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int age = DateTime.Now.Year - ngaySinh.Year;
            if (ngaySinh > DateTime.Now.AddYears(-age)) age--; // Adjust if birthday has not occurred this year
            if (age < 18)
            {
                MessageBox.Show("Chủ trọ phải từ 18 tuổi trở lên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlCommand cmdCheck = new SqlCommand("Select Count(*) from TaiKhoan where TenDangNhap = @tenDangNhap");
            cmdCheck.Parameters.AddWithValue("@tenDangNhap", taiKhoan);
            if (CheckDK(cmdCheck, "Tài khoản đã tồn tại. Vui lòng chọn tên đăng nhập khác!","have"))
            {
                return;
            }
            string queryCT = @"INSERT INTO ChuTro VALUES (@MaChuTro, @TenChuTro, @CMND, @SoDienThoai, @GioiTinh, @NgaySinh, @SoTaiKhoan, @NganHang)";
            string queryTK = @"INSERT INTO TaiKhoan VALUES (@MaTK, @TenDangNhap, @MatKhau, '2')";
            SqlCommand cmd = new SqlCommand(queryCT);
            SqlCommand cmdTK = new SqlCommand(queryTK);
            //Tài khoản
            cmdTK.Parameters.AddWithValue("@MaTK", ma);
            cmdTK.Parameters.AddWithValue("@TenDangNhap", taiKhoan);
            cmdTK.Parameters.AddWithValue("@MatKhau", matKhau);
            //Chủ Trọ
            cmd.Parameters.AddWithValue("@MaChuTro", ma);
            cmd.Parameters.AddWithValue("@TenChuTro", hoTen);
            cmd.Parameters.AddWithValue("@CMND", canCuocCongDan);
            cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
            cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
            cmd.Parameters.AddWithValue("@SoTaiKhoan", soTaiKhoan );
            cmd.Parameters.AddWithValue("@NganHang", nganHang);
            try
            {
                ExecuteNonQuery(cmdTK);
                ExecuteNonQuery(cmd);
                MessageBox.Show("Thêm chủ trọ thành công!");
            }
            catch(Exception er)
            {
                MessageBox.Show("Lỗi: " + er);
            }
        }
        public void LoadBankNames()
        {
            // Clear any existing items to avoid duplicates if this method is called multiple times
            cB_NganHang.Items.Clear();

            // Add fixed bank names to the ComboBox
            cB_NganHang.Items.Add("Vietcombank");
            cB_NganHang.Items.Add("BIDV");
            cB_NganHang.Items.Add("VietinBank");
            cB_NganHang.Items.Add("Agribank");
            cB_NganHang.Items.Add("ACB");
            cB_NganHang.Items.Add("Techcombank");
            cB_NganHang.Items.Add("MB Bank");
            cB_NganHang.Items.Add("Sacombank");
            cB_NganHang.Items.Add("VPBank");
            cB_NganHang.Items.Add("TPBank");
            // Optionally, set a default selection
            if (cB_NganHang.Items.Count > 0)
            {
                cB_NganHang.SelectedIndex = 0; // Select the first item by default
            }
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_NumberInput_KeyPress(sender, e);
        }
    }
}
