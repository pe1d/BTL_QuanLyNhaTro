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
using static BTL_QuanLyNhaTro.FormDSHoaDon;
using static BTL_QuanLyNhaTro.FunctionAll;

namespace BTL_QuanLyNhaTro
{
    public partial class FormBaoCaoDoanhThu : Form
    {
        SqlCommand getAllCT = new SqlCommand("select * from ChuTro");
        SqlCommand getChutroID = new SqlCommand("select * from Chutro where MaChuTro = '" + User.UserID + "'");
        public FormBaoCaoDoanhThu()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            if(User.RoleID == 3)
            {
                LoadDataToComboBox(getAllCT, cbChuTro);
            }
            if (User.RoleID == 2)
            {
                LoadDataToComboBox(getChutroID, cbChuTro);
                cbChuTro.Enabled = false;
            }
            PopulateMonthsComboBox();
            PopulateYearsComboBox();
        }
        private void PopulateMonthsComboBox()
        {
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
        private bool ValidateReportSelection()
        {
            if (cB_Thang.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn tháng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cB_Nam.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn năm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void btn_BaoCao_Click(object sender, EventArgs e)
        {
            string query;
            if (chB_All.Checked)
            {
                query = @"SELECT SUM(hd.SoTienThanhToan) AS TotalAmount 
                       FROM HoaDon hd 
                       JOIN Phong p ON hd.MaPhong = p.MaPhong 
                       WHERE p.MaChuTro = @MaChuTro";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@MaChuTro", cbChuTro.SelectedValue);
                decimal tong = GetTotalAmountByLandlord(cmd);
                if (tong > 0)
                {
                    //Hiện báo cáo
                    FormBaoCaoDoanhThuChiTiet f = new FormBaoCaoDoanhThuChiTiet(tong,cbChuTro.Text,0,0);
                    f.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không có doanh thu cho chủ trọ này!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            else
            {
                if (ValidateReportSelection()) {
                    int month = ((ComboBoxItem)cB_Thang.SelectedItem).Value;
                    int year = ((ComboBoxItem)cB_Nam.SelectedItem).Value;
                    query = @"SELECT SUM(hd.SoTienThanhToan) AS TotalAmount 
                       FROM HoaDon hd 
                       JOIN Phong p ON hd.MaPhong = p.MaPhong 
                       WHERE p.MaChuTro = @MaChuTro and MONTH(NgayLapHoaDon) = @Month and  YEAR(NgayLapHoaDon) = @Year";
                    SqlCommand cmd = new SqlCommand(query);
                    cmd.Parameters.AddWithValue("@MaChuTro", cbChuTro.SelectedValue);
                    cmd.Parameters.AddWithValue("@Month", month);
                    cmd.Parameters.AddWithValue("@Year", year);
                    decimal tong = GetTotalAmountByLandlord(cmd);
                    if (tong > 0)
                    {
                        FormBaoCaoDoanhThuChiTiet f = new FormBaoCaoDoanhThuChiTiet(tong, cbChuTro.Text, month, year);
                        f.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Không có doanh thu cho chủ trọ này trong tháng năm trên!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                    
                }
                else
                {
                    return;
                }
            }
        }
        private decimal GetTotalAmountByLandlord(SqlCommand query)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {             
                try
                {
                    conn.Open();
                    query.Connection = conn;
                    object result = query.ExecuteScalar();
                    return result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chB_All.Checked)
            {
                cB_Nam.SelectedIndex = -1;
                cB_Thang.SelectedIndex = -1;
                cB_Nam.Enabled = false;
                cB_Thang.Enabled = false;
            }
            else
            {
                cB_Nam.Enabled = true;
                cB_Thang.Enabled = true;
            }
        }
    }
}
