﻿namespace BTL_QuanLyNhaTro
{
    partial class FormSuaHoaDon
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_GiaPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_NguoiLap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtP_to = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtP_from = new System.Windows.Forms.DateTimePicker();
            this.tb_Khach = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Phong = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sửa hóa đơn";
            // 
            // tb_GiaPhong
            // 
            this.tb_GiaPhong.Location = new System.Drawing.Point(412, 118);
            this.tb_GiaPhong.Name = "tb_GiaPhong";
            this.tb_GiaPhong.Size = new System.Drawing.Size(111, 20);
            this.tb_GiaPhong.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(347, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Giá phòng:";
            // 
            // tb_NguoiLap
            // 
            this.tb_NguoiLap.Location = new System.Drawing.Point(148, 83);
            this.tb_NguoiLap.Name = "tb_NguoiLap";
            this.tb_NguoiLap.Size = new System.Drawing.Size(190, 20);
            this.tb_NguoiLap.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Người lập:";
            // 
            // dtP_to
            // 
            this.dtP_to.Location = new System.Drawing.Point(148, 180);
            this.dtP_to.Name = "dtP_to";
            this.dtP_to.Size = new System.Drawing.Size(190, 20);
            this.dtP_to.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Hạn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Ngày lập:";
            // 
            // dtP_from
            // 
            this.dtP_from.Location = new System.Drawing.Point(148, 147);
            this.dtP_from.Name = "dtP_from";
            this.dtP_from.Size = new System.Drawing.Size(190, 20);
            this.dtP_from.TabIndex = 19;
            // 
            // tb_Khach
            // 
            this.tb_Khach.Location = new System.Drawing.Point(148, 118);
            this.tb_Khach.Name = "tb_Khach";
            this.tb_Khach.Size = new System.Drawing.Size(190, 20);
            this.tb_Khach.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên khách thuê:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Phòng:";
            // 
            // cb_Phong
            // 
            this.cb_Phong.FormattingEnabled = true;
            this.cb_Phong.Location = new System.Drawing.Point(412, 82);
            this.cb_Phong.Name = "cb_Phong";
            this.cb_Phong.Size = new System.Drawing.Size(111, 21);
            this.cb_Phong.TabIndex = 15;
            // 
            // FormSuaHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_Phong);
            this.Controls.Add(this.label2);
            this.Name = "FormSuaHoaDon";
            this.Text = "FormSuaHoaDon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_GiaPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_NguoiLap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtP_to;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtP_from;
        private System.Windows.Forms.TextBox tb_Khach;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Phong;
    }
}