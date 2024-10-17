using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static BTL_QuanLyNhaTro.FunctionAll;

namespace BTL_QuanLyNhaTro
{
    public partial class FormThemHoaDon : Form
    {
        private SqlCommand cmdSDichVU = new SqlCommand("Select * from DichVu");
        public FormThemHoaDon()
        {
            InitializeComponent();
        }

        private void FormThemHoaDon_Load(object sender, EventArgs e)
        {

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
            txtDonVi.Enabled = false;
            txtDonGia.Enabled = false;
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
                if (dt.Rows[0] == null)
                {
                    txtDonVi.Text = "";
                    txtDonGia.Text = "";
                }
                txtDonVi.Text = row["DonVi"].ToString();
                txtDonGia.Text = row["DonGia"].ToString();
            };
            btnDelete.Click += (s, ev) =>
            {
                this.Controls.Remove(cbDichVu);
                this.Controls.Remove(txtDonGia);
                this.Controls.Remove(txtDonVi);
                this.Controls.Remove(numSoLuong);
                this.Controls.Remove(txtThanhTien);
                this.Controls.Remove(btnDelete);
                yPosition -= 25;
                AdjustFormHeight(-25);
                dem--;
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
        }
    }
}
