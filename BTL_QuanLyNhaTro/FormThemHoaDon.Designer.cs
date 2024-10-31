
namespace BTL_QuanLyNhaTro
{
    partial class FormThemHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Phong = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Khach = new System.Windows.Forms.TextBox();
            this.dtP_from = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtP_to = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_NguoiLap = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_GiaPhong = new System.Windows.Forms.TextBox();
            this.btn_addSerHD = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_addHoaDon = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tB_tongTien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm hóa đơn";
            // 
            // cb_Phong
            // 
            this.cb_Phong.FormattingEnabled = true;
            this.cb_Phong.Location = new System.Drawing.Point(415, 71);
            this.cb_Phong.Name = "cb_Phong";
            this.cb_Phong.Size = new System.Drawing.Size(111, 21);
            this.cb_Phong.TabIndex = 2;
            this.cb_Phong.SelectedIndexChanged += new System.EventHandler(this.cb_Phong_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phòng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên khách thuê:";
            // 
            // tb_Khach
            // 
            this.tb_Khach.Location = new System.Drawing.Point(151, 107);
            this.tb_Khach.Name = "tb_Khach";
            this.tb_Khach.Size = new System.Drawing.Size(190, 20);
            this.tb_Khach.TabIndex = 5;
            // 
            // dtP_from
            // 
            this.dtP_from.Enabled = false;
            this.dtP_from.Location = new System.Drawing.Point(151, 136);
            this.dtP_from.Name = "dtP_from";
            this.dtP_from.Size = new System.Drawing.Size(190, 20);
            this.dtP_from.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày lập:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hạn:";
            // 
            // dtP_to
            // 
            this.dtP_to.Location = new System.Drawing.Point(151, 169);
            this.dtP_to.Name = "dtP_to";
            this.dtP_to.Size = new System.Drawing.Size(190, 20);
            this.dtP_to.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Người lập:";
            // 
            // tb_NguoiLap
            // 
            this.tb_NguoiLap.Location = new System.Drawing.Point(151, 72);
            this.tb_NguoiLap.Name = "tb_NguoiLap";
            this.tb_NguoiLap.Size = new System.Drawing.Size(190, 20);
            this.tb_NguoiLap.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Giá phòng:";
            // 
            // tb_GiaPhong
            // 
            this.tb_GiaPhong.Location = new System.Drawing.Point(415, 107);
            this.tb_GiaPhong.Name = "tb_GiaPhong";
            this.tb_GiaPhong.Size = new System.Drawing.Size(111, 20);
            this.tb_GiaPhong.TabIndex = 14;
            // 
            // btn_addSerHD
            // 
            this.btn_addSerHD.Location = new System.Drawing.Point(62, 198);
            this.btn_addSerHD.Name = "btn_addSerHD";
            this.btn_addSerHD.Size = new System.Drawing.Size(93, 23);
            this.btn_addSerHD.TabIndex = 15;
            this.btn_addSerHD.Text = "+ Thêm dịch vụ";
            this.btn_addSerHD.UseVisualStyleBackColor = true;
            this.btn_addSerHD.Click += new System.EventHandler(this.addSerHD_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Thành tiền:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 229);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Số lượng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(62, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Dịch vụ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(289, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Đơn vị";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(189, 228);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Đơn giá";
            // 
            // btn_addHoaDon
            // 
            this.btn_addHoaDon.Location = new System.Drawing.Point(62, 274);
            this.btn_addHoaDon.Name = "btn_addHoaDon";
            this.btn_addHoaDon.Size = new System.Drawing.Size(90, 23);
            this.btn_addHoaDon.TabIndex = 26;
            this.btn_addHoaDon.Text = "Thêm hóa đơn";
            this.btn_addHoaDon.UseVisualStyleBackColor = true;
            this.btn_addHoaDon.Click += new System.EventHandler(this.btn_addHoaDon_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(354, 143);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Tổng tiền:";
            // 
            // tB_tongTien
            // 
            this.tB_tongTien.Enabled = false;
            this.tB_tongTien.Location = new System.Drawing.Point(415, 140);
            this.tB_tongTien.Name = "tB_tongTien";
            this.tB_tongTien.Size = new System.Drawing.Size(110, 20);
            this.tB_tongTien.TabIndex = 28;
            // 
            // FormThemHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 351);
            this.Controls.Add(this.tB_tongTien);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btn_addHoaDon);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_addSerHD);
            this.Controls.Add(this.tb_GiaPhong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_NguoiLap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtP_to);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtP_from);
            this.Controls.Add(this.tb_Khach);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Phong);
            this.Controls.Add(this.label1);
            this.Name = "FormThemHoaDon";
            this.Text = "Thêm hóa đơn";
            this.Load += new System.EventHandler(this.FormThemHoaDon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Phong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Khach;
        private System.Windows.Forms.DateTimePicker dtP_from;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtP_to;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_NguoiLap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_GiaPhong;
        private System.Windows.Forms.Button btn_addSerHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_addHoaDon;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tB_tongTien;
    }
}