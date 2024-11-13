
namespace BTL_QuanLyNhaTro
{
    partial class FormBaoCaoDoanhThu
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbChuTro = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cB_Thang = new System.Windows.Forms.ComboBox();
            this.cB_Nam = new System.Windows.Forms.ComboBox();
            this.btn_BaoCao = new System.Windows.Forms.Button();
            this.chB_All = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo cáo doanh thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chủ trọ";
            // 
            // cbChuTro
            // 
            this.cbChuTro.FormattingEnabled = true;
            this.cbChuTro.Location = new System.Drawing.Point(27, 65);
            this.cbChuTro.Name = "cbChuTro";
            this.cbChuTro.Size = new System.Drawing.Size(250, 21);
            this.cbChuTro.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Năm";
            // 
            // cB_Thang
            // 
            this.cB_Thang.FormattingEnabled = true;
            this.cB_Thang.Location = new System.Drawing.Point(27, 110);
            this.cB_Thang.Name = "cB_Thang";
            this.cB_Thang.Size = new System.Drawing.Size(121, 21);
            this.cB_Thang.TabIndex = 5;
            // 
            // cB_Nam
            // 
            this.cB_Nam.FormattingEnabled = true;
            this.cB_Nam.Location = new System.Drawing.Point(156, 109);
            this.cB_Nam.Name = "cB_Nam";
            this.cB_Nam.Size = new System.Drawing.Size(121, 21);
            this.cB_Nam.TabIndex = 6;
            // 
            // btn_BaoCao
            // 
            this.btn_BaoCao.Location = new System.Drawing.Point(27, 157);
            this.btn_BaoCao.Name = "btn_BaoCao";
            this.btn_BaoCao.Size = new System.Drawing.Size(75, 23);
            this.btn_BaoCao.TabIndex = 7;
            this.btn_BaoCao.Text = "Báo cáo";
            this.btn_BaoCao.UseVisualStyleBackColor = true;
            this.btn_BaoCao.Click += new System.EventHandler(this.btn_BaoCao_Click);
            // 
            // chB_All
            // 
            this.chB_All.AutoSize = true;
            this.chB_All.Location = new System.Drawing.Point(27, 138);
            this.chB_All.Name = "chB_All";
            this.chB_All.Size = new System.Drawing.Size(57, 17);
            this.chB_All.TabIndex = 8;
            this.chB_All.Text = "Tất cả";
            this.chB_All.UseVisualStyleBackColor = true;
            this.chB_All.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormBaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 192);
            this.Controls.Add(this.chB_All);
            this.Controls.Add(this.btn_BaoCao);
            this.Controls.Add(this.cB_Nam);
            this.Controls.Add(this.cB_Thang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbChuTro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormBaoCaoDoanhThu";
            this.Text = "FormBaoCaoDoanhThu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbChuTro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cB_Thang;
        private System.Windows.Forms.ComboBox cB_Nam;
        private System.Windows.Forms.Button btn_BaoCao;
        private System.Windows.Forms.CheckBox chB_All;
    }
}