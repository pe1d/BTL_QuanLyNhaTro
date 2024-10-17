using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using static BTL_QuanLyNhaTro.FunctionAll;
namespace BTL_QuanLyNhaTro
{
    public class AuthenticationService
    {
        public class User
        {
            public string UserID { get; set; }
            public string Username { get; set; }
            public int RoleID { get; set; }
        }
        public User Authenticate(string username, string password)
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
                            return new User
                            {
                                UserID = reader["MaTaiKhoan"].ToString(),
                                Username = reader["TenDangNhap"].ToString(),
                                RoleID = int.Parse(reader["MaVaiTro"].ToString()),
                            };
                        }
                    }
                }
            }
            return null;
        }


    }   
    
}



