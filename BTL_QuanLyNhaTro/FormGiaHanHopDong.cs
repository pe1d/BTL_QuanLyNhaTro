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
using static BTL_QuanLyNhaTro.FunctionAll;
using static BTL_QuanLyNhaTro.FormThemHopDong;
namespace BTL_QuanLyNhaTro
{
    public partial class FormGiaHanHopDong : Form
    {
        string ma;
        public FormGiaHanHopDong(string maHopDong)
        {
            InitializeComponent();
            ma = maHopDong;
            LoadDataDetail(maHopDong);
            LoadCBThoiGianThue();
        }
        public void LoadDataDetail(string maHopDong)
        {
            SqlCommand cmd = new SqlCommand("Select * from HopDong where MaHopDong = @MaHopDong");
            cmd.Parameters.AddWithValue("@MaHopDong", maHopDong);
            DataTable dt = GetData(cmd);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                date_NgayBatDau.Value = DateTime.Parse(row["NgayBatDau"].ToString());
                date_NgayKetThuc.Value = DateTime.Parse(row["NgayKetThuc"].ToString());
            }
        }
        public void LoadCBThoiGianThue()
        {
            cB_GiaHan.Items.Add(new TimeRental { DisplayName = "1 tháng", Months = 1 });
            cB_GiaHan.Items.Add(new TimeRental { DisplayName = "3 tháng", Months = 3 });
            cB_GiaHan.Items.Add(new TimeRental { DisplayName = "6 tháng", Months = 6 });
            cB_GiaHan.Items.Add(new TimeRental { DisplayName = "12 tháng", Months = 12 });
            cB_GiaHan.Items.Add(new TimeRental { DisplayName = "24 tháng", Months = 24 });
            cB_GiaHan.Items.Add(new TimeRental { DisplayName = "36 tháng", Months = 36 });
            cB_GiaHan.SelectedIndexChanged += CB_GiaHan_SelectedIndexChanged; ;
        }

        private void CB_GiaHan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_GiaHan.SelectedItem is TimeRental selectedTimeRental)
            {
                MessageBox.Show(date_NgayKetThuc.Value.AddMonths(selectedTimeRental.Months).ToString());
            }
        }

        private void btn_XacNhan_Click(object sender, EventArgs e)
        {
            if (cB_GiaHan.SelectedItem is TimeRental selectedTimeRental)
            {
                DateTime newEndDate = date_NgayKetThuc.Value.AddMonths(selectedTimeRental.Months);
                SqlCommand cmd = new SqlCommand(
                        "UPDATE HopDong SET NgayKetThuc = @NewEndDate WHERE MaHopDong = @MaHopDong"
                    );
                cmd.Parameters.AddWithValue("@NewEndDate", newEndDate);
                cmd.Parameters.AddWithValue("@MaHopDong", ma);
                try
                {
                    ExecuteNonQuery(cmd);
                    MessageBox.Show("Gia hạn thành công!");
                    this.Close();
                }
                catch(Exception er)
                {
                    MessageBox.Show("Gia hạn thất bại!"+ er.ToString());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn ngày gia hạn!");
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
