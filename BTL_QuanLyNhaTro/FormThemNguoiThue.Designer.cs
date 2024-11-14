
namespace BTL_QuanLyNhaTro
{
    partial class FormThemNguoiThue
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
            this.btn_huy = new System.Windows.Forms.Button();
            this.btn_ThemNguoiThue = new System.Windows.Forms.Button();
            this.date_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rB_Nu = new System.Windows.Forms.RadioButton();
            this.rB_Nam = new System.Windows.Forms.RadioButton();
            this.tb_SoDienThoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_CanCuoc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_HoTen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_MatKhau = new System.Windows.Forms.TextBox();
            this.tb_TaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_huy
            // 
            this.btn_huy.Location = new System.Drawing.Point(105, 329);
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.Size = new System.Drawing.Size(75, 23);
            this.btn_huy.TabIndex = 43;
            this.btn_huy.Text = "Hủy";
            this.btn_huy.UseVisualStyleBackColor = true;
            this.btn_huy.Visible = false;
            this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click_1);
            // 
            // btn_ThemNguoiThue
            // 
            this.btn_ThemNguoiThue.Location = new System.Drawing.Point(24, 329);
            this.btn_ThemNguoiThue.Name = "btn_ThemNguoiThue";
            this.btn_ThemNguoiThue.Size = new System.Drawing.Size(75, 23);
            this.btn_ThemNguoiThue.TabIndex = 42;
            this.btn_ThemNguoiThue.Text = "Thêm";
            this.btn_ThemNguoiThue.UseVisualStyleBackColor = true;
            this.btn_ThemNguoiThue.Click += new System.EventHandler(this.btn_ThemNguoiThue_Click);
            // 
            // date_NgaySinh
            // 
            this.date_NgaySinh.Location = new System.Drawing.Point(25, 259);
            this.date_NgaySinh.Name = "date_NgaySinh";
            this.date_NgaySinh.Size = new System.Drawing.Size(226, 20);
            this.date_NgaySinh.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Giới tính";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Ngày sinh";
            // 
            // rB_Nu
            // 
            this.rB_Nu.AutoSize = true;
            this.rB_Nu.Location = new System.Drawing.Point(324, 262);
            this.rB_Nu.Name = "rB_Nu";
            this.rB_Nu.Size = new System.Drawing.Size(39, 17);
            this.rB_Nu.TabIndex = 34;
            this.rB_Nu.TabStop = true;
            this.rB_Nu.Text = "Nữ";
            this.rB_Nu.UseVisualStyleBackColor = true;
            // 
            // rB_Nam
            // 
            this.rB_Nam.AutoSize = true;
            this.rB_Nam.Location = new System.Drawing.Point(270, 262);
            this.rB_Nam.Name = "rB_Nam";
            this.rB_Nam.Size = new System.Drawing.Size(47, 17);
            this.rB_Nam.TabIndex = 33;
            this.rB_Nam.TabStop = true;
            this.rB_Nam.Text = "Nam";
            this.rB_Nam.UseVisualStyleBackColor = true;
            // 
            // tb_SoDienThoai
            // 
            this.tb_SoDienThoai.Location = new System.Drawing.Point(25, 215);
            this.tb_SoDienThoai.Name = "tb_SoDienThoai";
            this.tb_SoDienThoai.Size = new System.Drawing.Size(339, 20);
            this.tb_SoDienThoai.TabIndex = 32;
            this.tb_SoDienThoai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_SoDienThoai_KeyPress_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Số điện thoại *";
            // 
            // tb_CanCuoc
            // 
            this.tb_CanCuoc.Location = new System.Drawing.Point(25, 175);
            this.tb_CanCuoc.Name = "tb_CanCuoc";
            this.tb_CanCuoc.Size = new System.Drawing.Size(339, 20);
            this.tb_CanCuoc.TabIndex = 30;
            this.tb_CanCuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_CanCuoc_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Căn cước công dân *";
            // 
            // tb_HoTen
            // 
            this.tb_HoTen.Location = new System.Drawing.Point(25, 131);
            this.tb_HoTen.Name = "tb_HoTen";
            this.tb_HoTen.Size = new System.Drawing.Size(339, 20);
            this.tb_HoTen.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Họ tên *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mật khẩu *";
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Location = new System.Drawing.Point(200, 87);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.Size = new System.Drawing.Size(164, 20);
            this.tb_MatKhau.TabIndex = 25;
            // 
            // tb_TaiKhoan
            // 
            this.tb_TaiKhoan.Location = new System.Drawing.Point(25, 87);
            this.tb_TaiKhoan.Name = "tb_TaiKhoan";
            this.tb_TaiKhoan.Size = new System.Drawing.Size(164, 20);
            this.tb_TaiKhoan.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Tài khoản *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Thêm người thuê ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Địa chỉ";
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Location = new System.Drawing.Point(24, 303);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(336, 20);
            this.tb_DiaChi.TabIndex = 46;
            // 
            // FormThemNguoiThue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 433);
            this.Controls.Add(this.tb_DiaChi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_huy);
            this.Controls.Add(this.btn_ThemNguoiThue);
            this.Controls.Add(this.date_NgaySinh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rB_Nu);
            this.Controls.Add(this.rB_Nam);
            this.Controls.Add(this.tb_SoDienThoai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_CanCuoc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_HoTen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_MatKhau);
            this.Controls.Add(this.tb_TaiKhoan);
            this.Controls.Add(this.label2);
            this.Name = "FormThemNguoiThue";
            this.Text = "FormThemNguoiThue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Tb_SoDienThoai_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Button btn_huy;
        private System.Windows.Forms.Button btn_ThemNguoiThue;
        private System.Windows.Forms.DateTimePicker date_NgaySinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rB_Nu;
        private System.Windows.Forms.RadioButton rB_Nam;
        private System.Windows.Forms.TextBox tb_SoDienThoai;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_CanCuoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_HoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_MatKhau;
        private System.Windows.Forms.TextBox tb_TaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_DiaChi;
    }
}