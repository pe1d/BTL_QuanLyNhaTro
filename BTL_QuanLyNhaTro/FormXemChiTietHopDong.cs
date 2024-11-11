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
    public partial class FormXemChiTietHopDong : Form
    {
        private string maHopDong;
        public FormXemChiTietHopDong(string maHopDong)
        {
            this.maHopDong = maHopDong;
            InitializeComponent();
            loadHopDongDetail();
        }
        private void loadHopDongDetail()
        {
            string query = @"select hd.*, ct.TenChuTro, nt.HoTen from HopDong hd 
                            JOIN ChuTro ct On ct.MaChuTro = hd.MaChuTro
                            JOIN NguoiThue nt On nt.MaNguoiThue = hd.MaNguoiThue
                            Where hd.MaHopDong = @MaHopDong";
            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@MaHopDong", maHopDong);
            DataTable dt = GetData(cmd);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                tb_MaHopDOng.Text = row["MaHopDong"].ToString();
                tB_TenChuTro.Text = row["TenChuTro"].ToString();
                tB_TenNguoiThue.Text = row["HoTen"].ToString();
                tB_TenPhong.Text = row["MaPhong"].ToString();
                tB_GiaPhong.Text = row["TongTienThue"].ToString();
                date_Lap.Value = DateTime.Parse(row["NgayLapHopDong"].ToString());
                date_BatDau.Value = DateTime.Parse(row["NgayBatDau"].ToString());
                date_KetThuc.Value = DateTime.Parse(row["NgayKetThuc"].ToString());
            }
        }

        private void btn_GiaHan_Click(object sender, EventArgs e)
        {
            FormGiaHanHopDong f = new FormGiaHanHopDong(maHopDong);
            f.ShowDialog();
        }
    }
}
