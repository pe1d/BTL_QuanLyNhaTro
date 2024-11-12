using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SqlClient;
using static BTL_QuanLyNhaTro.FunctionAll;
using static BTL_QuanLyNhaTro.AuthenticationService;

namespace BTL_QuanLyNhaTro
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            cb_show.MouseDown += holdCheckBox_MouseDown;
            cb_show.MouseUp += holdCheckBox_MouseUp;
            cb_show_re.MouseDown += holdCheckBox_MouseDown;
            cb_show_re.MouseUp += holdCheckBox_MouseUp;
            SqlCommand cmd = new SqlCommand("Select * from VaiTro where MaVaiTro != 3");
            LoadDataToComboBox(cmd, cb_phanquyen);
        }
        private void holdCheckBox_MouseDown(object sender, MouseEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            cb.Checked = true;
        }

        private void holdCheckBox_MouseUp(object sender, MouseEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            cb.Checked = false;
        }
        public void AddTaiKhoan()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("Insert into TaiKhoan values (@MaTaiKhoan,@TenDangNhap,@MatKhau,@MaVaiTro)", conn))
                    {
                        int selectedIndex = 0;
                        if (!string.IsNullOrEmpty(cb_phanquyen.SelectedValue.ToString()))
                        {
                            selectedIndex = int.Parse(cb_phanquyen.SelectedValue.ToString());
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn vai trò của bạn!");
                            return;
                        }
                        SqlCommand cmdCheck = new SqlCommand("Select Count(*) from TaiKhoan where TenDangNhap = @tenDangNhap");
                        cmdCheck.Parameters.AddWithValue("@tenDangNhap", tb_name_register.Text);
                        if (CheckDK(cmdCheck, "Tài khoản đã tồn tại. Vui lòng chọn tên đăng nhập khác!","HAVE"))
                        {
                            return;
                        }
                        string maTaiKhoanPrefix = selectedIndex == 1 ? "NT_" :
                                                      selectedIndex == 2 ? "CT_" : "UN_";
                        string maTaiKhoan = maTaiKhoanPrefix + DateTime.Now.ToString("yyyyMMdd-HHmmss");
                        cmd.Parameters.AddWithValue("@MaTaiKhoan", maTaiKhoan);
                        cmd.Parameters.AddWithValue("@TenDangNhap", tb_name_register.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", tb_pass_register.Text);
                        cmd.Parameters.AddWithValue("@MaVaiTro", selectedIndex);
                        
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            ChuTro chutro = new ChuTro();
                            NguoiThue nguoiThue = new NguoiThue();

                            if (selectedIndex == 2)
                            {
                                chutro.Show();
                            }
                            else if (selectedIndex == 1)
                            {
                                nguoiThue.Show();
                            }

                            this.Hide();
                        }

                        else
                        {
                            MessageBox.Show("Failed to add account.");
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.ToString()}");
                }
            }
        }
        private void bt_re_Click(object sender, EventArgs e)
        {
            AddTaiKhoan();
        }

        private void cb_show_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            tb_pass.UseSystemPasswordChar = !cb.Checked;
            tb_pass_register.UseSystemPasswordChar = !cb.Checked;
            tb_confirm_pass.UseSystemPasswordChar = !cb.Checked;
        }

        public void Login(string username, string password)
        {
            AuthenticationService authService = new AuthenticationService();
            authService.Authenticate(username, password);
            //MessageBox.Show(User.RoleID.ToString());
            if (User.RoleID != 0)
            {
                MessageBox.Show("Đăng nhập thành công!");
                FirstForm f = new FirstForm();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng.");
            }
        }
        private void bt_login_Click(object sender, EventArgs e)
        {
            string username = tb_name.Text;
            string password = tb_pass.Text;
            Login(username, password);
        }
    }
}
