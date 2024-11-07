
namespace BTL_QuanLyNhaTro
{
    partial class ThanhToanHoaDonForm
    {
        private System.Windows.Forms.Label lbMaHoaDon;
        private System.Windows.Forms.Label lbTenPhong;
        private System.Windows.Forms.Label lbNgayLap;
        private System.Windows.Forms.Label lbHanHoaDon;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label lbTrangThai;
        private System.Windows.Forms.ComboBox cBPhuongThuc;
        private System.Windows.Forms.Button btnThanhToan;

        private void InitializeComponent()
        {
            this.lbMaHoaDon = new System.Windows.Forms.Label();
            this.lbTenPhong = new System.Windows.Forms.Label();
            this.lbNgayLap = new System.Windows.Forms.Label();
            this.lbHanHoaDon = new System.Windows.Forms.Label();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.lbTrangThai = new System.Windows.Forms.Label();
            this.cBPhuongThuc = new System.Windows.Forms.ComboBox();
            this.btnThanhToan = new System.Windows.Forms.Button();

            // Thiết lập thuộc tính cho các điều khiển
            this.lbMaHoaDon.AutoSize = true;
            this.lbMaHoaDon.Location = new System.Drawing.Point(12, 15);
            this.lbMaHoaDon.Name = "lbMaHoaDon";
            this.lbMaHoaDon.Size = new System.Drawing.Size(35, 13);
            this.lbMaHoaDon.TabIndex = 0;
            this.lbMaHoaDon.Text = "Mã Hóa Đơn:";

            this.lbTenPhong.AutoSize = true;
            this.lbTenPhong.Location = new System.Drawing.Point(12, 45);
            this.lbTenPhong.Name = "lbTenPhong";
            this.lbTenPhong.Size = new System.Drawing.Size(35, 13);
            this.lbTenPhong.TabIndex = 1;
            this.lbTenPhong.Text = "Tên Phòng:";

            this.lbNgayLap.AutoSize = true;
            this.lbNgayLap.Location = new System.Drawing.Point(12, 75);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(53, 13);
            this.lbNgayLap.TabIndex = 2;
            this.lbNgayLap.Text = "Ngày Lập:";

            this.lbHanHoaDon.AutoSize = true;
            this.lbHanHoaDon.Location = new System.Drawing.Point(12, 105);
            this.lbHanHoaDon.Name = "lbHanHoaDon";
            this.lbHanHoaDon.Size = new System.Drawing.Size(73, 13);
            this.lbHanHoaDon.TabIndex = 3;
            this.lbHanHoaDon.Text = "Hạn Hóa Đơn:";

            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Location = new System.Drawing.Point(12, 135);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(47, 13);
            this.lbSoTien.TabIndex = 4;
            this.lbSoTien.Text = "Số Tiền:";

            this.lbTrangThai.AutoSize = true;
            this.lbTrangThai.Location = new System.Drawing.Point(12, 165);
            this.lbTrangThai.Name = "lbTrangThai";
            this.lbTrangThai.Size = new System.Drawing.Size(64, 13);
            this.lbTrangThai.TabIndex = 5;
            this.lbTrangThai.Text = "Trạng Thái:";

            this.cBPhuongThuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBPhuongThuc.FormattingEnabled = true;
            this.cBPhuongThuc.Items.AddRange(new object[] {
            "Tiền mặt",
            "Chuyển khoản"});
            this.cBPhuongThuc.Location = new System.Drawing.Point(115, 195);
            this.cBPhuongThuc.Name = "cBPhuongThuc";
            this.cBPhuongThuc.Size = new System.Drawing.Size(121, 21);
            this.cBPhuongThuc.TabIndex = 6;

            this.btnThanhToan.Location = new System.Drawing.Point(115, 230);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(121, 23);
            this.btnThanhToan.TabIndex = 7;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);

            // Thêm các điều khiển vào form
            this.Controls.Add(this.lbMaHoaDon);
            this.Controls.Add(this.lbTenPhong);
            this.Controls.Add(this.lbNgayLap);
            this.Controls.Add(this.lbHanHoaDon);
            this.Controls.Add(this.lbSoTien);
            this.Controls.Add(this.lbTrangThai);
            this.Controls.Add(this.cBPhuongThuc);
            this.Controls.Add(this.btnThanhToan);

            // Thiết lập thuộc tính form
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "ThanhToanHoaDonForm";
            this.Text = "Thanh Toán Hóa Đơn";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }


}