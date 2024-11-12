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
    }
}
