using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Backend.Models;
using Backend.Repositories.Interfaces;

namespace Backend.Repositories.Impelementations
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;

        public UserRepository(IConfiguration configuration)
        {
            _connectionString =
                configuration.GetConnectionString("DefaultConnection");
        }

        public List<User> GetAllUsers()
        {
            List<User> users = new();

            SqlConnection con =
                new SqlConnection(_connectionString);

            con.Open();

            string sql =
                "SELECT UserId, UserName, Email FROM Users";

            SqlCommand cmd =
                new SqlCommand(sql, con);

            SqlDataReader reader =
                cmd.ExecuteReader();

            while (reader.Read())
            {
                users.Add(new User
                {
                    UserId = Convert.ToInt32(reader["UserId"]),
                    UserName = reader["UserName"].ToString(),
                    Email = reader["Email"].ToString()
                });
            }
            con.Close();
            return users;
        }
    }
}