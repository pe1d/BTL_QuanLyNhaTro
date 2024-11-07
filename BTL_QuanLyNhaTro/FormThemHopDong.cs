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
    public partial class FormThemHopDong : Form
    {
        private SqlCommand cmdSPhongCT = new SqlCommand("Select * from Phong where MaTrangThai = '1' AND MaChuTro = '" + User.UserID + "'");
        private SqlCommand cmdSPhongAll = new SqlCommand("Select * from Phong where MaTrangThai = '1'");
        private SqlCommand cmdSChuTro = new SqlCommand("Select * from ChuTro where MaChuTro = '" + User.UserID + "'");
        private SqlCommand cmdSChuTroAll = new SqlCommand("Select * from ChuTro");
        private SqlCommand cmdSKhachThueAll = new SqlCommand("Select * from NguoiThue ");
        public class TimeRental
        {
            public string DisplayName { get; set; }  // Hiển thị
            public int Months { get; set; }          // Số tháng

            // Để hiển thị "DisplayName" trong ComboBox
            public override string ToString()
            {
                return DisplayName;
            }
        }
        public void LoadCBThoiGianThue()
        {
            cB_ThoiGianThue.Items.Add(new TimeRental { DisplayName = "1 tháng", Months = 1 });
            cB_ThoiGianThue.Items.Add(new TimeRental { DisplayName = "3 tháng", Months = 3 });
            cB_ThoiGianThue.Items.Add(new TimeRental { DisplayName = "6 tháng", Months = 6 });
            cB_ThoiGianThue.Items.Add(new TimeRental { DisplayName = "12 tháng", Months = 12 });
            cB_ThoiGianThue.Items.Add(new TimeRental { DisplayName = "24 tháng", Months = 24 });
            cB_ThoiGianThue.Items.Add(new TimeRental { DisplayName = "36 tháng", Months = 36 });
            cB_ThoiGianThue.SelectedIndexChanged += CB_ThoiGianThue_SelectedIndexChanged;
        }

        private void CB_ThoiGianThue_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_ThoiGianThue.SelectedItem is TimeRental selectedTimeRental)
            {
                MessageBox.Show(dTP_NgayThue.Value.AddMonths(selectedTimeRental.Months).ToString());
            }
        }

        public FormThemHopDong()
        {
            InitializeComponent();
            tBGiaPhong.ReadOnly = true;
            LoadData();
            LoadCBThoiGianThue();
            cB_ChuTro.SelectedIndexChanged += cB_ChuTro_SelectedIndexChanged;
            dTP_NgayThue.MinDate = DateTime.Now;
        }

        private void LoadData()
        {
            if(User.RoleID == 3)
            {
                LoadDataToComboBox(cmdSChuTroAll, cB_ChuTro);
            }
            if (User.RoleID == 2)
            {
                DataTable dt = GetData(cmdSChuTro);
                DataRow dr = dt.Rows[0];
                if (dr["TenChuTro"].ToString() != null)
                {
                    cB_ChuTro.Text = dr["TenChuTro"].ToString();
                    cB_ChuTro.Enabled = false;
                    DataTable dtPhong = GetData(cmdSPhongCT);
                    if (dtPhong != null)
                    {
                        LoadDataToComboBox(cmdSPhongCT, cB_Phong);
                    }
                    else
                    {
                        MessageBox.Show("Không còn phòng trống");
                    }
                }
            }
            LoadDataToComboBox(cmdSKhachThueAll, cb_KhachThue);
        }

        private void cB_ChuTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cB_ChuTro.SelectedValue != null)
            {
                string queryPhong = @"select * from Phong where MaChuTro = @MaChuTro and MaTrangThai = '1'";
                SqlCommand cmdphong = new SqlCommand(queryPhong);
                cmdphong.Parameters.AddWithValue("@MaChuTro", cB_ChuTro.SelectedValue);
                if (HasData(GetData(cmdphong)))
                {
                    LoadDataToComboBox(cmdphong, cB_Phong);
                    cB_Phong.SelectedIndexChanged += cb_Phong_SelectedIndexChanged;
                }
                else
                {
                    MessageBox.Show("Chủ trọ đã hết phòng");
                    cB_Phong.DataSource = null;
                    tBGiaPhong.Text = null;
                }  
            }
        }
        private void cb_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SqlCommand cmdSPhongKT = new SqlCommand(@"select GiaThue from Phong where MaPhong = '" + cb.SelectedValue + "'");
            DataTable dt = GetData(cmdSPhongKT);
            if (HasData(dt))
            {
                DataRow dr = dt.Rows[0];
                if (dr["GiaThue"].ToString() != null)
                {
                    tBGiaPhong.Text = dr["GiaThue"].ToString();
                }
                else
                {
                    MessageBox.Show("Có 1 vài lỗi xảy ra");
                }
            }
        }
    }
}
