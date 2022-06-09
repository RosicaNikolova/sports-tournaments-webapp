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

        public User GetPlayerById(int userId)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "select firstName, lastName,idUser, email, password from usertournaments where idUser=@idUser and role=@role;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("idUser", userId);
                    cmd.Parameters.AddWithValue("role", Role.Player.ToString());

                    conn.Open();
                    User user = null;
                    MySqlDataReader dateReader = cmd.ExecuteReader();

                    if (dateReader.Read())
                    {
                        user = new User();
                        user.Id = dateReader.GetInt32("idUser");
                        user.FirstName = dateReader.GetString("firstName");
                        user.LastName = dateReader.GetString("lastName");
                        user.Email = dateReader.GetString("email");
                        user.Password = dateReader.GetString("password");
                    }
                    return user;
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }
        public bool CheckIfUserExists(string email)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "select email from usertournaments where @email=email;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("email", email);
                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    if (dateReader.Read())
                    {
                        return false;
                    }
                    return true;
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }

        public void RegisterUser(User user)
        {
            try
            {
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "insert into usertournaments (email, password, firstName, lastName, role) values(@email, @password, @firstName, @lastName, @role);";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("email", user.Email);
                    cmd.Parameters.AddWithValue("password", user.Password);
                    cmd.Parameters.AddWithValue("firstName", user.FirstName);
                    cmd.Parameters.AddWithValue("lastName", user.LastName);
                    cmd.Parameters.AddWithValue("role", user.Role.ToString());

                    conn.Open();

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                throw new DataBaseException();
            }
        }

        public void UpdateUser(User user)
        {
            //try
            //{
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "update usertournaments set email=@email, password=@password, firstName=@firstName, lastName=@lastName where idUser=@idUser;";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("email", user.Email);
                    cmd.Parameters.AddWithValue("password", user.Password);
                    cmd.Parameters.AddWithValue("firstName", user.FirstName);
                    cmd.Parameters.AddWithValue("lastName", user.LastName);
                    cmd.Parameters.AddWithValue("idUser", user.Id);
                    conn.Open();
                    cmd.ExecuteNonQuery();

                }
            //}
            //catch (Exception)
            //{
            //    throw new DataBaseException();
            //}
        }

        public bool CheckIfAnotherUsesWithSameEmail(string email, int userId)
        {
            //try
            //{
                using (MySqlConnection conn = DatabaseConnection.CreateConnection())
                {
                    string sql = "select email from usertournaments where email=@email and idUser NOT in (@idUser);";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("idUser", userId);
                    conn.Open();

                    MySqlDataReader dateReader = cmd.ExecuteReader();
                    if (dateReader.Read())
                    {
                        return false;
                    }
                    return true;
                }
            //}
            //catch (Exception)
            //{
            //    throw new DataBaseException();
            //}
        }
    }
}
