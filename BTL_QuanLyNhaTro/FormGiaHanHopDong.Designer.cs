
namespace BTL_QuanLyNhaTro
{
    partial class FormGiaHanHopDong
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
            this.date_NgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.date_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cB_GiaHan = new System.Windows.Forms.ComboBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_XacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gia hạn hợp đồng";
            // 
            // date_NgayBatDau
            // 
            this.date_NgayBatDau.Enabled = false;
            this.date_NgayBatDau.Location = new System.Drawing.Point(49, 55);
            this.date_NgayBatDau.Name = "date_NgayBatDau";
            this.date_NgayBatDau.Size = new System.Drawing.Size(200, 20);
            this.date_NgayBatDau.TabIndex = 1;
            // 
            // date_NgayKetThuc
            // 
            this.date_NgayKetThuc.Enabled = false;
            this.date_NgayKetThuc.Location = new System.Drawing.Point(49, 94);
            this.date_NgayKetThuc.Name = "date_NgayKetThuc";
            this.date_NgayKetThuc.Size = new System.Drawing.Size(200, 20);
            this.date_NgayKetThuc.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày bắt đầu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày kết thúc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Thời gian thêm";
            // 
            // cB_GiaHan
            // 
            this.cB_GiaHan.FormattingEnabled = true;
            this.cB_GiaHan.Location = new System.Drawing.Point(49, 137);
            this.cB_GiaHan.Name = "cB_GiaHan";
            this.cB_GiaHan.Size = new System.Drawing.Size(200, 21);
            this.cB_GiaHan.TabIndex = 6;
            // 
            // btn_Huy
            // 
            this.btn_Huy.Location = new System.Drawing.Point(49, 183);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 7;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_XacNhan
            // 
            this.btn_XacNhan.Location = new System.Drawing.Point(130, 183);
            this.btn_XacNhan.Name = "btn_XacNhan";
            this.btn_XacNhan.Size = new System.Drawing.Size(75, 23);
            this.btn_XacNhan.TabIndex = 8;
            this.btn_XacNhan.Text = "Gia hạn";
            this.btn_XacNhan.UseVisualStyleBackColor = true;
            this.btn_XacNhan.Click += new System.EventHandler(this.btn_XacNhan_Click);
            // 
            // FormGiaHanHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 236);
            this.Controls.Add(this.btn_XacNhan);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.cB_GiaHan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date_NgayKetThuc);
            this.Controls.Add(this.date_NgayBatDau);
            this.Controls.Add(this.label1);
            this.Name = "FormGiaHanHopDong";
            this.Text = "FormGiaHanHopDong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_NgayBatDau;
        private System.Windows.Forms.DateTimePicker date_NgayKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cB_GiaHan;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_XacNhan;
    }
}