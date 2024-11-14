using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyNhaTro
{
    public partial class FormReportBaoCao : Form
    {
        public FormReportBaoCao(DataTable dt,decimal tong, string TenChuTro, int Thang, int Nam)
        {
            InitializeComponent();
            ReportDocument reportDoc = new ReportDocument();
            reportDoc.Load(@"D:\Study\HocKyI-Nam2024-2025\HSK\BTL\Code\BTL_QuanLyNhaTro\BTL_QuanLyNhaTro\BaoCaoDoanhThu.rpt");
            reportDoc.SetDataSource(dt);
            reportDoc.SetParameterValue("Tong", tong);
            if(Thang != 0)
            {
                reportDoc.SetParameterValue("Thang", Thang);
                reportDoc.SetParameterValue("Nam", Nam);
            }
            else
            {
                reportDoc.SetParameterValue("Thang", "Tất cả");
                reportDoc.SetParameterValue("Nam", "Tất cả");
            }   
            reportDoc.SetParameterValue("TenChuTro", TenChuTro);
            cRV_baoCao.ReportSource = reportDoc;
            cRV_baoCao.Refresh();
        }
    }
}
