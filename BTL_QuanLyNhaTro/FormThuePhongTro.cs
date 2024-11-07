using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using static BTL_QuanLyNhaTro.FunctionAll;

namespace BTL_QuanLyNhaTro
{
    public partial class FormThuePhongTro : Form
    {
        public FormThuePhongTro()
        {
            InitializeComponent();
            AutoResizeDataGridView(dGV_PhongTro);
            dGV_PhongTro.CellMouseDown += DataGridView_CellMouseDown;
            LoadPhongTro();
            SetPlaceholderText(tb_GiaMin, "Giá tối thiểu");
            SetPlaceholderText(tb_GiaMax, "Giá tối đa");
            SetPlaceholderText(tb_DienTichMin, "Diện tích tối thiểu");
            SetPlaceholderText(tb_DienTichMax, "Diện tích tối đa");
            SetPlaceholderText(tb_Tang, "Tầng");
        }

        private void LoadPhongTro()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Phong WHERE MaTrangThai = '3'");
            DataTable dt = GetData(cmd);
            dGV_PhongTro.DataSource = dt;
        }

        private void FilterPhongTro()
        {
            string query = "SELECT * FROM Phong WHERE MaTrangThai = '3'";

            if (!string.IsNullOrEmpty(tb_GiaMin.Text) && tb_GiaMin.ForeColor != SystemColors.GrayText)
            {
                query += " AND GiaThue >= @GiaMin";
            }

            if (!string.IsNullOrEmpty(tb_GiaMax.Text) && tb_GiaMax.ForeColor != SystemColors.GrayText)
            {
                query += " AND GiaThue <= @GiaMax";
            }

            if (!string.IsNullOrEmpty(tb_DienTichMin.Text) && tb_DienTichMin.ForeColor != SystemColors.GrayText)
            {
                query += " AND DienTich >= @DienTichMin";
            }

            if (!string.IsNullOrEmpty(tb_DienTichMax.Text) && tb_DienTichMax.ForeColor != SystemColors.GrayText)
            {
                query += " AND DienTich <= @DienTichMax";
            }

            if (!string.IsNullOrEmpty(tb_Tang.Text) && tb_Tang.ForeColor != SystemColors.GrayText)
            {
                query += " AND Tang = @Tang";
            }

            SqlCommand cmd = new SqlCommand(query);

            if (!string.IsNullOrEmpty(tb_GiaMin.Text) && tb_GiaMin.ForeColor != SystemColors.GrayText)
            {
                cmd.Parameters.AddWithValue("@GiaMin", tb_GiaMin.Text);
            }

            if (!string.IsNullOrEmpty(tb_GiaMax.Text) && tb_GiaMax.ForeColor != SystemColors.GrayText)
            {
                cmd.Parameters.AddWithValue("@GiaMax", tb_GiaMax.Text);
            }

            if (!string.IsNullOrEmpty(tb_DienTichMin.Text) && tb_DienTichMin.ForeColor != SystemColors.GrayText)
            {
                cmd.Parameters.AddWithValue("@DienTichMin", tb_DienTichMin.Text);
            }

            if (!string.IsNullOrEmpty(tb_DienTichMax.Text) && tb_DienTichMax.ForeColor != SystemColors.GrayText)
            {
                cmd.Parameters.AddWithValue("@DienTichMax", tb_DienTichMax.Text);
            }

            if (!string.IsNullOrEmpty(tb_Tang.Text) && tb_Tang.ForeColor != SystemColors.GrayText)
            {
                cmd.Parameters.AddWithValue("@Tang", tb_Tang.Text);
            }

            DataTable dt = GetData(cmd);
            dGV_PhongTro.DataSource = dt;
        }

        private void DataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dGV_PhongTro.ClearSelection();
                dGV_PhongTro.Rows[e.RowIndex].Selected = true;
                dGV_PhongTro.CurrentCell = dGV_PhongTro.Rows[e.RowIndex].Cells[0];
            }
        }

        private void ThuePhongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dGV_PhongTro.CurrentRow.Index;
            var maPhong = dGV_PhongTro.Rows[selectedRowIndex].Cells["MaPhong"].Value.ToString();
            FormThemHopDong formThemHopDong = new FormThemHopDong(maPhong);
            formThemHopDong.ShowDialog();
            LoadPhongTro(); // Tải lại danh sách phòng sau khi thêm hợp đồng
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            FilterPhongTro();
        }

        private void SetPlaceholderText(TextBox textBox, string placeholder)
        {
            textBox.ForeColor = SystemColors.GrayText;
            textBox.Text = placeholder;
            textBox.Enter += (sender, e) => {
                if (textBox.ForeColor == SystemColors.GrayText)
                {
                    textBox.ForeColor = SystemColors.WindowText;
                    textBox.Text = "";
                }
            };
            textBox.Leave += (sender, e) => {
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.ForeColor = SystemColors.GrayText;
                    textBox.Text = placeholder;
                }
            };
        }
    }
}
