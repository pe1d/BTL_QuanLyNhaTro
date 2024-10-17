using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static BTL_QuanLyNhaTro.FunctionAll;
using static BTL_QuanLyNhaTro.AuthenticationService;

namespace BTL_QuanLyNhaTro
{
    public partial class FormThemHoaDon : Form
    {
        private SqlCommand cmdSDichVU = new SqlCommand("Select * from DichVu");
        private SqlCommand cmdSChuTro = new SqlCommand("Select * from ChuTro where MaChuTro = '" + User.UserID+"'");
        private SqlCommand cmdSPhongCT = new SqlCommand("Select * from Phong where MaTrangThai = '3' AND MaChuTro = '" + User.UserID + "'");
        private SqlCommand cmdSPhongAll = new SqlCommand("Select * from Phong where MaTrangThai = '3'");
        private List<Control[]> serviceRows = new List<Control[]>();
        public FormThemHoaDon()
        {
            InitializeComponent();
        }

        private void FormThemHoaDon_Load(object sender, EventArgs e)
        {
            if (User.RoleID == 3)
            {
                tb_NguoiLap.Text = "ADMIN";
                LoadDataToComboBox(cmdSPhongAll, cb_Phong);
            }
            if(User.RoleID == 2)
            {
                DataTable dt = GetData(cmdSChuTro);
                DataRow dr = dt.Rows[0];
                if(dr["TenChuTro"].ToString() != null)
                {
                    tb_NguoiLap.Text = dr["TenChuTro"].ToString();
                    tb_NguoiLap.ReadOnly = true;
                    tb_Khach.ReadOnly = true;
                    tb_GiaPhong.ReadOnly = true;
                    DataTable dtPhong = GetData(cmdSPhongCT);
                    if(dtPhong != null)
                    {
                        LoadDataToComboBox(cmdSPhongCT, cb_Phong);
                    }
                    else
                    {
                        MessageBox.Show("Không còn phòng trống");
                    }
                    
                }
            }
        }

        private void addSerHD_Click(object sender, EventArgs e)
        {
            ThemDongMoi();
        }

        private void ThemDongMoi()
        {
            // Tạo các TextBox mới cho dòng mới
            if(dem > 4)
            {
                MessageBox.Show("Chỉ thêm được tối đa 5 dịch vụ");
                return;
            }
            ComboBox cbDichVu = new ComboBox();
            TextBox txtDonGia = new TextBox();
            TextBox txtDonVi = new TextBox();
            NumericUpDown numSoLuong = new NumericUpDown();
            TextBox txtThanhTien = new TextBox();
            Button btnDelete = new Button();
            // Đặt vị trí và kích thước cho các TextBox mới
            cbDichVu.Location = new Point(62, yPosition);
            txtDonGia.Location = new Point(189, yPosition);
            txtDonVi.Location = new Point(292, yPosition);
            numSoLuong.Location = new Point(347, yPosition);
            txtThanhTien.Location = new Point(415, yPosition);
            btnDelete.Location = new Point(536, yPosition);
            // Đặt kich thước
            cbDichVu.Size = new Size(121, 20);
            txtDonGia.Size = new Size(97, 20);
            txtDonVi.Size = new Size(49, 20);
            numSoLuong.Size = new Size(62, 20);
            txtThanhTien.Size = new Size(111, 20);
            btnDelete.Size = new Size(50, 20);
            txtDonVi.ReadOnly = true;
            txtDonGia.ReadOnly = true;
            //Khởi tạo giá trị
            btnDelete.Text = "Xóa";
            LoadDataToComboBox(cmdSDichVU, cbDichVu);
            cbDichVu.SelectedIndexChanged += (s, ev) =>
            {
                ComboBox cb = s as ComboBox;
                SqlCommand cmdSDichVuCondition = new SqlCommand("Select * from DichVu where MaDichVu = " + cb.SelectedValue.ToString());
                DataTable dt = GetData(cmdSDichVuCondition);
                //LogDataTable(dt);
                DataRow row = dt.Rows[0];
                if (row == null)
                {
                    txtDonVi.Text = "";
                    txtDonGia.Text = "";
                }
                txtDonVi.Text = row["DonVi"].ToString();
                txtDonGia.Text = row["DonGia"].ToString();
            };
            btnDelete.Click += (s, ev) =>
            {
                Control[] row = serviceRows.Find(r => r[0] == cbDichVu);
                if (row != null)
                {
                    foreach (var control in row)
                    {
                        this.Controls.Remove(control);
                    }
                    serviceRows.Remove(row);
                    UpdateRowPositions();
                    AdjustFormHeight(-25);
                    dem--;
                }
            };
            // Thêm các TextBox mới vào form
            this.Controls.Add(cbDichVu);
            this.Controls.Add(txtDonGia);
            this.Controls.Add(txtDonVi);
            this.Controls.Add(numSoLuong);
            this.Controls.Add(txtThanhTien);
            this.Controls.Add(btnDelete);
            // Tính thành tiền
            numSoLuong.ValueChanged += (s, ev) =>
            {
                if (decimal.TryParse(txtDonGia.Text, out decimal giaTien))
                {
                    txtThanhTien.Text = (giaTien * numSoLuong.Value).ToString();
                }
            };
            // Cập nhật vị trí y cho dòng tiếp theo
            serviceRows.Add(new Control[] { cbDichVu, txtDonGia, txtDonVi, numSoLuong, txtThanhTien, btnDelete });
            yPosition += 25;
            // Cập nhật ví trí cho datagridview và form
            AdjustFormHeight(25);
            dem++;
        }
        // Biến toàn cục để theo dõi vị trí y của dòng mới
        private int yPosition = 245;
        private int dem = 0;
        private void AdjustFormHeight(int change)
        {
            this.ClientSize = new Size(this.ClientSize.Width, this.ClientSize.Height + change);
            dGV_ListHoaDon.Location = new Point(dGV_ListHoaDon.Location.X, dGV_ListHoaDon.Location.Y + change);
            btn_addHoaDon.Location = new Point(btn_addHoaDon.Location.X, btn_addHoaDon.Location.Y + change); ;
        }
        private void cb_Phong_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            SqlCommand cmdSPhongKT = new SqlCommand(@"select * from HopDong 
                                    inner join NguoiThue ON NguoiThue.MaNguoiThue = HopDong.MaNguoiThue
                                    where HopDong.MaPhong = '" + cb.SelectedValue +"'");
            DataTable dt = GetData(cmdSPhongKT);
            if (HasData(dt))
            {
                DataRow dr = dt.Rows[0];
                if (dr["HoTen"].ToString() != null)
                {
                    tb_Khach.Text = dr["HoTen"].ToString();
                    tb_GiaPhong.Text = dr["TongTienThue"].ToString();
                }
                else
                {
                    MessageBox.Show("Có 1 vài lỗi xảy ra");
                }
            }
            
        }
        private void UpdateRowPositions()
        {
            yPosition = 245; // Đặt lại vị trí Y ban đầu
            foreach (var row in serviceRows)
            {
                //MessageBox.Show(yPosition.ToString());
                row[0].Location = new Point(62, yPosition); // cbDichVu
                row[1].Location = new Point(189, yPosition); // txtDonGia
                row[2].Location = new Point(292, yPosition); // txtDonVi
                row[3].Location = new Point(347, yPosition); // numSoLuong
                row[4].Location = new Point(415, yPosition); // txtThanhTien
                row[5].Location = new Point(536, yPosition); // btnDelete
                yPosition += 25;
            }
        }
        private void btn_addHoaDon_Click(object sender, EventArgs e)
        {

        }
    }
}
