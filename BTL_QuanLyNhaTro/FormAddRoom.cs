using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BTL_QuanLyNhaTro.FunctionAll;
namespace BTL_QuanLyNhaTro
{
    public partial class FormAddRoom : Form
    {

        public static string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;

        public FormAddRoom()
        {
            InitializeComponent();
        }
        private void AddPhong()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("AddPhong", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters
                        cmd.Parameters.AddWithValue("@MaPhong", textBoxRoomCode.Text);
                        cmd.Parameters.AddWithValue("@TenPhong", textBoxRoomName.Text);
                        //cmd.Parameters.AddWithValue("@MaChuTro", textBoxOwnerCode.Text);
                        cmd.Parameters.AddWithValue("@SoPhong", textBoxRoomNumber.Text);
                        cmd.Parameters.AddWithValue("@DienTich", float.Parse(textBoxAreaPrice.Text));
                        cmd.Parameters.AddWithValue("@Tang", int.Parse(textBoxFloor.Text));
                        cmd.Parameters.AddWithValue("@GiaThue", float.Parse(textBoxRentPrice.Text));
                        //cmd.Parameters.AddWithValue("@MaTrangThai", textBoxStatusCode.Text);
                        //cmd.Parameters.AddWithValue("@DiaChi", textBoxAddress.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        // Display result
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Thêm phòng thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Thêm phòng thất bại.");
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddPhong();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void textBoxRentPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFloor_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_NumberInput_KeyPress(sender, e);
        }
    }
}
