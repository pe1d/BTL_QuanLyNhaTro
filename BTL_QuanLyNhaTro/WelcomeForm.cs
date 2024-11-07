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
        public static string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;
        public WelcomeForm()
        {
            InitializeComponent();
            cb_show.MouseDown += holdCheckBox_MouseDown;
            cb_show.MouseUp += holdCheckBox_MouseUp;
            cb_show_re.MouseDown += holdCheckBox_MouseDown;
            cb_show_re.MouseUp += holdCheckBox_MouseUp;
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
        public void AddTaiKhoan()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("sp_AddTaiKhoan", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        int maVaiTroIndex = cb_phanquyen.SelectedIndex + 1;

                        // Add parameters for TenDangNhap, MatKhau, and MaVaiTro
                        cmd.Parameters.AddWithValue("@TenDangNhap", tb_name_register.Text);
                        cmd.Parameters.AddWithValue("@MatKhau", tb_pass_register.Text);
                        cmd.Parameters.AddWithValue("@MaVaiTro", maVaiTroIndex);

                        // Generate MaTaiKhoan based on the selected role
                        string maTaiKhoanPrefix = maVaiTroIndex == 1 ? "NT_" :
                                                 maVaiTroIndex == 2 ? "CT_" : "UN_";
                        string maTaiKhoan = maTaiKhoanPrefix + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                        // Add parameter for MaTaiKhoan
                        cmd.Parameters.AddWithValue("@MaTaiKhoan", maTaiKhoan);

                        // Execute the command
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Display message based on the result
                        if (rowsAffected > 0)
                        {
                            ChuTro chutro = new ChuTro();
                            NguoiThue nguoiThue = new NguoiThue();

                            if( maVaiTroIndex == 1)
                            {
                                chutro.Show();
                            }
                            else if (maVaiTroIndex == 2)
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
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        private void bt_re_Click(object sender, EventArgs e)
        {
            AddTaiKhoan();
        }

        private void cb_phanquyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cb_phanquyen.SelectedIndex  +1;
          
        }
    }
}
