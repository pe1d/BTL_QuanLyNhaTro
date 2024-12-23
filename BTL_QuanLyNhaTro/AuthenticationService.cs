﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using static BTL_QuanLyNhaTro.FunctionAll;
using System.Windows.Forms;

namespace BTL_QuanLyNhaTro
{
    public class AuthenticationService
    {
        public class User
        {
            public static string UserID { get; set; }
            public static string Username { get; set; }
            public static int RoleID { get; set; }
            public static string Pass { get; set; }
        }
        public static void Authenticate(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @Username AND MatKhau = @Password";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //MessageBox.Show(reader["MaTaiKhoan"].ToString());
                            User.UserID = reader["MaTaiKhoan"].ToString();
                            User.Username = reader["TenDangNhap"].ToString();
                            User.RoleID = int.Parse(reader["MaVaiTro"].ToString());
                            User.Pass = reader["MatKhau"].ToString();
                        }
                    }
                }
            }
        }
        public static void Logout()
        {
            // Xóa thông tin đăng nhập của người dùng
            User.UserID = null;
            User.Username = null;
            User.RoleID = 0;

            // Có thể thêm logic để chuyển hướng người dùng về màn hình đăng nhập
            MessageBox.Show("Đăng xuất thành công!");
        }
    }   
    
}



