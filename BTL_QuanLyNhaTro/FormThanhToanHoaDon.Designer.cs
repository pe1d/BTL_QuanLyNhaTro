
namespace BTL_QuanLyNhaTro
{
    partial class FormThanhToanHoaDon
    {
        private System.Windows.Forms.DataGridView dGV_HoaDon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thanhToanToolStripMenuItem;

        private void InitializeComponent()
        {
            this.dGV_HoaDon = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.thanhToanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            // Initialize DataGridView và các thuộc tính của nó
            this.dGV_HoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_HoaDon.Location = new System.Drawing.Point(12, 12);
            this.dGV_HoaDon.Name = "dGV_HoaDon";
            this.dGV_HoaDon.Size = new System.Drawing.Size(760, 450);
            this.dGV_HoaDon.TabIndex = 0;

            // Initialize ContextMenuStrip
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thanhToanToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 26);

            // Initialize ToolStripMenuItem
            this.thanhToanToolStripMenuItem.Name = "thanhToanToolStripMenuItem";
            this.thanhToanToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.thanhToanToolStripMenuItem.Text = "Thanh Toán";
            this.thanhToanToolStripMenuItem.Click += new System.EventHandler(this.ThanhToanToolStripMenuItem_Click);

            // Gán ContextMenuStrip vào DataGridView
            this.dGV_HoaDon.ContextMenuStrip = this.contextMenuStrip1;

            // Thêm DataGridView vào form
            this.Controls.Add(this.dGV_HoaDon);

            // Thiết lập các thuộc tính khác của form
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "FormThanhToanHoaDon";
            this.Text = "Thanh Toán Hóa Đơn";
            this.Load += new System.EventHandler(this.FormThanhToanHoaDon_Load);

            // Finalize và hiển thị các thành phần
            ((System.ComponentModel.ISupportInitialize)(this.dGV_HoaDon)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }


}