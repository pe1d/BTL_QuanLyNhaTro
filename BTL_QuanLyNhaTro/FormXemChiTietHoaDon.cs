using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BTL_QuanLyNhaTro.AuthenticationService;
using static BTL_QuanLyNhaTro.FunctionAll;

namespace BTL_QuanLyNhaTro
{
    public partial class FormXemChiTietHoaDon : Form
    {
        private string maHoaDon;
        public FormXemChiTietHoaDon(string maHoaDon)
        {
            InitializeComponent();
            this.maHoaDon = maHoaDon;
            AutoResizeDataGridView(dataGridView1);
            LoadHoaDonDetails();
            LoadDichVuList();
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.CellMouseDown += dataGridView_CellMouseDown;
            dataGridView1.Enabled = false;
        }
        private void LoadHoaDonDetails()
        {
            string query1 = @"
            SELECT hd.NguoiLap, hd.NgayLapHoaDon, hd.HanHoaDon, hd.SoTienThanhToan,hd.MaPhong,
                   p.TenPhong,p.GiaThue, tthd.TenTrangThai
            FROM HoaDon hd
            JOIN Phong p ON hd.MaPhong = p.MaPhong
            JOIN TrangThaiHoaDon tthd ON hd.MaTrangThaiHoaDon = tthd.MaTrangThai
            WHERE hd.MaHoaDon = @MaHoaDon";
            SqlCommand query = new SqlCommand(query1);
            query.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
            DataTable dt = GetData(query);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                lb_NguoiLap.Text = row["NguoiLap"].ToString();
                dTP_NgayLap.Value = Convert.ToDateTime(row["NgayLapHoaDon"]);
                dTP_Han.Value = Convert.ToDateTime(row["HanHoaDon"]);
                tB_Phong.Text = row["TenPhong"].ToString();
                tB_giaPhong.Text = row["GiaThue"].ToString(); ;
                tB_tongTien.Text = row["SoTienThanhToan"].ToString();
                cB_TrangThai.Text = row["TenTrangThai"].ToString(); // Có thể join để lấy tên trạng thái
                setTenKhachThue(row["MaPhong"].ToString());
            }
        }
        private void setTenKhachThue(string maPhong)
        {
            SqlCommand cmdSPhongKT = new SqlCommand(@"select * from HopDong 
                                    inner join NguoiThue ON NguoiThue.MaNguoiThue = HopDong.MaNguoiThue
                                    where HopDong.MaPhong = '" + maPhong + "'");
            DataTable dt = GetData(cmdSPhongKT);
            if (HasData(dt))
            {
                DataRow dr = dt.Rows[0];
                if (dr["HoTen"].ToString() != null)
                {
                    tB_khachThue.Text = dr["HoTen"].ToString();
                }
                else
                {
                    MessageBox.Show("Có 1 vài lỗi xảy ra");
                }
            }
        }
        private void LoadDichVuList()
        {
            string query = @"
            SELECT hd_dv.MaHoaDonDichVu, dv.MaDichVu, dv.TenDichVu, dv.DonGia, hd_dv.SoLuong, dv.DonVi, hd_dv.ThanhTien
            FROM HoaDon_DichVu hd_dv
            INNER JOIN DichVu dv ON hd_dv.MaDichVu = dv.MaDichVu
            WHERE hd_dv.MaHoaDon = @MaHoaDon";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MaHoaDon", maHoaDon);
            DataTable dt = GetData(cmd);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["MaHoaDonDichVu"].Visible = false;
            dataGridView1.Columns["MaDichVu"].Visible = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("Select * from TrangThaiHoaDon");
            dTP_Han.Enabled = checkBox1.Checked;
            button1.Enabled = checkBox1.Checked;
            tB_giaPhong.Enabled = checkBox1.Checked;
            cB_TrangThai.Enabled = checkBox1.Checked;
            dataGridView1.Enabled = checkBox1.Checked;
            if (checkBox1.Checked == true)
            {
                LoadDataToComboBox(query, cB_TrangThai);
            }
        }

        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 )
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                // Chỉ đặt CurrentCell nếu cột đầu tiên không bị ẩn
                foreach (DataGridViewCell cell in dataGridView1.Rows[e.RowIndex].Cells)
                {
                    if (cell.Visible)
                    {
                        dataGridView1.CurrentCell = cell; // Chọn một ô hiện không bị ẩn
                        break;
                    }
                }
            }
        }

        private void SuaDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.CurrentRow.Index;
            var maHoaDonDV = dataGridView1.Rows[selectedRowIndex].Cells["MaHoaDonDichVu"].Value.ToString();
            MessageBox.Show("sửa hóa đơn dịch vụ: " + maHoaDonDV);
        }
    }
}
