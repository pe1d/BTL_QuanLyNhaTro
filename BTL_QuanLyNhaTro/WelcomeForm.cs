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

        private void bt_re_Click(object sender, EventArgs e)
        {

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
