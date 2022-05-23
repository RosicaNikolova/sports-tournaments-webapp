using ClassLibraryTournaments.Business;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryTournaments.Persistence
{
    public class UserRepository : IUserRepository
    {
        public User FindUser(string email, string password)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())

                {
                    string sql = "select idUser, email, password, firstName, lastName, role from usertournaments where @email=email and @password=password;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("password", password);
                    conn.Open();
                    User user = null;
                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    if (dateReader.Read())
                    {
                        user = new User();
                        user.Id = dateReader.GetInt32("idUser");
                        user.Email = dateReader.GetString("email");
                        user.FirstName = dateReader.GetString("firstName");
                        user.LastName = dateReader.GetString("lastName");
                        user.Password = dateReader.GetString("password");
                        user.Role = (Role)Enum.Parse(typeof(Role), dateReader.GetString("role"), true);
                    }
                    return user;
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }
    }
}
