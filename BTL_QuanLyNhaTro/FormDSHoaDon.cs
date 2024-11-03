using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static BTL_QuanLyNhaTro.AuthenticationService;
using static BTL_QuanLyNhaTro.FunctionAll;

namespace BTL_QuanLyNhaTro
{
    public partial class FormDSHoaDon : Form
    {
        private SqlCommand cmdSPhongAll = new SqlCommand("Select * from Phong where MaTrangThai = '3'");
        //private SqlCommand cmdSNguoiLapAll = new SqlCommand("select [MaChuTro], [TenChuTro] from ChuTro");
        public FormDSHoaDon()
        {
            InitializeComponent();
            AutoResizeDataGridView(dGV_dsHoaDon);
            dGV_dsHoaDon.ContextMenuStrip = contextMenuStripDSHoaDon;
            dGV_dsHoaDon.CellMouseDown += dataGridView_CellMouseDown;
        }
        private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dGV_dsHoaDon.ClearSelection();
                dGV_dsHoaDon.Rows[e.RowIndex].Selected = true;
                dGV_dsHoaDon.CurrentCell = dGV_dsHoaDon.Rows[e.RowIndex].Cells[0];
            }
        }
        private void FormDSHoaDon_Load(object sender, EventArgs e)
        {
            PopulateMonthsComboBox();
            PopulateYearsComboBox();
            if (User.RoleID == 3)
            {
                LoadDataToComboBox(cmdSPhongAll, cB_Phong);
            }
        }

        private void cB_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SqlCommand cmdSPhongKT = new SqlCommand(@"select * from HopDong 
                                    inner join NguoiThue ON NguoiThue.MaNguoiThue = HopDong.MaNguoiThue
                                    where HopDong.MaPhong = '" + cb.SelectedValue + "'");
            DataTable dt = GetData(cmdSPhongKT);
            if (HasData(dt))
            {
                DataRow dr = dt.Rows[0];
                if (dr["HoTen"].ToString() != null)
                {
                    txt_TenNguoiThue.Text = dr["HoTen"].ToString();
                }
                else
                {
                    MessageBox.Show("Có 1 vài lỗi xảy ra");
                }
            }
        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }
        private void PopulateMonthsComboBox()
        {
            var currentMonth = DateTime.Now.Month;
            for (int month = 1; month <= 12; month++)
            {
                cB_Thang.Items.Add(new ComboBoxItem { Text = month.ToString(), Value = month });
            }

        }
        private void PopulateYearsComboBox()
        {
            var currentYear = DateTime.Now.Year;
            for (int year = currentYear; year >= currentYear - 5; year--)
            {
                cB_Nam.Items.Add(new ComboBoxItem { Text = year.ToString(), Value = year });
            }
        }

        private void tB_TongTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_NumberInput_KeyPress(sender, e);
        }
        private DataTable GetFilteredData( decimal? tongTienTu, decimal? tongTienDen, int? thang, int? nam, string phong)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"SELECT hd.MaHoaDon, hd.MaPhong, hd.NguoiLap, hd.NgayLapHoaDon, hd.HanHoaDon, hd.SoTienThanhToan, tt.TenTrangThai
                    FROM HoaDon hd JOIN TrangThaiHoaDon tt ON hd.MaTrangThaiHoaDon = tt.MaTrangThai WHERE 1=1";
                if (tongTienTu.HasValue)
                    query += " AND SoTienThanhToan >= @TongTienTu";
                if (tongTienDen.HasValue)
                    query += " AND SoTienThanhToan <= @TongTienDen";
                if (thang.HasValue)
                    query += " AND MONTH(NgayLapHoaDon) = @Thang";
                if (nam.HasValue)
                    query += " AND YEAR(NgayLapHoaDon) = @Nam";
                if (!string.IsNullOrEmpty(phong))
                    query += " AND MaPhong = @Phong";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (tongTienTu.HasValue)
                    {
                        Console.WriteLine("Check query:  " + tongTienTu);
                        cmd.Parameters.AddWithValue("@TongTienTu", tongTienTu.Value);
                    }
                        
                    if (tongTienDen.HasValue)
                        cmd.Parameters.AddWithValue("@TongTienDen", tongTienDen.Value);
                    if (thang.HasValue)
                        cmd.Parameters.AddWithValue("@Thang", thang.Value);
                    if (nam.HasValue)
                        cmd.Parameters.AddWithValue("@Nam", nam.Value);
                    if (!string.IsNullOrEmpty(phong))
                    {
                        Console.WriteLine("Check query:  " + phong);
                        cmd.Parameters.AddWithValue("@Phong", phong);
                    }
                    Console.WriteLine("Check query:  " + query);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            decimal? tongTienTu = string.IsNullOrEmpty(tB_TongTienMin.Text) ? (decimal?)null : Convert.ToDecimal(tB_TongTienMin.Text);
            decimal? tongTienDen = string.IsNullOrEmpty(tB_TongTienMax.Text) ? (decimal?)null : Convert.ToDecimal(tB_TongTienMax.Text);
            int? thang = cB_Thang.SelectedValue != null ? Convert.ToInt32(cB_Thang.SelectedValue) : (int?)null;
            int? nam = cB_Nam.SelectedValue != null ? Convert.ToInt32(cB_Nam.SelectedValue) : (int?)null;
            string phong = cB_Phong.SelectedValue?.ToString();

            DataTable dt = GetFilteredData(tongTienTu, tongTienDen, thang, nam, phong);
            Console.WriteLine("Check dt " + dt);
            dGV_dsHoaDon.DataSource = dt;
        }

        private void xemChiTietToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dGV_dsHoaDon.CurrentRow.Index;
            var maHoaDon = dGV_dsHoaDon.Rows[selectedRowIndex].Cells["MaHoaDon"].Value.ToString();
            MessageBox.Show("xem chi tiết, sửa hóa đơn: " + maHoaDon);
            FormXemChiTietHoaDon f = new FormXemChiTietHoaDon(maHoaDon);
            f.Show();
        }

        private void suaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dGV_dsHoaDon.CurrentRow.Index;
            var maHoaDon = dGV_dsHoaDon.Rows[selectedRowIndex].Cells["MaHoaDon"].Value.ToString();
            MessageBox.Show("sửa hóa đơn: " + maHoaDon);
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dGV_dsHoaDon.CurrentRow.Index;
            var maHoaDon = dGV_dsHoaDon.Rows[selectedRowIndex].Cells["MaHoaDon"].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Thực hiện xóa hóa đơn
            }
        }
    }
}
