
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
            this.mApp_uRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_sRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_mService_A = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_aService = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_uService = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_mContract_R_U = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_vContract_U = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_sContract = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_aContract = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_mUser_R = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_vUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_uUser = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtHóaĐơnThanhToánChoKháchThuêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_mBill_R = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_aBill = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_vBill = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_sBill = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_vRevenue_R = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_earnDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_earnGeneral = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_PayBill = new System.Windows.Forms.ToolStripMenuItem();
            this.mApp_rRoom = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmPhòngTrọToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lb1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trangChủToolStripMenuItem,
            this.tàiKhoảnToolStripMenuItem,
            this.mApp_Manage,
            this.mApp_vRevenue_R,
            this.mApp_PayBill,
            this.mApp_rRoom});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
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
            // 
            // mApp_Manage
            // 
            this.mApp_Manage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mApp_mRoom_R,
            this.mApp_mService_A,
            this.mApp_mContract_R_U,
            this.mApp_mUser_R,
            this.mApp_mBill_R});
            this.mApp_Manage.Name = "mApp_Manage";
            this.mApp_Manage.Size = new System.Drawing.Size(60, 20);
            this.mApp_Manage.Text = "Quản lý";
            // 
            // mApp_mRoom_R
            // 
            this.mApp_mRoom_R.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mApp_vRoom,
            this.mApp_addRoom,
            this.mApp_uRoom,
            this.mApp_sRoom});
            this.mApp_mRoom_R.Name = "mApp_mRoom_R";
            this.mApp_mRoom_R.Size = new System.Drawing.Size(177, 22);
            this.mApp_mRoom_R.Text = "Quản lý phòng";
            // 
            // mApp_vRoom
            // 
            this.mApp_vRoom.Name = "mApp_vRoom";
            this.mApp_vRoom.Size = new System.Drawing.Size(201, 22);
            this.mApp_vRoom.Text = "Xem danh sách phòng";
            // 
            // mApp_addRoom
            // 
            this.mApp_addRoom.Name = "mApp_addRoom";
            this.mApp_addRoom.Size = new System.Drawing.Size(201, 22);
            this.mApp_addRoom.Text = "Thêm phòng trọ";
            // 
            // mApp_uRoom
            // 
            this.mApp_uRoom.Name = "mApp_uRoom";
            this.mApp_uRoom.Size = new System.Drawing.Size(201, 22);
            this.mApp_uRoom.Text = "Sửa thông tin phòng trọ";
            // 
            // mApp_sRoom
            // 
            this.mApp_sRoom.Name = "mApp_sRoom";
            this.mApp_sRoom.Size = new System.Drawing.Size(201, 22);
            this.mApp_sRoom.Text = "Tìm kiếm phòng trọ";
            // 
            // mApp_mService_A
            // 
            this.mApp_mService_A.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mApp_aService,
            this.mApp_uService});
            this.mApp_mService_A.Name = "mApp_mService_A";
            this.mApp_mService_A.Size = new System.Drawing.Size(177, 22);
            this.mApp_mService_A.Text = "Quản lý dịch vụ";
            // 
            // mApp_aService
            // 
            this.mApp_aService.Name = "mApp_aService";
            this.mApp_aService.Size = new System.Drawing.Size(187, 22);
            this.mApp_aService.Text = "Thêm dịch vụ";
            // 
            // mApp_uService
            // 
            this.mApp_uService.Name = "mApp_uService";
            this.mApp_uService.Size = new System.Drawing.Size(187, 22);
            this.mApp_uService.Text = "Sửa thông tin dịch vụ";
            // 
            // mApp_mContract_R_U
            // 
            this.mApp_mContract_R_U.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mApp_vContract_U,
            this.mApp_sContract,
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
            // 
            // mApp_sContract
            // 
            this.mApp_sContract.Name = "mApp_sContract";
            this.mApp_sContract.Size = new System.Drawing.Size(184, 22);
            this.mApp_sContract.Text = "Tìm kiếm hợp đồng";
            // 
            // mApp_aContract
            // 
            this.mApp_aContract.Name = "mApp_aContract";
            this.mApp_aContract.Size = new System.Drawing.Size(184, 22);
            this.mApp_aContract.Text = "Tạo hợp đồng";
            // 
            // mApp_mUser_R
            // 
            this.mApp_mUser_R.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mApp_vUser,
            this.mApp_uUser,
            this.cậpNhậtHóaĐơnThanhToánChoKháchThuêToolStripMenuItem});
            this.mApp_mUser_R.Name = "mApp_mUser_R";
            this.mApp_mUser_R.Size = new System.Drawing.Size(177, 22);
            this.mApp_mUser_R.Text = "Quản lý khách thuê";
            // 
            // mApp_vUser
            // 
            this.mApp_vUser.Name = "mApp_vUser";
            this.mApp_vUser.Size = new System.Drawing.Size(315, 22);
            this.mApp_vUser.Text = "Xem danh sách khách thuê";
            // 
            // mApp_uUser
            // 
            this.mApp_uUser.Name = "mApp_uUser";
            this.mApp_uUser.Size = new System.Drawing.Size(315, 22);
            this.mApp_uUser.Text = "Sửa thông tin khách hàng";
            // 
            // cậpNhậtHóaĐơnThanhToánChoKháchThuêToolStripMenuItem
            // 
            this.cậpNhậtHóaĐơnThanhToánChoKháchThuêToolStripMenuItem.Name = "cậpNhậtHóaĐơnThanhToánChoKháchThuêToolStripMenuItem";
            this.cậpNhậtHóaĐơnThanhToánChoKháchThuêToolStripMenuItem.Size = new System.Drawing.Size(315, 22);
            this.cậpNhậtHóaĐơnThanhToánChoKháchThuêToolStripMenuItem.Text = "Cập nhật hóa đơn thanh toán cho khách thuê";
            // 
            // mApp_mBill_R
            // 
            this.mApp_mBill_R.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mApp_aBill,
            this.mApp_vBill,
            this.mApp_sBill});
            this.mApp_mBill_R.Name = "mApp_mBill_R";
            this.mApp_mBill_R.Size = new System.Drawing.Size(180, 22);
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
            // 
            // mApp_sBill
            // 
            this.mApp_sBill.Name = "mApp_sBill";
            this.mApp_sBill.Size = new System.Drawing.Size(202, 22);
            this.mApp_sBill.Text = "Tìm kiếm hóa đơn";
            // 
            // mApp_vRevenue_R
            // 
            this.mApp_vRevenue_R.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mApp_earnDetail,
            this.mApp_earnGeneral});
            this.mApp_vRevenue_R.Name = "mApp_vRevenue_R";
            this.mApp_vRevenue_R.Size = new System.Drawing.Size(119, 20);
            this.mApp_vRevenue_R.Text = "Báo cáo doanh thu";
            // 
            // mApp_earnDetail
            // 
            this.mApp_earnDetail.Name = "mApp_earnDetail";
            this.mApp_earnDetail.Size = new System.Drawing.Size(171, 22);
            this.mApp_earnDetail.Text = "Báo cáo chi tiết";
            // 
            // mApp_earnGeneral
            // 
            this.mApp_earnGeneral.Name = "mApp_earnGeneral";
            this.mApp_earnGeneral.Size = new System.Drawing.Size(171, 22);
            this.mApp_earnGeneral.Text = "Báo cáo tông quát";
            // 
            // mApp_PayBill
            // 
            this.mApp_PayBill.Name = "mApp_PayBill";
            this.mApp_PayBill.Size = new System.Drawing.Size(126, 20);
            this.mApp_PayBill.Text = "Thanh toán hóa đơn";
            // 
            // mApp_rRoom
            // 
            this.mApp_rRoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmPhòngTrọToolStripMenuItem1});
            this.mApp_rRoom.Name = "mApp_rRoom";
            this.mApp_rRoom.Size = new System.Drawing.Size(101, 20);
            this.mApp_rRoom.Text = "Thuê phòng trọ";
            // 
            // tìmKiếmPhòngTrọToolStripMenuItem1
            // 
            this.tìmKiếmPhòngTrọToolStripMenuItem1.Name = "tìmKiếmPhòngTrọToolStripMenuItem1";
            this.tìmKiếmPhòngTrọToolStripMenuItem1.Size = new System.Drawing.Size(179, 22);
            this.tìmKiếmPhòngTrọToolStripMenuItem1.Text = "Tìm kiếm phòng trọ";
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
        private System.Windows.Forms.ToolStripMenuItem mApp_uRoom;
        private System.Windows.Forms.ToolStripMenuItem mApp_sRoom;
        private System.Windows.Forms.ToolStripMenuItem mApp_mService_A;
        private System.Windows.Forms.ToolStripMenuItem mApp_aService;
        private System.Windows.Forms.ToolStripMenuItem mApp_uService;
        private System.Windows.Forms.ToolStripMenuItem mApp_mContract_R_U;
        private System.Windows.Forms.ToolStripMenuItem mApp_sContract;
        private System.Windows.Forms.ToolStripMenuItem mApp_aContract;
        private System.Windows.Forms.ToolStripMenuItem mApp_mUser_R;
        private System.Windows.Forms.ToolStripMenuItem mApp_vUser;
        private System.Windows.Forms.ToolStripMenuItem mApp_uUser;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtHóaĐơnThanhToánChoKháchThuêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mApp_rRoom;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmPhòngTrọToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mApp_vContract_U;
        private System.Windows.Forms.ToolStripMenuItem mApp_mBill_R;
        private System.Windows.Forms.ToolStripMenuItem mApp_aBill;
        private System.Windows.Forms.ToolStripMenuItem mApp_vBill;
        private System.Windows.Forms.ToolStripMenuItem mApp_sBill;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.ToolStripMenuItem mApp_earnDetail;
        private System.Windows.Forms.ToolStripMenuItem mApp_earnGeneral;
    }
}