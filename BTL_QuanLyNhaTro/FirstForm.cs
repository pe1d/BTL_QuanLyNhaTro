using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static BTL_QuanLyNhaTro.AuthenticationService;

namespace BTL_QuanLyNhaTro
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
            ApplyRolePermissions(User.RoleID);
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

        }

        private void mApp_Manage_Click(object sender, EventArgs e)
        {

        }

        private void mApp_addRoom_Click_1(object sender, EventArgs e)
        {
            FormAddRoom f = new FormAddRoom();
            f.Show();
            //MessageBox.Show("Them Phong");
        }
    }
}
