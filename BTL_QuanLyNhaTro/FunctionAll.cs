using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace BTL_QuanLyNhaTro
{
    class FunctionAll
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["MyDatabaseConnection"].ConnectionString;
        public static SqlConnection cnn = new SqlConnection(connectionString); 
        public static DataTable GetData(SqlCommand cmd)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = cnn;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            { 
                MessageBox.Show(e.Message);
            }
            return dt;
        }
        public static void LoadDataToComboBox(SqlCommand cmd, ComboBox cbb)
        {
            DataTable dt = GetData(cmd);
            cbb.DataSource = dt;
            cbb.ValueMember = dt.Columns[0].ColumnName;
            cbb.DisplayMember = dt.Columns[1].ColumnName;
        }
    }

}
