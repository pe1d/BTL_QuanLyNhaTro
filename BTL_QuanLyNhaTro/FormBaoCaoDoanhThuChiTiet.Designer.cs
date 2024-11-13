
namespace BTL_QuanLyNhaTro
{
    partial class FormBaoCaoDoanhThuChiTiet
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
            this.dGV_DanhSachHoaDon = new System.Windows.Forms.DataGridView();
            this.lb_title = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_Tong = new System.Windows.Forms.TextBox();
            this.btn_Print = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DanhSachHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // dGV_DanhSachHoaDon
            // 
            this.dGV_DanhSachHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_DanhSachHoaDon.Location = new System.Drawing.Point(43, 71);
            this.dGV_DanhSachHoaDon.Name = "dGV_DanhSachHoaDon";
            this.dGV_DanhSachHoaDon.Size = new System.Drawing.Size(723, 215);
            this.dGV_DanhSachHoaDon.TabIndex = 0;
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(39, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(253, 24);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "Báo cáo doanh thu chi tiết";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng doanh thu:";
            // 
            // tb_Tong
            // 
            this.tb_Tong.Location = new System.Drawing.Point(132, 45);
            this.tb_Tong.Name = "tb_Tong";
            this.tb_Tong.Size = new System.Drawing.Size(117, 20);
            this.tb_Tong.TabIndex = 3;
            // 
            // btn_Print
            // 
            this.btn_Print.Location = new System.Drawing.Point(43, 293);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(75, 23);
            this.btn_Print.TabIndex = 4;
            this.btn_Print.Text = "In";
            this.btn_Print.UseVisualStyleBackColor = true;
            // 
            // FormBaoCaoDoanhThuChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.tb_Tong);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_title);
            this.Controls.Add(this.dGV_DanhSachHoaDon);
            this.Name = "FormBaoCaoDoanhThuChiTiet";
            this.Text = "FormBaoCaoDoanhThuChiTiet";
            ((System.ComponentModel.ISupportInitialize)(this.dGV_DanhSachHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGV_DanhSachHoaDon;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_Tong;
        private System.Windows.Forms.Button btn_Print;
    }
}