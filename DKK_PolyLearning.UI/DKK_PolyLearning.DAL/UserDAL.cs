using System.Data.SqlClient;
using DKK_PolyLearning.DTO;

namespace DKK_PolyLearning.DAL
{
    public class UserDAL
    {
        private readonly string connectionString = "Data Source=maycuabo;Initial Catalog=DKK_PolyLearning;Integrated Security=True;Trust Server Certificate=True";

        public bool RegisterUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Users (Username, Password, FullName, Email, Role) VALUES (@Username, @Password, @FullName, @Email, @Role)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@Password", user.Password);
                    cmd.Parameters.AddWithValue("@FullName", user.FullName);
                    cmd.Parameters.AddWithValue("@Email", user.Email);
                    cmd.Parameters.AddWithValue("@Role", user.Role);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}