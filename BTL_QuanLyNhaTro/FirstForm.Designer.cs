﻿
namespace BTL_QuanLyNhaTro
{
    partial class FirstForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trangChủToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_infoAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_setRoleAccount_A = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_cPass = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_logout = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_Manage = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_mRoom_R = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_vRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_addRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_mContract_R_U = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_vContract_U = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_aContract = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_mUser_R = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_vUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtHóaĐơnThanhToánChoKháchThuêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_mBill_R = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_aBill = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_vBill = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_mChuTro = new System.Windows.Forms.ToolStripMenuItem();
            this.themChuTroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSachChuTroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_vRevenue_R = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_PayBill = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_rRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.lb1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.mApp_Manage,
            this.mApp_vRevenue_R,
            this.mApp_PayBill,
            this.mApp_rRoom});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuApp";
            // 
            // trangChủToolStripMenuItem
            // 
            this.trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            this.trangChủToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mApp_infoAccount,
            this.mApp_setRoleAccount_A,
            this.mApp_cPass,
            this.mApp_logout});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // mApp_infoAccount
            // 
            this.mApp_infoAccount.Name = "mApp_infoAccount";
            this.mApp_infoAccount.Size = new System.Drawing.Size(212, 22);
            this.mApp_infoAccount.Text = "Thông tin tài khoản";
            // 
            // mApp_setRoleAccount_A
            // 
            this.mApp_setRoleAccount_A.Name = "mApp_setRoleAccount_A";
            this.mApp_setRoleAccount_A.Size = new System.Drawing.Size(212, 22);
            this.mApp_setRoleAccount_A.Text = "Phân quyền cho tài khoản";
            // 
            // mApp_cPass
            // 
            this.mApp_cPass.Name = "mApp_cPass";
            this.mApp_cPass.Size = new System.Drawing.Size(212, 22);
            this.mApp_cPass.Text = "Đổi mật khẩu";
            // 
            // mApp_logout
            // 
            this.mApp_logout.Name = "mApp_logout";
            this.mApp_logout.Size = new System.Drawing.Size(212, 22);
            this.mApp_logout.Text = "Đăng xuất";
            this.mApp_logout.Click += new System.EventHandler(this.mApp_logout_Click);
            // 
            // mApp_Manage
            // 
            this.mApp_Manage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mApp_mRoom_R,
            this.mApp_mContract_R_U,
            this.mApp_mUser_R,
            this.mApp_mBill_R,
            this.mApp_mChuTro});
            this.mApp_Manage.Name = "mApp_Manage";
            this.mApp_Manage.Size = new System.Drawing.Size(60, 20);
            this.mApp_Manage.Text = "Quản lý";
            // 
            // mApp_mRoom_R
            // 
            this.mApp_mRoom_R.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mApp_vRoom,
            this.mApp_addRoom});
            this.mApp_mRoom_R.Name = "mApp_mRoom_R";
            this.mApp_mRoom_R.Size = new System.Drawing.Size(177, 22);
            this.mApp_mRoom_R.Text = "Quản lý phòng";
            // 
            // mApp_vRoom
            // 
            this.mApp_vRoom.Name = "mApp_vRoom";
            this.mApp_vRoom.Size = new System.Drawing.Size(193, 22);
            this.mApp_vRoom.Text = "Xem danh sách phòng";
            this.mApp_vRoom.Click += new System.EventHandler(this.mApp_vRoom_Click);
            // 
            // mApp_addRoom
            // 
            this.mApp_addRoom.Name = "mApp_addRoom";
            this.mApp_addRoom.Size = new System.Drawing.Size(193, 22);
            this.mApp_addRoom.Text = "Thêm phòng trọ";
            this.mApp_addRoom.Click += new System.EventHandler(this.mApp_addRoom_Click_1);
            // 
            // mApp_mContract_R_U
            // 
            this.mApp_mContract_R_U.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mApp_vContract_U,
            this.mApp_aContract});
            this.mApp_mContract_R_U.Name = "mApp_mContract_R_U";
            this.mApp_mContract_R_U.Size = new System.Drawing.Size(177, 22);
            this.mApp_mContract_R_U.Text = "Quản lý hợp đồng";
            // 
            // mApp_vContract_U
            // 
            this.mApp_vContract_U.Name = "mApp_vContract_U";
            this.mApp_vContract_U.Size = new System.Drawing.Size(184, 22);
            this.mApp_vContract_U.Text = "Danh sách hợp đồng";
            this.mApp_vContract_U.Click += new System.EventHandler(this.mApp_vContract_U_Click);
            // 
            // mApp_aContract
            // 
            this.mApp_aContract.Name = "mApp_aContract";
            this.mApp_aContract.Size = new System.Drawing.Size(184, 22);
            this.mApp_aContract.Text = "Tạo hợp đồng";
            this.mApp_aContract.Click += new System.EventHandler(this.mApp_aContract_Click);
            // 
            // mApp_mUser_R
            // 
            this.mApp_mUser_R.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mApp_vUser,
            this.cậpNhậtHóaĐơnThanhToánChoKháchThuêToolStripMenuItem,
            this.thToolStripMenuItem});
            this.mApp_mUser_R.Name = "mApp_mUser_R";
            this.mApp_mUser_R.Size = new System.Drawing.Size(180, 22);
            this.mApp_mUser_R.Text = "Quản lý khách thuê";
            // 
            // mApp_vUser
            // 
            this.mApp_vUser.Name = "mApp_vUser";
            this.mApp_vUser.Size = new System.Drawing.Size(315, 22);
            this.mApp_vUser.Text = "Xem danh sách khách thuê";
            // 
            // cậpNhậtHóaĐơnThanhToánChoKháchThuêToolStripMenuItem
            // 
            this.cậpNhậtHóaĐơnThanhToánChoKháchThuêToolStripMenuItem.Name = "cậpNhậtHóaĐơnThanhToánChoKháchThuêToolStripMenuItem";
            this.cậpNhậtHóaĐơnThanhToánChoKháchThuêToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.cậpNhậtHóaĐơnThanhToánChoKháchThuêToolStripMenuItem.Text = "Cập nhật hóa đơn thanh toán cho khách thuê";
            // 
            // thToolStripMenuItem
            // 
            this.thToolStripMenuItem.Name = "thToolStripMenuItem";
            this.thToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.thToolStripMenuItem.Text = "Thêm khách thuê";
            this.thToolStripMenuItem.Click += new System.EventHandler(this.thToolStripMenuItem_Click);
            // 
            // mApp_mBill_R
            // 
            this.mApp_mBill_R.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mApp_aBill,
            this.mApp_vBill});
            this.mApp_mBill_R.Name = "mApp_mBill_R";
            this.mApp_mBill_R.Size = new System.Drawing.Size(177, 22);
            this.mApp_mBill_R.Text = "Quản lý hóa đơn";
            // 
            // mApp_aBill
            // 
            this.mApp_aBill.Name = "mApp_aBill";
            this.mApp_aBill.Size = new System.Drawing.Size(202, 22);
            this.mApp_aBill.Text = "Thêm hóa đơn";
            this.mApp_aBill.Click += new System.EventHandler(this.mApp_aBill_Click);
            // 
            // mApp_vBill
            // 
            this.mApp_vBill.Name = "mApp_vBill";
            this.mApp_vBill.Size = new System.Drawing.Size(202, 22);
            this.mApp_vBill.Text = "Xem danh sách hóa đơn";
            this.mApp_vBill.Click += new System.EventHandler(this.mApp_vBill_Click);
            // 
            // mApp_mChuTro
            // 
            this.mApp_mChuTro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themChuTroToolStripMenuItem,
            this.danhSachChuTroToolStripMenuItem});
            this.mApp_mChuTro.Name = "mApp_mChuTro";
            this.mApp_mChuTro.Size = new System.Drawing.Size(177, 22);
            this.mApp_mChuTro.Text = "Quản lý chủ trọ";
            // 
            // themChuTroToolStripMenuItem
            // 
            this.themChuTroToolStripMenuItem.Name = "themChuTroToolStripMenuItem";
            this.themChuTroToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.themChuTroToolStripMenuItem.Text = "Thêm chủ trọ";
            this.themChuTroToolStripMenuItem.Click += new System.EventHandler(this.themChuTroToolStripMenuItem_Click);
            // 
            // danhSachChuTroToolStripMenuItem
            // 
            this.danhSachChuTroToolStripMenuItem.Name = "danhSachChuTroToolStripMenuItem";
            this.danhSachChuTroToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.danhSachChuTroToolStripMenuItem.Text = "Danh sách chủ trọ";
            this.danhSachChuTroToolStripMenuItem.Click += new System.EventHandler(this.danhSachChuTroToolStripMenuItem_Click);
            // 
            // mApp_vRevenue_R
            // 
            this.mApp_vRevenue_R.Name = "mApp_vRevenue_R";
            this.mApp_vRevenue_R.Size = new System.Drawing.Size(119, 20);
            this.mApp_vRevenue_R.Text = "Báo cáo doanh thu";
            this.mApp_vRevenue_R.Click += new System.EventHandler(this.mApp_vRevenue_R_Click);
            // 
            // mApp_PayBill
            // 
            this.mApp_PayBill.Name = "mApp_PayBill";
            this.mApp_PayBill.Size = new System.Drawing.Size(126, 20);
            this.mApp_PayBill.Text = "Thanh toán hóa đơn";
            this.mApp_PayBill.Click += new System.EventHandler(this.mApp_PayBill_Click);
            // 
            // mApp_rRoom
            // 
            this.mApp_rRoom.Name = "mApp_rRoom";
            this.mApp_rRoom.Size = new System.Drawing.Size(101, 20);
            this.mApp_rRoom.Text = "Thuê phòng trọ";
            this.mApp_rRoom.Click += new System.EventHandler(this.mApp_rRoom_Click);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(142, 57);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(476, 84);
            this.lb1.TabIndex = 1;
            this.lb1.Text = " Ứng dụng\r\n quản lý và thuê phòng trọ";
            this.lb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FirstForm";
            this.Text = "FirstForm";
            this.Shown += new System.EventHandler(this.FirstForm_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trangChủToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mApp_infoAccount;
        private System.Windows.Forms.ToolStripMenuItem mApp_cPass;
        private System.Windows.Forms.ToolStripMenuItem mApp_logout;
        private System.Windows.Forms.ToolStripMenuItem mApp_Manage;
        private System.Windows.Forms.ToolStripMenuItem mApp_vRevenue_R;
        private System.Windows.Forms.ToolStripMenuItem mApp_PayBill;
        private System.Windows.Forms.ToolStripMenuItem mApp_setRoleAccount_A;
        private System.Windows.Forms.ToolStripMenuItem mApp_mRoom_R;
        private System.Windows.Forms.ToolStripMenuItem mApp_vRoom;
        private System.Windows.Forms.ToolStripMenuItem mApp_addRoom;
        private System.Windows.Forms.ToolStripMenuItem mApp_mContract_R_U;
        private System.Windows.Forms.ToolStripMenuItem mApp_aContract;
        private System.Windows.Forms.ToolStripMenuItem mApp_mUser_R;
        private System.Windows.Forms.ToolStripMenuItem mApp_vUser;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtHóaĐơnThanhToánChoKháchThuêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mApp_rRoom;
        private System.Windows.Forms.ToolStripMenuItem mApp_vContract_U;
        private System.Windows.Forms.ToolStripMenuItem mApp_mBill_R;
        private System.Windows.Forms.ToolStripMenuItem mApp_aBill;
        private System.Windows.Forms.ToolStripMenuItem mApp_vBill;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.ToolStripMenuItem thToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mApp_mChuTro;
        private System.Windows.Forms.ToolStripMenuItem themChuTroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSachChuTroToolStripMenuItem;
    }
}