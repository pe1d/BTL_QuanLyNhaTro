
namespace BTL_QuanLyNhaTro
{
           partial class FormThemHopDong1
           {
            private System.Windows.Forms.Label lbMaPhong;
            private System.Windows.Forms.Label lbTenPhong;
            private System.Windows.Forms.Label lbGiaThue;
            private System.Windows.Forms.Label lbDienTich;
            private System.Windows.Forms.Label lbTang;
            private System.Windows.Forms.TextBox tbMaNguoiThue;
            private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
            private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
            private System.Windows.Forms.Button btnThemHopDong;
            private void InitializeComponent()
            {
                this.lbMaPhong = new System.Windows.Forms.Label();
                this.lbTenPhong = new System.Windows.Forms.Label();
                this.lbGiaThue = new System.Windows.Forms.Label();
                this.lbDienTich = new System.Windows.Forms.Label();
                this.lbTang = new System.Windows.Forms.Label();
                this.tbMaNguoiThue = new System.Windows.Forms.TextBox();
                this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
                this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
                this.btnThemHopDong = new System.Windows.Forms.Button();

                // 
                // lbMaPhong
                // 
                this.lbMaPhong.AutoSize = true;
                this.lbMaPhong.Location = new System.Drawing.Point(12, 15);
                this.lbMaPhong.Name = "lbMaPhong";
                this.lbMaPhong.Size = new System.Drawing.Size(55, 13);
                this.lbMaPhong.TabIndex = 0;
                this.lbMaPhong.Text = "Mã Phòng:";

                // 
                // lbTenPhong
                // 
                this.lbTenPhong.AutoSize = true;
                this.lbTenPhong.Location = new System.Drawing.Point(12, 45);
                this.lbTenPhong.Name = "lbTenPhong";
                this.lbTenPhong.Size = new System.Drawing.Size(65, 13);
                this.lbTenPhong.TabIndex = 1;
                this.lbTenPhong.Text = "Tên Phòng:";

                // 
                // lbGiaThue
                // 
                this.lbGiaThue.AutoSize = true;
                this.lbGiaThue.Location = new System.Drawing.Point(12, 75);
                this.lbGiaThue.Name = "lbGiaThue";
                this.lbGiaThue.Size = new System.Drawing.Size(54, 13);
                this.lbGiaThue.TabIndex = 2;
                this.lbGiaThue.Text = "Giá Thuê:";

                // 
                // lbDienTich
                // 
                this.lbDienTich.AutoSize = true;
                this.lbDienTich.Location = new System.Drawing.Point(12, 105);
                this.lbDienTich.Name = "lbDienTich";
                this.lbDienTich.Size = new System.Drawing.Size(54, 13);
                this.lbDienTich.TabIndex = 3;
                this.lbDienTich.Text = "Diện Tích:";

                // 
                // lbTang
                // 
                this.lbTang.AutoSize = true;
                this.lbTang.Location = new System.Drawing.Point(12, 135);
                this.lbTang.Name = "lbTang";
                this.lbTang.Size = new System.Drawing.Size(38, 13);
                this.lbTang.TabIndex = 4;
                this.lbTang.Text = "Tầng:";

                // 
                // tbMaNguoiThue
                // 
                this.tbMaNguoiThue.Location = new System.Drawing.Point(100, 165);
                this.tbMaNguoiThue.Name = "tbMaNguoiThue";
                this.tbMaNguoiThue.Size = new System.Drawing.Size(200, 20);
                this.tbMaNguoiThue.TabIndex = 5;

                // 
                // dtpNgayBatDau
                // 
                this.dtpNgayBatDau.Location = new System.Drawing.Point(100, 195);
                this.dtpNgayBatDau.Name = "dtpNgayBatDau";
                this.dtpNgayBatDau.Size = new System.Drawing.Size(200, 20);
                this.dtpNgayBatDau.TabIndex = 6;

                // 
                // dtpNgayKetThuc
                // 
                this.dtpNgayKetThuc.Location = new System.Drawing.Point(100, 225);
                this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
                this.dtpNgayKetThuc.Size = new System.Drawing.Size(200, 20);
                this.dtpNgayKetThuc.TabIndex = 7;

                // 
                // btnThemHopDong
                // 
                this.btnThemHopDong.Location = new System.Drawing.Point(100, 255);
                this.btnThemHopDong.Name = "btnThemHopDong";
                this.btnThemHopDong.Size = new System.Drawing.Size(200, 23);
                this.btnThemHopDong.TabIndex = 8;
                this.btnThemHopDong.Text = "Thêm Hợp Đồng";
                this.btnThemHopDong.UseVisualStyleBackColor = true;
                this.btnThemHopDong.Click += new System.EventHandler(this.btnThemHopDong_Click);

                // 
                // FormThemHopDong
                // 
                this.ClientSize = new System.Drawing.Size(320, 300);
                this.Controls.Add(this.lbMaPhong);
                this.Controls.Add(this.lbTenPhong);
                this.Controls.Add(this.lbGiaThue);
                this.Controls.Add(this.lbDienTich);
                this.Controls.Add(this.lbTang);
                this.Controls.Add(this.tbMaNguoiThue);
                this.Controls.Add(this.dtpNgayBatDau);
                this.Controls.Add(this.dtpNgayKetThuc);
                this.Controls.Add(this.btnThemHopDong);
                this.Name = "FormThemHopDong";
                this.Text = "Thêm Hợp Đồng";
                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }

    }