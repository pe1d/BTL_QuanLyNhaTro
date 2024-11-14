using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BTL_QuanLyNhaTro.FunctionAll;
using static BTL_QuanLyNhaTro.AuthenticationService;
using System.Data.SqlClient;

namespace BTL_QuanLyNhaTro
{
    public partial class FormThemNguoiThue : Form
    {
        private string tk, mk;
        public FormThemNguoiThue(string tk, string mk)
        {
            InitializeComponent();
            this.tk = tk;
            this.mk = mk;
            LoadData();
        }
        public void LoadData()
        {
            if (!string.IsNullOrEmpty(tk) && !string.IsNullOrEmpty(mk))
            {
                tb_MatKhau.Text = mk;
                tb_TaiKhoan.Text = tk;
                tb_TaiKhoan.Enabled = false;
                tb_MatKhau.Enabled = false;
                btn_huy.Visible = true;
            }
        }
        private void btn_ThemNguoiThue_Click(object sender, EventArgs e)
        {
            string ma = "NT_" + DateTime.Now.ToString("yyyyMMdd-HHmmss");
            string taiKhoan = tb_TaiKhoan.Text;
            string matKhau = tb_MatKhau.Text;
            string hoTen = tb_HoTen.Text;
            string canCuocCongDan = tb_CanCuoc.Text;
            string soDienThoai = tb_SoDienThoai.Text;
            DateTime ngaySinh = date_NgaySinh.Value;
            string gioiTinh = rB_Nam.Checked ? "Nam" : "Nu"; // Assuming rbtnNam and rbtnNu for gender
            string diaChi = tb_DiaChi.Text;
            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau) ||
                string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(canCuocCongDan) ||
                string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng điền tất cả các trường bắt buộc (*)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int age = DateTime.Now.Year - ngaySinh.Year;
            if (ngaySinh > DateTime.Now.AddYears(-age)) age--; // Adjust if birthday has not occurred this year
            if (age < 17)
            {
                MessageBox.Show("Người thuê phải từ 17 tuổi trở lên.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlCommand cmdCheck = new SqlCommand("Select Count(*) from TaiKhoan where TenDangNhap = @tenDangNhap");
            cmdCheck.Parameters.AddWithValue("@tenDangNhap", taiKhoan);
            if (CheckDK(cmdCheck, "Tài khoản đã tồn tại. Vui lòng chọn tên đăng nhập khác!", "have"))
            {
                return;
            }
            string queryCT = @"INSERT INTO NguoiThue VALUES (@MaNguoiThue, @TenNguoiThue, @CMND, @SoDienThoai, @NgaySinh, @GioiTinh, @DiaChi, null)";
            string queryTK = @"INSERT INTO TaiKhoan VALUES (@MaTK, @TenDangNhap, @MatKhau, '1')";
            SqlCommand cmd = new SqlCommand(queryCT);
            SqlCommand cmdTK = new SqlCommand(queryTK);
            //Tài khoản
            cmdTK.Parameters.AddWithValue("@MaTK", ma);
            cmdTK.Parameters.AddWithValue("@TenDangNhap", taiKhoan);
            cmdTK.Parameters.AddWithValue("@MatKhau", matKhau);
            //Người thuê
            cmd.Parameters.AddWithValue("@MaNguoiThue", ma);
            cmd.Parameters.AddWithValue("@TenNguoiThue", hoTen);
            cmd.Parameters.AddWithValue("@CMND", canCuocCongDan);
            cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
            cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
            cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
            cmd.Parameters.AddWithValue("@DiaChi", diaChi);
            try
            {
                ExecuteNonQuery(cmdTK);
                ExecuteNonQuery(cmd);
                if (string.IsNullOrEmpty(tk) && string.IsNullOrEmpty(mk))
                {
                    MessageBox.Show("Thêm người thuê thành công!");
                }
                else
                {
                    MessageBox.Show("Thêm thông tin thành công!");
                    this.Hide();
                    Authenticate(taiKhoan, matKhau);
                    FirstForm f = new FirstForm();
                    f.Show();
                }

            }
            catch (Exception er)
            {
                MessageBox.Show("Lỗi: " + er);
            }
        }

        private void btn_huy_Click_1(object sender, EventArgs e)
        {
            Logout();
            var openForms = new List<Form>(Application.OpenForms.Cast<Form>());

            foreach (Form form in openForms)
            {
                if (form.Name != "WelcomeForm")
                {
                    form.Close();
                }
            }
            WelcomeForm f = new WelcomeForm();
            f.Show();
        }

        private void tb_SoDienThoai_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            tb_NumberInput_KeyPress(sender, e);
        }

        private void tb_CanCuoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_NumberInput_KeyPress(sender, e);
        }

    }
}
