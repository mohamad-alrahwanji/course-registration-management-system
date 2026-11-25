using CourseRegistration.Entities;
using Framework.Common;
using Microsoft.Data.SqlClient;

namespace CourseRegistration.DAL.DataProviders
{
    internal static class UserDataProvider
    {
        internal static List<User> GetAll()
        {
            List<User> users = new List<User>();

            using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
            connection.Open();

            using SqlCommand command = new("Select Id, Username, FullName, Role, IsActive From Users", connection);
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                User user = new User
                {
                    Id = (int)reader["Id"],
                    Username = (string)reader["Username"],
                    FullName = (string)reader["FullName"],
                    Role = (string)reader["Role"],
                    IsActive = (bool)reader["IsActive"]
                };

                users.Add(user);
            }

            return users;
        }

        internal static bool Add(User user)
        {
            using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
            connection.Open();

            using SqlCommand command = new("Insert into Users (Username, FullName, PasswordHash, Role, IsActive) " +
                "Values(@Username, @FullName, @PasswordHash, @Role, @IsActive)", connection);

            command.Parameters.AddWithValue("@Username", user.Username);
            command.Parameters.AddWithValue("@FullName", user.FullName);
            command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
            command.Parameters.AddWithValue("@Role", user.Role);
            command.Parameters.AddWithValue("@IsActive", user.IsActive);

            return command.ExecuteNonQuery() == 1;
        }

        internal static bool UsernameExists(string username)
        {
            using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
            connection.Open();

            using SqlCommand command = new("Select Count(*) from Users where Username = @Username", connection);

            command.Parameters.AddWithValue("@Username", username);

            return Convert.ToInt32(command.ExecuteScalar()) == 1;
        }

        internal static bool Edit(User user, bool passwordChanged)
        {
            using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
            connection.Open();

            string sqlQuery = "Update Users Set " +
                "Username = @Username, FullName = @FullName, Role = @Role, IsActive = @IsActive";

            if(passwordChanged)
            {
                sqlQuery += ", PasswordHash = @PasswordHash";
            }

            sqlQuery += " Where Id = @Id";

            using SqlCommand command = new(sqlQuery, connection);

            command.Parameters.AddWithValue("@Username", user.Username);
            command.Parameters.AddWithValue("@FullName", user.FullName);
            command.Parameters.AddWithValue("@Role", user.Role);
            command.Parameters.AddWithValue("@IsActive", user.IsActive);
            command.Parameters.AddWithValue("@Id", user.Id);

            if(passwordChanged)
            {
                command.Parameters.AddWithValue("@PasswordHash", user.PasswordHash);
            }

            return command.ExecuteNonQuery() == 1;
        }

        internal static bool UsernameExists(string username, int excludedUserId)
        {
            using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
            connection.Open();

            using SqlCommand command = new("Select Count(*) From Users Where Username = @Username AND Id <> @Id", connection);

            command.Parameters.AddWithValue("@Username", username);
            command.Parameters.AddWithValue("@Id", excludedUserId);

            return Convert.ToInt32(command.ExecuteScalar()) > 0;
        }

        internal static bool Delete(int userId)
        {
            using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
            connection.Open();

            using SqlCommand command = new("Delete From Users Where Id = @Id", connection);
            command.Parameters.AddWithValue("@Id", userId);

            return command.ExecuteNonQuery() == 1;
        }

        internal static List<User> Search(string searchText)
        {
            List<User> users = new List<User>();

            using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
            connection.Open();

            using SqlCommand command = new("Select Id, Username, FullName, Role, IsActive From Users " +
                "Where Username Like @Search Or FullName Like @Search", connection);

            command.Parameters.AddWithValue("@Search", $"%{searchText}%");
            using SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                User user = new User
                {
                    Id = (int)reader["Id"],
                    Username = (string)reader["Username"],
                    FullName = (string)reader["FullName"],
                    Role = (string)reader["Role"],
                    IsActive = (bool)reader["IsActive"]
                };

                users.Add(user);
            }

            return users;
        }

        internal static User? GetByUsername(string username)
        {
            using SqlConnection connection = new(SQLServerHelper.DbConnectionString);
            connection.Open();

            using SqlCommand command = new("Select Id, Username, PasswordHash, FullName, Role, IsActive From Users " +
                "Where Username = @Username", connection);

            command.Parameters.AddWithValue("@Username", username);

            using SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                User user = new User
                {
                    Id = (int)reader["Id"],
                    Username = (string)reader["Username"],
                    PasswordHash = (string)reader["PasswordHash"],
                    FullName = (string)reader["FullName"],
                    Role = (string)reader["Role"],
                    IsActive = (bool)reader["IsActive"]
                };

                return user;
            }

            return null;
            
        }
    }
}
