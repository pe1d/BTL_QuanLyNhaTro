
namespace BTL_QuanLyNhaTro
{
    partial class FormThuePhongTro
    {
        private System.Windows.Forms.DataGridView dGV_PhongTro; 
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1; 
        private System.Windows.Forms.ToolStripMenuItem thuePhongToolStripMenuItem; 
        private System.Windows.Forms.TextBox tb_GiaMin; 
        private System.Windows.Forms.TextBox tb_GiaMax;
        private System.Windows.Forms.TextBox tb_DienTichMin; 
        private System.Windows.Forms.TextBox tb_DienTichMax; 
        private System.Windows.Forms.TextBox tb_Tang; 
        private System.Windows.Forms.Button btn_Filter;
        private void InitializeComponent()
        {
            // Thiết lập các thuộc tính của điều khiển
            this.dGV_PhongTro = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.thuePhongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_GiaMin = new System.Windows.Forms.TextBox();
            this.tb_GiaMax = new System.Windows.Forms.TextBox();
            this.tb_DienTichMin = new System.Windows.Forms.TextBox();
            this.tb_DienTichMax = new System.Windows.Forms.TextBox();
            this.tb_Tang = new System.Windows.Forms.TextBox();
            this.btn_Filter = new System.Windows.Forms.Button();

            // 
            // dGV_PhongTro
            // 
            this.dGV_PhongTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_PhongTro.Location = new System.Drawing.Point(12, 12);
            this.dGV_PhongTro.Name = "dGV_PhongTro";
            this.dGV_PhongTro.Size = new System.Drawing.Size(760, 450);
            this.dGV_PhongTro.TabIndex = 0;

            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thuePhongToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 26);

            // 
            // thuePhongToolStripMenuItem
            // 
            this.thuePhongToolStripMenuItem.Name = "thuePhongToolStripMenuItem";
            this.thuePhongToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.thuePhongToolStripMenuItem.Text = "Thuê Phòng";
            this.thuePhongToolStripMenuItem.Click += new System.EventHandler(this.ThuePhongToolStripMenuItem_Click);

            // Gán ContextMenuStrip vào DataGridView
            this.dGV_PhongTro.ContextMenuStrip = this.contextMenuStrip1;

            // 
            // tb_GiaMin
            // 
            this.tb_GiaMin.Location = new System.Drawing.Point(12, 480);
            this.tb_GiaMin.Name = "tb_GiaMin";
            this.tb_GiaMin.Size = new System.Drawing.Size(100, 20);
            this.tb_GiaMin.TabIndex = 1;

            // 
            // tb_GiaMax
            // 
            this.tb_GiaMax.Location = new System.Drawing.Point(120, 480);
            this.tb_GiaMax.Name = "tb_GiaMax";
            this.tb_GiaMax.Size = new System.Drawing.Size(100, 20);
            this.tb_GiaMax.TabIndex = 2;

            // 
            // tb_DienTichMin
            // 
            this.tb_DienTichMin.Location = new System.Drawing.Point(230, 480);
            this.tb_DienTichMin.Name = "tb_DienTichMin";
            this.tb_DienTichMin.Size = new System.Drawing.Size(100, 20);
            this.tb_DienTichMin.TabIndex = 3;

            // 
            // tb_DienTichMax
            // 
            this.tb_DienTichMax.Location = new System.Drawing.Point(340, 480);
            this.tb_DienTichMax.Name = "tb_DienTichMax";
            this.tb_DienTichMax.Size = new System.Drawing.Size(100, 20);
            this.tb_DienTichMax.TabIndex = 4;

            // 
            // tb_Tang
            // 
            this.tb_Tang.Location = new System.Drawing.Point(450, 480);
            this.tb_Tang.Name = "tb_Tang";
            this.tb_Tang.Size = new System.Drawing.Size(100, 20);
            this.tb_Tang.TabIndex = 5;

            // 
            // btn_Filter
            // 
            this.btn_Filter.Location = new System.Drawing.Point(560, 480);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.Size = new System.Drawing.Size(75, 23);
            this.btn_Filter.TabIndex = 6;
            this.btn_Filter.Text = "Lọc";
            this.btn_Filter.UseVisualStyleBackColor = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);

            // Thêm các điều khiển vào form
            this.Controls.Add(this.dGV_PhongTro);
            this.Controls.Add(this.tb_GiaMin);
            this.Controls.Add(this.tb_GiaMax);
            this.Controls.Add(this.tb_DienTichMin);
            this.Controls.Add(this.tb_DienTichMax);
            this.Controls.Add(this.tb_Tang);
            this.Controls.Add(this.btn_Filter);

            // Thiết lập các thuộc tính form
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "FormThuePhongTro";
            this.Text = "Thuê Phòng Trọ";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
     
}