using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static BTL_QuanLyNhaTro.AuthenticationService;
using static BTL_QuanLyNhaTro.FunctionAll;

namespace BTL_QuanLyNhaTro
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
            ApplyRolePermissions(User.RoleID);
            CheckTT();
        }
        private void CheckTT()
        {
            if (User.RoleID == 1)
            {
                SqlCommand cmd = new SqlCommand("select Count(*) from NguoiThue Where MaNguoiThue = @Ma");
                cmd.Parameters.AddWithValue("@Ma", User.UserID);
                if(CheckDK(cmd, "Chưa có thông tin người dùng vui lòng nhập thông tin!","nohave"))
                {
                    NguoiThue nt = new NguoiThue();
                    nt.ShowDialog();
                }
                else
                {
                    return;
                }            
            }
            if (User.RoleID == 2)
            {
                SqlCommand cmd = new SqlCommand("select Count(*) from ChuTro Where MaChuTro = @Ma");
                cmd.Parameters.AddWithValue("@Ma", User.UserID);
                if (CheckDK(cmd, "Chưa có thông tin người dùng vui lòng nhập thông tin!","nohave"))
                {
                    ChuTro ct = new ChuTro();
                    ct.ShowDialog();
                    
                }
                else
                {
                    return;
                }
            }
        }
        private void ApplyRolePermissions(int roleID)
        {
            switch (roleID)
            {
                case 1: // KhachThue
                    mApp_setRoleAccount_A.Visible = false;
                    mApp_mRoom_R.Visible = false;
                    mApp_mUser_R.Visible = false;
                    mApp_aBill.Visible = false;
                    mApp_aContract.Visible = false;
                    mApp_vRevenue_R.Visible = false;
                    mApp_mChuTro.Visible = false;
                    break;
                case 2: // ChuTro
                    mApp_setRoleAccount_A.Visible = false;
                    mApp_rRoom.Visible = false;
                    mApp_mChuTro.Visible = false;
                    break;
                case 3: // Admin
                    break;
            }

        }
        private void mApp_aBill_Click(object sender, EventArgs e)
        {
            FormThemHoaDon f = new FormThemHoaDon();
            f.Show();
        }

        private void mApp_vBill_Click(object sender, EventArgs e)
        {
            FormDSHoaDon f = new FormDSHoaDon();
            f.Show();
        }

        private void mApp_vRoom_Click(object sender, EventArgs e)
        {
            FormShowListRooms f = new FormShowListRooms();
            f.Show();
        }

        private void mApp_PayBill_Click(object sender, EventArgs e)
        {
            FormThanhToanHoaDon f = new FormThanhToanHoaDon(); 
            f.Show();
        }

        private void mApp_rRoom_Click(object sender, EventArgs e)
        {
            FormThuePhongTro f = new FormThuePhongTro();
            f.Show();
        }

        private void mApp_aContract_Click(object sender, EventArgs e)
        {
            FormThemHopDong f = new FormThemHopDong();
            f.Show();
        }

        private void mApp_addRoom_Click(object sender, EventArgs e)
        {
            FormAddRoom f = new FormAddRoom();
            f.Show();
        }
        private void mApp_vContract_U_Click(object sender, EventArgs e)
        {
            FormDanhSachHopDong f = new FormDanhSachHopDong();
            f.Show();
        }
        private void danhSachChuTroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void themChuTroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThemChuTro f = new FormThemChuTro();
            f.Show();
        }

        private void mApp_addRoom_Click_1(object sender, EventArgs e)
        {
            FormAddRoom f = new FormAddRoom();
            f.Show();
        }

        private void mApp_vRevenue_R_Click(object sender, EventArgs e)
        {
            FormBaoCaoDoanhThu f = new FormBaoCaoDoanhThu();
            f.Show();
        }
    }
}
