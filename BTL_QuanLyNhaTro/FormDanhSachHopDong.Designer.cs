
namespace BTL_QuanLyNhaTro
{
    partial class FormDanhSachHopDong
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
            this.label3 = new System.Windows.Forms.Label();
            this.cB_ChuTro = new System.Windows.Forms.ComboBox();
            this.cB_NguoiThue = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.date_NgayHetHanFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.date_NgayHetHanTo = new System.Windows.Forms.DateTimePicker();
            this.ChB_HpDongHetHan = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tB_GiaTriHopDongFrom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tB_GiaTriHopDongTo = new System.Windows.Forms.TextBox();
            this.chB_All = new System.Windows.Forms.CheckBox();
            this.btn_Loc = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách hợp đồng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chủ trọ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Người thuê";
            // 
            // cB_ChuTro
            // 
            this.cB_ChuTro.FormattingEnabled = true;
            this.cB_ChuTro.Location = new System.Drawing.Point(98, 75);
            this.cB_ChuTro.Name = "cB_ChuTro";
            this.cB_ChuTro.Size = new System.Drawing.Size(151, 21);
            this.cB_ChuTro.TabIndex = 3;
            // 
            // cB_NguoiThue
            // 
            this.cB_NguoiThue.FormattingEnabled = true;
            this.cB_NguoiThue.Location = new System.Drawing.Point(255, 75);
            this.cB_NguoiThue.Name = "cB_NguoiThue";
            this.cB_NguoiThue.Size = new System.Drawing.Size(121, 21);
            this.cB_NguoiThue.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(98, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(595, 221);
            this.dataGridView1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ngày hết hạn";
            // 
            // date_NgayHetHanFrom
            // 
            this.date_NgayHetHanFrom.Location = new System.Drawing.Point(120, 120);
            this.date_NgayHetHanFrom.Name = "date_NgayHetHanFrom";
            this.date_NgayHetHanFrom.Size = new System.Drawing.Size(200, 20);
            this.date_NgayHetHanFrom.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "từ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "đến";
            // 
            // date_NgayHetHanTo
            // 
            this.date_NgayHetHanTo.Location = new System.Drawing.Point(358, 120);
            this.date_NgayHetHanTo.Name = "date_NgayHetHanTo";
            this.date_NgayHetHanTo.Size = new System.Drawing.Size(200, 20);
            this.date_NgayHetHanTo.TabIndex = 10;
            // 
            // ChB_HpDongHetHan
            // 
            this.ChB_HpDongHetHan.AutoSize = true;
            this.ChB_HpDongHetHan.Location = new System.Drawing.Point(564, 122);
            this.ChB_HpDongHetHan.Name = "ChB_HpDongHetHan";
            this.ChB_HpDongHetHan.Size = new System.Drawing.Size(129, 17);
            this.ChB_HpDongHetHan.TabIndex = 11;
            this.ChB_HpDongHetHan.Text = "Hợp đồng đã hết hạn";
            this.ChB_HpDongHetHan.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(95, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Giá trị hợp đồng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "từ";
            // 
            // tB_GiaTriHopDongFrom
            // 
            this.tB_GiaTriHopDongFrom.Location = new System.Drawing.Point(120, 171);
            this.tB_GiaTriHopDongFrom.Name = "tB_GiaTriHopDongFrom";
            this.tB_GiaTriHopDongFrom.Size = new System.Drawing.Size(200, 20);
            this.tB_GiaTriHopDongFrom.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(326, 174);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "đến";
            // 
            // tB_GiaTriHopDongTo
            // 
            this.tB_GiaTriHopDongTo.Location = new System.Drawing.Point(358, 171);
            this.tB_GiaTriHopDongTo.Name = "tB_GiaTriHopDongTo";
            this.tB_GiaTriHopDongTo.Size = new System.Drawing.Size(200, 20);
            this.tB_GiaTriHopDongTo.TabIndex = 16;
            // 
            // chB_All
            // 
            this.chB_All.AutoSize = true;
            this.chB_All.Location = new System.Drawing.Point(98, 197);
            this.chB_All.Name = "chB_All";
            this.chB_All.Size = new System.Drawing.Size(106, 17);
            this.chB_All.TabIndex = 17;
            this.chB_All.Text = "Tất cả hợp đồng";
            this.chB_All.UseVisualStyleBackColor = true;
            // 
            // btn_Loc
            // 
            this.btn_Loc.Location = new System.Drawing.Point(98, 220);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(75, 23);
            this.btn_Loc.TabIndex = 18;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(95, 48);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.sửaToolStripMenuItem.Text = "Sửa";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // FormDanhSachHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 490);
            this.Controls.Add(this.btn_Loc);
            this.Controls.Add(this.chB_All);
            this.Controls.Add(this.tB_GiaTriHopDongTo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tB_GiaTriHopDongFrom);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ChB_HpDongHetHan);
            this.Controls.Add(this.date_NgayHetHanTo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.date_NgayHetHanFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cB_NguoiThue);
            this.Controls.Add(this.cB_ChuTro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDanhSachHopDong";
            this.Text = "FormDanhSachHopDong";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cB_ChuTro;
        private System.Windows.Forms.ComboBox cB_NguoiThue;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker date_NgayHetHanFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker date_NgayHetHanTo;
        private System.Windows.Forms.CheckBox ChB_HpDongHetHan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tB_GiaTriHopDongFrom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tB_GiaTriHopDongTo;
        private System.Windows.Forms.CheckBox chB_All;
        private System.Windows.Forms.Button btn_Loc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
    }
}