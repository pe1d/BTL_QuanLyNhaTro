﻿using System;
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
        public static bool HasData(DataTable table)
        {
            return table != null && table.Rows.Count > 0;
        }
        public static void ExecuteNonQuery(SqlCommand cmd) { 
            using (SqlConnection conn = new SqlConnection(connectionString)) 
            { 
                cmd.Connection = conn; 
                conn.Open(); 
                cmd.ExecuteNonQuery(); 
            } 
        }
        public static void tb_NumberInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only digits, the backspace key, and the decimal point
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void AutoResizeDataGridView(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.AutoResizeColumns();
            dgv.AutoResizeRows();
        }
        public static Boolean CheckDK(SqlCommand cmd, string messageFail, string type)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    cmd.Connection = conn;
                    int count = (int)cmd.ExecuteScalar();
                    if(type.ToUpper() == "HAVE")
                    {
                        if (count > 0)
                        {
                            MessageBox.Show(messageFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return true;
                        }
                        return false;
                    }
                    if (type.ToUpper() == "NOHAVE")
                    {
                        if (count > 0)
                        {
                            return false;
                        }
                        MessageBox.Show(messageFail, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }

                    return false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
