
namespace BTL_QuanLyNhaTro
{
    partial class FormXemChiTietHoaDon
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_NguoiLap = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tB_Phong = new System.Windows.Forms.TextBox();
            this.tB_khachThue = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.tB_tongTien = new System.Windows.Forms.TextBox();
            this.tB_giaPhong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dTP_Han = new System.Windows.Forms.DateTimePicker();
            this.dTP_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.cB_TrangThai = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuaDichVuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Người lập:";
            // 
            // lb_NguoiLap
            // 
            this.lb_NguoiLap.AutoSize = true;
            this.lb_NguoiLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NguoiLap.Location = new System.Drawing.Point(113, 41);
            this.lb_NguoiLap.Name = "lb_NguoiLap";
            this.lb_NguoiLap.Size = new System.Drawing.Size(28, 13);
            this.lb_NguoiLap.TabIndex = 2;
            this.lb_NguoiLap.Text = "abc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày lập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày hết hạn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Khách thuê:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Trạng thái:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 18);
            this.label8.TabIndex = 8;
            this.label8.Text = "Danh sách dịch vụ:";
            // 
            // tB_Phong
            // 
            this.tB_Phong.Enabled = false;
            this.tB_Phong.Location = new System.Drawing.Point(116, 113);
            this.tB_Phong.Name = "tB_Phong";
            this.tB_Phong.Size = new System.Drawing.Size(218, 20);
            this.tB_Phong.TabIndex = 11;
            // 
            // tB_khachThue
            // 
            this.tB_khachThue.Enabled = false;
            this.tB_khachThue.Location = new System.Drawing.Point(116, 139);
            this.tB_khachThue.Name = "tB_khachThue";
            this.tB_khachThue.Size = new System.Drawing.Size(218, 20);
            this.tB_khachThue.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 252);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 150);
            this.dataGridView1.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Tổng tiền:";
            // 
            // tB_tongTien
            // 
            this.tB_tongTien.Enabled = false;
            this.tB_tongTien.Location = new System.Drawing.Point(103, 411);
            this.tB_tongTien.Name = "tB_tongTien";
            this.tB_tongTien.Size = new System.Drawing.Size(100, 20);
            this.tB_tongTien.TabIndex = 21;
            // 
            // tB_giaPhong
            // 
            this.tB_giaPhong.Enabled = false;
            this.tB_giaPhong.Location = new System.Drawing.Point(116, 165);
            this.tB_giaPhong.Name = "tB_giaPhong";
            this.tB_giaPhong.Size = new System.Drawing.Size(218, 20);
            this.tB_giaPhong.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(57, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Giá phòng:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(45, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Chỉnh sửa";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(45, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dTP_Han
            // 
            this.dTP_Han.Enabled = false;
            this.dTP_Han.Location = new System.Drawing.Point(116, 87);
            this.dTP_Han.Name = "dTP_Han";
            this.dTP_Han.Size = new System.Drawing.Size(218, 20);
            this.dTP_Han.TabIndex = 26;
            // 
            // dTP_NgayLap
            // 
            this.dTP_NgayLap.Enabled = false;
            this.dTP_NgayLap.Location = new System.Drawing.Point(116, 61);
            this.dTP_NgayLap.Name = "dTP_NgayLap";
            this.dTP_NgayLap.Size = new System.Drawing.Size(218, 20);
            this.dTP_NgayLap.TabIndex = 27;
            // 
            // cB_TrangThai
            // 
            this.cB_TrangThai.Enabled = false;
            this.cB_TrangThai.FormattingEnabled = true;
            this.cB_TrangThai.Location = new System.Drawing.Point(116, 192);
            this.cB_TrangThai.Name = "cB_TrangThai";
            this.cB_TrangThai.Size = new System.Drawing.Size(218, 21);
            this.cB_TrangThai.TabIndex = 28;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SuaDichVuToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(94, 26);
            // 
            // SuaDichVuToolStripMenuItem
            // 
            this.SuaDichVuToolStripMenuItem.Name = "SuaDichVuToolStripMenuItem";
            this.SuaDichVuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SuaDichVuToolStripMenuItem.Text = "Sửa";
            this.SuaDichVuToolStripMenuItem.Click += new System.EventHandler(this.SuaDichVuToolStripMenuItem_Click);
            // 
            // FormXemChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 474);
            this.Controls.Add(this.cB_TrangThai);
            this.Controls.Add(this.dTP_NgayLap);
            this.Controls.Add(this.dTP_Han);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tB_giaPhong);
            this.Controls.Add(this.tB_tongTien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tB_khachThue);
            this.Controls.Add(this.tB_Phong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_NguoiLap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormXemChiTietHoaDon";
            this.Text = "FormXemChiTietHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_NguoiLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tB_Phong;
        private System.Windows.Forms.TextBox tB_khachThue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tB_tongTien;
        private System.Windows.Forms.TextBox tB_giaPhong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dTP_Han;
        private System.Windows.Forms.DateTimePicker dTP_NgayLap;
        private System.Windows.Forms.ComboBox cB_TrangThai;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SuaDichVuToolStripMenuItem;
    }
}