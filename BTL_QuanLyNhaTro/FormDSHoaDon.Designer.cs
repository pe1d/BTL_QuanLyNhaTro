
namespace BTL_QuanLyNhaTro
{
    partial class FormDSHoaDon
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
            this.dGV_dsHoaDon = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tB_TongTienMin = new System.Windows.Forms.TextBox();
            this.tB_TongTienMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cB_Thang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cB_Nam = new System.Windows.Forms.ComboBox();
            this.cB_Phong = new System.Windows.Forms.ComboBox();
            this.txt_TenNguoiThue = new System.Windows.Forms.TextBox();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.contextMenuStripDSHoaDon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemChiTietToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_dsHoaDon)).BeginInit();
            this.contextMenuStripDSHoaDon.SuspendLayout();
            this.SuspendLayout();
            // 
            // dGV_dsHoaDon
            // 
            this.dGV_dsHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_dsHoaDon.Location = new System.Drawing.Point(57, 199);
            this.dGV_dsHoaDon.Name = "dGV_dsHoaDon";
            this.dGV_dsHoaDon.Size = new System.Drawing.Size(835, 262);
            this.dGV_dsHoaDon.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng tiền:";
            // 
            // tB_TongTienMin
            // 
            this.tB_TongTienMin.Location = new System.Drawing.Point(160, 46);
            this.tB_TongTienMin.Name = "tB_TongTienMin";
            this.tB_TongTienMin.Size = new System.Drawing.Size(100, 20);
            this.tB_TongTienMin.TabIndex = 2;
            this.tB_TongTienMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_TongTien_KeyPress);
            // 
            // tB_TongTienMax
            // 
            this.tB_TongTienMax.Location = new System.Drawing.Point(302, 46);
            this.tB_TongTienMax.Name = "tB_TongTienMax";
            this.tB_TongTienMax.Size = new System.Drawing.Size(100, 20);
            this.tB_TongTienMax.TabIndex = 3;
            this.tB_TongTienMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_TongTien_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "từ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phòng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tên người thuê";
            // 
            // cB_Thang
            // 
            this.cB_Thang.FormattingEnabled = true;
            this.cB_Thang.Location = new System.Drawing.Point(139, 72);
            this.cB_Thang.Name = "cB_Thang";
            this.cB_Thang.Size = new System.Drawing.Size(121, 21);
            this.cB_Thang.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tháng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Năm:";
            // 
            // cB_Nam
            // 
            this.cB_Nam.FormattingEnabled = true;
            this.cB_Nam.Location = new System.Drawing.Point(302, 72);
            this.cB_Nam.Name = "cB_Nam";
            this.cB_Nam.Size = new System.Drawing.Size(100, 21);
            this.cB_Nam.TabIndex = 13;
            // 
            // cB_Phong
            // 
            this.cB_Phong.FormattingEnabled = true;
            this.cB_Phong.Location = new System.Drawing.Point(139, 103);
            this.cB_Phong.Name = "cB_Phong";
            this.cB_Phong.Size = new System.Drawing.Size(121, 21);
            this.cB_Phong.TabIndex = 14;
            this.cB_Phong.SelectedIndexChanged += new System.EventHandler(this.cB_Phong_SelectedIndexChanged);
            // 
            // txt_TenNguoiThue
            // 
            this.txt_TenNguoiThue.Enabled = false;
            this.txt_TenNguoiThue.Location = new System.Drawing.Point(139, 130);
            this.txt_TenNguoiThue.Name = "txt_TenNguoiThue";
            this.txt_TenNguoiThue.Size = new System.Drawing.Size(263, 20);
            this.txt_TenNguoiThue.TabIndex = 15;
            // 
            // btn_Loc
            // 
            this.btn_Loc.Location = new System.Drawing.Point(57, 159);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(75, 23);
            this.btn_Loc.TabIndex = 16;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.UseVisualStyleBackColor = true;
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // contextMenuStripDSHoaDon
            // 
            this.contextMenuStripDSHoaDon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemChiTietToolStripMenuItem,
            this.xoaToolStripMenuItem});
            this.contextMenuStripDSHoaDon.Name = "contextMenuStripDSHoaDon";
            this.contextMenuStripDSHoaDon.Size = new System.Drawing.Size(162, 48);
            // 
            // xemChiTietToolStripMenuItem
            // 
            this.xemChiTietToolStripMenuItem.Name = "xemChiTietToolStripMenuItem";
            this.xemChiTietToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.xemChiTietToolStripMenuItem.Text = "Xem chi tiết, sửa";
            this.xemChiTietToolStripMenuItem.Click += new System.EventHandler(this.xemChiTietToolStripMenuItem_Click);
            // 
            // xoaToolStripMenuItem
            // 
            this.xoaToolStripMenuItem.Name = "xoaToolStripMenuItem";
            this.xoaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xoaToolStripMenuItem.Text = "Xóa";
            this.xoaToolStripMenuItem.Click += new System.EventHandler(this.xoaToolStripMenuItem_Click);
            // 
            // FormDSHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 486);
            this.Controls.Add(this.btn_Loc);
            this.Controls.Add(this.txt_TenNguoiThue);
            this.Controls.Add(this.cB_Phong);
            this.Controls.Add(this.cB_Nam);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cB_Thang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tB_TongTienMax);
            this.Controls.Add(this.tB_TongTienMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGV_dsHoaDon);
            this.Name = "FormDSHoaDon";
            this.Text = "Danh sách hóa đơn";
            this.Load += new System.EventHandler(this.FormDSHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_dsHoaDon)).EndInit();
            this.contextMenuStripDSHoaDon.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_dsHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tB_TongTienMin;
        private System.Windows.Forms.TextBox tB_TongTienMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cB_Thang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cB_Nam;
        private System.Windows.Forms.ComboBox cB_Phong;
        private System.Windows.Forms.TextBox txt_TenNguoiThue;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDSHoaDon;
        private System.Windows.Forms.ToolStripMenuItem xemChiTietToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaToolStripMenuItem;
    }
}