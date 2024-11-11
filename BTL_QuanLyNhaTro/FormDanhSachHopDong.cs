using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BTL_QuanLyNhaTro.FunctionAll;
using static BTL_QuanLyNhaTro.AuthenticationService;
using System.Data.SqlClient;

namespace BTL_QuanLyNhaTro
{
    public partial class FormDanhSachHopDong : Form
    {
        SqlCommand getAllChutro = new SqlCommand("select * from Chutro");
        SqlCommand getAllNT = new SqlCommand("select * from NguoiThue");
        SqlCommand getChutroID = new SqlCommand("select * from Chutro where MaChuTro = '"+User.UserID+"'");
        string queryAll, queryHan;
        public FormDanhSachHopDong()
        {
            InitializeComponent();
            LoadData();
            AutoResizeDataGridView(dataGridView1);
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.CellMouseDown += DataGridView1_CellMouseDown; ;
        }
        private void DataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[0];
            }
        }
        public void LoadData()
        {
            if(User.RoleID == 3)//Admin
            {
                LoadDataToComboBox(getAllChutro,cB_ChuTro);
                LoadDataToComboBox(getAllNT, cB_NguoiThue);
            }
            if (User.RoleID == 2)//Chu tro
            {
                LoadDataToComboBox(getChutroID, cB_ChuTro);
                cB_ChuTro.Enabled = false;
                string query = @"select DISTINCT  hd.MaNguoiThue, nt.HoTen from HopDong hd  
                    join NguoiThue nt on nt.MaNguoiThue = hd.MaNguoiThue
                    where hd.MaChuTro = @MaChuTro";
                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@MaChuTro", User.UserID);
                LoadDataToComboBox(cmd, cB_NguoiThue);
            }
            if (User.RoleID == 1)//Nguoi thue
            {
                string query = @"select DISTINCT  hd.MaChuTro, ct.TenChuTro from HopDong hd  
                    join ChuTro ct on ct.MaChuTro = hd.MaChuTro
                    where hd.MaNguoiThue = @MaNguoiThue";
                string queryCbNT = @"select * from NguoiThue where MaNguoiThue = @MaNguoiThue";
                SqlCommand getChuTroByHDMaNguoiDung = new SqlCommand(query);
                SqlCommand getNguoiThueByHDMaNguoiDung = new SqlCommand(queryCbNT);
                getChuTroByHDMaNguoiDung.Parameters.AddWithValue("@MaNguoiThue", User.UserID);
                getNguoiThueByHDMaNguoiDung.Parameters.AddWithValue("@MaNguoiThue", User.UserID);
                LoadDataToComboBox(getChuTroByHDMaNguoiDung, cB_ChuTro);
                LoadDataToComboBox(getNguoiThueByHDMaNguoiDung, cB_NguoiThue);
                cB_NguoiThue.Enabled = false;
            }
        }

        private void tB_GiaTriHopDong_KeyPress(object sender, KeyPressEventArgs e)
        {
            tb_NumberInput_KeyPress(sender, e);
        }

        private void chB_All_CheckedChanged(object sender, EventArgs e)
        {
            if (ChB_HpDongHetHan.Checked == true && chB_All.Checked == true)
            {
                ChB_HpDongHetHan.Checked = false;
            }
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                if (User.RoleID == 3)//Admin
                {
                    queryAll = "select * from HopDong";
                    return;
                }
                if (User.RoleID == 2)//Chu Tro
                {
                    queryAll = "select * from HopDong where MaChuTro = '" + User.UserID + "'";
                    return;
                }
                else //NguoiThue
                {

                    queryAll = "select * from HopDong where MaNguoiThue = '" + User.UserID + "'";
                    return;
                }
            }

        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            if (chB_All.Checked == true)
            {
                SqlCommand cmd = new SqlCommand(queryAll);
                DataTable dt = GetData(cmd);
                dataGridView1.DataSource = dt;
                return;
            }
            if (ChB_HpDongHetHan.Checked == true)
            {
                SqlCommand cmd = new SqlCommand(queryHan);
                DataTable dt = GetData(cmd);
                dataGridView1.DataSource = dt;
                return;
            }
        }

        private void SuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.CurrentRow.Index;
            var maHopDong = dataGridView1.Rows[selectedRowIndex].Cells["MaHopDong"].Value.ToString();
            MessageBox.Show("Check ma hop dong: "+ maHopDong);
            FormXemChiTietHopDong f = new FormXemChiTietHopDong(maHopDong);
            f.Show();
        }

        private void xoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = dataGridView1.CurrentRow.Index;
            var maHopDong = dataGridView1.Rows[selectedRowIndex].Cells["MaHopDong"].Value.ToString();
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Thực hiện xóa hóa đơn
                MessageBox.Show("Check ma hop dong: "+ maHopDong);
            }
        }

        private void ChB_HpDongHetHan_CheckedChanged(object sender, EventArgs e)
        {
            if(chB_All.Checked == true && ChB_HpDongHetHan.Checked == true)
            {
                chB_All.Checked = false;
            }
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                if (User.RoleID == 3)//Admin
                {
                    queryHan = "select * from HopDong where NgayKetThuc < GETDATE()";
                    return;
                }
                if (User.RoleID == 2)//Chu Tro
                {
                    queryHan = "select * from HopDong where NgayKetThuc < GETDATE() and MaChuTro = '" + User.UserID + "'";
                    return;
                }
                else //NguoiThue
                {

                    queryHan = "select * from HopDong where NgayKetThuc < GETDATE() and MaNguoiThue = '" + User.UserID + "'";
                    return;
                }
            }
            else
            {
                queryHan = "";
            }
            
        }
    }
}
