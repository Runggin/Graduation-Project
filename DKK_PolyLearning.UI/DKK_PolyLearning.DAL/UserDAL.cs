using System;
using System.Data.SqlClient;
using DKK_PolyLearning.DTO;

namespace DKK_PolyLearning.DAL
{
    public class UserDAL
    {
        private readonly string connectionString = "Data Source=phamkhoa;Initial Catalog=DKK_Education;Integrated Security=True;";


        public UserDAL()
        {

        }

        public User loginUser(string TenDN, string MatKhau)
        {
            User user = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT TenDN, MatKhau, VaiTro FROM TaiKhoan WHERE TenDN = @TenDN AND MatKhau = @MatKhau";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TenDN", TenDN);
                        command.Parameters.AddWithValue("@MatKhau", MatKhau);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                user = new User
                                {
                                    TenDN = reader["TenDN"].ToString(),
                                    MatKhau = reader["MatKhau"].ToString(), // Không nên trả về mật khẩu từ DB
                                    VaiTro = reader["VaiTro"].ToString()
                                };
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Lỗi đăng nhập:  {ex.Message}");
                    user = null;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Lỗi không xác định khi đăng nhập: {ex.Message}");
                }

            }
            return user;
        }

    }
}